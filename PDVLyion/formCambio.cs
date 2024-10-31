using PDCLyion.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static POSLyion.formCambio;
using CapaEntidad;

namespace POSLyion
{
    public partial class formCambio : Form
    {
        decimal montoEfectivo = 0m;
        decimal montoTarjeta = 0m;
        decimal montoMP = 0m;
        decimal total = 0;
        private Usuarios UsuarioActual;
        public decimal vuelto = 0;
        // Evento que se invoca al realizar el cobro
        // para que formulario Start se suscriba
        public event EventHandler VentanaCerrada;

        public formCambio(decimal p_total, Usuarios usuarioActual)
        {
            InitializeComponent();
            total = p_total;
            UsuarioActual = usuarioActual;
        }

        private void formCambio_Load(object sender, EventArgs e)
        {
            cbox_tipocambio.Items.Add("Efectivo");
            cbox_tipocambio.Items.Add("Mercado pago");
            cbox_tipocambio.Items.Add("Tarjeta");
            cbox_tipocambio.SelectedIndex = 0;
            lbl_suma_total.Text = Convert.ToString(total);
        }

        // Variables para almacenar los importes parciales
        private decimal importeEfectivo = 0;
        private decimal importeTarjeta = 0;
        private decimal importeMP = 0;


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cobrar_Click(object sender, EventArgs e)
        {
            string metodoPago = cbox_tipocambio.SelectedItem.ToString();
            decimal importeParcial = Convert.ToDecimal(txt_dinero_entregado.Text);
            switch (metodoPago)
            {
                case "Efectivo":
                    importeEfectivo += importeParcial;
                    lbl_efectivo.Text = $"Efectivo: {importeEfectivo:C}";
                    break;
                case "Tarjeta":
                    importeTarjeta += importeParcial;
                    lbl_tarjeta.Text = $"Tarjeta: {importeTarjeta:C}";
                    break;
                case "Mercado Pago":
                    importeMP += importeParcial;
                    lbl_mp.Text = $"QR: {importeMP:C}";
                    break;
            }
            VentanaCerrada?.Invoke(this, EventArgs.Empty);
            //this.Close();
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
        }

        private void txt_dinero_entregado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txt_dinero_entregado.Text.Trim().Length == 0 && e.KeyChar.ToString() == ",")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ",")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void btn_elimef_Click(object sender, EventArgs e)
        {
            lbl_efectivo.Text = string.Empty;
            lbl_efectivo.Text = "Efectivo: $0.00";
        }

        private void btn_elimtj_Click(object sender, EventArgs e)
        {
            lbl_tarjeta.Text = "Tarjeta: $0.00";
        }

        private void btn_buscar_cliente_Click(object sender, EventArgs e)
        {
            using (var modal = new MD_Clientes())
            {
                var resultado = modal.ShowDialog();
                if(resultado == DialogResult.OK)
                {
                    //txt_dni_cliente.Text = modal.oCliente.Dni;
                    //txt_nombre_completo_cliente.Text = modal.oCliente.Nombre_completo;
                }
            }
        }
    }
}


