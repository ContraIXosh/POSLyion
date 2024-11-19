using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDCLyion.Resources
{
    public sealed class TicketManager
    {
        private static readonly Lazy<TicketManager> instance = new Lazy<TicketManager>(() => new TicketManager());
        private List<Ticket> tickets = new List<Ticket>();

        private TicketManager() { }

        public static TicketManager Instance => instance.Value;

        public void AgregarTicket(Ticket ticket)
        {
            tickets.Add(ticket);
        }

        public void EliminarTicket(Ticket ticket)
        {
            if (tickets.Count > 1)
            {
                tickets.Remove(ticket);
            }
        }

        public List<Ticket> ObtenerTickets()
        {
            return tickets;
        }

        public Ticket ObtenerTicketPorNumero(int numero)
        {
            return tickets.FirstOrDefault(t => t.Numero_ticket == numero);
        }
    }
}

