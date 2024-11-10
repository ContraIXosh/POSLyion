using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Filtros
{
    public class FiltrosUsuario
    {
        public string Nombre_usuario { get; set; } = "";
        public int Id_rol { get; set; } = 0;
        public int Estado { get; set; } = 1;
    }
}
