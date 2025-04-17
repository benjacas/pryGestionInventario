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
        private clsProductos nuevoProducto = new clsProductos();
        private clsProductos Producto = new clsProductos();
        

        private void frmAgregarProducto_Load(object sender, EventArgs e)
        {
            clsProductos productos = new clsProductos();
            cmbCategorias.DataSource = productos.ObtenerCategorias();
            cmbCategorias.DisplayMember = "Nombre";
            cmbCategorias.ValueMember = "Id";

            CargarCategorias();
            CargarProductos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                nuevoProducto.Nombre=txtNombre.Text;
                nuevoProducto.Descripcion = txtDescripcion.Text;
                nuevoProducto.Stock = Convert.ToInt32(numStock.Value);
                nuevoProducto.Precio = numPrecio.Value;
                nuevoProducto.CategoriaId = Convert.ToInt32(cmbCategorias.SelectedValue);

                Producto.AgregarProducto(nuevoProducto);
                MessageBox.Show("Producto agregado correctamente.");

                CargarCategorias();
                CargarProductos();

                
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
            DataTable categorias = nuevoProducto.ObtenerCategorias();
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
            DataTable productos = nuevoProducto.ObtenerProductos();
            if (productos != null)
            {
                dgvProductos.DataSource = productos;
            }
        }



    }
}
