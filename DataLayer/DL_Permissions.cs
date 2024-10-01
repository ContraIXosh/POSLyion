using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DL_Permissions
    {
        public List<Permissions> Read(int user_id)
        {
            List<Permissions> list = new List<Permissions>();
            using (SqlConnection oConnection = new SqlConnection(Connection.ConnectionString))
            {
                try
                {
                    oConnection.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT p.role_id, p.menu_name FROM Permissions p");
                    query.AppendLine("INNER JOIN Roles r ON r.role_id = p.role_id");
                    query.AppendLine("INNER JOIN Users u ON u.role_id = r.role_id");
                    query.AppendLine("WHERE u.user_id = @user_id");
                    SqlCommand command = new SqlCommand(query.ToString(), oConnection);
                    command.Parameters.AddWithValue("@user_id", user_id);
                    command.CommandType = CommandType.Text;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Permissions()
                            {
                                oRol = new Roles()
                                {
                                    Role_id = Convert.ToInt32(reader["role_id"])
                                },
                                Menu_name = reader["menu_name"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    list = new List<Permissions>();
                }
            }
            return list;
        }

        public List<Permissions> ReadAll(int user_id)
        {
            List<Permissions> list = new List<Permissions>();
            using (SqlConnection oConnection = new SqlConnection(Connection.ConnectionString))
            {
                try
                {
                    oConnection.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT p.role_id, p.menu_name FROM Permissions p");
                    query.AppendLine("INNER JOIN Roles r ON r.role_id = p.role_id");
                    query.AppendLine("INNER JOIN Users u ON u.role_id = r.role_id");
                    query.AppendLine("WHERE u.user_id = @user_id");
                    SqlCommand command = new SqlCommand(query.ToString(), oConnection);
                    command.Parameters.AddWithValue("@user_id", user_id);
                    command.CommandType = CommandType.Text;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Permissions()
                            {
                                oRol = new Roles()
                                {
                                    Role_id = Convert.ToInt32(reader["role_id"])
                                },
                                Menu_name = reader["menu_name"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    list = new List<Permissions>();
                }
            }
            return list;
        }
    }
}
