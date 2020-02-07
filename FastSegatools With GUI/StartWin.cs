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
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.IO;


namespace FastSegaTools_with_GUI
{
    public partial class Startwin : Form
    {
        public Startwin()
        {
            InitializeComponent();
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
            ConfigForm newForm = new ConfigForm();
            this.Hide();
            newForm.Show();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public static string[] GetLocalIPs()
        {
            try
            {
        
                NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
                var result = new List<string>();

                foreach (var net in nics)
                {
                    
  
                    IPInterfaceProperties ipps = net.GetIPProperties();
                    var ips = ipps.UnicastAddresses;

                    foreach(var ua in ips)
                    {
                        if ((ua.Address.AddressFamily == AddressFamily.InterNetwork) && (ua.PrefixOrigin.ToString() == "Dhcp" || ua.PrefixOrigin.ToString() == "Manual"))
                        {
                            var ip = ua.Address.GetAddressBytes();
                            var mask = ua.IPv4Mask.GetAddressBytes();

                            for (var i = 0; i < ip.Length; i++)
                            {
                                ip[i] &= mask[i];
                            }

                            IPAddress addr = new IPAddress(ip);
                            result.Add(addr.ToString());
                        }
                        
                    }

                    
         
                }

                return result.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show("获取IP地址出错！" + ex.Message);
                return null;
            }

        }

        private void Startwin_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Directory.GetCurrentDirectory() + "/segatools.ini"))
            {
                MessageBox.Show(this, "请将本程序放至游戏文件夹下！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

    }
}
