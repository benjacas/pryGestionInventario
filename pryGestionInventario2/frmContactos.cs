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
    public partial class frmAgregarContactos : Form
    {
        public frmAgregarContactos()
        {
            InitializeComponent();
        }
        clsContactos nuevoContacto = new clsContactos();
        private void btnCargar_Click(object sender, EventArgs e)
        {
            
            
        }

        private void frmAgregarContactos_Load(object sender, EventArgs e)
        {
            nuevoContacto.CargarContactos(nuevoContacto, dgvContactos);
        }

        private void btnCargar_Click_1(object sender, EventArgs e)
        {
            try
            {
                nuevoContacto.Nombre = txtNombre.Text;
                nuevoContacto.Apellido = txtApellido.Text;
                nuevoContacto.Telefono = Convert.ToInt32(txtTelefono.Text);
                nuevoContacto.Correo = txtCorreo.Text;

                nuevoContacto.AgregarContacto(nuevoContacto);
                nuevoContacto.CargarContactos(nuevoContacto, dgvContactos);

                txtNombre.Clear();
                txtApellido.Clear();
                txtTelefono.Clear();
                txtCorreo.Clear();
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocurrió un error: {error.Message}");
            }
        }
    }
}
