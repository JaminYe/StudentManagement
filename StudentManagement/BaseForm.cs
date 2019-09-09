using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudentManagement {
    public partial class BaseForm : Form {
        public BaseForm() {
        InitializeComponent();
        }
        #region 拖动事件
        protected int x, y;
        private void BaseForm_MouseDown(object sender, MouseEventArgs e) {
        this.x = e.X;
        this.y = e.Y;
        }
        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BaseForm_MouseMove(object sender, MouseEventArgs e) {
        if (e.Button == MouseButtons.Left) {
        int lengX = e.X - x;
        int lengY = e.Y - y;
        this.Left += lengX;
        this.Top += lengY;
        }
        }
        #endregion
        #region 关闭与最小化
        private void ClosePicture_MouseHover(object sender, EventArgs e) {
        this.closePicture.BackColor = Color.Red;
        }

        private void ClosePicture_MouseLeave(object sender, EventArgs e) {
        this.closePicture.BackColor = Color.Transparent;
        }
        private void PictureBox1_Click(object sender, EventArgs e) {
        Application.Exit();
        }

        private void minimizeBox_MouseHover(object sender, EventArgs e) {
        this.minimizeBox.Image = Image.FromFile(@"D:\Document\VisualStudio\StudentManagement\StudentManagement\Resources\minusBig.png");
        }
        private void minimizeBox_MouseLeave(object sender, EventArgs e) {
        this.minimizeBox.Image = Image.FromFile(@"D:\Document\VisualStudio\StudentManagement\StudentManagement\Resources\minusSmall.png");
        }

        private void minimizeBox_Click(object sender, EventArgs e) {
        this.WindowState = FormWindowState.Minimized;
        notifyIcon1.Visible = true;
        this.Hide();
        }
        #endregion

        #region 托盘右击菜单

        private void 打开主菜单ToolStripMenuItem_Click(object sender, EventArgs e) {
        this.Show();
        this.WindowState = FormWindowState.Normal;
        notifyIcon1.Visible = false;
        }

        private void 退出ToolStripMenuItem_Click_1(object sender, EventArgs e) {
        DialogResult result = MessageBox.Show("您确定要残忍的离开我吗", "退出", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (DialogResult.Yes == result) {
        this.Close();
        }
        }

        #endregion



    }
}