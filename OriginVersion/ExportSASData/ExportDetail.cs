using ExportSASData.Model;
using OfficeOpenXml;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ExportSASData
{

    public partial class ExportDetail : Form
    {
        string filepath = "";
        DataTable table = new DataTable();
        public ExportDetail()
        {
            InitializeComponent();
            bindPreview();
            bindComboBox(cb_delimiter);
            setProgressbar(false, false, true, true, false);
        }

        /// <summary>
        /// bind 预览列表
        /// </summary>
        private void bindPreview()
        {
            DataTable table = ExportFileView.getPreviewData(ExportForm.currentapplyid);
            if (table != null) preview_grid.DataSource = table;
            dataGridPreviewSetting();
        }

        /// <summary>
        /// bind 分隔符下拉框
        /// </summary>
        /// <param name="cb">ComboBox</param>
        private void bindComboBox(ComboBox cb)
        {
            ArrayList list = new ArrayList();
            list.Add(new DictionaryEntry("逗号", ","));
            list.Add(new DictionaryEntry("分号", ";"));
            list.Add(new DictionaryEntry("竖线", "|"));
            list.Add(new DictionaryEntry("自定义", ""));

            cb.DataSource = list;
            cb.DisplayMember = "Key";
            cb.ValueMember = "Value";
            cb.SelectedIndex = 0;
            txt_delimiter.Text = cb_delimiter.SelectedValue.ToString();
        }

        /// <summary>
        /// 分隔加密字段号
        /// </summary>
        /// <param name="encryptednum">字段号字符串</param>
        /// <returns></returns>
        private int[] getEncryptColumns(string encryptednum)
        {
            if (encryptednum == "")
            {
                return new int[] { };
            }
            string[] strarr = encryptednum.Trim().Split(' ');
            int[] numarr = new int[strarr.Length];
            for (int i = 0; i < strarr.Length; i++)
            {
                numarr[i] = Convert.ToInt32(strarr[i]);
            }
            return numarr;
        }


        /// <summary>
        /// 预览列表设置
        /// </summary>
        private void dataGridPreviewSetting()
        {
            int[] numarr = getEncryptColumns(ExportForm.encryptednum);
            int[] txtarr = getEncryptColumns(ExportForm.encryptedtxt);
            if (preview_grid.DataSource != null)
            {
                for (int j = 0; j < preview_grid.ColumnCount; j++)
                {
                    if (preview_grid.Columns[j].HeaderCell.Value.ToString().Substring(0, 2).ToUpper() == "V_")
                    {
                        preview_grid.Columns[j].HeaderText = preview_grid.Columns[j].HeaderCell.Value.ToString().Substring(2);//去掉前缀"v_"
                    }
                    for (int i = 0; i < numarr.Length; i++)
                    {
                        if (j == numarr[i] - 1)
                        {
                            preview_grid.Columns[j].HeaderText = preview_grid.Columns[j].HeaderText + "(已加密)";
                            preview_grid.Columns[j].Width = 150;
                            preview_grid.Columns[j].HeaderCell.Style.ForeColor = Color.Red;
                        }
                    }
                    for (int i = 0; i < txtarr.Length; i++)
                    {
                        if (j == txtarr[i] - 1)
                        {
                            preview_grid.Columns[j].HeaderText = preview_grid.Columns[j].HeaderText + "(已脱敏)";
                            preview_grid.Columns[j].Width = 150;
                            preview_grid.Columns[j].HeaderCell.Style.ForeColor = Color.Red;
                        }
                    }
                    for (var i = 0; i < preview_grid.RowCount; i++)
                    {
                        string value = preview_grid.Rows[i].Cells[j].Value.ToString().Trim();
                        if (value.Length > 4)
                        {
                            string str = value.Substring(3, value.Length - 4);
                            string temp = "";
                            for (int k = 0; k < str.Length; k++)
                            {
                                temp += "*";
                            }
                            value = value.Replace(str, temp);
                            preview_grid.Rows[i].Cells[j].Value = value;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 是否显示控件
        /// </summary>
        /// <param name="progress">进度条</param>
        /// <param name="lbprogress">提示框</param>
        /// <param name="txtbrowser">路径框</param>
        /// <param name="btnbrowser">浏览按钮</param>
        /// <param name="btnlocation">定位按钮</param>
        private void setProgressbar(bool progress, bool lbprogress, bool txtbrowser, bool btnbrowser, bool btnlocation)
        {
            txt_path.Visible = txtbrowser;
            btn_browser.Visible = btnbrowser;
            progressbar.Visible = progress;
            lb_progress.Visible = lbprogress;
            btn_location.Visible = btnlocation;
        }

        /// <summary>
        /// 去除表头 "V_"
        /// </summary>
        private string modifyTitle(DataTable table)
        {
            string title = string.Empty;
            //int[] numarr = getEncryptColumns(ExportForm.encryptednum);
            for (int i = 0; i < table.Columns.Count; i++)
            {
                if (table.Columns[i].ColumnName.Substring(0, 2).ToUpper() == "V_")
                {
                    table.Columns[i].ColumnName = table.Columns[i].ColumnName.Substring(2);
                }
                title += table.Columns[i].ColumnName + txt_delimiter.Text;
            }
            return title;
        }
        /// <summary>
        /// 导出TXT
        /// </summary>
        /// <param name="table">表</param>
        private void ExportToTxt(DataTable table)
        {
            if (ExportForm.currentapplyid.Length == 30)
            {
                setProgressbar(true, true, false, false, true);

                string filename = string.Format("{0}.txt", ExportForm.currentapplyid.Substring(0, ExportForm.currentapplyid.Length - 6));
                filepath = string.Format("{0}\\{1}", txt_path.Text, filename);
                FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(new BufferedStream(fs), Encoding.Default);
                int[] numarr = getEncryptColumns(ExportForm.encryptednum);
                int[] txtarr = getEncryptColumns(ExportForm.encryptedtxt);
                string title = modifyTitle(table);

                sw.WriteLine(title);

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    string line = string.Empty;
                    for (int j = 0; j < table.Columns.Count; j++)
                    {
                        string value = table.Rows[i][j].ToString().Trim();
                        for (int c = 0; c < numarr.Length; c++)
                        {
                            if (j == numarr[c] - 1)
                                value = SqlHelper.AesEncrypt(value, ExportForm.currentapplyid + "00");
                        }
                        for (int c = 0; c < txtarr.Length; c++)
                        {
                            if (j == txtarr[c] - 1)
                                value = RegexHelper.allReplaceValue(value);
                        }

                        line += value + txt_delimiter.Text;
                    }
                    line = line.Substring(0, line.Length - txt_delimiter.Text.Length);
                    sw.WriteLine(line);
                    if (table.Rows.Count > 100000)
                    {
                        if (i + 1 == table.Rows.Count)
                        {
                            lb_progress.Text = "导出成功，文件名为:" + filename;
                            progressbar.Visible = false;
                        }
                    }
                    else
                    {
                        setProgress((i + 1), table.Rows.Count, filename);
                    }
                }
                sw.Close();
                fs.Close();
            }
            //else
            //{
            //    MessageBox.Show("申请号不正确，不能导出", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //}
        }
        /// <summary>
        /// 导出Excel(文件流，快）
        /// </summary>
        /// <param name="table">表</param>
        private void ExportToExcel(DataTable table)
        {
            if (ExportForm.currentapplyid.Length == 30)
            {
                setProgressbar(true, true, false, false, true);
                string guid = Guid.NewGuid().ToString();
                guid = guid.Substring(guid.Length - 6).ToUpper();

                string filename = string.Format("{0}{1}.xls", ExportForm.currentapplyid.Substring(0, ExportForm.currentapplyid.Length - 6), guid);
                filepath = string.Format("{0}\\{1}", txt_path.Text, filename);
                //string[] filenames = txt_path.Text.Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);
                //string filename = filenames[filenames.Length - 1];
                int[] numarr = getEncryptColumns(ExportForm.encryptednum);
                int[] txtarr = getEncryptColumns(ExportForm.encryptedtxt);
                try
                {
                    StreamWriter sw = new StreamWriter(filepath, false, Encoding.GetEncoding("gb2312"));

                    StringBuilder sb = new StringBuilder();
                    for (int k = 0; k < table.Columns.Count; k++)
                    {
                        sb.Append(table.Columns[k].ColumnName.ToString().Substring(2) + "\t");
                    }
                    sb.Append(Environment.NewLine);

                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        for (int j = 0; j < table.Columns.Count; j++)
                        {
                            string value = table.Rows[i][j].ToString().Trim();
                            for (int c = 0; c < numarr.Length; c++)
                            {
                                if (j == numarr[c] - 1)
                                    value = SqlHelper.AesEncrypt(value, ExportForm.currentapplyid + "00");
                            }
                            for (int c = 0; c < txtarr.Length; c++)
                            {
                                if (j == txtarr[c] - 1) value = RegexHelper.allReplaceValue(value);

                            }
                            sb.Append(value + "\t");
                        }
                        sb.Append(Environment.NewLine);
                        if (table.Rows.Count > 100000)
                        {
                            if (i + 1 == table.Rows.Count)
                            {
                                lb_progress.Text = "导出成功，文件名为:" + filename;
                                progressbar.Visible = false;
                            }
                        }
                        else
                        {
                            setProgress((i + 1), table.Rows.Count, filename);
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
        ///// <summary>
        ///// 导出Excel （正常，慢）
        ///// </summary>
        ///// <param name="table">表</param>
        //private void ExportToExcel(DataTable table)
        //{
        //    if (ExportForm.currentapplyid.Length == 30)
        //    {
        //        setProgressbar(true, true, false, false, true);
        //        string guid = Guid.NewGuid().ToString();
        //        guid = guid.Substring(guid.Length - 6).ToUpper();

        //        string filename = string.Format("{0}{1}.xlsx", ExportForm.currentapplyid.Substring(0, ExportForm.currentapplyid.Length - 6), guid);
        //        filepath = string.Format("{0}\\{1}", txt_path.Text, filename);
        //        FileInfo file = new FileInfo(filepath);
        //        int[] numarr = getEncryptColumns(ExportForm.encryptednum);
        //        using (ExcelPackage package = new ExcelPackage(file))
        //        {
        //            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add(ExportForm.currentapplyid);

        //            for (int i = 0; i < table.Columns.Count; i++)
        //            {
        //                if (table.Columns[i].ColumnName.Substring(0, 2).ToUpper() == "V_")
        //                {
        //                    table.Columns[i].ColumnName = table.Columns[i].ColumnName.Substring(2);
        //                }
        //                worksheet.Cells[1, i + 1].Value = table.Columns[i].ColumnName;
        //            }

        //            for (int i = 0; i < table.Rows.Count; i++)
        //            {
        //                for (int j = 0; j < table.Columns.Count; j++)
        //                {
        //                    string value = table.Rows[i][j].ToString().Trim();
        //                    for (int c = 0; c < numarr.Length; c++)
        //                    {
        //                        if (j == numarr[c] - 1)
        //                            value = SqlHelper.AesEncrypt(value, ExportForm.currentapplyid + "00");
        //                    }
        //                    worksheet.Cells[i + 2, j + 1].Value = value;
        //                }
        //                setProgress((i + 1), table.Rows.Count, filename);
        //            }

        //            package.Workbook.Properties.Title = "Data Download From SAS";
        //            package.Workbook.Properties.Author = "GMCC";
        //            package.Workbook.Properties.Comments = "This data downloaded from SAS platform.";
        //            package.Workbook.Properties.Company = "Brilliant Data Analytics Inc.";

        //            package.Save();
        //        }
        //    }
        //}
        ///// <summary>
        ///// 导出TXT
        ///// </summary>
        ///// <param name="table">表</param>
        //private void ExportToTxt(DataTable table)
        //{
        //    if (ExportForm.currentapplyid.Length == 30)
        //    {
        //        setProgressbar(true, true, false, false, true);

        //        string filename = string.Format("{0}.txt", ExportForm.currentapplyid.Substring(0, ExportForm.currentapplyid.Length - 6));
        //        filepath = string.Format("{0}\\{1}", txt_path.Text, filename);
        //        FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate);
        //        StreamWriter sw = new StreamWriter(new BufferedStream(fs), Encoding.Default);
        //        //string title = string.Empty;
        //        //int[] numarr = getEncryptColumns(ExportForm.encryptednum);
        //        //for (int i = 0; i < table.Columns.Count; i++)
        //        //{
        //        //    if (table.Columns[i].ColumnName.Substring(0, 2).ToUpper() == "V_")
        //        //    {
        //        //        table.Columns[i].ColumnName = table.Columns[i].ColumnName.Substring(2);
        //        //    }
        //        //    title += table.Columns[i].ColumnName + txt_delimiter.Text;
        //        //}
        //        //title = title.Substring(0, title.Length - txt_delimiter.Text.Length);
        //        int[] numarr = getEncryptColumns(ExportForm.encryptednum);
        //        string title = modifyTitle(table);

        //        sw.WriteLine(title);

        //        for (int i = 0; i < table.Rows.Count; i++)
        //        {
        //            string line = string.Empty;
        //            for (int j = 0; j < table.Columns.Count; j++)
        //            {
        //                string value = table.Rows[i][j].ToString().Trim();
        //                if (numarr.Length > 0)
        //                {
        //                    for (int c = 0; c < numarr.Length; c++)
        //                    {
        //                        if (j == numarr[c] - 1)
        //                            value = SqlHelper.AesEncrypt(value, ExportForm.currentapplyid + "00");
        //                    }
        //                }
        //                line += value + txt_delimiter.Text;
        //            }
        //            line = line.Substring(0, line.Length - txt_delimiter.Text.Length);
        //            sw.WriteLine(line);
        //            if (table.Rows.Count > 100000)
        //            {
        //                if (i + 1 == table.Rows.Count)
        //                {
        //                    lb_progress.Text = "导出成功，文件名为:" + filename;
        //                    progressbar.Visible = false;
        //                }
        //            }
        //            else
        //            {
        //                setProgress((i + 1), table.Rows.Count, filename);
        //            }
        //        }
        //        sw.Close();
        //        fs.Close();
        //    }
        //    //else
        //    //{
        //    //    MessageBox.Show("申请号不正确，不能导出", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        //    //}
        //}
        ///// <summary>
        ///// 导出Excel(文件流，快）
        ///// </summary>
        ///// <param name="table">表</param>
        //private void ExportToExcel(DataTable table)
        //{
        //    if (ExportForm.currentapplyid.Length == 30)
        //    {
        //        setProgressbar(true, true, false, false, true);
        //        string guid = Guid.NewGuid().ToString();
        //        guid = guid.Substring(guid.Length - 6).ToUpper();

        //        string filename = string.Format("{0}{1}.xlsx", ExportForm.currentapplyid.Substring(0, ExportForm.currentapplyid.Length - 6), guid);
        //        filepath = string.Format("{0}\\{1}", txt_path.Text, filename);
        //        int[] numarr = getEncryptColumns(ExportForm.encryptednum);
        //        try
        //        {
        //            StreamWriter sw = new StreamWriter(filepath, false, Encoding.GetEncoding("gb2312"));

        //            StringBuilder sb = new StringBuilder();
        //            for (int k = 0; k < table.Columns.Count; k++)
        //            {
        //                sb.Append(table.Columns[k].ColumnName.ToString().Substring(2) + "\t");
        //            }
        //            sb.Append(Environment.NewLine);

        //            for (int i = 0; i < table.Rows.Count; i++)
        //            {
        //                for (int j = 0; j < table.Columns.Count; j++)
        //                {
        //                    string value = table.Rows[i][j].ToString().Trim();
        //                    if (numarr.Length > 0)
        //                    {
        //                        for (int c = 0; c < numarr.Length; c++)
        //                        {
        //                            if (j == numarr[c] - 1)
        //                                value = SqlHelper.AesEncrypt(value, ExportForm.currentapplyid + "00");
        //                        }
        //                    }
        //                    sb.Append(value + "\t");
        //                }
        //                sb.Append(Environment.NewLine);
        //                if (table.Rows.Count > 100000)
        //                {
        //                    if (i + 1 == table.Rows.Count)
        //                    {
        //                        lb_progress.Text = "导出成功，文件名为:" + filename;
        //                        progressbar.Visible = false;
        //                    }
        //                }
        //                else {
        //                    setProgress((i + 1), table.Rows.Count, filename);
        //                }

        //            }

        //            sw.Write(sb.ToString());
        //            sw.Flush();
        //            sw.Close();
        //            sw.Dispose();
        //        }
        //        catch (Exception)
        //        {
        //            MessageBox.Show("导出失败！请重试");
        //        }
        //    }
        //}
        /// <summary>
        /// 设置进度条
        /// </summary>
        /// <param name="rownum">当前条数</param>
        /// <param name="count">全部条数</param>
        /// <param name="filename">文件名</param>
        private void setProgress(int rownum, int count, string filename)
        {
            lb_progress.Text = String.Format("{0}/{1}", rownum, count);
            progressbar.Value = Convert.ToInt32(rownum * 100 / count);
            if (rownum == count)
            {
                lb_progress.Text = "导出成功，文件名为:" + filename;
            }
        }

        private void ExportDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (progressbar.Value < 100 && progressbar.Value > 0)
            {
                MessageBox.Show("正在导出数据，请稍等！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Cancel = true;
            }
            else
            {
                table.Clear();
            }
        }

        
        /// <summary>
        /// 浏览文件夹
        /// </summary>
        private void btnbrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = "选择导出文件存放目录";
            if (folder.ShowDialog() == DialogResult.OK)
            {
                txt_path.Text = folder.SelectedPath;
            }
            //if (rbtn_txt.Checked)
            //{
            //    FolderBrowserDialog folder = new FolderBrowserDialog();
            //    folder.Description = "选择导出文件存放目录";
            //    if (folder.ShowDialog() == DialogResult.OK)
            //    {
            //        txt_path.Text = folder.SelectedPath;
            //    }
            //}
            //else
            //{
            //    OpenFileDialog openFileDialog = new OpenFileDialog();
            //    openFileDialog.Title = "请选择保存数据的Excel文件";
            //    openFileDialog.Filter = "Excel文件|*.xlsx|Excel文件|*.xls";
            //    openFileDialog.RestoreDirectory = true;
            //    openFileDialog.FilterIndex = 1;
            //    if (openFileDialog.ShowDialog() == DialogResult.OK)
            //    {
            //        txt_path.Text = openFileDialog.FileName;
            //    }
            //}
            
        }

        /// <summary>
        /// 导出
        /// </summary>
        private void btnexport_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_path.Text))
            {
                MessageBox.Show("请选择导出文件路径！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(txt_delimiter.Text) && rbtn_txt.Checked)
            {
                MessageBox.Show("请选择或输出文件分隔符！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                table = ExportFileView.getAllData(ExportForm.currentapplyid);
                if (table.Rows.Count > 100000)
                {
                    progressbar.Visible = false;
                    lb_progress.Text = "数据量大，请稍等！";
                }
                if (rbtn_txt.Checked)
                    ExportToTxt(table);
                else
                    ExportToExcel(table);

                group_delimiter.Enabled = false;
                group_filetype.Enabled = false;
                btn_browser.Enabled = false;
                btn_export.Enabled = false;
            }
        }

        /// <summary>
        /// 分隔符下拉框改变时
        /// </summary>
        private void cbdelimiter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_delimiter.ReadOnly = true;
            txt_delimiter.Text = cb_delimiter.SelectedValue.ToString();
            if (cb_delimiter.SelectedIndex == 3)
            {
                txt_delimiter.ReadOnly = false;
                txt_delimiter.Text = String.Empty;
            }
        }

        /// <summary>
        /// 导出文件类型改变时
        /// </summary>
        private void rbtntxt_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_txt.Checked) 
                group_delimiter.Enabled = true;
            else
                group_delimiter.Enabled = false;
            //txt_path.Text = "";
        }

        /// <summary>
        /// 定位文件
        /// </summary>
        private void btnlocation_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("Explorer.exe");
            psi.Arguments = "/e,/select," + filepath;
            System.Diagnostics.Process.Start(psi);
        }
    }
}
