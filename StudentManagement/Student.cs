using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace StudentManagement {
    public partial class Student:BaseForm {
        BLL.StudentService studentService = new BLL.StudentService();
        public Student() {
            InitializeComponent();
            }
        /// <summary>
        /// 初始化 数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Student_Load(object sender,EventArgs e) {
            GetList();
            }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender,EventArgs e) {
            new AddStu(this).Show();
            }

        public void FillData() {
            this.Controls.Clear();
            InitializeComponent();
            GetList();
            }

        public void GetList() {
            string stringWhere = "";
            dataGridView1.DataSource = studentService.GetList(stringWhere);
            }
        }
    }
