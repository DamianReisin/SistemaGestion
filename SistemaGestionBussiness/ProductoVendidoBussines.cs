using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class ProductoVendidoBussines
    {
        public static List<ProductoVendido> ObtenerProductoVendido(int productoVendidoData)
        {
            return ProductoVendidoData.ObtenerProductoVendidoData(productoVendidoData);
        }

        public static List<ProductoVendido> ListarProductoVendido()
        {
            return ProductoVendidoData.ListarProductoVendidoData();
        }
        public static void CrearProductoVendidoData(ProductoVendido productoVendido)
        {
            ProductoVendidoData.CrearProductoVendidoData(productoVendido);
        }
        public static void EliminarProductoVendidoData(ProductoVendido productoVendido)
        {
            ProductoVendidoData.EliminarProductoVendidoData(productoVendido);
        }
        public static void ModificarProductoVendidoData(ProductoVendido productoVendido)
        {
            ProductoVendidoData.ModificarProductoVendidoData(productoVendido);
        }
    }
}
