using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestionInventario2
{
    internal class clsContactos
    {
        private clsConexionBD Conexion = new clsConexionBD();
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }


        public clsContactos()
        {

            Conexion = new clsConexionBD();

        }

        public DataTable ObtenerContactos()
        {
            string query = "SELECT Nombre, Apellido, Telefono, Correo FROM Contactos";
            SqlCommand comando = new SqlCommand(query);
            return Conexion.EjecutarConsulta(comando);
        }

        public void AgregarContacto(clsContactos contacto)
        {
            try
            {
                string query = "INSERT INTO Contactos (Nombre, Apellido, Telefono, Correo) " +
                               "VALUES (@Nombre, @Apellido, @Telefono, @Correo)";

                SqlCommand comando = new SqlCommand(query);
                comando.Parameters.AddWithValue("@Nombre", contacto.Nombre);
                comando.Parameters.AddWithValue("@Apellido", contacto.Apellido);
                comando.Parameters.AddWithValue("@Telefono", contacto.Telefono);
                comando.Parameters.AddWithValue("@Correo", contacto.Correo);

                Conexion.EjecutarComando(comando);
                MessageBox.Show("Contacto agregado correctamente.");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al agregar contacto: " + error.Message);
            }
        }

        public DataTable BuscarContacto(string texto)
        {
            string query = "SELECT Codigo, Nombre, Apellido, Telefono, Correo FROM Contactos " +
                           "WHERE Nombre LIKE @Texto OR Apellido LIKE @Texto";
            SqlCommand comando = new SqlCommand(query);
            comando.Parameters.AddWithValue("@Texto", "%" + texto + "%");
            return Conexion.EjecutarConsulta(comando);
        }

        public void ModificarContacto(clsContactos contacto)
        {
            try
            {
                string query = "UPDATE Contactos SET Nombre = @Nombre, Apellido = @Apellido, " +
                               "Telefono = @Telefono, Correo = @Correo " +
                               "WHERE Codigo = @Codigo";

                SqlCommand comando = new SqlCommand(query);
                comando.Parameters.AddWithValue("@Codigo", contacto.Codigo);
                comando.Parameters.AddWithValue("@Nombre", contacto.Nombre);
                comando.Parameters.AddWithValue("@Apellido", contacto.Apellido);
                comando.Parameters.AddWithValue("@Telefono", contacto.Telefono);
                comando.Parameters.AddWithValue("@Correo", contacto.Correo);

                Conexion.EjecutarComando(comando);
                MessageBox.Show("Contacto modificado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar contacto: " + ex.Message);
            }
        }

        public void EliminarContactoPorCodigo(string correo)
        {
            try
            {
                string query = "DELETE FROM Contactos WHERE Codigo = @Codigo";
                SqlCommand comando = new SqlCommand(query);
                comando.Parameters.AddWithValue("@Codigo", Codigo);

                Conexion.EjecutarComando(comando);
                MessageBox.Show("Contacto eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar contacto: " + ex.Message);
            }
        }

        public void CargarContactos(clsContactos contacto, DataGridView dgv)
        {
            DataTable contactos = contacto.ObtenerContactos();
            if (contactos != null)
            {
                dgv.DataSource = contactos;
            }
        }

    }
}
