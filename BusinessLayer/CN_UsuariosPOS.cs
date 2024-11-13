using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_UsuariosPOS
    {
        CD_UsuariosPOS oUsuarioPOS = new CD_UsuariosPOS();

        public List<UsuariosPOS> Leer()
        {
            return oUsuarioPOS.Leer();
        }
    }
}
