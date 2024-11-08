using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Reportes
    {
        public List<ReportesDetalle> Compra_Detalle(int id_compra)
        {
            List<ReportesDetalle> lista_compra_detalle = new List<ReportesDetalle>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    SqlCommand cmd = new SqlCommand("SP_HISTORIAL_COMPRAS", oConexion);
                    cmd.Parameters.AddWithValue("id_compra", id_compra);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    oConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            lista_compra_detalle.Add(new ReportesDetalle()
                            {
                                Codigo_barras = reader["CodigoBarras"].ToString(),
                                Nombre_producto = reader["NombreProducto"].ToString(),
                                Nombre_categoria = reader["NombreCategoria"].ToString(),
                                Precio_unitario = Convert.ToDecimal(reader["PrecioUnitario"].ToString()),
                                Cantidad = Convert.ToInt32(reader["Cantidad"].ToString()),
                                Subtotal = Convert.ToDecimal(reader["Subtotal"].ToString())
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista_compra_detalle = new List<ReportesDetalle>();
                }
            }
            return lista_compra_detalle;
        }

        public List<ReportesDetalle> Venta_Detalle(int id_venta)
        {
            List<ReportesDetalle> lista_venta_detalle = new List<ReportesDetalle>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    SqlCommand cmd = new SqlCommand("SP_HISTORIAL_VENTAS", oConexion);
                    cmd.Parameters.AddWithValue("id_venta", id_venta);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    oConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista_venta_detalle.Add(new ReportesDetalle()
                            {
                                Codigo_barras = reader["CodigoBarras"].ToString(),
                                Nombre_producto = reader["NombreProducto"].ToString(),
                                Nombre_categoria = reader["NombreCategoria"].ToString(),
                                Precio_unitario = Convert.ToDecimal(reader["PrecioUnitario"].ToString()),
                                Cantidad = Convert.ToInt32(reader["Cantidad"].ToString()),
                                Subtotal = Convert.ToDecimal(reader["Subtotal"].ToString())
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista_venta_detalle = new List<ReportesDetalle>();
                }
            }
            return lista_venta_detalle;
        }
    }
 
}
