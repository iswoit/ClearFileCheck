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

namespace ClearfileCheck
{
    public partial class FrmMain : Form
    {
        Manager _manager;


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
                _manager = new Manager();


                // 状态列表
                lvStatus.Items.Clear();
                foreach (FileSource tmpFileSource in _manager.FileSourceList)
                {
                    ListViewItem lvi = new ListViewItem(tmpFileSource.Name);
                    lvi.SubItems.Add("");
                    lvi.SubItems.Add("");
                    lvi.SubItems.Add("");
                    lvi.Tag = tmpFileSource;
                    lvStatus.Items.Add(lvi);
                }

            }
            catch (Exception ex)
            {
                tbError.Text = ex.Message + System.Environment.NewLine + tbError.Text;
            }
        }


        private void btnExecute_Click(object sender, EventArgs e)
        {
            /* 1.循环FileSource列表
             * 2.每一个FileSource，判断所有标志文件是否到
             * 3.如果到齐，获取文件列表
             * 4.文件复制，
             * 5.文件md5判断
             */

            lbStatus.Text = "执行中...";
            btnExecute.Text = "点击停止";
            if(!bgWorker.IsBusy)
            {
                bgWorker.RunWorkerAsync();
            }
            else
            {
                bgWorker.CancelAsync();
            }
            
        }


        #region 更新列表
        private void UpdateFileSourceInfo()
        {
            lvStatus.BeginUpdate();
            // 进度列表
            foreach (ListViewItem tmpLVI in lvStatus.Items)
            {
                FileSource tmpFileSource = (FileSource)tmpLVI.Tag;
                tmpLVI.SubItems[1].Text = string.Format("{0}/{1}", tmpFileSource.CopiedFileCount, tmpFileSource.TotalFileCount);
                tmpLVI.SubItems[2].Text = tmpFileSource.CopiedFileCount == tmpFileSource.TotalFileCount ? "√" : "×";
            }
            lvStatus.EndUpdate();

        }

        private void UpdateFileListInfo()
        {
            // 文件列表
            lvFile.Items.Clear();
            foreach (FileSource tmpFileSource in _manager.FileSourceList)
            {
                foreach (ClearFile tmpClearFile in tmpFileSource.ClearFiles)
                {
                    ListViewItem lvi = new ListViewItem(tmpFileSource.Name);
                    lvi.SubItems.Add(tmpClearFile.FileName);
                    lvi.SubItems.Add(tmpClearFile.IsCopied ? "√" : "×");

                    string md5Result = "";
                    if (tmpClearFile.IsMD5Equal.HasValue)
                    {
                        if (tmpClearFile.IsMD5Equal.Value == true)
                            md5Result = "√";
                        else
                            md5Result = "×";
                    }
                    lvi.SubItems.Add(md5Result);

                    if (!(tmpClearFile.IsCopied == true && tmpClearFile.IsMD5Equal.HasValue == true && tmpClearFile.IsMD5Equal.Value == true))
                    {
                        lvi.BackColor = Color.OrangeRed;
                    }

                    lvFile.Items.Add(lvi);


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

                // 2.每一个FileSource，判断所有标志文件是否到
                bool pass = true;
                tmpFileSource.FlagFilesMissingList.Clear();
                foreach (string tmpFlagFileName in tmpFileSource.FlagFilesList)
                {
                    string tmpFlagFilePath = Path.Combine(Util.Filename_Date_Convert(tmpFileSource.OriginPath), Util.Filename_Date_Convert(tmpFlagFileName));
                    if (!File.Exists(tmpFlagFilePath))  // *****要改良，如果不通很慢
                    {
                        pass = false;
                        tmpFileSource.FlagFilesMissingList.Add(Util.Filename_Date_Convert(tmpFlagFileName));
                    }
                }
                tmpFileSource.IsFlagFilesAllArrived = pass;


                // 3.如果到齐，拉取文件列表
                if (tmpFileSource.IsFlagFilesAllArrived == true)
                {
                    tmpFileSource.ClearFiles.Clear();   // 清空列表
                    DirectoryInfo di = new DirectoryInfo(Util.Filename_Date_Convert(tmpFileSource.OriginPath));     // 源文件夹
                    foreach (string tmpPattern in tmpFileSource.FilePattern)     // 循环每个特征
                    {
                        FileInfo[] fis = di.GetFiles(Util.Filename_Date_Convert(tmpPattern), SearchOption.TopDirectoryOnly);
                        foreach (FileInfo tmpFileInfo in fis)
                        {
                            // *如果是标记文件，则不拷贝(还没做)


                            // 新建清算文件对象
                            ClearFile clearFile = new ClearFile(tmpFileInfo.Name, tmpFileInfo.FullName, Path.Combine(Util.Filename_Date_Convert(tmpFileSource.DestPath), tmpFileInfo.Name));
                            tmpFileSource.ClearFiles.Add(clearFile);
                        }
                    }

                    tmpFileSource.IsFileListAcquired = true;
                }
            }


            // 4.循环列表，文件复制
            foreach (FileSource tmpFileSource in _manager.FileSourceList)
            {
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

                        bgWorker.ReportProgress(1);
                        Thread.Sleep(10);
                    }
                

                    if (bgWorker.CancellationPending)   // 取消按钮，这个要换个位置
                    {
                        e.Cancel = true;
                        return;
                    }
                }

                
            }

            // 5.文件判断MD5
            foreach (FileSource tmpFileSource in _manager.FileSourceList)
            {
                foreach (ClearFile tmpClearFile in tmpFileSource.ClearFiles)
                {
                    if (File.Exists(tmpClearFile.SourceFileName) && File.Exists(tmpClearFile.DestFileName))
                    {
                        string md5Source = Util.GetMD5HashFromFile(tmpClearFile.SourceFileName);
                        string md5Dest = Util.GetMD5HashFromFile(tmpClearFile.DestFileName);
                        if (md5Source == md5Dest)
                            tmpClearFile.IsMD5Equal = true;
                        else
                            tmpClearFile.IsMD5Equal = false;
                    }
                    else
                    {
                        tmpClearFile.IsMD5Equal = null;
                    }

                }
            }



            bgWorker.ReportProgress(1);

            e.Result = true;
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            UpdateFileSourceInfo();
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("Error");
            }
            else if (e.Cancelled)
            {
                MessageBox.Show("Canceled");
            }
            else
            {
                lbStatus.Text = "执行完成";
                UpdateFileSourceInfo();
                UpdateFileListInfo();
            }

            btnExecute.Text = "执行";
        }
        #endregion

    }
}
