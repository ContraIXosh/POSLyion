using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using BusinessLayer;

namespace PDCLyion
{
    public partial class formCustomers : Form
    {
        string connectionString = "Data Source = ; Initial Catalog = POSLyion; Integrated Security = True";
        private static Users oUser = new Users();
        public formCustomers()
        {
            InitializeComponent();
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

        private void btn_addvendedor_Click_1(object sender, EventArgs e)
        {
            abrirHerencia(new formCustomers2());
        }

        private void btn_viewvendedor_Click_1(object sender, EventArgs e)
        {
            abrirHerencia(new formCustomers());
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            abrirHerencia(new Start(oUser));
        }

        private void panel_footer_Resize_1(object sender, EventArgs e)
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
                btn_back.Left = this.ClientSize.Width - btn_back.Width;
            }
        }

        private void panel_footer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formCustomers_Load(object sender, EventArgs e)
        {
            List<Customers> customer_list = new BL_Customers().ListAll();
            foreach(Customers customer in customer_list)
            {
                grid_proveedores.Rows.Add(new object[]
                {
                    "",
                    customer.Customer_id,
                    customer.Full_name,
                    customer.Dni,
                    customer.Phone,
                    customer.Email,
                    customer.State == true ? "Activo" : "Inactivo",
                    customer.State == true ? 1 : 0
                });
            }
        }

        private void grid_proveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (grid_proveedores.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                if (index >= 0)
                {
                    Customers customer = new Customers()
                    {
                        Customer_id = Convert.ToInt32(grid_proveedores.Rows[index].Cells["cliente_id"].Value),
                        Dni = grid_proveedores.Rows[index].Cells["cliente_dni"].Value.ToString(),
                        Full_name = grid_proveedores.Rows[index].Cells["cliente_fullname"].Value.ToString(),
                        Email = grid_proveedores.Rows[index].Cells["cliente_email"].Value.ToString(),
                        Phone = grid_proveedores.Rows[index].Cells["cliente_tel"].Value.ToString(),
                        State = Convert.ToBoolean(grid_proveedores.Rows[index].Cells["cliente_estado_valor"].Value)
                    };
                    abrirHerencia(new formCustomers2(customer));
                }
            }
            else if (grid_proveedores.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {
                if (MessageBox.Show("¿Desea eliminar el cliente", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (index >= 0)
                    {
                        string message = string.Empty;
                        Customers customer = new Customers()
                        {
                            Customer_id = Convert.ToInt32(grid_proveedores.Rows[index].Cells["cliente_id"].Value)
                        };
                        bool result = new BL_Customers().Delete(customer, out message);
                        if (!result)
                        {
                            MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("Cliente eliminado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            abrirHerencia(new formCustomers2());
                        }
                    }
                }
            }
        }
    }
}
