using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*****************************************************************
公寓寝室查询模块：
可选择通过公寓号或寝室号两种方式进行数据库信息的查询，并反馈给用户
******************************************************************/
namespace dormitory_manage
{
    public partial class bedroom_select : Form
    {
        public bedroom_select()
        {
            InitializeComponent();
            Condition_Box.SelectedIndex = 0;
        }

        private void bedroom_select_Click(object sender, EventArgs e)
        {
            if (Condition_Box.SelectedIndex == 0)//按公寓号查询
            {
                string sql = string.Format("select * from 公寓寝室 where 公寓号 like '%'+'{0}'+'%'", bedroom_text.Text);//查询数据库
                dataGridView1.DataSource = getData(sql);//显示查询信息
            }
            else//按寝室号查询
            {
                string sql = string.Format("select * from 公寓寝室 where 寝室号 like '%{0}%';", bedroom_text.Text);//查询数据库
                dataGridView1.DataSource = getData(sql);//显示查询信息
            }
        }
        DataTable getData(string sql)//获取数据
        {
            DataTable dt = Sqlhelper.getTable(sql);
            return dt;
        }
    }
}
