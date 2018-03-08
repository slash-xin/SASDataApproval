using System;
using System.Windows.Forms;

namespace ExportApproval
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // 12.2 去掉登陆过程，通过系统用户直接登录
            //Login login = new Login();
            //login.ShowDialog();
            //if (login.DialogResult == DialogResult.OK)
            //{
            //    Application.Run(new ApprovalForm());
            //}

            AuthUser user = new AuthUser();
            // user.ShowDialog();
            if (user.DialogResult == DialogResult.OK)
            {
                user.Close();
                Application.Run(new ApprovalForm());
            }
        }
    }
}
