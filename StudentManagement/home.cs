using System.Windows.Forms;

namespace StudentManagement {
    public partial class Home : BaseForm {
        public static string userName;
        public Home() {
        InitializeComponent();
        }
        public Home(string userName) {
        InitializeComponent();
        }
        /// <summary>
        /// 学生管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, System.EventArgs e) {
        Student student = new Student();
        student.Show();
        }
    }
}
