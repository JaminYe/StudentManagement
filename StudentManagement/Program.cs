using System;
using System.Windows.Forms;

namespace StudentManagement {
    static class Program {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main() {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Login login = new Login();
        login.ShowDialog();
        if (login.DialogResult == DialogResult.OK) {
        Application.Run(new Home());
        }
        }
    }
}
