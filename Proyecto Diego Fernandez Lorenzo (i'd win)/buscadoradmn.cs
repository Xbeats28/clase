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
                if (b != null)
                {
                    string[] cachos = b.Split('-');

                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    label4.Visible = true;
                    label5.Visible = false;
                    label6.Visible = false;

                    label9.Visible = true;
                    label10.Visible = false;
                    label11.Visible = false;

                    label12.Visible = true;
                    label13.Visible = false;
                    label14.Visible = false;


                    label6.Text = cachos[0] + " Codigo: " + cachos[5];
                    label9.Text = "Marca: " + cachos[1];
                    label12.Text = "Descripcion: " + cachos[4] + " " + cachos[3] + "$";
                }
                a.Close();

            }
            if (comboBox1.SelectedIndex == 1)
            {
                StreamReader a = new StreamReader(ruta, true);
                string b = a.ReadLine();
                string c = a.ReadLine();
                if (c != null)
                {
                    string[] cachos = c.Split('-');
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = true;
                    label6.Visible = false;

                    label9.Visible = false;
                    label10.Visible = true;
                    label11.Visible = false;

                    label12.Visible = false;
                    label13.Visible = true;
                    label14.Visible = false;


                    label5.Text = cachos[0] + " Codigo: " + cachos[5];
                    label10.Text = "Marca: " + cachos[1];
                    label13.Text = "Descripcion: " + cachos[4] + " " + cachos[3] + "$";
                }
                a.Close();

            }
            if (comboBox1.SelectedIndex == 2)
            {
                StreamReader a = new StreamReader(ruta, true);
                string b = a.ReadLine();
                string c = a.ReadLine();
                string d = a.ReadLine();
                if (d != null)
                {
                    string[] cachos = d.Split('-');
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = true;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = true;

                    label9.Visible = false;
                    label10.Visible = false;
                    label11.Visible = true;

                    label12.Visible = false;
                    label13.Visible = false;
                    label14.Visible = true;


                    label6.Text = cachos[0] + " Codigo: " + cachos[5];
                    label11.Text = "Marca: " + cachos[1];
                    label14.Text = "Descripcion: " + cachos[4] + " " + cachos[3] + "$";
                }
                a.Close();

            }
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {


                StreamReader a = new StreamReader(ruta, true);
                string b = a.ReadLine();
                if (b != null)
                {
                    string[] cachos = b.Split('-');

                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    label4.Visible = true;
                    label5.Visible = false;
                    label6.Visible = false;

                    label9.Visible = true;
                    label10.Visible = false;
                    label11.Visible = false;

                    label12.Visible = true;
                    label13.Visible = false;
                    label14.Visible = false;


                    label6.Text = cachos[0] + " Codigo: " + cachos[5];
                    label9.Text = "Marca: " + cachos[1];
                    label12.Text = "Descripcion: " + cachos[4] + " " + cachos[3] + "$";
                }
                a.Close();

            }
            if (comboBox2.SelectedIndex == 1)
            {
                StreamReader a = new StreamReader(ruta, true);
                string b = a.ReadLine();
                string c = a.ReadLine();

                if (c != null)
                {

                    string[] cachos = c.Split('-');
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = true;
                    label6.Visible = false;

                    label9.Visible = false;
                    label10.Visible = true;
                    label11.Visible = false;

                    label12.Visible = false;
                    label13.Visible = true;
                    label14.Visible = false;


                    label5.Text = cachos[0] + " Codigo: " + cachos[5];
                    label10.Text = "Marca: " + cachos[1];
                    label13.Text = "Descripcion: " + cachos[4] + " " + cachos[3] + "$";
                }
                a.Close();

            }
            if (comboBox2.SelectedIndex == 2)
            {
                StreamReader a = new StreamReader(ruta, true);
                string b = a.ReadLine();
                string c = a.ReadLine();
                string d = a.ReadLine();
                if (d != null)
                {
                    string[] cachos = d.Split('-');
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = true;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = true;

                    label9.Visible = false;
                    label10.Visible = false;
                    label11.Visible = true;

                    label12.Visible = false;
                    label13.Visible = false;
                    label14.Visible = true;


                    label6.Text = cachos[0] + " Codigo: " + cachos[5];
                    label11.Text = "Marca: " + cachos[1];
                    label14.Text = "Descripcion: " + cachos[4] + " " + cachos[3] + "$";
                }
                a.Close();
            }
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
                string[] cachos = a.Split('-');

                if (cachos[5] == texto)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                label4.Visible = true;
                label5.Visible = false;
                label6.Visible = false; 

                label9.Visible = true;
                label10.Visible = false;
                label11.Visible = false;

                label12.Visible = true;
                label13.Visible = false;
                label14.Visible = false;

                
                label4.Text = cachos[0] + " Codigo: " + cachos[5];
                label9.Text = "Marca: " + cachos[1];
                label12.Text = "Descripcion: " + cachos[4] + " " + cachos[3]+"$";

                aa = false;
            }
           
            }



            if (b != null)
            {
                string[] cachos = b.Split('-');

                if (cachos[5] == texto)
                {

                    pictureBox1.Visible = false;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = true;
                    label6.Visible = false; 

                    label9.Visible = false;
                    label10.Visible = true;
                    label11.Visible = false;

                    label12.Visible = false;
                    label13.Visible = true;
                    label14.Visible = false;

            
                    label5.Text = cachos[0] + " Codigo: " + cachos[5];
                    label10.Text = "Marca: " + cachos[1];
                    label13.Text = "Descripcion: " + cachos[4] + " " + cachos[3] + "$";

                    aa = false;
                }
              
            }

            if (c != null)
            {
                string[] cachos = c.Split('-');

                if (cachos[5] == texto)
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = true;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = true; 

                    label9.Visible = false;
                    label10.Visible = false;
                    label11.Visible = true;

                    label12.Visible = false;
                    label13.Visible = false;
                    label14.Visible = true;

                   
                    label6.Text = cachos[0] + " Codigo: " + cachos[5];
                    label11.Text = "Marca: " + cachos[1];
                    label14.Text = "Descripcion: " + cachos[4] + " " + cachos[3] + "$";
                    aa = false;

                }

               


            }
            if (aa) { MessageBox.Show("No se encontraron referencias", "ERROR"); }
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

                    string[] cachos = a.Split('-');
                    if (cachos[5] ==texto)
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    label4.Visible = true;
                    label5.Visible = false;
                    label6.Visible = false; 

                    label9.Visible = true;
                    label10.Visible = false;
                    label11.Visible = false;

                    label12.Visible = true;
                    label13.Visible = false;
                    label14.Visible = false;

                   
                    label4.Text = cachos[0] + " Codigo: " + cachos[5];
                    label9.Text = "Marca: " + cachos[1];
                        label12.Text = "Descripcion: " + cachos[4] + " " + cachos[3] + "$";

                        aa = false;
                }
                   
                }


                if (b != null)
                {
                    string[] cachos = b.Split('-');

                    if (cachos[5] ==texto)
                    {
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = true;
                        pictureBox3.Visible = false;
                        label4.Visible = false;
                        label5.Visible = true;
                        label6.Visible = false; 

                        label9.Visible = false;
                        label10.Visible = true;
                        label11.Visible = false;

                        label12.Visible = false;
                        label13.Visible = true;
                        label14.Visible = false;

                       
                        label5.Text = cachos[0] + " Codigo: " + cachos[5];
                        label10.Text = "Marca: " + cachos[1];
                        label13.Text = "Descripcion: " + cachos[4] + " " + cachos[3] + "$";

                        aa = false;
                    }
                   
                }

                if (c != null)
                {
                    string[] cachos = c.Split('-');
                    if (cachos[5] ==texto)
                    {
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;
                        pictureBox3.Visible = true;
                        label4.Visible = false;
                        label5.Visible = false;
                        label6.Visible = true; 

                        label9.Visible = false;
                        label10.Visible = false;
                        label11.Visible = true;

                        label12.Visible = false;
                        label13.Visible = false;
                        label14.Visible = true;

                       
                        label6.Text = cachos[0] + " Codigo: " + cachos[5];
                        label11.Text = "Marca: " + cachos[1];
                        label14.Text = "Descripcion: " + cachos[4] +" "+ cachos[3] + "$";

                        aa = false;
                    }
                    
                }
                if (aa) { MessageBox.Show("No se encontraron referencias", "ERROR"); }
            }




             
        }

        public string aa = "";
        public string aaa = "";
        public string aaaa = "";
        public string[] cachos;
        public string[] cachos1;
        public string[] cachos2;

        public void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal a = numericUpDown1.Value;
            decimal b = numericUpDown2.Value;
            int precio1 = 0;
            int precio2 = 0;
            int precio3 = 0;
            int menor = 0;
            int mayor = 0;

            StreamReader lector = new StreamReader(ruta, true);
            aa = lector.ReadLine();
            aaa = lector.ReadLine();
            aaaa = lector.ReadLine();
            lector.Close();

            if (aa != null)
            {
                 cachos = aa.Split('-');
                precio1 = int.Parse(cachos[3]);
                menor = Convert.ToInt32(a);
                mayor = Convert.ToInt32(b);
            }
            if (aaa != null)
            {
                cachos1 = aaa.Split('-');
                precio2 = int.Parse(cachos1[3]);
                menor = Convert.ToInt32(a);
                mayor = Convert.ToInt32(b);
            }
            if (aaaa != null)
            {
                cachos2 = aaaa.Split('-');
                precio3 = int.Parse(cachos2[3]);
                menor = Convert.ToInt32(a);
                mayor = Convert.ToInt32(b);
            }


            
          
         


            if (precio1 > menor && precio1 < mayor)
            {






                pictureBox1.Visible = true;
                label4.Text = cachos[0] + " Codigo: " + cachos[5];
                label9.Text = "Marca: " + cachos[1];
                label12.Text = "Descripcion: " + cachos[4] + " " + cachos[3] + "$";

                if (precio2 >=menor && precio1 < mayor)
                {
                    pictureBox2.Visible = true;
                    label3.Text = cachos1[0] + " Codigo: " + cachos1[5];
                    label10.Text = "Marca: " + cachos1[1];
                    label13.Text = "Descripcion: " + cachos1[4] + " " + cachos1[3] + "$";



                }
                else if (precio3 < mayor && precio1 > menor)
                {
                    pictureBox3.Visible = true;
                    label4.Text = cachos2[0] + " Codigo: " + cachos2[5];
                    label11.Text = "Marca: " + cachos2[1];
                    label14.Text = "Descripcion: " + cachos2[4] + " " + cachos2[3] + "$";



                }




            }


            else if (precio2 > menor && precio2 < mayor)
            {
                pictureBox2.Visible = true;
                label3.Text = cachos1[0] + " Codigo: " + cachos1[5];
                label10.Text = "Marca: " + cachos1[1];
                label13.Text = "Descripcion: " + cachos1[4] + " " + cachos1[3] + "$";


                if (precio1 > menor && precio1 < mayor)
                {
                    pictureBox1.Visible = true;
                    label2.Text = cachos[0] + " Codigo: " + cachos[5];
                    label9.Text = "Marca: " + cachos[1];
                    label12.Text = "Descripcion: " + cachos[4] + " " + cachos[3] + "$";



                }
                else if (precio3 < mayor && precio1 > menor)
                {
                    pictureBox3.Visible = true;
                    label4.Text = cachos2[0] + " Codigo: " + cachos2[5];
                    label11.Text = "Marca: " + cachos2[1];
                    label14.Text = "Descripcion: " + cachos2[4] + " " + cachos2[3] + "$";



                }


            }

            else if (precio3 < mayor && precio1 > menor)
            {
                pictureBox3.Visible = true;
                label4.Text = cachos2[0] + " Codigo: " + cachos2[5];
                label11.Text = "Marca: " + cachos2[1];
                label14.Text = "Descripcion: " + cachos2[4] + " " + cachos2[3] + "$";

                if (precio1 > menor && precio1 < mayor)
                {
                    pictureBox1.Visible = true;
                    label2.Text = cachos[0] + " Codigo: " + cachos[5];
                    label9.Text = "Marca: " + cachos[1];
                    label12.Text = "Descripcion: " + cachos[4] + " " + cachos[3] + "$";



                }
                else if (precio2 < mayor && precio2 > menor)
                {
                    pictureBox2.Visible = true;
                    label3.Text = cachos1[0] + " Codigo: " + cachos1[5];
                    label10.Text = "Marca: " + cachos1[1];
                    label13.Text = "Descripcion: " + cachos1[4] + " " + cachos1[3] + "$";



                }

            }
            else
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;

                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;

                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
            }
        }


        public string aa1 = "";
        public string aaa1 = "";
        public string aaaa1 = "";
        public string[] cachos12;
        public string[] cachos13;
        public string[] cachos14;

        public void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            decimal a = numericUpDown1.Value;
            decimal b = numericUpDown2.Value;
            int precio1 = 0;
            int precio2 = 0;
            int precio3 = 0;
            int menor = 0;
            int mayor = 0;

            StreamReader lector = new StreamReader(ruta, true);
            string aa = lector.ReadLine();
            string aaa = lector.ReadLine();
            string aaaa = lector.ReadLine();
            lector.Close();
            if (aa != null)
            {
                cachos12 = aa.Split('-');
                precio1 = int.Parse(cachos12[3]);
            }
            if (aaa != null)
            {
                cachos13 = aaa.Split('-');
                precio2 = int.Parse(cachos13[3]);
            }
            if (aaaa != null)
            {
                cachos14 = aaaa.Split('-');
                precio3 = int.Parse(cachos14[3]);
            }


           
            
            
            menor = Convert.ToInt32(a);
            mayor = Convert.ToInt32(b);


            if (precio1 > menor && precio1 < mayor)
            {






                pictureBox1.Visible = true;
                label4.Text = cachos12[0] + " Codigo: " + cachos12[5];
                label9.Text = "Marca: " + cachos12[1];
                label12.Text = "Descripcion: " + cachos12[4] + " " + cachos12[3] + "$";

                  if (precio2 > menor && precio1 < mayor)
                {
                    pictureBox2.Visible = true;
                    label3.Text = cachos13[0] + " Codigo: " + cachos13[5];
                    label10.Text = "Marca: " + cachos13[1];
                    label13.Text = "Descripcion: " + cachos13[4] + " " + cachos13[3] + "$";



                }
                else if (precio3 < mayor && precio1 > menor)
                {
                    pictureBox3.Visible = true;
                    label4.Text = cachos14[0] + " Codigo: " + cachos14[5];
                    label11.Text = "Marca: " + cachos14[1];
                    label14.Text = "Descripcion: " + cachos14[4] + " " + cachos14[3] + "$";



                }




            }


            else if (precio2 > menor && precio2 < mayor)
            {
                pictureBox2.Visible = true;
                label3.Text = cachos1[0] + " Codigo: " + cachos1[5];
                label10.Text = "Marca: " + cachos1[1];
                label13.Text = "Descripcion: " + cachos1[4] + " " + cachos1[3] + "$";


                if (precio1 > menor && precio1 < mayor)
                {
                    pictureBox1.Visible = true;
                    label2.Text = cachos[0] + " Codigo: " + cachos[5];
                    label9.Text = "Marca: " + cachos[1];
                    label12.Text = "Descripcion: " + cachos[4] + " " + cachos[3] + "$";



                }
                else if (precio3 < mayor && precio1 > menor)
                {
                    pictureBox3.Visible = true;
                    label4.Text = cachos2[0] + " Codigo: " + cachos2[5];
                    label11.Text = "Marca: " + cachos2[1];
                    label14.Text = "Descripcion: " + cachos2[4] + " " + cachos2[3] + "$";



                }


            }

            else if (precio3 < mayor && precio1 > menor)
            {
                pictureBox3.Visible = true;
                label4.Text = cachos2[0] + " Codigo: " + cachos12[5];
                label11.Text = "Marca: " + cachos2[1];
                label14.Text = "Descripcion: " + cachos2[4] + " " + cachos2[3] + "$";

                if (precio1 > menor && precio1 < mayor)
                {
                    pictureBox1.Visible = true;
                    label2.Text = cachos[0] + " Codigo: " + cachos[5];
                    label9.Text = "Marca: " + cachos[1];
                    label12.Text = "Descripcion: " + cachos[4] + " " + cachos[3] + "$";



                }
                else if (precio2 < mayor && precio2 > menor)
                {
                    pictureBox2.Visible = true;
                    label3.Text = cachos1[0] + " Codigo: " + cachos1[5];
                    label10.Text = "Marca: " + cachos1[1];
                    label13.Text = "Descripcion: " + cachos1[4] + " " + cachos1[3] + "$";



                }

            }
            else
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;

                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;

                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Boolean aa = true;

            string texto = textBox2.Text;
            StreamReader s = new StreamReader(ruta, true);
            string a = s.ReadLine();
            string b = s.ReadLine();
            string c = s.ReadLine();


            s.Close();
           

            if (a != null)
            {
              
                string[] cachos = a.Split('-');
             

                if (texto == cachos[0])
                {
                  
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    label4.Visible = true;
                    label5.Visible = false;
                    label6.Visible = false;

                    label9.Visible = true;
                    label10.Visible = false;
                    label11.Visible = false;

                    label12.Visible = true;
                    label13.Visible = false;
                    label14.Visible = false;


                    label4.Text = cachos[0] + " Codigo: " + cachos[5];
                    label9.Text = "Marca: " + cachos[1];
                    label12.Text = "Descripcion: " + cachos[4] + " " + cachos[3] + "$";

                    aa = false;
                }

            }



            if (b != null)
            {
                string[] cachos = b.Split('-');

                if (cachos[0] == texto)
                {
                    
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = true;
                    label6.Visible = false;

                    label9.Visible = false;
                    label10.Visible = true;
                    label11.Visible = false;

                    label12.Visible = false;
                    label13.Visible = true;
                    label14.Visible = false;


                    label5.Text = cachos[0] + " Codigo: " + cachos[5];
                    label10.Text = "Marca: " + cachos[1];
                    label13.Text = "Descripcion: " + cachos[4] + " " + cachos[3] + "$";

                    aa = false;
                }

            }

            if (c != null)
            {
                string[] cachos = c.Split('-');

                if (cachos[0] == texto)
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = true;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = true;

                    label9.Visible = false;
                    label10.Visible = false;
                    label11.Visible = true;

                    label12.Visible = false;
                    label13.Visible = false;
                    label14.Visible = true;


                    label6.Text = cachos[0] + " Codigo: " + cachos[5];
                    label11.Text = "Marca: " + cachos[1];
                    label14.Text = "Descripcion: " + cachos[4] + " " + cachos[3] + "$";
                    aa = false;

                }




            }
          
           if (aa) { MessageBox.Show("No se encontraron referencias", "ERROR"); }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            Boolean aa = true;

            string texto = textBox2.Text;
            StreamReader s = new StreamReader(ruta, true);
            string a = s.ReadLine();
            string b = s.ReadLine();
            string c = s.ReadLine();


            s.Close();

            if (e.KeyCode == Keys.Enter)
            {

                if (a != null)
                {

                    string[] cachos = a.Split('-');
                    if (cachos[0] == texto)
                    {
                        pictureBox1.Visible = true;
                        pictureBox2.Visible = false;
                        pictureBox3.Visible = false;
                        label4.Visible = true;
                        label5.Visible = false;
                        label6.Visible = false;

                        label9.Visible = true;
                        label10.Visible = false;
                        label11.Visible = false;

                        label12.Visible = true;
                        label13.Visible = false;
                        label14.Visible = false;


                        label4.Text = cachos[0] + " Codigo: " + cachos[5];
                        label9.Text = "Marca: " + cachos[1];
                        label12.Text = "Descripcion: " + cachos[4] + " " + cachos[3] + "$";

                        aa = false;
                    }

                }


                if (b != null)
                {
                    string[] cachos = b.Split('-');

                    if (cachos[0] == texto)
                    {
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = true;
                        pictureBox3.Visible = false;
                        label4.Visible = false;
                        label5.Visible = true;
                        label6.Visible = false;

                        label9.Visible = false;
                        label10.Visible = true;
                        label11.Visible = false;

                        label12.Visible = false;
                        label13.Visible = true;
                        label14.Visible = false;


                        label5.Text = cachos[0] + " Codigo: " + cachos[5];
                        label10.Text = "Marca: " + cachos[1];
                        label13.Text = "Descripcion: " + cachos[4] + " " + cachos[3] + "$";

                        aa = false;
                    }

                }

                if (c != null)
                {
                    string[] cachos = c.Split('-');
                    if (cachos[0] == texto)
                    {
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;
                        pictureBox3.Visible = true;
                        label4.Visible = false;
                        label5.Visible = false;
                        label6.Visible = true;

                        label9.Visible = false;
                        label10.Visible = false;
                        label11.Visible = true;

                        label12.Visible = false;
                        label13.Visible = false;
                        label14.Visible = true;


                        label6.Text = cachos[0] + " Codigo: " + cachos[5];
                        label11.Text = "Marca: " + cachos[1];
                        label14.Text = "Descripcion: " + cachos[4] + " " + cachos[3] + "$";

                        aa = false;
                    }

                }
                if (aa) { MessageBox.Show("No se encontraron referencias", "ERROR"); }
            }


            }

        private void button2_Click(object sender, EventArgs e)
        {
         
            string texto = textBox2.Text;
            StreamReader s = new StreamReader(ruta, true);
            string a = s.ReadLine();
            string b = s.ReadLine();
            string c = s.ReadLine();


            s.Close();
            string[] cachos = a.Split('-');
            MessageBox.Show("Mandando un " + cachos[0], "Recibido");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string texto = textBox2.Text;
            StreamReader s = new StreamReader(ruta, true);
            string a = s.ReadLine();
            string b = s.ReadLine();
            string c = s.ReadLine();


            s.Close();
            string[] cachos = b.Split('-');
            MessageBox.Show("Mandando un " + cachos[0], "Recibido");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string texto = textBox2.Text;
            StreamReader s = new StreamReader(ruta, true);
            string a = s.ReadLine();
            string b = s.ReadLine();
            string c = s.ReadLine();


            s.Close();
            string[] cachos = c.Split('-');
            MessageBox.Show("Mandando un " + cachos[0], "Recibido" );
        }
    }
}
