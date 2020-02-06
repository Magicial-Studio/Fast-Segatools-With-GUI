using FastSegatools_With_GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.Sockets;
using System.Net;

namespace FastSegaTools_with_GUI
{
    public partial class Startwin : Form
    {
        public Startwin()
        {
            InitializeComponent();
        }

        private void Title1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Agree.Checked == true) Start.Enabled = true;
            else Start.Enabled = false;
        }

        private void AboutFST_Click(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            String ip = "0.0.0.0";


            try
            {
                string hostname = Dns.GetHostName();
                IPAddress[] ipadrlist = Dns.GetHostAddresses(hostname);
                foreach (IPAddress ipadr in ipadrlist)
                {
                    if (ipadr.AddressFamily == AddressFamily.InterNetwork)
                    {//判断是否IPv4
                        ip = ipadr.ToString();
                        
                        break;
                    }
                }
            }
            catch { }


            String FinalIP=ip.Remove(ip.LastIndexOf('.') + 1) + "0";
            System.IO.File.WriteAllText(@"Time", FinalIP);
            SetIP newForm = new SetIP();//声明新窗体，Formmain是已设计好的并列窗体
            newForm.Show();//打开新窗体
            }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
