using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compras
    {
        public int Id_compra { get; set; }
        public Usuarios oUsuario { get; set; }
        public Proveedores oProveedor { get; set; }
        public List<Compras_Detalle> oCompras_detalle { get; set; }
        public decimal Total { get; set; }
        public string Tipo_documento { get; set; }
        public string Numero_documento { get; set; }
        public string Fecha_documento { get; set; }
        public string Create_date { get; set; }
    }
}
