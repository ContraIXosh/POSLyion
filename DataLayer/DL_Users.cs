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
    public class DL_Users
    {
        public List<Users> ListAll()
        {
            List<Users> list = new List<Users>();
            using (SqlConnection oConnection = new SqlConnection(Connection.ConnectionString))
            {
                try
                {
                    oConnection.Open();
                    string query = "SELECT user_id, dni, full_name, email, username, password, state FROM Users";
                    SqlCommand command = new SqlCommand(query, oConnection);
                    command.CommandType = CommandType.Text;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Users()
                            {
                                User_id = Convert.ToInt32(reader["user_id"]),
                                Dni = reader["dni"].ToString(),
                                Full_name = reader["full_name"].ToString(),
                                Email = reader["email"].ToString(),
                                Username = reader["username"].ToString(),
                                Password = reader["password"].ToString(),
                                State = Convert.ToBoolean(reader["state"])
                            });
                        }
                    }
                    return list;
                }
                catch (Exception ex)
                {
                    list = new List<Users>();
                }
            }
            return list;
        }
    }
}
