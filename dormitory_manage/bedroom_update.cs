using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


/************************************************************************
公寓寝室更新模块：
通过输入公寓号和寝室号进行精确查询，然后修改相应数据，并更新到数据库
**************************************************************************/
namespace dormitory_manage
{
    public partial class bedroom_update : Form
    {
        public bedroom_update()
        {
            InitializeComponent();
        }
        private bool int_to_bool(Object i)//变换数据类型
        {
            if (i == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void bedroom_Select_Click(object sender, EventArgs e)
        {

            if (int_to_bool(Sqlhelper.getScalar(string.Format("select * from 公寓寝室 where 公寓号='{0}' and 寝室号='{1}'", home_num.Text, bed_num.Text))))//在数据库中找到该寝室信息
            {
                string kzrs = string.Format("select 可住人数 from 公寓寝室 where 公寓号='{0}' and 寝室号='{1}'", home_num.Text, bed_num.Text);
                int kz = (int)Sqlhelper.getScalar(kzrs);
                allowed_num.Text = kz.ToString();//显示可住人数

                string zsfy = string.Format("select 住宿费用 from 公寓寝室 where 公寓号='{0}' and 寝室号='{1}'", home_num.Text, bed_num.Text);
                decimal zs = (decimal)Sqlhelper.getScalar(zsfy);
                Expense.Text = zs.ToString();//显示住宿费用

                string dhh = string.Format("select 电话 from 公寓寝室 where 公寓号='{0}' and 寝室号='{1}'", home_num.Text, bed_num.Text);
                string dh = (string)Sqlhelper.getScalar(dhh);
                telephone.Text = dh;//显示电话

                string szrs = string.Format("select 实住人数 from 公寓寝室 where 公寓号='{0}' and 寝室号='{1}'", home_num.Text, bed_num.Text);
                int sz = (int)Sqlhelper.getScalar(szrs);
                actual_num.Text = sz.ToString();//显示实住人数

                string zybh = string.Format("select 专业编号 from 公寓寝室 where 公寓号='{0}' and 寝室号='{1}'", home_num.Text, bed_num.Text);
                string zy = (string)Sqlhelper.getScalar(zybh);
                SC.Text = zy;//显示专业编号
            }
            else//未找到该寝室信息时，进行提示
            {
                MessageBox.Show("提示：未找到该寝室！");
            }
        }

        private void bedroom_update_Click(object sender, EventArgs e)
        {
            string sql = string.Format("update 公寓寝室 set 可住人数={0},住宿费用={1},电话='{2}',实住人数={3},专业编号='{4}' where 公寓号='{5}' and 寝室号='{6}' ", allowed_num.Text, Expense.Text, telephone.Text, actual_num.Text, SC.Text, home_num.Text, bed_num.Text);//更新数据库
            int i = Sqlhelper.exexute(sql);
            if (i > 0)//修改成功
            {
                MessageBox.Show("修改成功！");
                this.Close();
            }
            else//修改失败
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
