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
    }
}
