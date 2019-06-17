namespace WinTracert
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTBLayout = new System.Windows.Forms.TableLayoutPanel();
            this.IPLabel = new System.Windows.Forms.Label();
            this.IPAddress = new System.Windows.Forms.TextBox();
            this.IPTips = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.tipsLabel = new System.Windows.Forms.Label();
            this.TipsShow = new System.Windows.Forms.Label();
            this.mainTBLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTBLayout
            // 
            this.mainTBLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTBLayout.ColumnCount = 4;
            this.mainTBLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.17291F));
            this.mainTBLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.82709F));
            this.mainTBLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.mainTBLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.mainTBLayout.Controls.Add(this.IPLabel, 0, 0);
            this.mainTBLayout.Controls.Add(this.IPAddress, 1, 0);
            this.mainTBLayout.Controls.Add(this.IPTips, 2, 0);
            this.mainTBLayout.Controls.Add(this.btnStart, 3, 0);
            this.mainTBLayout.Controls.Add(this.richTextBoxLog, 0, 1);
            this.mainTBLayout.Controls.Add(this.tipsLabel, 0, 2);
            this.mainTBLayout.Controls.Add(this.TipsShow, 1, 2);
            this.mainTBLayout.Location = new System.Drawing.Point(13, 13);
            this.mainTBLayout.Name = "mainTBLayout";
            this.mainTBLayout.RowCount = 3;
            this.mainTBLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.349206F));
            this.mainTBLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.65079F));
            this.mainTBLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTBLayout.Size = new System.Drawing.Size(475, 461);
            this.mainTBLayout.TabIndex = 0;
            // 
            // IPLabel
            // 
            this.IPLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.IPLabel.AutoSize = true;
            this.IPLabel.Location = new System.Drawing.Point(3, 8);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(57, 12);
            this.IPLabel.TabIndex = 0;
            this.IPLabel.Text = "IP 地址";
            this.IPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IPAddress
            // 
            this.IPAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.IPAddress.Location = new System.Drawing.Point(66, 3);
            this.IPAddress.Name = "IPAddress";
            this.IPAddress.Size = new System.Drawing.Size(245, 21);
            this.IPAddress.TabIndex = 1;
            this.IPAddress.TextChanged += new System.EventHandler(this.IPAddress_TextChanged);
            // 
            // IPTips
            // 
            this.IPTips.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.IPTips.AutoSize = true;
            this.IPTips.Location = new System.Drawing.Point(317, 8);
            this.IPTips.Name = "IPTips";
            this.IPTips.Size = new System.Drawing.Size(71, 12);
            this.IPTips.TabIndex = 2;
            this.IPTips.Text = "ipTips";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(394, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(78, 22);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "测试";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxLog.BackColor = System.Drawing.SystemColors.MenuText;
            this.mainTBLayout.SetColumnSpan(this.richTextBoxLog, 4);
            this.richTextBoxLog.ForeColor = System.Drawing.Color.White;
            this.richTextBoxLog.Location = new System.Drawing.Point(3, 34);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.Size = new System.Drawing.Size(469, 400);
            this.richTextBoxLog.TabIndex = 4;
            this.richTextBoxLog.Text = "";
            this.richTextBoxLog.TextChanged += new System.EventHandler(this.richTextBoxLog_TextChanged);
            // 
            // tipsLabel
            // 
            this.tipsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tipsLabel.AutoSize = true;
            this.tipsLabel.Location = new System.Drawing.Point(3, 445);
            this.tipsLabel.Name = "tipsLabel";
            this.tipsLabel.Size = new System.Drawing.Size(57, 12);
            this.tipsLabel.TabIndex = 5;
            this.tipsLabel.Text = "Tips:";
            this.tipsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TipsShow
            // 
            this.TipsShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TipsShow.AutoSize = true;
            this.mainTBLayout.SetColumnSpan(this.TipsShow, 3);
            this.TipsShow.ForeColor = System.Drawing.Color.OrangeRed;
            this.TipsShow.Location = new System.Drawing.Point(66, 445);
            this.TipsShow.Name = "TipsShow";
            this.TipsShow.Size = new System.Drawing.Size(406, 12);
            this.TipsShow.TabIndex = 6;
            this.TipsShow.Text = "info";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 550);
            this.Controls.Add(this.mainTBLayout);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Tracert Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Closing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainTBLayout.ResumeLayout(false);
            this.mainTBLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTBLayout;
        public  System.Windows.Forms.Label IPLabel;
        public System.Windows.Forms.TextBox IPAddress;
        public System.Windows.Forms.Label IPTips;
        public System.Windows.Forms.Button btnStart;
        public System.Windows.Forms.RichTextBox richTextBoxLog;
        public System.Windows.Forms.Label tipsLabel;
        public System.Windows.Forms.Label TipsShow;
    }
}

