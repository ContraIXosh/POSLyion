using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaEntidad.Filtros;

namespace POSLyion
{
    public partial class formProveedores : Form
    {
        private static Usuarios oUsuario = new Usuarios();
        private FiltrosProveedor filtros = new FiltrosProveedor();

        public formProveedores()
        {
            InitializeComponent();
        }

        private void formProveedores_Load(object sender, EventArgs e)
        {
            this.MostrarProveedor();
        }

        private void dataGridView1_Resize(object sender, EventArgs e)
        {
            if (this.ClientSize.Width > 1000 && this.ClientSize.Height > 700)
            {
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            }
            else
            {
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            }
        }

        private void btn_crear_proveedor_Click(object sender, EventArgs e)
        {
            formProveedoresAlta formProveedoresAlta = new formProveedoresAlta();
            formProveedoresAlta.Show();
        }

        private void grid_proveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (dgv_proveedores.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                if (index >= 0)
                {
                    Proveedores oProveedor = new Proveedores()
                    {
                        Id_proveedor = Convert.ToInt32(dgv_proveedores.Rows[index].Cells["id"].Value),
                        Cuit = dgv_proveedores.Rows[index].Cells["cuit"].Value.ToString(),
                        Descripcion = dgv_proveedores.Rows[index].Cells["descripcion"].Value.ToString(),
                        Correo = dgv_proveedores.Rows[index].Cells["correo"].Value.ToString(),
                        Telefono = dgv_proveedores.Rows[index].Cells["telefono"].Value.ToString(),
                        Estado = Convert.ToBoolean(dgv_proveedores.Rows[index].Cells["estado_valor"].Value)
                    };
                    formProveedoresAlta formProveedoresAlta = new formProveedoresAlta(oProveedor);
                    formProveedoresAlta.Show();
                }
            }
            else if (dgv_proveedores.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {
                if (MessageBox.Show("¿Desea eliminar el proveedor?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (index >= 0)
                    {
                        string mensaje = string.Empty;
                        Proveedores oProveedor = new Proveedores()
                        {
                            Id_proveedor = Convert.ToInt32(dgv_proveedores.Rows[index].Cells["id"].Value)
                        };
                        bool resultado = new CN_Proveedores().Eliminar(oProveedor, out mensaje);
                        if (!resultado)
                        {
                            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("Proveedor eliminado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                    }
                }
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            this.MostrarProveedor();
        }

        private void MostrarProveedor()
        {
            if(dgv_proveedores.Rows.Count > 0)
            {
                dgv_proveedores.Rows.Clear();
            }
            List<Proveedores> lista_proveedores = new CN_Proveedores().Leer(filtros);
            foreach (Proveedores oProveedor in lista_proveedores)
            {
                dgv_proveedores.Rows.Add(new object[]
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

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            filtros = new FiltrosProveedor()
            {
                Nombre_proveedor = txt_busqueda.Text,
                Estado = cb_inactivo.Checked ? 0 : 1
            };
            this.MostrarProveedor();
        }

        private void btn_limpiar_filtros_Click(object sender, EventArgs e)
        {
            txt_busqueda.Text = "";
            cb_inactivo.Checked = false;
        }

        private void btn_crear_proveedor_Click_1(object sender, EventArgs e)
        {
            formProveedoresAlta formalta = new formProveedoresAlta();
            formalta.Show();
        }
    }
}
   
