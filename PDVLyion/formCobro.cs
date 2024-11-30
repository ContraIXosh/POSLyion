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
        private readonly Clientes Cliente;

        public formCobro(decimal p_total, Clientes cliente)
        {
            InitializeComponent();
            total = p_total - (p_total * (Convert.ToDecimal(cliente.Descuento) / 100));
            Cliente = cliente;
            lbl_suma_total.Text = $"$ {Convert.ToString(total)}";
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_cobrar_Click(object sender, EventArgs e)
        {
            var monto = lbl_suma_total.Text;
            var sumaTotal = Convert.ToDecimal(monto.Replace("$", "").Trim());
            string lblDineroEntregado;
            decimal dineroEntregado;
            if (txt_dinero_entregado.Text != "")
            {
                lblDineroEntregado = txt_dinero_entregado.Text;
                dineroEntregado = Convert.ToDecimal(lblDineroEntregado.Replace("$", "").Trim());
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
                _ = Convert.ToDecimal(txt_dinero_entregado.Text);
                venta_cerrada = true;
                Close();
            }
        }

        private void txt_dinero_entregado_TextChanged(object sender, EventArgs e)
        {
            var lblDineroEntregado = txt_dinero_entregado.Text.Replace("$", "").Trim();
            if (lblDineroEntregado != "")
            {
                vuelto = Convert.ToDecimal(lblDineroEntregado) - total;
                lbl_cambio.Text = vuelto >= 0 ? "$ " + vuelto.ToString() : "Monto entregado insuficiente";
            }
            else
            {
                lbl_cambio.Text = "$0,00";
            }
            txt_dinero_entregado.Select();
        }

        private void txt_dinero_entregado_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tecla = e.KeyChar;

            // Permitir el símbolo de dólar solo si es el primer carácter
            if (tecla == '$' && txt_dinero_entregado.Text.Length == 0)
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

            // Permitir punto para los miles, pero no más de uno seguido
            if (tecla == '.' && txt_dinero_entregado.Text.Length > 0)
            {
                var lastCommaIndex = txt_dinero_entregado.Text.LastIndexOf(',');
                var lastDotIndex = txt_dinero_entregado.Text.LastIndexOf('.');

                if (lastCommaIndex == -1 || lastDotIndex > lastCommaIndex)
                {
                    e.Handled = false;
                    return;
                }
            }

            // Permitir coma para decimales, pero solo una
            if (tecla == ',' && txt_dinero_entregado.Text.IndexOf(',') == -1)
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



        private void btn_buscar_cliente_Click(object sender, EventArgs e)
        {
            using (var modal = new MD_Clientes())
            {
                var resultado = modal.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    //txt_dni_cliente.Text = modal.oCliente.Dni;
                    //txt_nombre_completo_cliente.Text = modal.oCliente.Nombre_completo;
                }
            }
        }
    }
}


