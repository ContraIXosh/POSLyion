using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class UsuariosPOS
    {
        public int Id_usuario_pos { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public string Nombre_empresa { get; set; }
        public int Cantidad_sucursales { get; set; }
        public string Email { get; set; }
        public string Fecha_vencimiento { get; set; }
    }
}
