using System;
using System.Data;

namespace ExportApproval.Model
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
        public string ListID { get; set; }

        private static string usertable = "BDAIOM_USERINFO";
        private static string applytable = "BDAIOM_APPLY";

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
        /// <param name="usertype">用户类别</param>
        /// <returns></returns>
        public static DataTable getApplyInfoDT(string ID, string usertype, string fapproveruser)
        {
            string sql = string.Format(@"select a.user_name,a.user_region,a.user_department, a.apply_id ,a.apply_source , 
               a.apply_user_id ,a.apply_status ,a.list_id,b.user_name fapprover_user_name, c.user_name  sapprover_user_name,
               CASE a.apply_type  WHEN '1' THEN '汇总数据审批' ELSE '明细数据审批' END   apply_type  , a.data_obs , a.data_size , a.apply_reason , a.reject_reason ,
               a.last_approval_user , a.last_approval_date , a.apply_date_month , a.apply_date , a.fapproval_user_id,a.encrypted_num,a.encrypted_txt from
               (select Nvl(user_name,apply_user_id) user_name,user_region,user_department,a.*
               from {0} a left join {1} on apply_user_id = user_id) a ", applytable, usertable);
            string where = @" where apply_user_id in (" + ID + ")";
            string leftjoin = @" left join BDAIOM_USERINFO b on a.fapproval_user_id = b.user_id left join  BDAIOM_USERINFO c on a.last_approval_user = c.user_id  ";
        
            if ((ApprovalForm.UserType)Convert.ToInt32(usertype) == ApprovalForm.UserType.fapproval)
            {
                where += string.Format(" and apply_type in ('2') and  fapproval_user_id = '{0}' and (list_id is null or list_id='') ", fapproveruser);
            }
            sql += leftjoin + where + " order by a.apply_date desc";
            return SqlHelper.ExecuteDataTable(sql);
        }

        /// <summary>
        /// 根据获取所有申请信息（适用二级审批人）
        /// </summary>
        /// <returns></returns>
        public static DataTable getAllApplyInfoDT()
        {
            string sql = string.Format(@"select a.user_name,a.user_region,a.user_department, a.apply_id ,a.apply_source , 
               a.apply_user_id ,a.apply_status ,a.list_id ,b.user_name fapprover_user_name, c.user_name  sapprover_user_name,
               CASE a.apply_type  WHEN '1' THEN '汇总数据审批' ELSE '明细数据审批' END   apply_type, a.data_obs , a.data_size , a.apply_reason , a.reject_reason ,
               a.last_approval_user , a.last_approval_date , a.apply_date_month , a.apply_date , a.fapproval_user_id,a.encrypted_num,a.encrypted_txt from
               (select Nvl(user_name,apply_user_id) user_name,user_region,user_department,a.*
               from {0} a left join {1} on apply_user_id = user_id) a ", applytable, usertable);
            string leftjoin = @" left join BDAIOM_USERINFO b on a.fapproval_user_id = b.user_id left join  BDAIOM_USERINFO c on a.last_approval_user = c.user_id order by  a.apply_date desc";

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


        /// <summary>
        /// 根据获取所有申请信息(数据管理)
        /// </summary>
        /// <returns>DataTable</returns>
        public static DataTable getAllApplyInfo()
        {
            string sql = string.Format(@"SELECT A .apply_id 申请ID, A.apply_source 申请源,A.apply_user_id 申请人ID,A.user_name 申请人,A.user_region 地区,
                    A.user_department 部门,A.apply_status 审批状态,CASE A.apply_type WHEN '1' THEN '汇总数据审批' ELSE '明细数据审批' END 审批类别,
                    A.data_obs 行数,A.data_size 大小,A.apply_reason 申请理由,A.reject_reason 拒绝理由,A.apply_date_month 申请年月,
                    A.apply_date 申请日期,A.fapproval_user_id 一级审批人ID,b.user_name 一级审批人,c.user_name 二级审批人,
                    A.last_approval_user 最后审批人ID,A.last_approval_date 最后审批日期,A.list_id 单号,A.encrypted_num 号码加密列,A.encrypted_txt 文本脱敏列 from
               (select Nvl(user_name,apply_user_id) user_name,user_region,user_department,a.*
               from {0} a left join {1} on apply_user_id = user_id) a ", applytable, usertable);
            string leftjoin = @" left join BDAIOM_USERINFO b on a.fapproval_user_id = b.user_id left join  BDAIOM_USERINFO c on a.last_approval_user = c.user_id order by  a.apply_date desc";

            sql += leftjoin;
            return SqlHelper.ExecuteDataTable(sql);
        }
        /// <summary>
        /// 根据id删除申请信息(数据管理)
        /// </summary>
        /// <returns></returns>
        public static int deleteApplyInfo(string id)
        {
            string sql = string.Format("delete from {0} where  apply_id = '{1}'" ,applytable, id);
            return SqlHelper.ExecuteNonQuery(sql);
        }
    }
}
