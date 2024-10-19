using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Categorias
    {
        public int Id_categoria { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public int Cantidad { get; set; }
        public string Create_date { get; set; }
        public string Modify_date { get; set; }
    }
}
