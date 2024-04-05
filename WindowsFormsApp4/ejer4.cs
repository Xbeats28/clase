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
    public partial class ejer4 : Form
    {
        public ejer4()
        {
            InitializeComponent();
        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            //variables
            double data;
            double min;
            double sec;
            string r1;
            string r2;
            //
            data=double.Parse(txtdatos.Text);
            min = data * 60;
            sec = data * 3600;
            r1=Convert.ToString(min);
            r2 = Convert.ToString(sec);
            txtsec.Text = r2;
            txtmins.Text = r1;  
        }
    }
}
