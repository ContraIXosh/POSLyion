using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataLayer
{
    public class DL_Roles
    {
        public List<Roles> ListAll()
        {
            List<Roles> list = new List<Roles>();
            using (SqlConnection oConnection = new SqlConnection(Connection.ConnectionString))
            {
                try
                {
                    oConnection.Open();
                    string query = "SELECT role_id, description FROM Roles";
                    SqlCommand command = new SqlCommand(query, oConnection);
                    command.CommandType = CommandType.Text;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Roles()
                            {
                                Role_id = Convert.ToInt32(reader["role_id"]),
                                Description = reader["description"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    list = new List<Roles>();
                }
            }
            return list;
        }
    }
}
