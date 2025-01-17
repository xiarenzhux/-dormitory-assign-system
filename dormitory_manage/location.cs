﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*****************************************************************************
学生寝室分配模块，选中新添加的学生，可以选择自动分配以及按专业分配两种分配方式
******************************************************************************/
namespace dormitory_manage
{
    public partial class location : Form
    {
        string number;
        public location()
        {
            InitializeComponent();
        }
        public location(string number)
        {
            InitializeComponent();
            this.number = number;
        }
        private void location_Load(object sender, EventArgs e)//对dataGridView1初始化
        {
            string sql = "select * from 学生 where 寝室号 is null";
            dataGridView1.DataSource = getData(sql);
        }
        DataTable getData(string sql)//获取文件
        {
            DataTable dt = Sqlhelper.getTable(sql);
            return dt;
        }
        private void auto_assign(object sender, EventArgs e)//自动分配
        {
            string usex = string.Format("select 性别 from 学生 where 学号='{0}'", dataGridView1.SelectedCells[0].Value.ToString());
            string sex = (string)Sqlhelper.getScalar(usex);

            string house_num = string.Format("select 公寓号 from 公寓楼房 where 性别='{0}'", sex);
            string house_num_sql = (string)Sqlhelper.getScalar(house_num);

            string qs = string.Format("select 寝室号 from 公寓寝室 where 公寓号='{0}'", house_num_sql);
            string qsh = (string)Sqlhelper.getScalar(qs);

            string sql = string.Format("update 学生 set 寝室号='{0}',公寓号='{1}' where 学号='{2}'", qsh, house_num_sql, dataGridView1.SelectedCells[0].Value.ToString());
            string sql2 = string.Format("update 公寓寝室 set 实住人数=实住人数+1 where 公寓号='{0}' and 寝室号='{1}'", house_num_sql, qsh);
            int i = Sqlhelper.exexute(sql);
            i = i + Sqlhelper.exexute(sql2);
            if (i == 2)//判断数据是否成功修改
            {
                MessageBox.Show("分配成功！");
                string sql3 = "select * from 学生 where 寝室号 is null";
                dataGridView1.DataSource = getData(sql3);
            }
            else
            {
                MessageBox.Show("分配失败！");
            }
        }
        private void major_assgin(object sender, EventArgs e)//按专业分配
        {
                string zy1 = string.Format("select 专业编号 from 学生 where 学号='{0}'", dataGridView1.SelectedCells[0].Value.ToString());
                string zy = (string)Sqlhelper.getScalar(zy1);

                string sex1 = string.Format("select 性别 from 学生 where 学号='{0}'", dataGridView1.SelectedCells[0].Value.ToString());
                string sex = (string)Sqlhelper.getScalar(sex1);
                string qs = string.Format("select 寝室号 from 公寓寝室 where 实住人数<可住人数 and 专业编号='{0}' and exists (select * from 公寓楼房 where 公寓号=公寓寝室.公寓号 and 性别='{1}')", zy,sex );
                string qsh = (string)Sqlhelper.getScalar(qs);
                string gy = string.Format("select 公寓号 from 公寓寝室 where 实住人数<可住人数 and 专业编号='{0}'and exists(select * from 公寓楼房 where 公寓号=公寓寝室.公寓号 and 性别='{1}')", zy,sex);
                string gyh = (string)Sqlhelper.getScalar(gy);

                string sql = string.Format("update 学生 set 寝室号='{0}',公寓号='{1}' where 学号='{2}'", qsh,gyh, dataGridView1.SelectedCells[0].Value.ToString());
                string sql2 = string.Format("update 公寓寝室 set 实住人数=实住人数+1 where 公寓号='{0}' and 寝室号='{1}'", gyh, qsh);
                int i = Sqlhelper.exexute(sql);
                i = i + Sqlhelper.exexute(sql2);
                if (i == 2)
                {
                    MessageBox.Show("分配成功！");
                    string sql3 = "select * from 学生 where 寝室号 is null";
                    dataGridView1.DataSource = getData(sql3);
                }
                else
                {
                    MessageBox.Show("分配失败！");
                }
        }
    }
}
