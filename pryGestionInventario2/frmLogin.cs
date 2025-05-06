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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        clsUsuarios Usuarios = new clsUsuarios();
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            panelRegistro.Visible = true;
            panelIngresar.Visible = false;
           // Guna2Transition.HideSync(panelRegistro);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            //panelRegistro.Visible = false;
            //Guna2Transition1.HideSync(panelRegistro);
            panelRegistro.Visible = false;
            panelIngresar.Visible = true;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            try
            {
                if (Usuarios.VerificarLogin(usuario, contraseña))
                {
                    MessageBox.Show("Bienvenido " + usuario);
                    
                    frmMenu v = new frmMenu();
                    
                    v.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string usuario = txtRegistrarUsuario.Text.Trim();
            string contraseña = txtRegistrarContraseña.Text.Trim();
            string confirmarUsuario = txtConfirmarUsuario.Text.Trim();
            string confirmarContraseña = txtConfirmarContraseña.Text.Trim();

            
            
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            if (confirmarUsuario == usuario && confirmarContraseña == contraseña)
            {
                Usuarios.RegistrarUsuarios(usuario, contraseña);

                //en todo caso cerrar o esconder el panel cuando termines el diseño. si no hacerlo en otro form al registro
                //this.Close();
            }
            else
            {
                MessageBox.Show("Los campos no coinciden.");
            }
            

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            panelRegistro.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
