namespace BLL {
    public class StudentService {
        DAL.StudentDao studentDao = new DAL.StudentDao();
        public int? StudentLogin(string userName, string password) {
            return studentDao.StudentLogin(userName, password);
        }
    }
}
