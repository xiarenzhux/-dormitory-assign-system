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
    public partial class bedroom_insert : Form
    {
        public bedroom_insert()
        {
            InitializeComponent();
        }

        private void BInsert_Click(object sender, EventArgs e)
        {
            string sql = string.Format("insert into 公寓寝室(公寓号,寝室号,可住人数,住宿费用,电话,实住人数,专业编号) values('" + home_num.Text + "','" + bed_num.Text + "'," + allowed_num.Text + "," + Expense.Text + ",'" + telephone.Text + "'," + actual_num.Text + ",'" + SC.Text + "')");//创建查询数据库的语句
            int i = Sqlhelper.exexute(sql);
            if (i > 0)//接受用户输入的数据，判断是否成功
            {
                MessageBox.Show("添加成功！");
                this.Close();
            }
            else//用户输入的数据不符合要求
            {
                MessageBox.Show("添加失败！");
            }
        }

        private void BClose_Click(object sender, EventArgs e)//关闭
        {
            this.Close();
        }

    }
}
