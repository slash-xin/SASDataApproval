namespace ExportApproval
{
    partial class ApprovalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApprovalForm));
            this.group_date = new System.Windows.Forms.GroupBox();
            this.cb_date = new System.Windows.Forms.ComboBox();
            this.group_applyinfo = new System.Windows.Forms.GroupBox();
            this.applyinfo_grid = new System.Windows.Forms.DataGridView();
            this.group_rejectreason = new System.Windows.Forms.GroupBox();
            this.rtxt_reject = new System.Windows.Forms.RichTextBox();
            this.btn_preview = new System.Windows.Forms.Button();
            this.group_applyreason = new System.Windows.Forms.GroupBox();
            this.rtxt_apply = new System.Windows.Forms.RichTextBox();
            this.btn_reject = new System.Windows.Forms.Button();
            this.btn_approve = new System.Windows.Forms.Button();
            this.status_strip = new System.Windows.Forms.StatusStrip();
            this.lbapproval_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_regresh = new System.Windows.Forms.Label();
            this.lb_changepwd = new System.Windows.Forms.Label();
            this.group_Preview = new System.Windows.Forms.GroupBox();
            this.preview_grid = new System.Windows.Forms.DataGridView();
            this.group_department = new System.Windows.Forms.GroupBox();
            this.cb_department = new System.Windows.Forms.ComboBox();
            this.group_status = new System.Windows.Forms.GroupBox();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.group_type = new System.Windows.Forms.GroupBox();
            this.lb_approval = new System.Windows.Forms.Label();
            this.userContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.picture_user = new System.Windows.Forms.PictureBox();
            this.picture_logo = new System.Windows.Forms.PictureBox();
            this.group_date.SuspendLayout();
            this.group_applyinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applyinfo_grid)).BeginInit();
            this.group_rejectreason.SuspendLayout();
            this.group_applyreason.SuspendLayout();
            this.status_strip.SuspendLayout();
            this.group_Preview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preview_grid)).BeginInit();
            this.group_department.SuspendLayout();
            this.group_status.SuspendLayout();
            this.group_type.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // group_date
            // 
            this.group_date.Controls.Add(this.cb_date);
            this.group_date.Location = new System.Drawing.Point(345, 106);
            this.group_date.Margin = new System.Windows.Forms.Padding(0);
            this.group_date.Name = "group_date";
            this.group_date.Padding = new System.Windows.Forms.Padding(0);
            this.group_date.Size = new System.Drawing.Size(128, 66);
            this.group_date.TabIndex = 1;
            this.group_date.TabStop = false;
            this.group_date.Text = "申请时间";
            // 
            // cb_date
            // 
            this.cb_date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_date.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_date.FormattingEnabled = true;
            this.cb_date.ItemHeight = 18;
            this.cb_date.Location = new System.Drawing.Point(4, 25);
            this.cb_date.Margin = new System.Windows.Forms.Padding(4);
            this.cb_date.Name = "cb_date";
            this.cb_date.Size = new System.Drawing.Size(119, 26);
            this.cb_date.TabIndex = 0;
            this.cb_date.SelectedIndexChanged += new System.EventHandler(this.cbdate_SelectedIndexChanged);
            // 
            // group_applyinfo
            // 
            this.group_applyinfo.Controls.Add(this.applyinfo_grid);
            this.group_applyinfo.Location = new System.Drawing.Point(16, 184);
            this.group_applyinfo.Margin = new System.Windows.Forms.Padding(4);
            this.group_applyinfo.Name = "group_applyinfo";
            this.group_applyinfo.Padding = new System.Windows.Forms.Padding(4);
            this.group_applyinfo.Size = new System.Drawing.Size(733, 269);
            this.group_applyinfo.TabIndex = 3;
            this.group_applyinfo.TabStop = false;
            this.group_applyinfo.Text = "申请详细信息";
            // 
            // applyinfo_grid
            // 
            this.applyinfo_grid.AllowUserToAddRows = false;
            this.applyinfo_grid.AllowUserToDeleteRows = false;
            this.applyinfo_grid.AllowUserToOrderColumns = true;
            this.applyinfo_grid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.applyinfo_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.applyinfo_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.applyinfo_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.applyinfo_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.applyinfo_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applyinfo_grid.Location = new System.Drawing.Point(4, 22);
            this.applyinfo_grid.Margin = new System.Windows.Forms.Padding(4);
            this.applyinfo_grid.MultiSelect = false;
            this.applyinfo_grid.Name = "applyinfo_grid";
            this.applyinfo_grid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.applyinfo_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.applyinfo_grid.RowHeadersVisible = false;
            this.applyinfo_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.applyinfo_grid.Size = new System.Drawing.Size(725, 243);
            this.applyinfo_grid.TabIndex = 0;
            this.applyinfo_grid.SelectionChanged += new System.EventHandler(this.applyinfo_grid_SelectionChanged);
            // 
            // group_rejectreason
            // 
            this.group_rejectreason.Controls.Add(this.rtxt_reject);
            this.group_rejectreason.Location = new System.Drawing.Point(757, 321);
            this.group_rejectreason.Margin = new System.Windows.Forms.Padding(4);
            this.group_rejectreason.Name = "group_rejectreason";
            this.group_rejectreason.Padding = new System.Windows.Forms.Padding(4);
            this.group_rejectreason.Size = new System.Drawing.Size(277, 128);
            this.group_rejectreason.TabIndex = 5;
            this.group_rejectreason.TabStop = false;
            this.group_rejectreason.Text = "拒绝原因";
            // 
            // rtxt_reject
            // 
            this.rtxt_reject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxt_reject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxt_reject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtxt_reject.ForeColor = System.Drawing.Color.Red;
            this.rtxt_reject.Location = new System.Drawing.Point(4, 22);
            this.rtxt_reject.Margin = new System.Windows.Forms.Padding(4);
            this.rtxt_reject.Name = "rtxt_reject";
            this.rtxt_reject.ReadOnly = true;
            this.rtxt_reject.Size = new System.Drawing.Size(269, 102);
            this.rtxt_reject.TabIndex = 1;
            this.rtxt_reject.Text = "";
            // 
            // btn_preview
            // 
            this.btn_preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_preview.Location = new System.Drawing.Point(923, 125);
            this.btn_preview.Margin = new System.Windows.Forms.Padding(4);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(112, 35);
            this.btn_preview.TabIndex = 3;
            this.btn_preview.Text = "查看数据";
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.btnpreview_Click);
            // 
            // group_applyreason
            // 
            this.group_applyreason.Controls.Add(this.rtxt_apply);
            this.group_applyreason.Location = new System.Drawing.Point(757, 184);
            this.group_applyreason.Margin = new System.Windows.Forms.Padding(4);
            this.group_applyreason.Name = "group_applyreason";
            this.group_applyreason.Padding = new System.Windows.Forms.Padding(4);
            this.group_applyreason.Size = new System.Drawing.Size(277, 130);
            this.group_applyreason.TabIndex = 4;
            this.group_applyreason.TabStop = false;
            this.group_applyreason.Text = "申请原因";
            // 
            // rtxt_apply
            // 
            this.rtxt_apply.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxt_apply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxt_apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtxt_apply.ForeColor = System.Drawing.Color.Blue;
            this.rtxt_apply.Location = new System.Drawing.Point(4, 22);
            this.rtxt_apply.Margin = new System.Windows.Forms.Padding(4);
            this.rtxt_apply.Name = "rtxt_apply";
            this.rtxt_apply.ReadOnly = true;
            this.rtxt_apply.Size = new System.Drawing.Size(269, 104);
            this.rtxt_apply.TabIndex = 0;
            this.rtxt_apply.Text = "";
            // 
            // btn_reject
            // 
            this.btn_reject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reject.ForeColor = System.Drawing.Color.Red;
            this.btn_reject.Location = new System.Drawing.Point(680, 125);
            this.btn_reject.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reject.Name = "btn_reject";
            this.btn_reject.Size = new System.Drawing.Size(100, 35);
            this.btn_reject.TabIndex = 2;
            this.btn_reject.Text = "拒绝";
            this.btn_reject.UseVisualStyleBackColor = true;
            this.btn_reject.Click += new System.EventHandler(this.btnreject_Click);
            // 
            // btn_approve
            // 
            this.btn_approve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_approve.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_approve.Location = new System.Drawing.Point(801, 125);
            this.btn_approve.Margin = new System.Windows.Forms.Padding(4);
            this.btn_approve.Name = "btn_approve";
            this.btn_approve.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_approve.Size = new System.Drawing.Size(100, 35);
            this.btn_approve.TabIndex = 1;
            this.btn_approve.Text = "通过";
            this.btn_approve.UseVisualStyleBackColor = true;
            this.btn_approve.Click += new System.EventHandler(this.btnapprove_Click);
            // 
            // status_strip
            // 
            this.status_strip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.status_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbapproval_status});
            this.status_strip.Location = new System.Drawing.Point(0, 664);
            this.status_strip.Name = "status_strip";
            this.status_strip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.status_strip.Size = new System.Drawing.Size(1045, 25);
            this.status_strip.TabIndex = 4;
            this.status_strip.Text = "statusStrip1";
            // 
            // lbapproval_status
            // 
            this.lbapproval_status.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbapproval_status.Name = "lbapproval_status";
            this.lbapproval_status.Size = new System.Drawing.Size(49, 20);
            this.lbapproval_status.Text = "XXXX";
            this.lbapproval_status.ToolTipText = "asdfasd";
            // 
            // lb_regresh
            // 
            this.lb_regresh.AutoSize = true;
            this.lb_regresh.BackColor = System.Drawing.Color.White;
            this.lb_regresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_regresh.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_regresh.ForeColor = System.Drawing.Color.Navy;
            this.lb_regresh.Location = new System.Drawing.Point(590, 49);
            this.lb_regresh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_regresh.Name = "lb_regresh";
            this.lb_regresh.Size = new System.Drawing.Size(101, 30);
            this.lb_regresh.TabIndex = 8;
            this.lb_regresh.Text = "刷新数据";
            this.lb_regresh.Visible = false;
            this.lb_regresh.Click += new System.EventHandler(this.lbregresh_Click);
            // 
            // lb_changepwd
            // 
            this.lb_changepwd.AutoSize = true;
            this.lb_changepwd.BackColor = System.Drawing.Color.White;
            this.lb_changepwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_changepwd.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_changepwd.ForeColor = System.Drawing.Color.Navy;
            this.lb_changepwd.Location = new System.Drawing.Point(590, 9);
            this.lb_changepwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_changepwd.Name = "lb_changepwd";
            this.lb_changepwd.Size = new System.Drawing.Size(101, 30);
            this.lb_changepwd.TabIndex = 9;
            this.lb_changepwd.Text = "修改密码";
            this.lb_changepwd.Visible = false;
            this.lb_changepwd.Click += new System.EventHandler(this.lbchangepwd_Click);
            // 
            // group_Preview
            // 
            this.group_Preview.Controls.Add(this.preview_grid);
            this.group_Preview.Location = new System.Drawing.Point(16, 460);
            this.group_Preview.Margin = new System.Windows.Forms.Padding(4);
            this.group_Preview.Name = "group_Preview";
            this.group_Preview.Padding = new System.Windows.Forms.Padding(4);
            this.group_Preview.Size = new System.Drawing.Size(1015, 198);
            this.group_Preview.TabIndex = 10;
            this.group_Preview.TabStop = false;
            this.group_Preview.Text = "数据预览:(最多10行)";
            // 
            // preview_grid
            // 
            this.preview_grid.AllowUserToAddRows = false;
            this.preview_grid.AllowUserToDeleteRows = false;
            this.preview_grid.AllowUserToOrderColumns = true;
            this.preview_grid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.preview_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.preview_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.preview_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.preview_grid.DefaultCellStyle = dataGridViewCellStyle5;
            this.preview_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preview_grid.Location = new System.Drawing.Point(4, 22);
            this.preview_grid.Margin = new System.Windows.Forms.Padding(4);
            this.preview_grid.Name = "preview_grid";
            this.preview_grid.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.preview_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.preview_grid.RowHeadersVisible = false;
            this.preview_grid.RowTemplate.Height = 23;
            this.preview_grid.Size = new System.Drawing.Size(1007, 172);
            this.preview_grid.TabIndex = 0;
            // 
            // group_department
            // 
            this.group_department.Controls.Add(this.cb_department);
            this.group_department.Location = new System.Drawing.Point(189, 106);
            this.group_department.Margin = new System.Windows.Forms.Padding(0);
            this.group_department.Name = "group_department";
            this.group_department.Padding = new System.Windows.Forms.Padding(0);
            this.group_department.Size = new System.Drawing.Size(128, 66);
            this.group_department.TabIndex = 12;
            this.group_department.TabStop = false;
            this.group_department.Text = "部门";
            // 
            // cb_department
            // 
            this.cb_department.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_department.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_department.FormattingEnabled = true;
            this.cb_department.ItemHeight = 18;
            this.cb_department.Location = new System.Drawing.Point(4, 25);
            this.cb_department.Margin = new System.Windows.Forms.Padding(4);
            this.cb_department.Name = "cb_department";
            this.cb_department.Size = new System.Drawing.Size(119, 26);
            this.cb_department.TabIndex = 0;
            this.cb_department.SelectedIndexChanged += new System.EventHandler(this.cbsource_SelectedIndexChanged);
            // 
            // group_status
            // 
            this.group_status.Controls.Add(this.cb_status);
            this.group_status.Location = new System.Drawing.Point(501, 106);
            this.group_status.Margin = new System.Windows.Forms.Padding(0);
            this.group_status.Name = "group_status";
            this.group_status.Padding = new System.Windows.Forms.Padding(0);
            this.group_status.Size = new System.Drawing.Size(145, 66);
            this.group_status.TabIndex = 14;
            this.group_status.TabStop = false;
            this.group_status.Text = "审批状态";
            // 
            // cb_status
            // 
            this.cb_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_status.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_status.FormattingEnabled = true;
            this.cb_status.ItemHeight = 18;
            this.cb_status.Location = new System.Drawing.Point(4, 25);
            this.cb_status.Margin = new System.Windows.Forms.Padding(4);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(137, 26);
            this.cb_status.TabIndex = 0;
            this.cb_status.SelectedIndexChanged += new System.EventHandler(this.cbstatus_SelectedIndexChanged);
            // 
            // group_type
            // 
            this.group_type.Controls.Add(this.lb_approval);
            this.group_type.Location = new System.Drawing.Point(16, 106);
            this.group_type.Margin = new System.Windows.Forms.Padding(0);
            this.group_type.Name = "group_type";
            this.group_type.Padding = new System.Windows.Forms.Padding(0);
            this.group_type.Size = new System.Drawing.Size(147, 66);
            this.group_type.TabIndex = 17;
            this.group_type.TabStop = false;
            this.group_type.Text = "审批类型";
            // 
            // lb_approval
            // 
            this.lb_approval.AutoSize = true;
            this.lb_approval.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lb_approval.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_approval.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_approval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_approval.Location = new System.Drawing.Point(17, 31);
            this.lb_approval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_approval.Name = "lb_approval";
            this.lb_approval.Size = new System.Drawing.Size(44, 17);
            this.lb_approval.TabIndex = 17;
            this.lb_approval.Text = "    ";
            // 
            // userContextMenu
            // 
            this.userContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.userContextMenu.Name = "userContextMenu";
            this.userContextMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // picture_user
            // 
            this.picture_user.Image = global::ExportApproval.Properties.Resources.user;
            this.picture_user.Location = new System.Drawing.Point(982, 21);
            this.picture_user.Name = "picture_user";
            this.picture_user.Size = new System.Drawing.Size(49, 50);
            this.picture_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_user.TabIndex = 20;
            this.picture_user.TabStop = false;
            this.picture_user.Click += new System.EventHandler(this.pictureuser_Click);
            this.picture_user.MouseHover += new System.EventHandler(this.pictureuser_MouseHover);
            // 
            // picture_logo
            // 
            this.picture_logo.BackColor = System.Drawing.Color.White;
            this.picture_logo.Image = global::ExportApproval.Properties.Resources.logo2;
            this.picture_logo.Location = new System.Drawing.Point(0, -2);
            this.picture_logo.Margin = new System.Windows.Forms.Padding(4);
            this.picture_logo.Name = "picture_logo";
            this.picture_logo.Size = new System.Drawing.Size(1045, 94);
            this.picture_logo.TabIndex = 5;
            this.picture_logo.TabStop = false;
            // 
            // ApprovalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1045, 689);
            this.Controls.Add(this.picture_user);
            this.Controls.Add(this.group_type);
            this.Controls.Add(this.group_status);
            this.Controls.Add(this.group_department);
            this.Controls.Add(this.btn_reject);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.group_rejectreason);
            this.Controls.Add(this.group_Preview);
            this.Controls.Add(this.btn_approve);
            this.Controls.Add(this.lb_changepwd);
            this.Controls.Add(this.lb_regresh);
            this.Controls.Add(this.group_applyreason);
            this.Controls.Add(this.picture_logo);
            this.Controls.Add(this.status_strip);
            this.Controls.Add(this.group_applyinfo);
            this.Controls.Add(this.group_date);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ApprovalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据导出审批系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ApprovalForm_FormClosing);
            this.group_date.ResumeLayout(false);
            this.group_applyinfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.applyinfo_grid)).EndInit();
            this.group_rejectreason.ResumeLayout(false);
            this.group_applyreason.ResumeLayout(false);
            this.status_strip.ResumeLayout(false);
            this.status_strip.PerformLayout();
            this.group_Preview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.preview_grid)).EndInit();
            this.group_department.ResumeLayout(false);
            this.group_status.ResumeLayout(false);
            this.group_type.ResumeLayout(false);
            this.group_type.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox group_date;
        private System.Windows.Forms.GroupBox group_applyinfo;
        private System.Windows.Forms.DataGridView applyinfo_grid;
        private System.Windows.Forms.ComboBox cb_date;
        private System.Windows.Forms.StatusStrip status_strip;
        private System.Windows.Forms.ToolStripStatusLabel lbapproval_status;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.Button btn_reject;
        private System.Windows.Forms.Button btn_approve;
        private System.Windows.Forms.PictureBox picture_logo;
        private System.Windows.Forms.GroupBox group_rejectreason;
        private System.Windows.Forms.RichTextBox rtxt_reject;
        private System.Windows.Forms.GroupBox group_applyreason;
        private System.Windows.Forms.RichTextBox rtxt_apply;
        private System.Windows.Forms.Label lb_regresh;
        private System.Windows.Forms.Label lb_changepwd;
        private System.Windows.Forms.GroupBox group_Preview;
        private System.Windows.Forms.DataGridView preview_grid;
        private System.Windows.Forms.GroupBox group_department;
        private System.Windows.Forms.ComboBox cb_department;
        private System.Windows.Forms.GroupBox group_status;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.GroupBox group_type;
        private System.Windows.Forms.Label lb_approval;
        private System.Windows.Forms.ContextMenuStrip userContextMenu;
        private System.Windows.Forms.PictureBox picture_user;
    }
}