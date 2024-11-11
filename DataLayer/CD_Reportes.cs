﻿using CapaDatos;
using CapaEntidad;
using CapaEntidad.Filtros;
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
        public List<ReportesDetalle> Compra_Detalle(FiltrosReportes filtros)
        {
            List<ReportesDetalle> lista_compra_detalle = new List<ReportesDetalle>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    SqlCommand cmd = new SqlCommand("SP_HISTORIAL_COMPRAS", oConexion);
                    cmd.Parameters.AddWithValue("@fecha_desde", filtros.Fecha_desde);
                    cmd.Parameters.AddWithValue("@fecha_hasta", filtros.Fecha_hasta);
                    cmd.Parameters.AddWithValue("@id_compra", filtros.Id);
                    cmd.Parameters.AddWithValue("@id_usuario", filtros.Id_usuario);
                    cmd.Parameters.AddWithValue("@id_proveedor", filtros.Campo_adicional);
                    cmd.Parameters.AddWithValue("@nombre_producto", filtros.Nombre_producto);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    oConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            lista_compra_detalle.Add(new ReportesDetalle()
                            {
                                Id = Convert.ToInt32(reader["NumeroCompra"].ToString()),
                                Codigo_barras = reader["CodigoBarras"].ToString(),
                                Nombre_producto = reader["NombreProducto"].ToString(),
                                Nombre_categoria = reader["NombreCategoria"].ToString(),
                                Precio_unitario = Convert.ToDecimal(reader["PrecioUnitario"].ToString()),
                                Cantidad = Convert.ToInt32(reader["Cantidad"].ToString()),
                                Campo_adicional = reader["NombreProveedor"].ToString(),
                                Subtotal = Convert.ToDecimal(reader["Subtotal"].ToString()),
                                UsuarioRegistro = reader["UsuarioRegistro"].ToString(),
                                FechaDocumento = reader["FechaDocumento"].ToString(),
                                FechaRegistro = reader["FechaRegistro"].ToString()
                            }); ;
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

        public List<ReportesDetalle> Venta_Detalle(FiltrosReportes filtros)
        {
            List<ReportesDetalle> lista_venta_detalle = new List<ReportesDetalle>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    SqlCommand cmd = new SqlCommand("SP_HISTORIAL_VENTAS", oConexion);
                    cmd.Parameters.AddWithValue("@fecha_desde", filtros.Fecha_desde);
                    cmd.Parameters.AddWithValue("@fecha_hasta", filtros.Fecha_hasta);
                    cmd.Parameters.AddWithValue("@id_venta", filtros.Id);
                    cmd.Parameters.AddWithValue("@id_usuario", filtros.Id_usuario);
                    cmd.Parameters.AddWithValue("@id_cliente", filtros.Campo_adicional);
                    cmd.Parameters.AddWithValue("@nombre_producto", filtros.Nombre_producto);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    oConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista_venta_detalle.Add(new ReportesDetalle()
                            {
                                Id = Convert.ToInt32(reader["NumeroVenta"].ToString()),
                                Codigo_barras = reader["CodigoBarras"].ToString(),
                                Nombre_producto = reader["NombreProducto"].ToString(),
                                Nombre_categoria = reader["NombreCategoria"].ToString(),
                                Precio_unitario = Convert.ToDecimal(reader["PrecioUnitario"].ToString()),
                                Cantidad = Convert.ToInt32(reader["Cantidad"].ToString()),
                                Campo_adicional = reader["NombreCliente"].ToString(),
                                Subtotal = Convert.ToDecimal(reader["Subtotal"].ToString()),
                                UsuarioRegistro = reader["UsuarioRegistro"].ToString(),
                                FechaRegistro = reader["FechaRegistro"].ToString()
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