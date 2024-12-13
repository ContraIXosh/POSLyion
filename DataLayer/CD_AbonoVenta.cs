using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_AbonoVenta
    {
        public List<Abono_ventas> Leer()
        {
            var lista_abono_ventas = new List<Abono_ventas>();
            using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    var query = "SELECT id_abono, monto_abono, fecha_abono FROM Abono_Ventas";
                    var cmd = new SqlCommand(query, oConexion)
                    {
                        CommandType = System.Data.CommandType.Text
                    };
                    oConexion.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista_abono_ventas.Add(new Abono_ventas()
                            {
                                IdAbono = Convert.ToInt32(reader["id_abono"]),
                                MontoAbono = Convert.ToDecimal(reader["monto_abono"]),
                                FechaAbono = reader["fecha_abono"].ToString()
                            });
                        }
                    }
                }
                catch
                {
                    lista_abono_ventas = new List<Abono_ventas>();
                }
                finally
                {
                    oConexion.Close();
                }
                return lista_abono_ventas;
            }
        }

        public bool Crear(Abono_ventas oAbonoVenta, out string mensaje, out int id_abono_generado)
        {
            var respuesta = false;
            mensaje = string.Empty;
            id_abono_generado = 0;
            try
            {
                using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
                {
                    var cmd = new SqlCommand("SP_ABONO_VENTA", oConexion);
                    _ = cmd.Parameters.AddWithValue("id_cliente", oAbonoVenta.oCliente.Id_cliente);
                    _ = cmd.Parameters.AddWithValue("monto_abono", oAbonoVenta.MontoAbono);
                    cmd.Parameters.Add("resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("id_abono_generado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 360).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oConexion.Open();
                    _ = cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["resultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                    id_abono_generado = Convert.ToInt32(cmd.Parameters["id_abono_generado"].Value);
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
