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
    public partial class ejer3 : Form
    {
        public ejer3()
        {
            InitializeComponent();
        }

        private void btncuadrado_Click(object sender, EventArgs e)
        {
            //variables
            double lado;
            double area;
            string resultado;
            //
            lado=double.Parse(txtcuadrado.Text);
            area = lado * lado;
            resultado = Convert.ToString(area);
            labelresultadocuad.Text = "Area cuadrado= " + resultado;
        }

        private void btnrectangulo_Click(object sender, EventArgs e)
        {
            //variables
            double lado;
            double bas;
            double area;
            string resultado;
            //
            lado=double.Parse(txtreclado.Text);
            bas=double.Parse(txtrecbase.Text);
            area=bas*lado;
            resultado=Convert.ToString(area);
            labelresultadorec.Text = "Area rectangulo= " + resultado;
        }





























        private void ejer3_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void labelresultadotri_Click(object sender, EventArgs e)
        {

        }

        private void labelresultadocuad_Click(object sender, EventArgs e)
        {

        }

        private void labelresultadorec_Click(object sender, EventArgs e)
        {

        }

        private void btntriangulo_Click(object sender, EventArgs e)
        {
            //variable
            double lado;
                double bas;
            double area;
            string resultado;
            //
            lado=double.Parse(txttrilado.Text);
            bas=double.Parse(txttribase.Text);
            area = (lado * bas) / 2;
            resultado = Convert.ToString(area);
            labelresultadotri.Text = "Area triangulo= " + resultado;


        }
    }
}
