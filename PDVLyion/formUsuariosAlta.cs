using CapaEntidad;
using CapaNegocio;
using POSLyion.Resources;
using System;
using System.Windows.Forms;

namespace POSLyion
{
    public partial class formUsuariosAlta : Form
    {
        private Usuarios _objeto;
        private Usuarios _objetoAnterior;

        public formUsuariosAlta()
        {
            InitializeComponent();
            _objeto = new Usuarios();
        }

        public formUsuariosAlta(Usuarios oUsuario)
        {
            InitializeComponent();
            _objeto = oUsuario;
        }

        private void formUsuariosAlta_Load(object sender, EventArgs e)
        {
            CargarManejadoresEventos();
            CargarValoresPorDefecto();
            MostrarDatosObjeto();
            KeyPreview = true;
        }

        private void CargarManejadoresEventos()
        {
            txt_dni.KeyPress += new KeyPressEventHandler(NoLetras);
            txt_telefono.KeyPress += new KeyPressEventHandler(NoLetras);
        }

        private void CargarValoresPorDefecto()
        {
            lbl_estado.Visible = false;
            cbox_estado.Visible = false;
            btn_reiniciar_datos.Visible = false;

            var lista_roles = new CN_Roles().Leer();
            foreach (var oRol in lista_roles)
            {
                _ = cbox_roles.Items.Add(new OpcionCombo() { Valor = oRol.Id_rol, Texto = oRol.Descripcion });
            }
            cbox_roles.DisplayMember = "Texto";
            cbox_roles.ValueMember = "Valor";

            _ = cbox_estado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            _ = cbox_estado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Inactivo" });
            cbox_estado.DisplayMember = "Texto";
            cbox_estado.ValueMember = "Valor";

            cbox_estado.SelectedIndex = 0;
            cbox_roles.SelectedIndex = 0;
        }

        private void MostrarDatosObjeto()
        {
            if (_objeto.Id_usuario != 0)
            {
                RespaldoDatosObjeto();

                lbl_estado.Visible = true;
                cbox_estado.Visible = true;
                btn_reiniciar_datos.Visible = true;

                txt_nombre_completo.Text = _objeto.Nombre_completo;
                txt_correo.Text = _objeto.Correo;
                txt_dni.Text = _objeto.Dni;
                txt_nombre_usuario.Text = _objeto.Nombre_usuario;
                txt_telefono.Text = _objeto.Telefono;
                txt_contraseña.Text = _objeto.Clave;

                var cbo_rol_index = 0;
                var cbo_estado_index = 0;

                foreach (OpcionCombo opcion_estado in cbox_estado.Items)
                {
                    if (Convert.ToInt32(opcion_estado.Valor) == (_objeto.Estado == true ? 1 : 0))
                    {
                        cbo_estado_index = cbox_estado.Items.IndexOf(opcion_estado);
                        break;
                    }
                }
                cbox_estado.SelectedIndex = cbo_estado_index;

                foreach (OpcionCombo opcion_rol in cbox_roles.Items)
                {
                    if (Convert.ToInt32(opcion_rol.Valor) == _objeto.oRol.Id_rol)
                    {
                        cbo_rol_index = cbox_roles.Items.IndexOf(opcion_rol);
                        break;
                    }
                }
                cbox_roles.SelectedIndex = cbo_rol_index;
            }
        }

        private void CrearNuevoObjeto()
        {
            _objeto = new Usuarios()
            {
                Dni = txt_dni.Text,
                Nombre_completo = txt_nombre_completo.Text,
                Correo = txt_correo.Text,
                Nombre_usuario = txt_nombre_usuario.Text,
                Clave = txt_contraseña.Text,
                oRol = new Roles()
                {
                    Id_rol = Convert.ToInt32(((OpcionCombo)cbox_roles.SelectedItem).Valor),
                },
                Telefono = txt_telefono.Text,
                Estado = Convert.ToInt32(((OpcionCombo)cbox_estado.SelectedItem).Valor) == 1
            };

            if (new CN_Usuarios().Crear(_objeto, out var mensaje) == 0)
            {
                _ = MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                _ = MessageBox.Show("Usuario generado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }
        }

        private void EditarObjeto()
        {
            _objeto.Dni = txt_dni.Text;
            _objeto.Nombre_completo = txt_nombre_completo.Text;
            _objeto.Correo = txt_correo.Text;
            _objeto.Nombre_usuario = txt_nombre_usuario.Text;
            _objeto.Clave = txt_contraseña.Text;
            _objeto.oRol.Id_rol = Convert.ToInt32(((OpcionCombo)cbox_roles.SelectedItem).Valor);
            _objeto.Telefono = txt_telefono.Text;
            _objeto.Estado = Convert.ToInt32(((OpcionCombo)cbox_estado.SelectedItem).Valor) == 1;

            if (new CN_Usuarios().Modificar(_objeto, out var mensaje) == false)
            {
                _ = MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                _ = MessageBox.Show("Usuario actualizado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
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
            if (txt_dni.Text == "")
            {
                resultado = false;
                errorProvider4.SetError(txt_dni, "Ingrese el DNI del usuario");
            }
            return resultado;
        }

        private void RespaldoDatosObjeto()
        {
            _objetoAnterior = new Usuarios
            {
                Id_usuario = _objeto.Id_usuario,
                Dni = _objeto.Dni,
                Nombre_completo = _objeto.Nombre_completo,
                Correo = _objeto.Correo,
                Nombre_usuario = _objeto.Nombre_usuario,
                Clave = _objeto.Clave,
                oRol = new Roles() { Id_rol = _objeto.oRol.Id_rol },
                Telefono = _objeto.Telefono,
                Estado = _objeto.Estado
            };
        }

        private void NoLetras(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (_objeto.Id_usuario == 0)
                {
                    CrearNuevoObjeto();
                }
                else
                {
                    EditarObjeto();
                }
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_reiniciar_datos_Click(object sender, EventArgs e)
        {
            txt_nombre_completo.Text = _objetoAnterior.Nombre_completo;
            txt_dni.Text = _objetoAnterior.Dni;
            txt_telefono.Text = _objetoAnterior.Telefono;
            cbox_roles.SelectedIndex = _objetoAnterior.oRol.Id_rol - 1;
            txt_correo.Text = _objetoAnterior.Correo;
            txt_nombre_usuario.Text = _objetoAnterior.Nombre_usuario;
            txt_contraseña.Text = _objetoAnterior.Clave;
            cbox_estado.SelectedIndex = _objetoAnterior.Estado ? 0 : 1;
        }

        private void formUsuariosAlta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
