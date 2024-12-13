namespace CapaEntidad
{
    public class Abono_ventas
    {
        public int IdAbono { get; set; }
        public Clientes oCliente { get; set; }
        public decimal MontoAbono { get; set; }
        public string FechaAbono { get; set; }
    }
}
