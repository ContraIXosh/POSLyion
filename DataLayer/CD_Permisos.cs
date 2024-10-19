using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Permisos
    {
        public List<Permisos> Leer(int id_usuario)
        {
            List<Permisos> lista_permisos = new List<Permisos>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    oConexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT p.id_rol, p.nombre_menu FROM Permisos p");
                    query.AppendLine("INNER JOIN Roles r ON r.id_rol = p.id_rol");
                    query.AppendLine("INNER JOIN Usuarios u ON u.id_rol = r.id_rol");
                    query.AppendLine("WHERE u.id_usuario = @id_usuario");
                    SqlCommand command = new SqlCommand(query.ToString(), oConexion);
                    command.Parameters.AddWithValue("@id_usuario", id_usuario);
                    command.CommandType = CommandType.Text;
                    using (SqlDataReader reader = command.ExecuteReader())
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
                catch (Exception ex)
                {
                    lista_permisos = new List<Permisos>();
                }
            }
            return lista_permisos;
        }

        public List<Permisos> LeerTodo(int id_usuario)
        {
            List<Permisos> lista_permisos = new List<Permisos>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    oConexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT p.id_rol, p.nombre_menu FROM Permisos p");
                    query.AppendLine("INNER JOIN Roles r ON r.id_rol = p.id_rol");
                    query.AppendLine("INNER JOIN Usuarios u ON u.id_rol = r.id_rol");
                    query.AppendLine("WHERE u.id_usuario = @id_usuario");
                    SqlCommand command = new SqlCommand(query.ToString(), oConexion);
                    command.Parameters.AddWithValue("@id_usuario", id_usuario);
                    command.CommandType = CommandType.Text;
                    using (SqlDataReader reader = command.ExecuteReader())
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
                catch (Exception ex)
                {
                    lista_permisos = new List<Permisos>();
                }
            }
            return lista_permisos;
        }
    }
}
