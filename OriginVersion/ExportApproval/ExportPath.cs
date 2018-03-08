using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExportApproval
{
    public partial class ExportPath : Form
    {
        string filepath = "";
        DataTable currentTable = new DataTable();
        public ExportPath(DataTable table)
        {
            InitializeComponent();
            currentTable = table;
        }

        private void btnbrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = "选择导出文件存放目录";
            if (folder.ShowDialog() == DialogResult.OK)
            {
                txt_path.Text = folder.SelectedPath;
            }
        }

        private void btnlocation_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("Explorer.exe");
            psi.Arguments = "/e,/select," + filepath;
            System.Diagnostics.Process.Start(psi);
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_path.Text.Trim()))
            {
                MessageBox.Show("请选择导出文件路径！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ExportToExcel(currentTable);
            }
        }

        /// <summary>
        /// 导出Excel(文件流，快）
        /// </summary>
        /// <param name="table">表</param>
        private void ExportToExcel(DataTable table)
        {
            string guid = Guid.NewGuid().ToString();
            guid = guid.Substring(guid.Length - 6).ToUpper();

            string filename = string.Format("导出{0}.xls", DateTime.Now.ToString().Replace("/","").Replace(":", "").Replace(" ", ""));
            filepath = string.Format("{0}\\{1}", txt_path.Text, filename);
            try
            {
                StreamWriter sw = new StreamWriter(filepath, false, Encoding.GetEncoding("gb2312"));

                StringBuilder sb = new StringBuilder();
                for (int k = 0; k < table.Columns.Count; k++)
                {
                    sb.Append(table.Columns[k].ColumnName.ToString() + "\t");
                }
                sb.Append(Environment.NewLine);

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    for (int j = 0; j < table.Columns.Count; j++)
                    {
                        string value = table.Rows[i][j].ToString().Trim();
                        sb.Append(value + "\t");
                    }
                    sb.Append(Environment.NewLine);
                    if (i + 1 == table.Rows.Count)
                    {
                        lb_progress.Text = "导出成功，文件名为: " + filename;
                    }
                }
                sw.Write(sb.ToString());
                sw.Flush();
                sw.Close();
                sw.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("导出失败！请重试");
            }
        }
    }
}
