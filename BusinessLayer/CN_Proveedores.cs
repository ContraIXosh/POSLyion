using CapaDatos;
using CapaEntidad;
using CapaEntidad.Filtros;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Proveedores
    {
        private readonly CD_Proveedores oCD_Proveedor = new CD_Proveedores();

        public int Crear(Proveedores oProveedor, out string mensaje)
        {
            mensaje = string.Empty;
            if (oProveedor.Descripcion == "")
            {
                mensaje += "Es necesario el nombre de la empresa o proveedor.\n";
            }
            return mensaje != string.Empty ? 0 : oCD_Proveedor.Crear(oProveedor, out mensaje);
        }

        public List<Proveedores> Leer(FiltrosProveedor filtros)
        {
            return oCD_Proveedor.Leer(filtros);
        }

        public bool Modificar(Proveedores oProveedor, out string mensaje)
        {
            mensaje = string.Empty;
            if (oProveedor.Descripcion == "")
            {
                mensaje += "Es necesario el nombre de la empresa o proveedor.\n";
            }
            return mensaje == string.Empty && oCD_Proveedor.Modificar(oProveedor, out mensaje);
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
