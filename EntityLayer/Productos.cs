using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Productos
    {
        public int Id_producto { get; set; }
        public string Codigo_barras { get; set; }
        public string Descripcion { get; set; }
        public Categorias oCategoria { get; set; }
        public decimal Precio_costo { get; set; }
        public decimal Precio_venta { get; set; }
        public int Stock_actual { get; set; }
        public int Stock_minimo { get; set; }
        public bool Estado { get; set; }
        public string Create_date { get; set; }
        public string Modify_date { get; set; }
    }
}
