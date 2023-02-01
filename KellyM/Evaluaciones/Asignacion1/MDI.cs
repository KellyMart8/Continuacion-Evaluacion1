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
    public partial class MDI : Form
    {
        Form1 x = new Form1();
        Form2 y = new Form2();
        Form3 z = new Form3();
        public MDI()
        {
            InitializeComponent();
        }

        private void solicitudDePrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.MdiParent = this;
            x.Show();
        }

        private void depreciacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            y.MdiParent = this;
            y.Show();
        }

        private void efectivoOTarjetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            z.MdiParent = this;
            z.Show();
        }
    }
}
