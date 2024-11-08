using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Reportes
    {
        private CD_Reportes oReporte = new CD_Reportes();

        public List<ReportesDetalle> Compra_Detalle(int id_compra)
        {
            return oReporte.Compra_Detalle(id_compra);
        }

        public List<ReportesDetalle> Venta_Detalle(int id_venta)
        {
            return oReporte.Venta_Detalle(id_venta);
        }
    }
}
