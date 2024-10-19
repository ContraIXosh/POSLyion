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
using CapaEntidad;
using CapaNegocio;

namespace POSLyion
{
    public partial class formUsuarios : Form
    {
        private static Usuarios oUsuario = new Usuarios();

        public formUsuarios()
        {
            InitializeComponent();
        }

        private void formUsuariosAlta_Load(object sender, EventArgs e)
        {
            List<Usuarios> lista_usuarios = new CN_Usuarios().Leer();
            foreach (Usuarios oUsuario in lista_usuarios)
            {
                grid_usuarios.Rows.Add(new object[]
                {
                    "",
                    oUsuario.Id_usuario,
                    oUsuario.Dni,
                    oUsuario.Nombre_completo,
                    oUsuario.Correo,
                    oUsuario.Nombre_usuario,
                    oUsuario.Clave,
                    oUsuario.oRol.Id_rol,
                    oUsuario.oRol.Descripcion,
                    oUsuario.Telefono,
                    oUsuario.Estado == true ? "Activo" : "Inactivo",
                    oUsuario.Estado == true ? 1 : 0
                });
            }
        }

        private void formUsuarios_Resize(object sender, EventArgs e)
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

        private void grid_usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (grid_usuarios.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                if (index >= 0)
                {
                    Usuarios oUsuario = new Usuarios()
                    {
                        Id_usuario = Convert.ToInt32(grid_usuarios.Rows[index].Cells["id_usuario"].Value),
                        Dni = grid_usuarios.Rows[index].Cells["dni"].Value.ToString(),
                        Nombre_completo = grid_usuarios.Rows[index].Cells["nombre_completo"].Value.ToString(),
                        Correo = grid_usuarios.Rows[index].Cells["correo"].Value.ToString(),
                        Nombre_usuario = grid_usuarios.Rows[index].Cells["nombre_usuario"].Value.ToString(),
                        Clave = grid_usuarios.Rows[index].Cells["clave"].Value.ToString(),
                        oRol = new Roles()
                        {
                            Id_rol = Convert.ToInt32(grid_usuarios.Rows[index].Cells["id_rol"].Value),
                            Descripcion = grid_usuarios.Rows[index].Cells["descripcion_rol"].Value.ToString()
                        },
                        Telefono = grid_usuarios.Rows[index].Cells["telefono"].Value.ToString(),
                        Estado = Convert.ToBoolean(grid_usuarios.Rows[index].Cells["estado_valor"].Value)
                    };
                    formUsuariosAlta formUsuariosAlta = new formUsuariosAlta(oUsuario);
                    formUsuariosAlta.Show();
                }
            }
            else if (grid_usuarios.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {
                if (MessageBox.Show("¿Desea eliminar el usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (index >= 0)
                    {
                        string mensaje = string.Empty;
                        Usuarios oUsuario = new Usuarios()
                        {
                            Id_usuario = Convert.ToInt32(grid_usuarios.Rows[index].Cells["id_usuario"].Value)
                        };
                        bool result = new CN_Usuarios().Eliminar(oUsuario, out mensaje);
                        if (!result)
                        {
                            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("Usuario eliminado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
        }

        private void btn_crear_usuario_Click(object sender, EventArgs e)
        {
            formUsuariosAlta formUsuariosAlta = new formUsuariosAlta();
            formUsuariosAlta.Show();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            grid_usuarios.Rows.Clear();
            List<Usuarios> lista_usuarios = new CN_Usuarios().Leer();
            foreach (Usuarios oUsuario in lista_usuarios)
            {
                grid_usuarios.Rows.Add(new object[]
                {
                    "",
                    oUsuario.Id_usuario,
                    oUsuario.Dni,
                    oUsuario.Nombre_completo,
                    oUsuario.Correo,
                    oUsuario.Nombre_usuario,
                    oUsuario.Clave,
                    oUsuario.oRol.Id_rol,
                    oUsuario.oRol.Descripcion,
                    oUsuario.Telefono,
                    oUsuario.Estado == true ? "Activo" : "Inactivo",
                    oUsuario.Estado == true ? 1 : 0
                });
            }
        }
    }
}
