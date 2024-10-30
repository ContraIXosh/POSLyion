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

namespace POSLyion
{
    public partial class formProveedores : Form
    {
        private static Usuarios oUsuario = new Usuarios();

        public formProveedores()
        {
            InitializeComponent();
        }

        private void formProveedores_Load(object sender, EventArgs e)
        {
            List<Proveedores> lista_proveedores = new CN_Proveedores().LeerTodo();
            foreach (Proveedores oProveedor in lista_proveedores)
            {
                grid_proveedores.Rows.Add(new object[]
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
            if (grid_proveedores.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                if (index >= 0)
                {
                    Proveedores oProveedor = new Proveedores()
                    {
                        Id_proveedor = Convert.ToInt32(grid_proveedores.Rows[index].Cells["id"].Value),
                        Cuit = grid_proveedores.Rows[index].Cells["cuit"].Value.ToString(),
                        Descripcion = grid_proveedores.Rows[index].Cells["descripcion"].Value.ToString(),
                        Correo = grid_proveedores.Rows[index].Cells["correo"].Value.ToString(),
                        Telefono = grid_proveedores.Rows[index].Cells["telefono"].Value.ToString(),
                        Estado = Convert.ToBoolean(grid_proveedores.Rows[index].Cells["estado_valor"].Value)
                    };
                    formProveedoresAlta formProveedoresAlta = new formProveedoresAlta(oProveedor);
                    formProveedoresAlta.Show();
                }
            }
            else if (grid_proveedores.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {
                if (MessageBox.Show("¿Desea eliminar el proveedor?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (index >= 0)
                    {
                        string mensaje = string.Empty;
                        Proveedores oProveedor = new Proveedores()
                        {
                            Id_proveedor = Convert.ToInt32(grid_proveedores.Rows[index].Cells["id"].Value)
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
            grid_proveedores.Rows.Clear();
            List<Proveedores> lista_proveedores = new CN_Proveedores().LeerTodo();
            foreach (Proveedores oProveedor in lista_proveedores)
            {
                grid_proveedores.Rows.Add(new object[]
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
}
   
