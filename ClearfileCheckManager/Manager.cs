using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

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
            // 清空行情源
            _fileSourceList = new List<FileSource>();

            // 判断配置文件是否存在，不存在抛出异常
            if (!File.Exists(Path.Combine(Environment.CurrentDirectory, "cfg.xml")))
                throw new Exception("未能找到配置文件cfg.xml，请重新配置该文件后重启程序!");

            // 读取文件
            XmlDocument doc = new XmlDocument();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true;     //忽略文档里面的注释
            using (XmlReader reader = XmlReader.Create(@"cfg.xml", settings))
            {
                doc.Load(reader);

                // 根据配置文件，生成对象
                XmlNode rootNode = doc.SelectSingleNode("sources");   // 根节点
                if (rootNode == null)
                    throw new Exception("无法找到配置文件的根节点<sources>，请检查配置文件格式是否正确!");

                foreach (XmlNode tmpXnl in rootNode.ChildNodes)     // 遍历每一个子节点
                {
                    if (tmpXnl.Name.ToLower().Trim() == "file_source")  // 只能是file_source节点
                    {
                        string enable = string.Empty;
                        string name = string.Empty;
                        string originPath = string.Empty;
                        string destPath = string.Empty;
                        string flagFiles = string.Empty;
                        string filePattern = string.Empty;
                        string fileUnzipPattern = string.Empty;


                        XmlElement xe = (XmlElement)tmpXnl;
                        enable = xe.GetAttribute("enable");     // 启用标志（只要不是enable="false"，都算启用）
                        for (int i = 0; i < xe.ChildNodes.Count; i++)
                        {
                            switch (xe.ChildNodes[i].Name.ToLower().Trim())
                            {
                                case "name":
                                    name = xe.ChildNodes[i].InnerText;
                                    break;
                                case "origin_path":
                                    originPath = xe.ChildNodes[i].InnerText;
                                    break;
                                case "dest_path":
                                    destPath = xe.ChildNodes[i].InnerText;
                                    break;
                                case "flag_files":
                                    flagFiles = xe.ChildNodes[i].InnerText;
                                    break;
                                case "file_pattern":
                                    filePattern = xe.ChildNodes[i].InnerText;
                                    break;
                                case "file_unzip_pattern":
                                    fileUnzipPattern = xe.ChildNodes[i].InnerText;
                                    break;
                            }
                        }


                        // 生成对象
                        FileSource tmpFileSource = new FileSource(
                            enable,
                            name,
                            originPath.Trim(),
                            destPath.Trim(),
                            flagFiles.Trim(),
                            filePattern.Trim(),
                            fileUnzipPattern.Trim());

                        // 创建目标路径
                        if (!Directory.Exists(destPath.Trim()))
                            Directory.CreateDirectory(destPath.Trim());

                        // 对象加入列表
                        _fileSourceList.Add(tmpFileSource);
                    }
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
