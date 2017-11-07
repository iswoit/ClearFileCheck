using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ClearfileCheckManager
{
    public enum FileSourceStatus
    {
        尝试访问路径 = -1,
        禁用 = 0,
        未开始 = 1,
        源路径无法访问 = 2,
        标志文件未收齐 = 3,
        标志文件已收齐 = 4,
        正在获取文件列表 = 5,
        文件列表获取完成 = 6,
        文件复制中 = 7,
        文件复制完成 = 8,
        正在解压 = 9,
        正在检查文件 = 10,
        完成 = 11
    }

    /// <summary>
    /// 拷贝项目
    /// </summary>
    public class FileSource
    {
        private FileSourceStatus _status;       // 当前状态标志
        private bool _enable;                   // 是否启用
        private string _name;                   // 对应来源名称
        private string _originPath;             // 源路径
        private string _destPath;               // 清算机路径
        private List<string> _flagFilesList;    // 标志文件列表
        private List<string> _filePattern;      // 文件样式
        private List<string> _listNoCopyPattern;           // 不需要拷贝的文件列表(可能包含*号通配，mdd日期通配)

        private bool _isFlagFilesAllArrived;    // 所有标志文件是否已就绪
        private List<string> _flagFilesMissingList;     // 还缺失的标志文件列表

        private bool _isFileListAcquired;       // 清算文件列表是否已获取
        private List<ClearFile> _clearFiles;    // 清算文件列表

        private bool _isRunning = false;



        public FileSource(string enable, string name, string originPath, string destPath, string flagFiles, string filePattern, string noCopy)
        {
            // 配置是否启用（只有false是禁止，其他都是默认启用）
            bool convertResult = bool.TryParse(enable, out _enable);
            if (convertResult == false)
                _enable = true;
            _name = name;
            _originPath = Util.Filename_Date_Convert(originPath);       // 源目录 
            _destPath = Util.Filename_Date_Convert(destPath);

            // 标志文件特征
            string[] arr_flagfiles = flagFiles.Split(new char[] { '|', ';', '；', ',', '，' });
            _flagFilesList = new List<string>();
            foreach (string strTmp in arr_flagfiles)
            {
                if (!string.IsNullOrEmpty(strTmp.Trim()))
                    _flagFilesList.Add(strTmp.Trim());
            }

            // 清算文件特征
            string[] arr_file_pattern = filePattern.Split(new char[] { '|', ';', '；', ',', '，' });
            _filePattern = new List<string>();
            foreach (string strTmp in arr_file_pattern)
            {
                if (!string.IsNullOrEmpty(strTmp.Trim()))
                    _filePattern.Add(strTmp.Trim());
            }


            // 不需要拷贝的模式列表
            string[] arr_list_no_copy_pattern = noCopy.Split(new char[] { '|', ';', '；', ',', '，' });
            _listNoCopyPattern = new List<string>();
            foreach (string strTmp in arr_list_no_copy_pattern)
            {
                if (!string.IsNullOrEmpty(strTmp.Trim()))
                    _listNoCopyPattern.Add(strTmp.Trim());
            }

            _isFlagFilesAllArrived = false;
            _flagFilesMissingList = new List<string>();

            _isFileListAcquired = false;
            _clearFiles = new List<ClearFile>();

            if (Enable == false)
                Status = FileSourceStatus.禁用;
            else
                Status = FileSourceStatus.未开始;
        }

        #region 属性

        public FileSourceStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public bool Enable
        {
            get { return _enable; }
            set { _enable = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string OriginPath
        {
            get { return _originPath; }
            set { _originPath = value; }
        }

        public string DestPath
        {
            get { return _destPath; }
            set { _destPath = value; }
        }

        public List<string> FlagFilesList
        {
            get { return _flagFilesList; }
            set { _flagFilesList = value; }
        }


        public List<string> FilePattern
        {
            get { return _filePattern; }
            set { _filePattern = value; }
        }



        /// <summary>
        /// 不需要拷贝的文件模式列表
        /// </summary>
        public List<string> NoCopyPattern
        {
            get { return _listNoCopyPattern; }
            set { _listNoCopyPattern = value; }
        }

        public bool IsFlagFilesAllArrived
        {
            get { return _isFlagFilesAllArrived; }
            set { _isFlagFilesAllArrived = value; }
        }

        public List<string> FlagFilesMissingList
        {
            get { return _flagFilesMissingList; }
            set { _flagFilesMissingList = value; }
        }

        public bool IsFileListAcquired
        {
            get { return _isFileListAcquired; }
            set { _isFileListAcquired = value; }
        }


        public List<ClearFile> ClearFiles
        {
            get { return _clearFiles; }
            set { _clearFiles = value; }
        }

        // 获取文件总数
        public int TotalFileCount
        {
            get
            {
                if (_clearFiles == null)
                    return 0;

                return _clearFiles.Count;
            }
        }

        // 获取已拷贝数
        public int CopiedFileCount
        {
            get
            {
                if (_clearFiles == null)
                    return 0;

                int cnt = 0;
                foreach (ClearFile tmpFile in _clearFiles)
                {
                    if (tmpFile.IsCopied == true)
                        cnt++;
                }
                return cnt;
            }
        }


        // 判断所有文件是否拷贝完
        public bool IsAllFilesCopied
        {
            get
            {
                if (Enable == false)
                    return false;

                if (IsFlagFilesAllArrived == false)
                    return false;

                if (IsFileListAcquired == false)
                    return false;

                return TotalFileCount == CopiedFileCount;
            }
        }

        /// <summary>
        /// 检查所有检查都通过（文件大小、当日）
        /// </summary>
        public bool IsAllCheckPassed
        {
            get
            {
                if (Enable == false)
                    return false;

                if (IsFlagFilesAllArrived == false)
                    return false;

                if (IsFileListAcquired == false)
                    return false;

                if (IsAllFilesCopied == false)
                    return false;


                foreach (ClearFile tmp in _clearFiles)
                {
                    if (tmp.IsCheckPassed == false)
                        return false;
                }

                return true;
            }
        }


        /// <summary>
        /// 任务是否在运行
        /// </summary>
        public bool IsRunning
        {
            get { return _isRunning; }
            set { _isRunning = value; }
        }

        #endregion 属性



        #region 方法

        /// <summary>
        /// 检查本配置下所有标志文件是否到齐
        /// </summary>
        /// <returns></returns>
        public bool CheckFlagFilesAllArrived()
        {
            // 1.源路径的可访问性检查
            if (!Directory.Exists(OriginPath))
                throw new Exception(string.Format("检查【{0}】的标志文件失败！路径: {1} 无法访问！", Name, OriginPath));

            foreach (string flagFile in FlagFilesList)
            {
                if (!File.Exists(Path.Combine(OriginPath, Util.Filename_Date_Convert(flagFile))))
                {
                    IsFlagFilesAllArrived = false;
                    return false;
                }
            }

            IsFlagFilesAllArrived = true;
            return true;
        }
        #endregion 方法
    }
}
