using CapaDatos;
using CapaEntidad;
using CapaEntidad.GraficosVentas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CD_Ventas
    {
        public bool RestarStock(int id_producto, int cantidad)
        {
            bool respuesta = true;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    StringBuilder consulta = new StringBuilder();
                    consulta.AppendLine("UPDATE Productos SET stock_actual = stock_actual - @cantidad WHERE id_producto = @id_producto");
                    SqlCommand cmd = new SqlCommand(consulta.ToString(), oConexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@id_producto", id_producto);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();
                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

        public bool SumarStock(int id_producto, int cantidad)
        {
            bool respuesta = true;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    StringBuilder consulta = new StringBuilder();
                    consulta.AppendLine("UPDATE Productos SET stock_actual = stock_actual + @cantidad WHERE id_producto = @id_producto");
                    SqlCommand cmd = new SqlCommand(consulta.ToString(), oConexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@id_producto", id_producto);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();
                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

        public bool Crear(Ventas oVenta, DataTable VentaDetalle, out string mensaje, out int id_venta_generado)
        {
            bool respuesta = false;
            mensaje = string.Empty;
            id_venta_generado = 0;
            try
            {
                using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand("SP_ALTA_VENTA", oConexion);
                    cmd.Parameters.AddWithValue("id_usuario", oVenta.oUsuario.Id_usuario);
                    cmd.Parameters.AddWithValue("id_cliente", oVenta.oCliente.Id_cliente);
                    cmd.Parameters.AddWithValue("total", oVenta.Total);
                    cmd.Parameters.AddWithValue("vuelto", oVenta.Vuelto);
                    cmd.Parameters.AddWithValue("VentaDetalle", VentaDetalle);
                    cmd.Parameters.Add("resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("id_venta_generado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["resultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                    id_venta_generado = Convert.ToInt32(cmd.Parameters["id_venta_generado"].Value);
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                mensaje = ex.Message;
            }
            return respuesta;
        }

        public List<Ventas> Leer(string fecha_inicio, string fecha_fin)
        {
            List<Ventas> lista_ventas = new List<Ventas>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    string query = "SELECT id_venta[NumeroVenta], v.create_date[FechaVenta], c.nombre_completo[NombreCliente], total[Total] FROM Ventas v INNER JOIN Clientes c ON v.id_cliente = c.id_cliente WHERE CONVERT(DATE,v.create_date) BETWEEN @fecha_inicio AND @fecha_fin";
                    SqlCommand cmd = new SqlCommand(query, oConexion);
                    cmd.Parameters.AddWithValue("@fecha_inicio", fecha_inicio);
                    cmd.Parameters.AddWithValue("@fecha_fin", fecha_fin);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista_ventas.Add(new Ventas()
                            {
                                Id_venta = Convert.ToInt32(reader["NumeroVenta"].ToString()),
                                Create_date = reader["FechaVenta"].ToString(),
                                oCliente = new Clientes() { Nombre_completo = reader["NombreCliente"].ToString() },
                                Total = Convert.ToDecimal(reader["Total"].ToString())
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista_ventas = new List<Ventas>();
                }
            }
            return lista_ventas;
        }

        public Ventas VerTotalVentasDesde(string fecha, int id_usuario)
        {
            Ventas ventas = new Ventas();
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT SUM(total)[Total] FROM Ventas");
                    query.AppendLine("WHERE CONVERT(DATETIME, create_date) > @fecha");
                    query.AppendLine("AND id_usuario = @id_usuario");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.Parameters.AddWithValue("@fecha", fecha);
                    cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            ventas.Total = Convert.ToDecimal(reader["Total"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    ventas = new Ventas();
                }
            }
            return ventas;
        }

        public List<DatosGraficoMensual> VentasMensuales()
        {
            List<DatosGraficoMensual> lista_ventas = new List<DatosGraficoMensual>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT DATEPART(MONTH, create_date)[mes], COUNT(*)[cantidad_ventas] FROM Ventas");
                    query.AppendLine("GROUP BY  DATEPART(MONTH, create_date) ORDER BY mes;");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista_ventas.Add(new DatosGraficoMensual()
                            {
                                Mes = Convert.ToInt32(reader["mes"].ToString()),
                                Cantidad = Convert.ToInt32(reader["cantidad_ventas"].ToString())
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista_ventas = new List<DatosGraficoMensual>();
                }
            }
            return lista_ventas;
        }

        public List<DatosGraficoUsuarios> VentasMensualesUsuarios()
        {
            List<DatosGraficoUsuarios> lista_ventas = new List<DatosGraficoUsuarios>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT u.nombre_usuario[NombreUsuario], COUNT(v.id_usuario)[CantidadVentas], DATEPART(MONTH, v.create_date)[Mes]");
                    query.AppendLine("FROM Ventas v INNER JOIN Usuarios u ON v.id_usuario = u.id_usuario");
                    query.AppendLine("WHERE v.create_date >= '2024-01-01' AND v.create_date < '2024-12-31'");
                    query.AppendLine("GROUP BY u.nombre_usuario, DATEPART(MONTH, v.create_date) ORDER BY u.nombre_usuario;");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista_ventas.Add(new DatosGraficoUsuarios()
                            {
                                Nombre_usuario = reader["NombreUsuario"].ToString(),
                                Mes = Convert.ToInt32(reader["Mes"].ToString()),
                                Cantidad = Convert.ToInt32(reader["CantidadVentas"].ToString())
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista_ventas = new List<DatosGraficoUsuarios>();
                }
            }
            return lista_ventas;
        }
    }
}
