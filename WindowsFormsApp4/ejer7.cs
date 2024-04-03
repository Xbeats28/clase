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
    public partial class ejer7 : Form
    {
        public ejer7()
        {
            InitializeComponent();
        }

        private void btnconversoreuros_Click(object sender, EventArgs e)
        {
            //declaracion de variables
            double eur =  double.Parse(txteuros.Text);
            double doll;
            //
            doll=eur*0.93;
            txtdollares.Text =Convert.ToString(eur);


        }

        private void btnconvertirdollar_Click(object sender, EventArgs e)
        {
 //declaracion de variables
            double eur;
            double doll = double.Parse(txtdollares.Text);
            //
            eur=doll/0.93;
            txteuros.Text = Convert.ToString(eur);
        }
    }
}
