using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDCLyion
{

    public partial class formCambio : Form
    {
    decimal total = 1000m;
    decimal montoEfectivo = 0m;
    decimal montoTarjeta = 0m;
    decimal montoMP = 0m;
        public formCambio()
        {
            InitializeComponent();
        }

        private void txt_modificarprecio__TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txt_modificarprecio.Text, out decimal montoIngresado))
            {
                if (montoIngresado >= total)
                {

                    montoEfectivo = montoIngresado;
                    montoTarjeta = 0;
                    montoMP = 0;

                }
                else
                {

                    montoEfectivo = montoIngresado;
                    montoTarjeta = total - montoIngresado;

                }

                lbl_efectivo.Text = $"Efectivo: {montoEfectivo:C}";
                lbl_tarjeta.Text = montoTarjeta > 0 ? $"Tarjeta: {montoTarjeta:C}" : "Tarjeta: 0";
                lbl_mp.Text = montoMP > 0 ? $"Mercado Pago: {montoMP:C}" : "Mercado Pago: 0";
            }
            else
            {
                lbl_efectivo.Text = "Efectivo: 0";
                lbl_tarjeta.Text = "Tarjeta: 0";
                lbl_mp.Text = "Mercado pago: 0";
            }
        }

        private void btn_cobrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Cobro completado: \nEfectivo: {montoEfectivo: C}\nTarjeta: {montoTarjeta: C}\nMercado Pago: {montoMP: C}");
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
