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
    public partial class Formadd : Form
    {
        public Formadd()
        {
            InitializeComponent();
        }

        private void Formadd_Load(object sender, EventArgs e)
        {
            label7.Text = "——天行健，君子以自强不息！";
            radioButton1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            checkBox4.Checked = true;
            checkBox5.Checked = true;
            checkBox1.Checked = true;
            listBox1.SelectedIndex = 0;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = label7.Text.Substring(1) + label7.Text.Substring(0, 1);
        }
    }
}
          
