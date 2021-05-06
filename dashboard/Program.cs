using System;
using System.Windows.Forms;

namespace dashboard
{
    static class Program
    {
        public static string FrmState;
        public static string UserName;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_login());
        }
    }
}
