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
    public partial class FormbookBorrow : Form
    {
        public FormbookBorrow()
        {
            InitializeComponent();
        }

        private void FormbookBorrow_Load(object sender, EventArgs e)
        {
            label1.Text = "您好，" + Classnum.num + "同学";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
