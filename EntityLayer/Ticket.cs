using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Ticket
    {
        public int Numero_ticket { get; set; }
        public string Nombre_ticket { get; set; }
        public Clientes Cliente { get; set; }
        public List<Ventas_Detalle> Productos { get; set; }
        public decimal Total { get; set; }

        public Ticket(int numero, string nombre)
        {
            Numero_ticket = numero;
            Nombre_ticket = nombre;
            Productos = new List<Ventas_Detalle>();
        }
    }
}
