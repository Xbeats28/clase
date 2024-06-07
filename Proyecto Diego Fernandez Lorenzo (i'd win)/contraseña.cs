using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class contraseña : Form
    {
        public contraseña()
        {
            InitializeComponent();
        }

        string ctr = "1010";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
          
            // compruebo si el usuario pulsa enter para comprobar la contraseña
         
            if(e.KeyCode == Keys.Enter)
            {
                if(textBox1.Text ==ctr)
                {
                    admn s = new admn();
                    s.Show();


                }
                else { MessageBox.Show("Contraseña incorrecto", "Error"); }
                textBox1.Text = "";


            }
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ctr)
            {
                admn s = new admn();
                s.Show();


            }
            else { MessageBox.Show("Contraseña incorrecto", "Error"); }
            textBox1.Text = "";

        }

        private void contraseña_Load(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
