using CapaEntidad;
using CapaEntidad.Filtros;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class CD_Clientes
    {
        public int Crear(Clientes oCliente, out string mensaje)
        {
            mensaje = string.Empty;
            using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                int id_generada_cliente;
                try
                {
                    oConexion.Open();
                    var command = new SqlCommand("SP_ALTA_CLIENTE", oConexion);
                    _ = command.Parameters.AddWithValue("dni", oCliente.Dni);
                    _ = command.Parameters.AddWithValue("nombre_completo", oCliente.Nombre_completo);
                    _ = command.Parameters.AddWithValue("correo", oCliente.Correo);
                    _ = command.Parameters.AddWithValue("telefono", oCliente.Telefono);
                    _ = command.Parameters.AddWithValue("descuento", oCliente.Descuento);
                    command.Parameters.Add("mensaje", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    command.Parameters.Add("id_generada_cliente", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    _ = command.ExecuteNonQuery();
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
            var lista_clientes = new List<Clientes>();
            using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    oConexion.Open();
                    var query = new StringBuilder();
                    _ = query.AppendLine("SELECT id_cliente, dni, nombre_completo, correo, telefono, estado, descuento FROM Clientes");
                    _ = query.AppendLine("WHERE (nombre_completo LIKE '%' + @nombre_cliente + '%')");
                    _ = query.AppendLine("AND (estado = @estado)");
                    var command = new SqlCommand(query.ToString(), oConexion)
                    {
                        CommandType = CommandType.Text
                    };
                    _ = command.Parameters.AddWithValue("@nombre_cliente", filtros.Nombre_cliente);
                    _ = command.Parameters.AddWithValue("@estado", filtros.Estado);
                    using (var reader = command.ExecuteReader())
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
                catch (Exception)
                {
                    lista_clientes = new List<Clientes>();
                }
                return lista_clientes;
            }
        }

        public bool Modificar(Clientes oCliente, out string mensaje)
        {
            mensaje = string.Empty;
            using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                bool resultado;
                try
                {
                    oConexion.Open();
                    var command = new SqlCommand("SP_MODIFICAR_CLIENTE", oConexion);
                    _ = command.Parameters.AddWithValue("id_cliente", oCliente.Id_cliente);
                    _ = command.Parameters.AddWithValue("dni", oCliente.Dni);
                    _ = command.Parameters.AddWithValue("nombre_completo", oCliente.Nombre_completo);
                    _ = command.Parameters.AddWithValue("correo", oCliente.Correo);
                    _ = command.Parameters.AddWithValue("telefono", oCliente.Telefono);
                    _ = command.Parameters.AddWithValue("estado", oCliente.Estado);
                    _ = command.Parameters.AddWithValue("descuento", oCliente.Descuento);
                    command.Parameters.Add("mensaje", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    command.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    _ = command.ExecuteNonQuery();
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
            using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                bool resultado;
                try
                {
                    oConexion.Open();
                    var command = new SqlCommand("SP_BAJA_CLIENTE", oConexion);
                    _ = command.Parameters.AddWithValue("id_cliente", oCliente.Id_cliente);
                    command.Parameters.Add("mensaje", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    command.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    _ = command.ExecuteNonQuery();
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
            using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                bool resultado;
                try
                {
                    oConexion.Open();
                    var command = new SqlCommand("SP_RESTAURAR_CLIENTE", oConexion);
                    _ = command.Parameters.AddWithValue("id_cliente", oCliente.Id_cliente);
                    command.Parameters.Add("mensaje", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    command.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    _ = command.ExecuteNonQuery();
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
