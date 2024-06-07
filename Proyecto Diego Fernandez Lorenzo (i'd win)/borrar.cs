using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class borrar : Form
    {
        public borrar()
        {
            InitializeComponent();
        }
        public static string ruta = Directory.GetCurrentDirectory() + "datos2.txt";


        private void button1_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
        
            StreamReader s = new StreamReader(ruta,true);
            string a = s.ReadLine();
            string b = s.ReadLine();
            string c = s.ReadLine();

          
            
          
            s.Close();
            if(a!= null)
            {
                string[] cachos = a.Split('-');
                if (cachos[5]==texto)
                {
                    var lines = File.ReadAllLines(ruta).ToList();

                    // Eliminar líneas específicas (por ejemplo, eliminar todas las líneas que contienen "eliminar")
                    lines = lines.Where(line => !line.Contains(texto)).ToList();

                    // Escribir el contenido modificado de nuevo en el fichero
                    File.WriteAllLines(ruta, lines);
                    MessageBox.Show("Eliminado", "Exito");
                    textBox1.Text = "";
                }


            }
           

            else if (b != null)
            {
                string[] cachos1 = b.Split('-');
                if (cachos1[5] == texto)
                {
                   
                    var lines = File.ReadAllLines(ruta).ToList();

                    // Eliminar líneas específicas (por ejemplo, eliminar todas las líneas que contienen "eliminar")
                    lines = lines.Where(line => !line.Contains(texto)).ToList();

                    // Escribir el contenido modificado de nuevo en el fichero
                    File.WriteAllLines(ruta, lines);
                    MessageBox.Show("Eliminado", "Exito");
                    textBox1.Text = "";
                }


            }
           
         else    if (c != null)
            {
                string[] cachos2 = c.Split('-');
                if (cachos2[5] == texto)
                {
                    var lines = File.ReadAllLines(ruta).ToList();

                    // Eliminar líneas específicas (por ejemplo, eliminar todas las líneas que contienen "eliminar")
                    lines = lines.Where(line => !line.Contains(texto)).ToList();

                    // Escribir el contenido modificado de nuevo en el fichero
                    File.WriteAllLines(ruta, lines);
                    MessageBox.Show("Eliminado", "Exito");
                    textBox1.Text = "";
                }


            }
            else { MessageBox.Show("No encontrado", "Falso"); }

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Enter)
            {
                string texto = textBox1.Text;

                StreamReader s = new StreamReader(ruta, true);
                string a = s.ReadLine();
                string b = s.ReadLine();
                string c = s.ReadLine();

               
               
              
                s.Close();
                if (a != null)
                {
                    string[] cachos = a.Split('-');
                    if (cachos[5] == texto)
                    {
                        var lines = File.ReadAllLines(ruta).ToList();

                        // Eliminar líneas específicas (por ejemplo, eliminar todas las líneas que contienen "eliminar")
                        lines = lines.Where(line => !line.Contains(texto)).ToList();

                        // Escribir el contenido modificado de nuevo en el fichero
                        File.WriteAllLines(ruta, lines);
                        MessageBox.Show("Eliminado", "Exito");
                        textBox1.Text = "";
                    }


                }
             

             else   if (b != null)
                {
                    string[] cachos1 = b.Split('-');
                    if (cachos1[5] == texto)
                    {
                        var lines = File.ReadAllLines(ruta).ToList();

                        // Eliminar líneas específicas (por ejemplo, eliminar todas las líneas que contienen "eliminar")
                        lines = lines.Where(line => !line.Contains(texto)).ToList();

                        // Escribir el contenido modificado de nuevo en el fichero
                        File.WriteAllLines(ruta, lines);
                        MessageBox.Show("Eliminado", "Exito");
                        textBox1.Text = "";
                    }


                }
               
               else if (c != null)
                {
                    string[] cachos2 = c.Split('-');
                    if (cachos2[5] == texto)
                    {
                        var lines = File.ReadAllLines(ruta).ToList();

                        // Eliminar líneas específicas (por ejemplo, eliminar todas las líneas que contienen "eliminar")
                        lines = lines.Where(line => !line.Contains(texto)).ToList();

                        // Escribir el contenido modificado de nuevo en el fichero
                        File.WriteAllLines(ruta, lines);
                        MessageBox.Show("Eliminado", "Exito");
                        textBox1.Text = "";
                    }


                }
                else { MessageBox.Show("No encontrado", "Falso"); }

            }

        }
    }
}
