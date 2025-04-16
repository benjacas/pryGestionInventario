using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pryGestionInventario2
{
    internal class clsProductos
    {
        private clsConexionBD Conexion = new clsConexionBD();
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public int CategoriaId { get; set; }

        public clsProductos()
        {

            Conexion = new clsConexionBD();
            
        }


        public DataTable ObtenerProductos()
        {
            /*if (Conexion == null)
            {
                Conexion = new clsConexionBD();
            }*/
                
            string query = "SELECT p.Codigo, p.Nombre, p.Descripcion, p.Precio, p.Stock, c.Nombre AS Categoria " +
                           "FROM Productos p INNER JOIN Categorias c ON p.CategoriaId = c.Id";//Hace un INNER JOIN para traer también el nombre de la categoría desde la tabla Categorias
            SqlCommand comando = new SqlCommand(query);//crea el comando con la consulta
            return Conexion.EjecutarConsulta(comando);//la envia y le pide que devuelva los valores solicitados en la consulta
        }


        public void AgregarProducto(clsProductos producto)
        {
            try
            {
                string query = "INSERT INTO Productos (Nombre, Descripcion, Precio, Stock, CategoriaId) " +
                               "VALUES (@Nombre, @Descripcion, @Precio, @Stock, @CategoriaId)";//INSEERTA DATOS DENTRO DE ESAS COLUMNAS QUE INDICA

                SqlCommand comando = new SqlCommand(query);//crea el comando con la consulta
                comando.Parameters.AddWithValue("@Nombre", producto.Nombre);//asigna a cada columna el dato correspondiente del producto
                comando.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                comando.Parameters.AddWithValue("@Precio", producto.Precio);
                comando.Parameters.AddWithValue("@Stock", producto.Stock);
                comando.Parameters.AddWithValue("@CategoriaId", producto.CategoriaId);

                Conexion.EjecutarComando(comando);//Ejecuta el envio de comando con los datos a cada columna de la tabla usando la consulta
                MessageBox.Show("Producto agregado correctamente.");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al agregar producto: " + error.Message);
            }
        }


        /*
         Se arma una consulta SQL que une las tablas Productos y Categorias, y filtra según el texto ingresado.
         LIKE permite buscar coincidencias parciales. Por ejemplo, si buscás "tele", encuentra "televisor", "telecomando"
         */
        public DataTable BuscarProductoPorTexto(string texto)
        {
            string query = "SELECT p.Codigo, p.Nombre, p.Descripcion, p.Precio, p.Stock, c.Nombre AS Categoria " +
                           "FROM Productos p INNER JOIN Categorias c ON p.CategoriaId = c.Id " +
                           "WHERE p.Nombre LIKE @Texto OR p.Codigo LIKE @Texto";

            SqlCommand comando = new SqlCommand(query);
            comando.Parameters.AddWithValue("@Texto", "%" + texto + "%");//Acá se construye el patrón de búsqueda (%texto%) y se pasa como parámetro para evitar SQL Injection
            return Conexion.EjecutarConsulta(comando);//Ejecuta la consulta y devuelve los resultados en un DataTable
        }


        
        public void ModificarProducto(clsProductos producto)
        {
            try
            {   //Arma una sentencia SQL para modificar un registro.
                //Se asegura de modificar solo el producto con el Codigo correcto.
                string query = "UPDATE Productos SET Nombre = @Nombre, Descripcion = @Descripcion, Precio = @Precio, " +
                               "Stock = @Stock, CategoriaId = @CategoriaId WHERE Codigo = @Codigo";
                SqlCommand comando = new SqlCommand(query);//envia la consulta
                comando.Parameters.AddWithValue("@Codigo", producto.Codigo);
                comando.Parameters.AddWithValue("@Nombre", producto.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                comando.Parameters.AddWithValue("@Precio", producto.Precio);
                comando.Parameters.AddWithValue("@Stock", producto.Stock);
                comando.Parameters.AddWithValue("@CategoriaId", producto.CategoriaId);

                Conexion.EjecutarComando(comando);
                MessageBox.Show("Producto modificado correctamente.");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al modificar producto: " + error.Message);
            }
        }


        
        public void EliminarProductoPorNombre(string nombreProducto)
        {
            try
            {
                string query = "DELETE FROM Productos WHERE Nombre = @Nombre";//Arma una sentencia SQL para eliminar un producto específico
                SqlCommand comando = new SqlCommand(query);
                comando.Parameters.AddWithValue("@Nombre", nombreProducto);//usa parámetros para prevenir inyecciones SQL

                Conexion.EjecutarComando(comando);//elimina el registro
                MessageBox.Show("Producto eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar producto: " + ex.Message);
            }
        }


        public DataTable ObtenerCategorias()
        {
            string query = "SELECT Id, Nombre FROM Categorias";//consulta el ID y el nombre de la tabla categorias
            SqlCommand comando = new SqlCommand(query);//pide
            return Conexion.EjecutarConsulta(comando); //devuelve
        }

    }
}
