using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class ejer9 : Form
    {
        public ejer9()
        {
            InitializeComponent();
        }
        string ruta = Directory.GetCurrentDirectory() + "\\Datos9.txt";
        


        private void btnguardardatos_Click(object sender, EventArgs e)
        {
            string correo1 = txtcorreo.Text;
            string[] dominio=correo1.Split('.');


            

            if(txtnombre.Text!=null&&txtapellidos.Text!=null&&txtedad.Text!=null&&txtcorreo!=null&&txtdni!=null) 
            {
                if(double.Parse(txtedad.Text)>18)
                {
                    if (dominio[1] == "com" || dominio[1] == "org" || dominio[1] == "io")
                    {


                    }
                    else { MessageBox.Show("Introduzca un dominio correcto", "Fallo"); }

                }
                else { MessageBox.Show("Debes se mayor de edad", "Fallo"); }

            }
            else { MessageBox.Show("Introduzca todos Los datos necesarios","Fallo"); }



            string textoompleto = txtnombre.Text + '/' + txtapellidos.Text + '/' + txtedad.Text + '/' + txtcorreo.Text + '/' + txtdni.Text + '/' + txtedad.Text;
            StreamWriter escritor = new StreamWriter(ruta,true);
            escritor.WriteLine(textoompleto);
            escritor.Close();

        }
    }
}
