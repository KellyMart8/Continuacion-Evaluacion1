using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solicitud_de_prestamo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtVuelto.Enabled = false;
            txtTotal.Enabled = false;
            txtMontoPay.Enabled = false;
            txtIVA.Enabled = false;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            mtSubTotal.Clear();
            txtIVA.Clear();
            txtMontoPay.Clear();
            txtTotal.Clear();
            txtVuelto.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int subtotal = int.Parse(mtSubTotal.Text);

            if(subtotal > 0 && subtotal < 1000)
            {
                if (rbEfectivo.Checked)
                {
                    if(subtotal > 1 || subtotal < 25)
                    {
                        double total = subtotal * 0.02;
                        txtTotal.Text = total.ToString();

                    }else if (subtotal > 26 || subtotal < 60)
                    {
                        double total = subtotal * 0.04;
                        txtTotal.Text = total.ToString();
                    }
                    else if (subtotal > 60)
                    {
                        double total = subtotal * 0.07;
                        txtTotal.Text = total.ToString();
                    }
                }
                if (rbTarjeta.Checked)
                {
                    double total = subtotal * 0.05;
                    txtTotal.Text = total.ToString();
                }
            }else
            {
                MessageBox.Show("El rango debe estar entre 1 y 1000");
            }
        }
    }
}
