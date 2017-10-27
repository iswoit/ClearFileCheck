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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "jsmx01_js326.a27",
            "fsbz_a.a27",
            "是",
            "是",
            "是",
            "是"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))), null);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "jsmx02_js326.a27",
            "fzbz_a.a27",
            "是",
            "否",
            "否",
            "否"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), null);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("......");
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("现货过户文件");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("期权过户文件");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("上交所", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("上海A股（进度：9/20）");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("上海B股（进度：5/5）");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("沪港通（进度：10/10）");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("上海期权（进度：1/8）");
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
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("账户清算文件（进度：8/11）");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("中登账户", new System.Windows.Forms.TreeNode[] {
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("所有文件", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode8,
            treeNode12,
            treeNode14,
            treeNode16});
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lvFiles = new System.Windows.Forms.ListView();
            this.clmHead0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHead5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHead1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHead2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHead3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHead4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tvSource = new System.Windows.Forms.TreeView();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 360);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(853, 56);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "18:24:15 文件\\\\10.32.0.133\\dd\\hfxn\\xyfile\\qtsl.a27正在被其他程序占用，无法复制到清算机\r\n18:23:11 文件\\\\" +
    "10.32.0.133\\dd\\dcom_files\\sjsdz1027.dbf无法访问";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "异常信息：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(734, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "点击停止";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "文件源头：";
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
            this.lvFiles.FullRowSelect = true;
            this.lvFiles.GridLines = true;
            this.lvFiles.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lvFiles.Location = new System.Drawing.Point(254, 72);
            this.lvFiles.Name = "lvFiles";
            this.lvFiles.Size = new System.Drawing.Size(601, 256);
            this.lvFiles.TabIndex = 7;
            this.lvFiles.UseCompatibleStateImageBehavior = false;
            this.lvFiles.View = System.Windows.Forms.View.Details;
            // 
            // clmHead0
            // 
            this.clmHead0.Text = "文件名";
            this.clmHead0.Width = 120;
            // 
            // clmHead5
            // 
            this.clmHead5.Text = "标志文件";
            this.clmHead5.Width = 80;
            // 
            // clmHead1
            // 
            this.clmHead1.Text = "是否必收";
            this.clmHead1.Width = 80;
            // 
            // clmHead2
            // 
            this.clmHead2.Text = "文件存在";
            this.clmHead2.Width = 80;
            // 
            // clmHead3
            // 
            this.clmHead3.Text = "是否已复制到清算机";
            this.clmHead3.Width = 120;
            // 
            // clmHead4
            // 
            this.clmHead4.Text = "两边文件是否一致";
            this.clmHead4.Width = 120;
            // 
            // tvSource
            // 
            this.tvSource.Location = new System.Drawing.Point(0, 24);
            this.tvSource.Name = "tvSource";
            treeNode1.Name = "Node17";
            treeNode1.Text = "现货过户文件";
            treeNode2.Name = "Node18";
            treeNode2.Text = "期权过户文件";
            treeNode3.Name = "Node1";
            treeNode3.Text = "上交所";
            treeNode4.Name = "Node8";
            treeNode4.NodeFont = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode4.Text = "上海A股（进度：9/20）";
            treeNode5.Name = "Node9";
            treeNode5.Text = "上海B股（进度：5/5）";
            treeNode6.Name = "Node10";
            treeNode6.Text = "沪港通（进度：10/10）";
            treeNode7.Name = "Node11";
            treeNode7.Text = "上海期权（进度：1/8）";
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
            treeNode15.Name = "Node3";
            treeNode15.Text = "账户清算文件（进度：8/11）";
            treeNode16.Name = "Node1";
            treeNode16.Text = "中登账户";
            treeNode17.Name = "Node0";
            treeNode17.Text = "所有文件";
            this.tvSource.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode17});
            this.tvSource.Size = new System.Drawing.Size(248, 304);
            this.tvSource.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(607, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "状态：检查中...";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(335, 20);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(444, 23);
            this.progressBar1.TabIndex = 9;
            this.progressBar1.Value = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "整体进度：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "当前路径：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(335, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "所有文件\\中登上海\\上海A股（进度：9/20）";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(785, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "180/300";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(403, 429);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(37, 21);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "检查间隔：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(446, 431);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "分钟";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 431);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 12);
            this.label10.TabIndex = 17;
            this.label10.Text = "上一次检查完成时间：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(149, 431);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 18;
            this.label11.Text = "18:00:00";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 470);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tvSource);
            this.Controls.Add(this.lvFiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmMain";
            this.Text = "清算文件拷贝";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvFiles;
        private System.Windows.Forms.ColumnHeader clmHead0;
        private System.Windows.Forms.ColumnHeader clmHead5;
        private System.Windows.Forms.ColumnHeader clmHead1;
        private System.Windows.Forms.ColumnHeader clmHead2;
        private System.Windows.Forms.ColumnHeader clmHead3;
        private System.Windows.Forms.ColumnHeader clmHead4;
        private System.Windows.Forms.TreeView tvSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

