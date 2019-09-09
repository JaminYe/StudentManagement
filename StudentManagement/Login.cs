using System;
using System.Windows.Forms;

namespace StudentManagement {
    public partial class Login : BaseForm {


        BLL.StudentService studentService = new BLL.StudentService();
        public Login() {
        InitializeComponent();
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton_Click(object sender, EventArgs e) {
        if (string.IsNullOrEmpty(this.userNameText.Text.Trim())) {
        MessageBox.Show("用户名不得为空");
        } else if (string.IsNullOrEmpty(this.pwdText.Text.Trim())) {
        MessageBox.Show("密码不得为空");
        } else {
        int? flag = studentService.StudentLogin(userNameText.Text.Trim(), pwdText.Text.Trim());
        if (flag != null && flag != 0) {
        this.DialogResult = DialogResult.OK;
        Home.userName = userNameText.Text.Trim();
        this.Close();

      /*  Home home = new Home(userNameText.Text.Trim());
        this.Hide();
        home.Show();*/
        } else {
        MessageBox.Show("登录名或密码错误");
        this.pwdText.Clear();
        }
        }


        }
        private void PwdText_KeyDown(object sender, KeyEventArgs e) {
        if (e.KeyCode == Keys.Enter) {
        this.loginButton.Focus();
        this.LoginButton_Click(sender, e);
        }
        }

        private void UserNameText_KeyDown(object sender, KeyEventArgs e) {
        if (e.KeyCode == Keys.Enter) {
        this.pwdText.Focus();
        }
        }
    }
}
