using System;
using System.Collections.Generic;
using System.Data;

namespace ExportSASData.Model
{
    public class UserInfo
    {
        public string UserId { get; set; }
        public string UserType { get; set; }
        public string UserAccount { get; set; }
        public string UserPassword { get; set; }
        public string UserName { get; set; }
        public string UserPhone { get; set; }
        public string UserRegion { get; set; }
        public string UserDepartment { get; set; }
        public string SystemId { get; set; }
        

        private static string usertable = "BDAIOM_USERINFO";

        /// <summary>
        /// 查询用户是否存在
        /// </summary>
        /// <param name="account">账号(现使用手机号码登陆)</param>
        /// <param name="pwd">密码</param>
        /// <param name="type">用户类别</param>
        /// <returns></returns>
        public static bool IsUserExist(string account, string pwd, string type)
        {
            //string sql = string.Format("select count(*) from " + usertable + " where user_account='{0}' and user_password='{1}' and user_type in ({2})", account, pwd, type);
            string sql = string.Format("select count(*) from " + usertable + " where user_phone='{0}' and user_password='{1}' and user_type in ({2})", account, pwd, type);
            return Convert.ToInt32(SqlHelper.ExecuteScalar(sql)) > 0;
        }

        /// <summary>
        /// 根据ID获取用户信息
        /// </summary>
        /// <param name="ID">ID</param>
        /// <returns></returns>
        public static UserInfo getUserInfo(string ID)
        {
            string sql = string.Format("select count(*) from " + usertable + " where user_id='{0}'", ID);
            DataSet ds = SqlHelper.ExecuteDataSet(sql);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                UserInfo model = new UserInfo();
                model.UserId = ds.Tables[0].Rows[0]["user_id"].ToString();
                model.UserType = ds.Tables[0].Rows[0]["user_type"].ToString();
                model.UserAccount = ds.Tables[0].Rows[0]["user_account"].ToString();
                model.UserPassword = ds.Tables[0].Rows[0]["user_password"].ToString();
                model.UserName = ds.Tables[0].Rows[0]["user_name"].ToString();
                model.UserPhone = ds.Tables[0].Rows[0]["user_phone"].ToString();
                model.UserRegion = ds.Tables[0].Rows[0]["user_region"].ToString();
                model.UserDepartment = ds.Tables[0].Rows[0]["user_department"].ToString();
                return model;
            }
            return null;
        }

        /// <summary>
        /// 根据account获取用户信息
        /// </summary>
        /// <param name="account">账号</param>
        /// <returns></returns>
        public static UserInfo getUserInfoByAccount(string account)
        {
            string sql = string.Format("select * from " + usertable + " where user_account='{0}'", account);
            DataSet ds = SqlHelper.ExecuteDataSet(sql);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                UserInfo model = new UserInfo();
                model.UserId = ds.Tables[0].Rows[0]["user_id"].ToString();
                model.UserType = ds.Tables[0].Rows[0]["user_type"].ToString();
                model.UserAccount = ds.Tables[0].Rows[0]["user_account"].ToString();
                model.UserPassword = ds.Tables[0].Rows[0]["user_password"].ToString();
                model.UserName = ds.Tables[0].Rows[0]["user_name"].ToString();
                model.UserPhone = ds.Tables[0].Rows[0]["user_phone"].ToString();
                model.UserRegion = ds.Tables[0].Rows[0]["user_region"].ToString();
                model.UserDepartment = ds.Tables[0].Rows[0]["user_department"].ToString();
                return model;
            }
            return null;
        }
        /// <summary>
        /// phone
        /// </summary>
        /// <param name="phone">手机号码</param>
        /// <returns></returns>
        public static UserInfo getUserInfoByPhone(string phone)
        {
            string sql = string.Format("select * from " + usertable + " where user_phone='{0}'", phone);
            DataSet ds = SqlHelper.ExecuteDataSet(sql);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                UserInfo model = new UserInfo();
                model.UserId = ds.Tables[0].Rows[0]["user_id"].ToString();
                model.UserType = ds.Tables[0].Rows[0]["user_type"].ToString();
                model.UserAccount = ds.Tables[0].Rows[0]["user_account"].ToString();
                model.UserPassword = ds.Tables[0].Rows[0]["user_password"].ToString();
                model.UserName = ds.Tables[0].Rows[0]["user_name"].ToString();
                model.UserPhone = ds.Tables[0].Rows[0]["user_phone"].ToString();
                model.UserRegion = ds.Tables[0].Rows[0]["user_region"].ToString();
                model.UserDepartment = ds.Tables[0].Rows[0]["user_department"].ToString();
                return model;
            }
            return null;
        }

        /// <summary>
        /// 获取所有申请人ID
        /// </summary>
        /// <returns>List<string></returns>
        public static List<string> getAllApplyUserId()
        {
            string sql = string.Format("select user_id from {0} where user_type = '0'", usertable);
            DataSet ds = SqlHelper.ExecuteDataSet(sql);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                List<string> applyUserIdList = new List<string>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    applyUserIdList.Add(dr["user_id"].ToString());
                }
                return applyUserIdList;
            }
            return null;
        }

        /// <summary>
        /// 更新密码
        /// </summary>
        /// <param name="ID">ID</param>
        /// <param name="pwd">密码</param>
        /// <returns></returns>
        public static int updateUserPwd(string ID, string pwd)
        {
            string sql = string.Format("update {0} set user_password = '{1}'  where  user_id = '{2}'",
               usertable, pwd, ID);
            return SqlHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// phone
        /// </summary>
        /// <param name="SystemId">系统用户</param>
        /// <returns></returns>
        public static UserInfo getUserInfoBySyatemId(string SystemId)
        {
            //string sql = string.Format("select * from " + usertable + " where user_account='{0}'", account);
            string sql = string.Format("select * from {0} where system_id='{1}'", usertable, SystemId);
            DataSet ds = SqlHelper.ExecuteDataSet(sql);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                UserInfo model = new UserInfo();
                model.UserId = ds.Tables[0].Rows[0]["user_id"].ToString();
                model.UserType = ds.Tables[0].Rows[0]["user_type"].ToString();
                model.UserAccount = ds.Tables[0].Rows[0]["user_account"].ToString();
                model.UserPassword = ds.Tables[0].Rows[0]["user_password"].ToString();
                model.UserName = ds.Tables[0].Rows[0]["user_name"].ToString();
                model.UserPhone = ds.Tables[0].Rows[0]["user_phone"].ToString();
                model.UserRegion = ds.Tables[0].Rows[0]["user_region"].ToString();
                model.UserDepartment = ds.Tables[0].Rows[0]["user_department"].ToString();
                model.SystemId = ds.Tables[0].Rows[0]["system_id"].ToString();
                return model;
            }
            return null;
        }
    }
}
