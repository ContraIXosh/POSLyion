using CapaDatos;
using CapaEntidad;
using EntityLayer.Filtros;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Usuarios
    {
        private readonly CD_Usuarios oCD_Usuario = new CD_Usuarios();

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
            return mensaje != string.Empty ? 0 : oCD_Usuario.Crear(oUsuario, out mensaje);
        }

        public List<Usuarios> Leer(FiltrosUsuario filtros)
        {
            return oCD_Usuario.Leer(filtros);
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
            return mensaje == string.Empty && oCD_Usuario.Modificar(oUsuario, out mensaje);
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
