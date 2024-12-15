using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace POSLyion.Modals
{
    public partial class MD_Clientes : Form
    {

        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public List<Ventas> ListaVentas { get; set; }

        public MD_Clientes(int idCliente, string nombreCliente)
        {
            InitializeComponent();
            IdCliente = idCliente;
            NombreCliente = nombreCliente;
        }

        private void MD_Clientes_Load(object sender, System.EventArgs e)
        {
            ListaVentas = new CN_Ventas().BuscarVentasCreditoCliente(IdCliente);
            lbl_cliente.Text = $"Cliente: {NombreCliente}";
            lbl_deuda_monto.Text = CalcularDeuda().ToString();
            MostrarVentas();
        }

        private decimal CalcularDeuda()
        {
            var (totalVentasCredito, totalAbonos) = new CN_Clientes().ObtenerDeuda(IdCliente);
            return totalVentasCredito - totalAbonos;
        }

        private void MostrarVentas()
        {
            foreach (var venta in ListaVentas)
            {
                _ = dgv_ventas.Rows.Add(new object[] {
                    venta.Id_venta,
                    venta.Create_date,
                    venta.Total
                });
            }
        }

        private void dgv_ventas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_ventas.Rows.Count > 0)
            {
                dgv_productos.Rows.Clear();
                var idVentaCabecera = Convert.ToInt32(dgv_ventas.CurrentRow.Cells["id_venta"].Value);
                var ventas_detalle = new CN_Ventas().BuscarVentaDetalle(idVentaCabecera);
                if (ventas_detalle.Count > 0)
                {
                    foreach (var venta_detalle in ventas_detalle)
                    {
                        _ = dgv_productos.Rows.Add(new object[]
                        {
                            venta_detalle.oProducto.Codigo_barras,
                            venta_detalle.oProducto.Descripcion,
                            venta_detalle.Precio,
                            venta_detalle.Cantidad,
                            venta_detalle.Subtotal
                        });
                    }
                }
            }
        }

        private void btn_abonar_Click(object sender, EventArgs e)
        {
            var totalDeuda = Convert.ToDecimal(lbl_deuda_monto.Text);
            if (totalDeuda == 0)
            {
                _ = MessageBox.Show("El cliente no tiene deuda pendiente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                using (var modalAbonos = new MD_Abonos(totalDeuda))
                {
                    _ = modalAbonos.ShowDialog();
                    if (modalAbonos.AbonoRealizado)
                    {
                        if (modalAbonos.AbonoRealizado)
                        {
                            GenerarAbono(modalAbonos.MontoAbonado);
                        }
                    }
                }
            }
        }

        private void GenerarAbono(decimal montoAbonado)
        {
            var oAbono = new Abono_ventas()
            {
                oCliente = new Clientes() { Id_cliente = IdCliente },
                MontoAbono = montoAbonado
            };
            if (new CN_AbonoVenta().Crear(oAbono, out var mensaje, out _))
            {
                _ = MessageBox.Show($"Abono de {montoAbonado} generado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                lbl_deuda_monto.Text = CalcularDeuda().ToString();
            }
            else
            {
                _ = MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_liquidar_deuda_Click(object sender, EventArgs e)
        {
            var totalDeuda = Convert.ToDecimal(lbl_deuda_monto.Text);
            if (totalDeuda == 0)
            {
                _ = MessageBox.Show("El cliente no tiene deuda pendiente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var resultado = MessageBox.Show($"Se liquidará la deuda de {totalDeuda}.\n¿Desea continuar?", "Liquidación de deuda", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultado == DialogResult.Yes)
                {
                    GenerarAbono(totalDeuda);
                }
            }
        }
    }
}
