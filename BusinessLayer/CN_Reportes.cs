using CapaDatos;
using CapaEntidad;
using CapaEntidad.Filtros;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Reportes
    {
        private readonly CD_Reportes oReporte = new CD_Reportes();

        public List<ReportesDetalle> Compra_Detalle(FiltrosReportes filtros)
        {
            return oReporte.Compra_Detalle(filtros);
        }

        public List<ReportesDetalle> Venta_Detalle(FiltrosReportes filtros)
        {
            return oReporte.Venta_Detalle(filtros);
        }

        public List<ReportesCierre> Cierres(FiltrosReportes filtros)
        {
            return oReporte.Cierres(filtros);
        }
    }
}
