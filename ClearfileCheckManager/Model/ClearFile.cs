using System;
using System.Collections.Generic;
using System.Text;

namespace ClearfileCheckManager
{
    public class ClearFile
    {
        private string _fileName;           // 文件名
        private string _sourceFileName;     // 源文件
        private string _destFileName;       // 目的地
        private bool _isCopied;             // 是否已复制
        private bool? _isCurDate;           // 是否当天文件
        private bool? _isMD5Equal;          // MD5一致


        public ClearFile(string filename, string sourceFileName, string destFileName)
        {
            _fileName = filename;
            _sourceFileName = sourceFileName;
            _destFileName = destFileName;
            _isCopied = false;
            _isCurDate = null;
            _isMD5Equal = null;
        }

        #region 属性
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        public string SourceFileName
        {
            get { return _sourceFileName; }
            set { _sourceFileName = value; }
        }

        public string DestFileName
        {
            get { return _destFileName; }
            set { _destFileName = value; }
        }

        public bool IsCopied
        {
            get { return _isCopied; }
            set { _isCopied = value; }
        }

        public bool? IsCurDay
        {
            get { return _isCurDate; }
            set { _isCurDate = value; }
        }

        public bool? IsMD5Equal
        {
            get { return _isMD5Equal; }
            set { _isMD5Equal = value; }
        }
        #endregion
    }
}
