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
    public partial class stu_select : Form
    {
        public stu_select()
        {
            InitializeComponent();
            stu_num.SelectedIndex = 0;
        }

        private void select_click(object sender, EventArgs e)
        {
            if (stu_num.SelectedIndex == 0)//按学号查询
            {
                string sql = string.Format("select * from 学生 where 学号='%{0}%'", textBox1.Text);
                select_num.DataSource = getData(sql);
            }
            else if(stu_num.SelectedIndex == 1)//按班级编号查询
            {
                string sql = string.Format("select * from 学生 where 班级编号='%{0}%'", textBox1.Text);
                select_num.DataSource = getData(sql);
            }
            else //按专业编号查询
            {
                string sql = string.Format("select * from 学生 where 专业编号='%{0}%'", textBox1.Text);
                select_num.DataSource = getData(sql);
            }
        }
        DataTable getData(string sql)
        {
            DataTable dt = Sqlhelper.getTable(sql);
            return dt;
        }
    }
}
