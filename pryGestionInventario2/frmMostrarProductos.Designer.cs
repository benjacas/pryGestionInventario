namespace pryGestionInventario2
{
    partial class frmMostrarProductos
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
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Enabled = false;
            this.dgvProductos.Location = new System.Drawing.Point(55, 12);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(682, 290);
            this.dgvProductos.TabIndex = 0;
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Location = new System.Drawing.Point(55, 339);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(109, 20);
            this.txtBuscarNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(55, 323);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(55, 380);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(682, 45);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmMostrarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtBuscarNombre);
            this.Controls.Add(this.dgvProductos);
            this.Name = "frmMostrarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMostrarProductos";
            this.Load += new System.EventHandler(this.frmMostrarProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnBuscar;
    }
}