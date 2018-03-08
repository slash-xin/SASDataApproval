using ExportApproval.Model;
using System;
using System.Windows.Forms;

namespace ExportApproval
{
    public partial class ChangePassForm : Form
    {
        public ChangePassForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 验证旧密码
        /// </summary>
        /// <returns></returns>
        private bool ValidOldPass()
        {
            return AuthUser.currentUser.UserPassword == Login.GetMD5(txt_oldpwd.Text.Trim());
        }

        /// <summary>
        /// 修改
        /// </summary>
        private void btnchange_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_oldpwd.Text) || String.IsNullOrEmpty(txt_newpwd.Text) || String.IsNullOrEmpty(txt_newcheck.Text))
            {
                MessageBox.Show("请输入密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_newpwd.Text != txt_newcheck.Text)
            {
                MessageBox.Show("两次输入的新密码不一致！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_newpwd.Text == txt_oldpwd.Text)
            {
                MessageBox.Show("新密码不能与旧密码相同！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!ValidOldPass())
            {
                MessageBox.Show("输入的旧密码错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (UserInfo.updateUserPwd(AuthUser.currentUser.UserId, Login.GetMD5(txt_newpwd.Text.Trim())) > 0)
                {
                    MessageBox.Show("密码修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AuthUser.currentUser.UserPassword = Login.GetMD5(txt_newpwd.Text.Trim());
                    this.Close();
                }
                else
                    MessageBox.Show("密码修改失败，请重试！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 取消
        /// </summary>
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
