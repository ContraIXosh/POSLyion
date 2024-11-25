using CapaEntidad;
using CapaEntidad.Filtros;
using CapaNegocio;
using POSLyion.Resources;
using System;
using System.Windows.Forms;

namespace POSLyion.Modals
{
    public partial class MD_Clientes : Form
    {

        public Clientes oCliente { get; set; }

        public MD_Clientes()
        {
            InitializeComponent();
        }

        private void MD_Clientes_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgv_modal_clientes.Columns)
            {
                if (columna.Visible == true)
                {
                    _ = cbo_filtro.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }

            cbo_filtro.DisplayMember = "Texto";
            cbo_filtro.ValueMember = "Valor";
            cbo_filtro.SelectedIndex = 0;

            var filtros = new FiltrosCliente();
            var lista_clientes = new CN_Clientes().Leer(filtros);

            foreach (var cliente in lista_clientes)
            {
                if (cliente.Estado)
                {
                    _ = dgv_modal_clientes.Rows.Add(new object[] { cliente.Dni, cliente.Nombre_completo });
                }
            }
        }

        private void dgv_modal_clientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var indice_fila = e.RowIndex;
            var indice_columna = e.ColumnIndex;
            if (indice_fila >= 0 && indice_columna >= 0)
            {
                oCliente = new Clientes()
                {
                    Dni = dgv_modal_clientes.Rows[indice_fila].Cells["dni"].Value.ToString(),
                    Nombre_completo = dgv_modal_clientes.Rows[indice_fila].Cells["nombre_completo"].Value.ToString()
                };
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            var filtro = ((OpcionCombo)cbo_filtro.SelectedItem).Valor.ToString();
            if (dgv_modal_clientes.Rows.Count > 0)
            {
                foreach (DataGridViewRow fila in dgv_modal_clientes.Rows)
                {
                    fila.Visible = fila.Cells[filtro].Value.ToString().Trim().ToUpper().Contains(txt_busqueda.Texts.Trim().ToUpper());
                }
            }
        }
    }
}
