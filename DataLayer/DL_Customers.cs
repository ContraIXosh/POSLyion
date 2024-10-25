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
    public class DL_Customers
    {
        public int Create(Customers oCustomer, out string message)
        {
            message = string.Empty;
            int created_customer_id = 0;
            using (SqlConnection oConnection = new SqlConnection(Connection.ConnectionString))
            {
                try
                {
                    oConnection.Open();
                    SqlCommand command = new SqlCommand("SP_CREATE_CUSTOMER", oConnection);
                    command.Parameters.AddWithValue("dni", oCustomer.Dni);
                    command.Parameters.AddWithValue("full_name", oCustomer.Full_name);
                    command.Parameters.AddWithValue("email", oCustomer.Email);
                    command.Parameters.AddWithValue("phone", oCustomer.Phone);
                    command.Parameters.Add("message", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    command.Parameters.Add("created_customer_id", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    created_customer_id = Convert.ToInt32(command.Parameters["created_customer_id"].Value);
                    message = command.Parameters["message"].Value.ToString();
                }
                catch (Exception ex)
                {
                    created_customer_id = 0;
                    message = ex.Message;
                }
                return created_customer_id;
            }
        }

        public List<Customers> Read()
        {
            List<Customers> list = new List<Customers>();
            using (SqlConnection oConnection = new SqlConnection(Connection.ConnectionString))
            {
                try
                {
                    oConnection.Open();
                    string query = "SELECT customer_id, dni, full_name, email, phone, state FROM Customers";
                    SqlCommand command = new SqlCommand(query, oConnection);
                    command.CommandType = CommandType.Text;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Customers()
                            {
                                Customer_id = Convert.ToInt32(reader["customer_id"]),
                                Dni = reader["dni"].ToString(),
                                Full_name = reader["full_name"].ToString(),
                                Email = reader["email"].ToString(),
                                Phone = reader["phone"].ToString(),
                                State = Convert.ToBoolean(reader["state"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    list = new List<Customers>();
                }
                return list;
            }
        }

        public bool Update(Customers oCustomer, out string message)
        {
            message = string.Empty;
            bool result = false;
            using (SqlConnection oConnection = new SqlConnection(Connection.ConnectionString))
            {
                try
                {
                    oConnection.Open();
                    SqlCommand command = new SqlCommand("SP_UPDATE_CUSTOMER", oConnection);
                    command.Parameters.AddWithValue("customer_id", oCustomer.Customer_id);
                    command.Parameters.AddWithValue("dni", oCustomer.Dni);
                    command.Parameters.AddWithValue("full_name", oCustomer.Full_name);
                    command.Parameters.AddWithValue("email", oCustomer.Email);
                    command.Parameters.AddWithValue("phone", oCustomer.Phone);
                    command.Parameters.AddWithValue("state", oCustomer.State);
                    command.Parameters.Add("message", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    command.Parameters.Add("result", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    result = Convert.ToBoolean(command.Parameters["result"].Value);
                    message = command.Parameters["message"].Value.ToString();
                }
                catch (Exception ex)
                {
                    result = false;
                    message = ex.Message;
                }
                return result;
            }
        }

        public bool Delete(Customers oCustomer, out string message)
        {
            message = string.Empty;
            bool result = false;
            using (SqlConnection oConnection = new SqlConnection(Connection.ConnectionString))
            {
                try
                {
                    oConnection.Open();
                    SqlCommand command = new SqlCommand("SP_DELETE_CUSTOMER", oConnection);
                    command.Parameters.AddWithValue("customer_id", oCustomer.Customer_id);
                    command.Parameters.Add("message", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    command.Parameters.Add("result", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    result = Convert.ToBoolean(command.Parameters["result"].Value);
                    message = command.Parameters["message"].Value.ToString();
                }
                catch (Exception ex)
                {
                    result = false;
                    message = ex.Message;
                }
                return result;
            }
        }

        public bool Restore(Customers oCustomer, out string message)
        {
            message = string.Empty;
            bool result = false;
            using (SqlConnection oConnection = new SqlConnection(Connection.ConnectionString))
            {
                try
                {
                    oConnection.Open();
                    SqlCommand command = new SqlCommand("SP_RESTORE_CUSTOMER", oConnection);
                    command.Parameters.AddWithValue("customer_id", oCustomer.Customer_id);
                    command.Parameters.Add("message", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    command.Parameters.Add("result", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    result = Convert.ToBoolean(command.Parameters["result"].Value);
                    message = command.Parameters["message"].Value.ToString();
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
}
