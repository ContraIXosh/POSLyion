using PDCLyion.Resources;
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
using EntityLayer;
using BusinessLayer;
using System.Web.UI.WebControls;

namespace PDCLyion
{
    public partial class formUsers : Form
    {

        private Users User;

        public formUsers(Users oUser)
        {
            InitializeComponent();
            User = oUser;
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

        private void formUsers_Load(object sender, EventArgs e)
        {
            List<Roles> roles = new BL_Roles().ListAll();
            foreach (Roles role in roles)
            {
                cbo_rol.Items.Add(new OpcionCombo() { Value = role.Role_id, Text = role.Description });
            }
            cbo_rol.DisplayMember = "Text";
            cbo_rol.ValueMember = "Value";

            cbo_estado.Items.Add(new OpcionCombo() { Value = 1, Text = "Activo" });
            cbo_estado.Items.Add(new OpcionCombo() { Value = 0, Text = "Inactivo" });
            cbo_estado.DisplayMember = "Text";
            cbo_estado.ValueMember = "Value";

            txt_id.Texts = User.User_id.ToString();
            txt_nombre.Texts = User.Full_name;
            txt_correo.Texts = User.Email;
            txt_dni.Texts = User.Dni;
            txt_username.Texts = User.Username;
            txt_tel.Texts = User.Phone;
            txt_pass.Texts = User.Password;
            int cbo_rol_index = 0;
            int cbo_estado_index = 0;

            foreach (OpcionCombo opcion_estado in cbo_estado.Items)
            {
                if (Convert.ToInt32(opcion_estado.Value) == (User.State == true ? 1 : 0))
                {
                    cbo_estado_index = cbo_estado.Items.IndexOf(opcion_estado);
                    break;
                }
            }
            cbo_estado.SelectedIndex = cbo_estado_index;

            foreach (OpcionCombo opcion_rol in cbo_rol.Items)
            {
                if (Convert.ToInt32(opcion_rol.Value) == User.oRol.Role_id)
                {
                    cbo_rol_index = cbo_rol.Items.IndexOf(opcion_rol);
                    break;
                }
            }
            cbo_rol.SelectedIndex = cbo_rol_index;
        }
    }
}
