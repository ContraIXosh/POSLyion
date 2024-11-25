using CapaEntidad;
using EntityLayer.Filtros;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class CD_Usuarios
    {

        public int Crear(Usuarios oUsuario, out string mensaje)
        {
            mensaje = string.Empty;
            var id_generada_usuario = 0;
            try
            {
                using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
                {
                    oConexion.Open();
                    var command = new SqlCommand("SP_ALTA_USUARIO", oConexion);
                    _ = command.Parameters.AddWithValue("dni", oUsuario.Dni);
                    _ = command.Parameters.AddWithValue("nombre_completo", oUsuario.Nombre_completo);
                    _ = command.Parameters.AddWithValue("correo", oUsuario.Correo);
                    _ = command.Parameters.AddWithValue("nombre_usuario", oUsuario.Nombre_usuario);
                    _ = command.Parameters.AddWithValue("clave", oUsuario.Clave);
                    _ = command.Parameters.AddWithValue("id_rol", oUsuario.oRol.Id_rol);
                    _ = command.Parameters.AddWithValue("telefono", oUsuario.Telefono);
                    _ = command.Parameters.AddWithValue("estado", oUsuario.Estado);
                    command.Parameters.Add("mensaje", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    command.Parameters.Add("id_generada_usuario", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    _ = command.ExecuteNonQuery();
                    id_generada_usuario = Convert.ToInt32(command.Parameters["id_generada_usuario"].Value);
                    mensaje = command.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                id_generada_usuario = 0;
                mensaje = ex.Message;
            }
            return id_generada_usuario;
        }

        public List<Usuarios> Leer(FiltrosUsuario filtros)
        {
            var lista_usuarios = new List<Usuarios>();
            using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    oConexion.Open();
                    var query = new StringBuilder();
                    _ = query.AppendLine("SELECT u.id_usuario, u.dni, u.nombre_completo, u.correo, u.nombre_usuario, u.clave, u.telefono, u.estado, r.id_rol, r.descripcion FROM Usuarios u");
                    _ = query.AppendLine("INNER JOIN Roles r ON r.id_rol = u.id_rol");
                    _ = query.AppendLine("WHERE (u.nombre_usuario LIKE '%' + @nombre_usuario + '%')");
                    _ = query.AppendLine("AND (u.id_rol = IIF(@id_rol = 0, u.id_rol, @id_rol))");
                    _ = query.AppendLine("AND (u.estado = @estado)");
                    var command = new SqlCommand(query.ToString(), oConexion);
                    _ = command.Parameters.AddWithValue("@nombre_usuario", filtros.Nombre_usuario);
                    _ = command.Parameters.AddWithValue("@id_rol", filtros.Id_rol);
                    _ = command.Parameters.AddWithValue("@estado", filtros.Estado);
                    command.CommandType = CommandType.Text;
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista_usuarios.Add(new Usuarios()
                            {
                                Id_usuario = Convert.ToInt32(reader["id_usuario"]),
                                Dni = reader["dni"].ToString(),
                                Nombre_completo = reader["nombre_completo"].ToString(),
                                Correo = reader["correo"].ToString(),
                                Nombre_usuario = reader["nombre_usuario"].ToString(),
                                Clave = reader["clave"].ToString(),
                                oRol = new Roles()
                                {
                                    Id_rol = Convert.ToInt32(reader["id_rol"]),
                                    Descripcion = reader["descripcion"].ToString()
                                },
                                Telefono = reader["telefono"].ToString(),
                                Estado = Convert.ToBoolean(reader["estado"])
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista_usuarios = new List<Usuarios>();
                }
            }
            return lista_usuarios;
        }

        public bool Modificar(Usuarios oUsuario, out string mensaje)
        {
            mensaje = string.Empty;
            var resultado = false;
            try
            {
                using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
                {
                    oConexion.Open();
                    var command = new SqlCommand("SP_MODIFICAR_USUARIO", oConexion);
                    _ = command.Parameters.AddWithValue("id_usuario", oUsuario.Id_usuario);
                    _ = command.Parameters.AddWithValue("dni", oUsuario.Dni);
                    _ = command.Parameters.AddWithValue("nombre_completo", oUsuario.Nombre_completo);
                    _ = command.Parameters.AddWithValue("correo", oUsuario.Correo);
                    _ = command.Parameters.AddWithValue("nombre_usuario", oUsuario.Nombre_usuario);
                    _ = command.Parameters.AddWithValue("clave", oUsuario.Clave);
                    _ = command.Parameters.AddWithValue("id_rol", oUsuario.oRol.Id_rol);
                    _ = command.Parameters.AddWithValue("telefono", oUsuario.Telefono);
                    _ = command.Parameters.AddWithValue("estado", oUsuario.Estado);
                    command.Parameters.Add("mensaje", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    command.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    _ = command.ExecuteNonQuery();
                    resultado = Convert.ToBoolean(command.Parameters["resultado"].Value);
                    mensaje = command.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                resultado = false;
                mensaje = ex.Message;
            }
            return resultado;
        }

        public bool Eliminar(Usuarios oUsuario, out string mensaje)
        {
            mensaje = string.Empty;
            var resultado = false;
            try
            {
                using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
                {
                    oConexion.Open();
                    var command = new SqlCommand("SP_BAJA_USUARIO", oConexion);
                    _ = command.Parameters.AddWithValue("id_usuario", oUsuario.Id_usuario);
                    command.Parameters.Add("mensaje", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    command.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    _ = command.ExecuteNonQuery();
                    resultado = Convert.ToBoolean(command.Parameters["resultado"].Value);
                    mensaje = command.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                resultado = false;
                mensaje = ex.Message;
            }
            return resultado;
        }

        public bool Restaurar(Usuarios oUsuario, out string mensaje)
        {
            mensaje = string.Empty;
            var resultado = false;
            try
            {
                using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
                {
                    oConexion.Open();
                    var command = new SqlCommand("SP_RESTAURAR_USUARIO", oConexion);
                    _ = command.Parameters.AddWithValue("id_usuario", oUsuario.Id_usuario);
                    command.Parameters.Add("mensaje", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    command.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    _ = command.ExecuteNonQuery();
                    resultado = Convert.ToBoolean(command.Parameters["resultado"].Value);
                    mensaje = command.Parameters["mensaje"].Value.ToString();
                }
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
