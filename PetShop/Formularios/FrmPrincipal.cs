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
    public partial class FrmPrincipal : Form
    {
        static Empleado usuario;
        
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            FrmStock frmStock = new FrmStock();
            frmStock.Show();
            this.Hide();
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {

        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {

        }
    }
}
