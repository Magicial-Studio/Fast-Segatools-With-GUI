using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace FastSegatools_With_GUI
{
    public partial class SetIP : Form
    {
                
        public SetIP()
        {
            InitializeComponent();
            textBox1.Text= System.IO.File.ReadAllText(@"Time");
        }

        private void Next_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "") MessageBox.Show("IP地址段不能为空");
            else
            {
                String IPname = textBox1.Text;
                System.IO.File.WriteAllText(@"Time", IPname);
                SetServer newForm = new SetServer();//声明新窗体，Formmain是已设计好的并列窗体
                newForm.Show();//打开新窗体
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Help_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void SetIP_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
