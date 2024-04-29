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
    public partial class ejer10 : Form
    {
        public ejer10()
        {
            InitializeComponent();
        }
        int contador = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            contador++;
            if(contador  == 3 || contador == 1||contador==5||contador==7 || contador ==9) 
            {
                button1.Text = "X";
                  
            }
           else if (contador %2==0)
            {
                button1.Text = "O";

            }
            else if(contador==10)
            {
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";

                if(button1.Text=="X"&&button2.Text=="X"&&button3.Text=="X")
                {
                    MessageBox.Show("X gana", "GANADOR");

                }
               else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
                {
                    MessageBox.Show("O gana", "GANADOR");

                }
               
                
                if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
                {
                    MessageBox.Show("X gana", "GANADOR");

                }
                else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
                {
                    MessageBox.Show("O gana", "GANADOR");

                }
               
                
                if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
                {
                    MessageBox.Show("X gana", "GANADOR");

                }
                else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
                {
                    MessageBox.Show("O gana", "GANADOR");

                }

                if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
                {
                    MessageBox.Show("X gana", "GANADOR");

                }
                else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
                {
                    MessageBox.Show("O gana", "GANADOR");

                }


                if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
                {
                    MessageBox.Show("X gana", "GANADOR");

                }
                else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
                {
                    MessageBox.Show("O gana", "GANADOR");

                }


                if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                {
                    MessageBox.Show("X gana", "GANADOR");

                }
                else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                {
                    MessageBox.Show("O gana", "GANADOR");

                }


                if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
                {
                    MessageBox.Show("X gana", "GANADOR");

                }
                else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
                {
                    MessageBox.Show("O gana", "GANADOR");

                }


                if (button7.Text == "X" && button5.Text == "X" && button3.Text == "X")
                {
                    MessageBox.Show("X gana", "GANADOR");

                }
                else if (button7.Text == "O" && button5.Text == "O" && button3.Text == "O")
                {
                    MessageBox.Show("O gana", "GANADOR");

                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            contador++;
            if (contador == 3 || contador == 1 || contador == 5 || contador == 7 || contador == 9)
            {
                button2.Text = "X";

            }
            else if (contador % 2 == 0)
            {
                button2.Text = "O";

            }
            else if (contador == 10)
            {
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";

            }
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }

            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button7.Text == "X" && button5.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button7.Text == "O" && button5.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            contador++;
            if (contador == 3 || contador == 1 || contador == 5 || contador == 7 || contador == 9)
            {
                button3.Text = "X";

            }
            else if (contador % 2 == 0)
            {
                button3.Text = "O";

            }
            else if (contador == 10)
            {
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";

            }
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }

            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button7.Text == "X" && button5.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button7.Text == "O" && button5.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            contador++;
            if (contador == 3 || contador == 1 || contador == 5 || contador == 7 || contador == 9)
            {
                button4.Text = "X";

            }
            else if (contador % 2 == 0)
            {
                button4.Text = "O";

            }
            else if (contador == 10)
            {
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";

            }
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }

            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button7.Text == "X" && button5.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button7.Text == "O" && button5.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            contador++;
            if (contador == 3 || contador == 1 || contador == 5 || contador == 7 || contador == 9)
            {
                button5.Text = "X";

            }
            else if (contador % 2 == 0)
            {
                button5.Text = "O";

            }
            else if (contador == 10)
            {
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";

            }
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }

            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button7.Text == "X" && button5.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button7.Text == "O" && button5.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            contador++;
            if (contador == 3 || contador == 1 || contador == 5 || contador == 7 || contador == 9)
            {
                button6.Text = "X";

            }
            else if (contador % 2 == 0)
            {
                button6.Text = "O";

            }
            else if (contador == 10)
            {
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";

            }
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }

            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button7.Text == "X" && button5.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button7.Text == "O" && button5.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            contador++;
            if (contador == 3 || contador == 1 || contador == 5 || contador == 7 || contador == 9)
            {
                button7.Text = "X";

            }
            else if (contador % 2 == 0)
            {
                button7.Text = "O";

            }
            else if (contador == 10)
            {
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";

            }
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }

            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button7.Text == "X" && button5.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button7.Text == "O" && button5.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            contador++;
            if (contador == 3 || contador == 1 || contador == 5 || contador == 7 || contador == 9)
            {
                button8.Text = "X";

            }
            else if (contador % 2 == 0)
            {
                button8.Text = "O";

            }
            else if (contador == 10)
            {
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";

            }
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }

            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button7.Text == "X" && button5.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button7.Text == "O" && button5.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }




        }

        private void button9_Click(object sender, EventArgs e)
        {
            contador++;
            if (contador == 3 || contador == 1 || contador == 5 || contador == 7 || contador == 9)
            {
                button9.Text = "X";

            }
            else if (contador % 2 == 0)
            {
                button9.Text = "O";

            }
            else if (contador == 10)
            {
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";

            }
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }

            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }


            if (button7.Text == "X" && button5.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("X gana", "GANADOR");

            }
            else if (button7.Text == "O" && button5.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("O gana", "GANADOR");

            }

        }
    }
}
