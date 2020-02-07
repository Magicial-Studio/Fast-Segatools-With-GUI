using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text;
using System.IO;

namespace FastSegaTools_with_GUI
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FastSegaTools_with_GUI.Startwin());
            //Supported BY Fantasy GM
            //Supported BY Eraser
            //Supported BY WM86
            //Supported BY Silpher
            //Thank You !
        }
    }

    public class configParser
    {
        public string inipath;
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        [DllImport("Kernel32.dll")]
        static extern int WideCharToMultiByte(
          uint CodePage,
          uint dwFlags,
          [In, MarshalAs(UnmanagedType.LPWStr)]string lpWideCharStr,
          int cchWideChar,
          [Out, MarshalAs(UnmanagedType.LPStr)]StringBuilder lpMultiByteStr,
          int cbMultiByte,
          IntPtr lpDefaultChar, // Defined as IntPtr because in most cases is better to pass
          IntPtr lpUsedDefaultChar // NULL
          );
        private int buf_size = 512;
        public configParser(string INIPath)
        {
            if (INIPath.IndexOf(":") == -1)
            {
                inipath = System.Environment.CurrentDirectory + "\\" + INIPath;
            }
            else
                inipath = INIPath;
        }

        public void Write(string Section, string Key, int Value)
        {
            this.Write(Section, Key, Value.ToString());
        }

        public void Write(string Section, string Key, bool Value)
        {
            this.Write(Section, Key, Value ? "1" : "0");
        }

        public void Write(string Section, string Key, decimal Value)
        {
            this.Write(Section, Key, Value.ToString());
        }

        public void Write(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, this.inipath);
        }

        public string Read(string Section, string Key)
        {
            StringBuilder temp;
            int i = 0;
            int fac = 0;

            do
            {
                fac++;
                temp = new StringBuilder(buf_size * fac);
                i = GetPrivateProfileString(Section, Key, "", temp, buf_size * fac, this.inipath);
            } while (i == buf_size * fac - 1 || i == buf_size * fac - 2);

            return temp.ToString();
        }


        public int ReadInt(string Section, string Key)
        {
            string v = this.Read(Section, Key);
            if (v == "") v = "0";
            return int.Parse(v);
        }
        public float ReadFloat(string Section, string Key)
        {
            string v = this.Read(Section, Key);
            if (v == "") v = "0";
            return float.Parse(v);
        }
        public bool ReadBool(string Section, string Key)
        {
            string v = this.Read(Section, Key);
            return v == "1";
        }
        public bool ExistINIFile()
        {
            return File.Exists(inipath);
        }

        public List<string> EnumIniKey(string sectionName)
        {
            string[] IniText = File.ReadAllLines(inipath, Encoding.Default);
            List<string> KeyList = new List<string>();

            string curs = null;

            for (int i = 0; i != IniText.Length; i++)
            {
                string Text = IniText[i].Trim();
                if (Text == "")
                    continue;
                if (Text[0] == '[' && Text[Text.Length - 1] == ']')
                {
                    curs = Text;

                }
                else
                {

                    if (curs == "[" + sectionName + "]")
                        KeyList.Add(Text);
                }


            }
            return KeyList;

        }


    }


}
