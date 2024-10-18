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
    public partial class formUsers : Form
    {
        private static Users oUser = new Users();

        public formUsers()
        {
            InitializeComponent();
        }

        private void formUsersAdd_Load(object sender, EventArgs e)
        {
            List<Users> users_list = new BL_Users().ListAll();
            foreach (Users user in users_list)
            {
                grid_usuarios.Rows.Add(new object[]
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

        private void formUsers2_Resize(object sender, EventArgs e)
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

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (grid_usuarios.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                if (index >= 0)
                {
                    Users user = new Users()
                    {
                        User_id = Convert.ToInt32(grid_usuarios.Rows[index].Cells["user_id"].Value),
                        Dni = grid_usuarios.Rows[index].Cells["dni"].Value.ToString(),
                        Full_name = grid_usuarios.Rows[index].Cells["full_name"].Value.ToString(),
                        Email = grid_usuarios.Rows[index].Cells["email"].Value.ToString(),
                        Username = grid_usuarios.Rows[index].Cells["username"].Value.ToString(),
                        Password = grid_usuarios.Rows[index].Cells["password"].Value.ToString(),
                        oRol = new Roles()
                        {
                            Role_id = Convert.ToInt32(grid_usuarios.Rows[index].Cells["rol_id"].Value),
                            Description = grid_usuarios.Rows[index].Cells["rol_description"].Value.ToString()
                        },
                        Phone = grid_usuarios.Rows[index].Cells["phone"].Value.ToString(),
                        State = Convert.ToBoolean(grid_usuarios.Rows[index].Cells["state_value"].Value)
                    };
                    formUsersAdd frmusersadd = new formUsersAdd(user);
                    frmusersadd.Show();
                }
            }
            else if (grid_usuarios.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {
                if (MessageBox.Show("¿Desea eliminar el usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (index >= 0)
                    {
                        string message = string.Empty;
                        Users user = new Users()
                        {
                            User_id = Convert.ToInt32(grid_usuarios.Rows[index].Cells["user_id"].Value)
                        };
                        bool result = new BL_Users().Delete(user, out message);
                        if (!result)
                        {
                            MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("Usuario eliminado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
        }

        private void btn_crear_usuario_Click(object sender, EventArgs e)
        {
            formUsersAdd formuseradd = new formUsersAdd();
            formuseradd.Show();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            grid_usuarios.Rows.Clear();
            List<Users> users_list = new BL_Users().ListAll();
            foreach (Users user in users_list)
            {
                grid_usuarios.Rows.Add(new object[]
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
    }
}
