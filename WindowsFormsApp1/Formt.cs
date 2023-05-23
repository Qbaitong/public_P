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
    public partial class Formt : Form
    {
        public Formt()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void Formt_Load(object sender, EventArgs e)
        {
            button1.Focus();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Classfrom.nex().Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
