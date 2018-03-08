namespace ExportApproval
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.status_bar = new System.Windows.Forms.StatusStrip();
            this.lblogin_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.picture_logo = new System.Windows.Forms.PictureBox();
            this.status_bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "账  号：";
            // 
            // txt_user
            // 
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_user.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_user.Location = new System.Drawing.Point(125, 80);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(143, 23);
            this.txt_user.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "密  码：";
            // 
            // txt_pwd
            // 
            this.txt_pwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pwd.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_pwd.Location = new System.Drawing.Point(125, 113);
            this.txt_pwd.Margin = new System.Windows.Forms.Padding(0);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.PasswordChar = '*';
            this.txt_pwd.Size = new System.Drawing.Size(143, 23);
            this.txt_pwd.TabIndex = 3;
            // 
            // btn_login
            // 
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_login.Location = new System.Drawing.Point(66, 157);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(202, 32);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "登 陆";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // status_bar
            // 
            this.status_bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblogin_status});
            this.status_bar.Location = new System.Drawing.Point(0, 211);
            this.status_bar.Name = "status_bar";
            this.status_bar.Size = new System.Drawing.Size(330, 22);
            this.status_bar.TabIndex = 6;
            // 
            // lblogin_status
            // 
            this.lblogin_status.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblogin_status.Name = "lblogin_status";
            this.lblogin_status.Size = new System.Drawing.Size(164, 17);
            this.lblogin_status.Text = "提示：请输入用户名和密码。";
            // 
            // picture_logo
            // 
            this.picture_logo.BackColor = System.Drawing.Color.White;
            this.picture_logo.Image = global::ExportApproval.Properties.Resources.logo;
            this.picture_logo.Location = new System.Drawing.Point(0, 0);
            this.picture_logo.Name = "picture_logo";
            this.picture_logo.Size = new System.Drawing.Size(330, 64);
            this.picture_logo.TabIndex = 5;
            this.picture_logo.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 233);
            this.Controls.Add(this.status_bar);
            this.Controls.Add(this.picture_logo);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据导出审批";
            this.status_bar.ResumeLayout(false);
            this.status_bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.PictureBox picture_logo;
        private System.Windows.Forms.StatusStrip status_bar;
        private System.Windows.Forms.ToolStripStatusLabel lblogin_status;
    }
}

