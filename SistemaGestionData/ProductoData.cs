using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaGestionData
{
    public class ProductoData
    {
        public static List<Producto> ObtenerProductoData(int IdProducto)
        {

            List<Producto> list = new List<Producto>();
            string connectionString = @"Server=localhost\SQLEXPRESS; Database=SistemaGestion ;Trusted_Connection= True;";
            var query = "SELECT Id, Descripciones,Costo, PrecioVenta, Stock, IdUsuario From Producto Where Id=@IdProducto";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    var parametro = new SqlParameter();
                    parametro.ParameterName = "IdProducto";
                    parametro.SqlDbType = SqlDbType.Int;
                    parametro.Value = IdProducto;

                    comando.Parameters.Add(parametro);
                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                var producto = new Producto();
                                producto.Id = Convert.ToInt32(dr["id"]);
                                producto.Descripciones = dr["Descripciones"].ToString();
                                producto.Costo = Convert.ToDecimal(dr["Costo"]);
                                producto.PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]);
                                producto.Stock = Convert.ToDecimal(dr["Stock"]);
                                producto.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                                list.Add(producto);

                            }
                        }


                    }
                }
                return list;
            }
        }
        public static List<Producto> ListarProductoData()
        {

            List<Producto> list = new List<Producto>();
            string connectionString = @"Server=localhost\SQLEXPRESS; Database=SistemaGestion ;Trusted_Connection= True;";
            var query = "SELECT Id, Descripciones,Costo, PrecioVenta, Stock, IdUsuario From Producto";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {

                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                var producto = new Producto();
                                producto.Id = Convert.ToInt32(dr["id"]);
                                producto.Descripciones = dr["Descripciones"].ToString();
                                producto.Costo = Convert.ToDecimal(dr["Costo"]);
                                producto.PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]);
                                producto.Stock = Convert.ToDecimal(dr["Stock"]);
                                producto.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                                list.Add(producto);

                            }
                        }

                        return list;
                    }

                }
            }
        }
        public static void CrearProductoData(Producto producto)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS; Database=SistemaGestion ;Trusted_Connection= True;";
            var query = "INSERT INTO Producto (Descripciones,Costo, PrecioVenta, Stock, IdUsuario)" +
            "VALUES(@Descripciones,@Costo, @PrecioVenta, @Stock, @IdUsuario)";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Descripciones", SqlDbType.VarChar) { Value = producto.Descripciones });
                    comando.Parameters.Add(new SqlParameter("Costo", SqlDbType.Money) { Value = producto.Costo });
                    comando.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Money) { Value = producto.PrecioVenta });
                    comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Money) { Value = producto.Stock });
                    comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = producto.IdUsuario });

                }
                conexion.Close();
            }

        }
        public static void ModificarProductoData(Producto producto)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS; Database=SistemaGestion ;Trusted_Connection= True;";
            var query = "UPDATE Producto" +
                        "SET Descripciones = @Descripciones " +
                         ", Costo = @Costo" +
                         "PrecioVenta = @PrecioVenta" +
                         "Stock = @Stock" +
                         "IdUsuario = @IdUsuario";


            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Descripciones", SqlDbType.VarChar) { Value = producto.Descripciones });
                    comando.Parameters.Add(new SqlParameter("Costo", SqlDbType.Money) { Value = producto.Costo });
                    comando.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Money) { Value = producto.PrecioVenta });
                    comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Money) { Value = producto.Stock });
                    comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = producto.IdUsuario });

                }
                conexion.Close();
            }


        }
        public static void EliminarProductoData(Producto producto)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS; Database=SistemaGestion ;Trusted_Connection= True;";
            var query = "DELETE FROM Producto WHERE Id = @Id";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = producto.Id });
                }
                conexion.Close();
            }
        }
    }
}
