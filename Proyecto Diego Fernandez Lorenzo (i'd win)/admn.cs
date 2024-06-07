using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class admn : Form
    {
        public admn()
        {
            InitializeComponent();
        }

        private void admn_Load(object sender, EventArgs e)
        {
            
            contraseña c = new contraseña();
            c.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            introduc s = new introduc();
            s.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            buscadoradmn s = new buscadoradmn();
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            borrar s = new borrar();
            s.Show();
        }
    }
}
