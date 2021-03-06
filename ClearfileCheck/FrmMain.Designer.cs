﻿namespace ClearfileCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tbError = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lvFile = new System.Windows.Forms.ListView();
            this.cl0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbStatus = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbLastExecuteTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.timerExecute = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNextExecuteTime = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerCurrentTime = new System.Windows.Forms.Timer(this.components);
            this.numSpan = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFunc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFuncClearDestFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.lbCanClearStart = new System.Windows.Forms.Label();
            this.lvStatus = new ClearfileCheck.DoubleBufferListView();
            this.文件源 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.状态 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.进度 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.标志到齐 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.拷贝完成 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.检查通过 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpan)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbError
            // 
            this.tbError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbError.BackColor = System.Drawing.Color.White;
            this.tbError.Location = new System.Drawing.Point(12, 465);
            this.tbError.Multiline = true;
            this.tbError.Name = "tbError";
            this.tbError.ReadOnly = true;
            this.tbError.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbError.Size = new System.Drawing.Size(688, 96);
            this.tbError.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "异常信息：";
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecute.Image = global::ClearfileCheck.Properties.Resources.control_play;
            this.btnExecute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExecute.Location = new System.Drawing.Point(970, 494);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(83, 27);
            this.btnExecute.TabIndex = 3;
            this.btnExecute.Text = "点击执行";
            this.btnExecute.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "问题文件列表：";
            // 
            // lvFile
            // 
            this.lvFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl0,
            this.cl1,
            this.cl2,
            this.cl3});
            this.lvFile.FullRowSelect = true;
            this.lvFile.GridLines = true;
            this.lvFile.Location = new System.Drawing.Point(12, 305);
            this.lvFile.Name = "lvFile";
            this.lvFile.Size = new System.Drawing.Size(1084, 112);
            this.lvFile.TabIndex = 7;
            this.lvFile.UseCompatibleStateImageBehavior = false;
            this.lvFile.View = System.Windows.Forms.View.Details;
            // 
            // cl0
            // 
            this.cl0.Text = "文件源";
            // 
            // cl1
            // 
            this.cl1.Text = "文件名";
            this.cl1.Width = 200;
            // 
            // cl2
            // 
            this.cl2.Text = "文件日期不是当日";
            this.cl2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl2.Width = 120;
            // 
            // cl3
            // 
            this.cl3.Text = "两边文件不一致";
            this.cl3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl3.Width = 120;
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStatus.Location = new System.Drawing.Point(828, 474);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(119, 23);
            this.lbStatus.TabIndex = 8;
            this.lbStatus.Text = "停止运行";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(745, 433);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 17;
            this.label10.Text = "上一次时间：";
            // 
            // lbLastExecuteTime
            // 
            this.lbLastExecuteTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLastExecuteTime.AutoSize = true;
            this.lbLastExecuteTime.Location = new System.Drawing.Point(828, 433);
            this.lbLastExecuteTime.Name = "lbLastExecuteTime";
            this.lbLastExecuteTime.Size = new System.Drawing.Size(23, 12);
            this.lbLastExecuteTime.TabIndex = 18;
            this.lbLastExecuteTime.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "文件拷贝进度：";
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
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(781, 479);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "状态：";
            // 
            // timerExecute
            // 
            this.timerExecute.Interval = 500;
            this.timerExecute.Tick += new System.EventHandler(this.timerExecute_Tick);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Enabled = false;
            this.btnStop.Image = global::ClearfileCheck.Properties.Resources.control_stop;
            this.btnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStop.Location = new System.Drawing.Point(970, 527);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(83, 27);
            this.btnStop.TabIndex = 23;
            this.btnStop.Text = "点击停止";
            this.btnStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(745, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "下一次时间：";
            // 
            // lbNextExecuteTime
            // 
            this.lbNextExecuteTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNextExecuteTime.AutoSize = true;
            this.lbNextExecuteTime.Location = new System.Drawing.Point(828, 452);
            this.lbNextExecuteTime.Name = "lbNextExecuteTime";
            this.lbNextExecuteTime.Size = new System.Drawing.Size(23, 12);
            this.lbNextExecuteTime.TabIndex = 25;
            this.lbNextExecuteTime.Text = "N/A";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusTime});
            this.statusStrip.Location = new System.Drawing.Point(0, 576);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1108, 22);
            this.statusStrip.TabIndex = 26;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusTime
            // 
            this.statusTime.AutoSize = false;
            this.statusTime.Name = "statusTime";
            this.statusTime.Size = new System.Drawing.Size(163, 17);
            this.statusTime.Text = "当前时间: ";
            this.statusTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerCurrentTime
            // 
            this.timerCurrentTime.Enabled = true;
            this.timerCurrentTime.Interval = 500;
            this.timerCurrentTime.Tick += new System.EventHandler(this.timerCurrentTime_Tick);
            // 
            // numSpan
            // 
            this.numSpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numSpan.Location = new System.Drawing.Point(1010, 430);
            this.numSpan.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numSpan.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSpan.Name = "numSpan";
            this.numSpan.Size = new System.Drawing.Size(43, 21);
            this.numSpan.TabIndex = 27;
            this.numSpan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSpan.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(939, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 28;
            this.label6.Text = "间隔(秒)：";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFunc,
            this.menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1108, 25);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip";
            // 
            // menuFunc
            // 
            this.menuFunc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFuncClearDestFolder});
            this.menuFunc.Name = "menuFunc";
            this.menuFunc.Size = new System.Drawing.Size(44, 21);
            this.menuFunc.Text = "功能";
            // 
            // menuFuncClearDestFolder
            // 
            this.menuFuncClearDestFolder.Enabled = false;
            this.menuFuncClearDestFolder.Name = "menuFuncClearDestFolder";
            this.menuFuncClearDestFolder.Size = new System.Drawing.Size(172, 22);
            this.menuFuncClearDestFolder.Text = "清空目标路径文件";
            this.menuFuncClearDestFolder.Click += new System.EventHandler(this.menuFuncClearDestFolder_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 21);
            this.menuHelp.Text = "帮助";
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(109, 22);
            this.menuHelpAbout.Text = "关于...";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(709, 509);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 12);
            this.label7.TabIndex = 30;
            this.label7.Text = "是否可以开始清算：";
            // 
            // lbCanClearStart
            // 
            this.lbCanClearStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCanClearStart.AutoSize = true;
            this.lbCanClearStart.Location = new System.Drawing.Point(828, 509);
            this.lbCanClearStart.Name = "lbCanClearStart";
            this.lbCanClearStart.Size = new System.Drawing.Size(23, 12);
            this.lbCanClearStart.TabIndex = 31;
            this.lbCanClearStart.Text = "N/A";
            // 
            // lvStatus
            // 
            this.lvStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvStatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.文件源,
            this.columnHeader1,
            this.columnHeader2,
            this.状态,
            this.进度,
            this.标志到齐,
            this.拷贝完成,
            this.检查通过,
            this.columnHeader3});
            this.lvStatus.FullRowSelect = true;
            this.lvStatus.GridLines = true;
            this.lvStatus.Location = new System.Drawing.Point(12, 61);
            this.lvStatus.Name = "lvStatus";
            this.lvStatus.Size = new System.Drawing.Size(1084, 226);
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
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "目标路径";
            this.columnHeader2.Width = 150;
            // 
            // 状态
            // 
            this.状态.Text = "状态";
            this.状态.Width = 160;
            // 
            // 进度
            // 
            this.进度.Text = "文件进度";
            this.进度.Width = 70;
            // 
            // 标志到齐
            // 
            this.标志到齐.Text = "标志到齐";
            this.标志到齐.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 拷贝完成
            // 
            this.拷贝完成.Text = "拷贝完成";
            this.拷贝完成.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 检查通过
            // 
            this.检查通过.Text = "检查通过";
            this.检查通过.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "清算开始必须收齐";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 110;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 598);
            this.Controls.Add(this.lbCanClearStart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numSpan);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbNextExecuteTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvStatus);
            this.Controls.Add(this.lbLastExecuteTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lvFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbError);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "清算文件拷贝";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpan)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvFile;
        private System.Windows.Forms.ColumnHeader cl1;
        private System.Windows.Forms.ColumnHeader cl3;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbLastExecuteTime;
        private ClearfileCheck.DoubleBufferListView lvStatus;
        private System.Windows.Forms.ColumnHeader 文件源;
        private System.Windows.Forms.ColumnHeader 进度;
        private System.Windows.Forms.ColumnHeader 标志到齐;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.ColumnHeader cl0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader 状态;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Timer timerExecute;
        private System.Windows.Forms.ColumnHeader cl2;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbNextExecuteTime;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusTime;
        private System.Windows.Forms.Timer timerCurrentTime;
        private System.Windows.Forms.ColumnHeader 拷贝完成;
        private System.Windows.Forms.ColumnHeader 检查通过;
        private System.Windows.Forms.NumericUpDown numSpan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbCanClearStart;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStripMenuItem menuFunc;
        private System.Windows.Forms.ToolStripMenuItem menuFuncClearDestFolder;
    }
}

