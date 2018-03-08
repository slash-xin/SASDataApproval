using System.Collections.Generic;
using System.Data;

namespace ExportApproval.Model
{
    public class UserRelation
    {
        public string applyUserId { get; set; }
        public string fapprovalUserId { get; set; }

        private static string frelationtable = "BDAIOM_FAPPROVAL_RELATION";

        /// <summary>
        /// 根据一级审批人ID获取申请人ID
        /// </summary>
        /// <param name="ID">一级审批人ID</param>
        /// <returns></returns>
        public static List<string> getApplicantByFapprover(string ID)
        {
            string sql = string.Format("select apply_user_id from {0} where fapproval_user_id = '{1}'", frelationtable, ID);
            DataSet ds = SqlHelper.ExecuteDataSet(sql);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                List<string> applyUserIdList = new List<string>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    applyUserIdList.Add(dr["apply_user_id"].ToString());
                }
                return applyUserIdList;
            }
            return null;
        }
        /// <summary>
        /// 根据id删除用户关联信息(数据管理)
        /// </summary>
        /// <returns></returns>
        public static int deleteUserFrelationInfo(string id)
        {
            string sql = string.Format("delete from {0} where  apply_user_id = '{1}'", frelationtable, id);
            return SqlHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 添加UserRelation(数据管理)
        /// </summary>
        /// <returns></returns>
        public static int addUserRelation(UserRelation user)
        {
            string sql = string.Format("insert into {0} (apply_user_id, fapproval_user_id) values('{1}','{2}')",
               frelationtable, user.applyUserId, user.fapprovalUserId);
            return SqlHelper.ExecuteNonQuery(sql);
        }
    }
}
