using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
