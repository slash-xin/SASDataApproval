using System;
using System.Data;

namespace ExportApproval.Model
{
    public class ExportFileView
    {
        /// <summary>
        /// 根据表ID获取数据预览
        /// </summary>
        /// <param name="account">账号</param>
        /// <param name="pwd">密码</param>
        /// <returns></returns>
        public static DataTable getPreviewData(string tablename)
        {
            string sql = string.Format("select * from {0}  where rownum <=10", tablename);
            return SqlHelper.ExecuteDataTable(sql);
        }
        /// <summary>
        /// 判断预览表是否存在
        /// </summary>
        /// <param name="tablename">表名</param>
        /// <returns></returns>
        public static bool IsTableExist(string tablename)
        {
            string sql = string.Format("select count(*) from user_tables where table_name = '{0}'", tablename.ToUpper());
            return Convert.ToInt32(SqlHelper.ExecuteScalar(sql)) > 0;
        }

    }
}
