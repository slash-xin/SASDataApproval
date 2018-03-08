namespace ExportApproval
{
    partial class AuthAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthAdmin));
            this.txt_authpwd = new System.Windows.Forms.TextBox();
            this.lbauthpwd = new System.Windows.Forms.Label();
            this.btn_sure = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_authpwd
            // 
            this.txt_authpwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_authpwd.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_authpwd.Location = new System.Drawing.Point(125, 48);
            this.txt_authpwd.Margin = new System.Windows.Forms.Padding(0);
            this.txt_authpwd.Name = "txt_authpwd";
            this.txt_authpwd.PasswordChar = '*';
            this.txt_authpwd.Size = new System.Drawing.Size(190, 27);
            this.txt_authpwd.TabIndex = 5;
            // 
            // lbauthpwd
            // 
            this.lbauthpwd.AutoSize = true;
            this.lbauthpwd.Location = new System.Drawing.Point(43, 52);
            this.lbauthpwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbauthpwd.Name = "lbauthpwd";
            this.lbauthpwd.Size = new System.Drawing.Size(82, 15);
            this.lbauthpwd.TabIndex = 4;
            this.lbauthpwd.Text = "管理密码：";
            // 
            // btn_sure
            // 
            this.btn_sure.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btn_sure.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_sure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sure.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_sure.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_sure.Location = new System.Drawing.Point(46, 123);
            this.btn_sure.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sure.Name = "btn_sure";
            this.btn_sure.Size = new System.Drawing.Size(269, 40);
            this.btn_sure.TabIndex = 6;
            this.btn_sure.Text = "确  定";
            this.btn_sure.UseVisualStyleBackColor = true;
            this.btn_sure.Click += new System.EventHandler(this.btnsure_Click);
            // 
            // authAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 207);
            this.Controls.Add(this.btn_sure);
            this.Controls.Add(this.txt_authpwd);
            this.Controls.Add(this.lbauthpwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "authAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员认证";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_authpwd;
        private System.Windows.Forms.Label lbauthpwd;
        private System.Windows.Forms.Button btn_sure;
    }
}