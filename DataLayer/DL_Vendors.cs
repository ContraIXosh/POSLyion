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
    public class DL_Vendors
    {
        public int Create(Vendors oVendor, out string message)
        {
            message = string.Empty;
            int created_vendor_id = 0;
            using (SqlConnection oConnection = new SqlConnection(Connection.ConnectionString))
            {
                try
                {
                    oConnection.Open();
                    SqlCommand command = new SqlCommand("SP_CREATE_VENDOR", oConnection);
                    command.Parameters.AddWithValue("cuit", oVendor.Cuit);
                    command.Parameters.AddWithValue("company_name", oVendor.Company_name);
                    command.Parameters.AddWithValue("email", oVendor.Email);
                    command.Parameters.AddWithValue("phone", oVendor.Phone);
                    command.Parameters.Add("message", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    command.Parameters.Add("created_vendor_id", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    created_vendor_id = Convert.ToInt32(command.Parameters["created_vendor_id"].Value);
                    message = command.Parameters["message"].Value.ToString();
                }
                catch (Exception ex)
                {
                    created_vendor_id = 0;
                    message = ex.Message;
                }
                return created_vendor_id;
            }
        }

        public List<Vendors> Read()
        {
            List<Vendors> list = new List<Vendors>();
            using (SqlConnection oConnection = new SqlConnection(Connection.ConnectionString))
            {
                try
                {
                    oConnection.Open();
                    string query = "SELECT vendor_id, cuit, company_name, email, phone, state FROM Vendors";
                    SqlCommand command = new SqlCommand(query, oConnection);
                    command.CommandType = CommandType.Text;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Vendors()
                            {
                                Vendor_id = Convert.ToInt32(reader["Vendor_id"]),
                                Cuit = reader["cuit"].ToString(),
                                Company_name = reader["company_name"].ToString(),
                                Email = reader["email"].ToString(),
                                Phone = reader["phone"].ToString(),
                                State = Convert.ToBoolean(reader["state"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    list = new List<Vendors>();
                }
                return list;
            }
        }

        public bool Update(Vendors oVendor, out string message)
        {
            message = string.Empty;
            bool result = false;
            using (SqlConnection oConnection = new SqlConnection(Connection.ConnectionString))
            {
                try
                {
                    oConnection.Open();
                    SqlCommand command = new SqlCommand("SP_UPDATE_VENDOR", oConnection);
                    command.Parameters.AddWithValue("vendor_id", oVendor.Vendor_id);
                    command.Parameters.AddWithValue("cuit", oVendor.Cuit);
                    command.Parameters.AddWithValue("company_name", oVendor.Company_name);
                    command.Parameters.AddWithValue("email", oVendor.Email);
                    command.Parameters.AddWithValue("phone", oVendor.Phone);
                    command.Parameters.AddWithValue("state", oVendor.State);
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

        public bool Delete(Vendors oVendor, out string message)
        {
            message = string.Empty;
            bool result = false;
            using (SqlConnection oConnection = new SqlConnection(Connection.ConnectionString))
            {
                try
                {
                    oConnection.Open();
                    SqlCommand command = new SqlCommand("SP_UPDATE_VENDOR", oConnection);
                    command.Parameters.AddWithValue("vendor_id", oVendor.Vendor_id);
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

        public bool Restore(Vendors oVendor, out string message)
        {
            message = string.Empty;
            bool result = false;
            using (SqlConnection oConnection = new SqlConnection(Connection.ConnectionString))
            {
                try
                {
                    oConnection.Open();
                    SqlCommand command = new SqlCommand("SP_UPDATE_VENDOR", oConnection);
                    command.Parameters.AddWithValue("vendor_id", oVendor.Vendor_id);
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
