using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace 校园测量控制点管理系统
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            登录1  login = new 登录1();
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new 控制点管理());
            }
        }
    }
    
}
