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
    }
}
