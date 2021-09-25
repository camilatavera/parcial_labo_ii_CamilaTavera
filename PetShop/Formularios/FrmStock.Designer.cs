
namespace Formularios
{
    partial class FrmStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nud_precio = new System.Windows.Forms.NumericUpDown();
            this.btn_accionar = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_detalles = new System.Windows.Forms.TextBox();
            this.cmb_animal = new System.Windows.Forms.ComboBox();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.nup_cantidad = new System.Windows.Forms.NumericUpDown();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_producto,
            this.col_cantidad,
            this.col_animal,
            this.col_tipo,
            this.col_precio});
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(554, 352);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(49, 401);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(81, 37);
            this.btn_editar.TabIndex = 1;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(149, 401);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(90, 37);
            this.btn_borrar.TabIndex = 2;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.nud_precio);
            this.panel1.Controls.Add(this.btn_accionar);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.txt_detalles);
            this.panel1.Controls.Add(this.cmb_animal);
            this.panel1.Controls.Add(this.cmb_tipo);
            this.panel1.Controls.Add(this.nup_cantidad);
            this.panel1.Controls.Add(this.txt_nombre);
            this.panel1.Location = new System.Drawing.Point(597, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 454);
            this.panel1.TabIndex = 3;
            // 
            // nud_precio
            // 
            this.nud_precio.Location = new System.Drawing.Point(86, 223);
            this.nud_precio.Name = "nud_precio";
            this.nud_precio.Size = new System.Drawing.Size(120, 23);
            this.nud_precio.TabIndex = 7;
            // 
            // btn_accionar
            // 
            this.btn_accionar.Location = new System.Drawing.Point(109, 408);
            this.btn_accionar.Name = "btn_accionar";
            this.btn_accionar.Size = new System.Drawing.Size(133, 23);
            this.btn_accionar.TabIndex = 6;
            this.btn_accionar.Text = "button1";
            this.btn_accionar.UseVisualStyleBackColor = true;
            this.btn_accionar.Visible = false;
            this.btn_accionar.Click += new System.EventHandler(this.btn_accionar_Click);
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(205, 3);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(86, 23);
            this.txt_id.TabIndex = 5;
            this.txt_id.Visible = false;
            // 
            // txt_detalles
            // 
            this.txt_detalles.Location = new System.Drawing.Point(32, 262);
            this.txt_detalles.Multiline = true;
            this.txt_detalles.Name = "txt_detalles";
            this.txt_detalles.Size = new System.Drawing.Size(236, 119);
            this.txt_detalles.TabIndex = 4;
            // 
            // cmb_animal
            // 
            this.cmb_animal.FormattingEnabled = true;
            this.cmb_animal.Location = new System.Drawing.Point(71, 126);
            this.cmb_animal.Name = "cmb_animal";
            this.cmb_animal.Size = new System.Drawing.Size(154, 23);
            this.cmb_animal.TabIndex = 3;
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Location = new System.Drawing.Point(71, 180);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(154, 23);
            this.cmb_tipo.TabIndex = 2;
            // 
            // nup_cantidad
            // 
            this.nup_cantidad.Location = new System.Drawing.Point(86, 83);
            this.nup_cantidad.Name = "nup_cantidad";
            this.nup_cantidad.Size = new System.Drawing.Size(120, 23);
            this.nup_cantidad.TabIndex = 1;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(34, 43);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(234, 23);
            this.txt_nombre.TabIndex = 0;
            // 
            // col_id
            // 
            this.col_id.HeaderText = "Id";
            this.col_id.Name = "col_id";
            this.col_id.ReadOnly = true;
            this.col_id.Width = 50;
            // 
            // col_producto
            // 
            this.col_producto.HeaderText = "Producto";
            this.col_producto.Name = "col_producto";
            this.col_producto.ReadOnly = true;
            // 
            // col_cantidad
            // 
            this.col_cantidad.HeaderText = "cantidad";
            this.col_cantidad.Name = "col_cantidad";
            this.col_cantidad.ReadOnly = true;
            // 
            // col_animal
            // 
            this.col_animal.HeaderText = "Para que animal";
            this.col_animal.Name = "col_animal";
            this.col_animal.ReadOnly = true;
            // 
            // col_tipo
            // 
            this.col_tipo.HeaderText = "Tipo";
            this.col_tipo.Name = "col_tipo";
            this.col_tipo.ReadOnly = true;
            // 
            // col_precio
            // 
            this.col_precio.HeaderText = "Precio";
            this.col_precio.Name = "col_precio";
            this.col_precio.ReadOnly = true;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(255, 401);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(83, 37);
            this.btn_agregar.TabIndex = 4;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 450);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmStock";
            this.Text = "FrmStock";
            this.Load += new System.EventHandler(this.FrmStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_cantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_detalles;
        private System.Windows.Forms.ComboBox cmb_animal;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.NumericUpDown nup_cantidad;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_accionar;
        private System.Windows.Forms.NumericUpDown nud_precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_precio;
        private System.Windows.Forms.Button btn_agregar;
    }
}