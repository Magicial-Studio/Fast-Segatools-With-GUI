using System.Windows.Forms;

namespace FastSegatools_With_GUI
{
    public partial class IPTextBox : TextBox
    {
        public IPTextBox() : base()
        {
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ClassName = "SysIPAddress32";
                return cp;
            }
        }
    }
}
