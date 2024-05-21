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
    public partial class ejer5 : Form
    {
        public ejer5()
        {
            InitializeComponent();
        }


        int contadornoche = 0;
        int contadordia = 0;
        private void comboselector_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            //Recojo lo que el usuario escogio en la combobox en seleccion
            string seleccion = comboselector.Text; 
            string nombre = textBox1.Text;
            //

            //aqui veo si lo que escogio es malana o tarde  segun lo que sea lo añade en una listbox u otra
            if(seleccion =="Mañana")
            {
                listBox1.Items.Add(nombre);
                contadordia++;
            }
            if (seleccion == "Tarde")
            {
                listBox2.Items.Add(nombre);
                contadornoche++;
            }
            textBox3.Text = Convert.ToString(contadornoche);
            textBox2.Text = Convert.ToString(contadordia);

        }

       

        private void btnmovernoche1_Click(object sender, EventArgs e)
        {

            //
        
                string sss = listBox1.SelectedItem.ToString();
     

                //
               
                    listBox2.Items.Add(sss);
                    listBox1.Items.Remove(sss);
            contadordia--;
            contadornoche++;
            textBox3.Text = Convert.ToString(contadornoche);
            textBox2.Text = Convert.ToString(contadordia);
        }

        private void btnmovermañana1_Click(object sender, EventArgs e)
        {
            //


            string sss = listBox2.SelectedItem.ToString();

            //

            listBox1.Items.Add(sss);
            listBox2.Items.Remove(sss);
            contadornoche--;
            contadordia++;
            textBox3.Text = Convert.ToString(contadornoche);
            textBox2.Text = Convert.ToString(contadordia);
        }

        private void btnmovernocchetodos_Click(object sender, EventArgs e)
        {
            //
           List<string>lista = new List<string>();
            //
           

            //copio los elementos de listbox1 en lista
            foreach(string s in listBox1.Items)
            {
                lista.Add(s);

            }
            //limpio las listbox1
            listBox1.Items.Clear();
          
            //plasmo la lista en listbox2
            foreach (string s in lista)
            {
                listBox2.Items.Add(s);
                contadornoche++;
            }
            contadordia = 0;
            textBox3.Text = Convert.ToString(contadornoche);
            textBox2.Text = Convert.ToString(contadordia);
        }

        private void btnmovermañanatodos_Click(object sender, EventArgs e)
        {
            //
            List<string> lista = new List<string>();
           
            //


            //copio los elementos de listbox2 en lista
            foreach (string s in listBox2.Items)
            {
                lista.Add(s);

            }
            //limpio las listbox2
            listBox2.Items.Clear();

            //plasmo la lista en listbox1
            foreach (string s in lista)
            {
                listBox1.Items.Add(s);
                contadordia++;
            }
            contadornoche = 0;
            textBox3.Text = Convert.ToString(contadornoche);
            textBox2.Text = Convert.ToString(contadordia);
        }
    }
}
