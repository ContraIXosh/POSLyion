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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
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
            else
            {
                Start form = new Start();
                form.Show();
                this.Hide();
                form.FormClosing += form_closing;
            }
           
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void form_closing(object sender, FormClosingEventArgs e)
        {
            txtusername.Text = "";
            txtpassword.Text = "";
            this.Show();
        }
    }
}
