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
    public partial class bedroom_update : Form
    {
        public bedroom_update()
        {
            InitializeComponent();
        }

        private void BSelect_Click(object sender, EventArgs e)
        {
            string kzrs = string.Format("select 可住人数 from 公寓寝室 where 公寓号='{0}' and 寝室号='{1}'", home_num.Text,bed_num.Text);
            int kz = (int)Sqlhelper.getScalar(kzrs);
            allowed_num.Text = kz.ToString();//修改可住人数

            string zsfy = string.Format("select 住宿费用 from 公寓寝室 where 公寓号='{0}' and 寝室号='{1}'", home_num.Text,bed_num.Text);
            decimal zs = (decimal)Sqlhelper.getScalar(zsfy);
            Expense.Text = zs.ToString();//修改住宿费用

            string dhh = string.Format("select 电话 from 公寓寝室 where 公寓号='{0}' and 寝室号='{1}'", home_num.Text,bed_num.Text);
            string dh = (string)Sqlhelper.getScalar(dhh);
            telephone.Text = dh;//修改电话

            string szrs = string.Format("select 实住人数 from 公寓寝室 where 公寓号='{0}' and 寝室号='{1}'", home_num.Text,bed_num.Text);
            int sz = (int)Sqlhelper.getScalar(szrs);
            actual_num.Text = sz.ToString();//修改实住人数

            string zybh = string.Format("select 专业编号 from 公寓寝室 where 公寓号='{0}' and 寝室号='{1}'", home_num.Text, bed_num.Text);
            string zy = (string)Sqlhelper.getScalar(zybh);
            SC.Text = zy;//修改专业编号
        }

        private void BUpdate_Click(object sender, EventArgs e)
        {
            string sql = string.Format("update 公寓寝室 set 可住人数={0},住宿费用={1},电话='{2}',实住人数={3},专业编号='{4}' where 公寓号='{5}' and 寝室号='{6}' ", allowed_num.Text, Expense.Text, telephone.Text, actual_num.Text, SC.Text, home_num.Text, bed_num.Text);//创建查询数据库的语句
            int i = Sqlhelper.exexute(sql);
            if (i > 0)//接受用户输入的数据，判断是否正确
            {//正确
                MessageBox.Show("修改成功！");
                this.Close();
            }
            else//不正确
            {
                MessageBox.Show("修改失败！");
            }
        }

        private void B_Up_Close_Click(object sender, EventArgs e)//关闭
        {
            this.Close();
        }

    }
}
