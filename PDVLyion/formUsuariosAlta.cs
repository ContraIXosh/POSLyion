using POSLyion.Resources;
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
using System.Web.UI.WebControls;

namespace POSLyion
{
    public partial class formUsuariosAlta : Form
    {
        private Usuarios Usuario;
        private Usuarios Anterior_usuario;
        private static Usuarios oUsuario = new Usuarios();

        public formUsuariosAlta()
        {
            InitializeComponent();
            Usuario = new Usuarios();
        }

        public formUsuariosAlta(Usuarios oUsuario)
        {
            InitializeComponent();
            Usuario = oUsuario;
        }

        private void formUsuariosAlta_Load(object sender, EventArgs e)
        {
            if (Usuario.Id_usuario == 0)
            {
                btn_editar_permisos.Visible = false;
            }
            List<Roles> lista_roles = new CN_Roles().Leer();
            foreach (Roles oRol in lista_roles)
            {
                cbo_rol.Items.Add(new OpcionCombo() { Value = oRol.Id_rol, Text = oRol.Descripcion });
            }
            cbo_rol.DisplayMember = "Text";
            cbo_rol.ValueMember = "Value";

            cbo_estado.Items.Add(new OpcionCombo() { Value = 1, Text = "Activo" });
            cbo_estado.Items.Add(new OpcionCombo() { Value = 0, Text = "Inactivo" });
            cbo_estado.DisplayMember = "Text";
            cbo_estado.ValueMember = "Value";

            txt_id.Texts = Usuario.Id_usuario.ToString();
            txt_nombre_completo.Texts = Usuario.Nombre_completo;
            txt_correo.Texts = Usuario.Correo;
            txt_dni.Texts = Usuario.Dni;
            txt_nombre_usuario.Texts = Usuario.Nombre_usuario;
            txt_telefono.Texts = Usuario.Telefono;
            txt_clave.Texts = Usuario.Clave;
            int cbo_rol_index = 0;
            int cbo_estado_index = 0;

            if (Convert.ToInt32(txt_id.Texts) == 0)
            {
                cbo_estado.SelectedIndex = 0;
                cbo_rol.SelectedIndex = 0;
            }
            else
            {
                foreach (OpcionCombo opcion_estado in cbo_estado.Items)
                {
                    if (Convert.ToInt32(opcion_estado.Value) == (Usuario.Estado == true ? 1 : 0))
                    {
                        cbo_estado_index = cbo_estado.Items.IndexOf(opcion_estado);
                        break;
                    }
                }
                cbo_estado.SelectedIndex = cbo_estado_index;

                foreach (OpcionCombo opcion_rol in cbo_rol.Items)
                {
                    if (Convert.ToInt32(opcion_rol.Value) == Usuario.oRol.Id_rol)
                    {
                        cbo_rol_index = cbo_rol.Items.IndexOf(opcion_rol);
                        break;
                    }
                }
                cbo_rol.SelectedIndex = cbo_rol_index;
            }
        }

        private void panel1_Resize(object sender, EventArgs e)
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

        private void panel_useradd_Resize(object sender, EventArgs e)
        {
            if (this.ClientSize.Width > 1000 && this.ClientSize.Height > 700)
            {
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                btn_cerrar.Width = 150;
                btn_cerrar.Left = this.ClientSize.Width - btn_cerrar.Width;
            }
            else
            {
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                btn_cerrar.Left = this.ClientSize.Width - btn_cerrar.Width;
            }
        }

        //private void btn_deshacer_Click(object sender, EventArgs e)
        //{
        //    if (Convert.ToInt32(txt_id.Texts) != 0)
        //    {
        //        formUsuariosAdd frmuseradd = new formUsuariosAdd(Anterior_usuario);
        //        this.Close();
        //        frmuseradd.Show();
        //    }
        //    else
        //    {
        //        txt_dni.Texts = "";
        //        txt_correo.Texts = "";
        //        txt_nombre_completo.Texts = "";
        //        txt_pass.Texts = "";
        //        txt_tel.Texts = "";
        //        txt_username.Texts = "";
        //        cbo_estado.SelectedIndex = 0;
        //        cbo_rol.SelectedIndex = 0;
        //    }
        //}

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            if (Convert.ToInt32(txt_id.Texts) == 0)
            {
                Usuario = new Usuarios()
                {
                    Dni = txt_dni.Texts,
                    Nombre_completo = txt_nombre_completo.Texts,
                    Correo = txt_correo.Texts,
                    Nombre_usuario = txt_nombre_usuario.Texts,
                    Clave = txt_clave.Texts,
                    oRol = new Roles()
                    {
                        Id_rol = Convert.ToInt32(((OpcionCombo)cbo_rol.SelectedItem).Value),
                    },
                    Telefono = txt_telefono.Texts,
                    Estado = Convert.ToInt32(((OpcionCombo)cbo_estado.SelectedItem).Value) == 1 ? true : false
                };
                int id_generada_usuario = new CN_Usuarios().Crear(Usuario, out mensaje);
                if (id_generada_usuario == 0)
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Usuario generado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                Anterior_usuario = new Usuarios();
                Anterior_usuario.Id_usuario = Usuario.Id_usuario;
                Anterior_usuario.Dni = Usuario.Dni;
                Anterior_usuario.Nombre_completo = Usuario.Nombre_completo;
                Anterior_usuario.Correo = Usuario.Correo;
                Anterior_usuario.Nombre_usuario = Usuario.Nombre_usuario;
                Anterior_usuario.Clave = Usuario.Clave;
                Anterior_usuario.oRol = new Roles() { Id_rol = Usuario.oRol.Id_rol };
                Anterior_usuario.Telefono = Usuario.Telefono;
                Anterior_usuario.Estado = Usuario.Estado;
                Usuario.Dni = txt_dni.Texts;
                Usuario.Nombre_completo = txt_nombre_completo.Texts;
                Usuario.Correo = txt_correo.Texts;
                Usuario.Nombre_usuario = txt_nombre_usuario.Texts;
                Usuario.Clave = txt_clave.Texts;
                Usuario.oRol.Id_rol = Convert.ToInt32(((OpcionCombo)cbo_rol.SelectedItem).Value);
                Usuario.Telefono = txt_telefono.Texts;
                Usuario.Estado = Convert.ToInt32(((OpcionCombo)cbo_estado.SelectedItem).Value) == 1 ? true : false;
                bool resultado = new CN_Usuarios().Modificar(Usuario, out mensaje);
                if (!resultado)
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Usuario actualizado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_editar_permisos_Click(object sender, EventArgs e)
        {
            formPermisos formPermisos = new formPermisos(Usuario);
            formPermisos.Show();
        }
    }
}
