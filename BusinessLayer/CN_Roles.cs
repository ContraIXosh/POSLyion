using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Roles
    {

        private CD_Roles oCD_Rol = new CD_Roles();

        public List<Roles> Leer()
        {
            return oCD_Rol.Leer();
        }
    }
}
