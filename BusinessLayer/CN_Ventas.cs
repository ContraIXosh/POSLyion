using CapaDatos;
using CapaEntidad;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CN_Ventas
    {

        private CD_Ventas oVenta = new CD_Ventas();

        public bool RestarStock(int id_producto, int cantidad)
        {
            return oVenta.RestarStock(id_producto, cantidad);
        }

        public bool SumarStock(int id_producto, int cantidad)
        {
            return oVenta.SumarStock(id_producto, cantidad);
        }

        public bool Crear(Ventas _oVenta, DataTable VentaDetalle, out string mensaje)
        {
            return oVenta.Crear(_oVenta, VentaDetalle, out mensaje);
        }
    }
}
