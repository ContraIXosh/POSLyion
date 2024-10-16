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
            abrirHerencia(new formCustomersAdd());
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
            }
            else
            {
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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

        }

        //private void btn_hamb_Click(object sender, EventArgs e)
        //{
        //    menu_Main.Show(btn_hamb, btn_hamb.Width, 0);
        //}

        //private void btn_Down_Click(object sender, EventArgs e)
        //{
        //    menu_sesion.Show(btn_Down, btn_Down.Width, 0);
        //}

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirHerencia(new Start(oUser));
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPurchaseOrders crearfactura = new formPurchaseOrders(oUser);
            crearfactura.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirHerencia(new formProducts());
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirHerencia(new formUsers());
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirHerencia(new formCustomers());
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirHerencia(new formCat());
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirHerencia(new formVendors());
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirHerencia(new formStadistic());
        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirHerencia(new formConfig());
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            formCustomersAdd crearcliente = new formCustomersAdd();
            crearcliente.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            abrirHerencia(new Start(oUser));
        }
    }
}
