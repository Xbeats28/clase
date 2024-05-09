using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class inicio_10 : Form
    {
        public inicio_10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ejer10 s = new ejer10();
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ejer10b s = new ejer10b();
            s.Show();
        }
    }
}
