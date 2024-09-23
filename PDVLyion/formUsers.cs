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

namespace PDCLyion
{
    public partial class formUsers : Form
    {
        public formUsers()
        {
            InitializeComponent();
        }
        private void abrirHerencia(object formhija)
        {
            if (this.panel_main.Controls.Count > 0)
            {
                this.panel_main.Controls.RemoveAt(0);
                Form fh = formhija as Form;
                fh.TopLevel = false; //dependencia
                fh.Dock = DockStyle.Fill;
                fh.FormBorderStyle = FormBorderStyle.None;
                this.panel_main.Controls.Add(fh);
                this.panel_main.Tag = fh;
                fh.BringToFront();
                this.panel_main.Refresh();
                fh.Show();

            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            abrirHerencia(new formSales());
        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {

        }

        private void btn_visualizarUser_Click(object sender, EventArgs e)
        {
            abrirHerencia(new formUsers2());
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = .; Initial Catalog= POSLyion; Integrated Security = True";
            string query = "INSERT INTO dbo.Users (full_name, dni, num_tel, email, username, password)" + "VALUES (@Fullname, @DNI, @NUM_TEL, @Email, @Username, @Password)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Fullname", txt_nombre.Text);
                    cmd.Parameters.AddWithValue("@DNI", txt_dni.Text);
                    cmd.Parameters.AddWithValue("@NUM_TEL", txt_tel.Text);
                    cmd.Parameters.AddWithValue("@Email", txt_correo.Text);
                    cmd.Parameters.AddWithValue("@Username", txt_username.Text);
                    cmd.Parameters.AddWithValue("@Password", txt_pass.Text);

                    try
                    {
                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuario se pudo registrar correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo registrar el usuario.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error: " + ex.Message);
                    }
            }
            }
        }
    }
}
