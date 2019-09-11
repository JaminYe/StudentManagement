using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement {
    public partial class AddStu:BaseForm {

        BLL.StudentService studentService = new BLL.StudentService();
        private Student student;
        public AddStu(Student student) {
            this.student = student;
            InitializeComponent();
            toolTip1.ToolTipTitle = "提示";
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            }
        /// <summary>
        /// 姓名验证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox1_TextChanged(object sender,EventArgs e) {
            checkName();
            }
        /// <summary>
        /// 联系方式验证
        /// </summary>
        /// <param name="sender"></param>`
        /// <param name="e"></param>
        private void TextBox2_TextChanged(object sender,EventArgs e) {
            checkTel();
            }

        private void AddStu_Load(object sender,EventArgs e) {
            sexComboBox.SelectedIndex = 0;
            nationComboBox.SelectedIndex = 0;
            }

        /// <summary>
        /// 验证姓名
        /// </summary>
        /// <returns></returns>
        private bool checkName() {
            if(!string.IsNullOrEmpty(textBox1.Text.Trim()) && System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text,"^([a-zA-Z0-9\u4e00-\u9fa5]{1,10})$")) {
                return true;
                }
            else {
                toolTip1.Show("请输入正确的姓名",textBox1,3000);
                return false;
                }
            }
        /// <summary>
        /// 验证联系方式
        /// </summary>
        /// <returns></returns>
        private bool checkTel() {
            if(!string.IsNullOrEmpty(textBox2.Text.Trim()) && System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text,@"^(13[0-9]|14[5|7]|15[0|1|2|3|5|6|7|8|9]|18[0|1|2|3|5|6|7|8|9])\d{8}$")) {
                return true;
                }
            else {
                toolTip2.Show("请输入正确的手机号",textBox2,3000);

                return false;
                }
            }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender,EventArgs e) {
            if(checkName() && checkTel() && !string.IsNullOrEmpty(textBox3.Text.Trim())) {
                int? i = studentService.StudentAdd(textBox1.Text.Trim(),sexComboBox.SelectedItem.ToString(),nationComboBox.SelectedItem.ToString(),textBox3.Text.Trim(),textBox2.Text.Trim());
                if(i > 0 && i != null) {
                    MessageBox.Show("添加成功");
                    student.FillData();
                    this.Close();
                    }

                }

            }
        }
    }
