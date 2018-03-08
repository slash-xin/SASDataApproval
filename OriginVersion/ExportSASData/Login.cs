using ExportSASData.Model;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;


namespace ExportSASData
{
   
    public partial class Login : Form
    {
        public static UserInfo currentUser = new UserInfo();
        public Login()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 登陆
        /// </summary>
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_user.Text) || String.IsNullOrEmpty(txt_pwd.Text))
                MessageBox.Show("请输入用户名或密码！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                lblogin_status.Text = "登陆中，请稍等。。。";
                try
                {
                    if (UserInfo.IsUserExist(txt_user.Text.Trim(), GetMD5(txt_pwd.Text.Trim()), "0,1,2"))
                    {
                        UserInfo user = UserInfo.getUserInfoByPhone(txt_user.Text.Trim());
                        currentUser = user;

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        txt_pwd.Text = "";
                        MessageBox.Show(String.Format("账号或密码错误,请重新输入"),
                          "登陆失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    lblogin_status.Text = "登陆失败,请重试";
                }
            }
        }
        /// <summary>
        /// 获取MD5
        /// </summary>
        /// <param name="str">字符串</param>
        /// <returns></returns>
        public static string GetMD5(string str)
        {
            byte[] result = Encoding.Default.GetBytes(str.Trim());
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            return BitConverter.ToString(output).Replace("-", "");
        }


    }
}
