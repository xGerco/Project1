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
    public partial class frmregistro : Form
    {
        public frmregistro()
        {
            InitializeComponent();
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 principal = new Form1();
            principal.Show();
        }

        private void rbp1_CheckedChanged(object sender, EventArgs e)
        {
            
     
        }

        private void rbp1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbp1.Checked == true)
            {
                rbp2.Enabled = false;
                rbp3.Enabled = false;
                rbp4.Enabled = false;
                rbp5.Enabled = false;
                rbp6.Enabled = false;
                rbb1.Enabled = false;
                rbb2.Enabled = false;
                rbb3.Enabled = false;
                rbb4.Enabled = false;
                rbb5.Enabled = false;
            }
            else if (rbp1.Checked == false)
            {
                rbp2.Enabled = true;
                rbp3.Enabled = true;
                rbp4.Enabled = true;
                rbp5.Enabled = true;
                rbp6.Enabled = true;
                rbb1.Enabled = true;
                rbb2.Enabled = true;
                rbb3.Enabled = true;
                rbb4.Enabled = true;
                rbb5.Enabled = true;
            }
        }

        private void rbp2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbp2.Checked == true)
            {
                rbp1.Enabled = false;
                rbp3.Enabled = false;
                rbp4.Enabled = false;
                rbp5.Enabled = false;
                rbp6.Enabled = false;
                rbb1.Enabled = false;
                rbb2.Enabled = false;
                rbb3.Enabled = false;
                rbb4.Enabled = false;
                rbb5.Enabled = false;
            }
            else if (rbp2.Checked == false)
            {
                rbp1.Enabled = true;
                rbp3.Enabled = true;
                rbp4.Enabled = true;
                rbp5.Enabled = true;
                rbp6.Enabled = true;
                rbb1.Enabled = true;
                rbb2.Enabled = true;
                rbb3.Enabled = true;
                rbb4.Enabled = true;
                rbb5.Enabled = true;
            }
        }

        private void rbp3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbp3.Checked == true)
            {
                rbp2.Enabled = false;
                rbp1.Enabled = false;
                rbp4.Enabled = false;
                rbp5.Enabled = false;
                rbp6.Enabled = false;
                rbb1.Enabled = false;
                rbb2.Enabled = false;
                rbb3.Enabled = false;
                rbb4.Enabled = false;
                rbb5.Enabled = false;
            }
            else if (rbp3.Checked == false)
            {
                rbp2.Enabled = true;
                rbp1.Enabled = true;
                rbp4.Enabled = true;
                rbp5.Enabled = true;
                rbp6.Enabled = true;
                rbb1.Enabled = true;
                rbb2.Enabled = true;
                rbb3.Enabled = true;
                rbb4.Enabled = true;
                rbb5.Enabled = true;
            }
        }

        private void rbp4_CheckedChanged(object sender, EventArgs e)
        {
            if (rbp4.Checked == true)
            {
                rbp2.Enabled = false;
                rbp3.Enabled = false;
                rbp1.Enabled = false;
                rbp5.Enabled = false;
                rbp6.Enabled = false;
                rbb1.Enabled = false;
                rbb2.Enabled = false;
                rbb3.Enabled = false;
                rbb4.Enabled = false;
                rbb5.Enabled = false;
            }
            else if (rbp4.Checked == false)
            {
                rbp2.Enabled = true;
                rbp3.Enabled = true;
                rbp1.Enabled = true;
                rbp5.Enabled = true;
                rbp6.Enabled = true;
                rbb1.Enabled = true;
                rbb2.Enabled = true;
                rbb3.Enabled = true;
                rbb4.Enabled = true;
                rbb5.Enabled = true;
            }
        }

        private void rbp5_CheckedChanged(object sender, EventArgs e)
        {
            if (rbp5.Checked == true)
            {
                rbp2.Enabled = false;
                rbp3.Enabled = false;
                rbp4.Enabled = false;
                rbp1.Enabled = false;
                rbp6.Enabled = false;
                rbb1.Enabled = false;
                rbb2.Enabled = false;
                rbb3.Enabled = false;
                rbb4.Enabled = false;
                rbb5.Enabled = false;
            }
            else if (rbp5.Checked == false)
            {
                rbp2.Enabled = true;
                rbp3.Enabled = true;
                rbp4.Enabled = true;
                rbp1.Enabled = true;
                rbp6.Enabled = true;
                rbb1.Enabled = true;
                rbb2.Enabled = true;
                rbb3.Enabled = true;
                rbb4.Enabled = true;
                rbb5.Enabled = true;
            }
        }

        private void rbp6_CheckedChanged(object sender, EventArgs e)
        {
            if (rbp6.Checked == true)
            {
                rbp2.Enabled = false;
                rbp3.Enabled = false;
                rbp4.Enabled = false;
                rbp5.Enabled = false;
                rbp1.Enabled = false;
                rbb1.Enabled = false;
                rbb2.Enabled = false;
                rbb3.Enabled = false;
                rbb4.Enabled = false;
                rbb5.Enabled = false;
            }
            else if (rbp6.Checked == false)
            {
                rbp2.Enabled = true;
                rbp3.Enabled = true;
                rbp4.Enabled = true;
                rbp5.Enabled = true;
                rbp1.Enabled = true;
                rbb1.Enabled = true;
                rbb2.Enabled = true;
                rbb3.Enabled = true;
                rbb4.Enabled = true;
                rbb5.Enabled = true;
            }
        }

        private void rbb1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbb1.Checked == true)
            {
                rbp2.Enabled = false;
                rbp3.Enabled = false;
                rbp4.Enabled = false;
                rbp5.Enabled = false;
                rbp6.Enabled = false;
                rbp1.Enabled = false;
                rbb2.Enabled = false;
                rbb3.Enabled = false;
                rbb4.Enabled = false;
                rbb5.Enabled = false;
            }
            else if (rbb1.Checked == false)
            {
                rbp2.Enabled = true;
                rbp3.Enabled = true;
                rbp4.Enabled = true;
                rbp5.Enabled = true;
                rbp6.Enabled = true;
                rbp1.Enabled = true;
                rbb2.Enabled = true;
                rbb3.Enabled = true;
                rbb4.Enabled = true;
                rbb5.Enabled = true;
            }
        }

        private void rbb2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbb2.Checked == true)
            {
                rbp2.Enabled = false;
                rbp3.Enabled = false;
                rbp4.Enabled = false;
                rbp5.Enabled = false;
                rbp6.Enabled = false;
                rbb1.Enabled = false;
                rbp1.Enabled = false;
                rbb3.Enabled = false;
                rbb4.Enabled = false;
                rbb5.Enabled = false;
            }
            else if (rbb2.Checked == false)
            {
                rbp2.Enabled = true;
                rbp3.Enabled = true;
                rbp4.Enabled = true;
                rbp5.Enabled = true;
                rbp6.Enabled = true;
                rbb1.Enabled = true;
                rbp1.Enabled = true;
                rbb3.Enabled = true;
                rbb4.Enabled = true;
                rbb5.Enabled = true;
            }
        }

        private void rbb3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbb3.Checked == true)
            {
                rbp2.Enabled = false;
                rbp3.Enabled = false;
                rbp4.Enabled = false;
                rbp5.Enabled = false;
                rbp6.Enabled = false;
                rbb1.Enabled = false;
                rbb2.Enabled = false;
                rbp1.Enabled = false;
                rbb4.Enabled = false;
                rbb5.Enabled = false;
            }
            else if (rbb3.Checked == false)
            {
                rbp2.Enabled = true;
                rbp3.Enabled = true;
                rbp4.Enabled = true;
                rbp5.Enabled = true;
                rbp6.Enabled = true;
                rbb1.Enabled = true;
                rbb2.Enabled = true;
                rbp1.Enabled = true;
                rbb4.Enabled = true;
                rbb5.Enabled = true;
            }
        }

        private void rbb4_CheckedChanged(object sender, EventArgs e)
        {
            if (rbb4.Checked == true)
            {
                rbp2.Enabled = false;
                rbp3.Enabled = false;
                rbp4.Enabled = false;
                rbp5.Enabled = false;
                rbp6.Enabled = false;
                rbb1.Enabled = false;
                rbb2.Enabled = false;
                rbb3.Enabled = false;
                rbp1.Enabled = false;
                rbb5.Enabled = false;
            }
            else if (rbb4.Checked == false)
            {
                rbp2.Enabled = true;
                rbp3.Enabled = true;
                rbp4.Enabled = true;
                rbp5.Enabled = true;
                rbp6.Enabled = true;
                rbb1.Enabled = true;
                rbb2.Enabled = true;
                rbb3.Enabled = true;
                rbp1.Enabled = true;
                rbb5.Enabled = true;
            }
        }

        private void rbb5_CheckedChanged(object sender, EventArgs e)
        {
            if (rbb5.Checked == true)
            {
                rbp2.Enabled = false;
                rbp3.Enabled = false;
                rbp4.Enabled = false;
                rbp5.Enabled = false;
                rbp6.Enabled = false;
                rbb1.Enabled = false;
                rbb2.Enabled = false;
                rbb3.Enabled = false;
                rbb4.Enabled = false;
                rbp1.Enabled = false;
            }
            else if (rbb5.Checked == false)
            {
                rbp2.Enabled = true;
                rbp3.Enabled = true;
                rbp4.Enabled = true;
                rbp5.Enabled = true;
                rbp6.Enabled = true;
                rbb1.Enabled = true;
                rbb2.Enabled = true;
                rbb3.Enabled = true;
                rbb4.Enabled = true;
                rbp1.Enabled = true;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            txte1name.Clear();
            txbe2name.Clear();
            txbe3name.Clear();
            txbe4name.Clear();
            txbe5name.Clear();
            txbe1lname.Clear();
            txbe2lname.Clear();
            txbe3lname.Clear();
            txbe4lname.Clear();
            txbe5lname.Clear();
            txbe1m1.Clear();
            txbe2m1.Clear();
            txbe3m1.Clear();
            txbe4m1.Clear();
            txbe5m1.Clear();
            txbe1m2.Clear();
            txbe2m2.Clear();
            txbe3m2.Clear();
            txbe4m2.Clear();
            txbe5m2.Clear();
            txbe1m3.Clear();
            txbe2m3.Clear();
            txbe3m3.Clear();
            txbe4m3.Clear();
            txbe5m3.Clear();
            txbe1m4.Clear();
            txbe2m4.Clear();
            txbe3m4.Clear();
            txbe4m4.Clear();
            txbe5m4.Clear();
        }

        datos mydatos = new datos();
        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (rbp1.Checked == true)
            {
                P1 gradop1 = new P1();
                gradop1.e1NOMBRE = txte1name.Text;
                gradop1.e1APELLIDO = txbe1lname.Text;
                gradop1.e1M1 = Convert.ToDecimal(txbe1m1.Text);
                gradop1.e1M2 = Convert.ToDecimal(txbe1m2.Text);
                gradop1.e1M3 = Convert.ToDecimal(txbe1m2.Text);
                gradop1.e1M4 = Convert.ToDecimal(txbe1m2.Text);

                gradop1.e2NOMBRE = txbe2name.Text;
                gradop1.e2APELLIDO = txbe2lname.Text;
                gradop1.e2M1 = Convert.ToDecimal(txbe2m1.Text);
                gradop1.e2M2 = Convert.ToDecimal(txbe2m2.Text);
                gradop1.e2M3 = Convert.ToDecimal(txbe2m2.Text);
                gradop1.e2M4 = Convert.ToDecimal(txbe2m2.Text);

                gradop1.e3NOMBRE = txbe3name.Text;
                gradop1.e3APELLIDO = txbe3lname.Text;
                gradop1.e3M1 = Convert.ToDecimal(txbe3m1.Text);
                gradop1.e3M2 = Convert.ToDecimal(txbe3m2.Text);
                gradop1.e3M3 = Convert.ToDecimal(txbe3m2.Text);
                gradop1.e3M4 = Convert.ToDecimal(txbe3m2.Text);

                gradop1.e4NOMBRE = txbe4name.Text;
                gradop1.e4APELLIDO = txbe4lname.Text;
                gradop1.e4M1 = Convert.ToDecimal(txbe4m1.Text);
                gradop1.e4M2 = Convert.ToDecimal(txbe4m2.Text);
                gradop1.e4M3 = Convert.ToDecimal(txbe4m2.Text);
                gradop1.e4M4 = Convert.ToDecimal(txbe4m2.Text);

                gradop1.e5NOMBRE = txbe5name.Text;
                gradop1.e5APELLIDO = txbe5lname.Text;
                gradop1.e5M1 = Convert.ToDecimal(txbe5m1.Text);
                gradop1.e5M2 = Convert.ToDecimal(txbe5m2.Text);
                gradop1.e5M3 = Convert.ToDecimal(txbe5m2.Text);
                gradop1.e5M4 = Convert.ToDecimal(txbe5m2.Text);
            }
            else if (rbp2.Checked == true)
            {
                P2 gradop2 = new P2();
                gradop2.e1NOMBRE = txte1name.Text;
                gradop2.e1APELLIDO = txbe1lname.Text;
                gradop2.e1M1 = Convert.ToDecimal(txbe1m1.Text);
                gradop2.e1M2 = Convert.ToDecimal(txbe1m2.Text);
                gradop2.e1M3 = Convert.ToDecimal(txbe1m2.Text);
                gradop2.e1M4 = Convert.ToDecimal(txbe1m2.Text);

                gradop2.e2NOMBRE = txbe2name.Text;
                gradop2.e2APELLIDO = txbe2lname.Text;
                gradop2.e2M1 = Convert.ToDecimal(txbe2m1.Text);
                gradop2.e2M2 = Convert.ToDecimal(txbe2m2.Text);
                gradop2.e2M3 = Convert.ToDecimal(txbe2m2.Text);
                gradop2.e2M4 = Convert.ToDecimal(txbe2m2.Text);

                gradop2.e3NOMBRE = txbe3name.Text;
                gradop2.e3APELLIDO = txbe3lname.Text;
                gradop2.e3M1 = Convert.ToDecimal(txbe3m1.Text);
                gradop2.e3M2 = Convert.ToDecimal(txbe3m2.Text);
                gradop2.e3M3 = Convert.ToDecimal(txbe3m2.Text);
                gradop2.e3M4 = Convert.ToDecimal(txbe3m2.Text);

                gradop2.e4NOMBRE = txbe4name.Text;
                gradop2.e4APELLIDO = txbe4lname.Text;
                gradop2.e4M1 = Convert.ToDecimal(txbe4m1.Text);
                gradop2.e4M2 = Convert.ToDecimal(txbe4m2.Text);
                gradop2.e4M3 = Convert.ToDecimal(txbe4m2.Text);
                gradop2.e4M4 = Convert.ToDecimal(txbe4m2.Text);

                gradop2.e5NOMBRE = txbe5name.Text;
                gradop2.e5APELLIDO = txbe5lname.Text;
                gradop2.e5M1 = Convert.ToDecimal(txbe5m1.Text);
                gradop2.e5M2 = Convert.ToDecimal(txbe5m2.Text);
                gradop2.e5M3 = Convert.ToDecimal(txbe5m2.Text);
                gradop2.e5M4 = Convert.ToDecimal(txbe5m2.Text);
            }
            else if (rbp3.Checked == true)
            {
                P3 gradop3 = new P3();
                gradop3.e1NOMBRE = txte1name.Text;
                gradop3.e1APELLIDO = txbe1lname.Text;
                gradop3.e1M1 = Convert.ToDecimal(txbe1m1.Text);
                gradop3.e1M2 = Convert.ToDecimal(txbe1m2.Text);
                gradop3.e1M3 = Convert.ToDecimal(txbe1m2.Text);
                gradop3.e1M4 = Convert.ToDecimal(txbe1m2.Text);

                gradop3.e2NOMBRE = txbe2name.Text;
                gradop3.e2APELLIDO = txbe2lname.Text;
                gradop3.e2M1 = Convert.ToDecimal(txbe2m1.Text);
                gradop3.e2M2 = Convert.ToDecimal(txbe2m2.Text);
                gradop3.e2M3 = Convert.ToDecimal(txbe2m2.Text);
                gradop3.e2M4 = Convert.ToDecimal(txbe2m2.Text);

                gradop3.e3NOMBRE = txbe3name.Text;
                gradop3.e3APELLIDO = txbe3lname.Text;
                gradop3.e3M1 = Convert.ToDecimal(txbe3m1.Text);
                gradop3.e3M2 = Convert.ToDecimal(txbe3m2.Text);
                gradop3.e3M3 = Convert.ToDecimal(txbe3m2.Text);
                gradop3.e3M4 = Convert.ToDecimal(txbe3m2.Text);

                gradop3.e4NOMBRE = txbe4name.Text;
                gradop3.e4APELLIDO = txbe4lname.Text;
                gradop3.e4M1 = Convert.ToDecimal(txbe4m1.Text);
                gradop3.e4M2 = Convert.ToDecimal(txbe4m2.Text);
                gradop3.e4M3 = Convert.ToDecimal(txbe4m2.Text);
                gradop3.e4M4 = Convert.ToDecimal(txbe4m2.Text);

                gradop3.e5NOMBRE = txbe5name.Text;
                gradop3.e5APELLIDO = txbe5lname.Text;
                gradop3.e5M1 = Convert.ToDecimal(txbe5m1.Text);
                gradop3.e5M2 = Convert.ToDecimal(txbe5m2.Text);
                gradop3.e5M3 = Convert.ToDecimal(txbe5m2.Text);
                gradop3.e5M4 = Convert.ToDecimal(txbe5m2.Text);
            }
            else if (rbp4.Checked == true)
            {
                P4 gradop4 = new P4();
                gradop4.e1NOMBRE = txte1name.Text;
                gradop4.e1APELLIDO = txbe1lname.Text;
                gradop4.e1M1 = Convert.ToDecimal(txbe1m1.Text);
                gradop4.e1M2 = Convert.ToDecimal(txbe1m2.Text);
                gradop4.e1M3 = Convert.ToDecimal(txbe1m2.Text);
                gradop4.e1M4 = Convert.ToDecimal(txbe1m2.Text);

                gradop4.e2NOMBRE = txbe2name.Text;
                gradop4.e2APELLIDO = txbe2lname.Text;
                gradop4.e2M1 = Convert.ToDecimal(txbe2m1.Text);
                gradop4.e2M2 = Convert.ToDecimal(txbe2m2.Text);
                gradop4.e2M3 = Convert.ToDecimal(txbe2m2.Text);
                gradop4.e2M4 = Convert.ToDecimal(txbe2m2.Text);

                gradop4.e3NOMBRE = txbe3name.Text;
                gradop4.e3APELLIDO = txbe3lname.Text;
                gradop4.e3M1 = Convert.ToDecimal(txbe3m1.Text);
                gradop4.e3M2 = Convert.ToDecimal(txbe3m2.Text);
                gradop4.e3M3 = Convert.ToDecimal(txbe3m2.Text);
                gradop4.e3M4 = Convert.ToDecimal(txbe3m2.Text);

                gradop4.e4NOMBRE = txbe4name.Text;
                gradop4.e4APELLIDO = txbe4lname.Text;
                gradop4.e4M1 = Convert.ToDecimal(txbe4m1.Text);
                gradop4.e4M2 = Convert.ToDecimal(txbe4m2.Text);
                gradop4.e4M3 = Convert.ToDecimal(txbe4m2.Text);
                gradop4.e4M4 = Convert.ToDecimal(txbe4m2.Text);

                gradop4.e5NOMBRE = txbe5name.Text;
                gradop4.e5APELLIDO = txbe5lname.Text;
                gradop4.e5M1 = Convert.ToDecimal(txbe5m1.Text);
                gradop4.e5M2 = Convert.ToDecimal(txbe5m2.Text);
                gradop4.e5M3 = Convert.ToDecimal(txbe5m2.Text);
                gradop4.e5M4 = Convert.ToDecimal(txbe5m2.Text);
            }
            else if(rbp5.Checked == true)
            {
                P5 gradop5 = new P5();
                gradop5.e1NOMBRE = txte1name.Text;
                gradop5.e1APELLIDO = txbe1lname.Text;
                gradop5.e1M1 = Convert.ToDecimal(txbe1m1.Text);
                gradop5.e1M2 = Convert.ToDecimal(txbe1m2.Text);
                gradop5.e1M3 = Convert.ToDecimal(txbe1m2.Text);
                gradop5.e1M4 = Convert.ToDecimal(txbe1m2.Text);

                gradop5.e2NOMBRE = txbe2name.Text;
                gradop5.e2APELLIDO = txbe2lname.Text;
                gradop5.e2M1 = Convert.ToDecimal(txbe2m1.Text);
                gradop5.e2M2 = Convert.ToDecimal(txbe2m2.Text);
                gradop5.e2M3 = Convert.ToDecimal(txbe2m2.Text);
                gradop5.e2M4 = Convert.ToDecimal(txbe2m2.Text);

                gradop5.e3NOMBRE = txbe3name.Text;
                gradop5.e3APELLIDO = txbe3lname.Text;
                gradop5.e3M1 = Convert.ToDecimal(txbe3m1.Text);
                gradop5.e3M2 = Convert.ToDecimal(txbe3m2.Text);
                gradop5.e3M3 = Convert.ToDecimal(txbe3m2.Text);
                gradop5.e3M4 = Convert.ToDecimal(txbe3m2.Text);

                gradop5.e4NOMBRE = txbe4name.Text;
                gradop5.e4APELLIDO = txbe4lname.Text;
                gradop5.e4M1 = Convert.ToDecimal(txbe4m1.Text);
                gradop5.e4M2 = Convert.ToDecimal(txbe4m2.Text);
                gradop5.e4M3 = Convert.ToDecimal(txbe4m2.Text);
                gradop5.e4M4 = Convert.ToDecimal(txbe4m2.Text);

                gradop5.e5NOMBRE = txbe5name.Text;
                gradop5.e5APELLIDO = txbe5lname.Text;
                gradop5.e5M1 = Convert.ToDecimal(txbe5m1.Text);
                gradop5.e5M2 = Convert.ToDecimal(txbe5m2.Text);
                gradop5.e5M3 = Convert.ToDecimal(txbe5m2.Text);
                gradop5.e5M4 = Convert.ToDecimal(txbe5m2.Text);
            }
            else if(rbp6.Checked==true)
            {
                P6 gradop6 = new P6();
                gradop6.e1NOMBRE = txte1name.Text;
                gradop6.e1APELLIDO = txbe1lname.Text;
                gradop6.e1M1 = Convert.ToDecimal(txbe1m1.Text);
                gradop6.e1M2 = Convert.ToDecimal(txbe1m2.Text);
                gradop6.e1M3 = Convert.ToDecimal(txbe1m2.Text);
                gradop6.e1M4 = Convert.ToDecimal(txbe1m2.Text);

                gradop6.e2NOMBRE = txbe2name.Text;
                gradop6.e2APELLIDO = txbe2lname.Text;
                gradop6.e2M1 = Convert.ToDecimal(txbe2m1.Text);
                gradop6.e2M2 = Convert.ToDecimal(txbe2m2.Text);
                gradop6.e2M3 = Convert.ToDecimal(txbe2m2.Text);
                gradop6.e2M4 = Convert.ToDecimal(txbe2m2.Text);

                gradop6.e3NOMBRE = txbe3name.Text;
                gradop6.e3APELLIDO = txbe3lname.Text;
                gradop6.e3M1 = Convert.ToDecimal(txbe3m1.Text);
                gradop6.e3M2 = Convert.ToDecimal(txbe3m2.Text);
                gradop6.e3M3 = Convert.ToDecimal(txbe3m2.Text);
                gradop6.e3M4 = Convert.ToDecimal(txbe3m2.Text);

                gradop6.e4NOMBRE = txbe4name.Text;
                gradop6.e4APELLIDO = txbe4lname.Text;
                gradop6.e4M1 = Convert.ToDecimal(txbe4m1.Text);
                gradop6.e4M2 = Convert.ToDecimal(txbe4m2.Text);
                gradop6.e4M3 = Convert.ToDecimal(txbe4m2.Text);
                gradop6.e4M4 = Convert.ToDecimal(txbe4m2.Text);

                gradop6.e5NOMBRE = txbe5name.Text;
                gradop6.e5APELLIDO = txbe5lname.Text;
                gradop6.e5M1 = Convert.ToDecimal(txbe5m1.Text);
                gradop6.e5M2 = Convert.ToDecimal(txbe5m2.Text);
                gradop6.e5M3 = Convert.ToDecimal(txbe5m2.Text);
                gradop6.e5M4 = Convert.ToDecimal(txbe5m2.Text);
            }
            else if(rbb1.Checked ==true)
            {
                B1 gradob1 = new B1();
                gradob1.e1NOMBRE = txte1name.Text;
                gradob1.e1APELLIDO = txbe1lname.Text;
                gradob1.e1M1 = Convert.ToDecimal(txbe1m1.Text);
                gradob1.e1M2 = Convert.ToDecimal(txbe1m2.Text);
                gradob1.e1M3 = Convert.ToDecimal(txbe1m2.Text);
                gradob1.e1M4 = Convert.ToDecimal(txbe1m2.Text);

                gradob1.e2NOMBRE = txbe2name.Text;
                gradob1.e2APELLIDO = txbe2lname.Text;
                gradob1.e2M1 = Convert.ToDecimal(txbe2m1.Text);
                gradob1.e2M2 = Convert.ToDecimal(txbe2m2.Text);
                gradob1.e2M3 = Convert.ToDecimal(txbe2m2.Text);
                gradob1.e2M4 = Convert.ToDecimal(txbe2m2.Text);

                gradob1.e3NOMBRE = txbe3name.Text;
                gradob1.e3APELLIDO = txbe3lname.Text;
                gradob1.e3M1 = Convert.ToDecimal(txbe3m1.Text);
                gradob1.e3M2 = Convert.ToDecimal(txbe3m2.Text);
                gradob1.e3M3 = Convert.ToDecimal(txbe3m2.Text);
                gradob1.e3M4 = Convert.ToDecimal(txbe3m2.Text);

                gradob1.e4NOMBRE = txbe4name.Text;
                gradob1.e4APELLIDO = txbe4lname.Text;
                gradob1.e4M1 = Convert.ToDecimal(txbe4m1.Text);
                gradob1.e4M2 = Convert.ToDecimal(txbe4m2.Text);
                gradob1.e4M3 = Convert.ToDecimal(txbe4m2.Text);
                gradob1.e4M4 = Convert.ToDecimal(txbe4m2.Text);

                gradob1.e5NOMBRE = txbe5name.Text;
                gradob1.e5APELLIDO = txbe5lname.Text;
                gradob1.e5M1 = Convert.ToDecimal(txbe5m1.Text);
                gradob1.e5M2 = Convert.ToDecimal(txbe5m2.Text);
                gradob1.e5M3 = Convert.ToDecimal(txbe5m2.Text);
                gradob1.e5M4 = Convert.ToDecimal(txbe5m2.Text);
            }
            else if(rbb2.Checked==true)
            {
                B2 gradob2 = new B2();
                gradob2.e1NOMBRE = txte1name.Text;
                gradob2.e1APELLIDO = txbe1lname.Text;
                gradob2.e1M1 = Convert.ToDecimal(txbe1m1.Text);
                gradob2.e1M2 = Convert.ToDecimal(txbe1m2.Text);
                gradob2.e1M3 = Convert.ToDecimal(txbe1m2.Text);
                gradob2.e1M4 = Convert.ToDecimal(txbe1m2.Text);

                gradob2.e2NOMBRE = txbe2name.Text;
                gradob2.e2APELLIDO = txbe2lname.Text;
                gradob2.e2M1 = Convert.ToDecimal(txbe2m1.Text);
                gradob2.e2M2 = Convert.ToDecimal(txbe2m2.Text);
                gradob2.e2M3 = Convert.ToDecimal(txbe2m2.Text);
                gradob2.e2M4 = Convert.ToDecimal(txbe2m2.Text);

                gradob2.e3NOMBRE = txbe3name.Text;
                gradob2.e3APELLIDO = txbe3lname.Text;
                gradob2.e3M1 = Convert.ToDecimal(txbe3m1.Text);
                gradob2.e3M2 = Convert.ToDecimal(txbe3m2.Text);
                gradob2.e3M3 = Convert.ToDecimal(txbe3m2.Text);
                gradob2.e3M4 = Convert.ToDecimal(txbe3m2.Text);

                gradob2.e4NOMBRE = txbe4name.Text;
                gradob2.e4APELLIDO = txbe4lname.Text;
                gradob2.e4M1 = Convert.ToDecimal(txbe4m1.Text);
                gradob2.e4M2 = Convert.ToDecimal(txbe4m2.Text);
                gradob2.e4M3 = Convert.ToDecimal(txbe4m2.Text);
                gradob2.e4M4 = Convert.ToDecimal(txbe4m2.Text);

                gradob2.e5NOMBRE = txbe5name.Text;
                gradob2.e5APELLIDO = txbe5lname.Text;
                gradob2.e5M1 = Convert.ToDecimal(txbe5m1.Text);
                gradob2.e5M2 = Convert.ToDecimal(txbe5m2.Text);
                gradob2.e5M3 = Convert.ToDecimal(txbe5m2.Text);
                gradob2.e5M4 = Convert.ToDecimal(txbe5m2.Text);
            }
            else if (rbb3.Checked==true)
            {
                B3 gradob3 = new B3();
                gradob3.e1NOMBRE = txte1name.Text;
                gradob3.e1APELLIDO = txbe1lname.Text;
                gradob3.e1M1 = Convert.ToDecimal(txbe1m1.Text);
                gradob3.e1M2 = Convert.ToDecimal(txbe1m2.Text);
                gradob3.e1M3 = Convert.ToDecimal(txbe1m2.Text);
                gradob3.e1M4 = Convert.ToDecimal(txbe1m2.Text);

                gradob3.e2NOMBRE = txbe2name.Text;
                gradob3.e2APELLIDO = txbe2lname.Text;
                gradob3.e2M1 = Convert.ToDecimal(txbe2m1.Text);
                gradob3.e2M2 = Convert.ToDecimal(txbe2m2.Text);
                gradob3.e2M3 = Convert.ToDecimal(txbe2m2.Text);
                gradob3.e2M4 = Convert.ToDecimal(txbe2m2.Text);

                gradob3.e3NOMBRE = txbe3name.Text;
                gradob3.e3APELLIDO = txbe3lname.Text;
                gradob3.e3M1 = Convert.ToDecimal(txbe3m1.Text);
                gradob3.e3M2 = Convert.ToDecimal(txbe3m2.Text);
                gradob3.e3M3 = Convert.ToDecimal(txbe3m2.Text);
                gradob3.e3M4 = Convert.ToDecimal(txbe3m2.Text);

                gradob3.e4NOMBRE = txbe4name.Text;
                gradob3.e4APELLIDO = txbe4lname.Text;
                gradob3.e4M1 = Convert.ToDecimal(txbe4m1.Text);
                gradob3.e4M2 = Convert.ToDecimal(txbe4m2.Text);
                gradob3.e4M3 = Convert.ToDecimal(txbe4m2.Text);
                gradob3.e4M4 = Convert.ToDecimal(txbe4m2.Text);

                gradob3.e5NOMBRE = txbe5name.Text;
                gradob3.e5APELLIDO = txbe5lname.Text;
                gradob3.e5M1 = Convert.ToDecimal(txbe5m1.Text);
                gradob3.e5M2 = Convert.ToDecimal(txbe5m2.Text);
                gradob3.e5M3 = Convert.ToDecimal(txbe5m2.Text);
                gradob3.e5M4 = Convert.ToDecimal(txbe5m2.Text);
            }    
            else if(rbb4.Checked==true)
            {
                B4 gradob4 = new B4();
                gradob4.e1NOMBRE = txte1name.Text;
                gradob4.e1APELLIDO = txbe1lname.Text;
                gradob4.e1M1 = Convert.ToDecimal(txbe1m1.Text);
                gradob4.e1M2 = Convert.ToDecimal(txbe1m2.Text);
                gradob4.e1M3 = Convert.ToDecimal(txbe1m2.Text);
                gradob4.e1M4 = Convert.ToDecimal(txbe1m2.Text);

                gradob4.e2NOMBRE = txbe2name.Text;
                gradob4.e2APELLIDO = txbe2lname.Text;
                gradob4.e2M1 = Convert.ToDecimal(txbe2m1.Text);
                gradob4.e2M2 = Convert.ToDecimal(txbe2m2.Text);
                gradob4.e2M3 = Convert.ToDecimal(txbe2m2.Text);
                gradob4.e2M4 = Convert.ToDecimal(txbe2m2.Text);

                gradob4.e3NOMBRE = txbe3name.Text;
                gradob4.e3APELLIDO = txbe3lname.Text;
                gradob4.e3M1 = Convert.ToDecimal(txbe3m1.Text);
                gradob4.e3M2 = Convert.ToDecimal(txbe3m2.Text);
                gradob4.e3M3 = Convert.ToDecimal(txbe3m2.Text);
                gradob4.e3M4 = Convert.ToDecimal(txbe3m2.Text);

                gradob4.e4NOMBRE = txbe4name.Text;
                gradob4.e4APELLIDO = txbe4lname.Text;
                gradob4.e4M1 = Convert.ToDecimal(txbe4m1.Text);
                gradob4.e4M2 = Convert.ToDecimal(txbe4m2.Text);
                gradob4.e4M3 = Convert.ToDecimal(txbe4m2.Text);
                gradob4.e4M4 = Convert.ToDecimal(txbe4m2.Text);

                gradob4.e5NOMBRE = txbe5name.Text;
                gradob4.e5APELLIDO = txbe5lname.Text;
                gradob4.e5M1 = Convert.ToDecimal(txbe5m1.Text);
                gradob4.e5M2 = Convert.ToDecimal(txbe5m2.Text);
                gradob4.e5M3 = Convert.ToDecimal(txbe5m2.Text);
                gradob4.e5M4 = Convert.ToDecimal(txbe5m2.Text);
            }
            else if(rbb5.Checked==true)
            {
                B5 gradob5 = new B5();
                gradob5.e1NOMBRE = txte1name.Text;
                gradob5.e1APELLIDO = txbe1lname.Text;
                gradob5.e1M1 = Convert.ToDecimal(txbe1m1.Text);
                gradob5.e1M2 = Convert.ToDecimal(txbe1m2.Text);
                gradob5.e1M3 = Convert.ToDecimal(txbe1m2.Text);
                gradob5.e1M4 = Convert.ToDecimal(txbe1m2.Text);

                gradob5.e2NOMBRE = txbe2name.Text;
                gradob5.e2APELLIDO = txbe2lname.Text;
                gradob5.e2M1 = Convert.ToDecimal(txbe2m1.Text);
                gradob5.e2M2 = Convert.ToDecimal(txbe2m2.Text);
                gradob5.e2M3 = Convert.ToDecimal(txbe2m2.Text);
                gradob5.e2M4 = Convert.ToDecimal(txbe2m2.Text);

                gradob5.e3NOMBRE = txbe3name.Text;
                gradob5.e3APELLIDO = txbe3lname.Text;
                gradob5.e3M1 = Convert.ToDecimal(txbe3m1.Text);
                gradob5.e3M2 = Convert.ToDecimal(txbe3m2.Text);
                gradob5.e3M3 = Convert.ToDecimal(txbe3m2.Text);
                gradob5.e3M4 = Convert.ToDecimal(txbe3m2.Text);

                gradob5.e4NOMBRE = txbe4name.Text;
                gradob5.e4APELLIDO = txbe4lname.Text;
                gradob5.e4M1 = Convert.ToDecimal(txbe4m1.Text);
                gradob5.e4M2 = Convert.ToDecimal(txbe4m2.Text);
                gradob5.e4M3 = Convert.ToDecimal(txbe4m2.Text);
                gradob5.e4M4 = Convert.ToDecimal(txbe4m2.Text);

                gradob5.e5NOMBRE = txbe5name.Text;
                gradob5.e5APELLIDO = txbe5lname.Text;
                gradob5.e5M1 = Convert.ToDecimal(txbe5m1.Text);
                gradob5.e5M2 = Convert.ToDecimal(txbe5m2.Text);
                gradob5.e5M3 = Convert.ToDecimal(txbe5m2.Text);
                gradob5.e5M4 = Convert.ToDecimal(txbe5m2.Text);
            }
            MessageBox.Show("Sus datos han sido guardados exitosamente");
        }
    }
}
