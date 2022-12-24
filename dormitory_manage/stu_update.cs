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
    public partial class stu_update : Form
    {
        public stu_update()
        {
            InitializeComponent();
        }

        private void stu_Select_Click(object sender, EventArgs e)
        {
            string xm = string.Format("select 姓名 from 学生 where 学号='{0}'", textBox1.Text);
            string name = Sqlhelper.getScalar(xm).ToString();//姓名
            sName.Text = name;

            string xb = string.Format("select 性别 from 学生 where 学号='{0}'", textBox1.Text);
            string sex = Sqlhelper.getScalar(xb).ToString();//性别
            sSex.Text = sex;

            string mz = string.Format("select 民族 from 学生 where 学号='{0}'", textBox1.Text);
            string mz2 = Sqlhelper.getScalar(mz).ToString();//民族
            Nation.Text = mz2;

            string lxfs = string.Format("select 联系方式 from 学生 where 学号='{0}'", textBox1.Text);
            string lx = Sqlhelper.getScalar(lxfs).ToString();//联系方式
            Tele.Text = lx;

            string gyh = string.Format("select 公寓号 from 学生 where 学号='{0}'", textBox1.Text);
            string gy = Sqlhelper.getScalar(gyh).ToString();//公寓号
            HouseNo.Text = gy;

            string qsh = string.Format("select 寝室号 from 学生 where 学号='{0}'", textBox1.Text);
            string qs = Sqlhelper.getScalar(qsh).ToString();//寝室号
            BedNo.Text = qs;

            string bjh = string.Format("select 班级编号 from 学生 where 学号='{0}'", textBox1.Text);
            string bj = Sqlhelper.getScalar(bjh).ToString();//班级编号
            CNo.Text = bj;

            string zyh = string.Format("select 专业编号 from 学生 where 学号='{0}'", textBox1.Text);
            string zy = Sqlhelper.getScalar(zyh).ToString();//专业编号
            SC.Text = zy;

            string word = string.Format("select 密码 from 学生 where 学号='{0}'", textBox1.Text);
            string password = Sqlhelper.getScalar(word).ToString();//密码
            Pass.Text =password;
        }

        private void stu_Update_Click(object sender, EventArgs e)
        {
            string sql = string.Format("update 学生 set 姓名='{0}',性别='{1}',民族='{2}',联系方式='{3}',公寓号='{4}',寝室号='{5}',班级编号='{6}',专业编号='{7}',密码='{8}' where 学号='{9}' ", sName.Text, sSex.Text, Nation.Text, Tele.Text, HouseNo.Text, BedNo.Text, CNo.Text, SC.Text, Pass.Text, textBox1.Text);
            int i = Sqlhelper.exexute(sql);//接受用户输入的数据，判断是否正确
            if (i > 0)//接受用户输入的数据，判断正确
            {
                MessageBox.Show("修改成功！");
                this.Close();
            }
            else//不正确
            {
                MessageBox.Show("修改失败！");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
