namespace ExportApproval
{
    partial class DataManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataManagement));
            this.tabs = new System.Windows.Forms.TabControl();
            this.tab_apply = new System.Windows.Forms.TabPage();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.dataGridApply = new System.Windows.Forms.DataGridView();
            this.tab_approval = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridApproval = new System.Windows.Forms.DataGridView();
            this.tab_user = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridUser = new System.Windows.Forms.DataGridView();
            this.tabs.SuspendLayout();
            this.tab_apply.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridApply)).BeginInit();
            this.tab_approval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridApproval)).BeginInit();
            this.tab_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUser)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tab_apply);
            this.tabs.Controls.Add(this.tab_approval);
            this.tabs.Controls.Add(this.tab_user);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.ItemSize = new System.Drawing.Size(76, 40);
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1182, 653);
            this.tabs.TabIndex = 0;
            this.tabs.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabs_DrawItem);
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
            // 
            // tab_apply
            // 
            this.tab_apply.BackColor = System.Drawing.Color.White;
            this.tab_apply.Controls.Add(this.btn_remove);
            this.tab_apply.Controls.Add(this.btn_export);
            this.tab_apply.Controls.Add(this.dataGridApply);
            this.tab_apply.Location = new System.Drawing.Point(4, 44);
            this.tab_apply.Name = "tab_apply";
            this.tab_apply.Padding = new System.Windows.Forms.Padding(3);
            this.tab_apply.Size = new System.Drawing.Size(1174, 605);
            this.tab_apply.TabIndex = 0;
            this.tab_apply.Text = "申请信息";
            // 
            // btn_remove
            // 
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.ForeColor = System.Drawing.Color.Red;
            this.btn_remove.Location = new System.Drawing.Point(930, 10);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(4);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(100, 35);
            this.btn_remove.TabIndex = 5;
            this.btn_remove.Text = "删除";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btn_export
            // 
            this.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_export.Location = new System.Drawing.Point(1050, 10);
            this.btn_export.Margin = new System.Windows.Forms.Padding(4);
            this.btn_export.Name = "btn_export";
            this.btn_export.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_export.Size = new System.Drawing.Size(100, 35);
            this.btn_export.TabIndex = 4;
            this.btn_export.Text = "导出";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // dataGridApply
            // 
            this.dataGridApply.AllowUserToAddRows = false;
            this.dataGridApply.BackgroundColor = System.Drawing.Color.White;
            this.dataGridApply.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridApply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridApply.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridApply.Location = new System.Drawing.Point(3, 70);
            this.dataGridApply.Name = "dataGridApply";
            this.dataGridApply.ReadOnly = true;
            this.dataGridApply.RowHeadersVisible = false;
            this.dataGridApply.RowTemplate.Height = 27;
            this.dataGridApply.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridApply.Size = new System.Drawing.Size(1168, 532);
            this.dataGridApply.TabIndex = 0;
            // 
            // tab_approval
            // 
            this.tab_approval.BackColor = System.Drawing.Color.White;
            this.tab_approval.Controls.Add(this.button1);
            this.tab_approval.Controls.Add(this.button2);
            this.tab_approval.Controls.Add(this.dataGridApproval);
            this.tab_approval.Location = new System.Drawing.Point(4, 44);
            this.tab_approval.Name = "tab_approval";
            this.tab_approval.Padding = new System.Windows.Forms.Padding(3);
            this.tab_approval.Size = new System.Drawing.Size(1174, 605);
            this.tab_approval.TabIndex = 1;
            this.tab_approval.Text = "审批历史";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(930, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "删除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(1050, 10);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "导出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // dataGridApproval
            // 
            this.dataGridApproval.AllowUserToAddRows = false;
            this.dataGridApproval.AllowUserToDeleteRows = false;
            this.dataGridApproval.AllowUserToOrderColumns = true;
            this.dataGridApproval.BackgroundColor = System.Drawing.Color.White;
            this.dataGridApproval.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridApproval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridApproval.Location = new System.Drawing.Point(3, 70);
            this.dataGridApproval.Name = "dataGridApproval";
            this.dataGridApproval.ReadOnly = true;
            this.dataGridApproval.RowHeadersVisible = false;
            this.dataGridApproval.RowTemplate.Height = 27;
            this.dataGridApproval.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridApproval.Size = new System.Drawing.Size(1168, 525);
            this.dataGridApproval.TabIndex = 0;
            // 
            // tab_user
            // 
            this.tab_user.BackColor = System.Drawing.Color.White;
            this.tab_user.Controls.Add(this.button5);
            this.tab_user.Controls.Add(this.btn_edit);
            this.tab_user.Controls.Add(this.button3);
            this.tab_user.Controls.Add(this.button4);
            this.tab_user.Controls.Add(this.dataGridUser);
            this.tab_user.Location = new System.Drawing.Point(4, 44);
            this.tab_user.Name = "tab_user";
            this.tab_user.Size = new System.Drawing.Size(1174, 605);
            this.tab_user.TabIndex = 2;
            this.tab_user.Text = "用户信息";
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button5.Location = new System.Drawing.Point(810, 10);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button5.Size = new System.Drawing.Size(100, 35);
            this.button5.TabIndex = 11;
            this.button5.Text = "添加";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_edit.Location = new System.Drawing.Point(690, 10);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_edit.Size = new System.Drawing.Size(100, 35);
            this.btn_edit.TabIndex = 10;
            this.btn_edit.Text = "编辑";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(930, 10);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 35);
            this.button3.TabIndex = 9;
            this.button3.Text = "删除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button4.Location = new System.Drawing.Point(1050, 10);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button4.Size = new System.Drawing.Size(100, 35);
            this.button4.TabIndex = 8;
            this.button4.Text = "导出";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // dataGridUser
            // 
            this.dataGridUser.AllowUserToAddRows = false;
            this.dataGridUser.AllowUserToDeleteRows = false;
            this.dataGridUser.AllowUserToOrderColumns = true;
            this.dataGridUser.BackgroundColor = System.Drawing.Color.White;
            this.dataGridUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUser.Location = new System.Drawing.Point(3, 70);
            this.dataGridUser.Name = "dataGridUser";
            this.dataGridUser.ReadOnly = true;
            this.dataGridUser.RowHeadersVisible = false;
            this.dataGridUser.RowTemplate.Height = 27;
            this.dataGridUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUser.Size = new System.Drawing.Size(1168, 532);
            this.dataGridUser.TabIndex = 0;
            this.dataGridUser.SelectionChanged += new System.EventHandler(this.dataGridUser_SelectionChanged);
            // 
            // DataManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataManagement";
            this.Text = "数据管理";
            this.TopMost = true;
            this.tabs.ResumeLayout(false);
            this.tab_apply.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridApply)).EndInit();
            this.tab_approval.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridApproval)).EndInit();
            this.tab_user.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tab_apply;
        private System.Windows.Forms.DataGridView dataGridApply;
        private System.Windows.Forms.TabPage tab_approval;
        private System.Windows.Forms.TabPage tab_user;
        private System.Windows.Forms.DataGridView dataGridApproval;
        private System.Windows.Forms.DataGridView dataGridUser;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button button5;
    }
}