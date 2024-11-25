using System.Collections.Generic;

namespace POSLyion.Resources.Funcionalidad
{
    public class Ticket
    {
        public int IdTicket { get; set; }
        public string NombreTicket { get; set; }
        public System.Windows.Forms.Button BotonTicket { get; set; }
        public List<ProductoCarrito> Productos { get; set; }

        public Ticket(int idTicket, string nombreTicket, System.Windows.Forms.Button botonTicket)
        {
            IdTicket = idTicket;
            NombreTicket = nombreTicket;
            BotonTicket = botonTicket;
            Productos = new List<ProductoCarrito>();
        }
    }
}
