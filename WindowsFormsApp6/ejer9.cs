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
    public partial class ejer9 : Form
    {
        public ejer9()
        {
           
            InitializeComponent();
        }
       
        double precioplatoprinci = 0;
        //genero un evento para cunado el indice de la combobox cambie pase algo
        //hago publico este evento porque lo necesitare mas tarde
        public void comboplatosprinci_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
           
            string comida1 = comboplatosprinci.Text;
            //


            if (comida1== "Romana")
            {
                precioplatoprinci = 4;

            }
            if (comida1 == "Primavera")
            {
                precioplatoprinci = 3;

            }
            if (comida1 == "Cesar")
            {
                precioplatoprinci = 4.5;

            }


            if (comida1 == "Pulpo")
            {
                precioplatoprinci = 6;

            }
            if (comida1 == "Zamburiñas")
            {
                precioplatoprinci = 7;

            }
            if (comida1 == "Carne")
            {
                precioplatoprinci = 3;

            }
            if (comida1 == "Choco")
            {
                precioplatoprinci = 3.5;

            }

            if (comida1 == "Champiñones")
            {
                precioplatoprinci = 4;

            }
            if (comida1 == "Puerro")
            {
                precioplatoprinci = 5;

            }
            if (comida1 == "Zanahoria")
            {
                precioplatoprinci = 4.75;

            }


            lblprecio.Text = precioplatoprinci.ToString();
            label3.Visible = true;
            lblprecio.Visible = true;
        }

        private void radiocremas_CheckedChanged(object sender, EventArgs e)
        {
           
           
            comboplatosprinci.Items.Clear();
            comboplatosprinci.Items.Add("Champiñones");
            comboplatosprinci.Items.Add("Puerro");
            comboplatosprinci.Items.Add("Zanahoria");

        }

        private void radioempanadas_CheckedChanged(object sender, EventArgs e)
        {
           
           
            comboplatosprinci.Items.Clear();
            comboplatosprinci.Items.Add("Pulpo");
            comboplatosprinci.Items.Add("Zamburiñas");
            comboplatosprinci.Items.Add("Carne");
            comboplatosprinci.Items.Add("Choco");
        }

        private void radioensaladas_CheckedChanged(object sender, EventArgs e)
        {
          
           
            comboplatosprinci.Items.Clear();
            comboplatosprinci.Items.Add("Romana");
            comboplatosprinci.Items.Add("Primavera");
            comboplatosprinci.Items.Add("Cesar");
        }

        double preciosegundo = 0;

        public void combosegundoplato_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
          
            string texto2=combosegundoplato.Text;
            //

            label3.Visible = true;
            lblprecio.Visible = true;
            if (combosegundoplato.Text == "Milanesa")
            {
                preciosegundo = 4.5;
            }
            if (combosegundoplato.Text == "Chuleta")
            {
                preciosegundo = 7.5;
            }
            if (combosegundoplato.Text == "San jacobo")
            {
                preciosegundo = 4.5;
            }
            if (combosegundoplato.Text == "Solomillo")
            {
                preciosegundo = 8.5;
            }
            if (combosegundoplato.Text == "Spaguetti Bolognesa")
            {
                preciosegundo = 9;
            }
            if (combosegundoplato.Text == "Macarrones carbonara")
            {
                preciosegundo = 9.5;
            }
            if (combosegundoplato.Text == "Trofie al pesto")
            {
                preciosegundo = 10.5;
            }
            if (combosegundoplato.Text == "Merluza a la plancha")
            {
                preciosegundo = 4.5;
            }
            if (combosegundoplato.Text == "Lenguado")
            {
                preciosegundo = 4.5;
            }
            if (combosegundoplato.Text == "Besugo")
            {
                preciosegundo = 10;
            }
            if (combosegundoplato.Text == "Bacalao al horno")
            {
                preciosegundo = 6;
            }
            lblprecio2.Text = Convert.ToString(preciosegundo);
            label4.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
           
            combosegundoplato.Items.Clear();
            combosegundoplato.Items.Add("Merluza a la plancha");
            combosegundoplato.Items.Add("Lenguado");
            combosegundoplato.Items.Add("Besugo");
            combosegundoplato.Items.Add("Bacalao al horno");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
            combosegundoplato.Items.Clear();
            combosegundoplato.Items.Add("Milanesa");
            combosegundoplato.Items.Add("Chuleta");
            combosegundoplato.Items.Add("San Jacobos");
            combosegundoplato.Items.Add("Solomillo");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
            combosegundoplato.Items.Clear();
            combosegundoplato.Items.Add("Spaguetti Bolognesa");
            combosegundoplato.Items.Add("Macarrones carbonara");
            combosegundoplato.Items.Add("Trofie al pesto");
        }

        private void radiopostre_CheckedChanged(object sender, EventArgs e)
        {
            combopostre.Items.Clear();
            combopostre.Items.Add("Fruta / Yogurt");
            combopostre.Items.Add("Brownie Chocolate con helado");
            combopostre.Items.Add("Tarta de Santiago");
            combopostre.Items.Add("Tarta semifria de chocolate y queso");
        }

        private void radiocafe_CheckedChanged(object sender, EventArgs e)
        {
            combocafe.Items.Clear();
            combocafe.Items.Add("Con leche");
            combocafe.Items.Add("Cortado");
            combocafe.Items.Add("Solo");
            combocafe.Items.Add("Descafeinado");
        }
        double preciopostre = 0;
        public void combopostre_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
          
            string texto = combopostre.Text;
            //
            if(texto == "Fruta / Yogurt")
                { preciopostre = 1.5; }
            if (texto == "Brownie Chocolate con helado")
            { preciopostre = 3.5; }
            if (texto == "Tarta de Santiago")
            { preciopostre = 3.5; }
            if (texto == "Tarta semifria de chocolate y queso")
            { preciopostre = 3.5; }
            label11.Visible = true;
            lblpreciopostre.Text=Convert.ToString(preciopostre);
        }
        double preciocafe = 0;
        public void combocafe_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
           preciocafe = 1;
            //
            label8.Visible = true;
           lblpreciocafe.Text=Convert.ToString(preciocafe);
        }




        double preciobebida = 0;
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            preciobebida = 1;
            lblpreciobebida.Text = Convert.ToString(preciobebida);
        }

      
        
        
        
        
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            preciobebida = 0.70;
            lblpreciobebida.Text = Convert.ToString(preciobebida);
        }
     
    
        
        
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
             preciobebida = 10;
            lblpreciobebida.Text = Convert.ToString(preciobebida);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total = 0;
            double siniva = 0;

            label12.Visible = true;
            total = preciobebida + precioplatoprinci + preciosegundo + preciocafe + preciopostre;
            siniva = total;
            total = total * 0.1 + total;
            lblpreciototal.Text = Convert.ToString(total);
            MessageBox.Show(Convert.ToString(siniva),"Precio sin iva");
            
        }
    }
}
