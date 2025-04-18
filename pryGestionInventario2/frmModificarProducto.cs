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
    public partial class frmModificarProducto : Form
    {
        public frmModificarProducto()
        {
            InitializeComponent();
        }
        clsProductos ProductoEditar=new clsProductos();
        private void frmModificarProducto_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            CargarProductos();

            // Llenar combo de categorías
            clsProductos p = new clsProductos();
            cmbCategorias.DataSource = p.ObtenerCategorias();
            cmbCategorias.DisplayMember = "Nombre";
            cmbCategorias.ValueMember = "Id";

            // Cargar datos del producto en los campos
            if (ProductoEditar != null)
            {
                txtCodigo.Text = ProductoEditar.Codigo.ToString();
                txtNombre.Text = ProductoEditar.Nombre;
                txtDescripcion.Text = ProductoEditar.Descripcion;
                numPrecio.Value = ProductoEditar.Precio;
                numStock.Value = ProductoEditar.Stock;
                cmbCategorias.SelectedValue = ProductoEditar.CategoriaId;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                clsProductos productoActualizado = new clsProductos();
                productoActualizado.Codigo = int.Parse(txtCodigo.Text);
                productoActualizado.Nombre = txtNombre.Text;
                productoActualizado.Descripcion = txtDescripcion.Text;
                productoActualizado.Precio = numPrecio.Value;
                productoActualizado.Stock = Convert.ToInt32(numStock.Value);
                productoActualizado.CategoriaId = Convert.ToInt32(cmbCategorias.SelectedValue);

                productoActualizado.ModificarProducto(productoActualizado);

                CargarProductos();
                CargarCategorias();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cambios: " + ex.Message);
            }
        }


        public void CargarCategorias()
        {
            DataTable categorias = ProductoEditar.ObtenerCategorias();
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
            DataTable productos = ProductoEditar.ObtenerProductos();
            if (productos != null)
            {
                dgvProductos.DataSource = productos;
            }
        }
    }
}
