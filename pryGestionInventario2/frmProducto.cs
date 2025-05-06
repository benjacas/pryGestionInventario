using Guna.UI2.WinForms;
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
            btnEsconder.Visible = false;
  
            panelMenu.Width = 51;
            

        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            btnMostrar.Visible = false;
            btnEsconder.Visible = true;
            panelMenu.Visible = false;
            panelMenu.Width = 225;
            guna2Transition1.ShowSync(panelMenu);
        }

        private void btnEsconder_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
            btnEsconder.Visible = false;
            btnMostrar.Visible = true;
            panelMenu.Width = 51;
            guna2Transition1.ShowSync(panelMenu);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerProducto_Click(object sender, EventArgs e)
        {
            frmMostrarProductos v = new frmMostrarProductos();
            v.ShowDialog();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            frmAgregarProducto v = new frmAgregarProducto();
            v.ShowDialog();
        }

        private void btnModificarProductos_Click(object sender, EventArgs e)
        {
            frmModificarProducto v = new frmModificarProducto();
            v.ShowDialog();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            frmGenerarReporte v = new frmGenerarReporte();
            v.ShowDialog();
        }

        private void btnBorrarProductos_Click(object sender, EventArgs e)
        {
            frmEliminarProducto v = new frmEliminarProducto();
            v.ShowDialog();
        }

        private void btnContactos_Click(object sender, EventArgs e)
        {
            frmAgregarContactos v = new frmAgregarContactos();
            v.ShowDialog();
        }
    }
}
