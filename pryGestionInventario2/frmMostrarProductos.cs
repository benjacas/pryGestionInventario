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
    }
}
