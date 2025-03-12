using CapaEntidad;
using CapaNegocio;
using POSLyion.Modals;
using POSLyion.Resources.Funcionalidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POSLyion
{
    public partial class formCobro : Form
    {
        private readonly decimal montoEfectivo = 0m;
        public decimal total = 0;
        public decimal totalsindesc = 0;
        public decimal vuelto = 0;
        public bool venta_cerrada = false;
        public string NotasVenta;
        public bool _ventaACredito;
        public bool ImprimirTicket;
        private readonly Clientes Cliente;
        private List<Tipo_Venta> lista_tipos_venta;
        public Tipo_Venta TipoVenta;

        public formCobro(decimal p_total, Clientes cliente, List<ProductoCarrito> productos)
        {
            InitializeComponent();
            total = p_total;
            totalsindesc = p_total;
            Cliente = cliente;
            NotasVenta = string.Empty;
            KeyPreview = true;
            CargarDGV(productos);
        }

        private void formCobro_Load(object sender, EventArgs e)
        {
            lbl_textcondesc.Visible = false;
            total_completo.Visible = false;
            lbl_nombre_cliente.Visible = false;
            lbl_cliente_seleccionado.Visible = false;
            btn_tipo_venta.Visible = false;
            lbl_totaldesc.Visible = false;
            lbl_textporc.Visible = false;

            if (Cliente != null && Cliente.Id_cliente != 0)
            {
                lbl_nombre_cliente.Visible = true;
                lbl_cliente_seleccionado.Visible = true;
                btn_tipo_venta.Visible = true;
                lbl_totaldesc.Visible = true;
                lbl_textcondesc.Visible = true;
                total_completo.Visible = true;
                lbl_textporc.Visible = true;
                CargarDatosCliente();
            }

            
            lbl_total.Text = $"${Convert.ToString(total)}";
            total_completo.Text = $"${Convert.ToString(totalsindesc)}";
            txt_dinero_entregado.Text = lbl_total.Text;
            lista_tipos_venta = new CN_TiposVenta().Leer();
            TipoVenta = lista_tipos_venta.Where(t => t.Id == 1).FirstOrDefault();
        }

        private void CargarDatosCliente()
        {
            lbl_nombre_cliente.Text = Cliente.Nombre_completo.ToString();
            if (Cliente.Descuento > 0)
            {
                total -= total * (Convert.ToDecimal(Cliente.Descuento) / 100);
                lbl_totaldesc.Text = Cliente.Descuento.ToString() + "%";
            }
            else
            {
                total -= total;
                lbl_totaldesc.Text = "SIN DESCUENTOS";
            }
        }

        private void CargarDGV(List<ProductoCarrito> productos)
        {
            foreach (var producto in productos)
            {
                _ = dgv_resumen.Rows.Add(new object[]
                {
                    producto.NombreProducto,
                    producto.Cantidad,
                    producto.Precio,
                    producto.Subtotal
                });
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_cobrar_imprimir_Click(object sender, EventArgs e)
        {
            ImprimirTicket = true;
            var montoTotalVenta = lbl_total.Text;
            var sumaTotal = Convert.ToDecimal(montoTotalVenta.Replace("$", "").Trim());
            var lblDineroEntregado = txt_dinero_entregado.Text.Replace("$", "").Trim();
            decimal dineroEntregado;

            if (lblDineroEntregado != "" && lblDineroEntregado != ",")
            {
                dineroEntregado = Convert.ToDecimal(lblDineroEntregado);
            }
            else
            {
                _ = MessageBox.Show("Ingrese un monto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (sumaTotal > dineroEntregado && !_ventaACredito)
            {
                _ = MessageBox.Show("Dinero entregado insuficiente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _ = txt_dinero_entregado.Focus();
            }
            else
            {
                venta_cerrada = true;
                Close();
            }

            if (_ventaACredito)
            {
                venta_cerrada = true;
                Close();
            }
        }

        private void btn_notas_venta_Click(object sender, EventArgs e)
        {
            using (var modalNotasVenta = new MD_NotasVenta(NotasVenta))
            {
                _ = modalNotasVenta.ShowDialog();
                if (modalNotasVenta.NotaAgregada == true)
                {
                    NotasVenta = modalNotasVenta.NotasVenta;
                }
            }
        }

        private void txt_dinero_entregado_TextChanged(object sender, EventArgs e)
        {
            var dineroEntregado = txt_dinero_entregado.Text;

            // Ignorar el símbolo de dólar para validaciones numéricas
            if (dineroEntregado.StartsWith("$"))
            {
                dineroEntregado = dineroEntregado.Substring(1);
            }

            if (dineroEntregado != "" && dineroEntregado != ",")
            {
                vuelto = Convert.ToDecimal(dineroEntregado) - total;
                lbl_cambio.Text = vuelto >= 0 ? $"${vuelto}" : "Monto entregado insuficiente";
            }
        }

        private void txt_dinero_entregado_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tecla = e.KeyChar;
            var texto = txt_dinero_entregado.Text;

            // Permitir el símbolo de dólar solo si es el primer carácter
            if (tecla == '$' && texto.Length == 0)
            {
                e.Handled = false;
                return;
            }

            // Permitir números
            if (char.IsDigit(tecla))
            {
                e.Handled = false;
                return;
            }

            // Permitir coma para decimales, pero solo una vez
            if (tecla == ',' && texto.IndexOf(',') == -1)
            {
                e.Handled = false;
                return;
            }

            // Permitir teclas de control (backspace, delete, etc.)
            if (char.IsControl(tecla))
            {
                e.Handled = false;
                return;
            }

            // Bloquear cualquier otro carácter
            e.Handled = true;
        }

        private void btn_tipo_venta_Click(object sender, EventArgs e)
        {
            if (_ventaACredito == false)
            {
                btn_tipo_venta.Text = "VENTA\nEN\nEFECTIVO\n(F3)";
                lbl_paga_con.Text = "Venta a crédito";
                txt_dinero_entregado.Text = "$0";
                lbl_vueltex.Visible = false;
                lbl_cambio.Visible = false;
                txt_dinero_entregado.Visible = false;
                _ventaACredito = true;
                TipoVenta = lista_tipos_venta.Where(t => t.Id == 2).FirstOrDefault();
            }
            else
            {
                btn_tipo_venta.Text = "VENTA\nA\nCREDITO\n(F3)";
                lbl_paga_con.Text = "Venta en efectivo - Paga con:";
                txt_dinero_entregado.Text = lbl_total.Text;
                lbl_vueltex.Visible = true;
                lbl_cambio.Visible = true;
                txt_dinero_entregado.Visible = true;
                _ventaACredito = false;
                TipoVenta = lista_tipos_venta.Where(t => t.Id == 1).FirstOrDefault();
            }
        }

        private void formCobro_KeyDown(object sender, KeyEventArgs e)
        {
            Keys[] teclasEspeciales =
                {
                    Keys.F1, Keys.F2, Keys.F3, Keys.F4,
                    Keys.F5, Keys.F6, Keys.F7, Keys.F8,
                    Keys.F9, Keys.F10, Keys.F11, Keys.F12,
                    Keys.Enter, Keys.Delete, Keys.ShiftKey, Keys.ControlKey, Keys.Alt, Keys.Escape
                };
            if (Array.Exists(teclasEspeciales, tecla => tecla == e.KeyCode))
            {
                if (e.KeyCode == Keys.F1)
                {
                    btn_cobrar_imprimir_Click(sender, e);
                }
                if (e.KeyCode == Keys.F3)
                {
                    btn_tipo_venta_Click(sender, e);
                }
                if (e.KeyCode == Keys.F4)
                {
                    btn_notas_venta_Click(sender, e);
                }
                if (e.KeyCode == Keys.Escape)
                {
                    btn_cancelar_Click(sender, e);
                }
            }
        }

        private void btn_cobrar_sin_imprimir_Click(object sender, EventArgs e)
        {
            ImprimirTicket = false;
            var montoTotalVenta = lbl_total.Text;
            var sumaTotal = Convert.ToDecimal(montoTotalVenta.Replace("$", "").Trim());
            var lblDineroEntregado = txt_dinero_entregado.Text.Replace("$", "").Trim();
            decimal dineroEntregado;

            if (lblDineroEntregado != "" && lblDineroEntregado != ",")
            {
                dineroEntregado = Convert.ToDecimal(lblDineroEntregado);
            }
            else
            {
                _ = MessageBox.Show("Ingrese un monto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (sumaTotal > dineroEntregado && !_ventaACredito)
            {
                _ = MessageBox.Show("Dinero entregado insuficiente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _ = txt_dinero_entregado.Focus();
            }
            else
            {
                venta_cerrada = true;
                Close();
            }

            if (_ventaACredito)
            {
                venta_cerrada = true;
                Close();
            }
        }

        private void txt_dinero_entregado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                decimal precio;
                decimal pagado;

                if (decimal.TryParse(lbl_total.Text, out precio) && decimal.TryParse(txt_dinero_entregado.Text, out pagado))
                {
                    if (pagado >= precio)
                    {
                        decimal vuelto = pagado - precio;
                        lbl_vuelto.Text = "Recibes " + vuelto.ToString("C2") + " de vuelto.";
                    }
                    else
                    {
                        decimal faltante = precio - pagado;
                        lbl_cambio.Text = "Faltan " + faltante.ToString("C2") + " para completar el pago.";
                    }
                }
                else
                {
                    lbl_cambio.Text = "Introduce valores válidos.";
                }
            }
        }

    }
}


