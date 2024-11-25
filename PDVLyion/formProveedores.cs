using CapaEntidad;
using CapaEntidad.Filtros;
using CapaNegocio;
using System;
using System.Windows.Forms;

namespace POSLyion
{
    public partial class formProveedores : Form
    {
        private static readonly Usuarios oUsuario = new Usuarios();
        private FiltrosProveedor filtros = new FiltrosProveedor();
        private formProveedoresAlta formProveedor;
        public formProveedores()
        {
            InitializeComponent();
        }

        private void formProveedores_Load(object sender, EventArgs e)
        {
            MostrarProveedor();
        }

        private void dataGridView1_Resize(object sender, EventArgs e)
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

        private void btn_crear_proveedor_Click(object sender, EventArgs e)
        {
            var formProveedoresAlta = new formProveedoresAlta();
            formProveedoresAlta.Show();
        }

        private void grid_proveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            if (dgv_proveedores.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                if (index >= 0)
                {
                    var oProveedor = new Proveedores()
                    {
                        Id_proveedor = Convert.ToInt32(dgv_proveedores.Rows[index].Cells["id"].Value),
                        Cuit = dgv_proveedores.Rows[index].Cells["cuit"].Value.ToString(),
                        Descripcion = dgv_proveedores.Rows[index].Cells["descripcion"].Value.ToString(),
                        Correo = dgv_proveedores.Rows[index].Cells["correo"].Value.ToString(),
                        Telefono = dgv_proveedores.Rows[index].Cells["telefono"].Value.ToString(),
                        Estado = Convert.ToBoolean(dgv_proveedores.Rows[index].Cells["estado_valor"].Value)
                    };
                    var formProveedoresAlta = new formProveedoresAlta(oProveedor);
                    formProveedoresAlta.Show();
                }
            }
            else if (dgv_proveedores.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {
                if (MessageBox.Show("¿Desea eliminar el proveedor?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (index >= 0)
                    {
                        var oProveedor = new Proveedores()
                        {
                            Id_proveedor = Convert.ToInt32(dgv_proveedores.Rows[index].Cells["id"].Value)
                        };
                        var resultado = new CN_Proveedores().Eliminar(oProveedor, out var mensaje);
                        _ = !resultado
                            ? MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            : MessageBox.Show("Proveedor eliminado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            MostrarProveedor();
        }

        private void MostrarProveedor()
        {
            if (dgv_proveedores.Rows.Count > 0)
            {
                dgv_proveedores.Rows.Clear();
            }
            var lista_proveedores = new CN_Proveedores().Leer(filtros);
            foreach (var oProveedor in lista_proveedores)
            {
                if (oProveedor.Id_proveedor != 1)
                {
                    _ = dgv_proveedores.Rows.Add(new object[]
                                    {
                    oProveedor.Id_proveedor,
                    oProveedor.Cuit,
                    oProveedor.Descripcion,
                    oProveedor.Correo,
                    oProveedor.Telefono,
                    oProveedor.Estado == true ? "Activo" : "Inactivo",
                    oProveedor.Estado == true ? 1 : 0
                                    });
                }
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            filtros = new FiltrosProveedor()
            {
                Nombre_proveedor = txt_busqueda.Text,
                Estado = cb_inactivo.Checked ? 0 : 1
            };
            MostrarProveedor();
        }

        private void btn_limpiar_filtros_Click(object sender, EventArgs e)
        {
            txt_busqueda.Text = "";
            cb_inactivo.Checked = false;
        }

        private void btn_crear_proveedor_Click_1(object sender, EventArgs e)
        {
            if (formProveedor == null || formProveedor.IsDisposed)
            {
                formProveedor = new formProveedoresAlta();
                formProveedor.Show();
            }
            else
            {
                _ = formProveedor.Focus();
            }
        }

        private void formProveedores_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formProveedor != null && !formProveedor.IsDisposed)
            {
                formProveedor.Close();
            }
        }
    }
}

