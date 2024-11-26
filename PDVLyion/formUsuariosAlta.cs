using CapaEntidad;
using CapaNegocio;
using POSLyion.Resources;
using System;
using System.Windows.Forms;

namespace POSLyion
{
    public partial class formUsuariosAlta : Form
    {
        private Usuarios _usuario;
        private Usuarios _usuarioAnterior;

        public formUsuariosAlta()
        {
            InitializeComponent();
            _usuario = new Usuarios();
        }

        public formUsuariosAlta(Usuarios oUsuario)
        {
            InitializeComponent();
            _usuario = oUsuario;
        }

        private void formUsuariosAlta_Load(object sender, EventArgs e)
        {
            CargarManejadoresEventos();
            CargarValoresPorDefecto();
            CargarDatosUsuario();
            KeyPreview = true;
        }

        private void CargarManejadoresEventos()
        {
            txt_dni.KeyPress += new KeyPressEventHandler(NoLetras);
            txt_telefono.KeyPress += new KeyPressEventHandler(NoLetras);
        }

        private void NoLetras(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CargarValoresPorDefecto()
        {
            lbl_estado.Visible = false;
            cbo_estado.Visible = false;
            btn_reiniciar_datos.Visible = false;

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

            cbo_estado.SelectedIndex = 0;
            cbo_roles.SelectedIndex = 0;
        }

        private void CargarDatosUsuario()
        {
            if (_usuario.Id_usuario != 0)
            {
                lbl_estado.Visible = true;
                cbo_estado.Visible = true;
                btn_reiniciar_datos.Visible = true;
                CargarRespaldoUsuario();
                txt_id.Texts = _usuario.Id_usuario.ToString();
                txt_nombre_completo.Text = _usuario.Nombre_completo;
                txt_correo.Text = _usuario.Correo;
                txt_dni.Text = _usuario.Dni;
                txt_nombre_usuario.Text = _usuario.Nombre_usuario;
                txt_telefono.Text = _usuario.Telefono;
                txt_contraseña.Text = _usuario.Clave;
                var cbo_rol_index = 0;
                var cbo_estado_index = 0;

                foreach (OpcionCombo opcion_estado in cbo_estado.Items)
                {
                    if (Convert.ToInt32(opcion_estado.Valor) == (_usuario.Estado == true ? 1 : 0))
                    {
                        cbo_estado_index = cbo_estado.Items.IndexOf(opcion_estado);
                        break;
                    }
                }
                cbo_estado.SelectedIndex = cbo_estado_index;

                foreach (OpcionCombo opcion_rol in cbo_roles.Items)
                {
                    if (Convert.ToInt32(opcion_rol.Valor) == _usuario.oRol.Id_rol)
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
            if (ValidarDatos())
            {
                if (_usuario.Id_usuario == 0)
                {
                    _ = GenerarUsuario();
                    CrearNuevoUsuario();
                }
                else
                {
                    CargarRespaldoUsuario();
                    EditarUsuario();
                }
            }
        }

        private bool ValidarDatos()
        {
            var resultado = true;
            if (txt_nombre_completo.Text == "")
            {
                resultado = false;
                errorProvider1.SetError(txt_nombre_completo, "Ingrese un nombre de pila");
            }
            if (txt_nombre_usuario.Text == "")
            {
                resultado = false;
                errorProvider2.SetError(txt_nombre_usuario, "Ingrese un nombre de usuario");
            }
            if (txt_contraseña.Text == "")
            {
                resultado = false;
                errorProvider3.SetError(txt_contraseña, "Ingrese una contraseña de usuario");
            }
            return resultado;
        }

        private Usuarios GenerarUsuario()
        {
            _usuario = new Usuarios()
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
            return _usuario;
        }

        private void CargarRespaldoUsuario()
        {
            _usuarioAnterior = new Usuarios
            {
                Id_usuario = _usuario.Id_usuario,
                Dni = _usuario.Dni,
                Nombre_completo = _usuario.Nombre_completo,
                Correo = _usuario.Correo,
                Nombre_usuario = _usuario.Nombre_usuario,
                Clave = _usuario.Clave,
                oRol = new Roles() { Id_rol = _usuario.oRol.Id_rol },
                Telefono = _usuario.Telefono,
                Estado = _usuario.Estado
            };
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CrearNuevoUsuario()
        {
            if (new CN_Usuarios().Crear(_usuario, out var mensaje) == 0)
            {
                _ = MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                _ = MessageBox.Show("Usuario generado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }
        }

        private void EditarUsuario()
        {
            _usuario.Dni = txt_dni.Text;
            _usuario.Nombre_completo = txt_nombre_completo.Text;
            _usuario.Correo = txt_correo.Text;
            _usuario.Nombre_usuario = txt_nombre_usuario.Text;
            _usuario.Clave = txt_contraseña.Text;
            _usuario.oRol.Id_rol = Convert.ToInt32(((OpcionCombo)cbo_roles.SelectedItem).Valor);
            _usuario.Telefono = txt_telefono.Text;
            _usuario.Estado = Convert.ToInt32(((OpcionCombo)cbo_estado.SelectedItem).Valor) == 1;
            if (new CN_Usuarios().Modificar(_usuario, out var mensaje))
            {
                _ = MessageBox.Show("Usuario actualizado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();

            }
            else
            {
                _ = MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void formUsuariosAlta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void btn_reiniciar_datos_Click(object sender, EventArgs e)
        {
            txt_nombre_completo.Text = _usuarioAnterior.Nombre_completo;
            txt_dni.Text = _usuarioAnterior.Dni;
            txt_telefono.Text = _usuarioAnterior.Telefono;
            cbo_roles.SelectedIndex = _usuarioAnterior.oRol.Id_rol - 1;
            txt_correo.Text = _usuarioAnterior.Correo;
            txt_nombre_usuario.Text = _usuarioAnterior.Nombre_usuario;
            txt_contraseña.Text = _usuarioAnterior.Clave;
            cbo_estado.SelectedIndex = _usuarioAnterior.Estado ? 0 : 1;
        }
    }
}
