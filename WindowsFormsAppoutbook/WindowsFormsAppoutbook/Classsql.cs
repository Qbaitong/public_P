    using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppoutbook
{
    /// <summary>
    /// 一个访问数据库连接池的方法
    /// </summary>
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
            string sqlstr = "sql连接字符串";
            sc = new SqlConnection(sqlstr);
            sc.Open();
            return sc;
        }
        //需要传入一个sql语句
        public SqlCommand _cmd(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, con());
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
