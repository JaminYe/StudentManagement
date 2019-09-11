using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace DAL {
    public class StudentDao {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        public int? StudentLogin(string userName,string password) {
            string sql = "select count(1) from  userinfo where userName=@userName and password=@password";
            MySqlParameter[] mySqlParameters = new MySqlParameter[] {
               new MySqlParameter("@userName",userName),
               new MySqlParameter("@password",password)
           };
            object o = SqlHelper.ExecuteScalar(sql,mySqlParameters);
            return Convert.ToInt32(o);
            }


        public DataTable GetList(string stringWhere) {
            DataTable dt = null;
            string sql = "select stuId as 学生id,stuName as 学生姓名,stuSex as 性别,stuNation as 学生民族,stuAdress as 家庭住址,stuTel  as 电话号码 from stuinfo";
            if(string.IsNullOrEmpty(stringWhere.Trim())) {
                dt = SqlHelper.DataTable(sql);
                }
            return dt;
            }
        /// <summary>
        /// 添加学生
        /// </summary>
        /// <param name="strings"></param>
        /// <returns></returns>
        public int? AddStudent(params string[] strings) {
            string sql = "insert into stuinfo(stuName,stuSex,stuNation,stuAdress,stuTel) values(@stuName,@stuSex,@stuNation,@stuAdress,@stuTel)";
            MySqlParameter[] mySqlParameters = new MySqlParameter[] {
                new MySqlParameter("@stuName",strings[0]),
                new MySqlParameter("@stuSex",strings[1]),
                new MySqlParameter("@stuNation",strings[2]),
                new MySqlParameter("@stuAdress",strings[3]),
                new MySqlParameter("@stuTel",strings[4]),
                };
            object o = SqlHelper.ExecuteNonQuery(sql,mySqlParameters);
            return Convert.ToInt32(o);
            }
        }
    }
