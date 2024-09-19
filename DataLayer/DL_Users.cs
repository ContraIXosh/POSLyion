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

        public int Create(Users oUser, out string message)
        {
            message = string.Empty;
            int created_user_id = 0;
            try
            {
                using (SqlConnection oConnection = new SqlConnection(Connection.ConnectionString))
                {
                    oConnection.Open();
                    SqlCommand command = new SqlCommand("SP_CREATE_USER", oConnection);
                    command.Parameters.AddWithValue("dni", oUser.Dni);
                    command.Parameters.AddWithValue("full_name", oUser.Full_name);
                    command.Parameters.AddWithValue("email", oUser.Email);
                    command.Parameters.AddWithValue("username", oUser.Username);
                    command.Parameters.AddWithValue("password", oUser.Password);
                    command.Parameters.AddWithValue("role_id", oUser.oRol.Role_id);
                    command.Parameters.AddWithValue("state", oUser.State);
                    command.Parameters.Add("message", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    command.Parameters.Add("created_user_id", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    created_user_id = Convert.ToInt32(command.Parameters["created_user_id"].Value);
                    message = command.Parameters["message"].Value.ToString();
                }
            } 
            catch (Exception ex)
            {
                created_user_id = 0;
                message = ex.Message;
            }
            return created_user_id;
        }

        public List<Users> Read()
        {
            List<Users> list = new List<Users>();
            using (SqlConnection oConnection = new SqlConnection(Connection.ConnectionString))
            {
                try
                {
                    oConnection.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT u.user_id, u.dni, u.full_name, u.email, u.username, u.password, u.state, r.role_id, r.description FROM Users u");
                    query.AppendLine("INNER JOIN Roles r ON r.role_id = u.role_id");
                    SqlCommand command = new SqlCommand(query.ToString(), oConnection);
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
                                oRol = new Roles()
                                {
                                    Role_id = Convert.ToInt32(reader["role_id"]),
                                    Description = reader["description"].ToString()
                                },
                                State = Convert.ToBoolean(reader["state"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    list = new List<Users>();
                }
            }
            return list;
        }

        public bool Update(Users oUser, out string message)
        {
            message = string.Empty;
            bool result = false;
            try
            {
                using (SqlConnection oConnection = new SqlConnection(Connection.ConnectionString))
                {
                    oConnection.Open();
                    SqlCommand command = new SqlCommand("SP_UPDATE_USER", oConnection);
                    command.Parameters.AddWithValue("user_id", oUser.User_id);
                    command.Parameters.AddWithValue("dni", oUser.Dni);
                    command.Parameters.AddWithValue("full_name", oUser.Full_name);
                    command.Parameters.AddWithValue("email", oUser.Email);
                    command.Parameters.AddWithValue("username", oUser.Username);
                    command.Parameters.AddWithValue("password", oUser.Password);
                    command.Parameters.AddWithValue("role_id", oUser.oRol.Role_id);
                    command.Parameters.AddWithValue("state", oUser.State);
                    command.Parameters.Add("message", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    command.Parameters.Add("result", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    result = Convert.ToBoolean(command.Parameters["result"].Value);
                    message = command.Parameters["message"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                result = false;
                message = ex.Message;
            }
            return result;
        }

        public bool Delete(Users oUser, out string message)
        {
            message = string.Empty;
            bool result = false;
            try
            {
                using (SqlConnection oConnection = new SqlConnection(Connection.ConnectionString))
                {
                    oConnection.Open();
                    SqlCommand command = new SqlCommand("SP_DELETE_USER", oConnection);
                    command.Parameters.AddWithValue("user_id", oUser.User_id);
                    command.Parameters.Add("message", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    command.Parameters.Add("result", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    result = Convert.ToBoolean(command.Parameters["result"].Value);
                    message = command.Parameters["message"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                result = false;
                message = ex.Message;
            }
            return result;
        }

        public bool Restore(Users oUser, out string message)
        {
            message = string.Empty;
            bool result = false;
            try
            {
                using (SqlConnection oConnection = new SqlConnection(Connection.ConnectionString))
                {
                    oConnection.Open();
                    SqlCommand command = new SqlCommand("SP_RESTORE_USER", oConnection);
                    command.Parameters.AddWithValue("user_id", oUser.User_id);
                    command.Parameters.Add("message", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    command.Parameters.Add("result", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    result = Convert.ToBoolean(command.Parameters["result"].Value);
                    message = command.Parameters["message"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                result = false;
                message = ex.Message;
            }
            return result;
        }
    }
}
