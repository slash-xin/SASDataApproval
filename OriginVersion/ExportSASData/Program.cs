using System;
using System.Windows.Forms;

namespace ExportSASData
{

    static class Program
    {

        [STAThread]
        static void Main()
        {
            //Login login = new Login();
            //login.ShowDialog();
            //if (login.DialogResult == DialogResult.OK)
            //{
            //    Application.Run(new ExportForm());
            //}
            AuthUser user = new AuthUser();
            if (user.DialogResult == DialogResult.OK)
            {
                user.Close();
                Application.Run(new ExportForm());
            }
        }
    }
}
