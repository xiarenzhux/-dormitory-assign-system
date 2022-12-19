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
    public partial class manager : Form
    {
        string number;
        public manager()
        {
            InitializeComponent();
        }
        public manager(string number)
        {
            InitializeComponent();
            this.number = number;
        }

        private void manager_Load(object sender, EventArgs e)
        {
            string uname = string.Format("select rtrim(用户名) from 工作人员 where 工作号='{0}'", this.number);//创建查询数据库的语句
            string name = (string)Sqlhelper.getScalar(uname);//进行数据库查询
            this.name.Text = name;
            num.Text = number;

        }
        /*
        private void button1_Click(object sender, EventArgs e)
        {
            house_insert house = new house_insert();
            house.Show();
        }
        */

        private void Insert_House_ToolStripMenuItem_Click(object sender, EventArgs e)//插入公寓楼房
        {
            house_insert house_Insert = new house_insert(number);//插入公寓楼房
            house_Insert.Show();
        }

       

        

        private void Delete_House_ToolStripMenuItem_Click(object sender, EventArgs e)//删除公寓楼房
        {
            house_delete del = new house_delete();//删除公寓楼房
            del.Show();
        }

        private void Update_House_ToolStripMenuItem_Click(object sender, EventArgs e)//更新公寓楼房
        {
            house_update upd = new house_update();//更新公寓楼房
            upd.Show();
        }

        private void Select_House_ToolStripMenuItem_Click(object sender, EventArgs e)//查询公寓楼房
        {
            house_select sel = new house_select();//查询公寓楼房
            sel.Show();
        }

        private void Insert_Bedroom_ToolStripMenuItem_Click(object sender, EventArgs e)//插入公寓寝室
        {
            bedroom_insert bed = new bedroom_insert();
            bed.Show();
        }

        private void Update_Bedroom_ToolStripMenuItem_Click(object sender, EventArgs e)//更新公寓寝室
        {
            bedroom_update update = new bedroom_update();
            update.Show();
        }

        private void Delete_Bedroom_ToolStripMenuItem_Click(object sender, EventArgs e)//删除公寓寝室
        {
            bedroom_delete del = new bedroom_delete();
            del.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label1.Visible = true;
            textBox2.Visible = true;
            label2.Visible = true;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string newPassword = textBox1.Text;
            string confirmPassword = textBox1.Text;
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {

                return;
            }

            // 验证新密码和确认密码
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("新密码和确认密码不匹配。请重试。");
                return;
            }

            // 更新数据库中的密码
            string updateSql = string.Format("update 工作人员 set 密码='{0}' where 工作号='{1}'", newPassword, this.number);
            int rowsAffected = Sqlhelper.exexute(updateSql);
            if (rowsAffected > 0)
            {
                MessageBox.Show("密码修改成功。");
                textBox1.Visible = false;
                label1.Visible = false;
                textBox2.Visible = false;
                label2.Visible = false;
                button2.Visible = false;
            }
            else
            {
                MessageBox.Show("密码修改失败。");
            }
        }

        private void Select_Bedroom_Click(object sender, EventArgs e)
        {
            bedroom_select sel = new bedroom_select();
            sel.Show();
        }
    }
}
