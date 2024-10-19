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
    public class CD_Proveedores
    {
        public int Crear(Proveedores oProveedor, out string mensaje)
        {
            mensaje = string.Empty;
            int id_generada_proveedor = 0;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    oConexion.Open();
                    SqlCommand command = new SqlCommand("SP_ALTA_PROVEEDOR", oConexion);
                    command.Parameters.AddWithValue("cuit", oProveedor.Cuit);
                    command.Parameters.AddWithValue("descripcion", oProveedor.Descripcion);
                    command.Parameters.AddWithValue("correo", oProveedor.Correo);
                    command.Parameters.AddWithValue("telefono", oProveedor.Telefono);
                    command.Parameters.Add("mensaje", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    command.Parameters.Add("id_generada_proveedor", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    id_generada_proveedor = Convert.ToInt32(command.Parameters["id_generada_proveedor"].Value);
                    mensaje = command.Parameters["mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    id_generada_proveedor = 0;
                    mensaje = ex.Message;
                }
                return id_generada_proveedor;
            }
        }

        public List<Proveedores> Leer()
        {
            List<Proveedores> lista_proveedores = new List<Proveedores>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    oConexion.Open();
                    string query = "SELECT id_proveedor, cuit, descripcion, correo, telefono, estado FROM Proveedores";
                    SqlCommand command = new SqlCommand(query, oConexion);
                    command.CommandType = CommandType.Text;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista_proveedores.Add(new Proveedores()
                            {
                                Id_proveedor = Convert.ToInt32(reader["id_proveedor"]),
                                Cuit = reader["cuit"].ToString(),
                                Descripcion = reader["descripcion"].ToString(),
                                Correo = reader["correo"].ToString(),
                                Telefono = reader["telefono"].ToString(),
                                Estado = Convert.ToBoolean(reader["estado"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista_proveedores = new List<Proveedores>();
                }
                return lista_proveedores;
            }
        }

        public bool Modificar(Proveedores oProveedor, out string mensaje)
        {
            mensaje = string.Empty;
            bool resultado = false;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    oConexion.Open();
                    SqlCommand command = new SqlCommand("SP_MODIFICAR_PROVEEDOR", oConexion);
                    command.Parameters.AddWithValue("id_proveedor", oProveedor.Id_proveedor);
                    command.Parameters.AddWithValue("cuit", oProveedor.Cuit);
                    command.Parameters.AddWithValue("descripcion", oProveedor.Descripcion);
                    command.Parameters.AddWithValue("correo", oProveedor.Correo);
                    command.Parameters.AddWithValue("telefono", oProveedor.Telefono);
                    command.Parameters.AddWithValue("estado", oProveedor.Estado);
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

        public bool Eliminar(Proveedores oProveedor, out string mensaje)
        {
            mensaje = string.Empty;
            bool resultado = false;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    oConexion.Open();
                    SqlCommand command = new SqlCommand("SP_BAJA_PROVEEDOR", oConexion);
                    command.Parameters.AddWithValue("id_proveedor", oProveedor.Id_proveedor);
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

        public bool Restaurar(Proveedores oProveedor, out string mensaje)
        {
            mensaje = string.Empty;
            bool resultado = false;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    oConexion.Open();
                    SqlCommand command = new SqlCommand("SP_RESTAURAR_PROVEEDOR", oConexion);
                    command.Parameters.AddWithValue("id_proveedor", oProveedor.Id_proveedor);
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
