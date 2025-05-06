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


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        public void ControlDeCargaDatos()
        {

            if (txtNombre.Text == "")
            {
                txtNombre.Focus();
                txtNombre.BackColor = Color.Red;
            }
            else
            {
                if (txtDescripcion.Text == "")
                {
                    txtDescripcion.Focus();
                    txtDescripcion.BackColor = Color.Red;
                }
                else
                {
                    if (numPrecio.Value == 0)
                    {
                        numPrecio.Focus();
                        numPrecio.BackColor = Color.Red;
                    }
                    else
                    {
                        if (numStock.Value == 0)
                        {
                            numStock.Focus();
                            numStock.BackColor = Color.Red;
                        }
                        else
                        {
                            if (cmbCategorias.SelectedIndex == -1)
                            {
                                cmbCategorias.Focus();
                                cmbCategorias.BackColor = Color.Red;
                            }
                            else
                            {
                                //CargarEnBD
                                //limpiarControles();
                            }
                        }
                    }
                }
            }

        }



        private void btnAgregar_Click_1(object sender, EventArgs e)
        {

                try
                {
                    nuevoProducto.Nombre = txtNombre.Text;
                    nuevoProducto.Descripcion = txtDescripcion.Text;
                    nuevoProducto.Stock = Convert.ToInt32(numStock.Value);
                    nuevoProducto.Precio = numPrecio.Value;
                    nuevoProducto.CategoriaId = Convert.ToInt32(cmbCategorias.SelectedValue);

                    Producto.AgregarProducto(nuevoProducto);

                    CargarCategorias();
                    CargarProductos();

                    ControlDeCargaDatos();
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_TextChanged_1(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                txtNombre.BackColor = Color.Green;
                txtDescripcion.Enabled = true;
            }
            else
            {
                txtNombre.BackColor = Color.Red;
                txtDescripcion.Enabled = false;
            }
        }

        private void txtDescripcion_TextChanged_1(object sender, EventArgs e)
        {
            if (txtDescripcion.Text != "")
            {
                txtDescripcion.BackColor = Color.Green;
                numPrecio.Enabled = true;
            }
            else
            {
                txtDescripcion.BackColor = Color.Red;
                numPrecio.Enabled = false;
            }
        }

        private void numPrecio_ValueChanged_1(object sender, EventArgs e)
        {
            if (numPrecio.Value > 0)
            {
                numStock.Enabled = true;
            }
            else
            {
                numPrecio.BackColor = Color.Red;
                numStock.Enabled = false;
            }
        }

        private void numStock_ValueChanged_1(object sender, EventArgs e)
        {
            if (numStock.Value > 0)
            {
                cmbCategorias.Enabled = true;
            }
            else
            {
                numStock.BackColor = Color.Red;
                cmbCategorias.Enabled = false;
            }
        }

        private void cmbCategorias_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbCategorias.SelectedIndex > -1)
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }
    }
}
