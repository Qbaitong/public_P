
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class Classsql
    {
        //连接对象
        SqlConnection sc;
        /// <summary>
        /// 打开数据库，返回一个连接字符串对象
        /// </summary>
        /// <returns></returns>
        public SqlConnection con()
        {
            string sqlstr = "Data Source=你数据库的用户名;Initial Catalog = 数据库的名字;Integrated Security = True";
            sc = new SqlConnection(sqlstr);
            sc.Open();
            return sc;
        }
        //需要传入一个sql语句
        public SqlCommand _cmd(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql,con());
            return cmd;
        }
        public int exe(string sql)
        {
            return _cmd(sql).ExecuteNonQuery();
        }
        public SqlDataReader read(string sql)
        {
            return _cmd(sql).ExecuteReader();
        }
        public void close()
        {
            sc.Close();
        }
    }
}
