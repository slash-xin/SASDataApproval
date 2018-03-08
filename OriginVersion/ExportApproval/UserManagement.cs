using ExportApproval.Model;
using System;
using System.Collections;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ExportApproval
{
    public partial class UserManagement : Form
    {
        bool isedit = false;
        public UserManagement(bool isEdit)
        {
            InitializeComponent();
            isedit = isEdit;
            InitData();
        }

        private void InitData()
        {
            UserInfo user = DataManagement.currentuser;
            bindLeader();
            bindUserType();
            if (isedit)
            {
                lb_pwd.Visible = false;
                txt_pwd.Visible = false;
                txt_username.Text = user.UserName;
                txt_phone.Text = user.UserPhone;
                txt_region.Text = user.UserRegion;
                txt_department.Text = user.UserDepartment;
                txt_systemid.Text = user.SystemId;
            }
        }
        private void bindUserType()
        { 
            //string[] type = new string[] {"申请人", "领导", "管理员"};
            //int[] typeid = new int[] { 0, 1, 2 };
            cb_usertype.Items.Clear();
            ArrayList array = new ArrayList();
            array.Add(new DictionaryEntry(0, "申请人"));
            array.Add(new DictionaryEntry(1, "上级领导"));
            array.Add(new DictionaryEntry(2, "管理员"));
            cb_usertype.DataSource = array;
            cb_usertype.DisplayMember = "Value";
            cb_usertype.ValueMember = "Key";
            cb_usertype.SelectedIndex = 0;
        }

        private void bindLeader()
        {
            clb_leader.Items.Clear();
            clb_leader.DataSource = UserInfo.getUserInfoByType("1");
            clb_leader.DisplayMember = "user_name";
            clb_leader.ValueMember = "user_id";
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            
            if (!checkControlsData()) return;
            if (!UserInfo.IsUserExistById(txt_phone.Text.Trim()))
            {
                UserInfo user = new UserInfo();
                user.UserId = user.UserAccount = user.UserPhone = txt_phone.Text.Trim();
                user.UserName = txt_username.Text.Trim();
                user.UserPassword = Login.GetMD5(txt_pwd.Text.Trim());
                user.UserType = cb_usertype.SelectedIndex.ToString();
                user.UserRegion = txt_region.Text.Trim();
                user.UserDepartment = txt_department.Text.Trim();
                user.SystemId = txt_systemid.Text.Trim();
                try
                {
                    if (isedit)
                    {
                        UserInfo.deleteUserInfo(DataManagement.currentuser.UserId);
                        UserRelation.deleteUserFrelationInfo(DataManagement.currentuser.UserId);
                    }
                    UserInfo.addUserInfo(user);
                    UserRelation ur = new UserRelation();
                    for (int i = 0; i < this.clb_leader.CheckedItems.Count; i++)
                    {
                        ur.applyUserId = txt_phone.Text.Trim();
                        ur.fapprovalUserId = ((DataRowView)this.clb_leader.CheckedItems[i])[0].ToString();
                        UserRelation.addUserRelation(ur);
                    }
                    MessageBox.Show("成功");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("失败，请稍后再试" + ex.ToString());
                }
                
            }
            else
            {
                MessageBox.Show("失败，已经存在该手机号码");
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            resetControls(this);
        }
        private void resetControls(Control control)
        {
            foreach(Control ctl in control.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = "";
                }
                if (ctl is ComboBox)
                {
                    (ctl as ComboBox).SelectedIndex = 0;
                }
                if (ctl is CheckedListBox)
                {
                    for (int i = 0; i < clb_leader.Items.Count; i++)
                    {
                        clb_leader.SetItemChecked(i, false);
                    }
                }
            }
        }

        private bool checkControlsData()
        {
            if(isempty(this.txt_username.Text)|| isempty(this.txt_pwd.Text)|| isempty(this.txt_phone.Text)|| isempty(this.txt_region.Text) || isempty(this.txt_department.Text) || isempty(this.txt_systemid.Text))
            {
                MessageBox.Show("文本框不能为空");
                return false;

            }
            if (!validMobile(this.txt_phone.Text))
            {
                MessageBox.Show("手机号码不正确");
                return false;
            }
            if (this.clb_leader.CheckedItems.Count==0 && lb_leader.Visible == true)
            {
                MessageBox.Show("最少需选择一个上级领导。");
                return false;
            }
            return true;
        }

        private bool isempty(string txt)
        {
            return string.IsNullOrEmpty(txt.Trim());
        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static bool validMobile(string mobile)
        {
            if (string.IsNullOrEmpty(mobile))
                return false;

            return Regex.IsMatch(mobile, @"^(13|14|15|16|17|18|19)\d{9}$");
        }

        private void cbusertype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((DictionaryEntry)cb_usertype.SelectedItem).Value.ToString() == "申请人")
            {
                lb_leader.Visible = true;
                clb_leader.Visible = true;
            }
            else
            {
                for (int i = 0; i < clb_leader.Items.Count; i++)
                {
                    clb_leader.SetItemChecked(i, false);
                }
                lb_leader.Visible = false;
                clb_leader.Visible = false;
                
            }
        }
    }
}
