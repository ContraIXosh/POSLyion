using CapaDatos;
using CapaEntidad;
using EntityLayer.Filtros;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_UsuariosPOS
    {
        public List<UsuariosPOS> Leer()
        {
            List<UsuariosPOS> lista_usuarios_pos = new List<UsuariosPOS>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    oConexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT id_usuario_pos, nombre, clave, nombre_empresa, cantidad_sucursales, email, fecha_vencimiento FROM UsuariosPOS");
                    SqlCommand command = new SqlCommand(query.ToString(), oConexion);
                    command.CommandType = CommandType.Text;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista_usuarios_pos.Add(new UsuariosPOS()
                            {
                                Id_usuario_pos = Convert.ToInt32(reader["id_usuario_pos"].ToString()),
                                Nombre = reader["nombre"].ToString(),
                                Clave = reader["clave"].ToString(),
                                Nombre_empresa = reader["nombre_empresa"].ToString(),
                                Cantidad_sucursales = Convert.ToInt32(reader["cantidad_sucursales"].ToString()),
                                Email = reader["email"].ToString(),
                                Fecha_vencimiento = reader["fecha_vencimiento"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista_usuarios_pos = new List<UsuariosPOS>();
                }
            }
            return lista_usuarios_pos;
        }
    }
}
