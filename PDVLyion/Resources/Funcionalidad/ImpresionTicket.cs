using CapaEntidad;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace POSLyion.Resources.Funcionalidad
{
    public class ImpresionTicket
    {
        private readonly PrintDocument doc = new PrintDocument();
        private readonly PrintPreviewDialog vista = new PrintPreviewDialog();
        private readonly decimal _totalConDescuento;
        private readonly decimal _vuelto;
        private readonly string _notasVenta;
        private readonly Tipo_Venta _tipoVenta;
        private readonly string _nombreUsuario;
        private readonly Ticket _ticket;

        public ImpresionTicket(Ticket oTicket, decimal totalConDescuento, decimal vuelto, string notasVenta, Tipo_Venta tipoVenta, string nombreUsuario)
        {
            _ticket = oTicket;
            _totalConDescuento = totalConDescuento;
            _vuelto = vuelto;
            _notasVenta = notasVenta;
            _tipoVenta = tipoVenta;
            _nombreUsuario = nombreUsuario;
        }

        public void Imprimir()
        {
            doc.PrinterSettings.PrinterName = doc.DefaultPageSettings.PrinterSettings.PrinterName;
            doc.PrintPage += new PrintPageEventHandler(ImprimeTicket);
            vista.Document = doc;
            //vista.Show();
            doc.Print();
        }

        public void ImprimeTicket(object sender, PrintPageEventArgs e)
        {
            int posX, posY;
            var fuente = new Font("consola", 10, FontStyle.Bold);
            try
            {
                posX = 10;
                posY = 10;
                e.Graphics.DrawString("POSLyion", fuente, Brushes.Black, posX, posY);
                posY += 30;
                e.Graphics.DrawString($"Le atendió: {_nombreUsuario} - {DateTime.Now}", fuente, Brushes.Black, posX, posY);
                posY += 30;
                fuente = new Font("consola", 9, FontStyle.Regular);
                e.Graphics.DrawString($"Notas de venta: {_notasVenta}", fuente, Brushes.Black, posX, posY);
                posY += 35;
                fuente = new Font("consola", 10, FontStyle.Bold);
                e.Graphics.DrawString("---------------------------------------------------------------------------", fuente, Brushes.Black, posX, posY);
                posY += 15;
                e.Graphics.DrawString("CANT.", fuente, Brushes.Black, posX, posY);
                posX += 60;
                e.Graphics.DrawString("PRODUCTO", fuente, Brushes.Black, posX, posY);
                posX += 170;
                e.Graphics.DrawString("PRECIO", fuente, Brushes.Black, posX, posY);
                posX += 70;
                e.Graphics.DrawString("SUBTOTAL", fuente, Brushes.Black, posX, posY);
                posX = 10;
                posY += 20;
                e.Graphics.DrawString("---------------------------------------------------------------------------", fuente, Brushes.Black, posX, posY);
                posY += 35;
                fuente = new Font("consola", 9, FontStyle.Bold);
                var maxChar = 22;
                var cadena = "";
                foreach (var producto in _ticket.Productos)
                {
                    e.Graphics.DrawString($"{producto.Cantidad}", fuente, Brushes.Black, posX, posY);
                    posX += 60;
                    if (producto.NombreProducto.Length > maxChar)
                    {
                        cadena = producto.NombreProducto.Substring(0, maxChar);
                        e.Graphics.DrawString($"{cadena}", fuente, Brushes.Black, posX, posY);
                        posX += 170;
                    }
                    else
                    {
                        e.Graphics.DrawString($"{producto.NombreProducto}", fuente, Brushes.Black, posX, posY);
                        posX += 170;
                    }
                    e.Graphics.DrawString($"{producto.Precio}", fuente, Brushes.Black, posX, posY);
                    posX += 70;
                    e.Graphics.DrawString($"{producto.Subtotal}", fuente, Brushes.Black, posX, posY);
                    posX = 10;
                    posY += 10;
                }
                posY += 10;
                fuente = new Font("consola", 10, FontStyle.Bold);
                e.Graphics.DrawString("---------------------------------------------------------------------------", fuente, Brushes.Black, posX, posY);
                posY += 30;
                e.Graphics.DrawString($"Vuelto: {_vuelto}\nTotal: {_totalConDescuento}\nGracias por su compra.", fuente, Brushes.Black, posX, posY);
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(ex.Message);
            }
        }
    }
}
