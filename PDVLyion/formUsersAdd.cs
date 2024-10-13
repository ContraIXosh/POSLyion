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
    public partial class formUsersAdd : Form
    {
        private Users User;
        private Users Old_User;
        private static Users oUser = new Users();
        public formUsersAdd()
        {
            InitializeComponent();
            User = new Users();
        }

        public formUsersAdd(Users oUser)
        {
            InitializeComponent();
            User = oUser;
        }
        private void abrirHerencia(Form formhija)
        {
            this.panel_main.Controls.Clear();
            formhija.TopLevel = false;
            formhija.FormBorderStyle = FormBorderStyle.None;
            formhija.Dock = DockStyle.Fill;

            panel_main.Controls.Add(formhija);
            formhija.Show();
        }

        private void btn_visualizarUser_Click(object sender, EventArgs e)
        {
            abrirHerencia(new formUsers());
        }

        private void btn_visualizarUser_Click_1(object sender, EventArgs e)
        {
            abrirHerencia(new formUsers());
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            if (Convert.ToInt32(txt_id.Texts) == 0)
            {
                User = new Users()
                {
                    Dni = txt_dni.Texts,
                    Full_name = txt_nombre_completo.Texts,
                    Email = txt_correo.Texts,
                    Username = txt_username.Texts,
                    Password = txt_pass.Texts,
                    oRol = new Roles()
                    {
                        Role_id = Convert.ToInt32(((OpcionCombo)cbo_rol.SelectedItem).Value),
                    },
                    Phone = txt_tel.Texts,
                    State = Convert.ToInt32(((OpcionCombo)cbo_estado.SelectedItem).Value) == 1 ? true : false
                };
                int created_user_id = new BL_Users().Create(User, out message);
                if (created_user_id == 0)
                {
                    MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Usuario generado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                Old_User = new Users();
                Old_User.User_id = User.User_id;
                Old_User.Dni = User.Dni;
                Old_User.Full_name = User.Full_name;
                Old_User.Email = User.Email;
                Old_User.Username = User.Username;
                Old_User.Password = User.Password;
                Old_User.oRol = new Roles() { Role_id = User.oRol.Role_id };
                Old_User.Phone = User.Phone;
                Old_User.State = User.State;
                User.Dni = txt_dni.Texts;
                User.Full_name = txt_nombre_completo.Texts;
                User.Email = txt_correo.Texts;
                User.Username = txt_username.Texts;
                User.Password = txt_pass.Texts;
                User.oRol.Role_id = Convert.ToInt32(((OpcionCombo)cbo_rol.SelectedItem).Value);
                User.Phone = txt_tel.Texts;
                User.State = Convert.ToInt32(((OpcionCombo)cbo_estado.SelectedItem).Value) == 1 ? true : false;
                bool result = new BL_Users().Update(User, out message);
                if (!result)
                {
                    MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Usuario actualizado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void btn_deshacer_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txt_id.Texts) != 0)
            {
                abrirHerencia(new formUsersAdd(Old_User));
            }
            else
            {
                txt_dni.Texts = "";
                txt_correo.Texts = "";
                txt_nombre_completo.Texts = "";
                txt_pass.Texts = "";
                txt_tel.Texts = "";
                txt_username.Texts = "";
                cbo_estado.SelectedIndex = 0;
                cbo_rol.SelectedIndex = 0;
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_dni.Texts = "";
            txt_correo.Texts = "";
            txt_nombre_completo.Texts = "";
            txt_pass.Texts = "";
            txt_tel.Texts = "";
            txt_username.Texts = "";
            cbo_estado.SelectedIndex = 0;
            cbo_rol.SelectedIndex = 0;
        }

        private void btn_editar_permisos_Click(object sender, EventArgs e)
        {
            abrirHerencia(new formPermissions(User));
        }

        private void formUsers_Load(object sender, EventArgs e)
        {
            if(User.User_id == 0)
            {
                btn_editar_permisos.Visible = false;
            }
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
            txt_nombre_completo.Texts = User.Full_name;
            txt_correo.Texts = User.Email;
            txt_dni.Texts = User.Dni;
            txt_username.Texts = User.Username;
            txt_tel.Texts = User.Phone;
            txt_pass.Texts = User.Password;
            int cbo_rol_index = 0;
            int cbo_estado_index = 0;

            if (Convert.ToInt32(txt_id.Texts) == 0)
            {
                cbo_estado.SelectedIndex = 0;
                cbo_rol.SelectedIndex = 0;
            }
            else
            {
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

        private void rjButton2_Click(object sender, EventArgs e)
        {
            abrirHerencia(new Start(oUser));
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            if (this.ClientSize.Width > 1000 && this.ClientSize.Height > 700)
            {
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);

            }
            else
            {
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               
            }
        }

        private void panel_useradd_Resize(object sender, EventArgs e)
        {
            if (this.ClientSize.Width > 1000 && this.ClientSize.Height > 700)
            {
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                btn_back.Width = 150;
                btn_back.Left = this.ClientSize.Width - btn_back.Width;
            }
            else
            {
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                btn_back.Left = this.ClientSize.Width - btn_back.Width;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            abrirHerencia(new Start(oUser));
        }

        private void btn_viewvendedor_Click(object sender, EventArgs e)
        {
            abrirHerencia(new formUsers());
        }
    }
}
