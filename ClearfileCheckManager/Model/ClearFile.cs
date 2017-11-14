using System;
using System.Collections.Generic;
using System.Text;

namespace ClearfileCheckManager
{
    public class ClearFile
    {
        private string _fileName;           // 文件名
        private string _sourceFilePath;     // 源文件
        private string _destFilePath;       // 目的地
        private bool _isCopied;             // 是否已复制
        private bool? _isCurDate;           // 是否当天文件
        private bool? _isMD5Equal;          // MD5一致
        private List<string> _unzipedFiles; // 被解压的文件列表（还没用到）

        public ClearFile(string filename, string sourceFileName, string destFileName)
        {
            _fileName = filename;
            _sourceFilePath = sourceFileName;
            _destFilePath = destFileName;
            _isCopied = false;
            _isCurDate = null;
            _isMD5Equal = null;
            _unzipedFiles = new List<string>();
        }

        #region 属性
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        /// <summary>
        /// 清算文件源路径
        /// </summary>
        public string SourceFilePath
        {
            get { return _sourceFilePath; }
            set { _sourceFilePath = value; }
        }

        /// <summary>
        /// 清算文件目的路径
        /// </summary>
        public string DestFilePath
        {
            get { return _destFilePath; }
            set { _destFilePath = value; }
        }

        /// <summary>
        /// 清算文件是否已拷贝
        /// </summary>
        public bool IsCopied
        {
            get { return _isCopied; }
            set { _isCopied = value; }
        }

        /// <summary>
        /// 清算文件是否是当日
        /// </summary>
        public bool? IsCurDay
        {
            get { return _isCurDate; }
            set { _isCurDate = value; }
        }

        /// <summary>
        /// 清算文件源和目的md5是否一致
        /// </summary>
        public bool? IsMD5Equal
        {
            get { return _isMD5Equal; }
            set { _isMD5Equal = value; }
        }
        #endregion
    }
}
