using CapaEntidad;
using CapaNegocio;
using EntityLayer.Filtros;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace POSLyion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        public void form_closing(object sender, FormClosingEventArgs e)
        {
            txt_nombre_usuario.Text = "";
            txt_clave.Text = "";
            Show();
        }

        private void btn_abrir_sesion_Click(object sender, EventArgs e)
        {
            var filtros = new FiltrosUsuario();
            var oUsuario = new CN_Usuarios()
                .Leer(filtros)
                .Where(u => u.Nombre_usuario == txt_nombre_usuario.Text && u.Clave == txt_clave.Text).FirstOrDefault();

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
            else if (oUsuario == null)
            {
                _ = MessageBox.Show("Usuario no encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                VariablesGlobales.Inicio_sesion = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                VariablesGlobales.Usuario_actual = oUsuario;
                var formStart = new Start();
                formStart.Show();
                Hide();
                formStart.FormClosing += form_closing;
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtpassword_TextChanged_2(object sender, EventArgs e)
        {
            txt_clave.PasswordChar = '*';
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_iniciar_sesion.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
            {
                btn_cerrar.PerformClick();
            }
        }
    }
}
