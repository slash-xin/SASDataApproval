namespace ExportSASData
{
    partial class AuthUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthUser));
            this.lbLoading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbLoading
            // 
            this.lbLoading.AutoSize = true;
            this.lbLoading.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbLoading.Location = new System.Drawing.Point(67, 36);
            this.lbLoading.Name = "lbLoading";
            this.lbLoading.Size = new System.Drawing.Size(151, 25);
            this.lbLoading.TabIndex = 1;
            this.lbLoading.Text = "正在登陆...";
            // 
            // AuthUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 86);
            this.Controls.Add(this.lbLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuthUser";
            this.Text = "AuthUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLoading;
    }
}