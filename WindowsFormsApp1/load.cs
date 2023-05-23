 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class load : Form
    {
        public load()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (_loading(textBox1.Text.Replace(" ", ""), textBox2.Text) == true)
                {
                    Classfrom.mex().Hide();
                    Classfrom.nex().Show();
                    Classfrom.lo().Close();
                    Classfrom.nex().ShowInTaskbar = true;
                }
                else
                {
                    MessageBox.Show("登录失败");
                }
            }
            catch
            {
                MessageBox.Show("登录失败");
            }
        }

        private void Load_Load(object sender, EventArgs e)
        {

        }
        public static bool _loading(string aa, string ab)
        {
            bool load;
            Classsql s = new Classsql();
            IDataReader _read = s.read("select sCode from dbo.Student where sName = '" + aa + "'");
            _read.Read();
            try
            {
                if (ab == _read[0].ToString())
                {
                    load = true;
                }
                else
                {
                    load = false;
                }
            }
            catch
            {
                load = false;
            }
            return load;
        }
    }
}
