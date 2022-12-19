using System;
using System.Windows.Forms;

namespace dormitory_manage
{
    public partial class house_update : Form
    {
        public house_update()
        {
            InitializeComponent();
        }

        private void Select_Click(object sender, EventArgs e)
        {
            string lcs = string.Format("select 楼层数 from 公寓楼房 where 公寓号='{0}'", house_num.Text);//创建查询数据库的语句
            int lc =(int) Sqlhelper.getScalar(lcs);//楼层数
            Floor_num.Text = lc.ToString();

            string fjs = string.Format("select 房间数 from 公寓楼房 where 公寓号='{0}'", house_num.Text);//创建查询数据库的语句
            int  fj = (int)Sqlhelper.getScalar(fjs);//房间数
            home_num.Text = fj.ToString();

            string qys = string.Format("select 启用时间 from 公寓楼房 where 公寓号='{0}'", house_num.Text);//创建查询数据库的语句
            string qy = Sqlhelper.getScalar(qys).ToString();//启用时间
            start_time.Text = qy;

            string gbs = string.Format("select 关闭时间 from 公寓楼房 where 公寓号='{0}'", house_num.Text);//创建查询数据库的语句
            string gb = Sqlhelper.getScalar(gbs).ToString();//关闭时间
            close_time.Text = gb;

            string xb1 = string.Format("select 性别 from 公寓楼房 where 公寓号='{0}'", house_num.Text);//创建查询数据库的语句
            string xb = (string)Sqlhelper.getScalar(xb1);//性别
            Sex.Text = xb;

            string gzh = string.Format("select 工作号 from 公寓楼房 where 公寓号='{0}'", house_num.Text);//创建查询数据库的语句
            string gz = (string)Sqlhelper.getScalar(gzh);//工作号
            task_num.Text = gz;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string house_sql_ask = string.Format("update 公寓楼房 set 楼层数='{0}',房间数='{1}',启用时间='{2}',关闭时间='{3}',性别='{4}',工作号='{5}' where 公寓号='{6}' ",Floor_num.Text,home_num.Text,start_time.Text,close_time.Text, Sex.Text,task_num.Text,house_num.Text);//创建查询数据库的语句
            int i = Sqlhelper.exexute(house_sql_ask);//接受用户输入的数据，判断是否正确
            if (i > 0)//接受用户输入的数据，判断是否正确
            {
                MessageBox.Show("修改成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
