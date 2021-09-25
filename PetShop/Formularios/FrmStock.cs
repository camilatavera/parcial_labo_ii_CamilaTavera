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
    public partial class FrmStock : Form
       
    {
        static int indexRow;
        static int idActual;

        public int IndexRow
        {
            get { return indexRow; }
            set { indexRow = value; }

        }

        public int IdActual
        {
            get { return idActual; }
            set { idActual = value; }

        }

        public FrmStock()
        {
            InitializeComponent();
        }

        private void FrmStock_Load(object sender, EventArgs e)
        {
            Producto prodAux;
            this.btn_borrar.Enabled = false;
            
            this.btn_editar.Enabled = false;

            for(int i=0; i<Negocio.ListProductos.Count(); i++)
            {
                prodAux = Negocio.ListProductos[i];
                this.dataGridView1.Rows.Insert(i, prodAux.Id, prodAux.Nombre, prodAux.Cantidad,
                    prodAux.ParaMascota, prodAux.Tipo);

            }

            this.cmb_animal.DataSource = Enum.GetValues(typeof(TipoProducto));
            this.cmb_tipo.DataSource = Enum.GetValues(typeof(Mascota));


        }

        private void llenarDatos()
        {
            this.txt_id.Text = IdActual.ToString();
            this.txt_nombre.Text = dataGridView1[col_producto.Index, IndexRow].Value.ToString();
            this.nup_cantidad.Value = (decimal)dataGridView1[col_cantidad.Index, IndexRow].Value;
            this.cmb_animal.Text = dataGridView1[col_animal.Index, IndexRow].Value.ToString();
            this.cmb_tipo.Text = dataGridView1[col_tipo.Index, IndexRow].Value.ToString();
            this.nup_cantidad.Value = (decimal)dataGridView1[col_cantidad.Index, IndexRow].Value;
            this.txt_detalles.Text = Negocio.getDescripcion(IdActual);
        }

        private void actualizarDatosEditados(Producto productoEditado)
        {
            this.dataGridView1[col_producto.Index, IndexRow].Value = productoEditado.Nombre;
            this.dataGridView1[col_cantidad.Index, indexRow].Value = productoEditado.Cantidad;
            this.dataGridView1[col_animal.Index, indexRow].Value = productoEditado.ParaMascota;
            this.dataGridView1[col_tipo.Index, indexRow].Value = productoEditado.Tipo;
            this.dataGridView1[col_precio.Index, indexRow].Value = productoEditado.Precio;


        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
      
                
                this.txt_nombre.Enabled = true;
                this.nup_cantidad.Enabled = true;
                this.cmb_animal.Enabled = true;
                this.cmb_tipo.Enabled = true;
                this.txt_detalles.Enabled = true;
                

                this.btn_accionar.Text = "Guardar";
                this.btn_accionar.Visible = true;
                this.btn_accionar.Enabled = true;
        }

       

        private void btn_accionar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Producto prodAux;

            string nombre = this.txt_nombre.Text;
            float precio = (float)nud_precio.Value;
            TipoProducto tipo = (TipoProducto)cmb_tipo.SelectedItem;
            Mascota tipoMascota = (Mascota)cmb_animal.SelectedItem;
            int cantidad = (int)this.nup_cantidad.Value;
            string detalles = this.txt_detalles.Text;
            if (btn.Text == "Guardar")
            {
                prodAux = Negocio.editarProductoDeStock(IdActual, nombre, precio, tipo, tipoMascota, cantidad, detalles);   
            }

            if(btn.Text=="Guardar producto")
            {
                if (string.IsNullOrEmpty(detalles))
                    prodAux = new Producto(nombre, precio, tipo, tipoMascota, cantidad);
                else
                    prodAux = new Producto(nombre, precio, tipo, tipoMascota, cantidad, detalles);

                Negocio.agregarProducto(prodAux);
                dataGridView1.Rows.Add(prodAux.Id, prodAux.Nombre, prodAux.Cantidad,
                    prodAux.ParaMascota, prodAux.Tipo);
            }


        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Seguro que quiere borrar el producto?", "Borrando", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {

                dataGridView1.Rows.RemoveAt(IndexRow);
                Negocio.borrarProductoDeStock(IdActual);

            }   


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int id;
            id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            IdActual = id;
            IndexRow = dataGridView1.CurrentRow.Index;

            llenarDatos();
            this.btn_borrar.Enabled = true;
            this.btn_editar.Enabled = true;

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            this.txt_nombre.Enabled = true;
            this.nup_cantidad.Enabled = true;
            this.cmb_animal.Enabled = true;
            this.cmb_tipo.Enabled = true;
            this.txt_detalles.Enabled = true;

            if (!string.IsNullOrEmpty(this.txt_nombre.Text) && this.cmb_animal.SelectedItem != null
                && this.cmb_tipo.SelectedItem != null)
            {
                this.btn_accionar.Text = "Guardar producto";
                this.btn_accionar.Enabled = true;
            }
                


        }
    }
}
