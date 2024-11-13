using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Filtros
{
    public class FiltrosProducto
    {
        public string Nombre_producto { get; set; } = "";
        public string Codigo_barras { get; set; } = "";
        public int Id_categoria { get; set; } = 0;
        public int Estado { get; set; } = 1;
    }
}
