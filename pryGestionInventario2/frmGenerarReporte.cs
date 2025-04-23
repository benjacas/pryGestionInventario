using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestionInventario2
{
    public partial class frmGenerarReporte : Form
    {
        public frmGenerarReporte()
        {
            InitializeComponent();
        }
        clsProductos Productos = new clsProductos();
        private void frmGenerarReporte_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }
       
        public void CargarProductos()
        {
            DataTable productos = Productos.ObtenerProductos();
            if (productos != null)
            {
                dgvProductos.DataSource = productos;

            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
        }

        private void btnGenerar_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo PDF (*.pdf)|*.pdf";
            saveFileDialog.Title = "Guardar Reporte en PDF";
            saveFileDialog.FileName = "ReporteProductos.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                clsProductos p = new clsProductos();
                p.GenerarReporte(saveFileDialog.FileName);
                MessageBox.Show("Reporte generado correctamente.");
            }
        }
    }
}
