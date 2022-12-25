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
    public partial class bedroom_delete : Form
    {
        public bedroom_delete()
        {
            InitializeComponent();
        }

        private void select_Click(object sender, EventArgs e)//从数据库中查询寝室
        {
            string sql = string.Format("select * from 公寓寝室 where 寝室号 like '%{0}%'", textBox1.Text);
            dataGridView1.DataSource = getData(sql);
        }
        DataTable getData(string sql)
        {
            DataTable dt = Sqlhelper.getTable(sql);
            return dt;
        }

        private void delete_Click(object sender, EventArgs e)//将查询到的寝室删除
        {
            if (MessageBox.Show("您真的要删除吗？", "此删除不可恢复", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = string.Format("delete  from 公寓寝室 where 公寓号='{0}' and 寝室号='{1}'", dataGridView1.SelectedCells[0].Value.ToString(), dataGridView1.SelectedCells[1].Value.ToString());
                int i = Sqlhelper.exexute(sql);
                if (i == 1)
                {
                    MessageBox.Show("删除成功！");
                    string sql2 = string.Format("select * from 公寓寝室 where 寝室号='{0}'", textBox1.Text);
                    dataGridView1.DataSource = getData(sql2);
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
            
        }
    }
}
