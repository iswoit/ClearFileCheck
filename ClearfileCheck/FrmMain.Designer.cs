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
            this.components = new System.ComponentModel.Container();
            this.tbError = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lvFile = new System.Windows.Forms.ListView();
            this.clmHead1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHead0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHead4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbStatus = new System.Windows.Forms.Label();
            this.numSecSpan = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbLastExecuteTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbNextExecuteTime = new System.Windows.Forms.Label();
            this.timerExecute = new System.Windows.Forms.Timer(this.components);
            this.lvStatus = new ClearfileCheckManager.DoubleBufferListView();
            this.文件源 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.状态 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.进度 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.是否收齐 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.numSecSpan)).BeginInit();
            this.SuspendLayout();
            // 
            // tbError
            // 
            this.tbError.BackColor = System.Drawing.Color.White;
            this.tbError.Location = new System.Drawing.Point(12, 361);
            this.tbError.Multiline = true;
            this.tbError.Name = "tbError";
            this.tbError.ReadOnly = true;
            this.tbError.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbError.Size = new System.Drawing.Size(587, 134);
            this.tbError.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "异常信息：";
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(811, 468);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 27);
            this.btnExecute.TabIndex = 3;
            this.btnExecute.Text = "执行(&X)";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "问题文件列表：";
            // 
            // lvFile
            // 
            this.lvFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmHead1,
            this.clmHead0,
            this.clmHead4,
            this.columnHeader3});
            this.lvFile.FullRowSelect = true;
            this.lvFile.GridLines = true;
            this.lvFile.Location = new System.Drawing.Point(12, 209);
            this.lvFile.Name = "lvFile";
            this.lvFile.Size = new System.Drawing.Size(587, 120);
            this.lvFile.TabIndex = 7;
            this.lvFile.UseCompatibleStateImageBehavior = false;
            this.lvFile.View = System.Windows.Forms.View.Details;
            // 
            // clmHead1
            // 
            this.clmHead1.Text = "文件源";
            // 
            // clmHead0
            // 
            this.clmHead0.Text = "文件名";
            this.clmHead0.Width = 120;
            // 
            // clmHead4
            // 
            this.clmHead4.Text = "两边文件不一致";
            this.clmHead4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmHead4.Width = 120;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(701, 475);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(53, 12);
            this.lbStatus.TabIndex = 8;
            this.lbStatus.Text = "停止运行";
            // 
            // numSecSpan
            // 
            this.numSecSpan.Location = new System.Drawing.Point(812, 315);
            this.numSecSpan.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numSecSpan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSecSpan.Name = "numSecSpan";
            this.numSecSpan.Size = new System.Drawing.Size(37, 21);
            this.numSecSpan.TabIndex = 14;
            this.numSecSpan.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(741, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "检查间隔：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(855, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "秒";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(741, 391);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 12);
            this.label10.TabIndex = 17;
            this.label10.Text = "上一次拷贝时间：";
            // 
            // lbLastExecuteTime
            // 
            this.lbLastExecuteTime.AutoSize = true;
            this.lbLastExecuteTime.Location = new System.Drawing.Point(848, 391);
            this.lbLastExecuteTime.Name = "lbLastExecuteTime";
            this.lbLastExecuteTime.Size = new System.Drawing.Size(23, 12);
            this.lbLastExecuteTime.TabIndex = 18;
            this.lbLastExecuteTime.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "文件拷贝进度：";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(743, 341);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(144, 16);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "文件拷贝完成停止程序";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(654, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "状态：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(741, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 12);
            this.label6.TabIndex = 23;
            this.label6.Text = "下一次拷贝时间：";
            // 
            // lbNextExecuteTime
            // 
            this.lbNextExecuteTime.AutoSize = true;
            this.lbNextExecuteTime.Location = new System.Drawing.Point(848, 416);
            this.lbNextExecuteTime.Name = "lbNextExecuteTime";
            this.lbNextExecuteTime.Size = new System.Drawing.Size(23, 12);
            this.lbNextExecuteTime.TabIndex = 24;
            this.lbNextExecuteTime.Text = "N/A";
            // 
            // timerExecute
            // 
            this.timerExecute.Interval = 1000;
            this.timerExecute.Tick += new System.EventHandler(this.timerExecute_Tick);
            // 
            // lvStatus
            // 
            this.lvStatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.文件源,
            this.columnHeader1,
            this.columnHeader2,
            this.状态,
            this.进度,
            this.是否收齐});
            this.lvStatus.FullRowSelect = true;
            this.lvStatus.GridLines = true;
            this.lvStatus.Location = new System.Drawing.Point(12, 24);
            this.lvStatus.Name = "lvStatus";
            this.lvStatus.Size = new System.Drawing.Size(889, 157);
            this.lvStatus.TabIndex = 19;
            this.lvStatus.UseCompatibleStateImageBehavior = false;
            this.lvStatus.View = System.Windows.Forms.View.Details;
            // 
            // 文件源
            // 
            this.文件源.Text = "文件源";
            this.文件源.Width = 80;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "源路径";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "目标路径";
            this.columnHeader2.Width = 120;
            // 
            // 状态
            // 
            this.状态.Text = "状态";
            this.状态.Width = 160;
            // 
            // 进度
            // 
            this.进度.Text = "进度";
            // 
            // 是否收齐
            // 
            this.是否收齐.Text = "是否收齐";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "文件日期不是当日";
            this.columnHeader3.Width = 120;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 518);
            this.Controls.Add(this.lbNextExecuteTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvStatus);
            this.Controls.Add(this.lbLastExecuteTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numSecSpan);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lvFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbError);
            this.Name = "FrmMain";
            this.Text = "清算文件拷贝";
            ((System.ComponentModel.ISupportInitialize)(this.numSecSpan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvFile;
        private System.Windows.Forms.ColumnHeader clmHead0;
        private System.Windows.Forms.ColumnHeader clmHead4;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.NumericUpDown numSecSpan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbLastExecuteTime;
        private ClearfileCheckManager.DoubleBufferListView lvStatus;
        private System.Windows.Forms.ColumnHeader 文件源;
        private System.Windows.Forms.ColumnHeader 进度;
        private System.Windows.Forms.ColumnHeader 是否收齐;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.ColumnHeader clmHead1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbNextExecuteTime;
        private System.Windows.Forms.ColumnHeader 状态;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Timer timerExecute;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

