using CapaEntidad;
using CapaEntidad.Filtros;
using CapaNegocio;
using POSLyion.Resources;
using System;
using System.Windows.Forms;

namespace POSLyion.Modals
{
    public partial class MD_Proveedores : Form
    {

        public Proveedores oProveedor { get; set; }

        public MD_Proveedores()
        {
            InitializeComponent();
        }

        private void MD_Proveedores_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgv_modal_proveedores.Columns)
            {
                if (columna.Visible == true)
                {
                    _ = cbo_filtro.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }

            cbo_filtro.DisplayMember = "Texto";
            cbo_filtro.ValueMember = "Valor";
            cbo_filtro.SelectedIndex = 1;

            var filtros = new FiltrosProveedor();
            var lista_proveedores = new CN_Proveedores().Leer(filtros);

            foreach (var proveedor in lista_proveedores)
            {
                if (proveedor.Estado)
                {
                    _ = dgv_modal_proveedores.Rows.Add(new object[] { proveedor.Id_proveedor, proveedor.Cuit, proveedor.Descripcion });
                }
            }

            txt_busqueda.Select();
        }

        private void dgv_modal_proveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var indice_fila = e.RowIndex;
            var indice_columna = e.ColumnIndex;
            if (indice_fila >= 0 && indice_columna >= 0)
            {
                oProveedor = new Proveedores()
                {
                    Id_proveedor = Convert.ToInt32(dgv_modal_proveedores.Rows[indice_fila].Cells["id"].Value.ToString()),
                    Cuit = dgv_modal_proveedores.Rows[indice_fila].Cells["cuit"].Value.ToString(),
                    Descripcion = dgv_modal_proveedores.Rows[indice_fila].Cells["descripcion"].Value.ToString()
                };
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void txt_busqueda__TextChanged(object sender, EventArgs e)
        {
            var filtro = ((OpcionCombo)cbo_filtro.SelectedItem).Valor.ToString();
            if (dgv_modal_proveedores.Rows.Count > 0)
            {
                foreach (DataGridViewRow fila in dgv_modal_proveedores.Rows)
                {
                    fila.Visible = fila.Cells[filtro].Value.ToString().Trim().ToUpper().Contains(txt_busqueda.Texts.Trim().ToUpper());
                }
            }
        }
    }
}
