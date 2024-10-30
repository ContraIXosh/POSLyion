using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Usuarios
    {
        private CD_Usuarios oCD_Usuario = new CD_Usuarios();

        public int Crear(Usuarios oUsuario, out string mensaje)
        {
            mensaje = string.Empty;
            if (oUsuario.Nombre_completo == "")
            {
                mensaje += "Es necesario el nombre completo de pila.\n";
            }
            if (oUsuario.Nombre_usuario == "")
            {
                mensaje += "Es necesario el nombre de usuario.\n";
            }
            if (oUsuario.Clave == "")
            {
                mensaje += "Es necesario la contraseña del usuario.\n";
            }
            if (mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return oCD_Usuario.Crear(oUsuario, out mensaje);
            }
        }

        public List<Usuarios> Leer()
        {
            return oCD_Usuario.Leer();
        }

        public bool Modificar(Usuarios oUsuario, out string mensaje)
        {
            mensaje = string.Empty;
            if (oUsuario.Nombre_completo == "")
            {
                mensaje += "Es necesario el nombre completo de pila.\n";
            }
            if (oUsuario.Nombre_usuario == "")
            {
                mensaje += "Es necesario el nombre de usuario.\n";
            }
            if (oUsuario.Clave == "")
            {
                mensaje += "Es necesario la contraseña del usuario.\n";
            }
            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return oCD_Usuario.Modificar(oUsuario, out mensaje);
            }
        }

        public bool Eliminar(Usuarios oUsuario, out string mensaje)
        {
            return oCD_Usuario.Eliminar(oUsuario, out mensaje);
        }

        public bool Restaurar(Usuarios oUsuario, out string mensaje)
        {
            return oCD_Usuario.Restaurar(oUsuario, out mensaje);
        }
    }
}
