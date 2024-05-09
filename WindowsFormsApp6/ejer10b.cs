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
    public partial class ejer10b : Form
    {
        public ejer10b()
        {
            InitializeComponent();
        }


        int contador = 1;
        Boolean aa = true;
        Boolean b = true;
        Boolean c = true;
        Boolean d = true;
        Boolean ee = true;
        Boolean f = true;
        Boolean g = true;
        Boolean h = true;
        Boolean i = true;
        int pos1 = 0;
        int pos2 = 0;
        int pos3 = 0;
        int pos4 = 0;
        private void button1_Click_1(object sender, EventArgs e)
        {




            //dependiendo de si es par o impar escribe una cosa
            if ((contador == 3 || contador == 1 || contador == 5 || contador == 7 || contador == 9) && aa == true)
            {
                contador++;
                aa = false;
                button1.Text = "X";

            }
            Random random = new Random();
            pos1 = random.Next(1, 9);
            contador++;
       Boolean pruebapos = false;
            for (; pruebapos == false;)
            {
                if (pos1 == 1 && aa == true)
                {
                    button1.Text = "O";
                    pruebapos = true;
                    aa = false;
                }
                if (pos1 == 2 && b == true)
                {
                    button2.Text = "O";
                    pruebapos = true;
                    b = false;
                }
                if (pos1 == 3 && c == true)
                {
                    button3.Text = "O";
                    pruebapos = true;
                    c = false;
                }
                if (pos1 == 4 && d == true)
                {
                    button4.Text = "O";
                    pruebapos = true;
                    d = false;
                }
                if (pos1 == 5 && ee == true)
                {
                    button5.Text = "O";
                    pruebapos = true;
                    ee = false;
                }
                if (pos1 == 6 && f == true)
                {
                    button6.Text = "O";
                    pruebapos = true;
                    f = false;
                }
                if (pos1 == 7 && g == true)
                {
                    button7.Text = "O";
                    pruebapos = true;
                    g = false;
                }
                if (pos1 == 8 && h == true)
                {
                    button8.Text = "O";
                    pruebapos = true;
                    h = false;
                }
                if (pos1 == 9 && i == true)
                {
                    button9.Text = "O";
                    pruebapos = true;
                    i = false;
                }


                //si el contador llega a 9 se cierra porque se entiende que ha acabado en empate 
                else if (contador == 10)
                {
                    ejer10 s = new ejer10();
                    s.Close();
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
                else { pos1 = random.Next(1, 9); }
            }
            //empezamos la validacion de datos y luego es lo mismo con el resto de botones
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
    


        private void button2_Click_1(object sender, EventArgs e)
        {




            //dependiendo de si es par o impar escribe una cosa
            if ((contador == 3 || contador == 1 || contador == 5 || contador == 7 || contador == 9) && b == true)
            {
                contador++;
                b = false;
                button2.Text = "X";

            }
            Random random = new Random();
            pos1 = random.Next(1, 9);
            contador++;
            Boolean pruebapos = false;
            for (; pruebapos == false;)
            {
                if (pos1 == 1 && aa == true)
                {
                    button1.Text = "O";
                    pruebapos = true;
                    aa = false;
                }
                if (pos1 == 2 && b == true)
                {
                    button2.Text = "O";
                    pruebapos = true;
                    b = false;
                }
                if (pos1 == 3 && c == true)
                {
                    button3.Text = "O";
                    pruebapos = true;
                    c = false;
                }
                if (pos1 == 4 && d == true)
                {
                    button4.Text = "O";
                    pruebapos = true;
                    d = false;
                }
                if (pos1 == 5 && ee == true)
                {
                    button5.Text = "O";
                    pruebapos = true;
                    ee = false;
                }
                if (pos1 == 6 && f == true)
                {
                    button6.Text = "O";
                    pruebapos = true;
                    f = false;
                }
                if (pos1 == 7 && g == true)
                {
                    button7.Text = "O";
                    pruebapos = true;
                    g = false;
                }
                if (pos1 == 8 && h == true)
                {
                    button8.Text = "O";
                    pruebapos = true;
                    h = false;
                }
                if (pos1 == 9 && i == true)
                {
                    button9.Text = "O";
                    pruebapos = true;
                    i = false;
                }


                //si el contador llega a 9 se cierra porque se entiende que ha acabado en empate 
                else if (contador == 10)
                {
                    ejer10 s = new ejer10();
                    s.Close();
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
                else { pos1 = random.Next(1, 9); }
            }
            //empezamos la validacion de datos y luego es lo mismo con el resto de botones
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

        

        private void button3_Click_1(object sender, EventArgs e)
        {
            //dependiendo de si es par o impar escribe una cosa
            if ((contador == 3 || contador == 1 || contador == 5 || contador == 7 || contador == 9) && c == true)
            {
                contador++;
                c = false;
                button3.Text = "X";

            }
            Random random = new Random();
            pos1 = random.Next(1, 9);
            contador++;
            Boolean pruebapos = false;
            for (; pruebapos == false;)
            {
                if (pos1 == 1 && aa == true)
                {
                    button1.Text = "O";
                    pruebapos = true;
                    aa = false;
                }
                if (pos1 == 2 && b == true)
                {
                    button2.Text = "O";
                    pruebapos = true;
                    b = false;
                }
                if (pos1 == 3 && c == true)
                {
                    button3.Text = "O";
                    pruebapos = true;
                    c = false;
                }
                if (pos1 == 4 && d == true)
                {
                    button4.Text = "O";
                    pruebapos = true;
                    d = false;
                }
                if (pos1 == 5 && ee == true)
                {
                    button5.Text = "O";
                    pruebapos = true;
                    ee = false;
                }
                if (pos1 == 6 && f == true)
                {
                    button6.Text = "O";
                    pruebapos = true;
                    f = false;
                }
                if (pos1 == 7 && g == true)
                {
                    button7.Text = "O";
                    pruebapos = true;
                    g = false;
                }
                if (pos1 == 8 && h == true)
                {
                    button8.Text = "O";
                    pruebapos = true;
                    h = false;
                }
                if (pos1 == 9 && i == true)
                {
                    button9.Text = "O";
                    pruebapos = true;
                    i = false;
                }


                //si el contador llega a 9 se cierra porque se entiende que ha acabado en empate 
                else if (contador == 10)
                {
                    ejer10 s = new ejer10();
                    s.Close();
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
                else { pos1 = random.Next(1, 9); }
            }
            //empezamos la validacion de datos y luego es lo mismo con el resto de botones
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

        

        private void button4_Click_1(object sender, EventArgs e)
        {
            //dependiendo de si es par o impar escribe una cosa
            if ((contador == 3 || contador == 1 || contador == 5 || contador == 7 || contador == 9) && d == true)
            {
                contador++;
                d = false;
                button4.Text = "X";

            }
            Random random = new Random();
            pos1 = random.Next(1, 9);
            contador++;
            Boolean pruebapos = false;
            for (; pruebapos == false;)
            {
                if (pos1 == 1 && aa == true)
                {
                    button1.Text = "O";
                    pruebapos = true;
                    aa = false;
                }
                if (pos1 == 2 && b == true)
                {
                    button2.Text = "O";
                    pruebapos = true;
                    b = false;
                }
                if (pos1 == 3 && c == true)
                {
                    button3.Text = "O";
                    pruebapos = true;
                    c = false;
                }
                if (pos1 == 4 && d == true)
                {
                    button4.Text = "O";
                    pruebapos = true;
                    d = false;
                }
                if (pos1 == 5 && ee == true)
                {
                    button5.Text = "O";
                    pruebapos = true;
                    ee = false;
                }
                if (pos1 == 6 && f == true)
                {
                    button6.Text = "O";
                    pruebapos = true;
                    f = false;
                }
                if (pos1 == 7 && g == true)
                {
                    button7.Text = "O";
                    pruebapos = true;
                    g = false;
                }
                if (pos1 == 8 && h == true)
                {
                    button8.Text = "O";
                    pruebapos = true;
                    h = false;
                }
                if (pos1 == 9 && i == true)
                {
                    button9.Text = "O";
                    pruebapos = true;
                    i = false;
                }


                //si el contador llega a 9 se cierra porque se entiende que ha acabado en empate 
                else if (contador == 10)
                {
                    ejer10 s = new ejer10();
                    s.Close();
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
                else { pos1 = random.Next(1, 9); }
            }
            //empezamos la validacion de datos y luego es lo mismo con el resto de botones
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
        

        private void button5_Click_1(object sender, EventArgs e)
        {
            //dependiendo de si es par o impar escribe una cosa
            if ((contador == 3 || contador == 1 || contador == 5 || contador == 7 || contador == 9) && ee == true)
            {
                contador++;
                ee = false;
                button5.Text = "X";

            }
            Random random = new Random();
            pos1 = random.Next(1, 9);
            contador++;
            Boolean pruebapos = false;
            for (; pruebapos == false;)
            {
                if (pos1 == 1 && aa == true)
                {
                    button1.Text = "O";
                    pruebapos = true;
                    aa = false;
                }
                if (pos1 == 2 && b == true)
                {
                    button2.Text = "O";
                    pruebapos = true;
                    b = false;
                }
                if (pos1 == 3 && c == true)
                {
                    button3.Text = "O";
                    pruebapos = true;
                    c = false;
                }
                if (pos1 == 4 && d == true)
                {
                    button4.Text = "O";
                    pruebapos = true;
                    d = false;
                }
                if (pos1 == 5 && ee == true)
                {
                    button5.Text = "O";
                    pruebapos = true;
                    ee = false;
                }
                if (pos1 == 6 && f == true)
                {
                    button6.Text = "O";
                    pruebapos = true;
                    f = false;
                }
                if (pos1 == 7 && g == true)
                {
                    button7.Text = "O";
                    pruebapos = true;
                    g = false;
                }
                if (pos1 == 8 && h == true)
                {
                    button8.Text = "O";
                    pruebapos = true;
                    h = false;
                }
                if (pos1 == 9 && i == true)
                {
                    button9.Text = "O";
                    pruebapos = true;
                    i = false;
                }


                //si el contador llega a 9 se cierra porque se entiende que ha acabado en empate 
                else if (contador == 10)
                {
                    ejer10 s = new ejer10();
                    s.Close();
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
                else { pos1 = random.Next(1, 9); }
            }
            //empezamos la validacion de datos y luego es lo mismo con el resto de botones
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

        

        private void button6_Click_1(object sender, EventArgs e)
        {
            //dependiendo de si es par o impar escribe una cosa
            if ((contador == 3 || contador == 1 || contador == 5 || contador == 7 || contador == 9) && f == true)
            {
                contador++;
                f = false;
                button6.Text = "X";

            }
            Random random = new Random();
            pos1 = random.Next(1, 9);
            contador++;
            Boolean pruebapos = false;
            for (; pruebapos == false;)
            {
                if (pos1 == 1 && aa == true)
                {
                    button1.Text = "O";
                    pruebapos = true;
                    aa = false;
                }
                if (pos1 == 2 && b == true)
                {
                    button2.Text = "O";
                    pruebapos = true;
                    b = false;
                }
                if (pos1 == 3 && c == true)
                {
                    button3.Text = "O";
                    pruebapos = true;
                    c = false;
                }
                if (pos1 == 4 && d == true)
                {
                    button4.Text = "O";
                    pruebapos = true;
                    d = false;
                }
                if (pos1 == 5 && ee == true)
                {
                    button5.Text = "O";
                    pruebapos = true;
                    ee = false;
                }
                if (pos1 == 6 && f == true)
                {
                    button6.Text = "O";
                    pruebapos = true;
                    f = false;
                }
                if (pos1 == 7 && g == true)
                {
                    button7.Text = "O";
                    pruebapos = true;
                    g = false;
                }
                if (pos1 == 8 && h == true)
                {
                    button8.Text = "O";
                    pruebapos = true;
                    h = false;
                }
                if (pos1 == 9 && i == true)
                {
                    button9.Text = "O";
                    pruebapos = true;
                    i = false;
                }


                //si el contador llega a 9 se cierra porque se entiende que ha acabado en empate 
                else if (contador == 10)
                {
                    ejer10 s = new ejer10();
                    s.Close();
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
                else { pos1 = random.Next(1, 9); }
            }
            //empezamos la validacion de datos y luego es lo mismo con el resto de botones
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

        

        private void button7_Click_1(object sender, EventArgs e)
        {
            //dependiendo de si es par o impar escribe una cosa
            if ((contador == 3 || contador == 1 || contador == 5 || contador == 7 || contador == 9) && g == true)
            {
                contador++;
                aa = false;
                button7.Text = "X";

            }
            Random random = new Random();
            pos1 = random.Next(1, 9);
            contador++;
            Boolean pruebapos = false;
            for (; pruebapos == false;)
            {
                if (pos1 == 1 && aa == true)
                {
                    button1.Text = "O";
                    pruebapos = true;
                    aa = false;
                }
                if (pos1 == 2 && b == true)
                {
                    button2.Text = "O";
                    pruebapos = true;
                    b = false;
                }
                if (pos1 == 3 && c == true)
                {
                    button3.Text = "O";
                    pruebapos = true;
                    c = false;
                }
                if (pos1 == 4 && d == true)
                {
                    button4.Text = "O";
                    pruebapos = true;
                    d = false;
                }
                if (pos1 == 5 && ee == true)
                {
                    button5.Text = "O";
                    pruebapos = true;
                    ee = false;
                }
                if (pos1 == 6 && f == true)
                {
                    button6.Text = "O";
                    pruebapos = true;
                    f = false;
                }
                if (pos1 == 7 && g == true)
                {
                    button7.Text = "O";
                    pruebapos = true;
                    g = false;
                }
                if (pos1 == 8 && h == true)
                {
                    button8.Text = "O";
                    pruebapos = true;
                    h = false;
                }
                if (pos1 == 9 && i == true)
                {
                    button9.Text = "O";
                    pruebapos = true;
                    i = false;
                }


                //si el contador llega a 9 se cierra porque se entiende que ha acabado en empate 
                else if (contador == 10)
                {
                    ejer10 s = new ejer10();
                    s.Close();
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
                else { pos1 = random.Next(1, 9); }
            }
            //empezamos la validacion de datos y luego es lo mismo con el resto de botones
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

        

        private void button8_Click_1(object sender, EventArgs e)
        {
            //dependiendo de si es par o impar escribe una cosa
            if ((contador == 3 || contador == 1 || contador == 5 || contador == 7 || contador == 9) && h == true)
            {
                contador++;
                h = false;
                button1.Text = "X";

            }
            Random random = new Random();
            pos1 = random.Next(1, 9);
            contador++;
            Boolean pruebapos = false;
            for (; pruebapos == false;)
            {
                if (pos1 == 1 && aa == true)
                {
                    button1.Text = "O";
                    pruebapos = true;
                    aa = false;
                }
                if (pos1 == 2 && b == true)
                {
                    button2.Text = "O";
                    pruebapos = true;
                    b = false;
                }
                if (pos1 == 3 && c == true)
                {
                    button3.Text = "O";
                    pruebapos = true;
                    c = false;
                }
                if (pos1 == 4 && d == true)
                {
                    button4.Text = "O";
                    pruebapos = true;
                    d = false;
                }
                if (pos1 == 5 && ee == true)
                {
                    button5.Text = "O";
                    pruebapos = true;
                    ee = false;
                }
                if (pos1 == 6 && f == true)
                {
                    button6.Text = "O";
                    pruebapos = true;
                    f = false;
                }
                if (pos1 == 7 && g == true)
                {
                    button7.Text = "O";
                    pruebapos = true;
                    g = false;
                }
                if (pos1 == 8 && h == true)
                {
                    button8.Text = "O";
                    pruebapos = true;
                    h = false;
                }
                if (pos1 == 9 && i == true)
                {
                    button9.Text = "O";
                    pruebapos = true;
                    i = false;
                }


                //si el contador llega a 9 se cierra porque se entiende que ha acabado en empate 
                else if (contador == 10)
                {
                    ejer10 s = new ejer10();
                    s.Close();
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
                else { pos1 = random.Next(1, 9); }
            }
            //empezamos la validacion de datos y luego es lo mismo con el resto de botones
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

        

        private void button9_Click_1(object sender, EventArgs e)
        {
            //dependiendo de si es par o impar escribe una cosa
            if ((contador == 3 || contador == 1 || contador == 5 || contador == 7 || contador == 9))
            {
                contador++;
                i = false;
                button9.Text = "X";

            }
            Random random = new Random();
            pos1 = random.Next(1, 9);
            contador++;

            Boolean pruebapos = false;
            for (; pruebapos == false;)
            {
                if (pos1 == 1 && aa == true)
                {
                    button1.Text = "O";
                    pruebapos = true;
                    aa = false;
                }
                if (pos1 == 2 && b == true)
                {
                    button2.Text = "O";
                    pruebapos = true;
                    b = false;
                }
                if (pos1 == 3 && c == true)
                {
                    button3.Text = "O";
                    pruebapos = true;
                    c = false;
                }
                if (pos1 == 4 && d == true)
                {
                    button4.Text = "O";
                    pruebapos = true;
                    d = false;
                }
                if (pos1 == 5 && ee == true)
                {
                    button5.Text = "O";
                    pruebapos = true;
                    ee = false;
                }
                if (pos1 == 6 && f == true)
                {
                    button6.Text = "O";
                    pruebapos = true;
                    f = false;
                }
                if (pos1 == 7 && g == true)
                {
                    button7.Text = "O";
                    pruebapos = true;
                    g = false;
                }
                if (pos1 == 8 && h == true)
                {
                    button8.Text = "O";
                    pruebapos = true;
                    h = false;
                }
                if (pos1 == 9 && i == true)
                {
                    button9.Text = "O";
                    pruebapos = true;
                    i = false;
                }


                //si el contador llega a 9 se cierra porque se entiende que ha acabado en empate 
                else if (contador == 10)
                {
                    ejer10 s = new ejer10();
                    s.Close();
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
                else { pos1 = random.Next(1, 9); }
            }
            //empezamos la validacion de datos y luego es lo mismo con el resto de botones
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
    



