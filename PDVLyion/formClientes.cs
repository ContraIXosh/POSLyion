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
    public partial class formClientes : Form
    {
        private static Usuarios oUsuario = new Usuarios();

        public formClientes()
        {
            InitializeComponent();
        }

        private void formClientes_Load(object sender, EventArgs e)
        {
            List<Clientes> lista_clientes = new CN_Clientes().Leer();
            foreach (Clientes oCliente in lista_clientes)
            {
                grid_clientes.Rows.Add(new object[]
                {
                    oCliente.Id_cliente,
                    oCliente.Dni,
                    oCliente.Nombre_completo,
                    oCliente.Telefono,
                    oCliente.Correo,
                    oCliente.Estado == true ? "Activo" : "Inactivo",
                    oCliente.Estado == true ? 1 : 0
                });
            }
        }

        private void panel_footer_Resize_1(object sender, EventArgs e)
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

        private void grid_proveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (grid_clientes.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                if (index >= 0)
                {
                    Clientes oCliente = new Clientes()
                    {
                        Id_cliente = Convert.ToInt32(grid_clientes.Rows[index].Cells["id"].Value),
                        Dni = grid_clientes.Rows[index].Cells["dni"].Value.ToString(),
                        Nombre_completo = grid_clientes.Rows[index].Cells["nombre_completo"].Value.ToString(),
                        Correo = grid_clientes.Rows[index].Cells["correo"].Value.ToString(),
                        Telefono = grid_clientes.Rows[index].Cells["telefono"].Value.ToString(),
                        Estado = Convert.ToBoolean(grid_clientes.Rows[index].Cells["estado_valor"].Value)
                    };
                    formClientesAlta formClientesAlta = new formClientesAlta(oCliente);
                    formClientesAlta.Show();
                }
            }
            else if (grid_clientes.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {
                if (MessageBox.Show("¿Desea eliminar el cliente?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (index >= 0)
                    {
                        string mensaje = string.Empty;
                        Clientes oCliente = new Clientes()
                        {
                            Id_cliente = Convert.ToInt32(grid_clientes.Rows[index].Cells["id"].Value)
                        };
                        bool resultado = new CN_Clientes().Eliminar(oCliente, out mensaje);
                        if (!resultado)
                        {
                            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("Cliente eliminado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                    }
                }
            }
        }

        private void btn_crear_cliente_Click(object sender, EventArgs e)
        {
            formClientesAlta formClientesAlta = new formClientesAlta();
            formClientesAlta.Show();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            grid_clientes.Rows.Clear();
            List<Clientes> lista_clientes = new CN_Clientes().Leer();
            foreach (Clientes oCliente in lista_clientes)
            {
                grid_clientes.Rows.Add(new object[]
                {
                    oCliente.Id_cliente,
                    oCliente.Dni,
                    oCliente.Nombre_completo,
                    oCliente.Telefono,
                    oCliente.Correo,
                    oCliente.Estado == true ? "Activo" : "Inactivo",
                    oCliente.Estado == true ? 1 : 0
                });
            }
        }
    }
}
