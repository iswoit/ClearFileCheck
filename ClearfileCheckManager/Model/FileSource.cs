using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ClearfileCheckManager
{
    /// <summary>
    /// 拷贝项目
    /// </summary>
    public class FileSource
    {
        private bool _enable;                   // 是否启用
        private string _name;                   // 对应来源名称
        private string _originPath;             // 源路径
        private string _destPath;               // 清算机路径
        private List<string> _flagFilesList;    // 标志文件列表
        private bool _isFlagFilesAllArrived;    // 所有标志文件是否已就绪
        private bool _isFileListAcquired;       // 清算文件列表是否已获取
        

        public FileSource(string enable, string name, string originPath, string destPath, string flagFiles)
        {
            _enable = bool.Parse(enable);
            _name = name;
            _originPath = originPath;
            _destPath = destPath;

            string[] arr_flagfiles = flagFiles.Split(new char[';']);
            _flagFilesList = new List<string>();
            _flagFilesList.AddRange(arr_flagfiles);

            _isFlagFilesAllArrived = false;
        }

        #region 属性
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

        public bool IsFlagFilesAllArrived
        {
            get { return _isFlagFilesAllArrived; }
            set { _isFlagFilesAllArrived = value; }
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
