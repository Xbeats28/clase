﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //para abrir los ejers lo que hago es declarar los forms como variables e iniciarlas(creo)
        private void button1_Click(object sender, EventArgs e)
        {
            ejer s = new ejer();
           s.ShowDialog();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            ejer2 ejer2 = new ejer2();
            ejer2.ShowDialog();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            ejer5 s = new ejer5();
            s.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ejer6 s = new ejer6();
            s.ShowDialog();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            ejer7 s = new ejer7();
            s.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ejer3 s = new ejer3();
            s.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ejer4 s = new ejer4();
            s.ShowDialog();




        }

        private void button8_Click(object sender, EventArgs e)
        {
            ejer8 s = new ejer8();
            s.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ejer9 s = new ejer9(); 
            s.ShowDialog();
        }
    }
}