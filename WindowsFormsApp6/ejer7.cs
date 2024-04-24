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
    public partial class ejer7 : Form
    {
        public ejer7()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

           for(int i = 0; i < 600;i++)
            {
                pictureBox1.Left = i;
            }
            for (int i = 600; i <= 600 && i>0; i--)
            {
                pictureBox1.Left = i;
            }

        }

        private void ejer7_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
