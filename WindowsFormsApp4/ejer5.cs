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
    public partial class ejer5 : Form
    {
        public ejer5()
        {
            InitializeComponent();
        }

        








        private void ejer5_Load(object sender, EventArgs e)
        {
            


        }
        private void button2_Click(object sender, EventArgs e)
        {
            double data = double.Parse(dato1.Text);
            double data1 = double.Parse(dato2.Text);
            double resta = data - data1;
            labelsigno.Text = "   -";

            resultado.Text = Convert.ToString(resta);
        }
        private void btnpulsar_Click(object sender, EventArgs e)
        {
            double data = double.Parse(dato1.Text);
            double data1 = double.Parse(dato2.Text);
            double suma = data + data1;
            labelsigno.Text = "   +";

            resultado.Text = Convert.ToString(suma);

        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            double data = double.Parse(dato1.Text);
            double data1 = double.Parse(dato2.Text);
            double multi = data * data1;
            labelsigno.Text = "   X";

            resultado.Text = Convert.ToString(multi);
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            double data = double.Parse(dato1.Text);
            double data1 = double.Parse(dato2.Text);
            double dvs = data / data1;
            labelsigno.Text = "   /";

            resultado.Text = Convert.ToString(dvs);
        }
    }
}
