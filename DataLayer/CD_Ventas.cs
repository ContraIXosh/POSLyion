using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CD_Ventas
    {
        public bool RestarStock(int id_producto, int cantidad)
        {
            bool respuesta = true;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    StringBuilder consulta = new StringBuilder();
                    consulta.AppendLine("UPDATE Productos SET stock_actual = stock_actual - @cantidad WHERE id_producto = @id_producto");
                    SqlCommand cmd = new SqlCommand(consulta.ToString(), oConexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@id_producto", id_producto);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();
                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

        public bool SumarStock(int id_producto, int cantidad)
        {
            bool respuesta = true;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    StringBuilder consulta = new StringBuilder();
                    consulta.AppendLine("UPDATE Productos SET stock_actual = stock_actual + @cantidad WHERE id_producto = @id_producto");
                    SqlCommand cmd = new SqlCommand(consulta.ToString(), oConexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@id_producto", id_producto);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();
                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

        public bool Crear(Ventas oVenta, DataTable VentaDetalle, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;
            try
            {
                using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand("SP_ALTA_VENTA", oConexion);
                    cmd.Parameters.AddWithValue("id_usuario", oVenta.oUsuario.Id_usuario);
                    cmd.Parameters.AddWithValue("id_cliente", oVenta.oCliente.Id_cliente);
                    cmd.Parameters.AddWithValue("total", oVenta.Total);
                    cmd.Parameters.AddWithValue("vuelto", oVenta.Vuelto);
                    cmd.Parameters.AddWithValue("VentaDetalle", VentaDetalle);
                    cmd.Parameters.Add("resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["resultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                mensaje = ex.Message;
            }
            return respuesta;
        }
    }
}
