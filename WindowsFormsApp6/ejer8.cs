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
    public partial class a : Form
    {
        public a()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p1.Visible= false;
            p2.Visible = false;
            p3.Visible = false;
            p4.Visible = false;
            p5.Visible = false;
            p6.Visible = false;

            Random random = new Random();
            int dado1 = random.Next(1,6);
            if(dado1 ==1) { p1.Visible = true; }
            if (dado1 == 2) { p2.Visible = true; }
            if (dado1 == 3) { p3.Visible = true; }
            if (dado1 == 4) { p4.Visible = true; }
            if (dado1 == 5) { p5.Visible = true; }
            if (dado1 == 6) { p6.Visible = true; }


            t1.Visible = false;
            t2.Visible = false;
            t3.Visible = false;
            t4.Visible = false;
            t5.Visible = false;
            t6.Visible = false;

            Random random2 = new Random();
            int dado2 = random2.Next(1, 6);
            if (dado2 == 1) { t1.Visible = true; }
            if (dado2 == 2) { t2.Visible = true; }
            if (dado2 == 3) { t3.Visible = true; }
            if (dado2 == 4) { t4.Visible = true; }
            if (dado2 == 5) { t5.Visible = true; }
            if (dado2 == 6) { t6.Visible = true; }

            q1.Visible = false;
            q2.Visible = false;
            q3.Visible = false;
            q4.Visible = false;
            q5.Visible = false;
            q6.Visible = false;

            Random random3 = new Random();
            int dado3 = random3.Next(1, 6);
            if (dado3 == 1) { q1.Visible = true; }
            if (dado3 == 2) { q2.Visible = true; }
            if (dado3 == 3) { q3.Visible = true; }
            if (dado3 == 4) { q4.Visible = true; }
            if (dado3 == 5) { q5.Visible = true; }
            if (dado3 == 6) { q6.Visible = true; }


            x1.Visible = false;
            x2.Visible = false;
            x3.Visible = false;
            x4.Visible = false;
            x5.Visible = false;
            x6.Visible = false;

            Random random4 = new Random();
            int dado5 = random2.Next(1, 6);
            if (dado5 == 1) { x1.Visible = true; }
            if (dado5 == 2) { x2.Visible = true; }
            if (dado5 == 3) { x3.Visible = true; }
            if (dado5 == 4) { x4.Visible = true; }
            if (dado5 == 5) { x5.Visible = true; }
            if (dado5 == 6) { x6.Visible = true; }
        }
    }
}
