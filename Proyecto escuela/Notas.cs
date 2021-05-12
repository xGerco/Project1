using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_escuela
{
    public partial class Notas : Form
    {
        public Notas()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 principal = new Form1();
            principal.Show();
        }

        private void Rrbp1_CheckedChanged(object sender, EventArgs e)
        {
            if (Rrbp1.Checked == true)
            {
                Rrbp2.Enabled = false;
                Rrbp3.Enabled = false;
                Rrbp4.Enabled = false;
                Rrbp5.Enabled = false;
                Rrbp6.Enabled = false;
                Rrbb1.Enabled = false;
                Rrbb2.Enabled = false;
                Rrbb3.Enabled = false;
                Rrbb4.Enabled = false;
                Rrbb5.Enabled = false;
            }
            else
            {
                Rrbp2.Enabled = true;
                Rrbp3.Enabled = true;
                Rrbp4.Enabled = true;
                Rrbp5.Enabled = true;
                Rrbp6.Enabled = true;
                Rrbb1.Enabled = true;
                Rrbb2.Enabled = true;
                Rrbb3.Enabled = true;
                Rrbb4.Enabled = true;
                Rrbb5.Enabled = true;
            }
        }

        private void Rrbp2_CheckedChanged(object sender, EventArgs e)
        {
            if (Rrbp2.Checked == true)
            {
                Rrbp1.Enabled = false;
                Rrbp3.Enabled = false;
                Rrbp4.Enabled = false;
                Rrbp5.Enabled = false;
                Rrbp6.Enabled = false;
                Rrbb1.Enabled = false;
                Rrbb2.Enabled = false;
                Rrbb3.Enabled = false;
                Rrbb4.Enabled = false;
                Rrbb5.Enabled = false;
            }
            else
            {
                Rrbp1.Enabled = true;
                Rrbp3.Enabled = true;
                Rrbp4.Enabled = true;
                Rrbp5.Enabled = true;
                Rrbp6.Enabled = true;
                Rrbb1.Enabled = true;
                Rrbb2.Enabled = true;
                Rrbb3.Enabled = true;
                Rrbb4.Enabled = true;
                Rrbb5.Enabled = true;
            }
        }

        private void Rrbp3_CheckedChanged(object sender, EventArgs e)
        {
            if (Rrbp3.Checked == true)
            {
                Rrbp2.Enabled = false;
                Rrbp1.Enabled = false;
                Rrbp4.Enabled = false;
                Rrbp5.Enabled = false;
                Rrbp6.Enabled = false;
                Rrbb1.Enabled = false;
                Rrbb2.Enabled = false;
                Rrbb3.Enabled = false;
                Rrbb4.Enabled = false;
                Rrbb5.Enabled = false;
            }
            else
            {
                Rrbp2.Enabled = true;
                Rrbp1.Enabled = true;
                Rrbp4.Enabled = true;
                Rrbp5.Enabled = true;
                Rrbp6.Enabled = true;
                Rrbb1.Enabled = true;
                Rrbb2.Enabled = true;
                Rrbb3.Enabled = true;
                Rrbb4.Enabled = true;
                Rrbb5.Enabled = true;
            }
        }

        private void Rrbp4_CheckedChanged(object sender, EventArgs e)
        {
            if (Rrbp4.Checked == true)
            {
                Rrbp2.Enabled = false;
                Rrbp3.Enabled = false;
                Rrbp1.Enabled = false;
                Rrbp5.Enabled = false;
                Rrbp6.Enabled = false;
                Rrbb1.Enabled = false;
                Rrbb2.Enabled = false;
                Rrbb3.Enabled = false;
                Rrbb4.Enabled = false;
                Rrbb5.Enabled = false;
            }
            else
            {
                Rrbp2.Enabled = true;
                Rrbp3.Enabled = true;
                Rrbp1.Enabled = true;
                Rrbp5.Enabled = true;
                Rrbp6.Enabled = true;
                Rrbb1.Enabled = true;
                Rrbb2.Enabled = true;
                Rrbb3.Enabled = true;
                Rrbb4.Enabled = true;
                Rrbb5.Enabled = true;
            }
        }

        private void Rrbp5_CheckedChanged(object sender, EventArgs e)
        {
            if (Rrbp5.Checked == true)
            {
                Rrbp2.Enabled = false;
                Rrbp3.Enabled = false;
                Rrbp4.Enabled = false;
                Rrbp1.Enabled = false;
                Rrbp6.Enabled = false;
                Rrbb1.Enabled = false;
                Rrbb2.Enabled = false;
                Rrbb3.Enabled = false;
                Rrbb4.Enabled = false;
                Rrbb5.Enabled = false;
            }
            else
            {
                Rrbp2.Enabled = true;
                Rrbp3.Enabled = true;
                Rrbp4.Enabled = true;
                Rrbp1.Enabled = true;
                Rrbp6.Enabled = true;
                Rrbb1.Enabled = true;
                Rrbb2.Enabled = true;
                Rrbb3.Enabled = true;
                Rrbb4.Enabled = true;
                Rrbb5.Enabled = true;
            }
        }

        private void Rrbp6_CheckedChanged(object sender, EventArgs e)
        {
            if (Rrbp6.Checked == true)
            {
                Rrbp2.Enabled = false;
                Rrbp3.Enabled = false;
                Rrbp4.Enabled = false;
                Rrbp5.Enabled = false;
                Rrbp1.Enabled = false;
                Rrbb1.Enabled = false;
                Rrbb2.Enabled = false;
                Rrbb3.Enabled = false;
                Rrbb4.Enabled = false;
                Rrbb5.Enabled = false;
            }
            else
            {
                Rrbp2.Enabled = true;
                Rrbp3.Enabled = true;
                Rrbp4.Enabled = true;
                Rrbp5.Enabled = true;
                Rrbp1.Enabled = true;
                Rrbb1.Enabled = true;
                Rrbb2.Enabled = true;
                Rrbb3.Enabled = true;
                Rrbb4.Enabled = true;
                Rrbb5.Enabled = true;
            }
        }

        private void Rrbb1_CheckedChanged(object sender, EventArgs e)
        {
            if (Rrbb1.Checked == true)
            {
                Rrbp2.Enabled = false;
                Rrbp3.Enabled = false;
                Rrbp4.Enabled = false;
                Rrbp5.Enabled = false;
                Rrbp6.Enabled = false;
                Rrbp1.Enabled = false;
                Rrbb2.Enabled = false;
                Rrbb3.Enabled = false;
                Rrbb4.Enabled = false;
                Rrbb5.Enabled = false;
            }
            else
            {
                Rrbp2.Enabled = true;
                Rrbp3.Enabled = true;
                Rrbp4.Enabled = true;
                Rrbp5.Enabled = true;
                Rrbp6.Enabled = true;
                Rrbp1.Enabled = true;
                Rrbb2.Enabled = true;
                Rrbb3.Enabled = true;
                Rrbb4.Enabled = true;
                Rrbb5.Enabled = true;
            }
        }

        private void Rrbb2_CheckedChanged(object sender, EventArgs e)
        {
            if (Rrbb2.Checked == true)
            {
                Rrbp2.Enabled = false;
                Rrbp3.Enabled = false;
                Rrbp4.Enabled = false;
                Rrbp5.Enabled = false;
                Rrbp6.Enabled = false;
                Rrbb1.Enabled = false;
                Rrbp1.Enabled = false;
                Rrbb3.Enabled = false;
                Rrbb4.Enabled = false;
                Rrbb5.Enabled = false;
            }
            else
            {
                Rrbp2.Enabled = true;
                Rrbp3.Enabled = true;
                Rrbp4.Enabled = true;
                Rrbp5.Enabled = true;
                Rrbp6.Enabled = true;
                Rrbb1.Enabled = true;
                Rrbp1.Enabled = true;
                Rrbb3.Enabled = true;
                Rrbb4.Enabled = true;
                Rrbb5.Enabled = true;
            }
        }

        private void Rrbb3_CheckedChanged(object sender, EventArgs e)
        {
            if (Rrbb3.Checked == true)
            {
                Rrbp2.Enabled = false;
                Rrbp3.Enabled = false;
                Rrbp4.Enabled = false;
                Rrbp5.Enabled = false;
                Rrbp6.Enabled = false;
                Rrbb1.Enabled = false;
                Rrbb2.Enabled = false;
                Rrbp1.Enabled = false;
                Rrbb4.Enabled = false;
                Rrbb5.Enabled = false;
            }
            else
            {
                Rrbp2.Enabled = true;
                Rrbp3.Enabled = true;
                Rrbp4.Enabled = true;
                Rrbp5.Enabled = true;
                Rrbp6.Enabled = true;
                Rrbb1.Enabled = true;
                Rrbb2.Enabled = true;
                Rrbp1.Enabled = true;
                Rrbb4.Enabled = true;
                Rrbb5.Enabled = true;
            }

        }

        private void Rrbb4_CheckedChanged(object sender, EventArgs e)
        {
            if (Rrbb4.Checked == true)
            {
                Rrbp2.Enabled = false;
                Rrbp3.Enabled = false;
                Rrbp4.Enabled = false;
                Rrbp5.Enabled = false;
                Rrbp6.Enabled = false;
                Rrbb1.Enabled = false;
                Rrbb2.Enabled = false;
                Rrbb3.Enabled = false;
                Rrbp1.Enabled = false;
                Rrbb5.Enabled = false;
            }
            else
            {
                Rrbp2.Enabled = true;
                Rrbp3.Enabled = true;
                Rrbp4.Enabled = true;
                Rrbp5.Enabled = true;
                Rrbp6.Enabled = true;
                Rrbb1.Enabled = true;
                Rrbb2.Enabled = true;
                Rrbb3.Enabled = true;
                Rrbp1.Enabled = true;
                Rrbb5.Enabled = true;
            }
        }

        private void Rrbb5_CheckedChanged(object sender, EventArgs e)
        {
            if (Rrbb5.Checked == true)
            {
                Rrbp2.Enabled = false;
                Rrbp3.Enabled = false;
                Rrbp4.Enabled = false;
                Rrbp5.Enabled = false;
                Rrbp6.Enabled = false;
                Rrbb1.Enabled = false;
                Rrbb2.Enabled = false;
                Rrbb3.Enabled = false;
                Rrbb4.Enabled = false;
                Rrbp1.Enabled = false;
            }
            else
            {
                Rrbp2.Enabled = true;
                Rrbp3.Enabled = true;
                Rrbp4.Enabled = true;
                Rrbp5.Enabled = true;
                Rrbp6.Enabled = true;
                Rrbb1.Enabled = true;
                Rrbb2.Enabled = true;
                Rrbb3.Enabled = true;
                Rrbb4.Enabled = true;
                Rrbp1.Enabled = true;
            }
        }
        datos misestudiante = new datos();
        private void btnmostrar_Click(object sender, EventArgs e)
        {
            if(Rrbp1.Checked==true)
            {
                P1 gradop1 = new P1();
                //Datos estudiante 1
                txbe1cname.Text = gradop1.e1NOMBRE.ToString();
                txbe1rm1.Text = gradop1.e1M1.ToString();
            }
        }
    }
}
