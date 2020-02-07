using FastSegatools_With_GUI;
using FastSegatools_With_GUI.Properties;

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
            this.components = new System.ComponentModel.Container();
            this.Title1 = new System.Windows.Forms.Label();
            this.Set = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Server_textBox = new System.Windows.Forms.TextBox();
            this.info_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.subnet_label = new System.Windows.Forms.Label();
            this.subnetText_label = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.delay_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ipTextBox = new FastSegatools_With_GUI.IPTextBox();
            this.SuspendLayout();
            // 
            // Title1
            // 
            this.Title1.AutoSize = true;
            this.Title1.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.Title1.Location = new System.Drawing.Point(110, 22);
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(222, 27);
            this.Title1.TabIndex = 0;
            this.Title1.Text = "配置 SegaTools 服务器";
            // 
            // Set
            // 
            this.Set.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Set.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.Set.Location = new System.Drawing.Point(199, 211);
            this.Set.Name = "Set";
            this.Set.Size = new System.Drawing.Size(75, 23);
            this.Set.TabIndex = 2;
            this.Set.Text = "设置";
            this.Set.UseVisualStyleBackColor = true;
            this.Set.Click += new System.EventHandler(this.Start_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(314, 211);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Server:";
            // 
            // Server_textBox
            // 
            this.Server_textBox.Location = new System.Drawing.Point(115, 152);
            this.Server_textBox.Name = "Server_textBox";
            this.Server_textBox.Size = new System.Drawing.Size(152, 21);
            this.Server_textBox.TabIndex = 1;
            this.Server_textBox.TextChanged += new System.EventHandler(this.Server_textBox_TextChanged);
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.Location = new System.Drawing.Point(10, 183);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(0, 12);
            this.info_label.TabIndex = 8;
            this.info_label.TextChanged += new System.EventHandler(this.label_info_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "IPv4:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // subnet_label
            // 
            this.subnet_label.AutoSize = true;
            this.subnet_label.Location = new System.Drawing.Point(118, 122);
            this.subnet_label.Name = "subnet_label";
            this.subnet_label.Size = new System.Drawing.Size(0, 12);
            this.subnet_label.TabIndex = 8;
            // 
            // subnetText_label
            // 
            this.subnetText_label.AutoSize = true;
            this.subnetText_label.Location = new System.Drawing.Point(46, 122);
            this.subnetText_label.Name = "subnetText_label";
            this.subnetText_label.Size = new System.Drawing.Size(47, 12);
            this.subnetText_label.TabIndex = 9;
            this.subnetText_label.Text = "Subnet:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(9, 213);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(156, 16);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "更改已有 segatools.ini";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // delay_label
            // 
            this.delay_label.AutoSize = true;
            this.delay_label.Location = new System.Drawing.Point(287, 159);
            this.delay_label.Name = "delay_label";
            this.delay_label.Size = new System.Drawing.Size(71, 12);
            this.delay_label.TabIndex = 8;
            this.delay_label.Text = "Delay: -1ms";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(115, 84);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(123, 21);
            this.ipTextBox.TabIndex = 1;
            this.ipTextBox.Text = "0.0.0.0";
            this.ipTextBox.TextChanged += new System.EventHandler(this.ipTextBox_TextChanged);
            // 
            // Startwin
            // 
            this.AcceptButton = this.Set;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(401, 246);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.subnetText_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subnet_label);
            this.Controls.Add(this.delay_label);
            this.Controls.Add(this.info_label);
            this.Controls.Add(this.Server_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Set);
            this.Controls.Add(this.Title1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = global::FastSegatools_With_GUI.Properties.Resources.Icon;
            this.Name = "Startwin";
            this.Text = "Fast SegaTools";
            this.Load += new System.EventHandler(this.Startwin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title1;
        private System.Windows.Forms.Button Set;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Server_textBox;
        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label subnet_label;
        private System.Windows.Forms.Label subnetText_label;
        private IPTextBox ipTextBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label delay_label;
    }
}

