using System;
using System.Windows.Forms;

namespace ExportApproval
{
    public partial class RejectReasonForm : Form
    {
        public RejectReasonForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 获取拒绝原因
        /// </summary>
        /// <returns></returns>
        public string GetRejectReason()
        {
            return rtxt_reason.Text;
        }

        /// <summary>
        /// 拒绝
        /// </summary>
        private void btnreject_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtxt_reason.Text))
            {
                MessageBox.Show("请输入拒绝原因！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                this.Close();
        }
    }
}
