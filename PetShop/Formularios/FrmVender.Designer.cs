
namespace Formularios
{
    partial class FrmVender
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_realizarVenta = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_vendedir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.list_venta = new System.Windows.Forms.ListView();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_comprador = new System.Windows.Forms.TextBox();
            this.txt_vendedor = new System.Windows.Forms.TextBox();
            this.dateTime_fecha = new System.Windows.Forms.DateTimePicker();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.btn_borrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_realizarVenta
            // 
            this.btn_realizarVenta.Location = new System.Drawing.Point(63, 26);
            this.btn_realizarVenta.Name = "btn_realizarVenta";
            this.btn_realizarVenta.Size = new System.Drawing.Size(236, 42);
            this.btn_realizarVenta.TabIndex = 1;
            this.btn_realizarVenta.Text = "Realizar Venta";
            this.btn_realizarVenta.UseVisualStyleBackColor = true;
            this.btn_realizarVenta.Click += new System.EventHandler(this.btn_realizarVenta_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_vendedir,
            this.col_monto});
            this.dataGridView1.Location = new System.Drawing.Point(27, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(307, 326);
            this.dataGridView1.TabIndex = 2;
            // 
            // col_id
            // 
            this.col_id.HeaderText = "ID VENTA";
            this.col_id.Name = "col_id";
            this.col_id.ReadOnly = true;
            // 
            // col_vendedir
            // 
            this.col_vendedir.HeaderText = "VENDEDOR";
            this.col_vendedir.Name = "col_vendedir";
            this.col_vendedir.ReadOnly = true;
            // 
            // col_monto
            // 
            this.col_monto.HeaderText = "MONTO PAGADO";
            this.col_monto.Name = "col_monto";
            this.col_monto.ReadOnly = true;
            // 
            // list_venta
            // 
            this.list_venta.HideSelection = false;
            this.list_venta.Location = new System.Drawing.Point(523, 229);
            this.list_venta.Name = "list_venta";
            this.list_venta.Size = new System.Drawing.Size(187, 24);
            this.list_venta.TabIndex = 3;
            this.list_venta.UseCompatibleStateImageBehavior = false;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(523, 26);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(107, 23);
            this.txt_id.TabIndex = 4;
            // 
            // txt_comprador
            // 
            this.txt_comprador.Location = new System.Drawing.Point(523, 75);
            this.txt_comprador.Multiline = true;
            this.txt_comprador.Name = "txt_comprador";
            this.txt_comprador.Size = new System.Drawing.Size(169, 23);
            this.txt_comprador.TabIndex = 5;
            // 
            // txt_vendedor
            // 
            this.txt_vendedor.Location = new System.Drawing.Point(523, 126);
            this.txt_vendedor.Name = "txt_vendedor";
            this.txt_vendedor.Size = new System.Drawing.Size(169, 23);
            this.txt_vendedor.TabIndex = 6;
            // 
            // dateTime_fecha
            // 
            this.dateTime_fecha.Location = new System.Drawing.Point(523, 174);
            this.dateTime_fecha.Name = "dateTime_fecha";
            this.dateTime_fecha.Size = new System.Drawing.Size(200, 23);
            this.dateTime_fecha.TabIndex = 7;
            // 
            // txt_monto
            // 
            this.txt_monto.Location = new System.Drawing.Point(523, 284);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(100, 23);
            this.txt_monto.TabIndex = 8;
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(523, 335);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(121, 31);
            this.btn_borrar.TabIndex = 9;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            // 
            // FrmVender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.dateTime_fecha);
            this.Controls.Add(this.txt_vendedor);
            this.Controls.Add(this.txt_comprador);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.list_venta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_realizarVenta);
            this.Name = "FrmVender";
            this.Text = "FrmVender";
            this.Load += new System.EventHandler(this.FrmVender_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_realizarVenta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_vendedir;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_monto;
        private System.Windows.Forms.ListView list_venta;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_comprador;
        private System.Windows.Forms.TextBox txt_vendedor;
        private System.Windows.Forms.DateTimePicker dateTime_fecha;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.Button btn_borrar;
    }
}