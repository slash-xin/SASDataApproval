using ExportSASData.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ExportSASData
{
    public partial class ExportForm : Form
    {
        public enum UserType
        {
            apply = 0,  // 申请用户
            fapproval = 1, // 一级审批用户
            sapproval = 2, // 二级审批用户
            uapproval = 3, // 上传用户
        }
        private DataTable applyInfo;
        public static string currentapplyid;
        public static string encryptednum;
        public static string encryptedtxt;
        public UserInfo currentUser
        {
            get { return AuthUser.currentUser; }
        }

        Dictionary<string, string> filterwhere = new Dictionary<string, string>();

        public ExportForm()
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
                DataTable dt = ApplyInfo.getApplyInfoDT(currentUser.UserId);
                group_applyinfo.Text = "申请详细信息 (" + dt.Rows.Count + ")";
                applyInfo = dt;
                applyinfo_grid.DataSource = dt;
                

                bindApplyYearMonth();
                bindApplyStatus();
                bindApplyType();
                dataGridSetting();
                lbexport_status.Text = "注：最后刷新申请数据时间：" + DateTime.Now.ToString();
            }
            catch
            {
                lbexport_status.Text = "申请详细信息列表加载失败！请刷新";
            }
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
                applyinfo_grid.Columns["apply_date"].Width = 127;
                applyinfo_grid.Columns["apply_status"].HeaderText = "审批状态";
                applyinfo_grid.Columns["apply_status"].Width = 80;
                applyinfo_grid.Columns["data_obs"].HeaderText = "行数";
                applyinfo_grid.Columns["data_obs"].Width = 60;
                applyinfo_grid.Columns["data_size"].HeaderText = "数据大小";
                applyinfo_grid.Columns["data_size"].Width = 80;
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
                if(applystatus == "待审批")
                {
                    applyinfo_grid.Rows[i].Cells["fapprover_user_name"].Value = "";
                    applyinfo_grid.Rows[i].Cells["sapprover_user_name"].Value = "";
                }
                //string applytype = applyinfo_grid.Rows[i].Cells["apply_type"].Value.ToString();
                //if (applytype.IndexOf('1') >= 0)
                //{
                //    applyinfo_grid.Rows[i].Cells["apply_type"].Value = "汇总数据审批";
                //}
                //else if (applytype.IndexOf('2') >= 0)
                //{
                //    applyinfo_grid.Rows[i].Cells["apply_type"].Value = "明细数据审批";
                //}
            }
        }

        /// <summary>
        /// bind 筛选下拉框
        /// </summary>
        /// <param name="field">字段</param>
        /// <param name="cb">ComboBox</param>
        /// <param name="str">附加字符串</param>
        private void bindFilter(string field, ComboBox cb, string firststr="",  string str = "")
        {
           cb.Items.Clear();
            if (applyInfo != null)
            {
                DataTable table = applyInfo.DefaultView.ToTable(true, field);
                if (firststr != "") cb.Items.Add(firststr);
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
            bindFilter("apply_date_month", cb_date,"全部");
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
        private void bindApplyType()
        {
            bindFilter("apply_type", cb_type, "全部");
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
                group_applyinfo.Text = "申请详细信息 (" + dtrow.Length + ")";
                applyinfo_grid.DataSource = newtable;
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
        private void cbtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndexChanged("apply_type", cb_type.SelectedItem.ToString().Replace("次审批", ""));
        }
        /// <summary>
        ///申请状态改变时
        /// </summary>
        private void cbstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndexChanged("apply_status", cb_status.SelectedItem.ToString());
        }



        private void ExportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Yes != MessageBox.Show("是否确定退出数据导出系统？", "退出系统", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                e.Cancel = true;
            }
        }




        /// <summary>
        /// 导出
        /// </summary>
        private void btnexport_Click(object sender, EventArgs e)
        {
            if (applyinfo_grid.SelectedRows.Count > 0)
            {
                encryptednum = applyinfo_grid.SelectedRows[0].Cells["encrypted_num"].Value.ToString();
                encryptedtxt = applyinfo_grid.SelectedRows[0].Cells["encrypted_txt"].Value.ToString();
                if (ExportFileView.IsTableExist(currentapplyid))  //数据库中表是否存在
                {
                    new ExportDetail().ShowDialog();
                }
                else
                {
                    MessageBox.Show("数据表" + currentapplyid + "已被删除。请联系管理员", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("请先选择申请单", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 预览列表选择改变时
        /// </summary>
        private void applyinfo_grid_SelectionChanged(object sender, EventArgs e)
        {
            if (applyinfo_grid.SelectedRows.Count > 0)
            {
                currentapplyid = applyinfo_grid.SelectedRows[0].Cells["apply_id"].Value.ToString();
                group_rejectreason.Text = "拒绝原因:";
                rtxt_apply.Text = applyinfo_grid.SelectedRows[0].Cells["apply_reason"].Value.ToString();
                rtxt_reject.Text = applyinfo_grid.SelectedRows[0].Cells["reject_reason"].Value.ToString();
                string lastdatetime = applyinfo_grid.SelectedRows[0].Cells["last_approval_date"].Value.ToString();
                string apply_status = applyinfo_grid.SelectedRows[0].Cells["apply_status"].Value.ToString();

                if (apply_status == "待审批" || apply_status == "拒绝" || apply_status == "领导已拒绝" || apply_status == "领导已审批")
                {
                    btn_export.Enabled = false;
                    picture_status.Image = Properties.Resources.uncheck;
                }
                else if (apply_status == "通过")
                {
                    btn_export.Enabled = true;
                    picture_status.Image = Properties.Resources.check;

                    string dayofweek = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(Convert.ToDateTime(lastdatetime).DayOfWeek);
                    DateTime lastdate = Convert.ToDateTime(Convert.ToDateTime(lastdatetime).ToString("yyyy-MM-dd"));
                    //添加三个工作日
                    DateTime exportdate = lastdate.AddDays(3);
                    if (dayofweek == "星期四" || dayofweek == "星期五")
                    {
                        exportdate = lastdate.AddDays(5);
                    }
                    if (dayofweek == "星期日")
                    {
                        exportdate = lastdate.AddDays(4);
                    }
                    if (DateTime.Compare(DateTime.Now, exportdate) > 0)
                    {
                        rtxt_reject.Text = "该申请已经通过，但已超过导出有效期，不能导出。";
                        group_rejectreason.Text = "不能导出原因:";
                        btn_export.Enabled = false;
                        picture_status.Image = Properties.Resources.uncheck;
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
        }
        private void pictureuser_Click(object sender, EventArgs e)
        {
            this.userContextMenu.Items.Clear();
            string[] items = { "修改密码", "刷新数据" };
            foreach (string text in items)
            {
                    ToolStripItem item = new ToolStripMenuItem();
                    item.Name = item.Text = text;
                    item.Click += new EventHandler(userContextMenu_ItemClick);
                    this.userContextMenu.Items.Add(item);
            }
            //设置显示的位置为鼠标所在的位置  
            this.userContextMenu.Show(MousePosition.X, MousePosition.Y);
        }

        private void pictureuser_MouseHover(object sender, EventArgs e)
        {
            var toolTip = new ToolTip();
            toolTip.Show(currentUser.UserName, this.picture_user);
        }
    }
}
