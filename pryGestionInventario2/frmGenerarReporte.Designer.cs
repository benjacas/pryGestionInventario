namespace pryGestionInventario2
{
    partial class frmGenerarReporte
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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(52, 357);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(690, 66);
            this.btnGenerar.TabIndex = 7;
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(52, 34);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(690, 290);
            this.dgvProductos.TabIndex = 4;
            // 
            // frmGenerarReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dgvProductos);
            this.Name = "frmGenerarReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGenerarReporte";
            this.Load += new System.EventHandler(this.frmGenerarReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView dgvProductos;
    }
}