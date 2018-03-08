using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ExportApproval.Model
{
    public class ApprovalRecord
    {
        public string applyId { get; set; }
        public string applyUserId { get; set; }
        public string approvalContent { get; set; }
        public string approvalStatus { get; set; }
        public string approvalUserId { get; set; }
        public string ApprovalDate { get; set; }
        public string ApprovalUserType { get; set; }

        private static string approvalrecordtable = "BDAIOM_APPROVAL_HIS";
        private static string usertable = "BDAIOM_USERINFO";

        /// <summary>
        /// 根据申请ID插入审批记录
        /// </summary>
        /// <param name="approval">ApprovalRecord</param>
        /// <returns></returns>
        public static int addApprovalInfo(ApprovalRecord approval)
        {
            string sql = string.Format(@"insert into {0} (apply_id,apply_user_id,approval_user_id,approval_status,approval_content,approval_date,approval_user_type)
                 values ('{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
               approvalrecordtable, approval.applyId, approval.applyUserId, approval.approvalUserId, approval.approvalStatus, approval.approvalContent, approval.ApprovalDate, approval.ApprovalUserType);
            return SqlHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 根据获取所有审批记录信息(数据管理)
        /// </summary>
        /// <returns>DataTable</returns>
        public static DataTable getAllApprovalInfo()
        {
            string sql = string.Format(@" select h.APPLY_ID 申请ID ,h.APPROVAL_STATUS 审批状态, h.APPROVAL_CONTENT 拒绝理由, h.APPROVAL_DATE 审批日期, 
            CASE h.APPROVAL_USER_TYPE WHEN '1' THEN '上级' ELSE '管理员' END 审批人类型, CASE a.APPLY_TYPE  WHEN '1' THEN '汇总数据审批' ELSE '明细数据审批' END  申请类型 ,
            u.USER_NAME 申请人,u.USER_REGION 区域,u.USER_DEPARTMENT 部门,u.USER_PHONE 电话号码, u2.USER_NAME 审批人 
            from {0} h LEFT JOIN {1} u on u.USER_ID = h.APPLY_USER_ID ", approvalrecordtable, usertable);
            string leftjoin = @" LEFT JOIN BDAIOM_USERINFO u2 on u2.USER_ID = h.APPROVAL_USER_ID LEFT JOIN BDAIOM_APPLY a on a.APPLY_ID = h.APPLY_ID order by  H.APPROVAL_DATE desc ";

            sql += leftjoin;
            return SqlHelper.ExecuteDataTable(sql);
        }
        /// <summary>
        /// 根据id删除审批记录信息(数据管理)
        /// </summary>
        /// <returns></returns>
        public static int deleteApprovalInfo(string id)
        {
            string sql = string.Format("delete from {0} where  apply_id = '{1}'", approvalrecordtable, id);
            return SqlHelper.ExecuteNonQuery(sql);
        }
    }
}
