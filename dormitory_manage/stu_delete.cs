using System;
using System.Data;
using System.Windows.Forms;

namespace dormitory_manage
{
    public partial class stu_delete : Form
    {
        public stu_delete()
        {
            InitializeComponent();
        }

        private void Select_Click(object sender, EventArgs e)//从数据库中按学号查询学生信息
        {
            string sql = string.Format("select * from 学生 where 学号='{0}'", stu_id.Text);
            dataGridView1.DataSource = getData(sql);
        }
        DataTable getData(string sql)//获取数据
        {
            DataTable dt = Sqlhelper.getTable(sql);
            return dt;
        }

        private void Delete_Click(object sender, EventArgs e)//从数据库中删除学生信息
        {
            string gyh = string.Format("select 公寓号 from 学生 where 学号='{0}'", dataGridView1.SelectedCells[0].Value.ToString());//查找
            string gy = (string)Sqlhelper.getScalar(gyh);

            string qsh = string.Format("select 寝室号 from 学生 where 学号='{0}'", dataGridView1.SelectedCells[0].Value.ToString());
            string qs = (string)Sqlhelper.getScalar(qsh);
            string sql = string.Format("delete  from 学生 where 学号='{0}'", dataGridView1.SelectedCells[0].Value.ToString());//删除
            string sql2 = string.Format("update 公寓寝室 set 实住人数=实住人数-1 where 公寓号='{0}' and 寝室号='{1}'", gy, qs);//更新
            int i = Sqlhelper.exexute(sql);
            i = i + Sqlhelper.exexute(sql2);
            if (i == 2)
            {
                MessageBox.Show("删除成功！");
                string sql3 = string.Format("select * from 公寓楼房 where 公寓号='{0}'", stu_id.Text);
                dataGridView1.DataSource = getData(sql3);
            }
            else
            {
                MessageBox.Show("删除失败！");
            }
        }
    }
}
