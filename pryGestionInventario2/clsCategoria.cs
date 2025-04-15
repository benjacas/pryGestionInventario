using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryGestionInventario2
{
    internal class clsCategoria
    {
        public int ID { get; set; }
        public string Categoria { get; set; }

        public static void AgregarCategoria(List<clsCategoria> listaCategorias, clsCategoria nuevaCategoria)
        {
            listaCategorias.Add(nuevaCategoria);
        }

        public static bool EliminarCategoria(List<clsCategoria> listaCategorias, int idCategoria)
        {
            var categoriaAEliminar = listaCategorias.FirstOrDefault(c => c.ID == idCategoria);
            if (categoriaAEliminar != null)
            {
                listaCategorias.Remove(categoriaAEliminar);
                return true;
            }
            return false;
        }
    }
}
