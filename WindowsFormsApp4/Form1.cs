using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ejer ejer1 = new ejer();
            ejer1.ShowDialog();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            ejer2 ejer2 = new ejer2();
            ejer2.ShowDialog();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            ejer5 s = new ejer5();
            s.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ejer6 s = new ejer6();
            s.ShowDialog();


        }
    }
}
