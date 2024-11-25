﻿using CapaEntidad;
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
        private readonly Ticket _ticketSeleccionado;
        private readonly DataGridView dgv_detalle = new DataGridView();
        private decimal total = 0;
        private decimal vuelto = 0;
        private string dgv_activo = "factura";
        public Clientes Cliente = new Clientes();
        private readonly formConfiguracion formConfiguracion;
        private readonly formCompras formCompras;

        public formVentas()
        {
            InitializeComponent();
            _ticketManager = new TicketManager(flp_tickets, dgv_resumen, CalcularTotal, btn_factura_Click);
            _carritoManager = new CarritoManager(dgv_resumen, new CN_Ventas(), CalcularTotal, LimpiarBusqueda, VerDetalle, _ticketManager);
        }

        private void formVentas_Load(object sender, EventArgs e)
        {
            _ticketManager.AgregarNuevoTicket();
        }

        private void txt_buscarproductos_TextChanged(object sender, EventArgs e)
        {
            txt_buscarproductos.Select();
            dgv_productos.Rows.Clear();
            if (txt_buscarproductos.Text != "")
            {
                var tabla_productos = new CN_Productos().Buscar(txt_buscarproductos.Text);
                foreach (DataRow fila in tabla_productos.Rows)
                {
                    _ = dgv_productos.Rows.Add(new object[]
                    {
                        fila["ID"],
                        fila["Descripcion"],
                        fila["Precio"],
                        fila["Stock actual"],
                    });
                }
            }
        }

        private void dgv_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (!string.Equals(dgv_activo, "factura"))
                {
                    btn_factura_Click("Facturación", e);
                }

                _carritoManager.AgregarProductoCarrito(dgv_productos, e, dgv_activo);
                txt_buscarproductos.Text = "";
                txt_buscarproductos.Select();
                CalcularTotal();
            }
        }

        private void btn_cerrarventa_Click(object sender, EventArgs e)
        {
            if (dgv_resumen.Rows.Count > 0)
            {
                using (var formularioCobro = new formCambio(total, Cliente))
                {
                    _ = formularioCobro.ShowDialog();
                    // Después de cerrar, se obtiene el valor del vuelto
                    vuelto = formularioCobro.vuelto;
                    // Start se suscribe al evento VentanaCerrada en cuanto sea invocado
                    if (formularioCobro.venta_cerrada)
                    {
                        var total_con_descuento = formularioCobro.total != Convert.ToDecimal(lbl_suma_total.Text) ? formularioCobro.total : Convert.ToDecimal(lbl_suma_total.Text);
                        CrearVenta(total_con_descuento);
                    }
                }
            }
            else
            {
                _ = MessageBox.Show("Debe ingresar al menos un producto al carrito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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

        public void CrearVenta(decimal total_con_descuento)
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

            var oVenta = new Ventas()
            {
                oUsuario = new Usuarios() { Id_usuario = VariablesGlobales.Usuario_actual.Id_usuario },
                oCliente = new Clientes() { Id_cliente = Cliente.Id_cliente == null ? 1 : Cliente.Id_cliente },
                Total = total_con_descuento,
                Vuelto = vuelto,
            };

            var respuesta = new CN_Ventas().Crear(oVenta, ventaDetalle, out var mensaje, out var id_venta_generado);

            if (respuesta)
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
                Ticket1.AgregaTotales("Total: ", Convert.ToDouble(total_con_descuento));
                Ticket1.TextoIzquierda(" ");
                Ticket1.TextoIzquierda(" ");
                var impresora = "Microsoft XPS Document Writer v4";
                Ticket1.ImprimirTiket(impresora);

                _ = MessageBox.Show("Venta creada con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_resumen.Rows.Clear();
                lbl_tipoticket.Text = "Consumidor final";
                Cliente = new Clientes();
                CalcularTotal();
            }
            else
            {
                _ = MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void CalcularTotal()
        {
            total = 0;
            if (dgv_resumen.Rows.Count > 0)
            {
                foreach (DataGridViewRow fila in dgv_resumen.Rows)
                {
                    total += Convert.ToDecimal(fila.Cells["dgv_resumen_subtotal"].Value.ToString());
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
                _ = dgv_detalle.Columns.Add("dgv_detalle_codigo", "Cod. barras");
                _ = dgv_detalle.Columns.Add("dgv_detalle_producto", "Producto");
                _ = dgv_detalle.Columns.Add("dgv_detalle_categoria", "Categoria");
                _ = dgv_detalle.Columns.Add("dgv_detalle_precio", "Precio unitario");
                _ = dgv_detalle.Columns.Add("dgv_detalle_cantidad", "Cantidad");
                _ = dgv_detalle.Columns.Add("dgv_detalle_subtotal", "Subtotal");
                panel_container.Controls.Add(dgv_detalle, 0, 1);
                dgv_detalle.Dock = DockStyle.Fill;
                dgv_resumen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_detalle.BackgroundColor = Color.MediumSlateBlue;
                dgv_detalle.BorderStyle = BorderStyle.None;
                dgv_detalle.CellBorderStyle = DataGridViewCellBorderStyle.None;
                dgv_detalle.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgv_detalle.ColumnHeadersDefaultCellStyle.BackColor = Color.Maroon;
                dgv_detalle.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv_detalle.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Maroon;
                dgv_detalle.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
                dgv_detalle.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                dgv_detalle.RowHeadersVisible = false;
                dgv_detalle.EnableHeadersVisualStyles = false;
                dgv_detalle.AllowUserToAddRows = false;
                dgv_detalle.AllowUserToDeleteRows = false;
                dgv_detalle.AllowUserToResizeRows = false;
            }
        }

        private void CambioVentanas(string p_lbl_titulo, string p_dgv_activo)
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
                _ticketManager.MostrarProductosTicket();
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
                _ = dgv_resumen.Columns.Add("dgv_resumen_subtotal", "Subtotal");
                _ = dgv_resumen.Columns.Add("btn_editar", "");
                _ = dgv_resumen.Columns.Add("btn_eliminar", "");
                dgv_resumen.Columns["dgv_resumen_id"].Visible = false;
                dgv_resumen.Dock = DockStyle.Fill;
                dgv_resumen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_resumen.Visible = true;
                CambioVentanas("Facturación", "factura");
            }
        }

        private void btn_compra_Click(object sender, EventArgs e)
        {
            if (!string.Equals(dgv_activo, "compras"))
            {
                var fecha_hoy = DateTime.Now;
                var formato_fecha_hoy = fecha_hoy.ToString("yyyy-MM-dd");
                var lista_compras = new CN_Compras().Leer(formato_fecha_hoy, formato_fecha_hoy);
                CambioVentanas("Compras del día", "compras");
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
                CambioVentanas("Ventas del día", "ventas");
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
            using (var formDescuento = new formDescuento())
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
            if (e.KeyCode == Keys.F2)
            {
                btn_desc.PerformClick();
            }
            if (e.KeyCode == Keys.F10)
            {
                btn_cerrarventa.PerformClick();
            }
        }

        private void formVentas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formConfiguracion != null && !formConfiguracion.IsDisposed)
            {
                formConfiguracion.Close();
            }
            if (formCompras != null && !formCompras.IsDisposed)
            {
                formCompras.Close();
            }
        }

        private void lbl_cerrarcaja_Click(object sender, EventArgs e)
        {
            using (var formCierreCaja = new formCierre(VariablesGlobales.Usuario_actual.Id_usuario))
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
            _ticketManager.AgregarNuevoTicket();
        }

        private void btn_eliminar_ticket_Click(object sender, EventArgs e)
        {
            btn_factura_Click("Facturación", e);
            if (dgv_resumen.Rows.Count > 0)
            {
                var resultado = MessageBox.Show("Esto eliminará los productos del carrito\n¿Desea continuar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resultado == DialogResult.Yes)
                {
                    if (!_carritoManager.LimpiarCarrito())
                    {
                        _ = MessageBox.Show("Ocurrió un error inesperado.\nPor favor, verificar stock de productos.", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    }
                }
            }
            _ticketManager.EliminarTicket();
        }
    }
}
