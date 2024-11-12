using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CierreCaja
    {
        public int Id_cierre { get; set; }
        public int Id_usuario { get; set; }
        public decimal Monto_ventas { get; set; }
        public decimal Monto_caja { get; set; }
        public string Fecha_inicio_turno { get; set; }
        public string Fecha_fin_turno { get; set; }
    }
}
