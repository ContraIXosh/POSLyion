using CapaEntidad;
using CapaEntidad.Filtros;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class CD_Proveedores
    {
        public int Crear(Proveedores oProveedor, out string mensaje)
        {
            mensaje = string.Empty;
            using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                int id_generada_proveedor;
                try
                {
                    oConexion.Open();
                    var command = new SqlCommand("SP_ALTA_PROVEEDOR", oConexion);
                    _ = command.Parameters.AddWithValue("cuit", oProveedor.Cuit);
                    _ = command.Parameters.AddWithValue("descripcion", oProveedor.Descripcion);
                    _ = command.Parameters.AddWithValue("correo", oProveedor.Correo);
                    _ = command.Parameters.AddWithValue("telefono", oProveedor.Telefono);
                    command.Parameters.Add("mensaje", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    command.Parameters.Add("id_generada_proveedor", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    _ = command.ExecuteNonQuery();
                    id_generada_proveedor = Convert.ToInt32(command.Parameters["id_generada_proveedor"].Value);
                    mensaje = command.Parameters["mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    id_generada_proveedor = 0;
                    mensaje = ex.Message;
                }
                return id_generada_proveedor;
            }
        }

        public List<Proveedores> Leer(FiltrosProveedor filtros)
        {
            var lista_proveedores = new List<Proveedores>();
            using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    oConexion.Open();
                    var query = new StringBuilder();
                    _ = query.AppendLine("SELECT id_proveedor, cuit, descripcion, correo, telefono, estado FROM Proveedores");
                    _ = query.AppendLine("WHERE (descripcion LIKE '%' + @nombre_proveedor + '%')");
                    _ = query.AppendLine("AND (estado = @estado)");
                    var command = new SqlCommand(query.ToString(), oConexion)
                    {
                        CommandType = CommandType.Text
                    };
                    _ = command.Parameters.AddWithValue("@nombre_proveedor", filtros.Nombre_proveedor);
                    _ = command.Parameters.AddWithValue("@estado", filtros.Estado);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista_proveedores.Add(new Proveedores()
                            {
                                Id_proveedor = Convert.ToInt32(reader["id_proveedor"]),
                                Cuit = reader["cuit"].ToString(),
                                Descripcion = reader["descripcion"].ToString(),
                                Correo = reader["correo"].ToString(),
                                Telefono = reader["telefono"].ToString(),
                                Estado = Convert.ToBoolean(reader["estado"])
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista_proveedores = new List<Proveedores>();
                }
                return lista_proveedores;
            }
        }

        public bool Modificar(Proveedores oProveedor, out string mensaje)
        {
            mensaje = string.Empty;
            using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                bool resultado;
                try
                {
                    oConexion.Open();
                    var command = new SqlCommand("SP_MODIFICAR_PROVEEDOR", oConexion);
                    _ = command.Parameters.AddWithValue("id_proveedor", oProveedor.Id_proveedor);
                    _ = command.Parameters.AddWithValue("cuit", oProveedor.Cuit);
                    _ = command.Parameters.AddWithValue("descripcion", oProveedor.Descripcion);
                    _ = command.Parameters.AddWithValue("correo", oProveedor.Correo);
                    _ = command.Parameters.AddWithValue("telefono", oProveedor.Telefono);
                    _ = command.Parameters.AddWithValue("estado", oProveedor.Estado);
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

        public bool Eliminar(Proveedores oProveedor, out string mensaje)
        {
            mensaje = string.Empty;
            using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                bool resultado;
                try
                {
                    oConexion.Open();
                    var command = new SqlCommand("SP_BAJA_PROVEEDOR", oConexion);
                    _ = command.Parameters.AddWithValue("id_proveedor", oProveedor.Id_proveedor);
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

        public bool Restaurar(Proveedores oProveedor, out string mensaje)
        {
            mensaje = string.Empty;
            using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                bool resultado;
                try
                {
                    oConexion.Open();
                    var command = new SqlCommand("SP_RESTAURAR_PROVEEDOR", oConexion);
                    _ = command.Parameters.AddWithValue("id_proveedor", oProveedor.Id_proveedor);
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
