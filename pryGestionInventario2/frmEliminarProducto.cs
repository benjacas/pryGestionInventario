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
    public partial class frmEliminarProducto : Form
    {
        public frmEliminarProducto()
        {
            InitializeComponent();
        }
        private clsProductos Productos = new clsProductos();
        private void frmEliminarProducto_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            DataTable productos = Productos.ObtenerProductos();
            if (productos != null)
            {
                dgvProductos.DataSource = productos;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count == 0)
            {
                btnEliminar.Enabled = false;
                MessageBox.Show("Seleccione un producto de la lista para eliminar.");
                return;
            }
            else
            {
                btnEliminar.Enabled = true;
                DataGridViewRow seleccion = dgvProductos.SelectedRows[0];
                string nombreProducto = seleccion.Cells["Nombre"].Value.ToString();
                Productos.EliminarProductoPorNombre(nombreProducto);
                CargarProductos();
            }
        }
    }
}
