using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_TiposVenta
    {
        public List<Tipo_Venta> Leer()
        {
            var lista_tipos_venta = new List<Tipo_Venta>();
            using (var oConexion = new SqlConnection(Conexion.CadenaConexion))
            {
                try
                {
                    var query = "SELECT id_tipo_venta, descripcion FROM Tipo_Venta";
                    var cmd = new SqlCommand(query, oConexion)
                    {
                        CommandType = System.Data.CommandType.Text,
                    };
                    oConexion.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista_tipos_venta.Add(new Tipo_Venta
                            {
                                Id = Convert.ToInt32(reader["id_tipo_venta"]),
                                Descripcion = reader["descripcion"].ToString()
                            });
                        }
                    }
                }
                catch
                {
                    lista_tipos_venta = new List<Tipo_Venta>();
                }
                finally
                {
                    oConexion.Close();
                }
                return lista_tipos_venta;
            }
        }
    }
}
