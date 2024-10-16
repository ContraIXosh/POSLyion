using BusinessLayer;
using EntityLayer;
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
    public partial class Start : Form
    {
        string connectionString = "Data Source = ; Initial Catalog = POSLyion; Integrated Security = True";
        private static ToolStripMenuItem activeMenu = null;
        private static Form activeForm = null;
        private static Users oUser = new Users();
        public Start()
        {
        InitializeComponent();
        }

        public Start(Users user)
        {
            InitializeComponent();
            oUser = user;
            lbl_usuario.Text = user.Full_name;
        }
        List<Producto> productos = new List<Producto>
        {
            new Producto {}

        };
        private class Producto
        {
            public int id { get; set; }
            public string name { get; set; }
            public decimal precio { get; set; }

        }

        private void cargarProd()
        {
            dgv_productos.DataSource = productos;
        }

        private void RemoverStripMenu()
        {
            foreach (Control control in this.Controls)
            {
                if (control is MenuStrip)
                {
                    this.Controls.Remove(control); 
                }
            }
        }

        private void abrirHerencia(ToolStripMenuItem menu, Form fh)
        {

            if (panel_main.Controls.Count > 0)
                panel_main.Controls.RemoveAt(0);

            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;

            panel_main.Controls.Add(fh);
            panel_main.Tag = fh;
            fh.Show();
        }


        private void btn_compra_Click(object sender, EventArgs e)
        {
            lbl_titulo.Text = "Facturación";
            MostrarFacturacion();
        }

        private void btn_factura_Click(object sender, EventArgs e)
        {
            lbl_titulo.Text = "Historial de compra";
            mostrarHistorialSell();
        }

        private void btn_venta_Click(object sender, EventArgs e)
        {
            lbl_titulo.Text = "Historial de ventas";
            mostrarHistorialSell();
        }

        private void btn_cfinal_Click(object sender, EventArgs e)
        {
            lbl_tipoticket.Text = "CONSUMIDOR FINAL";
            btn_cfinal.ForeColor = Color.White;
            btn_cfinal.BackColor = Color.BlueViolet;
            btn_cfinal.Enabled = false;
            if (btn_eventual.Enabled == false)
            {
                btn_cfinal.ForeColor = Color.White;
                btn_cfinal.BackColor = Color.BlueViolet;
                btn_eventual.Enabled = true;
            }
        }

        private void btn_eventual_Click(object sender, EventArgs e)
        {
            lbl_tipoticket.Text = "EVENTUAL";
            btn_eventual.ForeColor = Color.White;
            btn_eventual.BackColor = Color.DarkMagenta;
            btn_eventual.Enabled = false;
            if (btn_cfinal.Enabled == false)
            {
                btn_eventual.ForeColor = Color.White;
                btn_eventual.BackColor = Color.DarkMagenta;
                btn_cfinal.Enabled = true;
            }
        }
        private void MostrarFacturacion()
        {
            panel_container.Controls.Clear();
            ListBox lstProductos = new ListBox();
            lstProductos.Items.Add("Producto 1 - $10");
            lstProductos.Items.Add("Producto 2 - $20");
            panel_container.Controls.Add(lstProductos);
        }

        private void mostrarHistorialBuy()
        {
            panel_container.Controls.Clear();
            DataGridView dgvCompra = new DataGridView();


        }
        private void mostrarHistorialSell()
        {
            float precio = 0;
            float total = precio;

            if (precio > 0)
            {

            }
            DataGridView dgvCompra = new DataGridView();
            dgvCompra.Columns.Add("Hora", "Hora");
            dgvCompra.Columns.Add("Precio", "Precio");
            dgvCompra.Columns.Add("Productos", "Productos");
            dgvCompra.Columns.Add("Fecha", "Fecha");
            dgvCompra.Rows.Add("16:52:16", "$1620", "Last product", "10/02/2025");
            dgvCompra.Rows.Add("16:53:42", "$1920", "Last product", "10/02/2025");
            panel_container.Controls.Add(dgvCompra);

            dgvCompra.Columns.Add("Fecha", "Fecha");
            dgvCompra.Columns.Add("Producto", "Producto");
            dgvCompra.Columns.Add("Precio", "Precio");

            dgvCompra.Rows.Add("01/10/2024", "Producto A", "$15");
            dgvCompra.Rows.Add("02/10/2024", "Producto B", "$25");
            panel_container.Controls.Add(dgvCompra, 0, 0);

            DataGridView dgvAmpliar = new DataGridView();
            dgvCompra.Columns.Add("Fecha", "Fecha");
            dgvCompra.Columns.Add("Producto", "Producto");
            dgvCompra.Columns.Add("Cantidad", "Cantidad");
            dgvCompra.Columns.Add("Precio", "precio");
            dgvCompra.Rows.Add("01/10/2024", "Salsa golf LC", "8", precio = 3999);
            dgvCompra.Rows.Add("01/10/2024", "Heineken lata 473", "6", precio = 124);
            dgvCompra.Rows.Add("01/10/2024", "Amstel lata 473", "15", precio = 15);
            dgvCompra.Rows.Add("Total =", total);
        }

        private void txt_buscarproductos_TextChanged(object sender, EventArgs e)
        {
            dgv_productos.Rows.Clear();
            if (txt_buscarproductos.Text != "")
            {
                DataTable products_table = new BL_Products().Search(txt_buscarproductos.Text);
                foreach (DataRow row in products_table.Rows)
                {
                    dgv_productos.Rows.Add(new object[]
                    {
                row["ID"],
                row["Descripcion"],
                row["Precio"],
                row["Stock actual"]
                    });
                }
            }
        }
        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoverStripMenu();
            abrirHerencia((ToolStripMenuItem)sender, new Start(oUser));
        }

        private void comprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formPurchaseOrders compras = new formPurchaseOrders(oUser);
            compras.Show();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            abrirHerencia(tsmenu_prods, new formProducts());
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            abrirHerencia(tsmenu_users, new formUsers());
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            abrirHerencia(tsmenu_clientes, new formCustomers());
        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            abrirHerencia(tsmenu_proveedor, new formVendors());
        }

        private void reportesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            abrirHerencia(tsmenu_reports, new formStadistic());
        }

        private void categoriasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            abrirHerencia(tsmenu_cat, new formCat());
        }

        private void configuraciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            abrirHerencia(tsmenu_config, new formConfig());
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formLogOut logout = new formLogOut();
            logout.Show();
        }

    }
}
