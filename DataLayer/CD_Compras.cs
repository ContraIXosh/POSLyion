using CapaEntidad;
using CapaEntidad.GraficosVentas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class CD_Compras
    {
        public bool Crear(Compras oCompra, DataTable CompraDetalle, out string mensaje)
        {
            var respuesta = false;
            mensaje = string.Empty;
            try
            {
                using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
                {
                    var cmd = new SqlCommand("SP_ALTA_COMPRA", oConexion);
                    _ = cmd.Parameters.AddWithValue("id_usuario", oCompra.oUsuario.Id_usuario);
                    _ = cmd.Parameters.AddWithValue("id_proveedor", oCompra.oProveedor.Id_proveedor);
                    _ = cmd.Parameters.AddWithValue("total", oCompra.Total);
                    _ = cmd.Parameters.AddWithValue("tipo_documento", oCompra.Tipo_documento);
                    _ = cmd.Parameters.AddWithValue("numero_documento", oCompra.Numero_documento);
                    _ = cmd.Parameters.AddWithValue("fecha_documento", oCompra.Fecha_documento);
                    _ = cmd.Parameters.AddWithValue("CompraDetalle", CompraDetalle);
                    cmd.Parameters.Add("resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oConexion.Open();
                    _ = cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["resultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                mensaje = ex.Message;
            }
            return respuesta;
        }

        public List<Compras> Leer(string fecha_inicio, string fecha_fin)
        {
            var lista_compras = new List<Compras>();
            using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    var query = "SELECT id_compra, id_proveedor, total, numero_documento, fecha_documento FROM Compras WHERE (CONVERT(DATE,create_date) BETWEEN @fecha_inicio AND @fecha_fin)";
                    var cmd = new SqlCommand(query, oConexion);
                    _ = cmd.Parameters.AddWithValue("@fecha_inicio", fecha_inicio);
                    _ = cmd.Parameters.AddWithValue("@fecha_fin", fecha_fin);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista_compras.Add(new Compras()
                            {
                                Id_compra = Convert.ToInt32(reader["id_compra"].ToString()),
                                oProveedor = new Proveedores() { Id_proveedor = Convert.ToInt32(reader["id_proveedor"].ToString()) },
                                Total = Convert.ToDecimal(reader["total"].ToString()),
                                Numero_documento = reader["numero_documento"].ToString(),
                                Fecha_documento = reader["fecha_documento"].ToString()
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista_compras = new List<Compras>();
                }
            }
            return lista_compras;
        }

        public List<DatosGraficoMensual> ComprasMensuales()
        {
            var lista_compras = new List<DatosGraficoMensual>();
            using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    var query = new StringBuilder();
                    _ = query.AppendLine("SELECT DATEPART(MONTH, create_date)[mes], COUNT(*)[cantidad_compras] FROM Compras");
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
                            lista_compras.Add(new DatosGraficoMensual()
                            {
                                Mes = Convert.ToInt32(reader["mes"].ToString()),
                                Cantidad = Convert.ToInt32(reader["cantidad_compras"].ToString())
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista_compras = new List<DatosGraficoMensual>();
                }
            }
            return lista_compras;
        }

        public List<DatosGraficoUsuarios> ComprasMensualesUsuarios()
        {
            var lista_compras = new List<DatosGraficoUsuarios>();
            using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    var query = new StringBuilder();
                    _ = query.AppendLine("SELECT u.nombre_usuario[NombreUsuario], COUNT(c.id_usuario)[CantidadCompras], DATEPART(MONTH, c.create_date)[Mes]");
                    _ = query.AppendLine("FROM Compras c INNER JOIN Usuarios u ON c.id_usuario = u.id_usuario");
                    _ = query.AppendLine("WHERE c.create_date >= '2024-01-01' AND c.create_date < '2024-12-31'");
                    _ = query.AppendLine("GROUP BY u.nombre_usuario, DATEPART(MONTH, c.create_date) ORDER BY u.nombre_usuario;");
                    var cmd = new SqlCommand(query.ToString(), oConexion)
                    {
                        CommandType = CommandType.Text
                    };
                    oConexion.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista_compras.Add(new DatosGraficoUsuarios()
                            {
                                Nombre_usuario = reader["NombreUsuario"].ToString(),
                                Mes = Convert.ToInt32(reader["Mes"].ToString()),
                                Cantidad = Convert.ToInt32(reader["CantidadCompras"].ToString())
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista_compras = new List<DatosGraficoUsuarios>();
                }
            }
            return lista_compras;
        }
    }
}
