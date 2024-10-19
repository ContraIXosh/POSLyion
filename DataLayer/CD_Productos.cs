using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Productos
    {
        public int Crear(Productos oProducto, out string mensaje)
        {
            mensaje = string.Empty;
            int id_generada_producto = 0;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    oConexion.Open();
                    SqlCommand command = new SqlCommand("SP_ALTA_PRODUCTO", oConexion);
                    command.Parameters.AddWithValue("codigo_barras", oProducto.Codigo_barras);
                    command.Parameters.AddWithValue("descripcion", oProducto.Descripcion);
                    command.Parameters.AddWithValue("id_categoria", oProducto.oCategoria.Id_categoria);
                    command.Parameters.AddWithValue("precio_costo", oProducto.Precio_costo);
                    command.Parameters.AddWithValue("precio_venta", oProducto.Precio_venta);
                    command.Parameters.AddWithValue("stock_actual", oProducto.Stock_actual);
                    command.Parameters.AddWithValue("stock_minimo", oProducto.Stock_minimo);
                    command.Parameters.Add("mensaje", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    command.Parameters.Add("id_generada_producto", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    id_generada_producto = Convert.ToInt32(command.Parameters["id_generada_producto"].Value);
                    mensaje = command.Parameters["mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    id_generada_producto = 0;
                    mensaje = ex.Message;
                }
                return id_generada_producto;
            }
        }

        public List<Productos> Leer()
        {
            List<Productos> lista_productos = new List<Productos>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    oConexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT id_producto, codigo_barras, p.descripcion, precio_costo, precio_venta, stock_actual, stock_minimo, p.estado, pc.id_categoria, pc.descripcion[DescripcionCategoria] FROM Productos as p");
                    query.AppendLine("INNER JOIN Categorias as pc ON p.id_categoria = pc.id_categoria ");
                    SqlCommand command = new SqlCommand(query.ToString(), oConexion);
                    command.CommandType = CommandType.Text;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista_productos.Add(new Productos()
                            {
                                Id_producto = Convert.ToInt32(reader["id_producto"]),
                                Codigo_barras = reader["codigo_barras"].ToString(),
                                Descripcion = reader["descripcion"].ToString(),
                                oCategoria = new Categorias() 
                                { 
                                    Id_categoria = Convert.ToInt32(reader["id_categoria"]),
                                    Descripcion = reader["DescripcionCategoria"].ToString(),
                                },
                                Precio_costo = Convert.ToDecimal(reader["precio_costo"]),
                                Precio_venta = Convert.ToDecimal(reader["precio_venta"]),
                                Stock_actual = Convert.ToInt32(reader["stock_actual"]),
                                Stock_minimo = Convert.ToInt32(reader["stock_minimo"]),
                                Estado = Convert.ToBoolean(reader["estado"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista_productos = new List<Productos>();
                }
                return lista_productos;
            }
        }

        public DataTable Buscar(string texto)
        {
            DataTable tabla_datos = new DataTable();
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    oConexion.Open();
                    string query = "SELECT id_producto, descripcion, precio_venta, stock_actual FROM Productos WHERE estado = 1 AND descripcion LIKE '%" + texto + "%'";
                    SqlCommand command = new SqlCommand(query.ToString(), oConexion);
                    command.CommandType = CommandType.Text;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        tabla_datos = new DataTable();
                        tabla_datos.Columns.Add("ID", typeof(int));
                        tabla_datos.Columns.Add("Descripcion", typeof(string));
                        tabla_datos.Columns.Add("Precio", typeof(decimal));
                        tabla_datos.Columns.Add("Stock actual", typeof(int));
                        while (reader.Read())
                        {
                            tabla_datos.Rows.Add(reader["id_producto"], reader["descripcion"], reader["precio_venta"], reader["stock_actual"]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    tabla_datos = new DataTable();
                }
                return tabla_datos;
            }
        }

        public bool Modificar(Productos oProducto, out string mensaje)
        {
            mensaje = string.Empty;
            bool resultado = false;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    oConexion.Open();
                    SqlCommand command = new SqlCommand("SP_MODIFICAR_PRODUCTO", oConexion);
                    command.Parameters.AddWithValue("id_producto", oProducto.Id_producto);
                    command.Parameters.AddWithValue("codigo_barras", oProducto.Codigo_barras);
                    command.Parameters.AddWithValue("descripcion", oProducto.Descripcion);
                    command.Parameters.AddWithValue("id_categoria", oProducto.oCategoria.Id_categoria);
                    command.Parameters.AddWithValue("precio_costo", oProducto.Precio_costo);
                    command.Parameters.AddWithValue("precio_venta", oProducto.Precio_venta);
                    command.Parameters.AddWithValue("stock_actual", oProducto.Stock_actual);
                    command.Parameters.AddWithValue("stock_minimo", oProducto.Stock_minimo);
                    command.Parameters.AddWithValue("estado", oProducto.Estado);
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

        public bool Eliminar(Productos oProducto, out string mensaje)
        {
            mensaje = string.Empty;
            bool resultado = false;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    oConexion.Open();
                    SqlCommand command = new SqlCommand("SP_BAJA_PRODUCTO", oConexion);
                    command.Parameters.AddWithValue("id_producto", oProducto.Id_producto);
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

        public bool Restaurar(Productos oProducto, out string mensaje)
        {
            mensaje = string.Empty;
            bool resultado = false;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    oConexion.Open();
                    SqlCommand command = new SqlCommand("SP_RESTAURAR_PRODUCTO", oConexion);
                    command.Parameters.AddWithValue("id_producto", oProducto.Id_producto);
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

