namespace ExportApproval
{
    partial class ChangePassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.group_changepwd = new System.Windows.Forms.GroupBox();
            this.txt_newcheck = new System.Windows.Forms.TextBox();
            this.txt_newpwd = new System.Windows.Forms.TextBox();
            this.txt_oldpwd = new System.Windows.Forms.TextBox();
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.group_changepwd.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入旧密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "输入新密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认新密码：";
            // 
            // group_changepwd
            // 
            this.group_changepwd.Controls.Add(this.txt_newcheck);
            this.group_changepwd.Controls.Add(this.txt_newpwd);
            this.group_changepwd.Controls.Add(this.txt_oldpwd);
            this.group_changepwd.Controls.Add(this.label1);
            this.group_changepwd.Controls.Add(this.label3);
            this.group_changepwd.Controls.Add(this.label2);
            this.group_changepwd.Location = new System.Drawing.Point(12, 27);
            this.group_changepwd.Name = "group_changepwd";
            this.group_changepwd.Size = new System.Drawing.Size(272, 125);
            this.group_changepwd.TabIndex = 3;
            this.group_changepwd.TabStop = false;
            this.group_changepwd.Text = "修改登陆密码";
            // 
            // txt_newcheck
            // 
            this.txt_newcheck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_newcheck.Location = new System.Drawing.Point(102, 90);
            this.txt_newcheck.Name = "txt_newcheck";
            this.txt_newcheck.PasswordChar = '*';
            this.txt_newcheck.Size = new System.Drawing.Size(146, 21);
            this.txt_newcheck.TabIndex = 5;
            // 
            // txt_newpwd
            // 
            this.txt_newpwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_newpwd.Location = new System.Drawing.Point(102, 59);
            this.txt_newpwd.Name = "txt_newpwd";
            this.txt_newpwd.PasswordChar = '*';
            this.txt_newpwd.Size = new System.Drawing.Size(146, 21);
            this.txt_newpwd.TabIndex = 4;
            // 
            // txt_oldpwd
            // 
            this.txt_oldpwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_oldpwd.Location = new System.Drawing.Point(102, 28);
            this.txt_oldpwd.Name = "txt_oldpwd";
            this.txt_oldpwd.PasswordChar = '*';
            this.txt_oldpwd.Size = new System.Drawing.Size(146, 21);
            this.txt_oldpwd.TabIndex = 3;
            // 
            // btn_change
            // 
            this.btn_change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_change.Location = new System.Drawing.Point(188, 171);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(72, 23);
            this.btn_change.TabIndex = 4;
            this.btn_change.Text = "修改";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Location = new System.Drawing.Point(31, 171);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(72, 23);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // ChangePassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 206);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.group_changepwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChangePassForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "密码安全";
            this.group_changepwd.ResumeLayout(false);
            this.group_changepwd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox group_changepwd;
        private System.Windows.Forms.TextBox txt_newcheck;
        private System.Windows.Forms.TextBox txt_newpwd;
        private System.Windows.Forms.TextBox txt_oldpwd;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Button btn_cancel;
    }
}