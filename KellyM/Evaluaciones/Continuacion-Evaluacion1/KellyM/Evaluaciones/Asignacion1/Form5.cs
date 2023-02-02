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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

      
        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            mtValorBien.Clear();
            txtDepre.Clear();
            mtValorBien.Focus();
        }
        // costo / vida util = Depreciacion lineal
        // (valor del bien * vida util + 1) /2   =   Suma de digito

        double val, dep;
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            mtValorBien.Text = val.ToString();

            if (lbxTipoD.Text == "Linea recta" || lbxTipoD.Text == "Suma de digitos")
            {
                if (lbxTipoD.Text == "Linea recta")
                {
                    if (chlbxTipoBien.Text == "Vehiculo")
                    {
                        dep = val / 5;
                        txtDepre.Text = dep.ToString();

                    }
                    else if (chlbxTipoBien.Text == "Edificio")
                    {
                        dep = val / 20;
                        txtDepre.Text = dep.ToString();
                    }
                    if (chlbxTipoBien.Text == "Equipo de oficina")
                    {
                        dep = val / 15;
                        txtDepre.Text = dep.ToString();
                    }
                } /* DEPRECIACION POR SUMA DE DIGITOS*/
                else if (lbxTipoD.Text == "Suma de digitos")
                {
                    if (chlbxTipoBien.Text == "Vehiculo")
                    {
                        dep = (val * (5 + 1)) / 2;
                        txtDepre.Text = dep.ToString();
                    }
                    else if (chlbxTipoBien.Text == "Edificio")
                    {
                        dep = (val * (20 + 1)) / 2;
                        txtDepre.Text = dep.ToString();
                    }
                    if (chlbxTipoBien.Text == "Equipo de oficina")
                    {
                        dep = (val * (15 + 1)) / 2;
                        txtDepre.Text = dep.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de depreciacion");
            }
        }
    }
}
