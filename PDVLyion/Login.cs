using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
using EntityLayer.Filtros;

namespace POSLyion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void form_closing(object sender, FormClosingEventArgs e)
        {
            txt_nombre_usuario.Text = "";
            txt_clave.Text = "";
            this.Show();
        }

        private void btn_abrir_sesion_Click(object sender, EventArgs e)
        {
            FiltrosUsuario filtros = new FiltrosUsuario();
            Usuarios oUsuario = new CN_Usuarios()
                .Leer(filtros)
                .Where(u => u.Nombre_usuario == txt_nombre_usuario.Text && u.Clave == txt_clave.Text).FirstOrDefault();

            if (txt_clave.Text == "" && txt_nombre_usuario.Text == "")
            {
                MessageBox.Show("Ingrese un usuario y contraseña", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txt_nombre_usuario.Text == "")
            {
                MessageBox.Show("Ingrese un usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txt_clave.Text == "")
            {
                MessageBox.Show("Ingrese una contraseña", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (oUsuario == null)
            {
                MessageBox.Show("Usuario no encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                VariablesGlobales.Inicio_sesion = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                VariablesGlobales.Usuario_actual = oUsuario;
                Start formStart = new Start();
                formStart.Show();
                this.Hide();
                formStart.FormClosing += form_closing;
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtpassword_TextChanged_2(object sender, EventArgs e)
        {
            txt_clave.PasswordChar = '*';
        }
    }
}
