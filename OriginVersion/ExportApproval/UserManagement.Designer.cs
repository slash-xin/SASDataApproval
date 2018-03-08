namespace ExportApproval
{
    partial class UserManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagement));
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_phone = new System.Windows.Forms.Label();
            this.lb_pwd = new System.Windows.Forms.Label();
            this.lb_region = new System.Windows.Forms.Label();
            this.lb_department = new System.Windows.Forms.Label();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_department = new System.Windows.Forms.TextBox();
            this.txt_region = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lb_usertype = new System.Windows.Forms.Label();
            this.cb_usertype = new System.Windows.Forms.ComboBox();
            this.txt_systemid = new System.Windows.Forms.TextBox();
            this.lb_systemid = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lb_leader = new System.Windows.Forms.Label();
            this.clb_leader = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(37, 44);
            this.lb_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(67, 15);
            this.lb_username.TabIndex = 4;
            this.lb_username.Text = "用户名：";
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Location = new System.Drawing.Point(37, 112);
            this.lb_phone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(82, 15);
            this.lb_phone.TabIndex = 6;
            this.lb_phone.Text = "手机号码：";
            // 
            // lb_pwd
            // 
            this.lb_pwd.AutoSize = true;
            this.lb_pwd.Location = new System.Drawing.Point(377, 256);
            this.lb_pwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_pwd.Name = "lb_pwd";
            this.lb_pwd.Size = new System.Drawing.Size(82, 15);
            this.lb_pwd.TabIndex = 8;
            this.lb_pwd.Text = "初始密码：";
            // 
            // lb_region
            // 
            this.lb_region.AutoSize = true;
            this.lb_region.Location = new System.Drawing.Point(37, 185);
            this.lb_region.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_region.Name = "lb_region";
            this.lb_region.Size = new System.Drawing.Size(52, 15);
            this.lb_region.TabIndex = 10;
            this.lb_region.Text = "地区：";
            // 
            // lb_department
            // 
            this.lb_department.AutoSize = true;
            this.lb_department.Location = new System.Drawing.Point(377, 187);
            this.lb_department.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_department.Name = "lb_department";
            this.lb_department.Size = new System.Drawing.Size(52, 15);
            this.lb_department.TabIndex = 12;
            this.lb_department.Text = "部门：";
            // 
            // txt_pwd
            // 
            this.txt_pwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pwd.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_pwd.Location = new System.Drawing.Point(458, 250);
            this.txt_pwd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(190, 27);
            this.txt_pwd.TabIndex = 15;
            this.txt_pwd.Text = "123456";
            // 
            // txt_username
            // 
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_username.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_username.Location = new System.Drawing.Point(112, 42);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(190, 27);
            this.txt_username.TabIndex = 16;
            // 
            // txt_department
            // 
            this.txt_department.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_department.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_department.Location = new System.Drawing.Point(458, 181);
            this.txt_department.Margin = new System.Windows.Forms.Padding(4);
            this.txt_department.Name = "txt_department";
            this.txt_department.Size = new System.Drawing.Size(190, 27);
            this.txt_department.TabIndex = 17;
            // 
            // txt_region
            // 
            this.txt_region.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_region.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_region.Location = new System.Drawing.Point(112, 181);
            this.txt_region.Margin = new System.Windows.Forms.Padding(4);
            this.txt_region.Name = "txt_region";
            this.txt_region.Size = new System.Drawing.Size(190, 27);
            this.txt_region.TabIndex = 18;
            // 
            // txt_phone
            // 
            this.txt_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_phone.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_phone.Location = new System.Drawing.Point(112, 108);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_phone.MaxLength = 11;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(190, 27);
            this.txt_phone.TabIndex = 19;
            this.txt_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtphone_KeyPress);
            // 
            // lb_usertype
            // 
            this.lb_usertype.AutoSize = true;
            this.lb_usertype.Location = new System.Drawing.Point(377, 112);
            this.lb_usertype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_usertype.Name = "lb_usertype";
            this.lb_usertype.Size = new System.Drawing.Size(52, 15);
            this.lb_usertype.TabIndex = 20;
            this.lb_usertype.Text = "类别：";
            // 
            // cb_usertype
            // 
            this.cb_usertype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_usertype.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_usertype.FormattingEnabled = true;
            this.cb_usertype.ItemHeight = 18;
            this.cb_usertype.Location = new System.Drawing.Point(458, 109);
            this.cb_usertype.Margin = new System.Windows.Forms.Padding(4);
            this.cb_usertype.Name = "cb_usertype";
            this.cb_usertype.Size = new System.Drawing.Size(190, 26);
            this.cb_usertype.TabIndex = 21;
            this.cb_usertype.SelectedIndexChanged += new System.EventHandler(this.cbusertype_SelectedIndexChanged);
            // 
            // txt_systemid
            // 
            this.txt_systemid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_systemid.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_systemid.Location = new System.Drawing.Point(458, 40);
            this.txt_systemid.Margin = new System.Windows.Forms.Padding(4);
            this.txt_systemid.Name = "txt_systemid";
            this.txt_systemid.Size = new System.Drawing.Size(190, 27);
            this.txt_systemid.TabIndex = 23;
            // 
            // lb_systemid
            // 
            this.lb_systemid.AutoSize = true;
            this.lb_systemid.Location = new System.Drawing.Point(377, 44);
            this.lb_systemid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_systemid.Name = "lb_systemid";
            this.lb_systemid.Size = new System.Drawing.Size(82, 15);
            this.lb_systemid.TabIndex = 22;
            this.lb_systemid.Text = "系统账号：";
            // 
            // btn_save
            // 
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_save.Location = new System.Drawing.Point(548, 331);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_save.Size = new System.Drawing.Size(100, 35);
            this.btn_save.TabIndex = 24;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Location = new System.Drawing.Point(391, 331);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(100, 35);
            this.btn_reset.TabIndex = 25;
            this.btn_reset.Text = "重置";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // lb_leader
            // 
            this.lb_leader.AutoSize = true;
            this.lb_leader.Location = new System.Drawing.Point(37, 256);
            this.lb_leader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_leader.Name = "lb_leader";
            this.lb_leader.Size = new System.Drawing.Size(82, 15);
            this.lb_leader.TabIndex = 26;
            this.lb_leader.Text = "上级领导：";
            // 
            // clb_leader
            // 
            this.clb_leader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clb_leader.FormattingEnabled = true;
            this.clb_leader.Location = new System.Drawing.Point(112, 256);
            this.clb_leader.Name = "clb_leader";
            this.clb_leader.Size = new System.Drawing.Size(190, 80);
            this.clb_leader.TabIndex = 28;
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(699, 390);
            this.Controls.Add(this.clb_leader);
            this.Controls.Add(this.lb_leader);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_systemid);
            this.Controls.Add(this.lb_systemid);
            this.Controls.Add(this.cb_usertype);
            this.Controls.Add(this.lb_usertype);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_region);
            this.Controls.Add(this.txt_department);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.lb_department);
            this.Controls.Add(this.lb_region);
            this.Controls.Add(this.lb_pwd);
            this.Controls.Add(this.lb_phone);
            this.Controls.Add(this.lb_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserManagement";
            this.Text = "用户管理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.Label lb_pwd;
        private System.Windows.Forms.Label lb_region;
        private System.Windows.Forms.Label lb_department;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_department;
        private System.Windows.Forms.TextBox txt_region;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lb_usertype;
        private System.Windows.Forms.ComboBox cb_usertype;
        private System.Windows.Forms.TextBox txt_systemid;
        private System.Windows.Forms.Label lb_systemid;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lb_leader;
        private System.Windows.Forms.CheckedListBox clb_leader;
    }
}