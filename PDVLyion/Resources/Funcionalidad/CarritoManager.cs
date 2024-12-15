using CapaEntidad;
using CapaEntidad.Filtros;
using CapaNegocio;
using POSLyion.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSLyion.Resources.Funcionalidad
{
    public class CarritoManager
    {

        private readonly DataGridView _dgv_resumen;
        private readonly CN_Ventas _ventasService;
        private readonly List<Ventas_Detalle> _respaldoCarrito = new List<Ventas_Detalle>();
        private readonly Action _calcularTotalCallBack;
        private readonly Action _limpiarBusquedaCallBack;
        private readonly Action<string, DataGridViewCellEventArgs> _facturaClickCallback;
        private readonly Action<List<ReportesDetalle>> _verDetalleCallBack;
        private readonly TicketManager _ticketManager;
        private readonly ActualizadorStockManager _actualizadorStock = new ActualizadorStockManager();

        public CarritoManager
            (
            DataGridView dgv_resumen,
            CN_Ventas ventasService,
            Action calcularTotalCallBack,
            Action limpiarBusquedaCallBack,
            Action<List<ReportesDetalle>> verDetalleCallBack,
            TicketManager ticketManager
            )
        {
            _dgv_resumen = dgv_resumen;
            _ventasService = ventasService;
            _calcularTotalCallBack = calcularTotalCallBack;
            _limpiarBusquedaCallBack = limpiarBusquedaCallBack;
            _verDetalleCallBack = verDetalleCallBack;
            _ticketManager = ticketManager;
        }

        public async Task AgregarProductoCarrito(DataGridView dgv_productos, DataGridViewCellEventArgs e, string dgv_activo)
        {
            var idProducto = Convert.ToInt32(dgv_productos.Rows[e.RowIndex].Cells["dgv_productos_id"].Value);

            if (!VerificarExistenciaProducto(dgv_productos, e, out var filaProductoEncontrado))
            {
                await _actualizadorStock.EncolarActualizacionStock(async () =>
                {
                    var resultadoOperacion = await _ventasService.RestarStockAsync(idProducto, 1);
                    if (resultadoOperacion)
                    {
                        var productoAgregado = GenerarProducto(dgv_productos, e, idProducto);
                        _ticketManager.AgregarProductoEnTicket(productoAgregado);
                    }
                });
            }
            else
            {
                var resultadoOperacion = await _ventasService.RestarStockAsync(idProducto, 1);
                if (resultadoOperacion)
                {
                    filaProductoEncontrado.Cells["dgv_resumen_cantidad"].Value =
                    Convert.ToInt32(filaProductoEncontrado.Cells["dgv_resumen_cantidad"].Value) + 1;
                    var subtotal =
                        Convert.ToInt32(filaProductoEncontrado.Cells["dgv_resumen_cantidad"].Value)
                        *
                        Convert.ToDecimal(filaProductoEncontrado.Cells["dgv_resumen_precio"].Value);
                    filaProductoEncontrado.Cells["dgv_resumen_subtotal"].Value = subtotal;
                    var productoActual = _ticketManager.ObtenerTicketActual().Productos.Where(p => p.IdProducto == idProducto).FirstOrDefault();
                    productoActual.Cantidad++;
                    productoActual.Subtotal = subtotal;
                }
            }
        }

        private ProductoCarrito GenerarProducto(DataGridView dgv_productos, DataGridViewCellEventArgs e, int idProducto)
        {
            _ = _dgv_resumen.Rows.Add(new object[]
                    {
                        dgv_productos.Rows[e.RowIndex].Cells["dgv_productos_id"].Value.ToString(),
                        dgv_productos.Rows[e.RowIndex].Cells["dgv_productos_descripcion"].Value.ToString(),
                        1,
                        dgv_productos.Rows[e.RowIndex].Cells["dgv_productos_precio"].Value,
                        dgv_productos.Rows[e.RowIndex].Cells["dgv_productos_precio_mayorista"].Value.ToString(),
                        dgv_productos.Rows[e.RowIndex].Cells["dgv_productos_precio"].Value,
                        "Editar",
                        "Eliminar",
                        "minorista"
                    });

            var producto = new ProductoCarrito()
            {
                IdProducto = idProducto,
                NombreProducto = dgv_productos.Rows[e.RowIndex].Cells["dgv_productos_descripcion"].Value.ToString(),
                Cantidad = 1,
                Precio = Convert.ToDecimal(dgv_productos.Rows[e.RowIndex].Cells["dgv_productos_precio"].Value),
                PrecioMayorista = Convert.ToDecimal(dgv_productos.Rows[e.RowIndex].Cells["dgv_productos_precio_mayorista"].Value),
                Subtotal = Convert.ToDecimal(dgv_productos.Rows[e.RowIndex].Cells["dgv_productos_precio"].Value),
                ControlPrecioAplicado = "minorista"
            };

            return producto;
        }

        private bool VerificarExistenciaProducto(DataGridView dgv_productos, DataGridViewCellEventArgs e, out DataGridViewRow filaProductoEncontrado)
        {
            filaProductoEncontrado = null;
            var productoExiste = false;
            foreach (DataGridViewRow productoCarrito in _dgv_resumen.Rows)
            {
                if (productoCarrito.Cells["dgv_resumen_id"].Value.ToString() == dgv_productos.Rows[e.RowIndex].Cells["dgv_productos_id"].Value.ToString())
                {
                    productoExiste = true;
                    filaProductoEncontrado = productoCarrito;
                    break;
                }
            }
            return productoExiste;
        }

        private async Task EliminarProductoCarrito(int idProducto, int cantidad, DataGridViewCellEventArgs e)
        {
            await _actualizadorStock.EncolarActualizacionStock(async () =>
            {
                var resultado = await new CN_Ventas().SumarStockAsync(idProducto, cantidad);
                if (resultado)
                {
                    // Si se sumó al stock correctamente, se elimina el producto del carrito
                    var indice = e.RowIndex;
                    if (indice >= 0)
                    {
                        _dgv_resumen.Rows.RemoveAt(indice);
                        var productoEliminado = _ticketManager.TicketSeleccionado.Productos.Where(p => p.IdProducto == idProducto).FirstOrDefault();
                        _ticketManager.EliminarProductoEnTicket(productoEliminado);
                        _calcularTotalCallBack?.Invoke();
                    }
                }
            });
            _limpiarBusquedaCallBack?.Invoke();
        }

        public async Task<bool> EliminarProductosFormClosingAsync(Ticket ticket)
        {
            _ticketManager.TicketSeleccionado = ticket;
            var resultadoOperacion = await LimpiarCarritoAsync();
            return resultadoOperacion;
        }

        public async Task<bool> LimpiarCarritoAsync()
        {
            var carritoLimpio = true;
            var productos = _ticketManager.ObtenerTicketActual().Productos;

            var tareas = productos.Select(async producto =>
            {
                var resultado = await _ventasService.SumarStockAsync(producto.IdProducto, producto.Cantidad);
                if (!resultado)
                {
                    carritoLimpio = false;
                }
            }).ToList();

            await Task.WhenAll(tareas);

            _dgv_resumen.Rows.Clear();
            _calcularTotalCallBack?.Invoke();
            return carritoLimpio;
        }

        public void ModificarCarrito(DataGridViewCellEventArgs e, string dgv_activo, DataGridView dgv_detalle)
        {
            _ = _dgv_resumen.EndEdit();

            if (_dgv_resumen.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {
                var idProducto = Convert.ToInt32(_dgv_resumen.Rows[e.RowIndex].Cells["dgv_resumen_id"].Value);
                var cantidadActualCarrito = Convert.ToInt32(_dgv_resumen.Rows[e.RowIndex].Cells["dgv_resumen_cantidad"].Value);
                _ = EliminarProductoCarrito(idProducto, cantidadActualCarrito, e);
            }

            if (_dgv_resumen.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                var idProducto = Convert.ToInt32(_dgv_resumen.Rows[e.RowIndex].Cells["dgv_resumen_id"].Value);
                var cantidadActualCarrito = Convert.ToInt32(_dgv_resumen.Rows[e.RowIndex].Cells["dgv_resumen_cantidad"].Value);
                var descripcionProducto = _dgv_resumen.Rows[e.RowIndex].Cells["dgv_resumen_descripcion"].Value.ToString();
                var nuevaCantidad = 0;

                using (var md_editarCantidad = new MD_EditarCantidad(descripcionProducto, cantidadActualCarrito))
                {
                    _ = md_editarCantidad.ShowDialog();
                    nuevaCantidad = md_editarCantidad.nueva_cantidad;
                }

                VerificarCantidadIngresada(nuevaCantidad, cantidadActualCarrito, idProducto, e);
            }

            if (_dgv_resumen.Columns[e.ColumnIndex].Name == "btn_ver_detalle")
            {
                VerDetalleCompraVenta(dgv_activo, e, dgv_detalle);
            }
            if (_dgv_resumen.Columns[e.ColumnIndex].Name == "btn_notas_venta")
            {
                VerNotasVenta(e);
            }
            if (_dgv_resumen.Columns[e.ColumnIndex].Name == "btn_imprimir")
            {
                // Obtiene el ID de la fila seleccionada
                var idVenta = Convert.ToInt32(_dgv_resumen.Rows[e.RowIndex].Cells["id_venta"].Value);

                var venta = new CN_Ventas().BuscarVenta(idVenta);
                var ventaDetalle = new CN_Ventas().BuscarVentaDetalle(idVenta);
                var listaProductos = new List<ProductoCarrito>();

                {
                    var ticket = new Ticket(66, null, null);
                    foreach (var producto in ventaDetalle)
                    {
                        listaProductos.Add(new ProductoCarrito
                        {
                            Cantidad = producto.Cantidad,
                            NombreProducto = producto.oProducto.Descripcion,
                            Precio = producto.Precio,
                            Subtotal = producto.Subtotal
                        });
                    }
                    ticket.Productos = listaProductos;
                    ticket.Cliente = new Clientes() { Nombre_completo = venta.oCliente.Nombre_completo };
                    var impresionTicket = new ImpresionTicket(ticket, venta.Total, venta.Vuelto, venta.NotasVenta, venta.oTipoVenta, venta.oUsuario.Nombre_completo, venta.Create_date);
                    impresionTicket.Imprimir();
                }


            }
        }

        private void VerificarCantidadIngresada(int nuevaCantidad, int cantidadActualCarrito, int idProducto, DataGridViewCellEventArgs e)
        {
            // Verifica si la cantidad ingresada es mayor a 0 o no es nula
            if (nuevaCantidad > 0)
            {
                // Si la nueva cantidad es mayor a la que tenía antes, entonces se resta la diferencia al stock
                if (nuevaCantidad > cantidadActualCarrito)
                {
                    _ = RestarStock(nuevaCantidad, cantidadActualCarrito, idProducto, e);
                }
                // Si la nueva cantidad es mayor a la que tenía antes, entonces se suma la diferencia al stock
                else if (nuevaCantidad < cantidadActualCarrito)
                {
                    _ = SumarStock(nuevaCantidad, cantidadActualCarrito, idProducto, e);
                }
            }
            else
            {
                _ = ManejarCantidadInvalida(idProducto, cantidadActualCarrito, e);
            }
        }

        private async Task RestarStock(int nuevaCantidad, int cantidadActualCarrito, int idProducto, DataGridViewCellEventArgs e)
        {
            var cantidadDescontarStock = nuevaCantidad - cantidadActualCarrito;
            await _actualizadorStock.EncolarActualizacionStock(async () =>
            {
                var resultadoOperacion = await _ventasService.RestarStockAsync(idProducto, cantidadDescontarStock);

                if (resultadoOperacion)
                {
                    _dgv_resumen.Rows[e.RowIndex].Cells["dgv_resumen_cantidad"].Value = nuevaCantidad;
                    _dgv_resumen.Rows[e.RowIndex].Cells["dgv_resumen_subtotal"].Value =
                                        nuevaCantidad
                                        *
                                        Convert.ToDecimal(_dgv_resumen.Rows[e.RowIndex].Cells["dgv_resumen_precio"].Value);
                    var productoModificado = _ticketManager.ObtenerTicketActual().Productos.Where(p => p.IdProducto == idProducto).FirstOrDefault();
                    productoModificado.Cantidad = nuevaCantidad;
                    productoModificado.Subtotal = nuevaCantidad * Convert.ToDecimal(_dgv_resumen.Rows[e.RowIndex].Cells["dgv_resumen_precio"].Value);
                    _calcularTotalCallBack?.Invoke();
                }
            });
        }

        private async Task SumarStock(int nuevaCantidad, int cantidadActualCarrito, int idProducto, DataGridViewCellEventArgs e)
        {
            var cantidadSumarStock = cantidadActualCarrito - nuevaCantidad;
            await _actualizadorStock.EncolarActualizacionStock(async () =>
            {
                var resultado = await new CN_Ventas().SumarStockAsync(idProducto, cantidadSumarStock);
                if (resultado)
                {
                    _dgv_resumen.Rows[e.RowIndex].Cells["dgv_resumen_cantidad"].Value = nuevaCantidad;
                    _dgv_resumen.Rows[e.RowIndex].Cells["dgv_resumen_subtotal"].Value =
                                        nuevaCantidad
                                        *
                                        Convert.ToDecimal(_dgv_resumen.Rows[e.RowIndex].Cells["dgv_resumen_precio"].Value);
                    var productoModificado = _ticketManager.ObtenerTicketActual().Productos.Where(p => p.IdProducto == idProducto).FirstOrDefault();
                    productoModificado.Cantidad = nuevaCantidad;
                    productoModificado.Subtotal = nuevaCantidad * Convert.ToDecimal(_dgv_resumen.Rows[e.RowIndex].Cells["dgv_resumen_precio"].Value);
                    _calcularTotalCallBack?.Invoke();
                }
            });
        }

        private async Task ManejarCantidadInvalida(int idProducto, int cantidadActualCarrito, DataGridViewCellEventArgs e)
        {
            var resultadoDialogo = MessageBox.Show("La cantidad ingresada es menor a 1. \n¿Desea eliminar el producto del carrito?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultadoDialogo == DialogResult.Yes)
            {
                await _actualizadorStock.EncolarActualizacionStock(async () =>
                {
                    var resultadoOperacion = await _ventasService.SumarStockAsync(idProducto, cantidadActualCarrito);
                    if (resultadoOperacion)
                    {
                        _dgv_resumen.Rows.RemoveAt(e.RowIndex);
                        var ticketActual = _ticketManager.ObtenerTicketActual();
                        var productoEliminado = ticketActual.Productos.Where(p => p.IdProducto == idProducto).FirstOrDefault();
                        _ = ticketActual.Productos.Remove(productoEliminado);
                        _calcularTotalCallBack?.Invoke();
                    }
                });
            }
            else
            {
                _dgv_resumen.Rows[e.RowIndex].Cells["dgv_resumen_cantidad"].Value = 1;
            }
        }

        private void VerDetalleCompraVenta(string dgv_activo, DataGridViewCellEventArgs e, DataGridView dgv_detalle)
        {
            int idCabecera;
            switch (dgv_activo)
            {
                case "compras":
                    idCabecera = Convert.ToInt32(_dgv_resumen.Rows[e.RowIndex].Cells["id_compra"].Value);
                    var filtrosCompras = new FiltrosReportes() { Id = idCabecera };
                    VerDetalleCompra(filtrosCompras, dgv_detalle);
                    break;
                case "ventas":
                    idCabecera = Convert.ToInt32(_dgv_resumen.Rows[e.RowIndex].Cells["id_venta"].Value);
                    var filtrosVentas = new FiltrosReportes() { Id = idCabecera };
                    VerDetalleVenta(filtrosVentas, dgv_detalle);
                    break;
            };
        }

        private void VerDetalleCompra(FiltrosReportes filtros, DataGridView dgv_detalle)
        {
            dgv_detalle.Rows.Clear();
            var _lista_detalle = new CN_Reportes().Compra_Detalle(filtros);
            _verDetalleCallBack?.Invoke(_lista_detalle);
        }

        private void VerDetalleVenta(FiltrosReportes filtros, DataGridView dgv_detalle)
        {
            dgv_detalle.Rows.Clear();
            var _lista_detalle = new CN_Reportes().Venta_Detalle(filtros);
            _verDetalleCallBack?.Invoke(_lista_detalle);
        }

        private void VerNotasVenta(DataGridViewCellEventArgs e)
        {
            var idCabecera = Convert.ToInt32(_dgv_resumen.Rows[e.RowIndex].Cells["id_venta"].Value.ToString());
            var texto = new CN_Ventas().BuscarVenta(idCabecera).NotasVenta;
            using (var notasVenta = new MD_NotasVenta(texto))
            {
                _ = notasVenta.ShowDialog();
            }
        }

        //public void GuardarCarrito()
        //{
        //    foreach (DataGridViewRow producto in _dgv_resumen.Rows)
        //    {
        //        _respaldoCarrito.Add(new Ventas_Detalle()
        //        {
        //            oProducto = new Productos()
        //            {
        //                Id_producto = Convert.ToInt32(producto.Cells["dgv_resumen_id"].Value),
        //                Descripcion = producto.Cells["dgv_resumen_descripcion"].Value.ToString()
        //            },
        //            Cantidad = Convert.ToInt32(producto.Cells["dgv_resumen_cantidad"].Value),
        //            Precio = Convert.ToDecimal(producto.Cells["dgv_resumen_precio"].Value),
        //            Subtotal = Convert.ToDecimal(producto.Cells["dgv_resumen_subtotal"].Value)
        //        });
        //    }
        //}

        //public List<Ventas_Detalle> ObtenerCarrito()
        //{
        //    return _respaldoCarrito;
        //}
    }
}
