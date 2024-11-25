using CapaEntidad;
using CapaNegocio;
using POSLyion.Resources;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace POSLyion
{
    public partial class formUsuariosAlta : Form
    {
        private Usuarios Usuario;
        private Usuarios Anterior_usuario;
        private static readonly Usuarios oUsuario = new Usuarios();

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

            var lista_roles = new CN_Roles().Leer();
            foreach (var oRol in lista_roles)
            {
                _ = cbo_roles.Items.Add(new OpcionCombo() { Valor = oRol.Id_rol, Texto = oRol.Descripcion });
            }
            cbo_roles.DisplayMember = "Texto";
            cbo_roles.ValueMember = "Valor";

            _ = cbo_estado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            _ = cbo_estado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Inactivo" });
            cbo_estado.DisplayMember = "Texto";
            cbo_estado.ValueMember = "Valor";

            txt_id.Texts = Usuario.Id_usuario.ToString();
            txt_nombre_completo.Text = Usuario.Nombre_completo;
            txt_correo.Text = Usuario.Correo;
            txt_dni.Text = Usuario.Dni;
            txt_nombre_usuario.Text = Usuario.Nombre_usuario;
            txt_telefono.Text = Usuario.Telefono;
            txt_contraseña.Text = Usuario.Clave;
            var cbo_rol_index = 0;
            var cbo_estado_index = 0;

            if (Convert.ToInt32(txt_id.Texts) == 0)
            {
                cbo_estado.SelectedIndex = 0;
                cbo_roles.SelectedIndex = 0;
            }
            else
            {
                foreach (OpcionCombo opcion_estado in cbo_estado.Items)
                {
                    if (Convert.ToInt32(opcion_estado.Valor) == (Usuario.Estado == true ? 1 : 0))
                    {
                        cbo_estado_index = cbo_estado.Items.IndexOf(opcion_estado);
                        break;
                    }
                }
                cbo_estado.SelectedIndex = cbo_estado_index;

                foreach (OpcionCombo opcion_rol in cbo_roles.Items)
                {
                    if (Convert.ToInt32(opcion_rol.Valor) == Usuario.oRol.Id_rol)
                    {
                        cbo_rol_index = cbo_roles.Items.IndexOf(opcion_rol);
                        break;
                    }
                }
                cbo_roles.SelectedIndex = cbo_rol_index;
            }
        }

        private void panel1_Resize(object sender, EventArgs e)
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

        private void panel_useradd_Resize(object sender, EventArgs e)
        {
            if (ClientSize.Width > 1000 && ClientSize.Height > 700)
            {
                AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                btn_cerrar.Width = 150;
                btn_cerrar.Left = ClientSize.Width - btn_cerrar.Width;
            }
            else
            {
                AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                btn_cerrar.Left = ClientSize.Width - btn_cerrar.Width;
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
            string mensaje;
            if (Convert.ToInt32(txt_id.Texts) == 0)
            {
                Usuario = new Usuarios()
                {
                    Dni = txt_dni.Text,
                    Nombre_completo = txt_nombre_completo.Text,
                    Correo = txt_correo.Text,
                    Nombre_usuario = txt_nombre_usuario.Text,
                    Clave = txt_contraseña.Text,
                    oRol = new Roles()
                    {
                        Id_rol = Convert.ToInt32(((OpcionCombo)cbo_roles.SelectedItem).Valor),
                    },
                    Telefono = txt_telefono.Text,
                    Estado = Convert.ToInt32(((OpcionCombo)cbo_estado.SelectedItem).Valor) == 1
                };
                var id_generada_usuario = new CN_Usuarios().Crear(Usuario, out mensaje);
                if (id_generada_usuario == 0)
                {
                    _ = MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    _ = MessageBox.Show("Usuario generado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Close();
                }
            }
            else
            {
                Anterior_usuario = new Usuarios
                {
                    Id_usuario = Usuario.Id_usuario,
                    Dni = Usuario.Dni,
                    Nombre_completo = Usuario.Nombre_completo,
                    Correo = Usuario.Correo,
                    Nombre_usuario = Usuario.Nombre_usuario,
                    Clave = Usuario.Clave,
                    oRol = new Roles() { Id_rol = Usuario.oRol.Id_rol },
                    Telefono = Usuario.Telefono,
                    Estado = Usuario.Estado
                };
                Usuario.Dni = txt_dni.Text;
                Usuario.Nombre_completo = txt_nombre_completo.Text;
                Usuario.Correo = txt_correo.Text;
                Usuario.Nombre_usuario = txt_nombre_usuario.Text;
                Usuario.Clave = txt_contraseña.Text;
                Usuario.oRol.Id_rol = Convert.ToInt32(((OpcionCombo)cbo_roles.SelectedItem).Valor);
                Usuario.Telefono = txt_telefono.Text;
                Usuario.Estado = Convert.ToInt32(((OpcionCombo)cbo_estado.SelectedItem).Valor) == 1;
                var resultado = new CN_Usuarios().Modificar(Usuario, out mensaje);
                if (!resultado)
                {
                    _ = MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    _ = MessageBox.Show("Usuario actualizado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Close();
                }
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_nombre_completo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                _ = MessageBox.Show("Ingrese solo letras", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                _ = MessageBox.Show("Ingresa solo valores numericos positivos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                _ = MessageBox.Show("Ingresa solo valores numericos positivos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txt_correo_Validating(object sender, CancelEventArgs e)
        {
            var email = txt_correo.Text; var pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; if (!Regex.IsMatch(email, pattern))
            {
                e.Cancel = true;
                txt_correo.BackColor = Color.LightCoral;
                _ = MessageBox.Show("Ingresa un correo electrónico válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txt_correo.BackColor = SystemColors.Window;
            }
        }
    }
}
