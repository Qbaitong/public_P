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
    public partial class Formmex : Form
    {
        public Formmex()
        {
            InitializeComponent();
        }

        private void 登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classfrom.lo().Show();
            Classfrom.lo().ShowInTaskbar = false;
        }
        private void Formmex_FormClosing(object sender, FormClosingEventArgs e)
        {
            Classfrom.nex().Close();
        }

        private void Formmex_Load(object sender, EventArgs e)
        {

        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classfrom._return().Show();
        }

        private void 课程信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 添加课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classfrom.add().Show();
        }
    }
}
