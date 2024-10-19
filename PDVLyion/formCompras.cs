using POSLyion.Resources;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSLyion
{
    public partial class formCompras : Form
    {

        private static Usuarios oUser = new Usuarios();

        public formCompras(Usuarios user)
        {
            InitializeComponent();
            oUser = user;
        }

        private void formPurchaseOrders_Load(object sender, EventArgs e)
        {
            cbo_tipo_documento.Items.Add(new OpcionCombo() { Value = "Factura", Text = "Factura" });
            cbo_tipo_documento.Items.Add(new OpcionCombo() { Value = "Boleta", Text = "Boleta" });
            cbo_tipo_documento.DisplayMember = "Text";
            cbo_tipo_documento.ValueMember = "Value";
            cbo_tipo_documento.SelectedIndex = 0;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
