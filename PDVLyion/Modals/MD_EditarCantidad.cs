using System;
using System.Windows.Forms;

namespace POSLyion.Modals
{
    public partial class MD_EditarCantidad : Form
    {

        public int nueva_cantidad = 0;
        public event EventHandler VentanaCerrada;

        public MD_EditarCantidad(string descripcion_producto, int cantidad_actual)
        {
            InitializeComponent();
            lbl_descripcion_producto.Text = descripcion_producto;
            nueva_cantidad = cantidad_actual;
            num_nueva_cantidad.Text = cantidad_actual.ToString();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (num_nueva_cantidad.Text != "")
            {
                nueva_cantidad = Convert.ToInt32(num_nueva_cantidad.Text);
                VentanaCerrada?.Invoke(this, EventArgs.Empty);
                Close();
            }
            else
            {
                _ = MessageBox.Show("Por favor ingrese una cantidad válida", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
