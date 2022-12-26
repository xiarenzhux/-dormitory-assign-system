using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/************************************************************************************
公寓寝室删除模块：
用户填写寝室号，通过选择词条精确删除数据库对应寝室信息，并在删除之前进行提示确认
**************************************************************************************/
namespace dormitory_manage
{
    public partial class bedroom_delete : Form
    {
        public bedroom_delete()
        {
            InitializeComponent();
        }

        private void bedroom_select_Click(object sender, EventArgs e)//从数据库中查询寝室
        {
            string sql = string.Format("select * from 公寓寝室 where 寝室号 like '%{0}%'", bedroom_num.Text);
            dataGridView1.DataSource = getData(sql);//显示查询结果
        }
        DataTable getData(string sql)
        {
            DataTable dt = Sqlhelper.getTable(sql);
            return dt;
        }

        private void bedroom_delete_Click(object sender, EventArgs e)//将查询到的寝室删除
        {
            if (MessageBox.Show("提示：您确定要删除吗？", "此删除不可恢复", MessageBoxButtons.YesNo) == DialogResult.Yes)//删除之前提示确认
            {
                string sql = string.Format("delete  from 公寓寝室 where 公寓号='{0}' and 寝室号='{1}'", dataGridView1.SelectedCells[0].Value.ToString(), dataGridView1.SelectedCells[1].Value.ToString());
                int i = Sqlhelper.exexute(sql);
                if (i == 1)
                {
                    MessageBox.Show("删除成功！");
                    string sql2 = string.Format("select * from 公寓寝室 where 寝室号='{0}'", bedroom_num.Text);
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
