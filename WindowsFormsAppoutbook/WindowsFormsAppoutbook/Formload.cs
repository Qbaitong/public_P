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
    public partial class Formload : Form
    {
        public Formload()
        {
            InitializeComponent();
        }

        private void Formload_FormClosing(object sender, FormClosingEventArgs e)
        {
            Classform._fat().Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                
                if (_loading(textBox1.Text.Replace(" ", ""), textBox2.Text) == true)
                {
                    
                    Classform._fat().Show();
                    Classform._fat().ShowInTaskbar = true;
                    Classform._loading().Hide();
                    Classform._loading().ShowInTaskbar = false;
                    Classnum.num = textBox1.Text;
                }
                else
                {
                    MessageBox.Show("登录失败啊");
                }
            }
            else if (radioButton2.Checked == true)
            {
                MessageBox.Show("学生禁止登录");
            }

        }
        /// <summary>
        /// 产生一个随机的验证码图片,返回给一个picturebox。
        /// 并且返回一个string类型的值
        /// </summary>
        public string hpic()
        {
            Bitmap b = new Bitmap(150, 80);
            Graphics a = Graphics.FromImage(b);
            pictureBox1.Image = b;
            Classnums d = new Classnums();
            Random r = new Random();
            v = d._uum();
            string[] fon = { "黑体", "仿宋", "黑体", "隶书", "华文彩云" };
            Color[] col = { Color.Yellow, Color.Beige, Color.BlueViolet, Color.Aqua, Color.DarkBlue };
            a.DrawString(v, new Font(fon[r.Next(0, 4)], 35, FontStyle.Regular), new SolidBrush(col[r.Next(0, 4)]), new Point(20, 15));
            for (int i = 0; i < 50; i++)
            {
                a.DrawLine(new Pen(col[r.Next(0, 4)]), new Point(r.Next(0, 150), r.Next(0, 150)), new Point(r.Next(0, 150), r.Next(0, 150)));
            }
            int num1 = r.Next(0, 120);
            int num = r.Next(0, 120);
            for (int q = 0; q < 1000; q++)
            {
                b.SetPixel(r.Next(0, 120), r.Next(0, 50), col[r.Next(0, 4)]);
            }
            return v;

        }
        //存储随机生成的字符串的变量
        public string v = null;

        private void Label3_Click(object sender, EventArgs e)
        {
            hpic();
        }

        private void Formload_Load(object sender, EventArgs e)
        {
            hpic();
            radioButton1.Checked = true;
        }
        /// <summary>
        /// 一个判断登录是否成功的方法，需要填入string类型的值（账号，密码）
        /// </summary>
        /// <returns></returns>
        public static bool _loading(string aa, string ab)
        {
            bool load;
            Classsql s = new Classsql();
            IDataReader _read = s.read("SELECT password FROM [newproject].[dbo].[ceshiuser] where username = '" + aa + "'");
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
