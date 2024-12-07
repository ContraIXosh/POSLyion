﻿using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad.Filtros;

namespace CapaDatos
{
    public class CD_Clientes
    {
        public int Crear(Clientes oCliente, out string mensaje)
        {
            mensaje = string.Empty;
            int id_generada_cliente = 0;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    oConexion.Open();
                    SqlCommand command = new SqlCommand("SP_ALTA_CLIENTE", oConexion);
                    command.Parameters.AddWithValue("dni", oCliente.Dni);
                    command.Parameters.AddWithValue("nombre_completo", oCliente.Nombre_completo);
                    command.Parameters.AddWithValue("correo", oCliente.Correo);
                    command.Parameters.AddWithValue("telefono", oCliente.Telefono);
                    command.Parameters.AddWithValue("descuento", oCliente.Descuento);
                    command.Parameters.Add("mensaje", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    command.Parameters.Add("id_generada_cliente", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    id_generada_cliente = Convert.ToInt32(command.Parameters["id_generada_cliente"].Value);
                    mensaje = command.Parameters["mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    id_generada_cliente = 0;
                    mensaje = ex.Message;
                }
                return id_generada_cliente;
            }
        }

        public List<Clientes> Leer(FiltrosCliente filtros)
        {
            List<Clientes> lista_clientes = new List<Clientes>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    oConexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT id_cliente, dni, nombre_completo, correo, telefono, estado, descuento FROM Clientes");
                    query.AppendLine("WHERE (nombre_completo LIKE '%' + @nombre_cliente + '%')");
                    query.AppendLine("AND (estado = @estado)");
                    SqlCommand command = new SqlCommand(query.ToString(), oConexion);
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@nombre_cliente", filtros.Nombre_cliente);
                    command.Parameters.AddWithValue("@estado", filtros.Estado);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista_clientes.Add(new Clientes()
                            {
                                Id_cliente = Convert.ToInt32(reader["id_cliente"]),
                                Dni = reader["dni"].ToString(),
                                Nombre_completo = reader["nombre_completo"].ToString(),
                                Correo = reader["correo"].ToString(),
                                Telefono = reader["telefono"].ToString(),
                                Estado = Convert.ToBoolean(reader["estado"]),
                                Descuento = Convert.ToInt32(reader["descuento"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista_clientes = new List<Clientes>();
                }
                return lista_clientes;
            }
        }

        public bool Modificar(Clientes oCliente, out string mensaje)
        {
            mensaje = string.Empty;
            bool resultado = false;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    oConexion.Open();
                    SqlCommand command = new SqlCommand("SP_MODIFICAR_CLIENTE", oConexion);
                    command.Parameters.AddWithValue("id_cliente", oCliente.Id_cliente);
                    command.Parameters.AddWithValue("dni", oCliente.Dni);
                    command.Parameters.AddWithValue("nombre_completo", oCliente.Nombre_completo);
                    command.Parameters.AddWithValue("correo", oCliente.Correo);
                    command.Parameters.AddWithValue("telefono", oCliente.Telefono);
                    command.Parameters.AddWithValue("estado", oCliente.Estado);
                    command.Parameters.AddWithValue("descuento", oCliente.Descuento);
                    command.Parameters.Add("mensaje", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    command.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    resultado = Convert.ToBoolean(command.Parameters["resultado"].Value);
                    mensaje = command.Parameters["mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    resultado = false;
                    mensaje = ex.Message;
                }
                return resultado;
            }
        }

        public bool Eliminar(Clientes oCliente, out string mensaje)
        {
            mensaje = string.Empty;
            bool resultado = false;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    oConexion.Open();
                    SqlCommand command = new SqlCommand("SP_BAJA_CLIENTE", oConexion);
                    command.Parameters.AddWithValue("id_cliente", oCliente.Id_cliente);
                    command.Parameters.Add("mensaje", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    command.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    resultado = Convert.ToBoolean(command.Parameters["resultado"].Value);
                    mensaje = command.Parameters["mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    resultado = false;
                    mensaje = ex.Message;
                }
                return resultado;
            }
        }

        public bool Restaurar(Clientes oCliente, out string mensaje)
        {
            mensaje = string.Empty;
            bool resultado = false;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    oConexion.Open();
                    SqlCommand command = new SqlCommand("SP_RESTAURAR_CLIENTE", oConexion);
                    command.Parameters.AddWithValue("id_cliente", oCliente.Id_cliente);
                    command.Parameters.Add("mensaje", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    command.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    resultado = Convert.ToBoolean(command.Parameters["resultado"].Value);
                    mensaje = command.Parameters["mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    resultado = false;
                    mensaje = ex.Message;
                }
                return resultado;
            }
        }
    }
}
