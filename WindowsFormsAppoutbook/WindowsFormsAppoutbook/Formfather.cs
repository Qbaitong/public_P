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
    public partial class Formfather : Form
    {
        public Formfather()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Classform._formadd().Show();
            Classform._formadd().ShowInTaskbar = false;
        }

        private void Formfather_Load(object sender, EventArgs e)
        {
            Classform._fat().Hide();
            Classform._fat().ShowInTaskbar = false;
            Classform._loading().Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Classform._query().Show();
            Classform._query().ShowInTaskbar = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Classform._borrow().Show();
            Classform._borrow().ShowInTaskbar = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Classform._ret().Show();
            Classform._ret().ShowInTaskbar = false;
        }
    }
}
