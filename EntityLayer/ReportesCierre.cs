using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ReportesCierre
    {
        public int Id_cierre { get; set; }
        public string Nombre_usuario { get; set; }
        public decimal Monto_ventas { get; set; }
        public decimal Monto_caja { get; set; }
        public string Fecha_inicio_turno { get; set; }
        public string Fecha_fin_turno { get; set; }
    }
}
