using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class btnguardar : Form
    {
        //zna de declaracion de variables
        List<string>dni=new List<string>();

        //*****************************fin de zona de declaracion de variables
        public btnguardar()
        {
            InitializeComponent();
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnpulsar_Click(object sender, EventArgs e)
        {
            foreach (string s in dni)
            {    
                
                lblmostrar.Text += (s+ "||");
            }
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
           string dni1=textBox1.Text;
            if (dni1 == "")
            {
                MessageBox.Show("introduzca un dni", "Error!!",MessageBoxButtons.OK); ;

                return;
            }
            else { dni.Add(dni1); textBox1.Text = (""); }
          

        }
    }
}
