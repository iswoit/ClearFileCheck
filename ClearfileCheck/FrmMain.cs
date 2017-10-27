using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ClearfileCheck
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();


            tvFolder.Nodes.Clear();


            XmlDocument doc = new XmlDocument();
            doc.Load("cfg.xml");
            XmlNode xn = doc.SelectSingleNode("sources");
            TreeNode tnRoot = new TreeNode("所有文件");
            tvFolder.Nodes.Add(tnRoot);

            XmlNodeList xnl = xn.ChildNodes;
            foreach (XmlNode xn1 in xnl)
            {
                if (xn1.Name == "file_source")
                {
                    string strNodeName = xn1.ChildNodes[0].InnerText;

                    XmlElement xe = (XmlElement)xn1;
                    if (xe.GetAttribute("enable").ToString() == "false")
                        strNodeName = "(不启用)" + strNodeName;
                    TreeNode tnTmp = new TreeNode(strNodeName);
                    tnRoot.Nodes.Add(tnTmp);
                }
            }

            tvFolder.ExpandAll();
        }


        private void btnExecute_Click(object sender, EventArgs e)
        {
            /* 1.循环FileSource列表
             * 2.每一个FileSource，判断所有标志文件是否盗取
             * 3.如果到齐，判断是否已经拉取文件列表
             * 4.如果已拉取，则逐个ClearFile对象判断。判断目标路径是否存在，以及源及目的文件md5文件是否一致
             * 5.如果没有拉取，先拉取表格，再重复步骤4
             * 
             */
        }
    }
}
