namespace ClearfileCheck
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("现货过户文件");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("期权过户文件");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("上交所", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("上海A股");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("上海B股");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("沪港通");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("上海期权");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("中登上海", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("深圳现货");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("深港通");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("深圳期权");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("中登深圳", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("股转清算文件");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("股份转让", new System.Windows.Forms.TreeNode[] {
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("所有文件", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode8,
            treeNode12,
            treeNode14});
            this.spltCont0 = new System.Windows.Forms.SplitContainer();
            this.tvSource = new System.Windows.Forms.TreeView();
            this.lvFiles = new System.Windows.Forms.ListView();
            this.clmHead0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHead2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHead3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHead1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHead4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHead5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spltCont0.Panel1.SuspendLayout();
            this.spltCont0.Panel2.SuspendLayout();
            this.spltCont0.SuspendLayout();
            this.SuspendLayout();
            // 
            // spltCont0
            // 
            this.spltCont0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltCont0.Location = new System.Drawing.Point(0, 0);
            this.spltCont0.Name = "spltCont0";
            // 
            // spltCont0.Panel1
            // 
            this.spltCont0.Panel1.Controls.Add(this.tvSource);
            // 
            // spltCont0.Panel2
            // 
            this.spltCont0.Panel2.Controls.Add(this.lvFiles);
            this.spltCont0.Size = new System.Drawing.Size(853, 378);
            this.spltCont0.SplitterDistance = 248;
            this.spltCont0.TabIndex = 0;
            // 
            // tvSource
            // 
            this.tvSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvSource.Location = new System.Drawing.Point(0, 0);
            this.tvSource.Name = "tvSource";
            treeNode1.Name = "Node17";
            treeNode1.Text = "现货过户文件";
            treeNode2.Name = "Node18";
            treeNode2.Text = "期权过户文件";
            treeNode3.Name = "Node1";
            treeNode3.Text = "上交所";
            treeNode4.Name = "Node8";
            treeNode4.Text = "上海A股";
            treeNode5.Name = "Node9";
            treeNode5.Text = "上海B股";
            treeNode6.Name = "Node10";
            treeNode6.Text = "沪港通";
            treeNode7.Name = "Node11";
            treeNode7.Text = "上海期权";
            treeNode8.Name = "Node3";
            treeNode8.Text = "中登上海";
            treeNode9.Name = "Node14";
            treeNode9.Text = "深圳现货";
            treeNode10.Name = "Node15";
            treeNode10.Text = "深港通";
            treeNode11.Name = "Node16";
            treeNode11.Text = "深圳期权";
            treeNode12.Name = "Node5";
            treeNode12.Text = "中登深圳";
            treeNode13.Name = "Node19";
            treeNode13.Text = "股转清算文件";
            treeNode14.Name = "Node6";
            treeNode14.Text = "股份转让";
            treeNode15.Name = "Node0";
            treeNode15.Text = "所有文件";
            this.tvSource.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15});
            this.tvSource.Size = new System.Drawing.Size(248, 378);
            this.tvSource.TabIndex = 0;
            // 
            // lvFiles
            // 
            this.lvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmHead0,
            this.clmHead5,
            this.clmHead1,
            this.clmHead2,
            this.clmHead3,
            this.clmHead4});
            this.lvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFiles.FullRowSelect = true;
            this.lvFiles.GridLines = true;
            this.lvFiles.Location = new System.Drawing.Point(0, 0);
            this.lvFiles.Name = "lvFiles";
            this.lvFiles.Size = new System.Drawing.Size(601, 378);
            this.lvFiles.TabIndex = 0;
            this.lvFiles.UseCompatibleStateImageBehavior = false;
            this.lvFiles.View = System.Windows.Forms.View.Details;
            // 
            // clmHead0
            // 
            this.clmHead0.Text = "文件名";
            this.clmHead0.Width = 80;
            // 
            // clmHead2
            // 
            this.clmHead2.Text = "是否已收到";
            this.clmHead2.Width = 80;
            // 
            // clmHead3
            // 
            this.clmHead3.Text = "是否已复制到清算机";
            this.clmHead3.Width = 120;
            // 
            // clmHead1
            // 
            this.clmHead1.Text = "是否必收";
            this.clmHead1.Width = 80;
            // 
            // clmHead4
            // 
            this.clmHead4.Text = "两边文件是否一致";
            this.clmHead4.Width = 120;
            // 
            // clmHead5
            // 
            this.clmHead5.Text = "标志文件";
            this.clmHead5.Width = 80;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 378);
            this.Controls.Add(this.spltCont0);
            this.Name = "FrmMain";
            this.Text = "清算文件检查";
            this.spltCont0.Panel1.ResumeLayout(false);
            this.spltCont0.Panel2.ResumeLayout(false);
            this.spltCont0.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spltCont0;
        private System.Windows.Forms.TreeView tvSource;
        private System.Windows.Forms.ListView lvFiles;
        private System.Windows.Forms.ColumnHeader clmHead0;
        private System.Windows.Forms.ColumnHeader clmHead1;
        private System.Windows.Forms.ColumnHeader clmHead2;
        private System.Windows.Forms.ColumnHeader clmHead3;
        private System.Windows.Forms.ColumnHeader clmHead4;
        private System.Windows.Forms.ColumnHeader clmHead5;
    }
}

