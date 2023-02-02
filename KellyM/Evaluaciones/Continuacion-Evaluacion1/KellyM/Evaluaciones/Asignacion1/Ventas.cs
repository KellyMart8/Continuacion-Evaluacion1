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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            txtTotal.Enabled = false;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            mtSubtotal.Clear();
            txtTotal.Clear();
        }

        double subt, t, a;
        private void btnCalc_Click(object sender, EventArgs e)
        {
            //subt = Convert.ToDouble(mtSubtotal.Text);
            mtSubtotal.Text = subt.ToString();

            if (subt > 0 && subt < 59)
            {
                cboDescuento.Checked = false;
                txtTotal.Text = "No tiene descuento";

            }
            else if (subt >= 60 && subt <= 99)
            {
                cboDescuento.Checked = true;
                a = subt * 0.05;
                t = subt - a;
               txtTotal.Text = t.ToString();
                
            } else if(subt >= 100 && subt <= 500)
            {
                cboDescuento.Checked = true;
                a = subt * 0.1;
                t = subt - a;
                txtTotal.Text = t.ToString();
            }
            else
            {
                MessageBox.Show("El rango debe estar entre 1 y 500", "ATENCION");
            }
        }
    }
}
