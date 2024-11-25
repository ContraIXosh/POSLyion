using System.Collections.Generic;

namespace CapaEntidad
{
    public class Ventas
    {
        public int Id_venta { get; set; }
        public Usuarios oUsuario { get; set; }
        public List<Ventas_Detalle> oVentas_detalle { get; set; }
        public Clientes oCliente { get; set; }
        public decimal Total { get; set; }
        public decimal Vuelto { get; set; }
        public string Create_date { get; set; }
        public string Modify_date { get; set; }
    }
}
