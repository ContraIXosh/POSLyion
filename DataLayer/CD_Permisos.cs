using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class CD_Permisos
    {
        public List<Permisos> Leer(int id_usuario)
        {
            var lista_permisos = new List<Permisos>();
            using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    oConexion.Open();
                    var query = new StringBuilder();
                    _ = query.AppendLine("SELECT p.id_rol, p.nombre_menu FROM Permisos p");
                    _ = query.AppendLine("INNER JOIN Roles r ON r.id_rol = p.id_rol");
                    _ = query.AppendLine("INNER JOIN Usuarios u ON u.id_rol = r.id_rol");
                    _ = query.AppendLine("WHERE u.id_usuario = @id_usuario");
                    var command = new SqlCommand(query.ToString(), oConexion);
                    _ = command.Parameters.AddWithValue("@id_usuario", id_usuario);
                    command.CommandType = CommandType.Text;
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista_permisos.Add(new Permisos()
                            {
                                oRol = new Roles()
                                {
                                    Id_rol = Convert.ToInt32(reader["id_rol"])
                                },
                                Nombre_menu = reader["nombre_menu"].ToString()
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista_permisos = new List<Permisos>();
                }
            }
            return lista_permisos;
        }

        public List<Permisos> LeerTodo(int id_usuario)
        {
            var lista_permisos = new List<Permisos>();
            using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    oConexion.Open();
                    var query = new StringBuilder();
                    _ = query.AppendLine("SELECT p.id_rol, p.nombre_menu FROM Permisos p");
                    _ = query.AppendLine("INNER JOIN Roles r ON r.id_rol = p.id_rol");
                    _ = query.AppendLine("INNER JOIN Usuarios u ON u.id_rol = r.id_rol");
                    _ = query.AppendLine("WHERE u.id_usuario = @id_usuario");
                    var command = new SqlCommand(query.ToString(), oConexion);
                    _ = command.Parameters.AddWithValue("@id_usuario", id_usuario);
                    command.CommandType = CommandType.Text;
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista_permisos.Add(new Permisos()
                            {
                                oRol = new Roles()
                                {
                                    Id_rol = Convert.ToInt32(reader["id_rol"])
                                },
                                Nombre_menu = reader["nombre_menu"].ToString()
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista_permisos = new List<Permisos>();
                }
            }
            return lista_permisos;
        }
    }
}
