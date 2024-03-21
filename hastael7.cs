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
    public partial class ejer2 : Form
    {
        public ejer2()
        {
            InitializeComponent();
        }

       
        
        
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ejer2_Load(object sender, EventArgs e)
        {

        }
       
        private void btnconvert_Click(object sender, EventArgs e)
        { //variables 
            string a = " ";
;            string day = dias.Text;
            string años = año.Text;
            //fin
            if (mes.Text == "1") { a = "Enero"; }
            else if (mes.Text == "2") { a = "Febrero"; }
      
            else if (mes.Text == "3") { a = "Marzo"; }
            else if(mes.Text == "4") { a = "Abril"; }
            else if (mes.Text == "5") { a = "Mayo"; }
            else if (mes.Text == "6") { a = "Junio"; }
            else if (mes.Text == "7") { a = "Jukio"; }
            else if (mes.Text == "8") { a = "Agosto"; }
            else if (mes.Text == "9") { a = "Septiembre"; }
            else if (mes.Text == "10") { a = "Octubre"; }
            else if (mes.Text == "11") { a = "Noviembre"; }
            else if (mes.Text == "12") { a = "Diciembre"; }
            else { MessageBox.Show("PON UN NUMERO DE MES P**A"); }
            txtmostrar.Text = day +" "+  a+" " + años;
        }

        private void btnpimpiar_Click(object sender, EventArgs e)
        {
            dias.Text = null;
            mes.Text = null;
            año.Text = null;




        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
           Form1 form1 = new Form1();
            form1.ShowDialog();


        }
    }
}
