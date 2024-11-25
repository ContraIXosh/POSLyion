using System;
using System.Windows.Forms;

namespace POSLyion
{
    public partial class formLogOut : Form
    {
        public formLogOut()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
