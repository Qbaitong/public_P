using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Formcx : Form
    {
        public Formcx()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string b = "select * from dbo.Student where sCode = '" + textBox1.Text + "' ";
            try
            {
                _load(b);
            }
            catch
            {
                MessageBox.Show("请输入正确的学号");
            }
        }
        public void _load(string b)
        {
             dataGridView1.Rows.Clear();
            Classsql sq = new Classsql();
            IDataReader _read = sq.read(b);
            while (_read.Read())
            {
                dataGridView1.Rows.Add(_read[2].ToString(), _read[3].ToString(), _read[4].ToString(), _read[5].ToString(), _read[6].ToString());
            }
            _read.Close();
            sq.close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string c = "select * from dbo.Student where sName = '" + textBox2.Text + "'";
            try 
            {
                _load(c);
            }
            catch
            {
                MessageBox.Show("请输入正确的名字");
            }
        }

        private void Formcx_Load(object sender, EventArgs e)
        {

        }
    }
}
