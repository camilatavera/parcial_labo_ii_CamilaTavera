using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formularios
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string userAux = this.txtUser.Text;
            string pswAux = this.txtPassword.Text;

            if (Negocio.validarIngreso(userAux, pswAux) == true)
            {
                FrmPrincipal principal = new FrmPrincipal();
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o password invalido");
                this.txtUser.Text = string.Empty;
                this.txtPassword.Text = string.Empty;
            }
        }
    }
}
