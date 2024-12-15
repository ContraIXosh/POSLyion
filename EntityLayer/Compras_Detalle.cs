namespace CapaEntidad
{
    public class Compras_Detalle
    {
        public int Id_compras_detalle { get; set; }
        public Productos oProducto { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
    }
}
