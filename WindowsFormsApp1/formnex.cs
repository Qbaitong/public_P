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
    public partial class formnex : Form
    {
        public formnex()
        {
            InitializeComponent();
        }

        private void 登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classfrom.mex().Show();
            Classfrom.nex().Hide();
        }

        private void Formnex_Load(object sender, EventArgs e)
        {
            Classfrom.nex().Hide();
            Classfrom.nex().ShowInTaskbar = false;
            Classfrom.mex().Show();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classfrom._return().Show();
        }

        private void 成绩管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classfrom._infor().Show();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void 学生管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classfrom.cx().Show();
        }

        private void 添加课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
