using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ReportesDetalle
    {
        public int Id { get; set; }
        public string Codigo_barras { get; set; }
        public string Nombre_producto { get; set; }
        public string Nombre_categoria { get; set; }
        public decimal Precio_unitario { get; set; }
        public int Cantidad { get; set; }
        public string Campo_adicional { get; set; }
        public decimal Subtotal { get; set; }
        public string UsuarioRegistro { get; set; }
        public string FechaDocumento { get; set; }
        public string FechaRegistro { get; set; }
    }
}
