using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asignacion1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtVuelto.Clear();
            txtTotal.Clear();
            txtIVA.Clear();
            mtSubTotal.Clear();
            mtMontoPay.Clear();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtIVA.Enabled = false;
            txtTotal.Enabled = false;
            txtVuelto.Enabled = false;
        }

        double total, subtotal;
        private void btnCalc_Click(object sender, EventArgs e)
        {
            subtotal = double.Parse(mtSubTotal.Text);
            double IVA = subtotal * 0.15;

            if (mtSubTotal.Text == "")
            {
                MessageBox.Show("Ingrese un valor");
                mtSubTotal.Focus();
            }
            else if(subtotal > 0 && subtotal <= 1000 )
            {
                txtIVA.Text = IVA.ToString();

                if (subtotal > 0 || subtotal <= 25)
                {
                    double descuento = subtotal * 0.02;
                    double subt = subtotal - descuento;


                }else if (subtotal >= 26 || subtotal <= 60)
                {
                    double descuento = subtotal * 0.04;
                    double subt = subtotal - descuento;
                }
                else if(subtotal > 60)
                {
                    double descuento = subtotal * 0.07;
                    double subt = subtotal - descuento;
                }
            }
            else
            {
                MessageBox.Show("El rango debe estar entre 1 y 1000");
            }

            total = subtotal + IVA;
            txtTotal.Text = total.ToString();

        }

        private void btnCalcVuelto_Click(object sender, EventArgs e)
        {
            double montoPay = double.Parse(mtMontoPay.Text);
            if (mtMontoPay.Text == "")
            {
                MessageBox.Show("Ingrese un valor");
                mtMontoPay.Focus();
            }

            if (rbEfectivo.Checked)
            {
                if (montoPay >= total)
                {
                    double vuelto = (montoPay - total);
                    txtVuelto.Text = vuelto.ToString();
                }
                else
                {
                    MessageBox.Show("El pago no es suficiente para pagar");
                    mtMontoPay.Clear();
                    mtMontoPay.Focus();
                }
            }

            if (rbTarjeta.Checked)
            {
                if (subtotal > 0)
                {
                    double descuento = subtotal * 0.5; 
                    txtVuelto.Text = descuento.ToString();   
                    subtotal = subtotal - descuento;
                }else if(montoPay < total || montoPay > total)
                {
                    txtVuelto.Clear();
                    MessageBox.Show("Se le recomienda pagar el monto exacto");
                    mtMontoPay.Clear();
                    mtMontoPay.Focus();
                }
                else if (montoPay == total)
                {
                    txtVuelto.Text = "No necesita vuelto";
                    txtVuelto.Clear();
                }
            }
        }
    }
}
