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
    public partial class ejer6 : Form
    {
        public ejer6()
        {
            InitializeComponent();
        }

        private void ejer6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cel = double.Parse(celsi.Text);
            double far = cel + 275.15;
            faren.Text = Convert.ToString(far);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            double far = double.Parse(faren.Text);
            double cel = far - 275.15;
            celsi.Text = Convert.ToString(cel);
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void celsi_TextChanged(object sender, EventArgs e)
        {
            double cel = double.Parse(celsi.Text);
            double far = cel + 275.15;
            faren.Text = Convert.ToString(far);
        }

        private void faren_TextChanged(object sender, EventArgs e)
        {
            double far = double.Parse(faren.Text);
            double cel = far - 275.15;
            celsi.Text = Convert.ToString(cel);
        }

        private void faren_Enter(object sender, EventArgs e)
        {

        }
    }
}
