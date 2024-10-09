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

namespace PDCLyion
{
    public partial class formUsers2 : Form
    {
        private static Users oUser = new Users();

        public formUsers2(Users user)
        {
            InitializeComponent();
            oUser = user;
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

        private void formUsers2_Load(object sender, EventArgs e)
        {
            List<Users> users_list = new BL_Users().ListAll();
            foreach (Users user in users_list)
            {
                dgvdata.Rows.Add(new object[]
                {
                    "",
                    user.User_id,
                    user.Dni,
                    user.Full_name,
                    user.Email,
                    user.Username,
                    user.Password,
                    user.oRol.Role_id,
                    user.oRol.Description,
                    user.Phone,
                    user.State == true ? "Activo" : "Inactivo",
                    user.State == true ? 1 : 0
                });
            }
        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {
            
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            abrirHerencia(new Start(oUser));
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (dgvdata.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                if (index >= 0)
                {
                    Users user = new Users()
                    {
                        User_id = Convert.ToInt32(dgvdata.Rows[index].Cells["data_id"].Value),
                        Dni = dgvdata.Rows[index].Cells["data_dni"].Value.ToString(),
                        Full_name = dgvdata.Rows[index].Cells["data_nombre_completo"].Value.ToString(),
                        Email = dgvdata.Rows[index].Cells["data_correo"].Value.ToString(),
                        Username = dgvdata.Rows[index].Cells["data_username"].Value.ToString(),
                        Password = dgvdata.Rows[index].Cells["data_clave"].Value.ToString(),
                        oRol = new Roles()
                        {
                            Role_id = Convert.ToInt32(dgvdata.Rows[index].Cells["data_id_rol"].Value),
                            Description = dgvdata.Rows[index].Cells["data_rol"].Value.ToString()
                        },
                        Phone = dgvdata.Rows[index].Cells["data_tel"].Value.ToString(),
                        State = Convert.ToBoolean(dgvdata.Rows[index].Cells["data_estado_valor"].Value)
                    };
                    abrirHerencia(new formUsers(user));
                }
            }
            else if (dgvdata.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {
                if (MessageBox.Show("¿Desea eliminar el usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (index >= 0)
                    {
                        string message = string.Empty;
                        Users user = new Users()
                        {
                            User_id = Convert.ToInt32(dgvdata.Rows[index].Cells["data_id"].Value)
                        };
                        bool result = new BL_Users().Delete(user, out message);
                        if (!result)
                        {
                            MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("Usuario eliminado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            abrirHerencia(new formUsers2(oUser));
                        }
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_useradd_Click(object sender, EventArgs e)
        {
            abrirHerencia(new formUsers());
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            abrirHerencia(new Start(oUser));
        }

        private void formUsers2_Resize(object sender, EventArgs e)
        {
            if (this.ClientSize.Width > 1000 && this.ClientSize.Height > 700)
            {
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                panel_footer.Left = this.ClientSize.Width - panel_footer.Width;
                btn_back.Width = 150;
                btn_back.Left = this.ClientSize.Width - btn_back.Width;
            }
            else
            {
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                panel_footer.Left = this.ClientSize.Width - panel_footer.Width;
                btn_back.Left = this.ClientSize.Width - btn_back.Width;
            }
        }

        private void btn_viewvendedor_Click(object sender, EventArgs e)
        {
            abrirHerencia(new formUsers2(oUser));
        }

        private void panel_footer_Resize(object sender, EventArgs e)
        {

        }
    }
}
