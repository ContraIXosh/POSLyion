using CapaEntidad;
using CapaNegocio;
using System;
using System.Windows.Forms;

namespace POSLyion
{
    public partial class formCierreCaja : Form
    {
        private readonly Ventas _total_ventas = new Ventas();
        private readonly double[] valoresBilletes = { 10, 20, 50, 100, 200, 500, 1000, 2000, 10000 };
        private double monto_caja = 0;
        public bool _caja_cerrada = false;

        public formCierreCaja(int id_usuario)
        {
            InitializeComponent();
            lbl_resultado.Visible = false;
            lbl_diff.Visible = false;
            _total_ventas = new CN_Ventas().VerTotalVentasDesde(VariablesGlobales.Inicio_sesion, id_usuario);
            lbl_caja.Text = _total_ventas.Total.ToString();
            KeyPreview = true;
        }

        private void btn_cierre_Click(object sender, EventArgs e)
        {
            var cierreCaja = new CierreCaja()
            {
                Id_usuario = VariablesGlobales.Usuario_actual.Id_usuario,
                Monto_ventas = _total_ventas.Total,
                Monto_caja = Convert.ToDecimal(monto_caja),
                Fecha_inicio_turno = VariablesGlobales.Inicio_sesion,
                Fecha_fin_turno = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            };

            var id_cierre_caja_generado = new CN_CierreCaja().Crear(cierreCaja, out var mensaje);
            if (id_cierre_caja_generado != 0)
            {
                _caja_cerrada = true;
                _ = MessageBox.Show("Cierre de caja realizado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _ = MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlarTextBox(sender, e);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            ActualizarSumaTotal();
        }

        private void ActualizarSumaTotal()
        {
            var textBoxes = new TextBox[] { txt_10, txt_20, txt_50, txt_100, txt_200, txt_500, txt_1mil, txt_2mil, txt_10mil };
            monto_caja = 0;
            for (var i = 0; i < textBoxes.Length; i++)
            {
                if (double.TryParse(textBoxes[i].Text, out var cantidad))
                {
                    monto_caja += cantidad * valoresBilletes[i];
                }
                else
                {
                    monto_caja += 0 * valoresBilletes[i];
                }
                lbl_sub.Text = monto_caja.ToString();
            }
            var diferencia = monto_caja - Convert.ToDouble(_total_ventas.Total);
            lbl_resultado.Visible = true;
            lbl_diff.Visible = true;
            if (diferencia > 0)
            {
                lbl_resultado.Text = "Sobra: $";
                lbl_diff.Text = diferencia.ToString();
            }
            else if (diferencia < 0)
            {
                lbl_resultado.Text = "Falta: $";
                lbl_diff.Text = diferencia.ToString();
            }
            else
            {
                lbl_resultado.Text = "Correcto";
                lbl_diff.Visible = false;
            }
        }
        private void formCierre_Load(object sender, EventArgs e)
        {
            txt_10.TextChanged += new EventHandler(textBox_TextChanged);
            txt_20.TextChanged += new EventHandler(textBox_TextChanged);
            txt_50.TextChanged += new EventHandler(textBox_TextChanged);
            txt_100.TextChanged += new EventHandler(textBox_TextChanged);
            txt_200.TextChanged += new EventHandler(textBox_TextChanged);
            txt_500.TextChanged += new EventHandler(textBox_TextChanged);
            txt_1mil.TextChanged += new EventHandler(textBox_TextChanged);
            txt_2mil.TextChanged += new EventHandler(textBox_TextChanged);
            txt_10mil.TextChanged += new EventHandler(textBox_TextChanged);
            txt_10.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            txt_20.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            txt_50.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            txt_100.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            txt_200.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            txt_500.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            txt_1mil.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            txt_2mil.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            txt_10mil.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
        }

        private void ControlarTextBox(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar)
&& ((((TextBox)sender).Text.Trim().Length == 0 && e.KeyChar.ToString() == ",") || !char.IsControl(e.KeyChar));
        }

        private void formCierre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btn_cancelar.PerformClick();
            }
        }
    }
}
