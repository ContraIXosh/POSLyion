using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;
using System.Runtime.CompilerServices;

namespace DataLayer
{
    public class DL_ProductCategories
    {
        
        public int Create(ProductCategories oProductCategory, out string message)
        {
            message = string.Empty;
            int created_productcategory_id = 0;
            using (SqlConnection oConnection = new SqlConnection(Connection.ConnectionString))
            {
                try
                {
                    oConnection.Open();
                    SqlCommand command = new SqlCommand("SP_CREATE_PRODUCTCATEGORY", oConnection);
                    command.Parameters.AddWithValue("description", oProductCategory.Description);
                    command.Parameters.Add("message", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    command.Parameters.Add("created_productcategory_id", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    created_productcategory_id = Convert.ToInt32(command.Parameters["created_productcategory_id"].Value);
                    message = command.Parameters["message"].Value.ToString();
                }
                catch (Exception ex)
                {
                    created_productcategory_id = 0;
                    message = ex.Message;
                }
                return created_productcategory_id;
            }
        }

        public List<ProductCategories> Read()
        {
            List<ProductCategories> list = new List<ProductCategories>();
            using (SqlConnection oConnection = new SqlConnection(Connection.ConnectionString))
            {
                try
                {
                    oConnection.Open();
                    string query = "SELECT product_category_id, description, state FROM ProductCategories";
                    SqlCommand command = new SqlCommand(query, oConnection);
                    command.CommandType = CommandType.Text;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new ProductCategories()
                            {
                                Product_category_id = Convert.ToInt32(reader["product_category_id"]),
                                Description = reader["description"].ToString(),
                                State = Convert.ToBoolean(reader["state"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    list = new List<ProductCategories>();
                }
                return list;
            }
        }

        public List<ProductCategories> CountProducts()
        {
            List<ProductCategories> list = new List<ProductCategories>();
            using (SqlConnection oConnection = new SqlConnection(Connection.ConnectionString))
            {
                try
                {
                    oConnection.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT pc.product_category_id[ProductCategoryId], pc.description[ProductCategoryDescription], ISNULL(COUNT(p.product_id), 0) AS products_quantity");
                    query.AppendLine("FROM ProductCategories pc");
                    query.AppendLine("LEFT JOIN Products p ON pc.product_category_id = p.product_category_id");
                    query.AppendLine("GROUP BY pc.product_category_id, pc.description");
                    SqlCommand command = new SqlCommand(query.ToString(), oConnection);
                    command.CommandType = CommandType.Text;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new ProductCategories()
                            {
                                Product_category_id = Convert.ToInt32(reader["ProductCategoryId"]),
                                Description = reader["ProductCategoryDescription"].ToString(),
                                Quantity = Convert.ToInt32(reader["products_quantity"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    list = new List<ProductCategories>();
                }
                return list;
            }
        }

        public bool Update(ProductCategories oProductCategory, out string message)
        {
            message = string.Empty;
            bool result = false;
            using (SqlConnection oConnection = new SqlConnection(Connection.ConnectionString))
            {
                try
                {
                    oConnection.Open();
                    SqlCommand command = new SqlCommand("SP_UPDATE_PRODUCTCATEGORY", oConnection);
                    command.Parameters.AddWithValue("product_category_id", oProductCategory.Product_category_id);
                    command.Parameters.AddWithValue("description", oProductCategory.Description);
                    command.Parameters.AddWithValue("state", oProductCategory.State);
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

        public bool Delete(ProductCategories oProductCategory, out string message)
        {
            message = string.Empty;
            bool result = false;
            using (SqlConnection oConnection = new SqlConnection(Connection.ConnectionString))
            {
                try
                {
                    oConnection.Open();
                    SqlCommand command = new SqlCommand("SP_DELETE_PRODUCTCATEGORY", oConnection);
                    command.Parameters.AddWithValue("product_category_id", oProductCategory.Product_category_id);
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

        public bool Restore(ProductCategories oProductCategory, out string message)
        {
            message = string.Empty;
            bool result = false;
            using (SqlConnection oConnection = new SqlConnection(Connection.ConnectionString))
            {
                try
                {
                    oConnection.Open();
                    SqlCommand command = new SqlCommand("SP_RESTORE_PRODUCTCATEGORY", oConnection);
                    command.Parameters.AddWithValue("product_category_id", oProductCategory.Product_category_id);
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
