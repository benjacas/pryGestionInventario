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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {

        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarProducto v = new frmAgregarProducto();
            v.ShowDialog();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrarProductos v = new frmMostrarProductos();
            v.ShowDialog();
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminarProducto v = new frmEliminarProducto();
            v.ShowDialog();
        }

        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarProducto v = new frmModificarProducto();
            v.ShowDialog();
        }

        private void crearReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGenerarReporte v = new frmGenerarReporte();
            v.ShowDialog();
        }
    }
}
