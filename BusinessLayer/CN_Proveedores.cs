using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Proveedores
    {
        private CD_Proveedores oCD_Proveedor = new CD_Proveedores();

        public int Crear(Proveedores oProveedor, out string mensaje)
        {
            mensaje = string.Empty;
            if (oProveedor.Descripcion == "")
            {
                mensaje += "Es necesario el nombre de la empresa o proveedor.\n";
            }
            if (mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return oCD_Proveedor.Crear(oProveedor, out mensaje);
            }
        }

        public List<Proveedores> LeerTodo()
        {
            return oCD_Proveedor.Leer();
        }

        public bool Modificar(Proveedores oProveedor, out string mensaje)
        {
            mensaje = string.Empty;
            if (oProveedor.Descripcion == "")
            {
                mensaje += "Es necesario el nombre de la empresa o proveedor.\n";
            }
            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return oCD_Proveedor.Modificar(oProveedor, out mensaje);
            }
        }

        public bool Eliminar(Proveedores oProveedor, out string mensaje)
        {
            return oCD_Proveedor.Eliminar(oProveedor, out mensaje);
        }

        public bool Restaurar(Proveedores oProveedor, out string mensaje)
        {
            return oCD_Proveedor.Restaurar(oProveedor, out mensaje);
        }
    }
}
