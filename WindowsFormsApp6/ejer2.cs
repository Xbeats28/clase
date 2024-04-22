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
    public partial class ejer2 : Form
    {
        public ejer2()
        {
            InitializeComponent();
        }
            
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            Ejer2a s = new Ejer2a();
            s.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Ejer2b s = new Ejer2b();
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ejer2_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
    }
}
