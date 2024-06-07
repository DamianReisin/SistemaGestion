using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class VentaBussines
    {
        public static List<Venta> ObtenerVenta(int ventaData)
        {
            return VentaData.ObtenerVentaData(ventaData);
        }

        public static List<Venta> ListarVenta()
        {
            return VentaData.ListarVentaData();
        }
        public static void CrearVenta(Venta venta)
        {
           VentaData.CrearVentaData(venta);
        }
        public static void EliminarVenta(Venta venta)
        {
            VentaData.EliminarVentaData(venta);
        }
        public static void ModificarVenta(Venta venta)
        {
            VentaData.ModificarVentaData(venta);
        }
    }
}
