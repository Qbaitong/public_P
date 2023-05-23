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
    public partial class Formaddson : Form
    {
        public Formaddson()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void _loadadd()
        {
            comboBox1.Items.Add("小说");
            comboBox1.Items.Add("散文");
            comboBox1.Items.Add("诗");
            comboBox1.Items.Add("戏剧");
            comboBox1.Items.Add("漫画");
            comboBox1.Items.Add("其他");
        }
        /// <summary>
        /// 加载书的种类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Formaddson_Load(object sender, EventArgs e)
        {
            _loadadd();
        }
        private void _loadsx()
        {
            try
            {
                listBox1.Items.Add("类型：" + comboBox1.SelectedItem.ToString());
                listBox1.Items.Add("书名：" + textBox2.Text);
                listBox1.Items.Add("作者：" + textBox3.Text);
                listBox1.Items.Add("编码：" + textBox4.Text);
                listBox1.Items.Add("库存：" + textBox5.Text);
            }
            catch
            {
                MessageBox.Show("请选择一个类型");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            _loadsx();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if ((int)MessageBox.Show("是否保存：是/否","提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == 1)
            {
                int na = la();
                if (na > 0)
                {
                    MessageBox.Show("保存成功");
                    Classform._son().Close();
                }
                else
                {
                    MessageBox.Show("保存失败");
                }
            }
            
        }
        /// <summary>
        /// 保存到数据库的方法
        /// </summary>
        private int la()
        {
            Classsql _sql = new Classsql();
            int n = _sql.exe("insert into dbo.shu values('" + comboBox1.SelectedItem.ToString() + "','" + textBox2.Text + "','"+ textBox3.Text +"','" + textBox4.Text + "','" + textBox5.Text + "') select * from dbo.shu");
            return n;
        }
    }
}
