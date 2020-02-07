using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FastSegatools_With_GUI
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
}
