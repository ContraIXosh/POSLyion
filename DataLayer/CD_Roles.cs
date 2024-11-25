using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Roles
    {
        public List<Roles> Leer()
        {
            var lista_roles = new List<Roles>();
            using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    oConexion.Open();
                    var query = "SELECT id_rol, descripcion FROM Roles";
                    var command = new SqlCommand(query, oConexion)
                    {
                        CommandType = CommandType.Text
                    };
                    using (var reader = command.ExecuteReader())
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
                catch (Exception)
                {
                    lista_roles = new List<Roles>();
                }
            }
            return lista_roles;
        }
    }
}
