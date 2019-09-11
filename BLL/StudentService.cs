using System.Data;

namespace BLL {
    public class StudentService {
        DAL.StudentDao studentDao = new DAL.StudentDao();
        public int? StudentLogin(string userName,string password) {
            return studentDao.StudentLogin(userName,password);
            }
        /// <summary>
        /// 获取list
        /// </summary>
        /// <param name="whereString"></param>
        /// <returns></returns>
        public DataTable GetList(string whereString) {
            return studentDao.GetList(whereString);
            }
        /// <summary>
        /// 添加学生
        /// </summary>
        /// <param name="strings"> 学生信息数组</param>
        /// <returns></returns>
        public int? StudentAdd(params string[] strings) {
            return studentDao.AddStudent(strings);
            }

        }
    }
