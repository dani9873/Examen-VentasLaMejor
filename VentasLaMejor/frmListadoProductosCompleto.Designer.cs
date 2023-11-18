namespace VentasLaMejor
{
    partial class frmListadoProductosCompleto
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
            this.components = new System.ComponentModel.Container();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.rbDescripcionProducto = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.bsProductos = new System.Windows.Forms.BindingSource(this.components);
            this.coliDproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.dgvProductos);
            this.GroupBox2.Location = new System.Drawing.Point(22, 127);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(707, 294);
            this.GroupBox2.TabIndex = 9;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Productos";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coliDproducto,
            this.colCodigoProducto,
            this.colProducto,
            this.colMarca});
            this.dgvProductos.Location = new System.Drawing.Point(14, 21);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(679, 252);
            this.dgvProductos.TabIndex = 1;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.GroupBox3);
            this.GroupBox1.Controls.Add(this.txtDato);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(22, 22);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(707, 100);
            this.GroupBox1.TabIndex = 8;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Búsqueda";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.rbDescripcionProducto);
            this.GroupBox3.Controls.Add(this.rbCodigo);
            this.GroupBox3.Location = new System.Drawing.Point(409, 15);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(276, 74);
            this.GroupBox3.TabIndex = 2;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Buscar por";
            // 
            // rbDescripcionProducto
            // 
            this.rbDescripcionProducto.AutoSize = true;
            this.rbDescripcionProducto.Location = new System.Drawing.Point(142, 28);
            this.rbDescripcionProducto.Name = "rbDescripcionProducto";
            this.rbDescripcionProducto.Size = new System.Drawing.Size(127, 17);
            this.rbDescripcionProducto.TabIndex = 1;
            this.rbDescripcionProducto.Text = "Descripción Producto";
            this.rbDescripcionProducto.UseVisualStyleBackColor = true;
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Checked = true;
            this.rbCodigo.Location = new System.Drawing.Point(23, 28);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(104, 17);
            this.rbCodigo.TabIndex = 0;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Código Producto";
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(68, 42);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(318, 20);
            this.txtDato.TabIndex = 1;
            this.txtDato.TextChanged += new System.EventHandler(this.txtDato_TextChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(26, 46);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(30, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Dato";
            // 
            // coliDproducto
            // 
            this.coliDproducto.DataPropertyName = "IdProducto";
            this.coliDproducto.HeaderText = "Idproducto";
            this.coliDproducto.Name = "coliDproducto";
            this.coliDproducto.ReadOnly = true;
            this.coliDproducto.Visible = false;
            // 
            // colCodigoProducto
            // 
            this.colCodigoProducto.DataPropertyName = "CodigoProducto";
            this.colCodigoProducto.HeaderText = "Código Producto";
            this.colCodigoProducto.Name = "colCodigoProducto";
            this.colCodigoProducto.ReadOnly = true;
            // 
            // colProducto
            // 
            this.colProducto.DataPropertyName = "Producto";
            this.colProducto.HeaderText = "Producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            // 
            // colMarca
            // 
            this.colMarca.DataPropertyName = "Marca";
            this.colMarca.HeaderText = "Marca";
            this.colMarca.Name = "colMarca";
            this.colMarca.ReadOnly = true;
            // 
            // frmListadoProductosCompleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 476);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListadoProductosCompleto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Productos [Completo]";
            this.Load += new System.EventHandler(this.frmListadoProductosCompleto_Load);
            this.GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.DataGridView dgvProductos;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.RadioButton rbDescripcionProducto;
        internal System.Windows.Forms.RadioButton rbCodigo;
        internal System.Windows.Forms.TextBox txtDato;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.BindingSource bsProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn coliDproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
    }
}