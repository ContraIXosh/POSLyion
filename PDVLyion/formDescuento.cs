using CapaEntidad;
using CapaEntidad.Filtros;
using CapaNegocio;
using DocumentFormat.OpenXml.Spreadsheet;
using POSLyion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDCLyion
{
    public partial class formDescuento : Form
    {

        public Clientes Cliente = new Clientes();
        public bool Cliente_seleccionado = false;

        public formDescuento()
        {
            InitializeComponent();
        }

        private void formDescuento_Load(object sender, EventArgs e)
        {
            FiltrosCliente filtros = new FiltrosCliente();
            List<Clientes> lista_clientes = new CN_Clientes().Leer(filtros).Where(c => c.Nombre_completo.ToLower().Contains(txt_busqueda.Text)).ToList();
            foreach (Clientes cliente in lista_clientes)
            {
                dgv_clientes.Rows.Add(new object[]
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
                FiltrosCliente filtros = new FiltrosCliente();
                List<Clientes> lista_clientes = new CN_Clientes().Leer(filtros).Where(c => c.Nombre_completo.ToLower().Contains(txt_busqueda.Text)).ToList();
                foreach (Clientes cliente in lista_clientes)
                {
                    dgv_clientes.Rows.Add(new object[]
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
                this.formDescuento_Load(sender, e);
            }
            txt_busqueda.Select();
        }

        private void dgv_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                Cliente.Id_cliente = Convert.ToInt32(dgv_clientes.Rows[e.RowIndex].Cells["id"].Value.ToString());
                Cliente.Dni = dgv_clientes.Rows[e.RowIndex].Cells["dni"].Value.ToString();
                Cliente.Nombre_completo = dgv_clientes.Rows[e.RowIndex].Cells["nombre_completo"].Value.ToString();
                Cliente.Telefono = dgv_clientes.Rows[e.RowIndex].Cells["telefono"].Value.ToString();
                Cliente.Descuento = Convert.ToInt32(dgv_clientes.Rows[e.RowIndex].Cells["descuento"].Value);
                Cliente_seleccionado = true;
                this.Close();
            }
        }
    }
}
