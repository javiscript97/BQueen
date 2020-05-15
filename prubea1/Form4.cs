using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prubea1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Nombre")
            {
                txtName.Text = "";
                txtName.ForeColor = Color.Black;

            }
        }

        private void txtapellidos_Enter(object sender, EventArgs e)
        {
            if (txtapellidos.Text == "Apellidos")
            {
                txtapellidos.Text = "";
                txtapellidos.ForeColor = Color.Black;

            }
        }

        private void txtEdad_Enter(object sender, EventArgs e)
        {
            if (txtEdad.Text == "Edad")
            {
                txtEdad.Text = "";
                txtEdad.ForeColor = Color.Black;

            }
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "Dirección")
            {
                txtDireccion.Text = "";
                txtDireccion.ForeColor = Color.Black;

            }
        }

        private void txtCP_Enter(object sender, EventArgs e)
        {
            if (txtCP.Text =="Código Postal")
            {
                txtCP.Text = "";
                txtCP.ForeColor = Color.Black;

            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;

            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Password")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;

            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;

            }
        }

        private void txtGenero_Enter(object sender, EventArgs e)
        {
            if (txtGenero.Text == "Género")
            {
                txtGenero.Text = "";
                txtGenero.ForeColor = Color.Black;

            }
        }

        private void txtTlf_Enter(object sender, EventArgs e)
        {
            if (txtTlf.Text == "Teléfono")
            {
                txtTlf.Text = "";
                txtTlf.ForeColor = Color.Black;

            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Nombre";
                txtName.ForeColor = Color.Silver;

            }
        }

        private void txtapellidos_Leave(object sender, EventArgs e)
        {
            if (txtapellidos.Text == "")
            {
                txtapellidos.Text = "Apellidos";
                txtapellidos.ForeColor = Color.Silver;

            }
        }

        private void txtEdad_Leave(object sender, EventArgs e)
        {
            if (txtEdad.Text == "")
            {
                txtEdad.Text = "Edad";
                txtEdad.ForeColor = Color.Silver;

            }
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "")
            {
                txtDireccion.Text = "Dirección";
                txtDireccion.ForeColor = Color.Silver;

            }
        }

        private void txtCP_Leave(object sender, EventArgs e)
        {
            if (txtCP.Text == "")
            {
                txtCP.Text = "Código Postal";
                txtCP.ForeColor = Color.Silver;

            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
                txtUser.ForeColor = Color.Silver;

            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Password";
                txtPass.ForeColor = Color.Silver;

            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.Silver;

            }
        }

        private void txtGenero_Leave(object sender, EventArgs e)
        {
            if (txtGenero.Text == "")
            {
                txtGenero.Text = "Género";
                txtGenero.ForeColor = Color.Silver;

            }
        }

        private void txtTlf_Leave(object sender, EventArgs e)
        {
            if (txtTlf.Text == "")
            {
                txtTlf.Text = "Teléfono";
                txtTlf.ForeColor = Color.Silver;

            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {

        }
    }
}
