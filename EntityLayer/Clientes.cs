using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Clientes
    {
        public int? Id_cliente { get; set; }
        public string Dni { get; set; }
        public string Nombre_completo { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public bool Estado { get; set; }
        public string Create_date { get; set; }
        public string Modify_date { get; set; }
    }
}
