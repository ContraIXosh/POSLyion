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

        public string DineroCambio
        {
            get { return lbl_cambio.Text; }
            set
            {
                lbl_cambio.Text = value;
                txt_modificarprecio.Text = value;
            }
        }
        private void txt_modificarprecio__TextChanged(object sender, EventArgs e)
        {

        }


        private void formCambio_Load(object sender, EventArgs e)
        {
            cbox_tipocambio.Items.Add("Efectivo");
            cbox_tipocambio.Items.Add("Mercado pago");
            cbox_tipocambio.Items.Add("Tarjeta");

            cbox_tipocambio.SelectedIndex = 0;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Variables para almacenar los importes parciales
        private decimal importeEfectivo = 0;
        private decimal importeTarjeta = 0;
        private decimal importeMP = 0;

        private void btn_cobrar_Click(object sender, EventArgs e)
        {
            string metodoPago = cbox_tipocambio.SelectedItem.ToString();
            decimal importeParcial;

            if (!decimal.TryParse(txt_modificarprecio.Text.Replace("$", ""), out importeParcial))
            {
                MessageBox.Show("Ingrese un importe válido");
                return;
            }

            decimal totalAPagar;
            if (!decimal.TryParse(lbl_cambio.Text.Replace("Falta: $", "").Replace("Total pagado.", "").Trim(), out totalAPagar))
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
                    lbl_mp.Text = $"Mercado Pago: {importeMP:C}";
                    break;
            }

            // Calcular el total pagado
            decimal totalPagado = importeEfectivo + importeTarjeta + importeMP;
            decimal diferencia = totalAPagar - totalPagado;

            if (diferencia > 0)
            {
                lbl_cambio.Text = $"Falta: {diferencia:C}";
                lbl_vuelto.Text = "Vuelto: $0"; 
            }
            else
            {
                lbl_cambio.Text = "Total pagado.";
                lbl_vuelto.Text = $"Vuelto: {-diferencia:C}";
            }
        }
    }
}
 
        //string totalText = lbl_cambio.Text.Replace("$", "").Trim();
        //string txtcambio = txt_modificarprecio.Text.Replace("$", "").Trim();

        //decimal importeEfectivo = 0;
        //decimal importeTarjeta = 0;
        //decimal importeMP = 0;
        //string metodoPago = cbox_tipocambio.SelectedItem.ToString();
        //decimal importeParcial = Convert.ToDecimal(txt_modificarprecio.Text);
        //string tipoCambio = cbox_tipocambio.SelectedItem.ToString();

        //decimal totalAPagar;
        //if (!decimal.TryParse(lbl_cambio.Text, out totalAPagar))
        //{
        //}

        //if (diferencia > 0)
        //{
        //    lbl_cambio.Text = Convert.ToString(total);
        //    lbl_vuelto.Text = "Vuelto: $ " + Convert.ToString(vuelto);
        //}
        //else
        //{
        //    lbl_cambio.Text = Convert.ToString(total);
        //    lbl_vuelto.Text = "Vuelto: $ " + Convert.ToString(vuelto);
        //}
        //if (diferencia > 0)
        //{
        //    lbl_cambio.Text = $"Falta: {diferencia:C}";
        //}
        //else
        //{
        //    lbl_vuelto.Text = $"Vuelto: {-diferencia:C}";

        //}


 
