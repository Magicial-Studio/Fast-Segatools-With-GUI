using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace FastSegaTools_with_GUI
{
    public partial class ConfigForm : Form
    {
        private string[] localaddrs;
        private configParser cf;
        public ConfigForm()
        {
            InitializeComponent();
            cf = new configParser(Directory.GetCurrentDirectory() + "/segatools.ini");
        }

        private void SetIP_Load(object sender, EventArgs e)
        {
            localaddrs = Startwin.GetLocalIPs();

            if (localaddrs != null)
            {
                cbxaddr.Items.AddRange(localaddrs);
                cbxaddr.SelectedIndex = 0;
            }

            var server = cf.Read("dns", "default");
            tbxserver.Text = server;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (cbxaddr.SelectedIndex < 0 || tbxserver.Text.Trim() == "")
            {
                MessageBox.Show(this, "请输入完整！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cf.Write("keychip", "subnet", cbxaddr.Text);
            cf.Write("dns", "default", tbxserver.Text);
            MessageBox.Show(this, "保存完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ConfigForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
