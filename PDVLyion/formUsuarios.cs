using CapaEntidad;
using CapaNegocio;
using EntityLayer.Filtros;
using POSLyion.Resources;
using System;
using System.Windows.Forms;

namespace POSLyion
{
    public partial class formUsuarios : Form
    {
        private static readonly Usuarios oUsuario = new Usuarios();
        private FiltrosUsuario filtros = new FiltrosUsuario();
        private formUsuariosAlta formUsuario;
        public formUsuarios()
        {
            InitializeComponent();
        }

        private void formUsuariosAlta_Load(object sender, EventArgs e)
        {
            var lista_roles = new CN_Roles().Leer();
            _ = cbo_roles.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Todos" });
            foreach (var oRol in lista_roles)
            {
                _ = cbo_roles.Items.Add(new OpcionCombo() { Valor = oRol.Id_rol, Texto = oRol.Descripcion });
            }
            cbo_roles.DisplayMember = "Texto";
            cbo_roles.ValueMember = "Valor";
            cbo_roles.SelectedIndex = 0;
            MostrarUsuarios();
        }

        private void formUsuarios_Resize(object sender, EventArgs e)
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

        private void grid_usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            if (dgv_usuarios.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                if (index >= 0)
                {
                    var oUsuario = new Usuarios()
                    {
                        Id_usuario = Convert.ToInt32(dgv_usuarios.Rows[index].Cells["id_usuario"].Value),
                        Dni = dgv_usuarios.Rows[index].Cells["dni"].Value.ToString(),
                        Nombre_completo = dgv_usuarios.Rows[index].Cells["nombre_completo"].Value.ToString(),
                        Correo = dgv_usuarios.Rows[index].Cells["correo"].Value.ToString(),
                        Nombre_usuario = dgv_usuarios.Rows[index].Cells["nombre_usuario"].Value.ToString(),
                        Clave = dgv_usuarios.Rows[index].Cells["clave"].Value.ToString(),
                        oRol = new Roles()
                        {
                            Id_rol = Convert.ToInt32(dgv_usuarios.Rows[index].Cells["id_rol"].Value),
                            Descripcion = dgv_usuarios.Rows[index].Cells["descripcion_rol"].Value.ToString()
                        },
                        Telefono = dgv_usuarios.Rows[index].Cells["telefono"].Value.ToString(),
                        Estado = Convert.ToBoolean(dgv_usuarios.Rows[index].Cells["estado_valor"].Value)
                    };
                    var formUsuariosAlta = new formUsuariosAlta(oUsuario);
                    formUsuariosAlta.Show();
                }
            }
            else if (dgv_usuarios.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {
                if (MessageBox.Show("¿Desea eliminar el usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (index >= 0)
                    {
                        var oUsuario = new Usuarios()
                        {
                            Id_usuario = Convert.ToInt32(dgv_usuarios.Rows[index].Cells["id_usuario"].Value)
                        };
                        var result = new CN_Usuarios().Eliminar(oUsuario, out var mensaje);
                        _ = !result
                            ? MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            : MessageBox.Show("Usuario eliminado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            dgv_usuarios.Rows.Clear();
            MostrarUsuarios();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            filtros = new FiltrosUsuario()
            {
                Nombre_usuario = txt_busqueda.Text,
                Id_rol = Convert.ToInt32(((OpcionCombo)cbo_roles.SelectedItem).Valor),
                Estado = cb_inactivos.Checked ? 0 : 1
            };
            MostrarUsuarios();
        }

        private void MostrarUsuarios()
        {
            if (dgv_usuarios.Rows.Count > 0)
            {
                dgv_usuarios.Rows.Clear();
            }
            var lista_usuarios = new CN_Usuarios().Leer(filtros);
            foreach (var oUsuario in lista_usuarios)
            {
                _ = dgv_usuarios.Rows.Add(new object[]
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

        private void btn_limpiar_filtros_Click(object sender, EventArgs e)
        {
            txt_busqueda.Text = "";
            cbo_roles.SelectedIndex = 0;
            cb_inactivos.Checked = false;
        }

        private void btn_crear_usuario_Click_1(object sender, EventArgs e)
        {
            if (formUsuario == null || formUsuario.IsDisposed)
            {
                formUsuario = new formUsuariosAlta();
                formUsuario.Show();
            }
        }
    }
}
