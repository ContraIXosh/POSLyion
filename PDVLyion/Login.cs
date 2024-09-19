using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using EntityLayer;

namespace PDCLyion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            
           
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
        }

        public void form_closing(object sender, FormClosingEventArgs e)
        {
            txtusername.Text = "";
            txtpassword.Text = "";
            this.Show();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Users oUser = new BL_Users()
                .ListAll()
                .Where(u => u.Username == txtusername.Text && u.Password == txtpassword.Text).FirstOrDefault();

            if (txtpassword.Text == "" && txtusername.Text == "")
            {
                MessageBox.Show("Ingrese un usuario y contraseña", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtusername.Text == "")
            {
                MessageBox.Show("Ingrese un usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtpassword.Text == "")
            {
                MessageBox.Show("Ingrese una contraseña", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (oUser == null)
            {
                MessageBox.Show("Usuario no encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Start form = new Start(oUser);
                form.Show();
                this.Hide();
                form.FormClosing += form_closing;
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusername__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
