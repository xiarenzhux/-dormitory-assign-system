using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/************************************************************************
学生登陆进去的展示界面，只显示用户的信息以及修改密码功能，没有任何操作权限
*************************************************************************/
namespace dormitory_manage
{
    public partial class student : Form
    {
        string number;
        public student()
        {
            InitializeComponent();
        }
        public student(string number)
        {
            InitializeComponent();
            this.number = number;
        }

        private void student_Load(object sender, EventArgs e)//显示学生信息
        {
            string uname = string.Format("select rtrim(姓名) from 学生 where 学号='{0}'", this.number);//创建查询数据库的语句
            string name = (string)Sqlhelper.getScalar(uname);//接受用户输入的数据，判断是否正确
            textBox1.Text = number;
            textBox2.Text = name;
            label11.Text = name;
            label12.Text = number;

            string usex = string.Format("select 性别 from 学生 where 学号='{0}'", this.number);//创建查询数据库的语句
            string sex = (string)Sqlhelper.getScalar(usex);//接受用户输入的数据，判断是否正确
            textBox3.Text = sex;

            string umz = string.Format("select 民族 from 学生 where 学号='{0}'", this.number);//创建查询数据库的语句
            string mz = (string)Sqlhelper.getScalar(umz);//接受用户输入的数据，判断是否正确
            textBox4.Text = mz;

            string ugy = string.Format("select 公寓号 from 学生 where 学号='{0}'", this.number);//创建查询数据库的语句
            string gy = (string)Sqlhelper.getScalar(ugy);//接受用户输入的数据，判断是否正确
            textBox7.Text = gy;

            string uqs = string.Format("select 寝室号 from 学生 where 学号='{0}'", this.number);//创建查询数据库的语句
            string qs = (string)Sqlhelper.getScalar(uqs);//接受用户输入的数据，判断是否正确
            textBox6.Text = qs;

            string uzy = string.Format("select 专业名称 from 学生,专业 where 学生.专业编号=专业.专业编号 and  学号='{0}'", this.number);//创建查询数据库的语句
            string zy = (string)Sqlhelper.getScalar(uzy);//接受用户输入的数据，判断是否正确
            textBox9.Text = zy;

            string ubj = string.Format("select 班级名称 from 班级 where 班级编号= (select 班级编号 from 学生 where 学号='{0}')", this.number);//创建查询数据库的语句
            string bj = (string)Sqlhelper.getScalar(ubj);//接受用户输入的数据，判断是否正确
            textBox5.Text = bj;

            string ulx = string.Format("select 联系方式 from 学生 where 学号='{0}'", this.number);//创建查询数据库的语句
            string lx = (string)Sqlhelper.getScalar(ulx);//接受用户输入的数据，判断是否正确
            textBox8.Text = lx;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string newPassword = textBox10.Text;
            string confirmPassword = textBox11.Text;
            if (string.IsNullOrEmpty(textBox10.Text) || string.IsNullOrEmpty(textBox11.Text))
            {

                return;
            }

            // 验证新密码和确认密码
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("新密码和确认密码不匹配。请重试。");
                return;
            }

            // 更新数据库中的密码
            string updateSql = string.Format("update 学生 set 密码='{0}' where 学号='{1}'", newPassword, this.number);
            int rowsAffected = Sqlhelper.exexute(updateSql);
            if (rowsAffected > 0)
            {
                MessageBox.Show("密码修改成功。");
                textBox10.Visible = false;
                label1.Visible = false;
                textBox11.Visible = false;
                label13.Visible = false;
                button2.Visible = false;
            }
            else
            {
                MessageBox.Show("密码修改失败。");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox10.Visible = true;
            label1.Visible = true;
            textBox11.Visible = true;
            label13.Visible = true;
            button2.Visible = true;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
