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
    public partial class house_insert : Form
    {
        string number;
        public house_insert()
        {
            InitializeComponent();
        }
        public house_insert(string number)
        {
            InitializeComponent();
            this.number = number;
        }
       

        private void Insert_Click(object sender, EventArgs e)
        {
            string sql_insert = string.Format("insert into 公寓楼房(公寓号,楼层数,房间数,性别,工作号,启用时间,关闭时间) values('"+ home_num.Text+"',"+floot.Text+ "," + room_num.Text + ",'" + sex.Text + "','" + task_num.Text + "','" + start_time.Text + "','" + end_time.Text + "')");//创建查询数据库的语句
            int i = Sqlhelper.exexute(sql_insert);
            if (i > 0)//接受用户输入的数据，判断是否成功
            {
                MessageBox.Show("添加成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }

        private void Close_Click(object sender, EventArgs e)//关闭
        {
            this.Close();
        }

    }
}
