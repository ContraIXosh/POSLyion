using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Permisos
    {
        private CD_Permisos oCD_Permiso = new CD_Permisos();

        public List<Permisos> Leer(int id_usuario)
        {
            return oCD_Permiso.Leer(id_usuario);
        }
    }
}
