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

namespace WindowsFormsApp7
{
    public partial class buscadoradmn : Form
    {
        public buscadoradmn()
        {
            InitializeComponent();
        }
        public static string ruta = Directory.GetCurrentDirectory() + "datos2.txt";
       
        


        private void buscadoradmn_Load(object sender, EventArgs e)
        {
            StreamReader s = new StreamReader(ruta);
            string a = s.ReadLine();
            string b = s.ReadLine();
            string c = s.ReadLine();
            if (a != null && b !=null  && c !=null )
            {
                string[] cachos = a.Split('-');
                string[] cachos1 = b.Split('-');
                string[] cachos2 = c.Split('-');
               
                if (a != "")
                {
                    comboBox1.Items.Add(cachos[1]);
                    comboBox2.Items.Add(cachos[2]);
                }
                if (b != "")
                {
                    comboBox1.Items.Add(cachos1[1]);
                    comboBox2.Items.Add(cachos1[2]);
                }
                if (c != "")
                {
                    comboBox1.Items.Add(cachos2[1]);
                    comboBox2.Items.Add(cachos2[2]);
                }

               







            }
            s.Close();



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {

               
                StreamReader a = new StreamReader(ruta, true);
                string b = a.ReadLine();
                string[] cachos = b.Split('-');
                
                label4.Visible = true;
                label5.Visible = false;
                label6.Visible = false;
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                label4.Text = cachos[0] +" Codigo:"+ cachos[5];
               a.Close();

            }
            if (comboBox1.SelectedIndex == 1)
            {
                StreamReader a = new StreamReader(ruta, true);
                string b = a.ReadLine();
                string c = a.ReadLine();
                string[] cachos = c.Split('-');
                label4.Visible = false;
                label5.Visible = true;
                label6.Visible = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                label4.Text = a.ReadLine();
                label5.Text = cachos[0] + " Codigo:" + cachos[5];
                a.Close();

            }
            if (comboBox1.SelectedIndex == 2)
            {
                StreamReader a = new StreamReader(ruta, true);
                string b = a.ReadLine();
                string c = a.ReadLine();
                string d = a.ReadLine();
                string[] cachos = d.Split('-');
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                label4.Text = a.ReadLine();
                label5.Text = a.ReadLine();
                label6.Text = cachos[0] + " Codigo:" + cachos[5];
                a.Close();

            }
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {

            Boolean aa = true;

            string texto = textBox1.Text;
            StreamReader s = new StreamReader(ruta, true);
            string a = s.ReadLine();
            string b = s.ReadLine();
            string c = s.ReadLine();
          
            s.Close();
            if (a != null) {
                if (a.Contains(texto))
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    label4.Visible = true;
                    label5.Visible = false;
                    label6.Visible = false; ;
                    string[] cachos = a.Split('-');
                    label4.Text = cachos[0] + " Codigo: " + cachos[5];
                    aa = false;



                }
            }


            if (b != null)
            {
                if (b.Contains(texto))
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = true;
                    label6.Visible = false; ;
                    string[] cachos = b.Split('-');
                    label5.Text = cachos[0] + " Codigo: " + cachos[5];
                    aa = false;

                }
            }

            if (c != null)
            {
                if (c.Contains(texto))
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = true;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = true; ;
                    string[] cachos = c.Split('-');
                    label6.Text = cachos[0] + " Codigo: " + cachos[5];
                    aa = false;
                }
            }

            else if ( aa){ MessageBox.Show("No se encontraron referencias", "ERROR"); }

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            Boolean aa = true;

            string texto = textBox1.Text;
            StreamReader s = new StreamReader(ruta, true);
            string a = s.ReadLine();
            string b = s.ReadLine();
            string c = s.ReadLine();

            
            s.Close();

            if (e.KeyCode == Keys.Enter)
            {

                if (a != null)
                {
                    if (a.Contains(texto))
                    {
                        pictureBox1.Visible = true;
                        pictureBox2.Visible = false;
                        pictureBox3.Visible = false;
                        label4.Visible = true;
                        label5.Visible = false;
                        label6.Visible = false; ;
                        string[] cachos = a.Split('-');
                        label4.Text = cachos[0] + " Codigo: " + cachos[5];
                        aa = false;



                    }
                }


                if (b != null)
                {
                    if (b.Contains(texto))
                    {
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = true;
                        pictureBox3.Visible = false;
                        label4.Visible = false;
                        label5.Visible = true;
                        label6.Visible = false; ;
                        string[] cachos = b.Split('-');
                        label5.Text = cachos[0] + " Codigo: " + cachos[5];
                        aa = false;

                    }
                }

                if (c != null)
                {
                    if (c.Contains(texto))
                    {
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;
                        pictureBox3.Visible = true;
                        label4.Visible = false;
                        label5.Visible = false;
                        label6.Visible = true; ;
                        string[] cachos = c.Split('-');
                        label6.Text = cachos[0] + " Codigo: " + cachos[5];
                        aa = false;
                    }
                }

                else if (aa) { MessageBox.Show("No se encontraron referencias", "ERROR"); }

            }
        }
        

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
