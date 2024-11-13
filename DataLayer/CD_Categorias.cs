using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using System.Runtime.CompilerServices;

namespace CapaDatos
{
    public class CD_Categorias
    {
        
        public int Crear(Categorias oCategoria, out string mensaje)
        {
            mensaje = string.Empty;
            int id_generada_categoria = 0;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    oConexion.Open();
                    SqlCommand command = new SqlCommand("SP_ALTA_CATEGORIA", oConexion);
                    command.Parameters.AddWithValue("descripcion", oCategoria.Descripcion);
                    command.Parameters.Add("mensaje", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    command.Parameters.Add("id_generada_categoria", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    id_generada_categoria = Convert.ToInt32(command.Parameters["id_generada_categoria"].Value);
                    mensaje = command.Parameters["mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    id_generada_categoria = 0;
                    mensaje = ex.Message;
                }
                return id_generada_categoria;
            }
        }

        public List<Categorias> Leer()
        {
            List<Categorias> lista_categorias = new List<Categorias>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    oConexion.Open();
                    string query = "SELECT id_categoria, descripcion, estado FROM Categorias";
                    SqlCommand command = new SqlCommand(query, oConexion);
                    command.CommandType = CommandType.Text;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista_categorias.Add(new Categorias()
                            {
                                Id_categoria = Convert.ToInt32(reader["id_categoria"]),
                                Descripcion = reader["descripcion"].ToString(),
                                Estado = Convert.ToBoolean(reader["estado"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista_categorias = new List<Categorias>();
                }
                return lista_categorias;
            }
        }

        public List<Categorias> ContarProductos()
        {
            List<Categorias> lista_categorias = new List<Categorias>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    oConexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT pc.id_categoria[IdCategoria], pc.descripcion[DescripcionCategoria], ISNULL(COUNT(p.id_producto), 0) AS cantidad_productos");
                    query.AppendLine("FROM Categorias pc");
                    query.AppendLine("LEFT JOIN Productos p ON pc.id_categoria = p.id_categoria");
                    query.AppendLine("GROUP BY pc.id_categoria, pc.descripcion");
                    SqlCommand command = new SqlCommand(query.ToString(), oConexion);
                    command.CommandType = CommandType.Text;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista_categorias.Add(new Categorias()
                            {
                                Id_categoria = Convert.ToInt32(reader["IdCategoria"]),
                                Descripcion = reader["DescripcionCategoria"].ToString(),
                                Cantidad = Convert.ToInt32(reader["cantidad_productos"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista_categorias = new List<Categorias>();
                }
                return lista_categorias;
            }
        }

        public bool Modificar(Categorias oCategoria, out string mensaje)
        {
            mensaje = string.Empty;
            bool resultado = false;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    oConexion.Open();
                    SqlCommand command = new SqlCommand("SP_MODIFICAR_CATEGORIA", oConexion);
                    command.Parameters.AddWithValue("id_categoria", oCategoria.Id_categoria);
                    command.Parameters.AddWithValue("descripcion", oCategoria.Descripcion);
                    command.Parameters.AddWithValue("estado", oCategoria.Estado);
                    command.Parameters.Add("mensaje", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    command.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    resultado = Convert.ToBoolean(command.Parameters["resultado"].Value);
                    mensaje = command.Parameters["mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    resultado = false;
                    mensaje = ex.Message;
                }
                return resultado;
            }
        }

        public bool Eliminar(Categorias oCategoria, out string mensaje)
        {
            mensaje = string.Empty;
            bool resultado = false;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    oConexion.Open();
                    SqlCommand command = new SqlCommand("SP_ELIMINAR_CATEGORIA", oConexion);
                    command.Parameters.AddWithValue("id_categoria", oCategoria.Id_categoria);
                    command.Parameters.Add("mensaje", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    command.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    resultado = Convert.ToBoolean(command.Parameters["resultado"].Value);
                    mensaje = command.Parameters["mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    resultado = false;
                    mensaje = ex.Message;
                }
                return resultado;
            }
        }

        public bool Restaurar(Categorias oCategoria, out string mensaje)
        {
            mensaje = string.Empty;
            bool resultado = false;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    oConexion.Open();
                    SqlCommand command = new SqlCommand("SP_RESTAURAR_CATEGORIA", oConexion);
                    command.Parameters.AddWithValue("id_categoria", oCategoria.Id_categoria);
                    command.Parameters.Add("mensaje", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    command.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    resultado = Convert.ToBoolean(command.Parameters["resultado"].Value);
                    mensaje = command.Parameters["mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    resultado = false;
                    mensaje = ex.Message;
                }
                return resultado;
            }
        }
    }
}
