using CapaEntidad;
using CapaNegocio;
using DocumentFormat.OpenXml.Spreadsheet;
using POSLyion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDCLyion
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
            UsuariosPOS oUsuarioPOS = new CN_UsuariosPOS()
                .Leer()
                .Where(u => u.Nombre == txt_nombre_usuario.Text && u.Clave == txt_clave.Text).FirstOrDefault();

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
            else if (oUsuarioPOS == null)
            {
                MessageBox.Show("Usuario no encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.UsuarioPOS = oUsuarioPOS;
                this.sesion_iniciada = true;
                MessageBox.Show("Sesion iniciada con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
