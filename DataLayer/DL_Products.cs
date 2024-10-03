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
    public class DL_Products
    {
        public int Create(Products oProduct, out string message)
        {
            message = string.Empty;
            int created_product_id = 0;
            using (SqlConnection oConnection = new SqlConnection(Connection.ConnectionString))
            {
                try
                {
                    oConnection.Open();
                    SqlCommand command = new SqlCommand("SP_CREATE_PRODUCT", oConnection);
                    command.Parameters.AddWithValue("bar_code", oProduct.Bar_code);
                    command.Parameters.AddWithValue("description", oProduct.Description);
                    command.Parameters.AddWithValue("product_category_id", oProduct.oProductCategory.Product_category_id);
                    command.Parameters.AddWithValue("cost_price", oProduct.Cost_price);
                    command.Parameters.AddWithValue("sale_price", oProduct.Sale_price);
                    command.Parameters.AddWithValue("current_stock", oProduct.Current_stock);
                    command.Parameters.AddWithValue("minimum_stock", oProduct.Minimum_stock);
                    command.Parameters.Add("message", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    command.Parameters.Add("created_product_id", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    created_product_id = Convert.ToInt32(command.Parameters["created_product_id"].Value);
                    message = command.Parameters["message"].Value.ToString();
                }
                catch (Exception ex)
                {
                    created_product_id = 0;
                    message = ex.Message;
                }
                return created_product_id;
            }
        }

        public List<Products> Read()
        {
            List<Products> list = new List<Products>();
            using (SqlConnection oConnection = new SqlConnection(Connection.ConnectionString))
            {
                try
                {
                    oConnection.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT product_id, bar_code, p.description, cost_price, sale_price, current_stock, minimum_stock, p.state, pc.product_category_id, pc.description[ProductCategoryDescription] FROM Products as p");
                    query.AppendLine("INNER JOIN ProductCategories as pc ON p.product_category_id = pc.product_category_id ");
                    SqlCommand command = new SqlCommand(query.ToString(), oConnection);
                    command.CommandType = CommandType.Text;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Products()
                            {
                                Product_id = Convert.ToInt32(reader["product_id"]),
                                Bar_code = reader["bar_code"].ToString(),
                                Description = reader["description"].ToString(),
                                oProductCategory = new ProductCategories() 
                                { 
                                    Product_category_id = Convert.ToInt32(reader["product_category_id"]),
                                    Description = reader["ProductCategoryDescription"].ToString(),
                                },
                                Cost_price = Convert.ToDecimal(reader["cost_price"]),
                                Sale_price = Convert.ToDecimal(reader["sale_price"]),
                                Current_stock = Convert.ToInt32(reader["current_stock"]),
                                Minimum_stock = Convert.ToInt32(reader["minimum_stock"]),
                                State = Convert.ToBoolean(reader["state"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    list = new List<Products>();
                }
                return list;
            }
        }

        public bool Update(Products oProduct, out string message)
        {
            message = string.Empty;
            bool result = false;
            using (SqlConnection oConnection = new SqlConnection(Connection.ConnectionString))
            {
                try
                {
                    oConnection.Open();
                    SqlCommand command = new SqlCommand("SP_UPDATE_PRODUCT", oConnection);
                    command.Parameters.AddWithValue("product_id", oProduct.Product_id);
                    command.Parameters.AddWithValue("bar_code", oProduct.Bar_code);
                    command.Parameters.AddWithValue("description", oProduct.Description);
                    command.Parameters.AddWithValue("product_category_id", oProduct.oProductCategory.Product_category_id);
                    command.Parameters.AddWithValue("cost_price", oProduct.Cost_price);
                    command.Parameters.AddWithValue("sale_price", oProduct.Sale_price);
                    command.Parameters.AddWithValue("current_stock", oProduct.Current_stock);
                    command.Parameters.AddWithValue("minimum_stock", oProduct.Minimum_stock);
                    command.Parameters.AddWithValue("state", oProduct.State);
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

        public bool Delete(Products oProduct, out string message)
        {
            message = string.Empty;
            bool result = false;
            using (SqlConnection oConnection = new SqlConnection(Connection.ConnectionString))
            {
                try
                {
                    oConnection.Open();
                    SqlCommand command = new SqlCommand("SP_DELETE_PRODUCT", oConnection);
                    command.Parameters.AddWithValue("product_id", oProduct.Product_id);
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

        public bool Restore(Products oProduct, out string message)
        {
            message = string.Empty;
            bool result = false;
            using (SqlConnection oConnection = new SqlConnection(Connection.ConnectionString))
            {
                try
                {
                    oConnection.Open();
                    SqlCommand command = new SqlCommand("SP_RESTORE_PRODUCT", oConnection);
                    command.Parameters.AddWithValue("product_id", oProduct.Product_id);
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

