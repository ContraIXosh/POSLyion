using PDCLyion.Resources;
using EntityLayer;
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
    public partial class formPurchaseOrders : Form
    {

        private Users oUser;

        public formPurchaseOrders(Users user)
        {
            InitializeComponent();
            oUser = user;
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formPurchaseOrders_Load(object sender, EventArgs e)
        {
            cbo_tipo_documento.Items.Add(new OpcionCombo() { Value = "Factura", Text = "Factura" });
            cbo_tipo_documento.Items.Add(new OpcionCombo() { Value = "Boleta", Text = "Boleta" });
            cbo_tipo_documento.DisplayMember = "Text";
            cbo_tipo_documento.ValueMember = "Value";
            cbo_tipo_documento.SelectedIndex = 0;
        }
    }
}
