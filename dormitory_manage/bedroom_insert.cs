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

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = string.Format("insert into 公寓寝室(公寓号,寝室号,可住人数,住宿费用,电话,实住人数,专业编号) values('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox4.Text + "," + textBox3.Text + ",'" + textBox6.Text + "'," + textBox5.Text + ",'" + textBox8.Text + "')");
            int i = Sqlhelper.exexute(sql);
            if (i > 0)
            {
                MessageBox.Show("添加成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
