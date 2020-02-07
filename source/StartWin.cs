using FastSegatools_With_GUI.Properties;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastSegaTools_with_GUI
{
    public partial class Startwin : Form
    {
        private readonly string segatools_ini = "segatools.ini";

        public Startwin()
        {
            InitializeComponent();
            if (System.IO.File.Exists(@"Custom")) Server_textBox.Text = System.IO.File.ReadAllText(@"Custom");
        }

        private void Start_Click(object sender, EventArgs e)
        {
            /*
                        if (MessageBox.Show("确认设定？", "", MessageBoxButtons.OKCancel) != DialogResult.OK)
                        {
                            info_label.Text = "已取消";
                            return;
                        }
            */
            var subnet = subnet_label.Text;
            var server = Server_textBox.Text;

            if (server == "" || subnet == "")
            {
                info_label.Text = @"未输入服务器或IPv4地址";
                return;
            }

            if (server == "localhost" || server == "127.0.0.1")
            {
                info_label.Text = @"DIVA 不接受本地本地环回地址";
                return;
            }

            string path;
            if (checkBox1.Checked)
            {
                path = SelectINI();
                if (path == "")
                {
                    info_label.Text = @"已取消";
                    return;
                }
            }
            else
            {
                if (!File.Exists(segatools_ini))
                    try
                    {
                        File.WriteAllText(segatools_ini, Resources.segatools_ini);
                    }
                    catch
                    {
                        throw new Exception(@"无法在当前目录下保存 " + segatools_ini);
                    }

                path = segatools_ini;
            }

            WriteSetting(path);
        }

        [DllImport("KERNEL32.DLL", EntryPoint = "WritePrivateProfileStringW",
            SetLastError = true,
            CharSet = CharSet.Unicode, ExactSpelling = true,
            CallingConvention = CallingConvention.StdCall)]
        private static extern int WritePrivateProfileStringW(
            string lpAppName,
            string lpKeyName,
            string lpString,
            string lpFilename);

        private void WriteSetting(string path)
        {
            // 写入配置
            WritePrivateProfileStringW("dns", "default", Server_textBox.Text, path);
            WritePrivateProfileStringW("keychip", "subnet", subnet_label.Text, path);
            info_label.Text = @"已保存入" + path;
        }


        private string SelectINI()
        {
            // 选择已有配置
            var divaPath = "";
            // 预测diva.exe路径
            var key = Registry.CurrentUser.OpenSubKey(
                "SOFTWARE\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache");
            if (key != null)
            {
                var keyNames = key.GetValueNames();
                foreach (var n in keyNames)
                {
                    if (!n.Contains("diva.exe")) continue;
                    var gamePath = n.Remove(n.LastIndexOf('\\') + 1);
                    if (!Directory.Exists(gamePath)) continue;
                    divaPath = gamePath;
                    break;
                }
            }

            var openFileDialog1 = new OpenFileDialog
            {
                Filter = segatools_ini + "|" + segatools_ini,
                FilterIndex = 0,
                InitialDirectory = divaPath,
                RestoreDirectory = true
            };


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                divaPath = openFileDialog1.FileName;
                return divaPath;
            }

            return "";
        }

        private static int TestServer(string server)
        {
            // 测试延迟
            Ping pinger = null;
            var delay = -1;
            try
            {
                pinger = new Ping();
                var reply = pinger.Send(server);
                var pingRelied = reply.Status == IPStatus.Success;
                if (pingRelied)
                    delay = (int)reply.RoundtripTime;
                else
                    delay = -1;
            }
            catch (PingException)
            {
                // Discard PingExceptions and return false;
            }
            finally
            {
                pinger?.Dispose();
            }

            return delay;
        }

        private static string GetIP()
        {
            // 得到活动ip
            foreach (var network in NetworkInterface.GetAllNetworkInterfaces())
                if (network.OperationalStatus == OperationalStatus.Up &&
                    network.GetIPProperties()?.GatewayAddresses.Count != 0)
                    foreach (var ip in network.GetIPProperties().UnicastAddresses)
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                            return ip.Address.ToString();
            return "";
        }

        private string GetSubnet(string ip)
        {
            // 从ip得到子网
            if (ip.Split('.').Length != 4)
                return "";
            return ip.Remove(ip.LastIndexOf('.') + 1) + "0";
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_info_TextChanged(object sender, EventArgs e)
        {
            // 自动重置信息
            if (info_label.Text != "")
                Task.Run(() =>
                {
                    Thread.Sleep(2000);
                    Invoke((Action)(() => info_label.Text = ""));
                    return 1;
                });
        }

        private void Startwin_Load(object sender, EventArgs e)
        {
            // 初始化
            ipTextBox.Text = GetIP();
            if (ipTextBox.Text != @"0.0.0.0")
                ipTextBox.Enabled = false;
            subnet_label.Text = GetSubnet(ipTextBox.Text);
        }

        private void ipTextBox_TextChanged(object sender, EventArgs e)
        {
            // ip变化更新子网
            try
            {
                subnet_label.Text = GetSubnet(ipTextBox.Text);
            }
            catch
            {
                subnet_label.Text = "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                var delay = TestServer(Server_textBox.Text).ToString();
                //UpdateDelay(delay);

                Invoke((Action)(() => delay_label.Text = @"Delay: " + delay + @"ms"));
                return 1;
            });
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (ModifierKeys == Keys.Control) ipTextBox.Enabled = !ipTextBox.Enabled;
        }

        private void Server_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}