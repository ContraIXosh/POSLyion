using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Roles
    {

        private readonly CD_Roles oCD_Rol = new CD_Roles();

        public List<Roles> Leer()
        {
            return oCD_Rol.Leer();
        }
    }
}
