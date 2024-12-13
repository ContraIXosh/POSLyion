using System;
using System.Windows.Forms;

namespace POSLyion.Modals
{
    public partial class MD_Abonos : Form
    {

        public decimal TotalDeuda { get; set; }
        public decimal MontoAbonado { get; set; }
        public bool AbonoRealizado { get; set; }

        public MD_Abonos(decimal totalDeuda)
        {
            InitializeComponent();
            TotalDeuda = totalDeuda;
            AbonoRealizado = false;
        }

        private void btn_aceptar_Click(object sender, System.EventArgs e)
        {
            var montoAbonado = txt_monto_abonado.Text.Replace("$", "").Trim();

            if (montoAbonado != "" && montoAbonado != ",")
            {
                MontoAbonado = Convert.ToDecimal(montoAbonado);
                if (MontoAbonado > 0)
                {
                    if (MontoAbonado >= TotalDeuda)
                    {
                        var resultado = MessageBox.Show("El monto ingresado es igual o mayor a la deuda total.\n¿Desea liquidar la deuda?",
                            "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.No)
                        {
                            return;
                        }
                        else
                        {
                            AbonoRealizado = true;
                            MontoAbonado = TotalDeuda;
                            Close();
                        }
                    }
                    else
                    {
                        AbonoRealizado = true;
                        Close();
                    }
                }
                else
                {
                    _ = MessageBox.Show("Ingrese un monto mayor a 0", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                _ = MessageBox.Show("Ingrese un monto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void txt_monto_abonado_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tecla = e.KeyChar;
            var texto = txt_monto_abonado.Text;

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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
