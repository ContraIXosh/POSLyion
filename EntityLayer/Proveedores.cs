namespace CapaEntidad
{
    public class Proveedores
    {
        public int? Id_proveedor { get; set; }
        public string Cuit { get; set; }
        public string Descripcion { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public bool Estado { get; set; }
        public string Create_date { get; set; }
        public string Modify_date { get; set; }
    }
}
