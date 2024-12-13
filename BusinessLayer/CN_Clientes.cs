using CapaDatos;
using CapaEntidad;
using CapaEntidad.Filtros;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Clientes
    {
        private readonly CD_Clientes oCD_Cliente = new CD_Clientes();

        public int Crear(Clientes oCliente, out string message)
        {
            message = string.Empty;
            if (oCliente.Nombre_completo == "")
            {
                message += "Es necesario el nombre completo de pila.\n";
            }
            return message != string.Empty ? 0 : oCD_Cliente.Crear(oCliente, out message);
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
            return message == string.Empty && oCD_Cliente.Modificar(oCliente, out message);
        }

        public bool Eliminar(Clientes oCliente, out string message)
        {
            return oCD_Cliente.Eliminar(oCliente, out message);
        }

        public bool Restaurar(Clientes oCliente, out string message)
        {
            return oCD_Cliente.Restaurar(oCliente, out message);
        }

        public (decimal totalVentasCredito, decimal totalAbonos) ObtenerDeuda(int idCliente)
        {
            return oCD_Cliente.ObtenerDeuda(idCliente);
        }
    }
}
