namespace FastSegaTools_with_GUI
{
    partial class Startwin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startwin));
            this.Title1 = new System.Windows.Forms.Label();
            this.AboutFST = new System.Windows.Forms.Label();
            this.Warn1 = new System.Windows.Forms.Label();
            this.Agree = new System.Windows.Forms.CheckBox();
            this.Start = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title1
            // 
            this.Title1.AutoSize = true;
            this.Title1.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.Title1.Location = new System.Drawing.Point(47, 9);
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(334, 27);
            this.Title1.TabIndex = 0;
            this.Title1.Text = "欢迎使用Fast SegaTools配置工具！";
            this.Title1.Click += new System.EventHandler(this.Title1_Click);
            // 
            // AboutFST
            // 
            this.AboutFST.AutoSize = true;
            this.AboutFST.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AboutFST.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.AboutFST.Location = new System.Drawing.Point(75, 45);
            this.AboutFST.Name = "AboutFST";
            this.AboutFST.Size = new System.Drawing.Size(261, 80);
            this.AboutFST.TabIndex = 1;
            this.AboutFST.Text = "本程序能协助您快速地配置SegaTools\r\n而无需修改那些令人眼花缭乱的内容\r\n这已经是一个连🐴都会用的程序了\r\n如果不会，那么我就无能为力了！！！！";
            this.AboutFST.Click += new System.EventHandler(this.AboutFST_Click);
            // 
            // Warn1
            // 
            this.Warn1.AutoSize = true;
            this.Warn1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.Warn1.ForeColor = System.Drawing.Color.Red;
            this.Warn1.Location = new System.Drawing.Point(49, 134);
            this.Warn1.Name = "Warn1";
            this.Warn1.Size = new System.Drawing.Size(320, 34);
            this.Warn1.TabIndex = 2;
            this.Warn1.Text = "注意：请在使用前备份segatools.ini\r\n本程序作者不对任何此程序产生的系统崩溃，数据丢失负责\r\n";
            // 
            // Agree
            // 
            this.Agree.AutoSize = true;
            this.Agree.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Agree.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.Agree.Location = new System.Drawing.Point(130, 171);
            this.Agree.Name = "Agree";
            this.Agree.Size = new System.Drawing.Size(127, 21);
            this.Agree.TabIndex = 3;
            this.Agree.Text = "是的是的 我知道了";
            this.Agree.UseVisualStyleBackColor = true;
            this.Agree.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Start
            // 
            this.Start.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Start.Enabled = false;
            this.Start.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.Start.Location = new System.Drawing.Point(91, 198);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 4;
            this.Start.Text = "开始";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(217, 198);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Startwin
            // 
            this.AcceptButton = this.Start;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(401, 250);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Agree);
            this.Controls.Add(this.Warn1);
            this.Controls.Add(this.AboutFST);
            this.Controls.Add(this.Title1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Startwin";
            this.Text = "Fast SegaTools";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title1;
        private System.Windows.Forms.CheckBox Agree;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Cancel;
        public System.Windows.Forms.Label AboutFST;
        public System.Windows.Forms.Label Warn1;
    }
}

