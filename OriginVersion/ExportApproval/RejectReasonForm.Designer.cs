namespace ExportApproval
{
    partial class RejectReasonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RejectReasonForm));
            this.rtxt_reason = new System.Windows.Forms.RichTextBox();
            this.btn_reject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxt_reason
            // 
            this.rtxt_reason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxt_reason.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtxt_reason.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtxt_reason.Location = new System.Drawing.Point(0, 0);
            this.rtxt_reason.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtxt_reason.MaxLength = 200;
            this.rtxt_reason.Name = "rtxt_reason";
            this.rtxt_reason.Size = new System.Drawing.Size(404, 150);
            this.rtxt_reason.TabIndex = 0;
            this.rtxt_reason.Text = "";
            // 
            // btn_reject
            // 
            this.btn_reject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reject.Location = new System.Drawing.Point(13, 158);
            this.btn_reject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_reject.Name = "btn_reject";
            this.btn_reject.Size = new System.Drawing.Size(382, 35);
            this.btn_reject.TabIndex = 1;
            this.btn_reject.Text = "拒绝申请";
            this.btn_reject.UseVisualStyleBackColor = true;
            this.btn_reject.Click += new System.EventHandler(this.btnreject_Click);
            // 
            // RejectReasonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 230);
            this.ControlBox = false;
            this.Controls.Add(this.btn_reject);
            this.Controls.Add(this.rtxt_reason);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RejectReasonForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "拒绝原因";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxt_reason;
        private System.Windows.Forms.Button btn_reject;
    }
}