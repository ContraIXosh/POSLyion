using CapaEntidad;
using POSLyion.Modals;
using System;
using System.Windows.Forms;

namespace POSLyion
{
    public partial class formCobro : Form
    {
        private readonly decimal montoEfectivo = 0m;
        public decimal total = 0;
        public decimal vuelto = 0;
        public bool venta_cerrada = false;
        public string NotasVenta;
        private readonly Clientes Cliente;

        public formCobro(decimal p_total, Clientes cliente)
        {
            InitializeComponent();
            total = p_total;
            Cliente = cliente;
            NotasVenta = string.Empty;
        }

        private void formCobro_Load(object sender, EventArgs e)
        {
            if (Cliente == null)
            {
                lbl_nombre_cliente.Visible = false;
                lbl_cliente_seleccionado.Visible = false;
                btn_opciones_cliente.Visible = false;
            }
            else
            {
                CargarDatosCliente();
            }

            lbl_suma_total.Text = $"${Convert.ToString(total)}";
            txt_dinero_entregado.Text = lbl_suma_total.Text;
        }

        private void CargarDatosCliente()
        {
            lbl_nombre_cliente.Text = Cliente.Nombre_completo.ToString();
            if (Cliente.Descuento > 0)
            {
                total -= total * (Convert.ToDecimal(Cliente.Descuento) / 100);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_cobrar_Click(object sender, EventArgs e)
        {
            var montoTotalVenta = lbl_suma_total.Text;
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

            if (sumaTotal > dineroEntregado)
            {
                _ = MessageBox.Show("Dinero entregado insuficiente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _ = txt_dinero_entregado.Focus();
            }
            else
            {
                _ = Convert.ToDecimal(lblDineroEntregado);
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

        private void btn_opciones_cliente_Click(object sender, EventArgs e)
        {

        }
    }
}


