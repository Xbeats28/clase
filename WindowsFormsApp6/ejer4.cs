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

namespace WindowsFormsApp6
{
    public partial class ejer4 : Form
    {
        public ejer4()
        {
            InitializeComponent();
        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            //
            string texto = txt1.Text;

            //

            if(radiocombo.Checked)
            {
                comboBox1.Items.Add(texto);

            }
            if(radiolistbox.Checked) 
            {
            listBox1.Items.Add(texto);

            }

        }
        string ruta = Directory.GetCurrentDirectory() + "SUTUTU.txt";
        private void button1_Click(object sender, EventArgs e)
        {
            string texto = txt1.Text;
           
            StreamWriter s = new StreamWriter(ruta,true);
            s.WriteLine(texto);
            s.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

          
            StreamReader lector = new StreamReader(ruta);
            listBox2.Visible = true;
            string x = lector.ReadLine();
            for (; x != null;)            {
               
                listBox2.Items.Add(x);
                x= lector.ReadLine();
            }

            lector.Close();

        }
    }
}
