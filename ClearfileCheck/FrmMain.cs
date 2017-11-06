using ClearfileCheckManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Threading;
using System.Resources;
using System.Reflection;

namespace ClearfileCheck
{
    public partial class FrmMain : Form
    {
        Manager _manager = null;


        public FrmMain()
        {
            InitializeComponent();

            Load_Config();
        }

        /// <summary>
        /// 加载界面配置文件
        /// </summary>
        private void Load_Config()
        {
            try
            {
                // 读取xml文件，生产管理manager对象
                _manager = new Manager();

                // 初始化文件源列表
                InitFileSourceInfo();
            }
            catch (XmlException ex)
            {
                Print_Error_Message("请检查cfg.xml格式是否正确! " + ex.Message);
            }
            catch (Exception ex)
            {
                Print_Error_Message(ex.Message);
            }
        }


        private void Print_Error_Message(string message)
        {
            tbError.Text = string.Format("{0}:{1}", DateTime.Now.ToString("HH:mm:ss"), message) + System.Environment.NewLine + tbError.Text;
        }


        private void btnExecute_Click(object sender, EventArgs e)
        {
            /* 1.循环FileSource列表
             * 2.每一个FileSource，判断所有标志文件是否到
             * 3.如果到齐，获取文件列表
             * 4.文件复制，
             * 5.文件md5判断
             */


            if (!bgWorker.IsBusy)
            {
                lbStatus.Text = "执行中...";
                btnExecute.Text = "点击停止";

                btnExecute.Image = (Image)Properties.Resources.ResourceManager.GetObject("control_pause");
                bgWorker.RunWorkerAsync();
            }
            else
            {
                bgWorker.CancelAsync();
            }

        }


        #region 更新UI方法

        /// <summary>
        /// 第一次加载文件源列表
        /// </summary>
        private void InitFileSourceInfo()
        {
            lvStatus.Items.Clear();
            for (int i = 0; i < _manager.FileSourceList.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(_manager.FileSourceList[i].Name);
                lvi.SubItems.Add(_manager.FileSourceList[i].OriginPath);
                lvi.SubItems.Add(_manager.FileSourceList[i].DestPath);
                lvi.SubItems.Add(_manager.FileSourceList[i].Status.ToString());
                lvi.SubItems.Add(string.Empty);
                lvi.SubItems.Add(string.Empty);

                lvi.Tag = _manager.FileSourceList[i];
                lvStatus.Items.Add(lvi);


                lvStatus.Columns[0].Width = -1;
                lvStatus.Columns[1].Width = -1;
                lvStatus.Columns[2].Width = -1;
                //lvStatus.Columns[3].Width = -1;
                //lvStatus.Columns[4].Width = -1;
                //lvStatus.Columns[5].Width = -1;
            }

        }


        /// <summary>
        /// 
        /// </summary>
        private void UpdateFileSourceInfo()
        {
            //lvStatus.BeginUpdate();
            // 进度列表
            try
            {
                for (int i = 0; i < lvStatus.Items.Count; i++)
                {
                    FileSource tmpFileSource = (FileSource)lvStatus.Items[i].Tag;   // 配置对象
                    lvStatus.Items[i].SubItems[3].Text = tmpFileSource.Status.ToString();
                    if (tmpFileSource.Enable)
                    {
                        lvStatus.Items[i].SubItems[4].Text = string.Format("{0}/{1}", tmpFileSource.CopiedFileCount, tmpFileSource.TotalFileCount);
                        lvStatus.Items[i].SubItems[5].Text = tmpFileSource.IsAllFilesCopied ? "√" : "×";
                    }
                }
            }
            catch (Exception)
            {
                // ui异常过滤
            }

            //lvStatus.EndUpdate();

        }


        private void UpdateFileListInfo()
        {
            // 文件列表
            lvFile.Items.Clear();
            foreach (FileSource tmpFileSource in _manager.FileSourceList)
            {
                foreach (ClearFile tmpClearFile in tmpFileSource.ClearFiles)
                {
                    if (tmpClearFile.IsCopied == true && (tmpClearFile.IsCurDay == false || tmpClearFile.IsMD5Equal == false))
                    {
                        ListViewItem lvi = new ListViewItem(tmpFileSource.Name);    // 文件源
                        lvi.SubItems.Add(tmpClearFile.FileName);                    // 文件名

                        string curDayResult = string.Empty;
                        if (tmpClearFile.IsCurDay.HasValue)
                        {
                            if (tmpClearFile.IsCurDay.Value == false)
                                curDayResult = "×";
                        }
                        lvi.SubItems.Add(curDayResult);

                        string md5Result = string.Empty;
                        if (tmpClearFile.IsMD5Equal.HasValue)
                        {
                            if (tmpClearFile.IsMD5Equal.Value == false)
                                md5Result = "×";
                        }
                        lvi.SubItems.Add(md5Result);

                        lvi.BackColor = Color.Pink;
                        lvFile.Items.Add(lvi);
                    }




                }
            }
        }



        #endregion


        #region 执行任务

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgWorker = sender as BackgroundWorker;

            // 1.循环FileSource列表
            foreach (FileSource tmpFileSource in _manager.FileSourceList)
            {
                if (tmpFileSource.Enable == false)  // 不启用的就跳过
                    continue;


                // 判断源路径是否存在
                if (!Directory.Exists(Util.Filename_Date_Convert(tmpFileSource.OriginPath)))
                {
                    // 报警
                    tmpFileSource.Status = FileSourceStatus.路径无法访问;
                    continue;
                }


                // 2.每一个FileSource，判断所有标志文件是否到
                tmpFileSource.IsFlagFilesAllArrived = false;
                tmpFileSource.FlagFilesMissingList.Clear();     // 标志缺失列表
                foreach (string tmpFlagFileName in tmpFileSource.FlagFilesList)
                {
                    string tmpFlagFilePath = Path.Combine(Util.Filename_Date_Convert(tmpFileSource.OriginPath), Util.Filename_Date_Convert(tmpFlagFileName));   // 实际的标志文件路径
                    if (File.Exists(tmpFlagFilePath))  // *****要改良，如果不通很慢
                    {
                        // 如果tmpFlagFileName里没有包含日期通配符，则要求文件必须是当日的。
                        if (!Util.Filename_Contain_DatePattern(tmpFlagFileName))
                        {
                            FileInfo fi = new FileInfo(tmpFlagFilePath);
                            if (fi.LastWriteTime.Date != DateTime.Now.Date) // 不是今天
                                tmpFileSource.FlagFilesMissingList.Add(Util.Filename_Date_Convert(tmpFlagFileName));
                        }
                    }
                    else
                    {
                        tmpFileSource.FlagFilesMissingList.Add(Util.Filename_Date_Convert(tmpFlagFileName));
                    }


                }
                tmpFileSource.IsFlagFilesAllArrived = tmpFileSource.FlagFilesMissingList.Count == 0 ? true : false;
                //更新状态
                if (tmpFileSource.IsFlagFilesAllArrived == false)
                    tmpFileSource.Status = FileSourceStatus.标志文件未收齐;
                else
                    tmpFileSource.Status = FileSourceStatus.标志文件已收齐;
                bgWorker.ReportProgress(1);



                // 3.如果到齐，拉取文件列表
                if (tmpFileSource.IsFlagFilesAllArrived == true)
                {
                    tmpFileSource.IsFileListAcquired = false;
                    tmpFileSource.Status = FileSourceStatus.正在获取文件列表;

                    tmpFileSource.ClearFiles.Clear();   // 清空列表
                    DirectoryInfo di = new DirectoryInfo(Util.Filename_Date_Convert(tmpFileSource.OriginPath));     // 源文件夹

                    // 如果没有配置文件规则，就都拷贝，否则就只拷贝特征
                    if (tmpFileSource.FilePattern.Count == 0)
                    {
                        FileInfo[] fis = di.GetFiles();
                        foreach (FileInfo tmpFileInfo in fis)
                        {
                            // 新建清算文件对象
                            ClearFile clearFile = new ClearFile(tmpFileInfo.Name, tmpFileInfo.FullName, Path.Combine(Util.Filename_Date_Convert(tmpFileSource.DestPath), tmpFileInfo.Name));
                            tmpFileSource.ClearFiles.Add(clearFile);
                        }
                    }
                    else
                    {
                        foreach (string tmpPattern in tmpFileSource.FilePattern)     // 循环每个特征
                        {
                            FileInfo[] fis = di.GetFiles(Util.Filename_Date_Convert(tmpPattern), SearchOption.TopDirectoryOnly);
                            foreach (FileInfo tmpFileInfo in fis)
                            {
                                // 新建清算文件对象
                                ClearFile clearFile = new ClearFile(tmpFileInfo.Name, tmpFileInfo.FullName, Path.Combine(Util.Filename_Date_Convert(tmpFileSource.DestPath), tmpFileInfo.Name));
                                tmpFileSource.ClearFiles.Add(clearFile);
                            }
                        }
                    }


                    tmpFileSource.IsFileListAcquired = true;
                    tmpFileSource.Status = FileSourceStatus.文件列表获取完成;
                    bgWorker.ReportProgress(1);

                }


                // 4.文件复制
                if (tmpFileSource.IsFileListAcquired == true)
                {
                    tmpFileSource.Status = FileSourceStatus.文件复制中;
                    bgWorker.ReportProgress(1);

                    foreach (ClearFile tmpClearFile in tmpFileSource.ClearFiles)
                    {
                        if (File.Exists(tmpClearFile.DestFileName))
                        {
                            tmpClearFile.IsCopied = true;
                        }
                        else
                        {
                            File.Copy(tmpClearFile.SourceFileName, tmpClearFile.DestFileName, true);
                            tmpClearFile.IsCopied = true;
                        }


                        bgWorker.ReportProgress(1);
                        Thread.Sleep(10);

                        if (bgWorker.CancellationPending)   // 取消按钮，这个要换个位置
                        {
                            e.Cancel = true;
                            return;
                        }
                    }

                    tmpFileSource.Status = FileSourceStatus.文件复制完成;
                    bgWorker.ReportProgress(1);
                }


                // 5.文件解压
                if (tmpFileSource.IsAllFilesCopied == true)
                {
                    tmpFileSource.Status = FileSourceStatus.正在解压;
                    bgWorker.ReportProgress(1);
                    foreach (string tmpUnzipPattern in tmpFileSource.FileUnzipPattern)
                    {
                        DirectoryInfo di = new DirectoryInfo(Util.Filename_Date_Convert(tmpFileSource.DestPath));     // 源文件夹

                        FileInfo[] fis = di.GetFiles(Util.Filename_Date_Convert(tmpUnzipPattern), SearchOption.TopDirectoryOnly);
                        foreach (FileInfo tmpFileInfo in fis)
                        {
                            // 解压
                            if(tmpUnzipPattern.ToLower().Contains("zip"))   // zip
                                Util.Decompress_zip(tmpFileInfo.FullName, Util.Filename_Date_Convert(tmpFileSource.DestPath));
                            else if(tmpUnzipPattern.ToLower().Contains("bz2"))  // bz2
                                Util.Decompress_bz2(tmpFileInfo.FullName, Util.Filename_Date_Convert(tmpFileSource.DestPath));
                        }
                    }
                }


                // 6.文件检查
                if (tmpFileSource.IsAllFilesCopied == true)
                {
                    tmpFileSource.Status = FileSourceStatus.正在检查文件;
                    bgWorker.ReportProgress(1);


                    foreach (ClearFile tmpClearFile in tmpFileSource.ClearFiles)
                    {
                        if (File.Exists(tmpClearFile.SourceFileName) && File.Exists(tmpClearFile.DestFileName))
                        {
                            tmpClearFile.IsCopied = true;

                            FileInfo fi_dest = new FileInfo(tmpClearFile.DestFileName);
                            if (fi_dest.LastWriteTime.Date == DateTime.Now.Date)
                                tmpClearFile.IsCurDay = true;
                            else
                                tmpClearFile.IsCurDay = false;


                            string md5Source = Util.GetMD5HashFromFile(tmpClearFile.SourceFileName);
                            string md5Dest = Util.GetMD5HashFromFile(tmpClearFile.DestFileName);
                            if (md5Source == md5Dest)
                                tmpClearFile.IsMD5Equal = true;
                            else
                                tmpClearFile.IsMD5Equal = false;
                        }
                        else
                        {
                            tmpClearFile.IsCopied = false;
                        }

                    }

                    tmpFileSource.Status = FileSourceStatus.文件检查结束;
                    bgWorker.ReportProgress(1);
                }
            }





            bgWorker.ReportProgress(1);

            e.Result = true;
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                UpdateFileSourceInfo();
            }
            catch (Exception ex)
            {
                Print_Error_Message(ex.Message);
            }
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                Print_Error_Message(e.Error.Message);
            }
            else if (e.Cancelled)
            {
                Print_Error_Message("任务被手工取消");
            }
            else
            {

                UpdateFileSourceInfo();
                UpdateFileListInfo();

                // 处理状态标签
                lbStatus.Text = "执行完成";
            }

            btnExecute.Text = "执行(&X)";
            btnExecute.Image = (Image)Properties.Resources.ResourceManager.GetObject("control_play");


            // 计算下一次执行时间
            DateTime dtNow = DateTime.Now;
            lbLastExecuteTime.Text = dtNow.ToString("HH:mm:ss");
            lbNextExecuteTime.Text = Util.GetNextExecuteTime(dtNow, Int32.Parse(numSecSpan.Value.ToString())).ToString("HH:mm:ss");
        }
        #endregion


        /// <summary>
        /// Timer的Tick事件，执行bgWorker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerExecute_Tick(object sender, EventArgs e)
        {

        }
    }
}
