namespace Asignacion1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCuota.Enabled = false;
            txtEstado.Enabled = false;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int ut, ing, egr, mr;

            ing = int.Parse(mtIng.Text);
            egr = int.Parse(mtEgr.Text);
            mr = int.Parse(mtMontoReq.Text);


            if (ing > 500)
            {
                if (egr < ing)
                {
                    ut = ing - egr;
                }
                else
                {
                    MessageBox.Show("El egreso debe ser menor al ingreso");
                }
            }
            else
            {
                MessageBox.Show("EL ingreso debe ser mayor a 500");
            }

              double cuotaMensual = mr / int.Parse(cboPlazo.Text);
            // double tasaMensual = 0.18 / int.Parse(cboPlazo.Text);
            //double cuotaMensual = (mr * tasaMensual) / (1 - Math.Pow(1 + tasaMensual, -int.Parse(cboPlazo.Text)));
            double tasaMensual = (mr * 0.18) / int.Parse(cboPlazo.Text);

            txtCuota.Text = cuotaMensual.ToString();

            double montoUtilidad = (ing - egr) * 0.35;
            /*
            if(mr > 1000)
            {
                MessageBox.Show("Esperando para calcular");
            }
            else
            {
                MessageBox.Show("El monto debe ser mayo a 1000");
            }
            */

            // saber si es suficiente para cubrir con la cuota
            if (montoUtilidad >= mr)
            {
                txtEstado.Text = "Su solicitud ha sido aprobada";
            }
            else
            {
                txtEstado.Text = "Su solicitud no ha sido aprobada";
            }

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtEstado.Clear();
            txtName.Clear();
            txtCuota.Clear();
            mtEgr.Clear();
            mtIng.Clear();
            mtMontoReq.Clear();
            cboPlazo.Text = "";
            cboTipoIn.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

