using CapaEntidad;
using CapaEntidad.Filtros;
using CapaNegocio;
using System;
using System.Windows.Forms;

namespace POSLyion
{
    public partial class formProveedores : Form
    {
        private FiltrosProveedor _filtros = new FiltrosProveedor();

        public formProveedores()
        {
            InitializeComponent();
        }

        private void formProveedores_Load(object sender, EventArgs e)
        {
            CargarManejadoresEventos();
            MostrarProveedor();
        }

        private void CargarManejadoresEventos()
        {
            txt_busqueda.TextChanged += new EventHandler(Buscar);
            cb_inactivo.Click += new EventHandler(Buscar);
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
            using (var formProveedoresAlta = new formProveedoresAlta())
            {
                _ = formProveedoresAlta.ShowDialog();
            }
            MostrarProveedor();
        }

        private void dgv_proveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var indiceProveedor = e.RowIndex;
            if (dgv_proveedores.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                if (indiceProveedor >= 0)
                {
                    using (var formProveedoresAlta = new formProveedoresAlta(GenerarProveedor(indiceProveedor)))
                    {
                        _ = formProveedoresAlta.ShowDialog();
                    }
                }
                MostrarProveedor();
            }
            else if (dgv_proveedores.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {
                if (MessageBox.Show("¿Desea eliminar el proveedor?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (indiceProveedor >= 0)
                    {
                        var oProveedor = new Proveedores()
                        {
                            Id_proveedor = Convert.ToInt32(dgv_proveedores.Rows[indiceProveedor].Cells["id"].Value)
                        };

                        if (new CN_Proveedores().Eliminar(oProveedor, out var mensaje))
                        {
                            _ = MessageBox.Show("Proveedor eliminado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Close();
                        }
                        else
                        {
                            _ = MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
        }

        private Proveedores GenerarProveedor(int indiceProveedor)
        {
            var oProveedor = new Proveedores()
            {
                Id_proveedor = Convert.ToInt32(dgv_proveedores.Rows[indiceProveedor].Cells["id"].Value),
                Cuit = dgv_proveedores.Rows[indiceProveedor].Cells["cuit"].Value.ToString(),
                Descripcion = dgv_proveedores.Rows[indiceProveedor].Cells["descripcion"].Value.ToString(),
                Correo = dgv_proveedores.Rows[indiceProveedor].Cells["correo"].Value.ToString(),
                Telefono = dgv_proveedores.Rows[indiceProveedor].Cells["telefono"].Value.ToString(),
                Estado = Convert.ToBoolean(dgv_proveedores.Rows[indiceProveedor].Cells["estado_valor"].Value)
            };
            return oProveedor;
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
            var lista_proveedores = new CN_Proveedores().Leer(_filtros);
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

        private void Buscar(object sender, EventArgs e)
        {
            CargarFiltros();
            MostrarProveedor();
        }

        private void CargarFiltros()
        {
            _filtros = new FiltrosProveedor()
            {
                Nombre_proveedor = txt_busqueda.Text,
                Estado = cb_inactivo.Checked ? 0 : 1
            };
        }

        private void btn_limpiar_filtros_Click(object sender, EventArgs e)
        {
            txt_busqueda.Text = "";
            cb_inactivo.Checked = false;
            _filtros = new FiltrosProveedor();
            MostrarProveedor();
        }
    }
}

