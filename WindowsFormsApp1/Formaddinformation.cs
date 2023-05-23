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
    public partial class Formaddinformation : Form
    {
        string dext = "";
        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                Classsql sq = new Classsql();
                
                if (radioButton1.Checked == true)
                {
                    dext = "必修";
                }
                else if (radioButton2.Checked == true)
                {
                    dext = "选修";
                }
                string a = "insert into dbo.Tablead  values('" + textBox1.Text + "','" + comboBox1.Text + "','" + dext + "','" + numericUpDown2.TextAlign + "',' " + numericUpDown3.TextAlign + " ','" + numericUpDown4.TextAlign +"')";
                sq.exe(a);
                MessageBox.Show("添加成功！");

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public Formaddinformation()
        {
            InitializeComponent();
        }

        private void Formaddinformation_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("专业必修");
            comboBox1.Items.Add("专业选修");
            comboBox1.SelectedIndex = 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == " ")
            {
                MessageBox.Show("请输入课堂名称");
                tabControl1.SelectedIndex = 0;
            }
            else
            {
                //tabControl1.SelectedIndex = 1;
                tabControl1.SelectedTab = tabPage2;
                //string km, lx, xz, xf, ll, sy, zong;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
