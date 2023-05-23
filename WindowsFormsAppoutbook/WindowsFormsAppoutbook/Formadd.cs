using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsAppoutbook
{
    public partial class Formadd : Form
    {
        public Formadd()
        {
            InitializeComponent();
        }
        public int id;

        private void Formadd_Load(object sender, EventArgs e)
        {
            _load();
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        /// <summary>
        /// 刷新数据库显示在控件中的表格
        /// </summary>
        public void _load()
        {
            dataGridView1.Rows.Clear();
            Classsql sq = new Classsql();
            IDataReader _read = sq.read("select * from dbo.shu");
            while (_read.Read())
            {
                dataGridView1.Rows.Add(_read[0].ToString(), _read[1].ToString(), _read[2].ToString(), _read[3].ToString(), _read[4].ToString(), _read[5].ToString());
            }
            _read.Close();
            sq.close();
        }
        /// <summary>
        /// 查询的方法
        /// </summary>
        public void _cId(int ac)
        {
            dataGridView1.Rows.Clear();
            Classsql sq = new Classsql();
            IDataReader _read = sq.read("select * from dbo.Student where sCode = '" + ac + "' ");
            while (_read.Read())
            {
                dataGridView1.Rows.Add(_read[0].ToString(), _read[1].ToString(), _read[2].ToString(), _read[3].ToString(), _read[4].ToString(), _read[5].ToString());
            }
            _read.Close();
            sq.close();
        }
        public void _cmh(string gg)
        {
            dataGridView1.Rows.Clear();
            Classsql sq = new Classsql();
            IDataReader _read = sq.read("select * from dbo.shu where 书名 like '%" + gg +"%'");
            while (_read.Read())
            {
                dataGridView1.Rows.Add(_read[0].ToString(), _read[1].ToString(), _read[2].ToString(), _read[3].ToString(), _read[4].ToString(), _read[5].ToString());
            }
            _read.Close();
            sq.close();
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            _load();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Classform._son().Show();
            Classform._son().ShowInTaskbar = false;
        }
        public void _shanchu()
        {
            try
            {
                id = Convert.ToInt32( dataGridView1.SelectedRows[0].Cells[0].Value);
                DialogResult dr = MessageBox.Show("确认要删除吗", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    Classsql nue = new Classsql();
                    if (nue.exe("delete from dbo.shu where 编号 = '" + id + "'") > 0)
                    {
                        MessageBox.Show("删除成功");
                        _load();
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                    }
                }
            }
            catch
            {

            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            _shanchu();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
        }
        public void _f(out string a,out string aa,out string ab,out string ac,out string ad,out string ae)
        {
            a = "";
            aa = "";
            ab = "";
            ac = "";
            ad = "";
            ae = "";
            try
            {
                a = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                aa = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                ab = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                ac = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                ad = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                ae = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                
            }
            catch
            {
                
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string aa = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string ab = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string ac = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string ad = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string ae = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                string a = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                Formaddson2 aoe = new Formaddson2(aa, ab, ac, ad, ae, a);
                aoe.ShowDialog();
                _load();
            }
            catch
            {
                MessageBox.Show("请选中书");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                _cId(Convert.ToInt32(textBox1.Text));
            }
            catch
            {
                MessageBox.Show("请输入正确的书ID");
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
               _cmh(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("请输入正确的书ID");
            }
        }
    }
}
