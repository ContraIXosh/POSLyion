using CapaEntidad;
using CapaEntidad.Filtros;
using CapaNegocio;
using System;
using System.Windows.Forms;

namespace POSLyion
{
    public partial class formClientes : Form
    {
        private static readonly Usuarios oUsuario = new Usuarios();
        private FiltrosCliente filtros = new FiltrosCliente();
        private formClientesAlta formClienteAlta;
        public formClientes()
        {
            InitializeComponent();
        }

        private void formClientes_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void panel_footer_Resize_1(object sender, EventArgs e)
        {
            if (ClientSize.Width > 1000 && ClientSize.Height > 700)
            {
                AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            }
            else
            {
                AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            }
        }

        private void grid_proveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            if (dgv_clientes.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                if (index >= 0)
                {
                    var oCliente = new Clientes()
                    {
                        Id_cliente = Convert.ToInt32(dgv_clientes.Rows[index].Cells["id"].Value),
                        Dni = dgv_clientes.Rows[index].Cells["dni"].Value.ToString(),
                        Nombre_completo = dgv_clientes.Rows[index].Cells["nombre_completo"].Value.ToString(),
                        Correo = dgv_clientes.Rows[index].Cells["correo"].Value.ToString(),
                        Telefono = dgv_clientes.Rows[index].Cells["telefono"].Value.ToString(),
                        Estado = Convert.ToBoolean(dgv_clientes.Rows[index].Cells["estado_valor"].Value)
                    };
                    var formClientesAlta = new formClientesAlta(oCliente);
                    formClientesAlta.Show();
                }
            }
            else if (dgv_clientes.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {
                if (MessageBox.Show("¿Desea eliminar el cliente?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (index >= 0)
                    {
                        var oCliente = new Clientes()
                        {
                            Id_cliente = Convert.ToInt32(dgv_clientes.Rows[index].Cells["id"].Value)
                        };
                        var resultado = new CN_Clientes().Eliminar(oCliente, out var mensaje);
                        _ = !resultado
                            ? MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            : MessageBox.Show("Cliente eliminado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void btn_crear_cliente_Click(object sender, EventArgs e)
        {
            var formClientesAlta = new formClientesAlta();
            formClientesAlta.Show();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void MostrarClientes()
        {
            if (dgv_clientes.Rows.Count > 0)
            {
                dgv_clientes.Rows.Clear();
            }
            var lista_clientes = new CN_Clientes().Leer(filtros);
            foreach (var oCliente in lista_clientes)
            {
                _ = dgv_clientes.Rows.Add(new object[]
                {
                    oCliente.Id_cliente,
                    oCliente.Dni,
                    oCliente.Nombre_completo,
                    oCliente.Telefono,
                    oCliente.Correo,
                    oCliente.Estado == true ? "Activo" : "Inactivo",
                    oCliente.Estado == true ? 1 : 0,
                    oCliente.Descuento
                });
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            filtros = new FiltrosCliente()
            {
                Nombre_cliente = txt_busqueda.Text,
                Estado = cb_inactivo.Checked ? 0 : 1
            };
            MostrarClientes();
        }

        private void btn_limpiar_filtros_Click(object sender, EventArgs e)
        {
            txt_busqueda.Text = "";
            cb_inactivo.Checked = false;
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            if (formClienteAlta == null || formClienteAlta.IsDisposed)
            {
                formClienteAlta = new formClientesAlta();
                formClienteAlta.Show();
            }
            else
            {
                _ = formClienteAlta.Focus();
            }
        }

        private void formClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formClienteAlta != null && !formClienteAlta.IsDisposed)
            {
                formClienteAlta.Close();
            }
        }
    }
}
