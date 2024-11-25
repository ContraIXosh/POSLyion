using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_UsuariosPOS
    {
        private readonly CD_UsuariosPOS oUsuarioPOS = new CD_UsuariosPOS();

        public List<UsuariosPOS> Leer()
        {
            return oUsuarioPOS.Leer();
        }
    }
}
