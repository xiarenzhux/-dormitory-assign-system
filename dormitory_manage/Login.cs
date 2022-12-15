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

        private void Login_click(object sender, EventArgs e)//登陆按钮
        {
            string stu_num = string.Format("select count(*) from 学生 where 学号='{0}' and 密码='{1}'", Account.Text, Password.Text);//创建查询数据库的语句
            string manager_num = string.Format("select count(*) from 工作人员 where 工作号='{0}' and 密码='{1}'", Account.Text, Password.Text);//创建查询数据库的语句
            //SqlCommand command = new SqlCommand(sql, con);
            //con.Open();
            //SqlDataReader r = command.ExecuteReader();
        
            if (Administrators.Checked)//管理员登录
            {
                int i=Convert.ToInt32(Sqlhelper.getScalar(manager_num));//接受用户输入的数据，判断是否正确
                if (i == 1)//对就允许登录
                {
                    manager manager = new manager(Account.Text);
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
                int i= Convert.ToInt32(Sqlhelper.getScalar(stu_num));//接受用户输入的数据，判断是否正确
                if (i==1)//对就允许登录
                {
                    student student = new student(Account.Text);
                    student.Show();
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("登录失败！");
                }
            }
            //r.Close();
            //con.Close();
        }

     
    }
}
