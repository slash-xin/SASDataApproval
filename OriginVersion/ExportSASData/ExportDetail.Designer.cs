namespace ExportSASData
{
    partial class ExportDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportDetail));
            this.preview_grid = new System.Windows.Forms.DataGridView();
            this.group_preview = new System.Windows.Forms.GroupBox();
            this.group_path = new System.Windows.Forms.GroupBox();
            this.btn_location = new System.Windows.Forms.Button();
            this.lb_progress = new System.Windows.Forms.Label();
            this.progressbar = new System.Windows.Forms.ProgressBar();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_browser = new System.Windows.Forms.Button();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.group_filetype = new System.Windows.Forms.GroupBox();
            this.rbtn_excel = new System.Windows.Forms.RadioButton();
            this.rbtn_txt = new System.Windows.Forms.RadioButton();
            this.cb_delimiter = new System.Windows.Forms.ComboBox();
            this.txt_delimiter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.group_delimiter = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.preview_grid)).BeginInit();
            this.group_preview.SuspendLayout();
            this.group_path.SuspendLayout();
            this.group_filetype.SuspendLayout();
            this.group_delimiter.SuspendLayout();
            this.SuspendLayout();
            // 
            // preview_grid
            // 
            this.preview_grid.AllowUserToAddRows = false;
            this.preview_grid.AllowUserToDeleteRows = false;
            this.preview_grid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.preview_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.preview_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.preview_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preview_grid.Location = new System.Drawing.Point(3, 17);
            this.preview_grid.Name = "preview_grid";
            this.preview_grid.ReadOnly = true;
            this.preview_grid.RowHeadersVisible = false;
            this.preview_grid.Size = new System.Drawing.Size(674, 258);
            this.preview_grid.TabIndex = 0;
            // 
            // group_preview
            // 
            this.group_preview.BackColor = System.Drawing.SystemColors.Control;
            this.group_preview.Controls.Add(this.preview_grid);
            this.group_preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.group_preview.Location = new System.Drawing.Point(12, 12);
            this.group_preview.Name = "group_preview";
            this.group_preview.Size = new System.Drawing.Size(680, 278);
            this.group_preview.TabIndex = 1;
            this.group_preview.TabStop = false;
            this.group_preview.Text = " 数据预览(前10行):";
            // 
            // group_path
            // 
            this.group_path.Controls.Add(this.btn_location);
            this.group_path.Controls.Add(this.lb_progress);
            this.group_path.Controls.Add(this.progressbar);
            this.group_path.Controls.Add(this.btn_export);
            this.group_path.Controls.Add(this.btn_browser);
            this.group_path.Controls.Add(this.txt_path);
            this.group_path.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.group_path.Location = new System.Drawing.Point(12, 354);
            this.group_path.Name = "group_path";
            this.group_path.Size = new System.Drawing.Size(680, 90);
            this.group_path.TabIndex = 2;
            this.group_path.TabStop = false;
            this.group_path.Text = "导出数据：";
            // 
            // btn_location
            // 
            this.btn_location.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_location.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_location.Location = new System.Drawing.Point(495, 56);
            this.btn_location.Name = "btn_location";
            this.btn_location.Size = new System.Drawing.Size(70, 23);
            this.btn_location.TabIndex = 2;
            this.btn_location.Text = "定位文件";
            this.btn_location.UseVisualStyleBackColor = true;
            this.btn_location.Click += new System.EventHandler(this.btnlocation_Click);
            // 
            // lb_progress
            // 
            this.lb_progress.AutoSize = true;
            this.lb_progress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_progress.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_progress.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_progress.Location = new System.Drawing.Point(11, 58);
            this.lb_progress.Name = "lb_progress";
            this.lb_progress.Size = new System.Drawing.Size(31, 15);
            this.lb_progress.TabIndex = 10;
            this.lb_progress.Text = "   ";
            // 
            // progressbar
            // 
            this.progressbar.Location = new System.Drawing.Point(14, 20);
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(551, 25);
            this.progressbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressbar.TabIndex = 1;
            // 
            // btn_export
            // 
            this.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_export.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_export.Location = new System.Drawing.Point(589, 17);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(85, 62);
            this.btn_export.TabIndex = 9;
            this.btn_export.Text = "导出";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // btn_browser
            // 
            this.btn_browser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_browser.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_browser.Location = new System.Drawing.Point(505, 22);
            this.btn_browser.Name = "btn_browser";
            this.btn_browser.Size = new System.Drawing.Size(60, 23);
            this.btn_browser.TabIndex = 1;
            this.btn_browser.Text = "浏览...";
            this.btn_browser.UseVisualStyleBackColor = true;
            this.btn_browser.Click += new System.EventHandler(this.btnbrowser_Click);
            // 
            // txt_path
            // 
            this.txt_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_path.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_path.Location = new System.Drawing.Point(14, 22);
            this.txt_path.Name = "txt_path";
            this.txt_path.ReadOnly = true;
            this.txt_path.Size = new System.Drawing.Size(477, 23);
            this.txt_path.TabIndex = 2;
            // 
            // group_filetype
            // 
            this.group_filetype.Controls.Add(this.rbtn_excel);
            this.group_filetype.Controls.Add(this.rbtn_txt);
            this.group_filetype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.group_filetype.Location = new System.Drawing.Point(12, 296);
            this.group_filetype.Name = "group_filetype";
            this.group_filetype.Size = new System.Drawing.Size(282, 52);
            this.group_filetype.TabIndex = 10;
            this.group_filetype.TabStop = false;
            this.group_filetype.Text = "输出文件类型：";
            // 
            // rbtn_excel
            // 
            this.rbtn_excel.AutoSize = true;
            this.rbtn_excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn_excel.Location = new System.Drawing.Point(170, 25);
            this.rbtn_excel.Name = "rbtn_excel";
            this.rbtn_excel.Size = new System.Drawing.Size(76, 16);
            this.rbtn_excel.TabIndex = 0;
            this.rbtn_excel.Text = "Excel文件";
            this.rbtn_excel.UseVisualStyleBackColor = true;
            // 
            // rbtn_txt
            // 
            this.rbtn_txt.AutoSize = true;
            this.rbtn_txt.Checked = true;
            this.rbtn_txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn_txt.Location = new System.Drawing.Point(34, 25);
            this.rbtn_txt.Name = "rbtn_txt";
            this.rbtn_txt.Size = new System.Drawing.Size(70, 16);
            this.rbtn_txt.TabIndex = 0;
            this.rbtn_txt.TabStop = true;
            this.rbtn_txt.Text = "文本文件";
            this.rbtn_txt.UseVisualStyleBackColor = true;
            this.rbtn_txt.CheckedChanged += new System.EventHandler(this.rbtntxt_CheckedChanged);
            // 
            // cb_delimiter
            // 
            this.cb_delimiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_delimiter.FormattingEnabled = true;
            this.cb_delimiter.Location = new System.Drawing.Point(147, 20);
            this.cb_delimiter.Name = "cb_delimiter";
            this.cb_delimiter.Size = new System.Drawing.Size(68, 20);
            this.cb_delimiter.TabIndex = 4;
            this.cb_delimiter.SelectedIndexChanged += new System.EventHandler(this.cbdelimiter_SelectedIndexChanged);
            // 
            // txt_delimiter
            // 
            this.txt_delimiter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_delimiter.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_delimiter.Location = new System.Drawing.Point(235, 20);
            this.txt_delimiter.Name = "txt_delimiter";
            this.txt_delimiter.ReadOnly = true;
            this.txt_delimiter.Size = new System.Drawing.Size(74, 21);
            this.txt_delimiter.TabIndex = 5;
            this.txt_delimiter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "文本分隔符：";
            // 
            // group_delimiter
            // 
            this.group_delimiter.Controls.Add(this.label2);
            this.group_delimiter.Controls.Add(this.txt_delimiter);
            this.group_delimiter.Controls.Add(this.cb_delimiter);
            this.group_delimiter.Location = new System.Drawing.Point(324, 296);
            this.group_delimiter.Name = "group_delimiter";
            this.group_delimiter.Size = new System.Drawing.Size(368, 52);
            this.group_delimiter.TabIndex = 11;
            this.group_delimiter.TabStop = false;
            this.group_delimiter.Text = "文本文件分隔符设置";
            // 
            // ExportDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 456);
            this.Controls.Add(this.group_delimiter);
            this.Controls.Add(this.group_path);
            this.Controls.Add(this.group_filetype);
            this.Controls.Add(this.group_preview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportDetail";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "数据下载设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExportDetail_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.preview_grid)).EndInit();
            this.group_preview.ResumeLayout(false);
            this.group_path.ResumeLayout(false);
            this.group_path.PerformLayout();
            this.group_filetype.ResumeLayout(false);
            this.group_filetype.PerformLayout();
            this.group_delimiter.ResumeLayout(false);
            this.group_delimiter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView preview_grid;
        private System.Windows.Forms.GroupBox group_preview;
        private System.Windows.Forms.GroupBox group_path;
        private System.Windows.Forms.Button btn_browser;
        private System.Windows.Forms.ComboBox cb_delimiter;
        private System.Windows.Forms.TextBox txt_delimiter;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox group_filetype;
        private System.Windows.Forms.RadioButton rbtn_excel;
        private System.Windows.Forms.RadioButton rbtn_txt;
        private System.Windows.Forms.GroupBox group_delimiter;
        private System.Windows.Forms.ProgressBar progressbar;
        private System.Windows.Forms.Label lb_progress;
        private System.Windows.Forms.Button btn_location;
    }
}