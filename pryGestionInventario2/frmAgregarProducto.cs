using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestionInventario2
{
    public partial class frmAgregarProducto : Form
    {
        public frmAgregarProducto()
        {
            InitializeComponent();
        }
        private clsProductos productosBD = new clsProductos();
        private ToolTip toolTip1 = new ToolTip();
        private void frmAgregarProducto_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            CargarProductos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                clsProductos nuevoProducto = new clsProductos
                {
                    Nombre = txtNombre.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim(),
                    Precio = numPrecio.Value > 0 ? numPrecio.Value : 0,
                    Stock = numStock.Value > 0 ? (int)numStock.Value : 0,
                    CategoriaId = Convert.ToInt32(cmbCategorias.SelectedValue)
                };

                productosBD.AgregarProducto(nuevoProducto);
                CargarProductos();
                txtNombre.Clear();
                txtDescripcion.Clear();
                numPrecio.Value = 0;
                numStock.Value = 0;
                cmbCategorias.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void CargarCategorias()
        {
            DataTable categorias = productosBD.ObtenerCategorias();
            if (categorias != null)
            {
                DataRow row = categorias.NewRow();
                row["Nombre"] = "Seleccionar categoría";
                categorias.Rows.InsertAt(row, 0);

                cmbCategorias.DisplayMember = "Nombre";
                cmbCategorias.ValueMember = "Id";
                cmbCategorias.DataSource = categorias;

                cmbCategorias.SelectedIndex = -1;
            }
        }

        public void CargarProductos()
        {
            DataTable productos = productosBD.ObtenerProductos();
            if (productos != null)
            {
                dgvProductos.DataSource = productos;
            }
        }



    }
}
