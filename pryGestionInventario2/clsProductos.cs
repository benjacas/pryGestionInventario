using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestionInventario2
{
    internal class clsProductos
    {
        //conexion con la base de datos
        private OleDbConnection conexion = new OleDbConnection();
        //se manda un comando con este objeto a la base de datos
        private OleDbCommand comando = new OleDbCommand();
        //adatpa el comando a un formato comprensible por .NET
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        //private string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Clientes.mdb";
        private string cadenaConexion = "Proveedor de datos .NET Framework para ODBC";
        private string tabla = "Clientes";

        /*public void listar(DataGridView grilla)
        {
            //se le da la direccion de la base de datos
            conexion.ConnectionString = cadenaConexion;
            //abre la conexion con la base de datos
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = tabla;

            adaptador = new OleDbDataAdapter(comando);
            DataSet DS = new DataSet();
            adaptador.Fill(DS);

            //cierra la base de datos
            conexion.Close();ddddddd
        }*/
    }
}
