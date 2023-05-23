using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppoutbook
{
    public partial class Formaddson2 : Form
    {
        string _id = "";
        public Formaddson2()
        {
            InitializeComponent();
        }

        private void Formaddson2_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            comboBox1.Items.Add("小说");
            comboBox1.Items.Add("散文");
            comboBox1.Items.Add("诗");
            comboBox1.Items.Add("戏剧");
            comboBox1.Items.Add("漫画");
            comboBox1.Items.Add("其他");
        }
        public Formaddson2(string aa,string ab,string ac,string ad,string ae,string a)
        {
            InitializeComponent();
            textBox1.Text = aa;
            comboBox1.Text = ab;
            textBox2.Text = ac;
            textBox3.Text = ad;
            textBox4.Text = ae;
            textBox5.Text = a;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string str = "update shu  set 类型 = '" + comboBox1.SelectedItem + "', 书名 = '" + textBox2.Text +"', 作者 = '" + textBox3.Text + "', 编码 = " + textBox4.Text + ", 库存 = " + textBox5.Text + " where 编号 = '" + textBox1.Text + "' select * from dbo.shu";
            Classsql sql = new Classsql();
            if (sql.exe(str) > 0)
            {
                MessageBox.Show("修改成功");
                this.Close();
                
            }
        }
    }
}
