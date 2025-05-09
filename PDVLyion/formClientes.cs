﻿using CapaEntidad;
using CapaEntidad.Filtros;
using CapaNegocio;
using POSLyion.Modals;
using System;
using System.Windows.Forms;

namespace POSLyion
{
    public partial class formClientes : Form
    {
        private static readonly Usuarios _oUsuario = new Usuarios();
        private FiltrosCliente _filtros = new FiltrosCliente();
        private readonly formClientesAlta _formClienteAlta;
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

        private void dgv_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var indiceCliente = e.RowIndex;
            if (dgv_clientes.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                if (indiceCliente >= 0)
                {
                    using (var formClientesAlta = new formClientesAlta(GenerarCliente(indiceCliente)))
                    {
                        _ = formClientesAlta.ShowDialog();
                    }
                    MostrarClientes();
                }
            }
            else if (dgv_clientes.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {
                if (MessageBox.Show("¿Desea eliminar el cliente?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (indiceCliente >= 0)
                    {
                        var oCliente = new Clientes()
                        {
                            Id_cliente = Convert.ToInt32(dgv_clientes.Rows[indiceCliente].Cells["id"].Value)
                        };
                        var resultado = new CN_Clientes().Eliminar(oCliente, out var mensaje);
                        _ = !resultado
                            ? MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            : MessageBox.Show("Cliente eliminado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                MostrarClientes();
            }
        }

        private Clientes GenerarCliente(int indiceCliente)
        {
            var oCliente = new Clientes()
            {
                Id_cliente = Convert.ToInt32(dgv_clientes.Rows[indiceCliente].Cells["id"].Value),
                Dni = dgv_clientes.Rows[indiceCliente].Cells["dni"].Value.ToString(),
                Nombre_completo = dgv_clientes.Rows[indiceCliente].Cells["nombre_completo"].Value.ToString(),
                Correo = dgv_clientes.Rows[indiceCliente].Cells["correo"].Value.ToString(),
                Telefono = dgv_clientes.Rows[indiceCliente].Cells["telefono"].Value.ToString(),
                Estado = Convert.ToBoolean(dgv_clientes.Rows[indiceCliente].Cells["estado_valor"].Value),
                Descuento = Convert.ToInt32(dgv_clientes.Rows[indiceCliente].Cells["descuento"].Value)
            };
            return oCliente;
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
            var lista_clientes = new CN_Clientes().Leer(_filtros);
            foreach (var oCliente in lista_clientes)
            {
                if (oCliente.Id_cliente != 1)
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
            if (dgv_clientes.Rows.Count > 0)
            {
                btn_ventas_credito.Visible = true;
                btn_ventas_credito.Text = $"Cuenta de: {dgv_clientes.CurrentRow.Cells["nombre_completo"].Value}";
            }
            else
            {
                btn_ventas_credito.Visible = false;
            }

        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            using (var formClienteAlta = new formClientesAlta())
            {
                _ = formClienteAlta.ShowDialog();
            }
            MostrarClientes();
        }

        private void formClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_formClienteAlta != null && !_formClienteAlta.IsDisposed)
            {
                _formClienteAlta.Close();
            }
        }

        private void CargarFiltros()
        {
            _filtros = new FiltrosCliente()
            {
                Nombre_cliente = txt_busqueda.Text,
                Estado = cb_inactivo.Checked ? 0 : 1
            };
        }

        private void txt_busqueda_TextChanged(object sender, EventArgs e)
        {
            CargarFiltros();
            MostrarClientes();
        }

        private void cb_inactivo_Click(object sender, EventArgs e)
        {
            CargarFiltros();
            MostrarClientes();
        }

        private void btn_limpiar_filtros_Click(object sender, EventArgs e)
        {
            txt_busqueda.Text = "";
            cb_inactivo.Checked = false;
            _filtros = new FiltrosCliente();
            MostrarClientes();
        }

        private void dgv_clientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_clientes.Rows.Count > 0)
            {
                if (dgv_clientes.SelectedRows.Count > 0)
                {
                    var filaSeleccionada = dgv_clientes.SelectedRows[0];
                    var nombreCliente = filaSeleccionada.Cells["nombre_completo"].Value.ToString();
                    btn_ventas_credito.Text = $"Cuenta de {nombreCliente}";
                }
            }
        }

        private void btn_ventas_credito_Click(object sender, EventArgs e)
        {
            var idCliente = Convert.ToInt32(dgv_clientes.CurrentRow.Cells["id"].Value);
            var nombreCliente = dgv_clientes.CurrentRow.Cells["nombre_completo"].Value.ToString();
            using (var modalClientes = new MD_Clientes(idCliente, nombreCliente))
            {
                _ = modalClientes.ShowDialog();
            }
        }
    }
}
