using CapaEntidad;
using CapaNegocio;
using POSLyion.Resources.Funcionalidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace POSLyion
{
    public partial class formVentas : Form
    {
        private readonly CarritoManager _carritoManager;
        private readonly TicketManager _ticketManager;
        private readonly DataGridView dgv_detalle = new DataGridView();
        public Clientes Cliente = new Clientes();
        private decimal total = 0;
        private string dgv_activo = "factura";

        public formVentas()
        {
            InitializeComponent();
            _ticketManager = new TicketManager(flp_tickets, dgv_resumen, CalcularTotal, btn_factura_Click);
            _carritoManager = new CarritoManager(dgv_resumen, new CN_Ventas(), CalcularTotal, LimpiarBusqueda, VerDetalle, _ticketManager);
            KeyPreview = true;
        }

        private void formVentas_Load(object sender, EventArgs e)
        {
            _ = _ticketManager.AgregarNuevoTicketAsync();
        }

        private void txt_buscarproductos_TextChanged(object sender, EventArgs e)
        {
            txt_buscarproductos.BackColor = SystemColors.Control;
            txt_buscarproductos.BorderStyle = BorderStyle.FixedSingle;
            txt_buscarproductos.Select();
            dgv_productos.Rows.Clear();
            if (txt_buscarproductos.Text != "")
            {
                var tabla_productos = new CN_Productos().BuscarProductoCarrito(txt_buscarproductos.Text);
                foreach (DataRow fila in tabla_productos.Rows)
                {
                    _ = dgv_productos.Rows.Add(new object[]
                    {
                        fila["ID"],
                        fila["Descripcion"],
                        fila["Precio minorista"],
                        fila["Precio mayorista"],
                        fila["Stock actual"],
                    });
                }
            }
        }

        private async void dgv_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (!string.Equals(dgv_activo, "factura"))
                {
                    btn_factura_Click("Facturación", e);
                }

                await _carritoManager.AgregarProductoCarrito(dgv_productos, e, dgv_activo);
                txt_buscarproductos.Text = "";
                txt_buscarproductos.Select();
                CalcularTotal();
            }
        }

        private void btn_cerrarventa_Click(object sender, EventArgs e)
        {
            if (dgv_resumen.Rows.Count > 0)
            {
                using (var formularioCobro = new formCobro(total, Cliente))
                {
                    _ = formularioCobro.ShowDialog();
                    // Después de cerrar, se obtiene el valor del vuelto
                    var vuelto = formularioCobro.vuelto;
                    // Start se suscribe al evento VentanaCerrada en cuanto sea invocado
                    if (formularioCobro.venta_cerrada)
                    {
                        var total_con_descuento = formularioCobro.total != Convert.ToDecimal(lbl_suma_total.Text) ? formularioCobro.total : Convert.ToDecimal(lbl_suma_total.Text);
                        CrearVenta(total_con_descuento, vuelto);
                    }
                }
            }
            else
            {
                _ = MessageBox.Show("Debe ingresar al menos un producto al carrito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void CrearVenta(decimal totalConDescuento, decimal vuelto)
        {
            if (new CN_Ventas().Crear(GenerarVentaCabecera(totalConDescuento, vuelto), GenerarVentaDetalle(), out var mensaje, out var id_venta_generado))
            {
                var Ticket1 = new classTicket.CreaTicket();
                Ticket1.TextoCentro("Empresa xxxxx ");
                Ticket1.TextoCentro("**********************************");
                Ticket1.TextoIzquierda("");
                Ticket1.TextoCentro("Factura de Venta");
                Ticket1.TextoIzquierda("No Fac:" + id_venta_generado);
                Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
                Ticket1.TextoIzquierda("Le Atendio: " + VariablesGlobales.Usuario_actual.Nombre_completo);
                Ticket1.TextoIzquierda("");
                _ = classTicket.CreaTicket.LineasGuion();
                classTicket.CreaTicket.EncabezadoVenta(dgv_resumen);
                _ = classTicket.CreaTicket.LineasGuion();
                _ = classTicket.CreaTicket.LineasGuion();
                Ticket1.TextoIzquierda(" ");
                Ticket1.AgregaTotales("Total: ", Convert.ToDouble(totalConDescuento));
                Ticket1.TextoIzquierda(" ");
                Ticket1.TextoIzquierda(" ");
                var impresora = "Microsoft XPS Document Writer v4";
                Ticket1.ImprimirTiket(impresora);

                _ = MessageBox.Show("Venta creada con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ticketManager.FinalizarVenta();
                lbl_tipoticket.Text = "Consumidor final";
                Cliente = new Clientes();
            }
            else
            {
                _ = MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public DataTable GenerarVentaDetalle()
        {
            var ventaDetalle = new DataTable();
            _ = ventaDetalle.Columns.Add("Id_Producto", typeof(int));
            _ = ventaDetalle.Columns.Add("Precio", typeof(decimal));
            _ = ventaDetalle.Columns.Add("Cantidad", typeof(int));
            _ = ventaDetalle.Columns.Add("Subtotal", typeof(decimal));

            foreach (DataGridViewRow fila in dgv_resumen.Rows)
            {
                _ = ventaDetalle.Rows.Add(new object[]
                {
                    fila.Cells["dgv_resumen_id"].Value.ToString(),
                    fila.Cells["dgv_resumen_precio"].Value.ToString(),
                    fila.Cells["dgv_resumen_cantidad"].Value.ToString(),
                    fila.Cells["dgv_resumen_subtotal"].Value.ToString(),
                });
            }

            return ventaDetalle;
        }

        public Ventas GenerarVentaCabecera(decimal totalConDescuento, decimal vuelto)
        {
            var oVenta = new Ventas()
            {
                oUsuario = new Usuarios() { Id_usuario = VariablesGlobales.Usuario_actual.Id_usuario },
                oCliente = new Clientes() { Id_cliente = Cliente.Id_cliente == 0 ? 1 : Cliente.Id_cliente },
                Total = totalConDescuento,
                Vuelto = vuelto,
            };

            return oVenta;
        }

        public void dgv_resumen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _carritoManager.ModificarCarrito(e, dgv_activo, dgv_detalle);
        }

        private void LimpiarBusqueda()
        {
            txt_buscarproductos.Text = "";
            dgv_productos.Rows.Clear();
        }

        public void CalcularTotal()
        {
            total = 0;
            if (dgv_resumen.Rows.Count > 0)
            {
                foreach (DataGridViewRow fila in dgv_resumen.Rows)
                {
                    total += Convert.ToDecimal(fila.Cells["dgv_resumen_precio"].Value) * Convert.ToDecimal(fila.Cells["dgv_resumen_cantidad"].Value);
                }
                lbl_suma_total.Text = total.ToString();
            }
            else
            {
                total = 0;
                lbl_suma_total.Text = "0,00";
            }
        }

        public void VerDetalle(List<ReportesDetalle> lista_detalle)
        {
            foreach (var item in lista_detalle)
            {
                _ = dgv_detalle.Rows.Add(new object[]
                {
                    item.Codigo_barras,
                    item.Nombre_producto,
                    item.Nombre_categoria,
                    item.Precio_unitario,
                    item.Cantidad,
                    item.Subtotal
                });
            }
        }

        private void flagdgv()
        {
            if (!panel_container.Controls.Container.Contains(dgv_detalle))
            {
                dgv_detalle.Columns.Clear();
                dgv_detalle.AlternatingRowsDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
                _ = dgv_detalle.Columns.Add("dgv_detalle_codigo", "Cod. barras");
                _ = dgv_detalle.Columns.Add("dgv_detalle_producto", "Producto");
                _ = dgv_detalle.Columns.Add("dgv_detalle_categoria", "Categoria");
                _ = dgv_detalle.Columns.Add("dgv_detalle_precio", "Precio unitario");
                _ = dgv_detalle.Columns.Add("dgv_detalle_cantidad", "Cantidad");
                _ = dgv_detalle.Columns.Add("dgv_detalle_subtotal", "Subtotal");
                panel_container.Controls.Add(dgv_detalle, 0, 1);
                dgv_detalle.Dock = DockStyle.Fill;
                dgv_resumen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_detalle.BackgroundColor = Color.Black;
                dgv_detalle.BorderStyle = BorderStyle.None;
                dgv_detalle.CellBorderStyle = DataGridViewCellBorderStyle.None;
                dgv_detalle.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgv_detalle.ColumnHeadersDefaultCellStyle.BackColor = Color.Maroon;
                dgv_detalle.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv_detalle.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Maroon;
                dgv_detalle.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
                dgv_detalle.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                dgv_detalle.RowHeadersVisible = false;
                dgv_detalle.RowsDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
                dgv_detalle.EnableHeadersVisualStyles = false;
                dgv_detalle.AllowUserToAddRows = false;
                dgv_detalle.AllowUserToDeleteRows = false;
                dgv_detalle.AllowUserToResizeRows = false;
            }
        }

        private async void CambioVentanasAsync(string p_lbl_titulo, string p_dgv_activo)
        {
            lbl_titulo.Text = p_lbl_titulo;
            _ = dgv_activo.ToString();
            dgv_activo = p_dgv_activo;

            if (string.Equals(p_dgv_activo, "compras") || string.Equals(p_dgv_activo, "ventas"))
            {
                dgv_detalle.Rows.Clear();
                if (btn_cerrarventa.Visible == true)
                {
                    btn_cerrarventa.Visible = false;
                }
            }
            else if (string.Equals(p_dgv_activo, "factura"))
            {
                if (panel_container.Controls.Container.Contains(dgv_detalle))
                {
                    panel_container.Controls.Remove(dgv_detalle);
                }
                if (btn_cerrarventa.Visible == false)
                {
                    btn_cerrarventa.Visible = true;
                }
                await _ticketManager.MostrarProductosTicketAsync();
            }
        }

        private void btn_factura_Click(object sender, EventArgs e)
        {
            if (!string.Equals(dgv_activo, "factura"))
            {
                dgv_resumen.Rows.Clear();
                dgv_resumen.Columns.Clear();
                _ = dgv_resumen.Columns.Add("dgv_resumen_id", "ID");
                _ = dgv_resumen.Columns.Add("dgv_resumen_descripcion", "Producto");
                _ = dgv_resumen.Columns.Add("dgv_resumen_cantidad", "Cantidad");
                _ = dgv_resumen.Columns.Add("dgv_resumen_precio", "Precio");
                _ = dgv_resumen.Columns.Add("dgv_resumen_precio_mayorista", "Precio mayorista");
                _ = dgv_resumen.Columns.Add("dgv_resumen_subtotal", "Subtotal");
                _ = dgv_resumen.Columns.Add("btn_editar", "");
                _ = dgv_resumen.Columns.Add("btn_eliminar", "");
                _ = dgv_resumen.Columns.Add("control_precio_aplicado", "");
                dgv_resumen.Columns["dgv_resumen_id"].Visible = false;
                dgv_resumen.Columns["dgv_resumen_precio_mayorista"].Visible = false;
                dgv_resumen.Columns["control_precio_aplicado"].Visible = false;
                dgv_resumen.Dock = DockStyle.Fill;
                dgv_resumen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_resumen.Visible = true;
                CambioVentanasAsync("Facturación", "factura");
            }
        }

        private void btn_compra_Click(object sender, EventArgs e)
        {
            if (!string.Equals(dgv_activo, "compras"))
            {
                var fecha_hoy = DateTime.Now;
                var formato_fecha_hoy = fecha_hoy.ToString("yyyy-MM-dd");
                var lista_compras = new CN_Compras().Leer(formato_fecha_hoy, formato_fecha_hoy);
                CambioVentanasAsync("Compras del día", "compras");
                flagdgv();
                dgv_resumen.Columns.Clear();
                _ = dgv_resumen.Columns.Add("id_compra", "Nro. Compra");
                _ = dgv_resumen.Columns.Add("fecha_documento", "Fecha");
                _ = dgv_resumen.Columns.Add("numero_documento", "Nro. Documento");
                _ = dgv_resumen.Columns.Add("total", "Total");
                _ = dgv_resumen.Columns.Add("btn_ver_detalle", "");
                dgv_detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_resumen.Visible = true;
                dgv_resumen.Dock = DockStyle.Fill;
                _ = panel_container.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                _ = panel_container.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                panel_container.Controls.Add(dgv_resumen, 0, 0);
                foreach (var compra in lista_compras)
                {
                    _ = dgv_resumen.Rows.Add(new object[]
                    {
                    compra.Id_compra,
                    compra.Fecha_documento,
                    compra.Numero_documento,
                    compra.Total,
                    "Ver detalle"
                    });
                }
            }
        }

        private void btn_venta_Click(object sender, EventArgs e)
        {
            if (!string.Equals(dgv_activo, "ventas"))
            {
                var fecha_hoy = DateTime.Now;
                var formato_fecha_hoy = fecha_hoy.ToString("yyyy-MM-dd");
                var lista_ventas = new CN_Ventas().Leer(formato_fecha_hoy, formato_fecha_hoy);
                CambioVentanasAsync("Ventas del día", "ventas");
                flagdgv();
                dgv_resumen.Columns.Clear();
                _ = dgv_resumen.Columns.Add("id_venta", "Nro. Venta");
                _ = dgv_resumen.Columns.Add("fecha_venta", "Fecha y hora");
                _ = dgv_resumen.Columns.Add("nombre_cliente", "Cliente");
                _ = dgv_resumen.Columns.Add("total", "Total");
                _ = dgv_resumen.Columns.Add("btn_ver_detalle", "");
                _ = dgv_resumen.Columns.Add("btn_imprimir", "");
                dgv_detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_resumen.Visible = true;
                dgv_resumen.Dock = DockStyle.Fill;
                _ = panel_container.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                _ = panel_container.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                panel_container.Controls.Add(dgv_resumen, 0, 0);
                foreach (var venta in lista_ventas)
                {
                    _ = dgv_resumen.Rows.Add(new object[]
                    {
                    venta.Id_venta,
                    venta.Create_date,
                    venta.oCliente.Nombre_completo,
                    venta.Total,
                    "Ver detalle",
                    "Imprimir ticket"
                    });
                }
            }
        }

        private void btn_desc_Click(object sender, EventArgs e)
        {
            using (var formDescuento = new formSeleccionCliente())
            {
                _ = formDescuento.ShowDialog();
                if (formDescuento.Cliente_seleccionado)
                {
                    _ = MessageBox.Show("Cliente seleccionado:" + formDescuento.Cliente.Nombre_completo, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cliente.Id_cliente = formDescuento.Cliente.Id_cliente;
                    Cliente.Dni = formDescuento.Cliente.Dni;
                    Cliente.Nombre_completo = formDescuento.Cliente.Nombre_completo;
                    Cliente.Telefono = formDescuento.Cliente.Telefono;
                    Cliente.Descuento = formDescuento.Cliente.Descuento;
                    lbl_tipoticket.Text = Cliente.Nombre_completo != "Consumidor final" ? "Cliente: " + Cliente.Nombre_completo : "Consumidor final";
                }
            }
        }

        private void formVentas_KeyDown(object sender, KeyEventArgs e)
        {
            Keys[] teclasEspeciales =
                { Keys.F1, Keys.F2, Keys.F3, Keys.F4,
                Keys.F5, Keys.F6, Keys.F7, Keys.F8,
                Keys.F9, Keys.F10, Keys.F11, Keys.F12,
                Keys.Enter, Keys.Delete, Keys.ShiftKey, Keys.ControlKey, Keys.Alt };
            if (Array.Exists(teclasEspeciales, tecla => tecla == e.KeyCode))
            {
                if (e.KeyCode == Keys.F4)
                {
                    btn_desc.PerformClick();
                }
                if (e.KeyCode == Keys.F5)
                {
                    btn_eliminar_ticket.PerformClick();
                }
                if (e.KeyCode == Keys.F6)
                {
                    _ = _ticketManager.AgregarNuevoTicketAsync();
                }
                if (e.KeyCode == Keys.F7)
                {
                    btn_cerrar_caja.PerformClick();
                }
                if (e.KeyCode == Keys.F10)
                {
                    btn_buscar_producto.PerformClick();
                }
                if (e.KeyCode == Keys.F12)
                {
                    btn_cerrarventa.PerformClick();
                }
            }

        }

        private void btn_cerrar_caja_Click(object sender, EventArgs e)
        {
            using (var formCierreCaja = new formCierreCaja(VariablesGlobales.Usuario_actual.Id_usuario))
            {
                _ = formCierreCaja.ShowDialog();
                if (formCierreCaja._caja_cerrada)
                {
                    Application.Restart();
                }
            }
        }

        private void btn_nuevo_ticket_Click(object sender, EventArgs e)
        {
            _ = _ticketManager.AgregarNuevoTicketAsync();
        }

        private async void btn_eliminar_ticket_Click(object sender, EventArgs e)
        {
            btn_factura_Click("Facturación", e);
            if (dgv_resumen.Rows.Count > 0)
            {
                var resultadoDialogo = MessageBox.Show("Esto eliminará los productos del carrito\n¿Desea continuar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resultadoDialogo == DialogResult.Yes)
                {
                    var resultadoOperacion = await _carritoManager.LimpiarCarritoAsync();
                    if (!resultadoOperacion)
                    {
                        _ = MessageBox.Show("Ocurrió un error inesperado.\nPor favor, verificar stock de productos.", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    }
                }
            }
            await _ticketManager.EliminarTicketAsync();
        }

        private void btn_buscar_producto_Click(object sender, EventArgs e)
        {
            txt_buscarproductos.Select();
            txt_buscarproductos.BackColor = Color.Bisque;
            txt_buscarproductos.BorderStyle = BorderStyle.Fixed3D;
            _ = txt_buscarproductos.Focus();
        }

        private void AplicarPrecioMinorista(DataGridViewRow filaActual)
        {
            var respaldoPrecioMayorista = Convert.ToDecimal(filaActual.Cells["dgv_resumen_precio"].Value);
            filaActual.Cells["dgv_resumen_precio"].Value = filaActual.Cells["dgv_resumen_precio_mayorista"].Value;
            filaActual.Cells["dgv_resumen_precio_mayorista"].Value = respaldoPrecioMayorista;
            filaActual.Cells["control_precio_aplicado"].Value = "minorista";
            filaActual.DefaultCellStyle.BackColor = Color.White;
            _ticketManager.AplicarPrecioMinorista(filaActual);
            CalcularTotal();
        }

        private void AplicarPrecioMayorista(DataGridViewRow filaActual)
        {
            if (Convert.ToDecimal(filaActual.Cells["dgv_resumen_precio_mayorista"].Value) != 0)
            {
                var respaldoPrecioMinorista = Convert.ToDecimal(filaActual.Cells["dgv_resumen_precio"].Value);
                filaActual.Cells["dgv_resumen_precio"].Value = filaActual.Cells["dgv_resumen_precio_mayorista"].Value;
                filaActual.Cells["dgv_resumen_precio_mayorista"].Value = respaldoPrecioMinorista;
                filaActual.Cells["control_precio_aplicado"].Value = "mayorista";
                filaActual.DefaultCellStyle.BackColor = Color.Bisque;
                _ticketManager.AplicarPrecioMayorista(filaActual);
                CalcularTotal();
            }
            else
            {
                _ = MessageBox.Show("Producto sin precio mayorista", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_buscarproductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (dgv_productos.Rows.Count > 0)
                {
                    dgv_productos.Select();
                }
                else if (_ticketManager.ObtenerTicketActual().Productos.Count > 0)
                {
                    if (!string.Equals(dgv_activo, "factura"))
                    {
                        btn_factura_Click("Facturación", e);
                    }

                    dgv_resumen.Select();
                }
            }
        }

        private void dgv_productos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var indiceFila = new DataGridViewCellEventArgs(0, dgv_productos.CurrentRow.Index);
                _ = _carritoManager.AgregarProductoCarrito(dgv_productos, indiceFila, dgv_activo);
                txt_buscarproductos.Text = "";
                txt_buscarproductos.Select();
                CalcularTotal();
                e.Handled = true;
            }
        }

        private void dgv_resumen_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgv_resumen.Rows.Count > 0)
            {
                if (e.KeyCode == Keys.F11 && dgv_activo == "factura")
                {
                    _ = dgv_resumen.CurrentCell;
                    var filaActual = dgv_resumen.CurrentRow;

                    switch (filaActual.Cells["control_precio_aplicado"].Value)
                    {
                        case "mayorista":
                            AplicarPrecioMinorista(filaActual);
                            break;
                        case "minorista":
                            AplicarPrecioMayorista(filaActual);
                            break;
                    }
                }
                if (e.KeyCode == Keys.Delete && dgv_activo == "factura")
                {
                    // Se envía el ColumnIndex 7 que corresponde al "btn_eliminar",
                    // y el índice de la fila posicionada actualmente
                    var indicesFila = new DataGridViewCellEventArgs(7, dgv_resumen.CurrentRow.Index);
                    _carritoManager.ModificarCarrito(indicesFila, dgv_activo, dgv_detalle);
                }
            }
        }

        public async void formVentas_FormClosing(object sender, FormClosingEventArgs e)
        {
            var ticketsConProductosPendientes = new List<Ticket>();
            foreach (var ticket in _ticketManager.ObtenerTickets())
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
                        await _ticketManager.SeleccionarTicketAsync(ticket);
                        var resultadoOperacion = await _carritoManager.LimpiarCarritoAsync();
                        if (!resultadoOperacion)
                        {
                            _ = MessageBox.Show("Ocurrió un error al limpiar el carrito para el ticket: " + ticket.IdTicket,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            e.Cancel = true; // Cancelar el cierre si algo falla
                            return;
                        }
                    }
                }
                else
                {
                    e.Cancel = true; // Cancelar el cierre si el usuario decide no eliminar los productos
                }
            }
        }
    }
}
