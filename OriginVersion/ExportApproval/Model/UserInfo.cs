using System;
using System.Collections.Generic;
using System.Data;

namespace ExportApproval.Model
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
        /// 根据系统ID查询用户是否存在
        /// </summary>
        /// <param name="systemId">系统ID</param>
        /// <returns></returns>
        public static bool IsUserExist(string systemId)
        {
            string sql = string.Format("select count(*) from {0} where system_id='{1}'", usertable, systemId);
            return Convert.ToInt32(SqlHelper.ExecuteScalar(sql)) > 0;
        }

        /// <summary>
        /// 根据用户ID查询用户是否存在
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <returns></returns>
        public static bool IsUserExistById(string userId)
        {
            string sql = string.Format("select count(*) from {0} where user_id='{1}'", usertable, userId);
            return Convert.ToInt32(SqlHelper.ExecuteScalar(sql)) > 0;
        }
        /// <summary>
        /// 查询用户是否存在
        /// </summary>
        /// <param name="account">账号(现使用手机号码登陆)</param>
        /// <param name="pwd">密码</param>
        /// <param name="type">用户类别</param>
        /// <returns></returns>
        public static bool IsUserExist(string account, string pwd, string type)
        {
           // string sql = string.Format("select count(*) from " + usertable + " where user_account='{0}' and user_password='{1}' and user_type in ({2})", account, pwd, type);
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
            //string sql = string.Format("select * from " + usertable + " where user_account='{0}'", account);
            string sql = string.Format("select * from " + usertable + " where user_phone='{0}'", account);
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

        /// <summary>
        /// phone
        /// </summary>
        /// <param name="phone">手机号码</param>
        /// <returns></returns>
        public static UserInfo getUserInfoByPhone(string phone)
        {
            //string sql = string.Format("select * from " + usertable + " where user_account='{0}'", account);
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
        /// 根据获取所有用户信息(数据管理)
        /// </summary>
        /// <returns>DataTable</returns>
        public static DataTable getAllUserInfo()
        {
            string sql = string.Format(@" select U.USER_ID ID, U.USER_ACCOUNT 账户, CASE U.USER_TYPE WHEN '0' THEN '申请人' WHEN '1' THEN '一级审批人'  ELSE '二级审批人' END 用户类型, 
              U.USER_NAME 用户名,U.USER_REGION 地区,U.USER_DEPARTMENT 部门,U.USER_PHONE 手机号码,  U.SYSTEM_ID 系统账号
              from {0} U ", usertable);
            return SqlHelper.ExecuteDataTable(sql);
        }
        /// <summary>
        /// 根据id删除用户信息(数据管理)
        /// </summary>
        /// <returns></returns>
        public static int deleteUserInfo(string id)
        {
            string sql = string.Format("delete from {0} where  user_id = '{1}'", usertable, id);
            return SqlHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 根据用户类别获取所有用户信息(数据管理)
        /// </summary>
        /// <returns>DataTable</returns>
        public static DataTable getUserInfoByType(string type)
        {
            string sql = string.Format(@" select * from {0} U where USER_TYPE = '{1}'", usertable, type);
            return SqlHelper.ExecuteDataTable(sql);
        }

        /// <summary>
        /// 更新UserInfo(数据管理)
        /// </summary>
        /// <returns></returns>
        public static int updateUserInfo(UserInfo user)
        {
            string sql = string.Format("update {0} set USER_TYPE = '{1}', USER_PASSWORD = '{2}', USER_NAME = '{3}', USER_PHONE = '{4}', USER_REGION = '{5}', USER_DEPARTMENT = '{6}', SYSTEM_ID = {7}  where  user_id = '{8}'",
               usertable, user.UserType, user.UserPassword, user.UserName, user.UserPhone, user.UserRegion, user.UserDepartment, user.SystemId, user.UserId);
            return SqlHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 添加UserInfo(数据管理)
        /// </summary>
        /// <returns></returns>
        public static int addUserInfo(UserInfo user)
        {
            string sql = string.Format("insert into {0} (USER_ID, USER_TYPE, USER_ACCOUNT, USER_PASSWORD, USER_NAME, USER_PHONE, USER_REGION, USER_DEPARTMENT, SYSTEM_ID) values('{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
               usertable, user.UserId, user.UserType, user.UserAccount, user.UserPassword, user.UserName, user.UserPhone, user.UserRegion, user.UserDepartment, user.SystemId);
            return SqlHelper.ExecuteNonQuery(sql);
        }
    }
}
