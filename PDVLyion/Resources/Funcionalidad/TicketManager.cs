﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace POSLyion.Resources.Funcionalidad
{
    public class TicketManager
    {
        private readonly List<Ticket> _listaTickets;
        private readonly FlowLayoutPanel _flowLayoutPanel;
        private readonly DataGridView _dgv_resumen;
        private readonly Action _calcularTotalCallBack;
        private readonly Action<string, DataGridViewCellEventArgs> _facturaClickCallback;
        private Button _botonSeleccionado;
        public Ticket TicketSeleccionado;
        private int _cantidadTicketsCreados;

        public TicketManager(FlowLayoutPanel flowLayoutPanel, DataGridView dgv_resumen, Action calcularTotalCallBack, Action<string, DataGridViewCellEventArgs> facturaClickCallBack)
        {
            _listaTickets = new List<Ticket>();
            _flowLayoutPanel = flowLayoutPanel;
            _calcularTotalCallBack = calcularTotalCallBack;
            _botonSeleccionado = null;
            _dgv_resumen = dgv_resumen;
            _facturaClickCallback = facturaClickCallBack;
        }

        public void AgregarNuevoTicket()
        {
            _cantidadTicketsCreados++;
            var numeroTicket = _cantidadTicketsCreados;
            var nombreTicket = $"Ticket {numeroTicket}";

            var botonTicket = new System.Windows.Forms.Button
            {
                UseVisualStyleBackColor = true,
                Text = $"Ticket {numeroTicket}",
            };

            var nuevoTicket = new Ticket(numeroTicket, nombreTicket, botonTicket);
            _listaTickets.Add(nuevoTicket);

            botonTicket.Click += (s, e) => SeleccionarTicket(nuevoTicket);
            SeleccionarTicket(nuevoTicket);

            _flowLayoutPanel.Controls.Add(botonTicket);
        }

        public void EliminarTicket()
        {
            var cantidadTickets = ObtenerTickets().Count;
            if (cantidadTickets > 1)
            {
                //_ = MessageBox.Show($"Ticket eliminado:\nId: {_ticketSeleccionado.IdTicket}\nNombre: {_ticketSeleccionado.NombreTicket}");
                _ = _listaTickets.Remove(TicketSeleccionado);
                _flowLayoutPanel.Controls.Remove(_botonSeleccionado);
                _botonSeleccionado.Dispose();
                SeleccionarTicket(_listaTickets[0]);
            }
            TicketSeleccionado.Productos.Clear();
        }

        private List<Ticket> ObtenerTickets()
        {
            return _listaTickets;
        }

        private void SeleccionarTicket(Ticket ticket)
        {
            //_ = MessageBox.Show($"Ticket seleccionado:\nId: {ticket.IdTicket}\nNombre: {ticket.NombreTicket}");
            TicketSeleccionado = ticket;
            if (_botonSeleccionado != null)
            {
                _botonSeleccionado.BackColor = SystemColors.Control;
            }
            ticket.BotonTicket.BackColor = Color.LightBlue;
            _botonSeleccionado = ticket.BotonTicket;
            MostrarProductosTicket();
        }

        public void AgregarProductoEnTicket(ProductoCarrito producto)
        {
            TicketSeleccionado.Productos.Add(producto);
        }

        public void EliminarProductoEnTicket(ProductoCarrito producto)
        {
            _ = TicketSeleccionado.Productos.Remove(producto);
        }

        public void MostrarProductosTicket()
        {
            _facturaClickCallback?.Invoke("Facturacion", null);
            _dgv_resumen.Rows.Clear();
            foreach (var producto in TicketSeleccionado.Productos)
            {
                _ = _dgv_resumen.Rows.Add(new object[]
                {
                    producto.IdProducto,
                    producto.NombreProducto,
                    producto.Cantidad,
                    producto.Precio,
                    producto.PrecioMayorista,
                    producto.Subtotal,
                    "Editar",
                    "Eliminar",
                    producto.ControlPrecioAplicado,
                });
            }
            _calcularTotalCallBack?.Invoke();
        }

        public Ticket ObtenerTicketActual()
        {
            return TicketSeleccionado;
        }

        public void FinalizarVenta()
        {
            TicketSeleccionado.Productos.Clear();
            _dgv_resumen.Rows.Clear();
            _calcularTotalCallBack?.Invoke();
        }

        public void AplicarPrecioMayorista(DataGridViewRow filaProducto)
        {
            var idProducto = Convert.ToInt32(filaProducto.Cells["dgv_resumen_id"].Value);
            var producto = TicketSeleccionado.Productos.Where(p => p.IdProducto == idProducto).FirstOrDefault();

            (producto.PrecioMayorista, producto.Precio) = (producto.Precio, producto.PrecioMayorista);
            producto.ControlPrecioAplicado = "mayorista";
        }

        public void AplicarPrecioMinorista(DataGridViewRow filaProducto)
        {
            var idProducto = Convert.ToInt32(filaProducto.Cells["dgv_resumen_id"].Value);
            var producto = TicketSeleccionado.Productos.Where(p => p.IdProducto == idProducto).FirstOrDefault();

            (producto.PrecioMayorista, producto.Precio) = (producto.Precio, producto.PrecioMayorista);
            producto.ControlPrecioAplicado = "minorista";
        }
    }
}