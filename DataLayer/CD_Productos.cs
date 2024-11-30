using CapaEntidad;
using CapaEntidad.Filtros;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class CD_Productos
    {
        public int Crear(Productos oProducto, out string mensaje)
        {
            mensaje = string.Empty;
            using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                int id_generada_producto;
                try
                {
                    oConexion.Open();
                    var command = new SqlCommand("SP_ALTA_PRODUCTO", oConexion);
                    _ = command.Parameters.AddWithValue("codigo_barras", oProducto.Codigo_barras);
                    _ = command.Parameters.AddWithValue("descripcion", oProducto.Descripcion);
                    _ = command.Parameters.AddWithValue("id_categoria", oProducto.oCategoria.Id_categoria);
                    _ = command.Parameters.AddWithValue("precio_costo", oProducto.Precio_costo);
                    _ = command.Parameters.AddWithValue("precio_venta", oProducto.Precio_venta);
                    _ = command.Parameters.AddWithValue("precio_mayorista", oProducto.Precio_venta);
                    _ = command.Parameters.AddWithValue("stock_actual", oProducto.Stock_actual);
                    _ = command.Parameters.AddWithValue("stock_minimo", oProducto.Stock_minimo);
                    command.Parameters.Add("mensaje", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    command.Parameters.Add("id_generada_producto", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    _ = command.ExecuteNonQuery();
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

        public List<Productos> Leer(FiltrosProducto filtros)
        {
            var lista_productos = new List<Productos>();
            using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    oConexion.Open();
                    var query = new StringBuilder();
                    _ = query.AppendLine("SELECT id_producto, codigo_barras, p.descripcion, precio_costo, precio_venta, precio_mayorista, stock_actual, stock_minimo, p.estado, pc.id_categoria, pc.descripcion[DescripcionCategoria] FROM Productos as p");
                    _ = query.AppendLine("INNER JOIN Categorias as pc ON p.id_categoria = pc.id_categoria ");
                    _ = query.AppendLine("WHERE (p.descripcion LIKE '%' + @nombre_producto + '%' OR @nombre_producto = '')");
                    _ = query.AppendLine("AND (p.codigo_barras = IIF(@codigo_barras = '', p.codigo_barras, @codigo_barras))");
                    _ = query.AppendLine("AND (p.id_categoria = IIF(@id_categoria = 0, p.id_categoria, @id_categoria))");
                    _ = query.AppendLine("AND ((@estado = 1 AND p.estado = 1) OR (@estado = 0 AND p.estado = 0) OR @estado = 0)");
                    var command = new SqlCommand(query.ToString(), oConexion);
                    _ = command.Parameters.AddWithValue("@nombre_producto", filtros.Nombre_producto);
                    _ = command.Parameters.AddWithValue("@codigo_barras", filtros.Codigo_barras);
                    _ = command.Parameters.AddWithValue("@id_categoria", filtros.Id_categoria);
                    _ = command.Parameters.AddWithValue("@estado", filtros.Estado);
                    command.CommandType = CommandType.Text;
                    using (var reader = command.ExecuteReader())
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
                                Precio_mayorista = Convert.ToDecimal(reader["precio_mayorista"]),
                                Stock_actual = Convert.ToInt32(reader["stock_actual"]),
                                Stock_minimo = Convert.ToInt32(reader["stock_minimo"]),
                                Estado = Convert.ToBoolean(reader["estado"])
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista_productos = new List<Productos>();
                }
                return lista_productos;
            }
        }

        public Productos BuscarUnProducto(int id)
        {
            var producto = new Productos();
            using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    oConexion.Open();
                    var query = "SELECT id_producto, descripcion, precio_costo, precio_venta, precio_mayorista, stock_actual FROM Productos WHERE estado = 1 AND id_producto = " + id;
                    var command = new SqlCommand(query.ToString(), oConexion)
                    {
                        CommandType = CommandType.Text
                    };
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            producto.Id_producto = Convert.ToInt32(reader["id_producto"]);
                            producto.Descripcion = reader["descripcion"].ToString();
                            producto.Precio_costo = Convert.ToDecimal(reader["precio_costo"]);
                            producto.Precio_venta = Convert.ToDecimal(reader["precio_venta"]);
                            producto.Precio_mayorista = Convert.ToDecimal(reader["precio_mayorista"]);
                            producto.Stock_actual = Convert.ToInt32(reader["stock_actual"]);
                        }
                    }
                }
                catch (Exception)
                {
                    producto = new Productos();
                }
                return producto;
            }
        }

        public DataTable BuscarProductoCarrito(string texto)
        {
            var tabla_datos = new DataTable();
            using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    oConexion.Open();
                    var query = "SELECT id_producto, descripcion, precio_venta, precio_mayorista, stock_actual FROM Productos WHERE estado = 1 AND descripcion LIKE '%" + texto + "%'";
                    var command = new SqlCommand(query.ToString(), oConexion)
                    {
                        CommandType = CommandType.Text
                    };
                    using (var reader = command.ExecuteReader())
                    {
                        tabla_datos = new DataTable();
                        _ = tabla_datos.Columns.Add("ID", typeof(int));
                        _ = tabla_datos.Columns.Add("Descripcion", typeof(string));
                        _ = tabla_datos.Columns.Add("Precio minorista", typeof(decimal));
                        _ = tabla_datos.Columns.Add("Precio mayorista", typeof(decimal));
                        _ = tabla_datos.Columns.Add("Stock actual", typeof(int));
                        while (reader.Read())
                        {
                            _ = tabla_datos.Rows.Add(reader["id_producto"], reader["descripcion"], reader["precio_venta"], reader["precio_mayorista"], reader["stock_actual"]);
                        }
                    }
                }
                catch (Exception)
                {
                    tabla_datos = new DataTable();
                }
                return tabla_datos;
            }
        }

        public bool Modificar(Productos oProducto, out string mensaje)
        {
            mensaje = string.Empty;
            using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                bool resultado;
                try
                {
                    oConexion.Open();
                    var command = new SqlCommand("SP_MODIFICAR_PRODUCTO", oConexion);
                    _ = command.Parameters.AddWithValue("id_producto", oProducto.Id_producto);
                    _ = command.Parameters.AddWithValue("codigo_barras", oProducto.Codigo_barras);
                    _ = command.Parameters.AddWithValue("descripcion", oProducto.Descripcion);
                    _ = command.Parameters.AddWithValue("id_categoria", oProducto.oCategoria.Id_categoria);
                    _ = command.Parameters.AddWithValue("precio_costo", oProducto.Precio_costo);
                    _ = command.Parameters.AddWithValue("precio_venta", oProducto.Precio_venta);
                    _ = command.Parameters.AddWithValue("precio_mayorista", oProducto.Precio_mayorista);
                    _ = command.Parameters.AddWithValue("stock_actual", oProducto.Stock_actual);
                    _ = command.Parameters.AddWithValue("stock_minimo", oProducto.Stock_minimo);
                    _ = command.Parameters.AddWithValue("estado", oProducto.Estado);
                    command.Parameters.Add("mensaje", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    command.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    _ = command.ExecuteNonQuery();
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
            using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                bool resultado;
                try
                {
                    oConexion.Open();
                    var command = new SqlCommand("SP_BAJA_PRODUCTO", oConexion);
                    _ = command.Parameters.AddWithValue("id_producto", oProducto.Id_producto);
                    command.Parameters.Add("mensaje", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    command.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    _ = command.ExecuteNonQuery();
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
            using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                bool resultado;
                try
                {
                    oConexion.Open();
                    var command = new SqlCommand("SP_RESTAURAR_PRODUCTO", oConexion);
                    _ = command.Parameters.AddWithValue("id_producto", oProducto.Id_producto);
                    command.Parameters.Add("mensaje", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    command.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    _ = command.ExecuteNonQuery();
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

