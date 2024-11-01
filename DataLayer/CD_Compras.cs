using System;
using System.Collections.Generic;
using System.Data;
using CapaEntidad;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaDatos
{
    public class CD_Compras
    {
        public bool Crear(Compras oCompra, DataTable CompraDetalle, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;
            try
            {
                using (SqlConnection oConexion = new SqlConnection(Conexion.CadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand("SP_ALTA_COMPRA", oConexion);
                    cmd.Parameters.AddWithValue("id_usuario", oCompra.oUsuario.Id_usuario);
                    cmd.Parameters.AddWithValue("id_proveedor", oCompra.oProveedor.Id_proveedor);
                    cmd.Parameters.AddWithValue("total", oCompra.Total);
                    cmd.Parameters.AddWithValue("tipo_documento", oCompra.Tipo_documento);
                    cmd.Parameters.AddWithValue("numero_documento", oCompra.Numero_documento);
                    cmd.Parameters.AddWithValue("fecha_documento", oCompra.Fecha_documento);
                    cmd.Parameters.AddWithValue("CompraDetalle", CompraDetalle);
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
