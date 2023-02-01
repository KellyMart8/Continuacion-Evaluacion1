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
    public partial class Form4 : Form
    {
        MDI mdi = new MDI();
        public Form4()
        {
            InitializeComponent();
        }

       
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // Set the maximum length of text in the control to eight.
            txtPassword.MaxLength = 8;
            // Assign the asterisk to be the password character.
            txtPassword.PasswordChar = '*';
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
             string user1 = "Kelly Martinez";
             string contr1 = "12345678";

            user1 = txtUsuario.Text;
            contr1 = txtPassword.Text;

            if (txtUsuario.Text == "Kelly Martinez" && txtPassword.Text == "12345678")
            {
                progressBar1.Minimum = 0;
                progressBar1.Maximum = 100;

                for (int i= 0; i < 100; i++)
                {
                    progressBar1.Value = i;
                }

                mdi.Show();
            }
            //else if (user1 =="" && contr1 == "")
            //{
            //    MessageBox.Show("Rellene los campos");
            //}
            else if (user1 != "Kelly Martinez" && contr1 != "12345678")
            {
                MessageBox.Show("Rellene los campos correctamente" , "Advertencia");
                txtUsuario.Clear();
                txtPassword.Clear();
                txtUsuario.Focus();
            }
            else
            {
                MessageBox.Show("Rellene todos los campos");
                txtUsuario.Focus();
            }
        }

        private void btnCalncel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
