using CapaDatos;
using CapaEntidad;
using CapaEntidad.GraficosVentas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CD_Ventas
    {
        public async Task<bool> RestarStockAsync(int id_producto, int cantidad)
        {
            var respuesta = true;
            using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    using (var cmd = new SqlCommand("SP_RESTAR_STOCK", oConexion))
                    {
                        _ = cmd.Parameters.AddWithValue("@id_producto", id_producto);
                        _ = cmd.Parameters.AddWithValue("@cantidad", cantidad);
                        cmd.Parameters.Add("resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                        cmd.CommandType = CommandType.StoredProcedure;
                        await oConexion.OpenAsync();
                        _ = await cmd.ExecuteNonQueryAsync();
                        respuesta = Convert.ToBoolean(cmd.Parameters["resultado"].Value);
                    }
                }
                catch (Exception)
                {
                    respuesta = false;
                }
                finally
                {
                    oConexion.Close();
                }
            }
            return respuesta;
        }

        public async Task<bool> SumarStockAsync(int id_producto, int cantidad)
        {
            var respuesta = true;
            using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    using (var cmd = new SqlCommand("SP_SUMAR_STOCK", oConexion))
                    {
                        _ = cmd.Parameters.AddWithValue("@id_producto", id_producto);
                        _ = cmd.Parameters.AddWithValue("@cantidad", cantidad);
                        cmd.Parameters.Add("resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                        cmd.CommandType = CommandType.StoredProcedure;
                        await oConexion.OpenAsync();
                        _ = await cmd.ExecuteNonQueryAsync();
                        respuesta = Convert.ToBoolean(cmd.Parameters["resultado"].Value);
                    }
                }
                catch (Exception)
                {
                    respuesta = false;
                }
                finally
                {
                    oConexion.Close();
                }
            }
            return respuesta;
        }

        public bool Crear(Ventas oVenta, DataTable VentaDetalle, out string mensaje, out int id_venta_generado)
        {
            var respuesta = false;
            mensaje = string.Empty;
            id_venta_generado = 0;
            try
            {
                using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
                {
                    var cmd = new SqlCommand("SP_ALTA_VENTA", oConexion);
                    _ = cmd.Parameters.AddWithValue("id_usuario", oVenta.oUsuario.Id_usuario);
                    _ = cmd.Parameters.AddWithValue("id_cliente", oVenta.oCliente.Id_cliente);
                    _ = cmd.Parameters.AddWithValue("total", oVenta.Total);
                    _ = cmd.Parameters.AddWithValue("vuelto", oVenta.Vuelto);
                    _ = cmd.Parameters.AddWithValue("VentaDetalle", VentaDetalle);
                    cmd.Parameters.Add("resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("id_venta_generado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oConexion.Open();
                    _ = cmd.ExecuteNonQuery();
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
            var lista_ventas = new List<Ventas>();
            using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    var query = "SELECT id_venta[NumeroVenta], v.create_date[FechaVenta], c.nombre_completo[NombreCliente], total[Total] FROM Ventas v INNER JOIN Clientes c ON v.id_cliente = c.id_cliente WHERE CONVERT(DATE,v.create_date) BETWEEN @fecha_inicio AND @fecha_fin";
                    var cmd = new SqlCommand(query, oConexion);
                    _ = cmd.Parameters.AddWithValue("@fecha_inicio", fecha_inicio);
                    _ = cmd.Parameters.AddWithValue("@fecha_fin", fecha_fin);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();
                    using (var reader = cmd.ExecuteReader())
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
                catch (Exception)
                {
                    lista_ventas = new List<Ventas>();
                }
            }
            return lista_ventas;
        }

        public Ventas VerTotalVentasDesde(string fecha, int id_usuario)
        {
            var ventas = new Ventas();
            using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    var query = new StringBuilder();
                    _ = query.AppendLine("SELECT SUM(total)[Total] FROM Ventas");
                    _ = query.AppendLine("WHERE CONVERT(DATETIME, create_date) > @fecha");
                    _ = query.AppendLine("AND id_usuario = @id_usuario");
                    var cmd = new SqlCommand(query.ToString(), oConexion);
                    _ = cmd.Parameters.AddWithValue("@fecha", fecha);
                    _ = cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ventas.Total = Convert.ToDecimal(reader["Total"].ToString());
                        }
                    }
                }
                catch (Exception)
                {
                    ventas = new Ventas();
                }
            }
            return ventas;
        }

        public List<DatosGraficoMensual> VentasMensuales()
        {
            var lista_ventas = new List<DatosGraficoMensual>();
            using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    var query = new StringBuilder();
                    _ = query.AppendLine("SELECT DATEPART(MONTH, create_date)[mes], COUNT(*)[cantidad_ventas] FROM Ventas");
                    _ = query.AppendLine("GROUP BY  DATEPART(MONTH, create_date) ORDER BY mes;");
                    var cmd = new SqlCommand(query.ToString(), oConexion)
                    {
                        CommandType = CommandType.Text
                    };
                    oConexion.Open();
                    using (var reader = cmd.ExecuteReader())
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
                catch (Exception)
                {
                    lista_ventas = new List<DatosGraficoMensual>();
                }
            }
            return lista_ventas;
        }

        public List<DatosGraficoUsuarios> VentasMensualesUsuarios()
        {
            var lista_ventas = new List<DatosGraficoUsuarios>();
            using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    var query = new StringBuilder();
                    _ = query.AppendLine("SELECT u.nombre_usuario[NombreUsuario], COUNT(v.id_usuario)[CantidadVentas], DATEPART(MONTH, v.create_date)[Mes]");
                    _ = query.AppendLine("FROM Ventas v INNER JOIN Usuarios u ON v.id_usuario = u.id_usuario");
                    _ = query.AppendLine("WHERE v.create_date >= '2024-01-01' AND v.create_date < '2024-12-31'");
                    _ = query.AppendLine("GROUP BY u.nombre_usuario, DATEPART(MONTH, v.create_date) ORDER BY u.nombre_usuario;");
                    var cmd = new SqlCommand(query.ToString(), oConexion)
                    {
                        CommandType = CommandType.Text
                    };
                    oConexion.Open();
                    using (var reader = cmd.ExecuteReader())
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
                catch (Exception)
                {
                    lista_ventas = new List<DatosGraficoUsuarios>();
                }
            }
            return lista_ventas;
        }
    }
}
