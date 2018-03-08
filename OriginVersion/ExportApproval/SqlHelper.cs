using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Data;

namespace ExportApproval
{
    public static class SqlHelper
    {
        //数据库连接字符串  
        private readonly static string connstr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        /// <summary>
        /// 执行数据库非查询操作
        /// </summary>
        /// <param name="cmdType">命令类型(sql语句或者存储过程)</param>
        /// <param name="cmdText">要执行的sql语句或者存储过程名称</param>
        /// <param name="commandParameters">执行所需的一些参数</param>
        /// <returns>返回受影响的行数</returns>
        public static int ExecuteNonQuery(string cmdText)
        {
            OracleCommand cmd = new OracleCommand();
            using (OracleConnection connection = new OracleConnection(connstr))
            {
                PrepareCommand(cmd, connection, null, CommandType.Text, cmdText, null);
                int val = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return val;
            }
        }

        /// <summary>
        /// 执行语句返回的是单行单列的结果 
        /// </summary>
        /// <param name="commandType">命令类型（sql或者存储过程）</param>
        /// <param name="commandText">sql语句或者存储过程名称</param>
        /// <param name="commandParameters">命令所需参数数组</param>
        /// <returns>返回是第一行第一列的结果（object类型）请使用Covert.to进行类型转换</returns>
        public static object ExecuteScalar(string cmdText)
        {
            OracleCommand cmd = new OracleCommand();
            using (OracleConnection conn = new OracleConnection(connstr))
            {
                PrepareCommand(cmd, conn, null, CommandType.Text, cmdText, null);
                object val = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
                return val;
            }
        }



        /// <summary>
        /// 执行数据库查询操作,返回DataSet类型的结果集  
        /// </summary>
        /// <param name="commandText">sql语句或者存储过程名称</param>
        /// <param name="commandParameters">命令所需参数数组</param>
        /// <returns></returns>
        public static DataSet ExecuteDataSet(string cmdText)
        {
            OracleCommand cmd = new OracleCommand();
            using (OracleConnection conn = new OracleConnection(connstr))
            {
                PrepareCommand(cmd, conn, null, CommandType.Text, cmdText, null);
                OracleDataAdapter adapter = new OracleDataAdapter();
                adapter.SelectCommand = cmd;
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);
                cmd.Parameters.Clear();
                return dataset;
            }
        }

        /// <summary>  
        /// 执行数据库查询操作,返回DataTable类型的结果集  
        /// </summary>  
        /// <param name="cmdText">存储过程名称或SQL命令</param>  
        /// <param name="commandParameters">命令参数集合</param>  
        /// <returns>当前查询操作返回的DataTable类型的结果集</returns>  
        internal static DataTable ExecuteDataTable(string cmdText)
        {
            OracleCommand cmd = new OracleCommand();
            using (OracleConnection conn = new OracleConnection(connstr))
            {
                PrepareCommand(cmd, conn, null, CommandType.Text, cmdText, null);
                OracleDataAdapter adapter = new OracleDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable table = new DataTable();
                adapter.Fill(table);
                cmd.Parameters.Clear();
                return table;
            }
        }

        /// <summary>  
        /// 执行数据库命令前的准备工作  
        /// </summary>  
        /// <param name="command">Command对象</param>  
        /// <param name="connection">数据库连接对象</param>  
        /// <param name="trans">事务对象</param>  
        /// <param name="cmdType">Command类型</param>  
        /// <param name="cmdText">Oracle存储过程名称或PL/SQL命令</param>  
        /// <param name="commandParameters">命令参数集合</param>  
        private static void PrepareCommand(OracleCommand command, OracleConnection connection, OracleTransaction trans, CommandType cmdType, string cmdText, OracleParameter[] commandParameters)
        {
            if (connection.State != ConnectionState.Open) connection.Open();

            command.Connection = connection;
            command.CommandText = cmdText;
            command.CommandType = cmdType;

            if (trans != null) command.Transaction = trans;

            if (commandParameters != null)
            {
                foreach (OracleParameter parm in commandParameters)
                    command.Parameters.Add(parm);
            }
        }
    }
}
