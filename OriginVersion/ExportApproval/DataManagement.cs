using ExportApproval.Model;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ExportApproval
{
    public partial class DataManagement : Form
    {
        int currentTabIndex = 0;
        DataTable currentTable = new DataTable();
        public static UserInfo currentuser = new UserInfo();

        public enum TabType
        {
            apply = 0,  // 申请信息
            approval = 1, // 审批历史信息
            user = 2, // 用户信息
        }
        public DataManagement()
        {
            InitializeComponent();
            bindApplyInfo();
        }

        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentTabIndex = tabs.SelectedIndex;
            //DataGridView CurrentDataGrid = getCurrentDataGrid();
            //if (CurrentDataGrid.DataSource == null)
            //{
            //    CurrentDataGrid.DataSource = ApplyInfo.getAllApplyInfo();
            //}
            if ((TabType)tabs.SelectedIndex == TabType.apply && this.dataGridApply.DataSource == null)
            {
                bindApplyInfo();
            }
            if ((TabType)tabs.SelectedIndex == TabType.approval)
            {
                bindApprovalInfo();
            }
            if ((TabType)tabs.SelectedIndex == TabType.user)
            {
                bindUserInfo();
            }

        }
        private DataGridView getCurrentDataGrid()
        {
            if ((TabType)tabs.SelectedIndex == TabType.apply)
            {
                return this.dataGridApply;
            }
            if ((TabType)tabs.SelectedIndex == TabType.approval)
            {
                return this.dataGridApproval;
            }
            return this.dataGridUser;
        }
        private void bindApplyInfo()
        {
            currentTable = ApplyInfo.getAllApplyInfo();
            this.dataGridApply.DataSource = currentTable;
        }
        private void bindApprovalInfo()
        {
            currentTable = ApprovalRecord.getAllApprovalInfo();
            this.dataGridApproval.DataSource = currentTable;
        }
        private void bindUserInfo()
        {
            currentTable = UserInfo.getAllUserInfo();
            this.dataGridUser.DataSource = currentTable;
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("是否删除该数据？", "是否删除该数据", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if ((TabType)tabs.SelectedIndex == TabType.apply && dataGridApply.SelectedRows.Count > 0)
                {
                    string applyid = dataGridApply.SelectedRows[0].Cells["申请ID"].Value.ToString();
                    ApplyInfo.deleteApplyInfo(applyid);
                    bindApplyInfo();
                }
                if ((TabType)tabs.SelectedIndex == TabType.approval && dataGridApproval.SelectedRows.Count > 0)
                {
                    string applyid = dataGridApproval.SelectedRows[0].Cells["申请ID"].Value.ToString();
                    ApprovalRecord.deleteApprovalInfo(applyid);
                    bindApprovalInfo();
                }
                if ((TabType)tabs.SelectedIndex == TabType.user && dataGridUser.SelectedRows.Count > 0)
                {
                    string userid = dataGridUser.SelectedRows[0].Cells["ID"].Value.ToString();
                    UserInfo.deleteUserInfo(userid);
                    UserRelation.deleteUserFrelationInfo(userid);
                    bindUserInfo();
                }
            }
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            new ExportPath(currentTable).ShowDialog();
        }

        private void tabs_DrawItem(object sender, DrawItemEventArgs e)
        {
            //标签背景填充颜色
            SolidBrush BackBrush = new SolidBrush(Color.Red);
            //标签文字填充颜色
            SolidBrush FrontBrush = new SolidBrush(Color.Black);
            StringFormat StringF = new StringFormat();
            //设置文字对齐方式
            StringF.Alignment = StringAlignment.Center;
            StringF.LineAlignment = StringAlignment.Center;
            Rectangle Rec = tabs.GetTabRect(tabs.SelectedIndex);
            e.Graphics.FillRectangle(BackBrush, Rec);
            for (int i = 0; i < tabs.TabPages.Count; i++)
            {
                e.Graphics.DrawString(tabs.TabPages[i].Text, new Font("宋体", 12), FrontBrush, Rec, StringF);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            new UserManagement(false).ShowDialog();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (dataGridUser.SelectedRows.Count > 0)
            {
                this.TopMost = false;
                new UserManagement(true).ShowDialog();
            }
            else
            {
                MessageBox.Show("请先选择一行数据");
            }

        }

        private void dataGridUser_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridUser.SelectedRows.Count > 0)
            {
                currentuser.UserId = dataGridUser.SelectedRows[0].Cells["ID"].Value.ToString();
                currentuser.UserType = dataGridUser.SelectedRows[0].Cells["用户类型"].Value.ToString();
                currentuser.UserAccount = dataGridUser.SelectedRows[0].Cells["账户"].Value.ToString();
                currentuser.UserName = dataGridUser.SelectedRows[0].Cells["用户名"].Value.ToString();
                currentuser.UserPhone = dataGridUser.SelectedRows[0].Cells["手机号码"].Value.ToString();
                currentuser.UserRegion = dataGridUser.SelectedRows[0].Cells["地区"].Value.ToString();
                currentuser.UserDepartment = dataGridUser.SelectedRows[0].Cells["部门"].Value.ToString();
                currentuser.SystemId = dataGridUser.SelectedRows[0].Cells["系统账号"].Value.ToString();
            }
        }
        
    }
}
