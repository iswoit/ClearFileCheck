using System;
using System.Collections.Generic;
using System.Text;

namespace ClearfileCheckManager
{
    public class ClearFile
    {
        private string _fileName;
        private string _sourceFileName;
        private string _destFileName;
        private bool _isCopied;
        private bool? _isMD5Equal;


        public ClearFile(string filename, string sourceFileName, string destFileName)
        {
            _fileName = filename;
            _sourceFileName = sourceFileName;
            _destFileName = destFileName;
            _isCopied = false;
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

        public bool? IsMD5Equal
        {
            get { return _isMD5Equal; }
            set { _isMD5Equal = value; }
        }
        #endregion
    }
}
