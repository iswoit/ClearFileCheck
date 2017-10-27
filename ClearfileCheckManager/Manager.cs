using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace ClearfileCheckManager
{
    public class Manager
    {
        private List<FileSource> _fileSourceList = new List<FileSource>();  // 文件源列表
        private DateTime? _lastCheckTime;
        private DateTime? _nextCheckTime;
        private int _checkMinuteSpan;       // 检查间隔

        /// <summary>
        /// 构造函数
        /// </summary>
        public Manager()
        {
            _fileSourceList.Clear();

            XmlDocument doc = new XmlDocument();
            doc.Load("cfg.xml");
            XmlNode xn = doc.SelectSingleNode("sources");   // 根节点


            XmlNodeList xnl = xn.ChildNodes;
            foreach (XmlNode xn1 in xnl)
            {
                if (xn1.Name.ToLower() == "file_source")
                {

                    XmlElement xe = (XmlElement)xn1;

                    FileSource tmpFileSource = new FileSource(xe.GetAttribute("enable").ToString(), xe.ChildNodes[0].InnerText, xe.ChildNodes[1].InnerText, xe.ChildNodes[2].InnerText, xe.ChildNodes[3].InnerText, xe.ChildNodes[4].InnerText);
                    _fileSourceList.Add(tmpFileSource);

                }
            }

        }


        #region 属性
        public List<FileSource> FileSourceList
        {
            get { return _fileSourceList; }
            set { _fileSourceList = value; }
        }

        public DateTime? LastCheckTime
        {
            get { return _lastCheckTime; }
            set { _lastCheckTime = value; }
        }

        public DateTime? NextCheckTime
        {
            get { return _nextCheckTime; }
            set { _nextCheckTime = value; }
        }

        public int CheckMinuteSpan
        {
            get { return _checkMinuteSpan; }
            set { _checkMinuteSpan = value; }
        }

        #endregion

    }
}
