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
    public partial class ejer3 : Form
    {
        public ejer3()
        {
            InitializeComponent();
        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            //Esta variable la utilizare en todo momento(recoge el texto de la textbox)
        double texto=double.Parse(txtmetros.Text);
            double result = 0;
            //el programa es simple comprueba cuál de todos cumple la propiedad chcked y dependiendo cual esté realizada el cálculo que deba
            if(milimetros.Checked)
            {
                result = texto*1000;
                txtresultado.Text=Convert.ToString(result);
            }
            if (decimetros.Checked)
            {
                result = texto * 10;
                txtresultado.Text = Convert.ToString(result);
            }
            if (centimetros.Checked)
            {
                result = texto * 100;
                txtresultado.Text = Convert.ToString(result);
            }
            if(kilometros.Checked)
            {
                result = texto /1000;
                txtresultado.Text = Convert.ToString(result);
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtmetros.Text = "";
            txtresultado.Text = "";
            milimetros.Checked = false;
            centimetros.Checked = false;
            kilometros.Checked = false;
            decimetros.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}