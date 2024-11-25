namespace CapaEntidad
{
    public class Usuarios
    {
        public int Id_usuario { get; set; }
        public string Dni { get; set; }
        public string Nombre_completo { get; set; }
        public string Correo { get; set; }
        public string Nombre_usuario { get; set; }
        public string Clave { get; set; }
        public Roles oRol { get; set; }
        public string Telefono { get; set; }
        public bool Estado { get; set; }
        public string Create_date { get; set; }
        public string Modify_date { get; set; }
    }
}
