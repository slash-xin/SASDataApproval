using ExportApproval.Model;
using System;
using System.Windows.Forms;

namespace ExportApproval
{
    public partial class AuthUser : Form
    {
        public static UserInfo currentUser = new UserInfo();
        public AuthUser()
        {
            InitializeComponent();
            autoAuthUser();
        }

        /// <summary>
        /// 登陆
        /// </summary>
        private void autoAuthUser()
        {
            string systemid = Environment.UserName.ToLower();
            lbLoading.Text = "正在登陆：" + systemid;
            try
            {
                UserInfo user = UserInfo.getUserInfoBySyatemId(systemid);
                if (user != null)
                {
                    // UserInfo user = UserInfo.getUserInfoBySyatemId(systemid);
                    if ((ApprovalForm.UserType)Convert.ToInt32(user.UserType) == ApprovalForm.UserType.apply)
                    {
                        MessageBox.Show(String.Format("没有审批权限。"), "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        currentUser = user;
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    MessageBox.Show(String.Format("用户不存在，请联系管理员"),
                      "登陆失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show(String.Format("登陆失败，稍后再试"),
                      "登陆失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
