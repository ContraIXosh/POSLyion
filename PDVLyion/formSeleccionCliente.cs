using CapaEntidad;
using CapaEntidad.Filtros;
using CapaNegocio;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace POSLyion
{
    public partial class formSeleccionCliente : Form
    {

        public Clientes Cliente = new Clientes();
        public bool Cliente_seleccionado = false;

        public formSeleccionCliente()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void formDescuento_Load(object sender, EventArgs e)
        {
            var filtros = new FiltrosCliente();
            var lista_clientes = new CN_Clientes().Leer(filtros).Where(c => c.Nombre_completo.ToLower().Contains(txt_busqueda.Text)).ToList();
            foreach (var cliente in lista_clientes)
            {
                _ = dgv_clientes.Rows.Add(new object[]
                {
                        cliente.Id_cliente,
                        cliente.Dni,
                        cliente.Nombre_completo,
                        cliente.Telefono,
                        cliente.Descuento
                });
            }
        }

        private void txt_busqueda_TextChanged(object sender, EventArgs e)
        {
            txt_busqueda.Select();
            dgv_clientes.Rows.Clear();
            if (txt_busqueda.Text.ToLower() != "")
            {
                var filtros = new FiltrosCliente();
                var lista_clientes = new CN_Clientes().Leer(filtros).Where(c => c.Nombre_completo.ToLower().Contains(txt_busqueda.Text)).ToList();
                foreach (var cliente in lista_clientes)
                {
                    _ = dgv_clientes.Rows.Add(new object[]
                    {
                        cliente.Id_cliente,
                        cliente.Dni,
                        cliente.Nombre_completo,
                        cliente.Telefono,
                        cliente.Descuento
                    });
                }
            }
            else
            {
                formDescuento_Load(sender, e);
            }
            txt_busqueda.Select();
        }

        private void dgv_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Cliente.Id_cliente = Convert.ToInt32(dgv_clientes.Rows[e.RowIndex].Cells["id"].Value.ToString());
                Cliente.Dni = dgv_clientes.Rows[e.RowIndex].Cells["dni"].Value.ToString();
                Cliente.Nombre_completo = dgv_clientes.Rows[e.RowIndex].Cells["nombre_completo"].Value.ToString();
                Cliente.Telefono = dgv_clientes.Rows[e.RowIndex].Cells["telefono"].Value.ToString();
                Cliente.Descuento = Convert.ToInt32(dgv_clientes.Rows[e.RowIndex].Cells["descuento"].Value);
                Cliente_seleccionado = true;
                Close();
            }
        }

        private void formDescuento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
