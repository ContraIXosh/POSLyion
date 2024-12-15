using POSLyion.Resources;
using POSLyion.Resources.Funcionalidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSLyion
{
    public partial class formLogOut : Form
    {
        public formLogOut()
        {
            InitializeComponent();
        }

        private async void btn_cerrar_Click(object sender, EventArgs e)
        {
            if (FormManager.Instance.ObtenerFormularioPrincipal(0) is formVentas formulario)
            {
                var tareasDeLimpieza = new List<Task<bool>>();
                var ticketsPendientes = formulario.TicketManager.ObtenerTickets();
                var ticketsConProductosPendientes = new List<Ticket>();

                foreach (var ticket in ticketsPendientes)
                {
                    if (ticket.Productos.Count > 0)
                    {
                        ticketsConProductosPendientes.Add(ticket);
                    }
                }

                if (ticketsConProductosPendientes.Count > 0)
                {
                    var resultadoDialogo = MessageBox.Show("Hay tickets pendientes que aún contienen productos.\n¿Desea eliminarlos?",
                         "Mensaje",
                         MessageBoxButtons.YesNo,
                         MessageBoxIcon.Warning);
                    if (resultadoDialogo == DialogResult.Yes)
                    {
                        foreach (var ticket in ticketsConProductosPendientes)
                        {
                            tareasDeLimpieza.Add(formulario.CarritoManager.EliminarProductosFormClosingAsync(ticket));
                        }

                        var resultados = await Task.WhenAll(tareasDeLimpieza);

                        if (resultados.Any(resultado => !resultado))
                        {
                            _ = MessageBox.Show("Ocurrió un error al limpiar algunos tickets.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                        else
                        {
                            Application.Restart();
                        }
                    }
                }
                else
                {
                    Application.Restart();
                }
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
