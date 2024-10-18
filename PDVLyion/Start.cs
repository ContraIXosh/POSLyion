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
            panel_resumen.Controls.Clear();
            ListBox lstProductos = new ListBox();
            lstProductos.Items.Add("Producto 1 - $10");
            lstProductos.Items.Add("Producto 2 - $20");
            panel_resumen.Controls.Add(lstProductos);
        }

        private void mostrarHistorialBuy()
        {
            panel_resumen.Controls.Clear();
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
            panel_resumen.Controls.Add(dgvCompra);

            dgvCompra.Columns.Add("Fecha", "Fecha");
            dgvCompra.Columns.Add("Producto", "Producto");
            dgvCompra.Columns.Add("Precio", "Precio");

            dgvCompra.Rows.Add("01/10/2024", "Producto A", "$15");
            dgvCompra.Rows.Add("02/10/2024", "Producto B", "$25");

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


        private void dgv_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                    decimal total = 0;
            if (e.RowIndex >= 0)
            {
                // Obtiene el nombre y el código del producto seleccionado
                string desc = dgv_productos.Rows[e.RowIndex].Cells["dgv_desc"].Value.ToString();
                string precio = dgv_productos.Rows[e.RowIndex].Cells["dgv_precio"].Value.ToString();

                // Verifica si el producto ya está en el dgv_resumen
                bool productoExiste = false;
                foreach (DataGridViewRow row in dgv_resumen.Rows)
                {
                    if (row.Cells["precio"].Value != null)
                    {
                        total += Convert.ToDecimal(row.Cells["precio"].Value);
                    }

                    if (row.Cells["desc"].Value != null && row.Cells["desc"].Value.ToString() == desc)
                    {
                        // Si el producto ya existe, aumenta la cantidad en la misma fila
                        int cantidadActual = Convert.ToInt32(row.Cells["cantidad"].Value);
                        row.Cells["cantidad"].Value = cantidadActual + 1;

                        decimal precioActual = Convert.ToDecimal(row.Cells["precio"].Value);
                        row.Cells["precio"].Value = precioActual + Convert.ToDecimal(precio);

                        productoExiste = true;
                        break;
                    }
                }

                // Si el producto no existe, lo agrega con cantidad inicial de 1
                if (!productoExiste)
                {
                    dgv_resumen.Rows.Add(new object[] { desc, 1, precio });
                }
            }
                        lbl_dinero.Text = "$" + total.ToString("0.00");

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
        private void btn_factura_Click_1(object sender, EventArgs e)
        {
            dgv_resumen.Columns.Clear();
            dgv_resumen.Columns.Add("desc", "Producto");
            dgv_resumen.Columns.Add("cantidad", "Cantidad");
            dgv_resumen.Columns.Add("precio", "Precio");
            dgv_resumen.Dock = DockStyle.Fill;
            dgv_resumen.Visible = true;
        }

        private void btn_compra_Click_1(object sender, EventArgs e)
        {
            dgv_resumen.Columns.Clear();
            dgv_resumen.Columns.Add("fecha", "Fecha");
            dgv_resumen.Columns.Add("hora", "Hora");
            dgv_resumen.Columns.Add("empresa", "Empresa");
            dgv_resumen.Columns.Add("cantidad", "Cantidad");

            DataGridView dgv_ampliar = new DataGridView();

            dgv_ampliar.Columns.Clear();
            dgv_ampliar.Columns.Add("prod", "Producto");
            dgv_ampliar.Columns.Add("cantidad", "Cantidad");
            dgv_ampliar.Columns.Add("precio", "Precio");

            dgv_ampliar.Visible = true;
            dgv_ampliar.Dock = DockStyle.Fill;
            dgv_resumen.Visible = true;
            dgv_resumen.Dock = DockStyle.Fill;

            panel_container.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panel_container.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            panel_container.Controls.Add(dgv_resumen, 0, 0);
            panel_container.Controls.Add(dgv_ampliar, 0, 1);

        }
    }
}
