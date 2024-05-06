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
        string w;
        private void ejer2_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Aplicaciones ofimaticas");
            listBox1.Items.Add("Redes");
            if (listBox1.SelectedIndex==0)
            {
                Ejer2a s = new Ejer2a();
                s.Show();

            }
            else if (listBox1.SelectedIndex==1)
            {
               Ejer2b s = new Ejer2b();
                s.Show();
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Redes");
            listBox1.Items.Add("Aplicaciones ofimaticas");
            
            {
                
            }
            if (listBox1.SelectedIndex==0)
            {
                Ejer2a s = new Ejer2a();
                s.Show();

            }
            else if (listBox1.SelectedIndex==1)
            {
                Ejer2b s = new Ejer2b();
                s.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            w = Convert.ToString(listBox1.SelectedItem);
        }
    }
}
