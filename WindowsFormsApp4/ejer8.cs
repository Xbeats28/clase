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
    public partial class ejer8 : Form
    {
        public ejer8()
        {
            InitializeComponent();
            
        }
       

        private void btn2_Click(object sender, EventArgs e)
        {
           
            textBox1.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn0.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn1.Text;
        }

       

        private void btnpunto_Click(object sender, EventArgs e)
        {
            textBox1.Text += btnpunto.Text;
        }




        //**********************************************************





        private void btnsumar_Click(object sender, EventArgs e)
        {
            textBox1.Text += btnsumar.Text;
        }
        private void btndiv_Click(object sender, EventArgs e)
        {
            textBox1.Text += btndiv.Text;
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            textBox1.Text += btnmenos.Text;
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            textBox1.Text += btnmul.Text;
        }

        private void btnporcent_Click(object sender, EventArgs e)
        {
            textBox1.Text += btnporcent.Text;
        }



        //RESULTADO
        
        private void btnigual_Click(object sender, EventArgs e)
        {//variables
            double resultado = 0;
            int contador = 0;
            string texto = textBox1.Text;
            string[] trozos = new string[10];
            //

            //corto el string del texto donde haya signos para separar cada cifra
            trozos=texto.Split('+','-','/','*','%');
            //transformo las cifras en double
            double[] cachos = new double[10];
            for(int i = 0; i<trozos.Length;i++ )
            {// mientras que el trozo tenga algo se realiza el cambio
                if (trozos[i]!=null)
                {
                    cachos[i] =  Convert.ToDouble(trozos[i]);
                    
                }

            }
            //operaciones
            if(texto.Contains("+"))
            {

                resultado = cachos[0] + cachos[1];

            }
            else if (texto.Contains("-"))
            {

                resultado = cachos[0] - cachos[1];

            }
            else if (texto.Contains("*"))
            {

                resultado = cachos[0] * cachos[1];

            }
            else if (texto.Contains("/"))
            {

                resultado = cachos[0] / cachos[1];

            }


            lblresult.Text= resultado.ToString();    
            //esto le añade un signo de igual a la texbox
            textBox1.Text += btnigual.Text;
        }



        //botones de limpieza


        private void btnc_Click(object sender, EventArgs e)
        {
            //texto2 es un substring de texto 1 o que hace es coge todos los caracteres menos el ultimo
            string texto1 = textBox1.Text;
            string texto2= texto1.Substring(0, texto1.Length - 1);//al colocar el 0 le estamos diciendo
          //que qeuremos empezar a seccionar desde el 1º caracter si le pusieramos 1 desde el 2º
            textBox1.Text = texto2;
            
        }

        private void btnce_Click(object sender, EventArgs e)
        {
            //pone el texto el label y texbox en nada
            lblresult.Text = "";
            textBox1.Text = "";
        }





    }
}
