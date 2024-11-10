using CapaDatos;
using CapaEntidad;
using CapaEntidad.Filtros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Clientes
    {
        private CD_Clientes oCD_Cliente = new CD_Clientes();

        public int Crear(Clientes oCliente, out string message)
        {
            message = string.Empty;
            if (oCliente.Nombre_completo == "")
            {
                message += "Es necesario el nombre completo de pila.\n";
            }
            if (message != string.Empty)
            {
                return 0;
            }
            else
            {
                return oCD_Cliente.Crear(oCliente, out message);
            }
        }

        public List<Clientes> Leer(FiltrosCliente filtros)
        {
            return oCD_Cliente.Leer(filtros);
        }

        public bool Modificar(Clientes oCliente, out string message)
        {
            message = string.Empty;
            if (oCliente.Nombre_completo == "")
            {
                message += "Es necesario el nombre completo de pila.\n";
            }
            if (message != string.Empty)
            {
                return false;
            }
            else
            {
                return oCD_Cliente.Modificar(oCliente, out message);
            }
        }

        public bool Eliminar(Clientes oCliente, out string message)
        {
            return oCD_Cliente.Eliminar(oCliente, out message);
        }

        public bool Restaurar(Clientes oCliente, out string message)
        {
            return oCD_Cliente.Restaurar(oCliente, out message);
        }
    }
}
