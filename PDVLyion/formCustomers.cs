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
        private static Users oUser = new Users();

        public formCustomers()
        {
            InitializeComponent();
        }

        private void formCustomers_Load(object sender, EventArgs e)
        {
            List<Customers> customer_list = new BL_Customers().ListAll();
            foreach (Customers customer in customer_list)
            {
                grid_clientes.Rows.Add(new object[]
                {
                    customer.Customer_id,
                    customer.Dni,
                    customer.Full_name,
                    customer.Phone,
                    customer.Email,
                    customer.State == true ? "Activo" : "Inactivo",
                    customer.State == true ? 1 : 0
                });
            }
        }

        private void panel_footer_Resize_1(object sender, EventArgs e)
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

        private void grid_proveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (grid_clientes.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                if (index >= 0)
                {
                    Customers customer = new Customers()
                    {
                        Customer_id = Convert.ToInt32(grid_clientes.Rows[index].Cells["id"].Value),
                        Dni = grid_clientes.Rows[index].Cells["dni"].Value.ToString(),
                        Full_name = grid_clientes.Rows[index].Cells["full_name"].Value.ToString(),
                        Email = grid_clientes.Rows[index].Cells["email"].Value.ToString(),
                        Phone = grid_clientes.Rows[index].Cells["phone"].Value.ToString(),
                        State = Convert.ToBoolean(grid_clientes.Rows[index].Cells["state_value"].Value)
                    };
                    formCustomersAdd customeradd = new formCustomersAdd(customer);
                    customeradd.Show();
                }
            }
            else if (grid_clientes.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {
                if (MessageBox.Show("¿Desea eliminar el cliente?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (index >= 0)
                    {
                        string message = string.Empty;
                        Customers customer = new Customers()
                        {
                            Customer_id = Convert.ToInt32(grid_clientes.Rows[index].Cells["id"].Value)
                        };
                        bool result = new BL_Customers().Delete(customer, out message);
                        if (!result)
                        {
                            MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("Cliente eliminado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                    }
                }
            }
        }

        private void btn_crear_cliente_Click(object sender, EventArgs e)
        {
            formCustomersAdd crearcliente = new formCustomersAdd();
            crearcliente.Show();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            grid_clientes.Rows.Clear();
            List<Customers> customer_list = new BL_Customers().ListAll();
            foreach (Customers customer in customer_list)
            {
                grid_clientes.Rows.Add(new object[]
                {
                    customer.Customer_id,
                    customer.Dni,
                    customer.Full_name,
                    customer.Phone,
                    customer.Email,
                    customer.State == true ? "Activo" : "Inactivo",
                    customer.State == true ? 1 : 0
                });
            }
        }
    }
}
