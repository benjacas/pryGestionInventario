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
    public partial class frmMostrarProductos : Form
    {
        public frmMostrarProductos()
        {
            InitializeComponent();
        }

        private void frmMostrarProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();

            btnBuscar.Enabled = false;

        }
        clsProductos Productos = new clsProductos();
        public void CargarProductos()
        {
            DataTable productos = Productos.ObtenerProductos();
            if (productos != null)
            {
                dgvProductos.DataSource = productos;

            }
        }



        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string nombre = txtBuscarNombre.Text;
            if (nombre != null)
            {        
                DataTable Resultados = Productos.BuscarProductoPorTexto(nombre);
                dgvProductos.DataSource = Resultados;
            }
            else
            {
                MessageBox.Show("Complete el campo de búsqueda");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarNombre.Text != "")
            {
                btnBuscar.Enabled = true;
            }
            
        }
    }
}
