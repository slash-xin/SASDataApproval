using System;
using System.Configuration;
using System.Windows.Forms;

namespace ExportApproval
{
    public partial class AuthAdmin : Form
    {
        public AuthAdmin()
        {
            InitializeComponent();
        }
        string salt = "CMCC";
        string authValue = "9CB2FD26BB987F2D89460A14A505E287";
        private void btnsure_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txt_authpwd.Text.Trim()))
            {
                MessageBox.Show("请输入管理密码！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string authAdmin = ConfigurationManager.AppSettings["authAdmin"];
            if (authAdmin == null) authAdmin = authValue;
            if (authAdmin == Login.GetMD5(salt + txt_authpwd.Text.Trim()))
            {
                new DataManagement().Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("密码错误,请重新输入！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
