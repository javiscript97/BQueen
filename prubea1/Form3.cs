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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
           // txtUser.b
        }

       
        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;

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


        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Password")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;

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

        private void btnAcceder_Click(object sender, EventArgs e)
        {

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Form Form4 = new Form4();
            this.Hide();
            Form4.ShowDialog();
            this.Visible = true;
        }
    }
}
