using MySql.Data.MySqlClient;
using System;

namespace DAL {
    public class StudentDao {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        public int? StudentLogin(string userName, string password) {
            string sql = "select count(1) from  userinfo where userName=@userName and password=@password";
            MySqlParameter[] mySqlParameters = new MySqlParameter[] {
               new MySqlParameter("@userName",userName),
               new MySqlParameter("@password",password)
           };
            object o = SqlHelper.ExecuteScalar(sql, mySqlParameters);
            return Convert.ToInt32(o);
        }
    }
}
