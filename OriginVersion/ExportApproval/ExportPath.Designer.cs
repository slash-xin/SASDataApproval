namespace ExportApproval
{
    partial class ExportPath
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportPath));
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_location = new System.Windows.Forms.Button();
            this.btn_browser = new System.Windows.Forms.Button();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.lb_progress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_export
            // 
            this.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_export.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_export.Location = new System.Drawing.Point(495, 120);
            this.btn_export.Margin = new System.Windows.Forms.Padding(4);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(111, 78);
            this.btn_export.TabIndex = 11;
            this.btn_export.Text = "导出";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // btn_location
            // 
            this.btn_location.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_location.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_location.Location = new System.Drawing.Point(131, 120);
            this.btn_location.Margin = new System.Windows.Forms.Padding(4);
            this.btn_location.Name = "btn_location";
            this.btn_location.Size = new System.Drawing.Size(115, 78);
            this.btn_location.TabIndex = 12;
            this.btn_location.Text = "定位文件";
            this.btn_location.UseVisualStyleBackColor = true;
            this.btn_location.Click += new System.EventHandler(this.btnlocation_Click);
            // 
            // btn_browser
            // 
            this.btn_browser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_browser.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_browser.Location = new System.Drawing.Point(614, 54);
            this.btn_browser.Margin = new System.Windows.Forms.Padding(4);
            this.btn_browser.Name = "btn_browser";
            this.btn_browser.Size = new System.Drawing.Size(80, 29);
            this.btn_browser.TabIndex = 13;
            this.btn_browser.Text = "浏览...";
            this.btn_browser.UseVisualStyleBackColor = true;
            this.btn_browser.Click += new System.EventHandler(this.btnbrowser_Click);
            // 
            // txt_path
            // 
            this.txt_path.BackColor = System.Drawing.Color.White;
            this.txt_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_path.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_path.Location = new System.Drawing.Point(13, 54);
            this.txt_path.Margin = new System.Windows.Forms.Padding(4);
            this.txt_path.Name = "txt_path";
            this.txt_path.ReadOnly = true;
            this.txt_path.Size = new System.Drawing.Size(593, 27);
            this.txt_path.TabIndex = 14;
            // 
            // lb_progress
            // 
            this.lb_progress.AutoSize = true;
            this.lb_progress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_progress.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_progress.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_progress.Location = new System.Drawing.Point(13, 9);
            this.lb_progress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_progress.Name = "lb_progress";
            this.lb_progress.Size = new System.Drawing.Size(39, 19);
            this.lb_progress.TabIndex = 15;
            this.lb_progress.Text = "   ";
            // 
            // ExportPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 235);
            this.Controls.Add(this.lb_progress);
            this.Controls.Add(this.btn_browser);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.btn_location);
            this.Controls.Add(this.btn_export);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExportPath";
            this.Text = "导出路径";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_location;
        private System.Windows.Forms.Button btn_browser;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Label lb_progress;
    }
}