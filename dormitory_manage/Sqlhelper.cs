using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace dormitory_manage
{
    static  class Sqlhelper
    {
        static string str = "Data Source=ZXCOMPUTER;Initial Catalog=学生公寓寝室分配;Integrated Security=True";
        static SqlConnection con = new SqlConnection(str);
        public static SqlDataReader getReader(string sql)
        {
            try
            {
                SqlCommand command = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader r = command.ExecuteReader(CommandBehavior.CloseConnection);
                return r;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally //finally是最终都会执行
            {
                /*此语句是为了，在打开连接的时候出现了问题，连接没有成功打开，此时关闭连接是有问题的。
               所以在finally里加了一个判断，判断连接的状态，如果是连接的就关闭连接*/
                if (con.State == ConnectionState.Open)//判断连接的状态
                    con.Close();
            }
        }
        public static int exexute(string sql)
        {
            try
            {
                SqlCommand command = new SqlCommand(sql, con);
                con.Open();
                int i = command.ExecuteNonQuery();
                return i;
            }
            catch (Exception ex)
            {
                return -1;
            }

            finally //finally是最终都会执行
            {
                /*此语句是为了，在打开连接的时候出现了问题，连接没有成功打开，此时关闭连接是有问题的。
               所以在finally里加了一个判段，判断连接的状态，如果是连接的就关闭连接*/
                if (con.State == ConnectionState.Open)//判断连接的状态
                    con.Close();
            }
        }
        public static object getScalar(string sql) //返回类型不一定是int，所以函数类型用object
        {
            try
            {
                SqlCommand command = new SqlCommand(sql, con);
                con.Open();
                object i = command.ExecuteScalar();
                return i;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally //finally是最终都会执行
            {
                /*此语句是为了，在打开连接的时候出现了问题，连接没有成功打开，此时关闭连接是有问题的。
               所以在finally里加了一个判段，判断连接的状态，如果是连接的就关闭连接*/
                if (con.State == ConnectionState.Open)//判断连接的状态
                    con.Close();
            }
        }
        public static DataTable getTable(string sql)
        {
            try
            {
                SqlDataAdapter ada = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                ada.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
