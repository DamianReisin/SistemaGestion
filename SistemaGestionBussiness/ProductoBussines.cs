using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class ProductoBussines
    {
        public static List<Producto> ObtenerProducto(int productoData)
        {
            return ProductoData.ObtenerProductoData(productoData);
        }

        public static List<Producto> ListarProducto()
        {
            return ProductoData.ListarProductoData();
        }
        public static void CrearProducto(Producto producto)
        {
            ProductoData.CrearProductoData(producto);
        }
        public static void EliminarProducto(Producto producto)
        {
            ProductoData.EliminarProductoData(producto);
        }
        public static void ModificarProducto (Producto producto)
        {
            ProductoData.ModificarProductoData(producto);
        }
    }
}
