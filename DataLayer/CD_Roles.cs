using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Roles
    {
        public List<Roles> Leer()
        {
            List<Roles> lista_roles = new List<Roles>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    oConexion.Open();
                    string query = "SELECT id_rol, descripcion FROM Roles";
                    SqlCommand command = new SqlCommand(query, oConexion);
                    command.CommandType = CommandType.Text;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista_roles.Add(new Roles()
                            {
                                Id_rol = Convert.ToInt32(reader["id_rol"]),
                                Descripcion = reader["descripcion"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista_roles = new List<Roles>();
                }
            }
            return lista_roles;
        }
    }
}
