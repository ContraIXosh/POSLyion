using System;
using System.Windows.Forms;

namespace POSLyion.Modals
{
    public partial class MD_NotasVenta : Form
    {

        public string NotasVenta;
        public bool NotaAgregada;

        public MD_NotasVenta(string notas)
        {
            InitializeComponent();
            NotasVenta = notas;
            KeyPreview = true;
        }

        private void MD_NotasVenta_Load(object sender, System.EventArgs e)
        {
            NotaAgregada = false;
            txt_notas_venta.Text = NotasVenta;
        }

        private void btn_aceptar_Click(object sender, System.EventArgs e)
        {
            NotasVenta = txt_notas_venta.Text;
            NotaAgregada = true;
            Close();
        }

        private void btn_cancelar_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void MD_NotasVenta_KeyDown(object sender, KeyEventArgs e)
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
                if (e.KeyCode == Keys.Enter)
                {
                    btn_aceptar_Click(sender, e);
                }
                if (e.KeyCode == Keys.Escape)
                {
                    btn_cancelar_Click(sender, e);
                }
            }
        }
    }
}
