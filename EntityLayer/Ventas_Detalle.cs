namespace CapaEntidad
{
    public class Ventas_Detalle
    {
        public string Id_ventas_detalle { get; set; }
        public Productos oProducto { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
    }
}
