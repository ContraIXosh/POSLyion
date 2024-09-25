﻿using System;
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
        public formUsers2()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if (dgvdata.Columns[e.ColumnIndex].Name == "btn_editar")
           {
                int index = e.RowIndex;
                if(index >= 0)
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
    }
}
