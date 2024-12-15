using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Permisos
    {
        private readonly CD_Permisos oCD_Permiso = new CD_Permisos();

        public List<Permisos> Leer(int id_usuario)
        {
            return oCD_Permiso.Leer(id_usuario);
        }
    }
}
