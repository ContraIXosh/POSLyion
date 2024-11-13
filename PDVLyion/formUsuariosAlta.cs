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
using System.Text.RegularExpressions;

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

            List<Roles> lista_roles = new CN_Roles().Leer();
            foreach (Roles oRol in lista_roles)
            {
                cbo_roles.Items.Add(new OpcionCombo() { Valor = oRol.Id_rol, Texto = oRol.Descripcion });
            }
            cbo_roles.DisplayMember = "Texto";
            cbo_roles.ValueMember = "Valor";

            cbo_estado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cbo_estado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Inactivo" });
            cbo_estado.DisplayMember = "Texto";
            cbo_estado.ValueMember = "Valor";

            txt_id.Texts = Usuario.Id_usuario.ToString();
            txt_nombre_completo.Text = Usuario.Nombre_completo;
            txt_correo.Text = Usuario.Correo;
            txt_dni.Text = Usuario.Dni;
            txt_nombre_usuario.Text = Usuario.Nombre_usuario;
            txt_telefono.Text = Usuario.Telefono;
            txt_contraseña.Text = Usuario.Clave;
            int cbo_rol_index = 0;
            int cbo_estado_index = 0;

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
                    Estado = Convert.ToInt32(((OpcionCombo)cbo_estado.SelectedItem).Valor) == 1 ? true : false
                };
                int id_generada_usuario = new CN_Usuarios().Crear(Usuario, out mensaje);
                if (id_generada_usuario == 0)
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Usuario generado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
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
                Usuario.Dni = txt_dni.Text;
                Usuario.Nombre_completo = txt_nombre_completo.Text;
                Usuario.Correo = txt_correo.Text;
                Usuario.Nombre_usuario = txt_nombre_usuario.Text;
                Usuario.Clave = txt_contraseña.Text;
                Usuario.oRol.Id_rol = Convert.ToInt32(((OpcionCombo)cbo_roles.SelectedItem).Valor);
                Usuario.Telefono = txt_telefono.Text;
                Usuario.Estado = Convert.ToInt32(((OpcionCombo)cbo_estado.SelectedItem).Valor) == 1 ? true : false;
                bool resultado = new CN_Usuarios().Modificar(Usuario, out mensaje);
                if (!resultado)
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Usuario actualizado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_nombre_completo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ingrese solo letras", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Ingresa solo valores numericos positivos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Ingresa solo valores numericos positivos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txt_correo_Validating(object sender, CancelEventArgs e)
        {
            string email = txt_correo.Text; string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; if (!Regex.IsMatch(email, pattern))
            {
                e.Cancel = true;
                txt_correo.BackColor = Color.LightCoral;
                MessageBox.Show("Ingresa un correo electrónico válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txt_correo.BackColor = SystemColors.Window;
            }
        }
    }
}
