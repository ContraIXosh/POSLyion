using CapaEntidad;
using CapaNegocio;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace POSLyion
{
    public partial class LoginPOS : Form
    {

        public UsuariosPOS UsuarioPOS = new UsuariosPOS();
        public bool sesion_iniciada = false;

        public LoginPOS()
        {
            InitializeComponent();
        }

        private void btn_iniciar_sesion_Click(object sender, EventArgs e)
        {
            var oUsuarioPOS = new CN_UsuariosPOS()
                .Leer()
                .Where(u => u.Nombre == txt_nombre_usuario.Text && u.Clave == txt_clave.Text).FirstOrDefault();

            if (txt_clave.Text == "" && txt_nombre_usuario.Text == "")
            {
                _ = MessageBox.Show("Ingrese un usuario y contraseña", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txt_nombre_usuario.Text == "")
            {
                _ = MessageBox.Show("Ingrese un usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txt_clave.Text == "")
            {
                _ = MessageBox.Show("Ingrese una contraseña", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (oUsuarioPOS == null)
            {
                _ = MessageBox.Show("Usuario no encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                UsuarioPOS = oUsuarioPOS;
                sesion_iniciada = true;
                _ = MessageBox.Show("Sesion iniciada con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
