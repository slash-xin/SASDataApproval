using System;
using System.Data;

namespace ExportApproval.Model
{
    public class ApplyList
    {

        public string ListId { get; set; }
        public string insertUserId { get; set; }
        public string insertDate { get; set; }
        public string expirationDate { get; set; }
        
        private static string applylisttable = "BDAIOM_APPLY_LIST";

        /// <summary>
        /// 添加申请单
        /// </summary>
        /// <param name="list">ApplyList</param>
        /// <returns></returns>
        public static int addApplyListInfo(ApplyList list)
        {
            string sql = string.Format(@"insert into {0} (List_Id,insert_User_Id,insert_Date,expiration_Date)
                 values ('{1}','{2}','{3}','{4}')",
               applylisttable, list.ListId, list.insertUserId, list.insertDate, list.expirationDate);
            return SqlHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 更新申请单
        /// </summary>
        /// <param name="list">ApplyList</param>
        /// <returns></returns>
        public static int updateApplyListInfo(ApplyList list)
        {
            string sql = string.Format(@"update {0} set insert_User_Id='{1}',insert_Date='{2}',expiration_Date='{3}' where List_Id = '{4}'",
               applylisttable, list.insertUserId, list.insertDate, list.expirationDate, list.ListId);
            return SqlHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 查询申请单是否存在
        /// </summary>
        /// <param name="Id">Id</param>
        /// <returns></returns>
        public static bool IsApplyListExist(string Id)
        {
            string sql = string.Format("select count(*) from " + applylisttable + " where List_Id='{0}'", Id);
            return Convert.ToInt32(SqlHelper.ExecuteScalar(sql)) > 0;
        }

        /// <summary>
        /// 根据ID获取申请单
        /// </summary>
        /// <param name="ID">ID</param>
        /// <returns>ApplyInfo</returns>
        public static ApplyList getApplyListInfo(string Id)
        {
            string sql = string.Format("select * from {0} where list_id ='{1}' ", applylisttable, Id);
            DataSet ds = SqlHelper.ExecuteDataSet(sql);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                ApplyList model = new ApplyList();
                model.ListId = ds.Tables[0].Rows[0]["List_Id"].ToString();
                model.insertUserId = ds.Tables[0].Rows[0]["insert_User_Id"].ToString();
                model.insertDate = ds.Tables[0].Rows[0]["insert_Date"].ToString();
                model.expirationDate = ds.Tables[0].Rows[0]["expiration_Date"].ToString();
                return model;
            }
            return null;
        }
    }
}

