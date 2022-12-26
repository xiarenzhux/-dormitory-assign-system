using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;

/***********************************************************************************
宿舍管理系统登陆界面，允许用户以管理员或者学生身份登陆，同时用户可以选择是否隐藏密码
***********************************************************************************/
namespace dormitory_manage
{
    public partial class Login : Form
    {
        //static string str = "Data Source=DESKTOP-P49N2UT;Initial Catalog=学生公寓寝室分配;Integrated Security=True";
        //SqlConnection con = new SqlConnection(str);
        public Login()
        {
            InitializeComponent();
        }

       private void see_password(object sender, EventArgs e)
        {
            if (see.Checked)
            {
                password.PasswordChar = '*'; // Hide password
            }
            else
            {
                password.PasswordChar = '\0'; // Show password
            }
        }
        private void login_click(object sender, EventArgs e)
        {
            string sql1 = string.Format("select count(*) from 学生 where 学号='{0}' and 密码='{1}'", textBox1.Text, password.Text);
            string sql2 = string.Format("select count(*) from 工作人员 where 工作号='{0}' and 密码='{1}'", textBox1.Text, password.Text);
            //SqlCommand command = new SqlCommand(sql, con);
            //con.Open();
            //SqlDataReader r = command.ExecuteReader();

            if (radioButton1.Checked)//管理员登录
            {
                int i = Convert.ToInt32(Sqlhelper.getScalar(sql2));
                if (i == 1)
                {
                    manager manager = new manager(textBox1.Text);
                    manager.Show();
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("登录失败！");
                }
            }
            else//学生登录
            {
                int i = Convert.ToInt32(Sqlhelper.getScalar(sql1));
                if (i == 1)
                {
                    student student = new student(textBox1.Text);
                    student.Show();
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("登录失败！");
                }
            }
        }

        private void Login_password(object sender, EventArgs e)
        {
            if (see.Checked)
            {
                password.PasswordChar = '*'; // Hide password
            }
            else
            {
                password.PasswordChar = '\0'; // Show password
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
