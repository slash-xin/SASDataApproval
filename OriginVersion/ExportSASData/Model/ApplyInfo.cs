using System;
using System.Data;

namespace ExportSASData.Model
{
    public class ApplyInfo
    {
        public string applyId { get; set; }
        public string applySource { get; set; }
        public string applyUserId { get; set; }
        public string applyDate { get; set; }
        public string applyYearMonth { get; set; }
        public string applyStatus { get; set; }
        public string dataObs { get; set; }
        public string dataSize { get; set; }
        public string applyReason { get; set; }
        public string rejectReason { get; set; }
        public string applyType { get; set; }
        public string lastApprovalUserId { get; set; }
        public string lastApprovalDate { get; set; }

        private static string applytable = "BDAIOM_APPLY";
        private static string usertable = "BDAIOM_USERINFO";

        /// <summary>
        /// 根据申请人ID获取申请信息
        /// </summary>
        /// <param name="ID">申请人ID</param>
        /// <returns>ApplyInfo</returns>
        public static ApplyInfo getApplyInfo(string ID)
        {
            string sql = string.Format("select * from {0} where apply_id ='{1}' ", applytable, ID);
            DataSet ds = SqlHelper.ExecuteDataSet(sql);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                ApplyInfo model = new ApplyInfo();
                model.applyId = ds.Tables[0].Rows[0]["apply_id"].ToString();
                model.applySource = ds.Tables[0].Rows[0]["apply_source"].ToString();
                model.applyUserId = ds.Tables[0].Rows[0]["apply_user_id"].ToString();
                model.applyDate = ds.Tables[0].Rows[0]["apply_date"].ToString();
                model.applyYearMonth = ds.Tables[0].Rows[0]["apply_date_month"].ToString();
                model.applyStatus = ds.Tables[0].Rows[0]["apply_status"].ToString();
                model.dataObs = ds.Tables[0].Rows[0]["data_obs"].ToString();
                model.dataSize = ds.Tables[0].Rows[0]["data_size"].ToString();
                model.applyReason = ds.Tables[0].Rows[0]["apply_reason"].ToString();
                model.rejectReason = ds.Tables[0].Rows[0]["reject_reason"].ToString();
                model.applyType = ds.Tables[0].Rows[0]["apply_type"].ToString();
                model.lastApprovalUserId = ds.Tables[0].Rows[0]["last_approval_user"].ToString();
                model.lastApprovalDate = ds.Tables[0].Rows[0]["last_approval_date"].ToString();
                return model;
            }
            return null;
        }

        /// <summary>
        /// 根据申请人ID获取申请信息
        /// </summary>
        /// <param name="ID">申请人ID</param>
        /// <returns>DataTable</returns>
        public static DataTable getApplyInfoDT(string ID)
        {

            //string sql = @"select apply_id,apply_user_id,user_name, apply_source,apply_status,apply_type,
            //        data_obs,data_size,apply_date,apply_reason,reject_reason,apply_date_month,last_approval_user,last_approval_date from BDAIOM_USERINFO ," + applytable;
            //string where = @" where apply_user_id in ('" + ID + "') and apply_user_id = user_id ";

            //sql += where;
            string sql = string.Format(@"select a.user_name,a.user_region,a.user_department, a.apply_id ,a.apply_source , 
               a.apply_user_id ,a.apply_status ,b.user_name fapprover_user_name, c.user_name  sapprover_user_name,
               CASE a.apply_type  WHEN '1' THEN '汇总数据审批' ELSE '明细数据审批' END   apply_type  , a.data_obs , a.data_size , a.apply_reason , a.reject_reason ,
               a.last_approval_user , a.last_approval_date , a.apply_date_month , a.apply_date , a.fapproval_user_id,a.encrypted_num,a.encrypted_txt from
               (select Nvl(user_name,apply_user_id) user_name,user_region,user_department,a.*
               from {0} a , {1} where apply_user_id = user_id and apply_user_id in ('{2}')) a ", applytable, usertable, ID);
            string leftjoin = @" left join BDAIOM_USERINFO b on a.fapproval_user_id = b.user_id left join  BDAIOM_USERINFO c on a.last_approval_user = c.user_id order by  a.apply_date desc ";

            sql += leftjoin;
            return SqlHelper.ExecuteDataTable(sql);
        }

        /// <summary>
        /// 根据申请ID更新申请信息
        /// </summary>
        /// <param name="apply">ApplyInfo</param>
        /// <returns></returns>
        public static int updateApplyInfo(ApplyInfo apply)
        {
            string sql = string.Format("update {0} set apply_status = '{1}',reject_reason='{2}',last_approval_user='{3}',last_approval_date='{4}' where  apply_id = '{5}'",
               applytable, apply.applyStatus, apply.rejectReason, apply.lastApprovalUserId, apply.lastApprovalDate, apply.applyId);
            return SqlHelper.ExecuteNonQuery(sql);
        }
    }
}
