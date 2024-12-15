using System;

namespace CapaEntidad.Filtros
{
    public class FiltrosReportes
    {
        public int Id { get; set; } = 0;
        public string Fecha_desde { get; set; } = DateTime.Now.ToString("yyyy-MM-dd");
        public string Fecha_hasta { get; set; } = DateTime.Now.ToString("yyyy-MM-dd");
        public int Id_usuario { get; set; } = 0;
        public string Nombre_producto { get; set; } = "";
        public int Campo_adicional { get; set; } = 0;
    }
}
