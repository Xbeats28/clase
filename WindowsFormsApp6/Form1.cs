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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ejer1 s = new ejer1();
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ejer2 s = new ejer2();
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ejer3 s = new ejer3();
            s.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ejer4 s = new ejer4();
            s.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ejer5 s = new ejer5();
            s.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ejer6 s = new ejer6();
            s.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ejer7 s = new ejer7();
            s.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //ejercicio 8
            a s = new a();
            s.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ejer9 s = new ejer9();
            s.Show();
        }
    }
}
