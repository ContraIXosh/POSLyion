using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class CD_CierreCaja
    {
        public int Crear(CierreCaja oCierreCaja, out string mensaje)
        {
            mensaje = string.Empty;
            using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                int id_generado_cierre_caja;
                try
                {
                    oConexion.Open();
                    var command = new SqlCommand("SP_ALTA_CAJA", oConexion);
                    _ = command.Parameters.AddWithValue("id_usuario", oCierreCaja.Id_usuario);
                    _ = command.Parameters.AddWithValue("monto_ventas", oCierreCaja.Monto_ventas);
                    _ = command.Parameters.AddWithValue("monto_caja", oCierreCaja.Monto_caja);
                    _ = command.Parameters.AddWithValue("fecha_inicio_turno", oCierreCaja.Fecha_inicio_turno);
                    _ = command.Parameters.AddWithValue("fecha_fin_turno", oCierreCaja.Fecha_fin_turno);
                    command.Parameters.Add("mensaje", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    command.Parameters.Add("id_generado_cierre_caja", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;
                    _ = command.ExecuteNonQuery();
                    id_generado_cierre_caja = Convert.ToInt32(command.Parameters["id_generado_cierre_caja"].Value);
                    mensaje = command.Parameters["mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    id_generado_cierre_caja = 0;
                    mensaje = ex.Message;
                }
                return id_generado_cierre_caja;
            }
        }

        public List<CierreCaja> Leer()
        {
            var lista_cierre_caja = new List<CierreCaja>();
            using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    oConexion.Open();
                    var query = new StringBuilder();
                    _ = query.AppendLine("SELECT id_cierre, id_usuario, monto_ventas, monto_caja, fecha_inicio_turno, fecha_fin_turno FROM Cierre_Caja");
                    var command = new SqlCommand(query.ToString(), oConexion)
                    {
                        CommandType = CommandType.Text
                    };
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista_cierre_caja.Add(new CierreCaja()
                            {
                                Id_cierre = Convert.ToInt32(reader["id_cierre"].ToString()),
                                Id_usuario = Convert.ToInt32(reader["id_usuario"].ToString()),
                                Monto_ventas = Convert.ToDecimal(reader["monto_ventas"].ToString()),
                                Monto_caja = Convert.ToDecimal(reader["monto_caja"].ToString()),
                                Fecha_inicio_turno = reader["fecha_inicio_turno"].ToString(),
                                Fecha_fin_turno = reader["fecha_fin_turno"].ToString()
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista_cierre_caja = new List<CierreCaja>();
                }
                return lista_cierre_caja;
            }
        }
    }
}
