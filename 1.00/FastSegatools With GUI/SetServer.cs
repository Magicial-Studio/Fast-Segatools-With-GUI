using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FastSegatools_With_GUI
{
    public partial class SetServer : Form
    {
        public SetServer()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") MessageBox.Show("服务器域名不能为空");
            else
            {
                String ServerName = textBox1.Text;
                String IPName = System.IO.File.ReadAllText(@"Time");
                File.Delete("Time");
                String FinalServerName = "default=" + ServerName;
                String FinalIPName = "subnet=" + IPName;
                //从此行开始输出Segatools.ini
                    System.IO.File.WriteAllText("segatools.ini","");
                    File.AppendAllText(@"segatools.ini", "[vfs]"+ Environment.NewLine); 
                    File.AppendAllText(@"segatools.ini", "; Insert the path to the game AMFS directory here (contains ICF1 and ICF2)" + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "amfs=C:\\" + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "; Create an empty directory somewhere and insert the path here." + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "; This directory may be shared between multiple SEGA games." + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "; NOTE: This has nothing to do with Windows %APPDATA%." + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "appdata=C:\\" + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "" + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "[dns]" + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "; Insert the hostname or IP address of the server you wish to use here." + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "; Note that 127.0.0.1, localhost etc are specifically rejected." + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", FinalServerName + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "" + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "[ds]" + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "; Region code on the emulated AMEX board DS EEPROM." + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "; 1: Japan" + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "; 4: Export (some UI elements in English)" + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", ";" + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "; NOTE: Changing this setting causes a factory reset." + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "region=1" + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "" + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "[netenv]" + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "; Simulate an ideal LAN environment. This may interfere with head-to-head play." + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "; SEGA games are somewhat picky about their LAN environment, so leaving this" + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "; setting enabled is recommended." + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "enable=1" + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "" + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "[keychip]" + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "; The /24 LAN subnet that the emulated keychip will tell the game to expect." + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "; If you disable netenv then you must set this to your LAN's IP subnet, and" + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "; that subnet must start with 192.168." + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", FinalIPName + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "id=A69E-01A88888888" + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "" + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "[gpio]" + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "; Emulated Nu DIP switch for Distribution Server setting." + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", ";" + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "; If multiple machines are present on the same LAN then set this to 1 on" + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "; exactly one machine and set this to 0 on all others." + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "dipsw1=0" + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "" + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "[io3]" + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "; Input API selection for JVS input emulator." + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "mode=xinput" + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "; Automatically reset the simulated shifter to Neutral when XInput Start is" + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "; pressed (e.g. when navigating menus between races)." + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "autoNeutral=1" + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "" + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "[gfx]" + Environment.NewLine);
                    File.AppendAllText(@"segatools.ini", "enable=0");
                //从此行结束输出Segatools.ini
                MessageBox.Show("配置已经完成 请将此程序生成的segatools.ini拖入游戏文件夹内，替换原本的segatools.ini");
                MessageBox.Show("请备份原文件，本人不对任何此程序产生的系统崩溃，游戏数据丢失负责");
                Application.Exit();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
