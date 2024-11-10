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
using EntityLayer.Filtros;
using POSLyion.Resources;

namespace POSLyion
{
    public partial class formUsuarios : Form
    {
        private static Usuarios oUsuario = new Usuarios();
        FiltrosUsuario filtros = new FiltrosUsuario();

        public formUsuarios()
        {
            InitializeComponent();
        }

        private void formUsuariosAlta_Load(object sender, EventArgs e)
        {
            List<Roles> lista_roles = new CN_Roles().Leer();
            cbo_roles.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Todos" });
            foreach (Roles oRol in lista_roles)
            {
                cbo_roles.Items.Add(new OpcionCombo() { Valor = oRol.Id_rol, Texto = oRol.Descripcion });
            }
            cbo_roles.DisplayMember = "Texto";
            cbo_roles.ValueMember = "Valor";
            cbo_roles.SelectedIndex = 0;
            this.MostrarUsuarios();
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
            if (dgv_usuarios.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                if (index >= 0)
                {
                    Usuarios oUsuario = new Usuarios()
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
                    formUsuariosAlta formUsuariosAlta = new formUsuariosAlta(oUsuario);
                    formUsuariosAlta.Show();
                }
            }
            else if (dgv_usuarios.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {
                if (MessageBox.Show("¿Desea eliminar el usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (index >= 0)
                    {
                        string mensaje = string.Empty;
                        Usuarios oUsuario = new Usuarios()
                        {
                            Id_usuario = Convert.ToInt32(dgv_usuarios.Rows[index].Cells["id_usuario"].Value)
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
            dgv_usuarios.Rows.Clear();
            this.MostrarUsuarios();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            filtros = new FiltrosUsuario()
            {
                Nombre_usuario = txt_busqueda.Text,
                Id_rol = Convert.ToInt32(((OpcionCombo)cbo_roles.SelectedItem).Valor),
                Estado = cb_inactivos.Checked ? 0 : 1
            };
            this.MostrarUsuarios();
        }

        private void MostrarUsuarios()
        {
            if(dgv_usuarios.Rows.Count > 0)
            {
                dgv_usuarios.Rows.Clear();
            }
            List<Usuarios> lista_usuarios = new CN_Usuarios().Leer(filtros);
            foreach (Usuarios oUsuario in lista_usuarios)
            {
                dgv_usuarios.Rows.Add(new object[]
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
    }
}
