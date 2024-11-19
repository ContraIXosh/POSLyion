using CapaEntidad;
using CapaEntidad.Filtros;
using CapaNegocio;
using PDCLyion.Resources;
using POSLyion.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSLyion
{
    public partial class formVentas : Form
    {
        DataGridView dgv_detalle = new DataGridView();
        private decimal total = 0;
        private decimal vuelto = 0;
        private string dgv_activo = "factura";
        private List<Ventas_Detalle> respaldo_carrito = new List<Ventas_Detalle>();
        public Clientes Cliente = new Clientes();
        private Ticket Ticket_actual;
        private Button _botonActual;

        public formVentas()
        {
            InitializeComponent();
        }

        private void formVentas_Load(object sender, EventArgs e)
        {
            // Configurar TableLayoutPanel con una columna inicial
            tlp_tickets.ColumnCount = 1;
            tlp_tickets.RowCount = 1;
            tlp_tickets.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F)); // Ajustar el tamaño de la columna automáticamente
            tlp_tickets.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            CrearNuevoTicket();
        }

        #region AgregarProductosCarrito
        private void txt_buscarproductos_TextChanged(object sender, EventArgs e)
        {
            txt_buscarproductos.Select();
            dgv_productos.Rows.Clear();
            if (txt_buscarproductos.Text != "")
            {
                DataTable tabla_productos = new CN_Productos().Buscar(txt_buscarproductos.Text);
                foreach (DataRow fila in tabla_productos.Rows)
                {
                    dgv_productos.Rows.Add(new object[]
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
                if (!String.Equals(dgv_activo, "factura"))
                {
                    this.btn_factura_Click("Facturación", e);
                }

                int idProducto = Convert.ToInt32(dgv_productos.Rows[e.RowIndex].Cells["dgv_productos_id"].Value);
                var ticket = TicketManager.Instance.ObtenerTicketPorNumero(Ticket_actual.Numero_ticket);
                var productoExistente = ticket.Productos.FirstOrDefault(p => p.oProducto.Id_producto == idProducto);

                if (productoExistente != null)
                {
                    // Producto ya existente: Actualizar cantidad y subtotal
                    if (RestarStock(idProducto, 1))
                    {
                        productoExistente.Cantidad++;
                        ActualizarFilaProductoExistente(productoExistente);
                    }
                }
                else
                {
                    // Producto no existente: Agregar nuevo producto
                    if (RestarStock(idProducto, 1))
                    {
                        var nuevoProducto = CrearNuevoProducto(e.RowIndex);
                        ticket.Productos.Add(nuevoProducto);
                        AgregarProductoDgvResumen(nuevoProducto);
                    }
                }

                // Reset búsqueda
                ResetBusqueda();
            }

            this.CalcularTotal();
        }
        private bool RestarStock(int idProducto, int cantidad)
        {
            return new CN_Ventas().RestarStock(idProducto, cantidad);
        }
        private Ventas_Detalle CrearNuevoProducto(int rowIndex)
        {
            return new Ventas_Detalle()
            {
                oProducto = new Productos()
                {
                    Id_producto = Convert.ToInt32(dgv_productos.Rows[rowIndex].Cells["dgv_productos_id"].Value),
                    Descripcion = dgv_productos.Rows[rowIndex].Cells["dgv_productos_descripcion"].Value.ToString(),
                },
                Precio = Convert.ToDecimal(dgv_productos.Rows[rowIndex].Cells["dgv_productos_precio"].Value),
                Cantidad = 1,
                Subtotal = Convert.ToDecimal(dgv_productos.Rows[rowIndex].Cells["dgv_productos_precio"].Value),
            };
        }
        private void AgregarProductoDgvResumen(Ventas_Detalle producto)
        {
            int rowIndex = dgv_resumen.Rows.Add();
            dgv_resumen.Rows[rowIndex].Cells["dgv_resumen_id"].Value = producto.oProducto.Id_producto;
            dgv_resumen.Rows[rowIndex].Cells["dgv_resumen_descripcion"].Value = producto.oProducto.Descripcion;
            dgv_resumen.Rows[rowIndex].Cells["dgv_resumen_cantidad"].Value = producto.Cantidad;
            dgv_resumen.Rows[rowIndex].Cells["dgv_resumen_precio"].Value = producto.Precio;
            dgv_resumen.Rows[rowIndex].Cells["dgv_resumen_subtotal"].Value = producto.Subtotal;
            dgv_resumen.Rows[rowIndex].Cells["btn_editar"].Value = "Editar";
            dgv_resumen.Rows[rowIndex].Cells["btn_eliminar"].Value = "Eliminar";
        }
        private void ActualizarFilaProductoExistente(Ventas_Detalle producto)
        {
            foreach (DataGridViewRow fila in dgv_resumen.Rows)
            {
                if (Convert.ToInt32(fila.Cells["dgv_resumen_id"].Value) == producto.oProducto.Id_producto)
                {
                    fila.Cells["dgv_resumen_cantidad"].Value = producto.Cantidad;
                    fila.Cells["dgv_resumen_subtotal"].Value = producto.Cantidad * producto.Precio;
                    break;
                }
            }
        }
        private void ResetBusqueda()
        {
            txt_buscarproductos.Text = "";
            dgv_productos.Rows.Clear();
            txt_buscarproductos.Select();
        }
        #endregion

        #region GestionTickets
        private void CrearNuevoTicket()
        {
            int numeroTicket = TicketManager.Instance.ObtenerTickets().Count + 1;
            string nombreTicket = "Ticket " + numeroTicket;
            Ticket nuevoTicket = new Ticket(numeroTicket, nombreTicket);
            TicketManager.Instance.AgregarTicket(nuevoTicket);
            Ticket_actual = nuevoTicket;
            // Crear un nuevo botón para representar el ticket
            Button btnTicket = new Button();
            btnTicket.Text = nombreTicket;
            btnTicket.UseVisualStyleBackColor = true;
            btnTicket.Size = new Size(100, 50); // Ajustar el tamaño del botón
            btnTicket.Click += (s, e) => SeleccionarTicket(btnTicket, nuevoTicket);
            SeleccionarTicket(btnTicket, nuevoTicket);
            // Añadir el botón al TableLayoutPanel
            tlp_tickets.Controls.Add(btnTicket, tlp_tickets.ColumnCount, 0);

            // Ajustar el estilo de la columna para que se adapte al contenido
            tlp_tickets.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

            // Incrementar el conteo de columnas
            tlp_tickets.ColumnCount++;
        }
        private void SeleccionarTicket(Button btnTicket, Ticket ticket)
        {
            Ticket_actual = ticket;
            if(_botonActual != null)
            {
                _botonActual.BackColor = SystemColors.Control;
            }
            _botonActual = btnTicket;
            _botonActual.BackColor = Color.LightBlue;
            lbl_titulo.Text = "FACTURACIÓN " + Ticket_actual.Nombre_ticket; 
            MostrarProductos(ticket);
        }
        private void MostrarProductos(Ticket ticket)
        {
            // Limpiar las columnas actuales del DataGridView
            dgv_resumen.Columns.Clear();

            // Definir y añadir columnas manualmente
            dgv_resumen.Columns.Add("dgv_resumen_id", "ID");
            dgv_resumen.Columns["dgv_resumen_id"].Visible = false;
            dgv_resumen.Columns.Add("dgv_resumen_descripcion", "Producto");
            dgv_resumen.Columns.Add("dgv_resumen_cantidad", "Cantidad");
            dgv_resumen.Columns.Add("dgv_resumen_precio", "Precio");
            dgv_resumen.Columns.Add("dgv_resumen_subtotal", "Subtotal");
            dgv_resumen.Columns.Add("btn_editar", "");
            dgv_resumen.Columns.Add("btn_eliminar", "");
            dgv_resumen.Dock = DockStyle.Fill;

            // Limpiar filas actuales del DataGridView
            dgv_resumen.Rows.Clear();

            // Añadir productos del ticket al DataGridView
            foreach (var producto in ticket.Productos)
            {
                int rowIndex = dgv_resumen.Rows.Add();
                dgv_resumen.Rows[rowIndex].Cells["dgv_resumen_id"].Value = producto.oProducto.Id_producto;
                dgv_resumen.Rows[rowIndex].Cells["dgv_resumen_descripcion"].Value = producto.oProducto.Descripcion.ToString();
                dgv_resumen.Rows[rowIndex].Cells["dgv_resumen_cantidad"].Value = producto.Cantidad;
                dgv_resumen.Rows[rowIndex].Cells["dgv_resumen_precio"].Value = producto.Precio;
                dgv_resumen.Rows[rowIndex].Cells["dgv_resumen_subtotal"].Value = producto.Precio * producto.Cantidad;
                dgv_resumen.Rows[rowIndex].Cells["btn_editar"].Value = "Editar";
                dgv_resumen.Rows[rowIndex].Cells["btn_eliminar"].Value = "Eliminar";
            }
            this.CalcularTotal();
        }
        private void btn_cerrarventa_Click(object sender, EventArgs e)
        {
            if (dgv_resumen.Rows.Count > 0)
            {
                using (var formularioCobro = new formCambio(total, Cliente))
                {
                    formularioCobro.ShowDialog();
                    // Después de cerrar, se obtiene el valor del vuelto
                    vuelto = formularioCobro.vuelto;
                    // Start se suscribe al evento VentanaCerrada en cuanto sea invocado
                    if (formularioCobro.venta_cerrada)
                    {
                        decimal total_con_descuento = (formularioCobro.total != Convert.ToDecimal(lbl_suma_total.Text) ? formularioCobro.total : Convert.ToDecimal(lbl_suma_total.Text));
                        this.CrearVenta(total_con_descuento);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar al menos un producto al carrito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        public void dgv_resumen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            dgv_resumen.EndEdit();
            var columnName = dgv_resumen.Columns[e.ColumnIndex].Name;
            var currentRow = dgv_resumen.Rows[e.RowIndex];

            switch (columnName)
            {
                case "btn_eliminar":
                    HandleDelete(currentRow, e.RowIndex);
                    break;
                case "btn_editar":
                    HandleEdit(currentRow, e.RowIndex);
                    break;
                case "btn_ver_detalle":
                    HandleViewDetail(currentRow);
                    break;
                case "btn_imprimir":
                    HandlePrint(currentRow);
                    break;
            }
        }

        #region EliminarProductoCarrito
        private void HandleDelete(DataGridViewRow row, int rowIndex)
        {
            int idProducto = Convert.ToInt32(row.Cells["dgv_resumen_id"].Value);
            int cantidad = Convert.ToInt32(row.Cells["dgv_resumen_cantidad"].Value);

            if (new CN_Ventas().SumarStock(idProducto, cantidad))
            {
                EliminarProducto(TicketManager.Instance.ObtenerTicketPorNumero(Ticket_actual.Numero_ticket), idProducto);
                dgv_resumen.Rows.RemoveAt(rowIndex);
                CalcularTotal();
                LimpiarBusqueda();
            }
        }
        private void EliminarProducto(Ticket ticket, int idProducto)
        {
            // Encontrar el producto en la lista
            var producto = ticket.Productos.FirstOrDefault(p => p.oProducto.Id_producto == idProducto);

            // Verificar si el producto existe
            if (producto != null)
            {
                // Eliminar el producto de la lista
                ticket.Productos.Remove(producto);
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }
        private void LimpiarBusqueda()
        {
            txt_buscarproductos.Text = "";
            dgv_productos.Rows.Clear();
        }
        #endregion

        #region EditarCantidadCarrito
        private void HandleEdit(DataGridViewRow row, int rowIndex)
        {
            int idProducto = Convert.ToInt32(row.Cells["dgv_resumen_id"].Value);
            string descripcion = row.Cells["dgv_resumen_descripcion"].Value.ToString();
            int cantidadActual = Convert.ToInt32(row.Cells["dgv_resumen_cantidad"].Value);

            int nuevaCantidad = ObtenerNuevaCantidad(descripcion, cantidadActual);

            if (nuevaCantidad > 0)
            {
                ActualizarCantidadProducto(row, rowIndex, idProducto, cantidadActual, nuevaCantidad);
            }
            else
            {
                ManejarCantidadInvalida(row, rowIndex, idProducto, cantidadActual);
            }
        }
        private int ObtenerNuevaCantidad(string descripcionProducto, int cantidadActual)
        {
            using (var mdEditarCantidad = new MD_EditarCantidad(descripcionProducto, cantidadActual))
            {
                mdEditarCantidad.ShowDialog();
                return mdEditarCantidad.nueva_cantidad;
            }
        }
        private void ActualizarCantidadProducto(DataGridViewRow row, int rowIndex, int idProducto, int cantidadActual, int nuevaCantidad)
        {
            var ventas = new CN_Ventas();
            bool respuesta;

            if (nuevaCantidad > cantidadActual)
            {
                respuesta = ventas.RestarStock(idProducto, nuevaCantidad - cantidadActual);
            }
            else
            {
                respuesta = ventas.SumarStock(idProducto, cantidadActual - nuevaCantidad);
            }

            if (respuesta)
            {
                ActualizarFilaResumen(row, nuevaCantidad);
                CalcularTotal();
            }
        }
        private void ActualizarFilaResumen(DataGridViewRow row, int nuevaCantidad)
        {
            TicketManager.Instance.ObtenerTicketPorNumero(Ticket_actual.Numero_ticket).Productos.Where(p => p.oProducto.Id_producto == Convert.ToInt32(row.Cells["dgv_resumen_id"].Value)).FirstOrDefault().Cantidad = nuevaCantidad;
            decimal precio = Convert.ToDecimal(row.Cells["dgv_resumen_precio"].Value);
            row.Cells["dgv_resumen_cantidad"].Value = nuevaCantidad;
            row.Cells["dgv_resumen_subtotal"].Value = nuevaCantidad * precio;
        }
        private void ManejarCantidadInvalida(DataGridViewRow row, int rowIndex, int idProducto, int cantidadActual)
        {
            var resultado = MessageBox.Show(
                "La cantidad ingresada es menor a 1. \n¿Desea eliminar el producto del carrito?",
                "Mensaje",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado == DialogResult.Yes && new CN_Ventas().SumarStock(idProducto, cantidadActual))
            {
                HandleDelete(row, rowIndex);
            }
            else
            {
                row.Cells["dgv_resumen_cantidad"].Value = 1;
            }
        }
        #endregion

        #region VerDetalle
        private void HandleViewDetail(DataGridViewRow row)
        {
            int id = ObtenerIdSegunTipo(row);
            var filtros = new FiltrosReportes { Id = id };

            LimpiarDetalles();
            CargarDetalles(filtros);
        }
        private int ObtenerIdSegunTipo(DataGridViewRow row)
        {
            string columnaId = dgv_activo == "compras" ? "id_compra" : "id_venta";
            return Convert.ToInt32(row.Cells[columnaId].Value);
        }
        private void LimpiarDetalles()
        {
            if (dgv_detalle.Rows.Count > 0)
                dgv_detalle.Rows.Clear();
        }
        private void CargarDetalles(FiltrosReportes filtros)
        {
            var reportes = new CN_Reportes();
            List<ReportesDetalle> listaDetalle;

            if (dgv_activo == "compras")
                listaDetalle = reportes.Compra_Detalle(filtros);
            else
                listaDetalle = reportes.Venta_Detalle(filtros);

            VerDetalle(listaDetalle);
        }
        public void VerDetalle(List<ReportesDetalle> lista_detalle)
        {
            foreach (ReportesDetalle item in lista_detalle)
            {
                dgv_detalle.Rows.Add(new object[]
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
        #endregion

        #region ImprimirTicket
        private void HandlePrint(DataGridViewRow row)
        {
            if (dgv_detalle.Rows.Count == 0)
            {
                MessageBox.Show("Debe presionar el botón Ver Detalle primero", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var ticket = PrepararTicket(row);
            ImprimirTicket(ticket);
        }
        private classTicket.CreaTicket PrepararTicket(DataGridViewRow row)
        {
            var dgvResumen = CrearDgvResumen();
            decimal total = CargarDatosResumen(dgvResumen);
            int idVenta = Convert.ToInt32(row.Cells["id_venta"].Value);

            var ticket = new classTicket.CreaTicket();
            ConfigurarEncabezadoTicket(ticket, idVenta);
            classTicket.CreaTicket.EncabezadoVenta(dgvResumen);
            ConfigurarPieTicket(ticket, total);

            return ticket;
        }
        private DataGridView CrearDgvResumen()
        {
            return new DataGridView
            {
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                Columns =
        {
            new DataGridViewTextBoxColumn { Name = "dgv_resumen_descripcion", HeaderText = "Descripción" },
            new DataGridViewTextBoxColumn { Name = "dgv_resumen_cantidad", HeaderText = "Cantidad" },
            new DataGridViewTextBoxColumn { Name = "dgv_resumen_precio", HeaderText = "Precio Unitario" },
            new DataGridViewTextBoxColumn { Name = "dgv_resumen_subtotal", HeaderText = "Subtotal" }
        }
            };
        }
        private decimal CargarDatosResumen(DataGridView dgvResumen)
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgv_detalle.Rows)
            {
                dgvResumen.Rows.Add(
                    row.Cells["dgv_detalle_producto"].Value.ToString(),
                    row.Cells["dgv_detalle_cantidad"].Value.ToString(),
                    row.Cells["dgv_detalle_precio"].Value.ToString(),
                    row.Cells["dgv_detalle_subtotal"].Value.ToString()
                );
                total += Convert.ToDecimal(row.Cells["dgv_detalle_subtotal"].Value);
            }
            return total;
        }
        private void ConfigurarEncabezadoTicket(classTicket.CreaTicket ticket, int idVenta)
        {
            ticket.TextoCentro("Empresa xxxxx");
            ticket.TextoCentro("**********************************");
            ticket.TextoIzquierda("");
            ticket.TextoCentro("Factura de Venta");
            ticket.TextoIzquierda("No Fac:" + idVenta);
            ticket.TextoIzquierda($"Fecha:{DateTime.Now.ToShortDateString()} Hora:{DateTime.Now.ToShortTimeString()}");
            classTicket.CreaTicket.LineasGuion();
        }
        private void ConfigurarPieTicket(classTicket.CreaTicket ticket, decimal total)
        {
            classTicket.CreaTicket.LineasGuion();
            classTicket.CreaTicket.LineasGuion();
            ticket.TextoIzquierda(" ");
            ticket.AgregaTotales("Total: ", Convert.ToDouble(total));
            ticket.TextoIzquierda(" ");
            ticket.TextoIzquierda(" ");
        }
        private void ImprimirTicket(classTicket.CreaTicket ticket)
        {
            string impresora = "Microsoft XPS Document Writer";
            ticket.ImprimirTiket(impresora);
        }
        #endregion

        #region CambioVistas
        private void CambioVentanas(string p_lbl_titulo, string p_dgv_activo)
        {
            lbl_titulo.Text = p_lbl_titulo;
            string dgv_anterior = dgv_activo.ToString();
            dgv_activo = p_dgv_activo;

            if (String.Equals(p_dgv_activo, "compras") || String.Equals(p_dgv_activo, "ventas"))
            {
                dgv_detalle.Rows.Clear();
                if (btn_cerrarventa.Visible == true)
                {
                    btn_cerrarventa.Visible = false;
                }

                if (respaldo_carrito.Count == 0 && String.Equals(dgv_anterior, "factura"))
                {
                    this.GuardarCarrito();
                }
            }
            else if (String.Equals(p_dgv_activo, "factura"))
            {
                if (panel_container.Controls.Container.Contains(dgv_detalle))
                {
                    panel_container.Controls.Remove(dgv_detalle);
                }
                if (btn_cerrarventa.Visible == false)
                {
                    btn_cerrarventa.Visible = true;
                }
                if (respaldo_carrito.Count > 0)
                {
                    this.MostrarCarrito();
                }
            }
        }
        private void flagdgv()
        {
            if (!panel_container.Controls.Container.Contains(dgv_detalle))
            {
                dgv_detalle.Columns.Clear();
                dgv_detalle.Columns.Add("dgv_detalle_codigo", "Cod. barras");
                dgv_detalle.Columns.Add("dgv_detalle_producto", "Producto");
                dgv_detalle.Columns.Add("dgv_detalle_categoria", "Categoria");
                dgv_detalle.Columns.Add("dgv_detalle_precio", "Precio unitario");
                dgv_detalle.Columns.Add("dgv_detalle_cantidad", "Cantidad");
                dgv_detalle.Columns.Add("dgv_detalle_subtotal", "Subtotal");
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
        private void btn_factura_Click(object sender, EventArgs e)
        {
            if (!String.Equals(dgv_activo, "factura"))
            {
                dgv_resumen.Rows.Clear();
                dgv_resumen.Columns.Clear();
                dgv_resumen.Columns.Add("dgv_resumen_id", "ID");
                dgv_resumen.Columns.Add("dgv_resumen_descripcion", "Producto");
                dgv_resumen.Columns.Add("dgv_resumen_cantidad", "Cantidad");
                dgv_resumen.Columns.Add("dgv_resumen_precio", "Precio");
                dgv_resumen.Columns.Add("dgv_resumen_subtotal", "Subtotal");
                dgv_resumen.Columns.Add("btn_editar", "");
                dgv_resumen.Columns.Add("btn_eliminar", "");
                dgv_resumen.Columns["dgv_resumen_id"].Visible = false;
                dgv_resumen.Dock = DockStyle.Fill;
                dgv_resumen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_resumen.Visible = true;
                this.CambioVentanas("Facturación", "factura");
            }
        }
        private void btn_compra_Click(object sender, EventArgs e)
        {
            if (!String.Equals(dgv_activo, "compras"))
            {
                DateTime fecha_hoy = DateTime.Now;
                string formato_fecha_hoy = fecha_hoy.ToString("yyyy-MM-dd");
                List<Compras> lista_compras = new CN_Compras().Leer(formato_fecha_hoy, formato_fecha_hoy);
                this.CambioVentanas("Compras del día", "compras");
                flagdgv();
                dgv_resumen.Columns.Clear();
                dgv_resumen.Columns.Add("id_compra", "Nro. Compra");
                dgv_resumen.Columns.Add("fecha_documento", "Fecha");
                dgv_resumen.Columns.Add("numero_documento", "Nro. Documento");
                dgv_resumen.Columns.Add("total", "Total");
                dgv_resumen.Columns.Add("btn_ver_detalle", "");
                dgv_detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_resumen.Visible = true;
                dgv_resumen.Dock = DockStyle.Fill;
                panel_container.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                panel_container.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                panel_container.Controls.Add(dgv_resumen, 0, 0);
                foreach (Compras compra in lista_compras)
                {
                    dgv_resumen.Rows.Add(new object[]
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
            if (!String.Equals(dgv_activo, "ventas"))
            {
                DateTime fecha_hoy = DateTime.Now;
                string formato_fecha_hoy = fecha_hoy.ToString("yyyy-MM-dd");
                List<Ventas> lista_ventas = new CN_Ventas().Leer(formato_fecha_hoy, formato_fecha_hoy);
                this.CambioVentanas("Ventas del día", "ventas");
                flagdgv();
                dgv_resumen.Columns.Clear();
                dgv_resumen.Columns.Add("id_venta", "Nro. Venta");
                dgv_resumen.Columns.Add("fecha_venta", "Fecha y hora");
                dgv_resumen.Columns.Add("nombre_cliente", "Cliente");
                dgv_resumen.Columns.Add("total", "Total");
                dgv_resumen.Columns.Add("btn_ver_detalle", "");
                dgv_resumen.Columns.Add("btn_imprimir", "");
                dgv_detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_resumen.Visible = true;
                dgv_resumen.Dock = DockStyle.Fill;
                panel_container.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                panel_container.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                panel_container.Controls.Add(dgv_resumen, 0, 0);
                foreach (Ventas venta in lista_ventas)
                {
                    dgv_resumen.Rows.Add(new object[]
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
        private void GuardarCarrito()
        {
            foreach (DataGridViewRow producto in dgv_resumen.Rows)
            {
                respaldo_carrito.Add(new CapaEntidad.Ventas_Detalle()
                {
                    oProducto = new Productos()
                    {
                        Id_producto = Convert.ToInt32(producto.Cells["dgv_resumen_id"].Value),
                        Descripcion = producto.Cells["dgv_resumen_descripcion"].Value.ToString()
                    },
                    Cantidad = Convert.ToInt32(producto.Cells["dgv_resumen_cantidad"].Value),
                    Precio = Convert.ToDecimal(producto.Cells["dgv_resumen_precio"].Value),
                    Subtotal = Convert.ToDecimal(producto.Cells["dgv_resumen_subtotal"].Value)
                });
            }
        }
        private void MostrarCarrito()
        {
            foreach (CapaEntidad.Ventas_Detalle producto in respaldo_carrito)
            {
                dgv_resumen.Rows.Add(new object[]
                {
                    producto.oProducto.Id_producto,
                    producto.oProducto.Descripcion,
                    producto.Cantidad,
                    producto.Precio,
                    producto.Subtotal,
                    "Editar",
                    "Eliminar"
                });
            }
            respaldo_carrito.Clear();
        }
        #endregion

        public void CrearVenta(decimal total_con_descuento)
        {
            DataTable ventaDetalle = new DataTable();
            ventaDetalle.Columns.Add("Id_Producto", typeof(int));
            ventaDetalle.Columns.Add("Precio", typeof(decimal));
            ventaDetalle.Columns.Add("Cantidad", typeof(int));
            ventaDetalle.Columns.Add("Subtotal", typeof(decimal));

            foreach (DataGridViewRow fila in dgv_resumen.Rows)
            {
                ventaDetalle.Rows.Add(new object[]
                {
                    fila.Cells["dgv_resumen_id"].Value.ToString(),
                    fila.Cells["dgv_resumen_precio"].Value.ToString(),
                    fila.Cells["dgv_resumen_cantidad"].Value.ToString(),
                    fila.Cells["dgv_resumen_subtotal"].Value.ToString(),
                });
            }

            Ventas oVenta = new Ventas()
            {
                oUsuario = new Usuarios() { Id_usuario = VariablesGlobales.Usuario_actual.Id_usuario },
                oCliente = new Clientes() { Id_cliente = (Cliente.Id_cliente == null ? 1 : Cliente.Id_cliente) },
                Total = total_con_descuento,
                Vuelto = vuelto,
            };

            string mensaje = string.Empty;
            int id_venta_generado = 0;
            bool respuesta = new CN_Ventas().Crear(oVenta, ventaDetalle, out mensaje, out id_venta_generado);

            if (respuesta)
            {
                classTicket.CreaTicket Ticket1 = new classTicket.CreaTicket();
                Ticket1.TextoCentro("Empresa xxxxx ");
                Ticket1.TextoCentro("**********************************");
                Ticket1.TextoIzquierda("");
                Ticket1.TextoCentro("Factura de Venta");
                Ticket1.TextoIzquierda("No Fac:" + id_venta_generado);
                Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
                Ticket1.TextoIzquierda("Le Atendio: " + VariablesGlobales.Usuario_actual.Nombre_completo);
                Ticket1.TextoIzquierda("");
                classTicket.CreaTicket.LineasGuion();
                classTicket.CreaTicket.EncabezadoVenta(dgv_resumen);
                classTicket.CreaTicket.LineasGuion();
                classTicket.CreaTicket.LineasGuion();
                Ticket1.TextoIzquierda(" ");
                Ticket1.AgregaTotales("Total: ", Convert.ToDouble(total_con_descuento));
                Ticket1.TextoIzquierda(" ");
                Ticket1.TextoIzquierda(" ");
                string impresora = "Microsoft XPS Document Writer v4";
                Ticket1.ImprimirTiket(impresora);

                MessageBox.Show("Venta creada con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_resumen.Rows.Clear();
                lbl_tipoticket.Text = "Consumidor final";
                Cliente = new Clientes();
                this.CalcularTotal();
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            TicketManager.Instance.ObtenerTicketPorNumero(Ticket_actual.Numero_ticket).Total = total;
        }

        private void btn_desc_Click(object sender, EventArgs e)
        {
            using (var formDescuento = new formDescuento())
            {
                formDescuento.ShowDialog();
                if (formDescuento.Cliente_seleccionado)
                {
                    MessageBox.Show("Cliente seleccionado:" + formDescuento.Cliente.Nombre_completo, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Cliente.Id_cliente = formDescuento.Cliente.Id_cliente;
                    this.Cliente.Dni = formDescuento.Cliente.Dni;
                    this.Cliente.Nombre_completo = formDescuento.Cliente.Nombre_completo;
                    this.Cliente.Telefono = formDescuento.Cliente.Telefono;
                    this.Cliente.Descuento = formDescuento.Cliente.Descuento;
                    if (this.Cliente.Nombre_completo != "Consumidor final")
                    {
                        lbl_tipoticket.Text = "Cliente: " + this.Cliente.Nombre_completo;
                    }
                    else
                    {
                        lbl_tipoticket.Text = "Consumidor final";
                    }
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

        private void lbl_cerrarcaja_Click(object sender, EventArgs e)
        {
            using (var formCierreCaja = new formCierre(VariablesGlobales.Usuario_actual.Id_usuario))
            {
                formCierreCaja.ShowDialog();
                if (formCierreCaja._caja_cerrada)
                {
                    Application.Restart();
                }
            }
        }

        private void btn_nuevo_ticket_Click(object sender, EventArgs e)
        {
            CrearNuevoTicket();
        }
    }
}
