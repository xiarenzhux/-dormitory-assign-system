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
    public partial class stu_insert : Form
    {
        string number;
        public stu_insert()
        {
            InitializeComponent();
        }
        public stu_insert(string number)
        {
            InitializeComponent();
            this.number = number;
        }
        private void insert_Click(object sender, EventArgs e)
        {
            string sql = string.Format("insert into 学生(学号,姓名,性别,民族,密码,专业编号,班级编号,联系方式) values('" + num.Text + "','" + name.Text + "','" + sex.Text + "','" + nation.Text + "','" + password.Text + "','" + major_num.Text + "','" + class_num.Text 
                + "','" + phonenum.Text + "')");//添加数据库命令语句
            int i = Sqlhelper.exexute(sql);//调用连接数据库函数
            if (i > 0)//判断是否添加成功
            {
                MessageBox.Show("添加成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
