using CapaEntidad;
using POSLyion.Modals;
using System;
using System.Windows.Forms;

namespace POSLyion
{
    public partial class formCobro : Form
    {
        private readonly decimal montoEfectivo = 0m;
        private readonly decimal montoTarjeta = 0m;
        private readonly decimal montoMP = 0m;
        public decimal total = 0;
        public decimal vuelto = 0;
        // Evento que se invoca al realizar el cobro
        // para que formulario Start se suscriba
        public bool venta_cerrada = false;
        private readonly Clientes Cliente;

        public formCobro(decimal p_total, Clientes cliente)
        {
            InitializeComponent();
            total = p_total - (p_total * (Convert.ToDecimal(cliente.Descuento) / 100));
            Cliente = cliente;
            lbl_suma_total.Text = Convert.ToString(total);
        }

        private void formCambio_Load(object sender, EventArgs e)
        {
            if (Cliente.Descuento != 0)
            {
                lbl_descuento_aplicado.Text = "Descuento aplicado por cliente: " + Cliente.Nombre_completo;
                lbl_descuento_aplicado.Visible = true;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_cobrar_Click(object sender, EventArgs e)
        {
            var suma_total = Convert.ToDecimal(lbl_suma_total.Text);
            decimal dinero_entregado;
            if (txt_dinero_entregado.Text != "")
            {
                dinero_entregado = Convert.ToDecimal(txt_dinero_entregado.Text);
            }
            else
            {
                _ = MessageBox.Show("Ingrese un monto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (suma_total > dinero_entregado)
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
            if (txt_dinero_entregado.Text != "")
            {
                vuelto = Convert.ToDecimal(txt_dinero_entregado.Text) - total;
                lbl_vuelto.Text = vuelto >= 0 ? "Vuelto: $" + vuelto.ToString() : "Monto entregado insuficiente";
            }
            else
            {
                lbl_vuelto.Text = "Vuelto: $0,00";
            }
            txt_dinero_entregado.Select();
        }

        private void txt_dinero_entregado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar)
&& ((txt_dinero_entregado.Text.Trim().Length == 0 && e.KeyChar.ToString() == ",")
|| (!char.IsControl(e.KeyChar) && e.KeyChar.ToString() != ","));
        }

        private void btn_elimef_Click(object sender, EventArgs e)
        {
            lbl_efectivo.Text = string.Empty;
            lbl_efectivo.Text = "Efectivo: $0.00";
        }

        private void btn_elimtj_Click(object sender, EventArgs e)
        {
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


