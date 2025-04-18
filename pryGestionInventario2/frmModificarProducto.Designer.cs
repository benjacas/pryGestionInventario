namespace pryGestionInventario2
{
    partial class frmModificarProducto
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Enabled = false;
            this.dgvProductos.Location = new System.Drawing.Point(12, 12);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(776, 294);
            this.dgvProductos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.lblCategoria);
            this.groupBox1.Controls.Add(this.cmbCategorias);
            this.groupBox1.Controls.Add(this.numStock);
            this.groupBox1.Controls.Add(this.numPrecio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblStock);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 126);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(17, 33);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 29;
            this.lblCodigo.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(20, 59);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 28;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(169, 97);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(417, 23);
            this.btnModificar.TabIndex = 27;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(635, 31);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoria";
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Location = new System.Drawing.Point(638, 58);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(121, 21);
            this.cmbCategorias.TabIndex = 26;
            // 
            // numStock
            // 
            this.numStock.Location = new System.Drawing.Point(503, 59);
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(120, 20);
            this.numStock.TabIndex = 25;
            // 
            // numPrecio
            // 
            this.numPrecio.Location = new System.Drawing.Point(368, 59);
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(120, 20);
            this.numPrecio.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stock";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(252, 60);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 4;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(249, 32);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 9;
            this.lblDescripcion.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Precio";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStock.Location = new System.Drawing.Point(27, 163);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(49, 20);
            this.lblStock.TabIndex = 23;
            this.lblStock.Text = "Stock";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrecio.Location = new System.Drawing.Point(27, 108);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(56, 20);
            this.lblPrecio.TabIndex = 22;
            this.lblPrecio.Text = "Precio";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombre.Location = new System.Drawing.Point(36, -29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 20);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Nombre";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(133, 32);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(44, 13);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(137, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // frmModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProductos);
            this.Name = "frmModificarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModificarProducto";
            this.Load += new System.EventHandler(this.frmModificarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategorias;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}