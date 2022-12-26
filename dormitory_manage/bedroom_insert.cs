using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

/**************************************************************************************************
公寓寝室添加模块：
通过填写公寓号、寝室号、可住人数、住宿费用、电话、实住人数和专业编号信息，实现寝室添加并更新到数据库
***************************************************************************************************/
namespace dormitory_manage
{
    public partial class bedroom_insert : Form
    {
        public bedroom_insert()
        {
            InitializeComponent();
        }
        //
        private void bedroom_Insert_Click(object sender, EventArgs e)
        {
            string sql = string.Format("insert into 公寓寝室(公寓号,寝室号,可住人数,住宿费用,电话,实住人数,专业编号) values('" + home_num.Text + "','" + bed_num.Text + "'," + allowed_num.Text + "," + Expense.Text + ",'" + telephone.Text + "'," + actual_num.Text + ",'" + SC.Text + "')");//向数据库插入该寝室信息
            int i = Sqlhelper.exexute(sql);
            if (i > 0)//如果成功输入数据库
            {
                MessageBox.Show("添加成功！");//提示成功
                this.Close();
            }
            else//用户输入数据不符合要求，进行友好型提示
            {
                if (home_num.Text == "" || telephone.Text == "" || bed_num.Text == "" || actual_num.Text == "" || allowed_num.Text == "" || SC.Text == "" || Expense.Text == "")
                    MessageBox.Show("提示：有未填完的信息项！");//提示信息填写不完整
                Regex rx = new Regex("^[0-9]*$");
                if (!rx.IsMatch(actual_num.Text))//判断实住人数框是否为数字
                    MessageBox.Show("提示：实住人数需为数字！");
                else if (!rx.IsMatch(allowed_num.Text))//判断可住人数框是否为数字
                    MessageBox.Show("提示：可住人数需为数字！");

                else if (home_num.Text.Length != 3)//判断公寓号位数
                    MessageBox.Show("提示：公寓号位数不正确！");
                else if (telephone.Text.Length != 11)//判断电话位数
                    MessageBox.Show("提示：电话位数不正确！");
                else if (home_num.Text.Length != 3)//判断寝室号位数
                    MessageBox.Show("提示：寝室号位数不正确！");
                else if (SC.Text.Length != 8)//判断专业编号位数
                    MessageBox.Show("提示：专业编号位数不正确！");

                else if (int.Parse(actual_num.Text) > int.Parse(allowed_num.Text))//逻辑判断
                    MessageBox.Show("提示：实住人数需小于或等于可住人数！");
                else
                    MessageBox.Show("添加失败！");//提示失败

            }
        }
        private void Close_Click(object sender, EventArgs e)//关闭
        {
            this.Close();
        }
    }
}
