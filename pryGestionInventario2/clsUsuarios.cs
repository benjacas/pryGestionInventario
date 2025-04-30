using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestionInventario2
{
    internal class clsUsuarios
    {

        private clsConexionBD conexion = new clsConexionBD();

        public bool VerificarLogin (string usuario, string contraseña)
        {
            string query ="SELECT COUNT (*) FROM Usuarios WHERE Usuario =@Usuario AND Clave = Clave";
            SqlCommand comando = new SqlCommand(query);
            comando.Parameters.AddWithValue("@Usuario",usuario);
            comando.Parameters.AddWithValue("@Clave",contraseña);
            
            DataTable dt = conexion.EjecutarConsulta(comando);
            return Convert.ToInt32(dt.Rows[0][0]) > 0;
        }

        public void RegistrarUsuarios(string usuario, string contraseña)
        {
            try
            {
                string query = "INSTERT INTO Usuarios(Usuarios,Contraseña) VALUES (@Usuario, @Contraseña)";
                SqlCommand comando = new SqlCommand(query);
                conexion.EjecutarComando(comando);

                MessageBox.Show("El usuario se ha registrado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar usuario: " + ex.Message);
            }

            
        }
    }
}
