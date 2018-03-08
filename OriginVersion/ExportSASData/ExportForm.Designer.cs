namespace ExportSASData
{
    partial class ExportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportForm));
            this.group_applyinfo = new System.Windows.Forms.GroupBox();
            this.applyinfo_grid = new System.Windows.Forms.DataGridView();
            this.btn_export = new System.Windows.Forms.Button();
            this.group_rejectreason = new System.Windows.Forms.GroupBox();
            this.rtxt_reject = new System.Windows.Forms.RichTextBox();
            this.group_applyreason = new System.Windows.Forms.GroupBox();
            this.rtxt_apply = new System.Windows.Forms.RichTextBox();
            this.statusStrip_label = new System.Windows.Forms.StatusStrip();
            this.lbexport_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.group_nowstatus = new System.Windows.Forms.GroupBox();
            this.picture_status = new System.Windows.Forms.PictureBox();
            this.lb_regresh = new System.Windows.Forms.Label();
            this.lb_changepwd = new System.Windows.Forms.Label();
            this.group_type = new System.Windows.Forms.GroupBox();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.group_status = new System.Windows.Forms.GroupBox();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.group_date = new System.Windows.Forms.GroupBox();
            this.cb_date = new System.Windows.Forms.ComboBox();
            this.picture_user = new System.Windows.Forms.PictureBox();
            this.picture_logo = new System.Windows.Forms.PictureBox();
            this.userContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.group_applyinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applyinfo_grid)).BeginInit();
            this.group_rejectreason.SuspendLayout();
            this.group_applyreason.SuspendLayout();
            this.statusStrip_label.SuspendLayout();
            this.group_nowstatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_status)).BeginInit();
            this.group_type.SuspendLayout();
            this.group_status.SuspendLayout();
            this.group_date.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // group_applyinfo
            // 
            this.group_applyinfo.Controls.Add(this.applyinfo_grid);
            this.group_applyinfo.Location = new System.Drawing.Point(9, 211);
            this.group_applyinfo.Margin = new System.Windows.Forms.Padding(4);
            this.group_applyinfo.Name = "group_applyinfo";
            this.group_applyinfo.Padding = new System.Windows.Forms.Padding(4);
            this.group_applyinfo.Size = new System.Drawing.Size(727, 328);
            this.group_applyinfo.TabIndex = 1;
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
            this.applyinfo_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.applyinfo_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applyinfo_grid.Location = new System.Drawing.Point(4, 22);
            this.applyinfo_grid.Margin = new System.Windows.Forms.Padding(4);
            this.applyinfo_grid.MultiSelect = false;
            this.applyinfo_grid.Name = "applyinfo_grid";
            this.applyinfo_grid.ReadOnly = true;
            this.applyinfo_grid.RowHeadersVisible = false;
            this.applyinfo_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.applyinfo_grid.Size = new System.Drawing.Size(719, 302);
            this.applyinfo_grid.TabIndex = 2;
            this.applyinfo_grid.SelectionChanged += new System.EventHandler(this.applyinfo_grid_SelectionChanged);
            // 
            // btn_export
            // 
            this.btn_export.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_export.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_export.Location = new System.Drawing.Point(84, 25);
            this.btn_export.Margin = new System.Windows.Forms.Padding(4);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(179, 51);
            this.btn_export.TabIndex = 7;
            this.btn_export.Text = "导出数据";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // group_rejectreason
            // 
            this.group_rejectreason.Controls.Add(this.rtxt_reject);
            this.group_rejectreason.Location = new System.Drawing.Point(748, 374);
            this.group_rejectreason.Margin = new System.Windows.Forms.Padding(4);
            this.group_rejectreason.Name = "group_rejectreason";
            this.group_rejectreason.Padding = new System.Windows.Forms.Padding(4);
            this.group_rejectreason.Size = new System.Drawing.Size(275, 165);
            this.group_rejectreason.TabIndex = 6;
            this.group_rejectreason.TabStop = false;
            this.group_rejectreason.Text = "拒绝原因：";
            // 
            // rtxt_reject
            // 
            this.rtxt_reject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxt_reject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxt_reject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtxt_reject.ForeColor = System.Drawing.Color.Red;
            this.rtxt_reject.Location = new System.Drawing.Point(4, 22);
            this.rtxt_reject.Margin = new System.Windows.Forms.Padding(4);
            this.rtxt_reject.Name = "rtxt_reject";
            this.rtxt_reject.ReadOnly = true;
            this.rtxt_reject.Size = new System.Drawing.Size(267, 139);
            this.rtxt_reject.TabIndex = 4;
            this.rtxt_reject.Text = "";
            // 
            // group_applyreason
            // 
            this.group_applyreason.Controls.Add(this.rtxt_apply);
            this.group_applyreason.Location = new System.Drawing.Point(748, 211);
            this.group_applyreason.Margin = new System.Windows.Forms.Padding(4);
            this.group_applyreason.Name = "group_applyreason";
            this.group_applyreason.Padding = new System.Windows.Forms.Padding(4);
            this.group_applyreason.Size = new System.Drawing.Size(275, 136);
            this.group_applyreason.TabIndex = 5;
            this.group_applyreason.TabStop = false;
            this.group_applyreason.Text = "数据用途：";
            // 
            // rtxt_apply
            // 
            this.rtxt_apply.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxt_apply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxt_apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtxt_apply.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rtxt_apply.Location = new System.Drawing.Point(4, 22);
            this.rtxt_apply.Margin = new System.Windows.Forms.Padding(4);
            this.rtxt_apply.Name = "rtxt_apply";
            this.rtxt_apply.ReadOnly = true;
            this.rtxt_apply.Size = new System.Drawing.Size(267, 110);
            this.rtxt_apply.TabIndex = 3;
            this.rtxt_apply.Text = "";
            // 
            // statusStrip_label
            // 
            this.statusStrip_label.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip_label.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbexport_status});
            this.statusStrip_label.Location = new System.Drawing.Point(0, 553);
            this.statusStrip_label.Name = "statusStrip_label";
            this.statusStrip_label.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip_label.Size = new System.Drawing.Size(1045, 25);
            this.statusStrip_label.TabIndex = 2;
            this.statusStrip_label.Text = "statusStrip1";
            // 
            // lbexport_status
            // 
            this.lbexport_status.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbexport_status.Name = "lbexport_status";
            this.lbexport_status.Size = new System.Drawing.Size(49, 20);
            this.lbexport_status.Text = "XXXX";
            // 
            // group_nowstatus
            // 
            this.group_nowstatus.Controls.Add(this.picture_status);
            this.group_nowstatus.Controls.Add(this.btn_export);
            this.group_nowstatus.Location = new System.Drawing.Point(748, 104);
            this.group_nowstatus.Margin = new System.Windows.Forms.Padding(4);
            this.group_nowstatus.Name = "group_nowstatus";
            this.group_nowstatus.Padding = new System.Windows.Forms.Padding(4);
            this.group_nowstatus.Size = new System.Drawing.Size(275, 89);
            this.group_nowstatus.TabIndex = 9;
            this.group_nowstatus.TabStop = false;
            this.group_nowstatus.Text = "当前状态：";
            // 
            // picture_status
            // 
            this.picture_status.Image = global::ExportSASData.Properties.Resources.wait;
            this.picture_status.Location = new System.Drawing.Point(12, 26);
            this.picture_status.Margin = new System.Windows.Forms.Padding(4);
            this.picture_status.Name = "picture_status";
            this.picture_status.Size = new System.Drawing.Size(53, 50);
            this.picture_status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_status.TabIndex = 10;
            this.picture_status.TabStop = false;
            // 
            // lb_regresh
            // 
            this.lb_regresh.AutoSize = true;
            this.lb_regresh.BackColor = System.Drawing.Color.White;
            this.lb_regresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_regresh.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_regresh.ForeColor = System.Drawing.Color.Navy;
            this.lb_regresh.Location = new System.Drawing.Point(734, 50);
            this.lb_regresh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_regresh.Name = "lb_regresh";
            this.lb_regresh.Size = new System.Drawing.Size(101, 30);
            this.lb_regresh.TabIndex = 10;
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
            this.lb_changepwd.Location = new System.Drawing.Point(734, 9);
            this.lb_changepwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_changepwd.Name = "lb_changepwd";
            this.lb_changepwd.Size = new System.Drawing.Size(101, 30);
            this.lb_changepwd.TabIndex = 11;
            this.lb_changepwd.Text = "修改密码";
            this.lb_changepwd.Visible = false;
            this.lb_changepwd.Click += new System.EventHandler(this.lbchangepwd_Click);
            // 
            // group_type
            // 
            this.group_type.Controls.Add(this.cb_type);
            this.group_type.Location = new System.Drawing.Point(9, 122);
            this.group_type.Margin = new System.Windows.Forms.Padding(0);
            this.group_type.Name = "group_type";
            this.group_type.Padding = new System.Windows.Forms.Padding(0);
            this.group_type.Size = new System.Drawing.Size(195, 66);
            this.group_type.TabIndex = 17;
            this.group_type.TabStop = false;
            this.group_type.Text = "审批类型";
            // 
            // cb_type
            // 
            this.cb_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_type.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_type.FormattingEnabled = true;
            this.cb_type.ItemHeight = 18;
            this.cb_type.Location = new System.Drawing.Point(7, 25);
            this.cb_type.Margin = new System.Windows.Forms.Padding(4);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(175, 26);
            this.cb_type.TabIndex = 0;
            this.cb_type.SelectedIndexChanged += new System.EventHandler(this.cbtype_SelectedIndexChanged);
            // 
            // group_status
            // 
            this.group_status.Controls.Add(this.cb_status);
            this.group_status.Location = new System.Drawing.Point(501, 122);
            this.group_status.Margin = new System.Windows.Forms.Padding(0);
            this.group_status.Name = "group_status";
            this.group_status.Padding = new System.Windows.Forms.Padding(0);
            this.group_status.Size = new System.Drawing.Size(192, 66);
            this.group_status.TabIndex = 18;
            this.group_status.TabStop = false;
            this.group_status.Text = "审批状态";
            // 
            // cb_status
            // 
            this.cb_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_status.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_status.FormattingEnabled = true;
            this.cb_status.ItemHeight = 18;
            this.cb_status.Location = new System.Drawing.Point(44, 25);
            this.cb_status.Margin = new System.Windows.Forms.Padding(4);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(137, 26);
            this.cb_status.TabIndex = 0;
            this.cb_status.SelectedIndexChanged += new System.EventHandler(this.cbstatus_SelectedIndexChanged);
            // 
            // group_date
            // 
            this.group_date.Controls.Add(this.cb_date);
            this.group_date.Location = new System.Drawing.Point(257, 122);
            this.group_date.Margin = new System.Windows.Forms.Padding(0);
            this.group_date.Name = "group_date";
            this.group_date.Padding = new System.Windows.Forms.Padding(0);
            this.group_date.Size = new System.Drawing.Size(192, 66);
            this.group_date.TabIndex = 15;
            this.group_date.TabStop = false;
            this.group_date.Text = "申请时间";
            // 
            // cb_date
            // 
            this.cb_date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_date.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_date.FormattingEnabled = true;
            this.cb_date.ItemHeight = 18;
            this.cb_date.Location = new System.Drawing.Point(44, 25);
            this.cb_date.Margin = new System.Windows.Forms.Padding(4);
            this.cb_date.Name = "cb_date";
            this.cb_date.Size = new System.Drawing.Size(137, 26);
            this.cb_date.TabIndex = 0;
            this.cb_date.SelectedIndexChanged += new System.EventHandler(this.cbdate_SelectedIndexChanged);
            // 
            // picture_user
            // 
            this.picture_user.Image = global::ExportSASData.Properties.Resources.user;
            this.picture_user.Location = new System.Drawing.Point(974, 21);
            this.picture_user.Name = "picture_user";
            this.picture_user.Size = new System.Drawing.Size(49, 50);
            this.picture_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_user.TabIndex = 21;
            this.picture_user.TabStop = false;
            this.picture_user.Click += new System.EventHandler(this.pictureuser_Click);
            this.picture_user.MouseHover += new System.EventHandler(this.pictureuser_MouseHover);
            // 
            // picture_logo
            // 
            this.picture_logo.BackColor = System.Drawing.Color.White;
            this.picture_logo.Image = global::ExportSASData.Properties.Resources.logo2;
            this.picture_logo.Location = new System.Drawing.Point(0, 0);
            this.picture_logo.Margin = new System.Windows.Forms.Padding(4);
            this.picture_logo.Name = "picture_logo";
            this.picture_logo.Size = new System.Drawing.Size(1045, 96);
            this.picture_logo.TabIndex = 0;
            this.picture_logo.TabStop = false;
            // 
            // userContextMenu
            // 
            this.userContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.userContextMenu.Name = "userContextMenu";
            this.userContextMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 578);
            this.Controls.Add(this.picture_user);
            this.Controls.Add(this.group_type);
            this.Controls.Add(this.group_status);
            this.Controls.Add(this.group_date);
            this.Controls.Add(this.lb_changepwd);
            this.Controls.Add(this.lb_regresh);
            this.Controls.Add(this.group_nowstatus);
            this.Controls.Add(this.group_rejectreason);
            this.Controls.Add(this.group_applyreason);
            this.Controls.Add(this.statusStrip_label);
            this.Controls.Add(this.group_applyinfo);
            this.Controls.Add(this.picture_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ExportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAS平台数据导出系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExportForm_FormClosing);
            this.group_applyinfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.applyinfo_grid)).EndInit();
            this.group_rejectreason.ResumeLayout(false);
            this.group_applyreason.ResumeLayout(false);
            this.statusStrip_label.ResumeLayout(false);
            this.statusStrip_label.PerformLayout();
            this.group_nowstatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_status)).EndInit();
            this.group_type.ResumeLayout(false);
            this.group_status.ResumeLayout(false);
            this.group_date.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_logo;
        private System.Windows.Forms.GroupBox group_applyinfo;
        private System.Windows.Forms.GroupBox group_rejectreason;
        private System.Windows.Forms.RichTextBox rtxt_reject;
        private System.Windows.Forms.GroupBox group_applyreason;
        private System.Windows.Forms.RichTextBox rtxt_apply;
        private System.Windows.Forms.DataGridView applyinfo_grid;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.StatusStrip statusStrip_label;
        private System.Windows.Forms.ToolStripStatusLabel lbexport_status;
        private System.Windows.Forms.GroupBox group_nowstatus;
        private System.Windows.Forms.PictureBox picture_status;
        private System.Windows.Forms.Label lb_regresh;
        private System.Windows.Forms.Label lb_changepwd;
        private System.Windows.Forms.GroupBox group_type;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.GroupBox group_status;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.GroupBox group_date;
        private System.Windows.Forms.ComboBox cb_date;
        private System.Windows.Forms.PictureBox picture_user;
        private System.Windows.Forms.ContextMenuStrip userContextMenu;
    }
}