﻿using System;
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
    public partial class introduc : Form
    {
        public introduc()
        {
            InitializeComponent();
        }

       public static string ruta = Directory.GetCurrentDirectory()+"datos2.txt";
        private void button1_Click(object sender, EventArgs e)
        {

            if (txtproducto.Text == "")
            { MessageBox.Show( "Faltan cosas importantes","Fallo"); }
           else if (txtcodigo.Text == "")
            { MessageBox.Show("Faltan cosas importantes", "Fallo"); }
            else if (txtdescripcion.Text == "")
            { MessageBox.Show("Faltan cosas importantes", "Fallo"); }
            else if (txtmarca.Text == "")
            { MessageBox.Show("Faltan cosas importantes", "Fallo"); }
            else if (txttipo.Text == "")
            { MessageBox.Show("Faltan cosas importantes", "Fallo"); }
            else if (txtproducto.Text == "")
            { MessageBox.Show("Faltan cosas importantes", "Fallo"); }
            else
            {
                string pr = txtproducto.Text;
                string mr = txtmarca.Text;
                string tp = txttipo.Text;
                string din = txtprecio.Text;
                string des = txtdescripcion.Text;
                string codig = txtcodigo.Text;
                StreamWriter s = new StreamWriter(ruta, true);
                s.WriteLine(pr + "-" + mr + "-" + tp + "-" + din + "-" + des + "-" + codig);
                s.Close();
                txtdescripcion.Text = "";
                txtmarca.Text = "";
                txtprecio.Text = "";
                txtproducto.Text = "";
                txttipo.Text = "";
                txtcodigo.Text = "";
            }
        }
    }
}
