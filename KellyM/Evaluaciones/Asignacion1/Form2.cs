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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtDepre.Enabled = false;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (cboTipoB.Text == "Vehiculo")
            {
                double depreVehiculo = int.Parse(mtValor.Text) / 5;
                txtDepre.Text = depreVehiculo.ToString();
            }
            if (cboTipoB.Text == "Edificio")
            {
                double depreEdificio = int.Parse(mtValor.Text) / 20;
                txtDepre.Text = depreEdificio.ToString();
            }
            if (cboTipoB.Text == "Eq Oficina")
            {
                double depreEqOficina = int.Parse(mtValor.Text) / 12;
                txtDepre.Text = depreEqOficina.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboTipoB.Text = "";
            txtDepre.Clear();
            mtValor.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
