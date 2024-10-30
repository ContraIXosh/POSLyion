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
        decimal total = 1000m;
        decimal montoEfectivo = 0m;
        decimal montoTarjeta = 0m;
        decimal montoMP = 0m;
        decimal dinero = 0;
        private Usuarios UsuarioActual;

        public formCambio(decimal p_dinero, Usuarios usuarioActual)
        {
            InitializeComponent();
            dinero = p_dinero;
            UsuarioActual = usuarioActual;
        }

        private void formCambio_Load(object sender, EventArgs e)
        {
            cbox_tipocambio.Items.Add("Efectivo");
            cbox_tipocambio.Items.Add("Mercado pago");
            cbox_tipocambio.Items.Add("Tarjeta");

            cbox_tipocambio.SelectedIndex = 0;
            lbl_total.Text = Convert.ToString(dinero);
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
            decimal importeParcial;

            if (!decimal.TryParse(nbud_precio.Text.Replace("$", ""), out importeParcial))
            {
            }

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

            // Calcular el total pagado
            decimal totalPagado = importeEfectivo + importeTarjeta + importeMP;
            decimal diferencia = dinero - totalPagado;
            if (diferencia > 0)
            {
                lbl_total.Text = $"Falta: {diferencia:C}";
                lbl_vuelto.Text = "Vuelto: $0";
            }
            else
            {
                lbl_total.Text = "Total pagado.";
                lbl_vuelto.Text = $"Vuelto: {-diferencia:C}";
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


