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
    public partial class house_delete : Form
    {
        public house_delete()
        {
            InitializeComponent();
        }
       
        private void Select_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select * from 公寓楼房 where 公寓号='{0}'",textBox1.Text);//创建查询数据库的语句
            dataGridView1.DataSource=getData(sql);
        }
        DataTable getData(string sql)//接收数据
        {
            DataTable dt = Sqlhelper.getTable(sql);
            return dt;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
                string sql = string.Format("delete  from 公寓楼房 where 公寓号='{0}'",dataGridView1.SelectedCells[0].Value.ToString() );//创建查询数据库的语句
            int i = Sqlhelper.exexute(sql);
                if (i == 1)
                {
                    MessageBox.Show("删除成功！");
                    string sql2 = string.Format("select * from 公寓楼房 where 公寓号='{0}'", textBox1.Text);//创建查询数据库的语句
                    dataGridView1.DataSource = getData(sql2);
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
        }

    }
}
