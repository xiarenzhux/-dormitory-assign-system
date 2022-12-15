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
    public partial class house_select : Form
    {
        public house_select()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void Select_Click(object sender, EventArgs e)//查询按钮
        {
            if (comboBox1.SelectedIndex== 0)//按公寓号查询
            {
                string home_num = string.Format("select * from 公寓楼房 where 公寓号='{0}'", house_text.Text);//创建查询数据库的语句
                dataGridView1.DataSource = getData(home_num);
            }
            else//按性别查询
            {
                string sex = string.Format("select * from 公寓楼房 where 性别='{0}'", house_text.Text);//创建查询数据库的语句
                dataGridView1.DataSource = getData(sex);
            }
        }
        DataTable getData(string sql)//获取数据
        {
            DataTable dt = Sqlhelper.getTable(sql);
            return dt;
        }

    }
}
