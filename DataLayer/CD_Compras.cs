﻿using System;
using System.Collections.Generic;
using System.Data;
using CapaEntidad;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad.GraficosVentas;
using System.Reflection;

namespace CapaDatos
{
    public class CD_Compras
    {
        public bool Crear(Compras oCompra, DataTable CompraDetalle, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;
            try
            {
                using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand("SP_ALTA_COMPRA", oConexion);
                    cmd.Parameters.AddWithValue("id_usuario", oCompra.oUsuario.Id_usuario);
                    cmd.Parameters.AddWithValue("id_proveedor", oCompra.oProveedor.Id_proveedor);
                    cmd.Parameters.AddWithValue("total", oCompra.Total);
                    cmd.Parameters.AddWithValue("tipo_documento", oCompra.Tipo_documento);
                    cmd.Parameters.AddWithValue("numero_documento", oCompra.Numero_documento);
                    cmd.Parameters.AddWithValue("fecha_documento", oCompra.Fecha_documento);
                    cmd.Parameters.AddWithValue("CompraDetalle", CompraDetalle);
                    cmd.Parameters.Add("resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
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
            List<Compras> lista_compras = new List<Compras>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    string query = "SELECT id_compra, id_proveedor, total, numero_documento, fecha_documento FROM Compras WHERE (CONVERT(DATE,create_date) BETWEEN @fecha_inicio AND @fecha_fin)";
                    SqlCommand cmd = new SqlCommand(query, oConexion);
                    cmd.Parameters.AddWithValue("@fecha_inicio", fecha_inicio);
                    cmd.Parameters.AddWithValue("@fecha_fin", fecha_fin);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
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
                catch (Exception ex)
                {
                    lista_compras = new List<Compras>();
                }
            }
            return lista_compras;
        }

        public List<DatosGraficoMensual> ComprasMensuales()
        {
            List<DatosGraficoMensual> lista_compras = new List<DatosGraficoMensual>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT DATEPART(MONTH, create_date)[mes], COUNT(*)[cantidad_compras] FROM Compras");
                    query.AppendLine("GROUP BY  DATEPART(MONTH, create_date) ORDER BY mes;");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
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
                catch (Exception ex)
                {
                    lista_compras = new List<DatosGraficoMensual>();
                }
            }
            return lista_compras;
        }

        public List<DatosGraficoUsuarios> ComprasMensualesUsuarios()
        {
            List<DatosGraficoUsuarios> lista_compras = new List<DatosGraficoUsuarios>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT u.nombre_usuario[NombreUsuario], COUNT(c.id_usuario)[CantidadCompras], DATEPART(MONTH, c.create_date)[Mes]");
                    query.AppendLine("FROM Compras c INNER JOIN Usuarios u ON c.id_usuario = u.id_usuario");
                    query.AppendLine("WHERE c.create_date >= '2024-01-01' AND c.create_date < '2024-12-31'");
                    query.AppendLine("GROUP BY u.nombre_usuario, DATEPART(MONTH, c.create_date) ORDER BY u.nombre_usuario;");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
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
                catch (Exception ex)
                {
                    lista_compras = new List<DatosGraficoUsuarios>();
                }
            }
            return lista_compras;
        }
    }
}
