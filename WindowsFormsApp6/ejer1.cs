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
    public partial class ejer1 : Form
    {
        public ejer1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {

            int[]array=new int[6];
            //creo array para almacenar percios y almaceno los precios segun si el marcador ha sido presionado
            if(comprobador1.Checked )
            {
              
                array[0] = int.Parse(precio1.Text);
                decimal cantidad = cantidad1.Value;
                array[0] = Convert.ToInt32(cantidad) * array[0];



            }
            if (comprobador2.Checked)
            {
               
               
                array[1] = int.Parse(precio2.Text);
                decimal cantidad = cantidad2.Value;
                array[1] = Convert.ToInt32(cantidad) * array[1];

            }
            if (comprobador3.Checked)
            {
                array[2] = int.Parse(precio3.Text);
               
                decimal cantidad = cantidad3.Value;
                array[2] = Convert.ToInt32(cantidad) * array[2];

            }
            if (comprobador4.Checked)
            {
                array[3] = int.Parse(precio4.Text);
                decimal cantidad = cantidad4.Value;
                array[3] = Convert.ToInt32(cantidad) * array[3];

            }
            if (comprobador5.Checked)
            {
                array[4] = int.Parse(precio5.Text);
                decimal cantidad = cantidad5.Value;
                array[4] = Convert.ToInt32(cantidad) * array[4];
            }
            if (comprobador6.Checked)
            {
                array[5] = int.Parse(precio6.Text);
                decimal cantidad = cantidad6.Value;
                array[5] = Convert.ToInt32(cantidad) * array[5];

            }
            //sumo los valores de los precios que hay almacenados en el array

            int suma = 0;
            for(int i =0;i<array.Length;i++)
            {
                suma = suma + array[i];

            }
            lbltotal.Text = "total =";
          lblresultado.Text=Convert.ToString(suma);

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            comprobador1.Checked= false;
            comprobador2.Checked = false;
            comprobador3.Checked = false;
            comprobador4.Checked = false;
            comprobador5.Checked = false;
            comprobador6.Checked = false;
            lblresultado.Text = "";
            lbltotal.Text = "";

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
            
        }
    }
}
