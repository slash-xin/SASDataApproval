using ExportApproval.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ExportApproval
{
    public partial class ApprovalForm : Form
    {
        public enum UserType
        {
            apply = 0,  // 申请用户
            fapproval = 1, // 一级审批用户
            sapproval = 2, // 二级审批用户
            uapproval = 3, // 上传用户
        }
        public UserInfo currentUser
        {
            get { return AuthUser.currentUser; }
        }
        private DataTable applyInfo;
        Dictionary<string, string> filterwhere = new Dictionary<string, string>();
        public ApprovalForm()
        {
            InitializeComponent();

            bindApplyGrid();
        }


        /// <summary>
        /// bind 申请信息列表
        /// </summary>
        private void bindApplyGrid()
        {
            try
            {
                List<string> applyUserIdList = new List<string>();
                DataTable dt = new DataTable();
                if ((UserType)Convert.ToInt32(currentUser.UserType) == UserType.fapproval)   //一级审批人
                {
                    applyUserIdList = UserRelation.getApplicantByFapprover(currentUser.UserId);
                    string idstr = listTostring(applyUserIdList);
                    dt = ApplyInfo.getApplyInfoDT(idstr, currentUser.UserType, currentUser.UserId);
                    lb_approval.Text = "领导审批";
                }
                else   //二级审批人
                {
                    dt = ApplyInfo.getAllApplyInfoDT();
                    lb_approval.Text = "管理小组审批";
                }
               
                group_applyinfo.Text = "申请详细信息 (" + dt.Rows.Count + ")";
                applyInfo = dt;
                applyinfo_grid.DataSource = dt;


                bindApplyYearMonth();
                bindUserDepartment();
                bindApplyStatus();
                //bindApplyType();
                dataGridSetting();
                lbapproval_status.Text = "注：最后刷新申请数据时间：" + DateTime.Now.ToString();
            }
            catch
            {
                lbapproval_status.Text = "申请详细信息列表加载失败！请刷新";
            }

        }

        /// <summary>
        /// 将list元素拼接成字符串
        /// </summary>
        /// <param name="List"></param>
        /// <returns></returns>
        private string listTostring(List<string> List)
        {
            string idstr = "";
            foreach (string list in List)
            {
                idstr += "'" + list + "',";
            }
            if (idstr != "") idstr = idstr.TrimEnd(',');
            return idstr;
        }

        /// <summary>
        /// 申请信息列表设置
        /// </summary>
        private void dataGridSetting()
        {
            if (applyinfo_grid.DataSource != null)
            {

                applyinfo_grid.Columns["apply_user_id"].Visible = false;
                applyinfo_grid.Columns["apply_id"].Visible = false;
                applyinfo_grid.Columns["apply_source"].Visible = false;
                applyinfo_grid.Columns["apply_date_month"].Visible = false;
                applyinfo_grid.Columns["apply_reason"].Visible = false;
                applyinfo_grid.Columns["reject_reason"].Visible = false;
                applyinfo_grid.Columns["last_approval_Date"].Visible = false;
                applyinfo_grid.Columns["last_approval_user"].Visible = false;
                applyinfo_grid.Columns["fapproval_user_id"].Visible = false;
                applyinfo_grid.Columns["encrypted_num"].Visible = false;
                applyinfo_grid.Columns["encrypted_txt"].Visible = false;

                applyinfo_grid.Columns["user_name"].HeaderText = "申请人";
                applyinfo_grid.Columns["user_name"].Width = 80;
                applyinfo_grid.Columns["apply_date"].HeaderText = "申请时间";
                applyinfo_grid.Columns["apply_date"].Width = 105;
                applyinfo_grid.Columns["apply_status"].HeaderText = "审批状态";
                applyinfo_grid.Columns["apply_status"].Width = 80;
                applyinfo_grid.Columns["list_id"].HeaderText = "单号";
                applyinfo_grid.Columns["list_id"].Width = 60;
                applyinfo_grid.Columns["data_obs"].HeaderText = "行数";
                applyinfo_grid.Columns["data_obs"].Width = 70;
                applyinfo_grid.Columns["data_size"].HeaderText = "数据大小";
                applyinfo_grid.Columns["data_size"].Width = 70;
                applyinfo_grid.Columns["apply_type"].HeaderText = "申请类型";
                applyinfo_grid.Columns["apply_type"].Width = 90;
                applyinfo_grid.Columns["user_region"].HeaderText = "中心";
                applyinfo_grid.Columns["user_region"].Width = 70;
                applyinfo_grid.Columns["user_department"].HeaderText = "部门";
                applyinfo_grid.Columns["user_department"].Width = 70;
                applyinfo_grid.Columns["fapprover_user_name"].HeaderText = "处理人1";
                applyinfo_grid.Columns["fapprover_user_name"].Width = 80;
                applyinfo_grid.Columns["sapprover_user_name"].HeaderText = "处理人2";
                applyinfo_grid.Columns["sapprover_user_name"].Width = 80;


                setDataGridValue();


                applyinfo_grid.AllowUserToResizeRows = false;
                //this.applyinfo_grid.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //this.applyinfo_grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        /// <summary>
        /// 遍历设置值
        /// </summary>
        private void setDataGridValue()
        {
            for (var i = 0; i < applyinfo_grid.RowCount; i++)
            {
                string applystatus = applyinfo_grid.Rows[i].Cells["apply_status"].Value.ToString();
                if (applystatus == "领导已审批" || applystatus == "领导已拒绝")
                {
                    applyinfo_grid.Rows[i].Cells["sapprover_user_name"].Value = "";
                }
                if (applystatus == "待审批")
                {
                    applyinfo_grid.Rows[i].Cells["fapprover_user_name"].Value = "";
                    applyinfo_grid.Rows[i].Cells["sapprover_user_name"].Value = "";
                }
            }
        }
        /// <summary>
        /// bind 筛选下拉框
        /// </summary>
        /// <param name="field">字段</param>
        /// <param name="cb">ComboBox</param>
        /// <param name="str">附加字符串</param>
        private void bindFilter(string field, ComboBox cb, string first = "", string str = "")
        {

            cb.Items.Clear();
            if (applyInfo != null)
            {
                DataTable table = applyInfo.DefaultView.ToTable(true, field);
                if (first != "") cb.Items.Add(first);
                for (int i = 0; i < table.Rows.Count; i++)
                    if (table.Rows[i][0].ToString() != "")
                        cb.Items.Add(table.Rows[i][0].ToString().ToUpper() + str);
            }
            cb.SelectedIndex = 0;
        }

        /// <summary>
        /// bind申请年月下拉框
        /// </summary>
        private void bindApplyYearMonth()
        {
            bindFilter("apply_date_month", cb_date, "全部");
        }
        /// <summary>
        /// bind用户部门下拉框
        /// </summary>
        private void bindUserDepartment()
        {
            bindFilter("user_department", cb_department, "全部");
        }
        /// <summary>
        /// bind申请状态下拉框
        /// </summary>
        private void bindApplyStatus()
        {
            bindFilter("apply_status", cb_status, "全部");
        }
        /// <summary>
        /// bind申请类别下拉框
        /// </summary>
        //private void bindApplyType()
        //{
        //     bindFilter("apply_type", cb_type, "" ,"次审批");
        //}


        private void ApprovalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Yes != MessageBox.Show("是否确定退出审批管理系统？", "退出系统", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                e.Cancel = true;
            }
        }


        /// <summary>
        /// 获取筛选条件字符串
        /// </summary>
        /// <returns></returns>
        private string getFilterwhere()
        {
            string where = "";
            foreach (KeyValuePair<string, string> kvp in filterwhere)
            {
                where += string.Format(" {0}='{1}' and", kvp.Key, kvp.Value);
            }
            if (where != "") where = where.Substring(0, where.Length - 3);
            return where;
        }

        /// <summary>
        /// 下拉框改变时
        /// </summary>
        /// <param name="field"></param>
        /// <param name="value"></param>
        private void SelectedIndexChanged(string field, string value)
        {
            if (applyInfo != null)
            {
                if (value != "全部")
                {
                    if (filterwhere.ContainsKey(field))
                        filterwhere[field] = value;
                    else
                        filterwhere.Add(field, value);
                }
                else
                {
                    filterwhere.Remove(field);
                }
                DataTable newtable = applyInfo.Clone();
                DataRow[] dtrow = applyInfo.Select(getFilterwhere());
                for (int i = 0; i < dtrow.Length; i++)
                {
                    newtable.ImportRow(dtrow[i]);
                }
                applyinfo_grid.DataSource = newtable;
                group_applyinfo.Text = "申请详细信息(" + dtrow.Length + ")";
                setDataGridValue();
            }
        }
        /// <summary>
        /// 申请年月改变时
        /// </summary>
        private void cbdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndexChanged("apply_date_month", cb_date.SelectedItem.ToString());
        }
        /// <summary>
        ///申请类型改变时
        /// </summary>
        //private void cbtype_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    SelectedIndexChanged("apply_type", cb_type.SelectedItem.ToString().Replace("次审批", ""));
        //}
        /// <summary>
        ///申请来源改变时
        /// </summary>
        private void cbsource_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndexChanged("user_department", cb_department.SelectedItem.ToString());
        }
        /// <summary>
        ///申请状态改变时
        /// </summary>
        private void cbstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndexChanged("apply_status", cb_status.SelectedItem.ToString());
        }

        /// <summary>
        /// 修改申请表并插入审批记录
        /// </summary>
        /// <param name="approve_status">审批状态</param>
        /// <param name="reason">拒绝原因</param>
        private void ChangeApproveStatus(string approve_status, string reason = "")
        {
            applyinfo_grid.SelectedRows[0].Cells["apply_status"].Value = approve_status;
            applyinfo_grid.SelectedRows[0].Cells["reject_reason"].Value = reason;
            string list_id = applyinfo_grid.SelectedRows[0].Cells["list_id"].Value.ToString();
            btn_approve.Enabled = false;
            btn_reject.Enabled = false;

            string applyid = applyinfo_grid.SelectedRows[0].Cells["apply_id"].Value.ToString();
            ApplyInfo apply = ApplyInfo.getApplyInfo(applyid);
            if (apply != null)
            {
                ApprovalRecord approval = new ApprovalRecord();

                approval.approvalStatus = apply.applyStatus = approve_status;
                approval.approvalContent = apply.rejectReason = reason;
                approval.approvalUserId = apply.lastApprovalUserId = currentUser.UserId;
                approval.ApprovalDate = apply.lastApprovalDate = DateTime.Now.ToString();
                approval.applyId = apply.applyId;
                approval.ApprovalUserType = currentUser.UserType;
                approval.applyUserId = apply.applyUserId;
                if (!approve_status.Contains("拒绝"))
                {
                    ApplyList list = new ApplyList();
                    list.insertUserId = apply.applyUserId;
                    list.insertDate = DateTime.Now.ToString();
                    list.expirationDate = DateTime.Now.AddMonths(3).ToString();
                    list.ListId = applyinfo_grid.SelectedRows[0].Cells["list_id"].Value.ToString();
                    HandleApplyList(list);
                }

                if (ApplyInfo.updateApplyInfo(apply) > 0 && ApprovalRecord.addApprovalInfo(approval) > 0)
                {
                    bindApplyGrid();
                    MessageBox.Show("操作成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("操作失败，请重试！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void HandleApplyList(ApplyList list)
        {
            if (list.ListId != "")
            {
                ApplyList newlist = ApplyList.getApplyListInfo(list.ListId);
                if (newlist != null)
                {
                    if (Convert.ToDateTime(newlist.expirationDate) < DateTime.Now)
                    {
                        ApplyList.updateApplyListInfo(list);
                    }
                }
                else
                {
                    ApplyList.addApplyListInfo(list);
                }
            }
        }
        /// <summary>
        /// 拒绝
        /// </summary>
        private void btnreject_Click(object sender, EventArgs e)
        {
            if (applyinfo_grid.SelectedRows.Count > 0)
            {
                if (DialogResult.Yes == MessageBox.Show("是否确定拒绝该申请？拒绝后无法再撤销！", "是否拒绝审批", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    RejectReasonForm reject_form = new RejectReasonForm();
                    reject_form.ShowDialog();
                    string reason = reject_form.GetRejectReason();
                    string status = "拒绝";
                    if ((UserType)Convert.ToInt32(currentUser.UserType) == UserType.fapproval)
                        status = "领导已拒绝";
                    ChangeApproveStatus(status, reason);
                }
            }
        }

        /// <summary>
        /// 通过
        /// </summary>
        private void btnapprove_Click(object sender, EventArgs e)
        {
            if (applyinfo_grid.SelectedRows.Count > 0)
            {
                if (preview_grid.DataSource == null)
                {
                    MessageBox.Show("通过该申请前，请单击“查看数据”按钮查看数据！", "请查看数据", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("是否确定通过该申请？通过后无法再撤销！", "是否通过审批", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        string status = "通过";
                        if ((UserType)Convert.ToInt32(currentUser.UserType) == UserType.fapproval)
                            status = "领导已审批";
                        ChangeApproveStatus(status);
                    }
                }
            }
        }

        /// <summary>
        /// 查看数据
        /// </summary>
        private void btnpreview_Click(object sender, EventArgs e)
        {
            if (applyinfo_grid.SelectedRows.Count > 0)
            {
                string applyid = applyinfo_grid.SelectedRows[0].Cells["apply_id"].Value.ToString();
                string encryptednum = applyinfo_grid.SelectedRows[0].Cells["encrypted_num"].Value.ToString();
                string encryptedtxt = applyinfo_grid.SelectedRows[0].Cells["encrypted_txt"].Value.ToString();

                if (ExportFileView.IsTableExist(applyid))
                {
                    DataTable table = ExportFileView.getPreviewData(applyid);
                    if (table != null) preview_grid.DataSource = table;
                    dataGridPreviewSetting(encryptednum, encryptedtxt);
                    lbapproval_status.Text = "加载成功。";
                }
                else
                {
                    lbapproval_status.Text = "查看失败，数据表" + applyid + "已被删除。";
                    MessageBox.Show("数据表" + applyid + "已被删除。请联系管理员", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// 分隔加密字段号
        /// </summary>
        /// <param name="encryptednum">字段号字符串</param>
        /// <returns></returns>
        private int[] getEncryptColumns(string encryptednum)
        {
            if (encryptednum == "")
            {
                return new int[] { };
            }
            string[] strarr = encryptednum.Trim().Split(' ');
            int[] numarr = new int[strarr.Length];
            for (int i = 0; i < strarr.Length; i++)
            {
                numarr[i] = Convert.ToInt32(strarr[i]);
            }
            return numarr;
        }

        /// <summary>
        /// 预览列表设置
        /// </summary>
        private void dataGridPreviewSetting(string encryptednum, string encryptedtxt)
        {
            int[] numarr = getEncryptColumns(encryptednum);
            int[] txtarr = getEncryptColumns(encryptedtxt);
            if (preview_grid.DataSource != null)
            {
                for (int j = 0; j < preview_grid.ColumnCount; j++)
                {
                    if (preview_grid.Columns[j].HeaderCell.Value.ToString().Substring(0, 2).ToUpper() == "V_")
                    {
                        preview_grid.Columns[j].HeaderText = preview_grid.Columns[j].HeaderCell.Value.ToString().Substring(2); //去掉前缀"v_"
                    }
                    for (int i = 0; i < numarr.Length; i++)
                    {
                        if (j == numarr[i] - 1)
                        {
                            preview_grid.Columns[j].HeaderText = preview_grid.Columns[j].HeaderText + "(已加密)";
                            preview_grid.Columns[j].Width = 150;
                            preview_grid.Columns[j].HeaderCell.Style.ForeColor = Color.Red;
                        }
                    }
                    for (int i = 0; i < txtarr.Length; i++)
                    {
                        if (j == txtarr[i] - 1)
                        {
                            preview_grid.Columns[j].HeaderText = preview_grid.Columns[j].HeaderText + "(已脱敏)";
                            preview_grid.Columns[j].Width = 150;
                            preview_grid.Columns[j].HeaderCell.Style.ForeColor = Color.Red;
                        }
                    }
                    for (var i = 0; i < preview_grid.RowCount; i++)
                    {
                        string value = preview_grid.Rows[i].Cells[j].Value.ToString().Trim();
                        if (value.Length > 4)
                        {
                            string str = value.Substring(3, value.Length - 4);
                            string temp = "";
                            for (int k = 0; k < str.Length; k++)
                            {
                                temp += "*";
                            }
                            value = value.Replace(str, temp);
                            preview_grid.Rows[i].Cells[j].Value = value;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 申请列表选择改变时
        /// </summary>
        private void applyinfo_grid_SelectionChanged(object sender, EventArgs e)
        {
            if (applyinfo_grid.SelectedRows.Count > 0)
            {
                preview_grid.DataSource = null;

                rtxt_apply.Text = applyinfo_grid.SelectedRows[0].Cells["apply_reason"].Value.ToString();
                rtxt_reject.Text = applyinfo_grid.SelectedRows[0].Cells["reject_reason"].Value.ToString();

                string apply_status = applyinfo_grid.SelectedRows[0].Cells["apply_status"].Value.ToString();
                string apply_type = applyinfo_grid.SelectedRows[0].Cells["apply_type"].Value.ToString();
                string list_id = applyinfo_grid.SelectedRows[0].Cells["list_id"].Value.ToString();
                if (apply_status == "待审批")
                {
                    if ((UserType)Convert.ToInt32(currentUser.UserType) == UserType.fapproval)
                    {
                        btn_approve.Enabled = true;
                        btn_reject.Enabled = true;
                    }
                    else
                    {
                        if (apply_type == "明细数据审批")
                        {
                            btn_approve.Enabled = false;
                            btn_reject.Enabled = false;
                            if (list_id != "")  //有单号
                            {
                                btn_approve.Enabled = true;
                                btn_reject.Enabled = true;
                            }
                        }
                        else if (apply_type == "汇总数据审批")
                        {
                            btn_approve.Enabled = true;
                            btn_reject.Enabled = true;
                        }
                    }
                    //picture_status.Image = Properties.Resources.wait;
                }
                else if (apply_status == "通过")
                {
                    btn_approve.Enabled = false;
                    btn_reject.Enabled = false;
                    //picture_status.Image = Properties.Resources.check;
                }
                else if (apply_status == "拒绝" || apply_status == "领导已拒绝")
                {
                    btn_approve.Enabled = false;
                    btn_reject.Enabled = false;
                    //picture_status.Image = Properties.Resources.uncheck;
                }
                else if (apply_status == "领导已审批")
                {
                    if ((UserType)Convert.ToInt32(currentUser.UserType) == UserType.fapproval)
                    {
                        btn_approve.Enabled = false;
                        btn_reject.Enabled = false;
                        //picture_status.Image = Properties.Resources.check;
                    }
                    else
                    {
                        btn_approve.Enabled = true;
                        btn_reject.Enabled = true;
                        //picture_status.Image = Properties.Resources.wait;
                    }
                }

            }
        }

        /// <summary>
        /// 刷新数据
        /// </summary>
        private void lbregresh_Click(object sender, EventArgs e)
        {
            bindApplyGrid();
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        private void lbchangepwd_Click(object sender, EventArgs e)
        {
            new ChangePassForm().ShowDialog();
        }

        //private void lbuser_Click(object sender, EventArgs e)
        //{
        //    if ((e as MouseEventArgs).Button == MouseButtons.Left)
        //    {
        //        this.userContextMenu.Items.Clear();
        //        string[] items = {"修改密码", "刷新数据", "数据管理"};

        //        foreach(string text in items)
        //        {
        //            if(!((UserType)Convert.ToInt32(currentUser.UserType) == UserType.fapproval && text == "数据管理"))
        //            {
        //                ToolStripItem item = new ToolStripMenuItem();
        //                item.Name = item.Text = text;
        //                item.Click += new EventHandler(userContextMenu_ItemClick);
        //                this.userContextMenu.Items.Add(item);
        //            }
        //        }
        //        //设置显示的位置为鼠标所在的位置  
        //        this.userContextMenu.Show(MousePosition.X, MousePosition.Y);
        //    }
        //}

        private void userContextMenu_ItemClick(object sender, EventArgs e)
        {
            ToolStripItem item = (ToolStripItem)sender;
            if ((sender as ToolStripItem).Text == "修改密码")
            {
                new ChangePassForm().ShowDialog();
            }
            if ((sender as ToolStripItem).Text == "刷新数据")
            {
                bindApplyGrid();
            }
            if ((sender as ToolStripItem).Text == "数据管理")
            {
                if (((UserType)Convert.ToInt32(currentUser.UserType) == UserType.sapproval)) new AuthAdmin().ShowDialog();
                else MessageBox.Show(String.Format("不是管理员，没有数据管理权限。"), "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureuser_Click(object sender, EventArgs e)
        {
            //if ((e as MouseEventArgs).Button == MouseButtons.Left)
            //{
            this.userContextMenu.Items.Clear();
            //ToolStripItem userinfo = new ToolStripMenuItem();
            //userinfo.Name = userinfo.Text = currentUser.UserName;
            //this.userContextMenu.Items.Add(userinfo);
            string[] items = { "修改密码", "刷新数据", "数据管理" };
            foreach (string text in items)
            {
                if (!((UserType)Convert.ToInt32(currentUser.UserType) == UserType.fapproval && text == "数据管理"))
                {
                    ToolStripItem item = new ToolStripMenuItem();
                    item.Name = item.Text = text;
                    item.Click += new EventHandler(userContextMenu_ItemClick);
                    this.userContextMenu.Items.Add(item);
                }
            }
            //设置显示的位置为鼠标所在的位置  
            this.userContextMenu.Show(MousePosition.X, MousePosition.Y);
            // }
        }

        private void pictureuser_MouseHover(object sender, EventArgs e)
        {
            var toolTip = new ToolTip();
            toolTip.Show(currentUser.UserName, this.picture_user);
        }
    }
}
