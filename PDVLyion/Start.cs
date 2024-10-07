using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using EntityLayer;
using BusinessLayer;
using System.Data.SqlClient;

namespace PDCLyion
{
    public partial class Start : Form
    {
        string connectionString = "Data Source = ; Initial Catalog = POSLyion; Integrated Security = True";
        private static IconMenuItem activeMenu = null;
        private static Form activeForm = null;
        private static Users oUser = new Users();

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
        private void abrirHerencia(object formhija)
        {
           if(this.panel_main.Controls.Count > 0)
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


        private void Start_Load(object sender, EventArgs e)
        {
            List<Permissions> permissions_list = new BL_Permissions().Read(oUser.User_id);
            foreach(ToolStripMenuItem menu in menu_Main.Items)
            {
                bool found = permissions_list.Any(m => m.Menu_name == menu.Name);
                if (!found)
                {
                    menu.Visible = false;
                }
            }
        }

        private void mostrarHistorialSell()
        {
            float precio = 0;
            float total = precio;

            if (precio > 0) { 
                
            }
            panel_container.Controls.Clear();
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
            panel_container.Controls.Add(dgvCompra, 0,0);

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

        private void MostrarFacturacion()
        {
            panel_container.Controls.Clear(); 
            ListBox lstProductos = new ListBox();
            lstProductos.Items.Add("Producto 1 - $10");
            lstProductos.Items.Add("Producto 2 - $20");
            panel_container.Controls.Add(lstProductos); 
        }

        private void mostrarHistorialBuy() {
            panel_container.Controls.Clear();
            DataGridView dgvCompra = new DataGridView();
            

        }

     

        private void panel1_DockChanged(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirHerencia(new formSales());
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPurchaseOrders crearfactura = new formPurchaseOrders(oUser);

            crearfactura.Show(); ;
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirHerencia(new formProducts());
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirHerencia(new formUsers2());
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirHerencia(new formCustomers());
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

        private void Start_Resize(object sender, EventArgs e)
        {

            if(this.ClientSize.Width > 1000 && this.ClientSize.Height >  700) {
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            panel_right.Width = 500;
            panel_right.Height = 860;
            panel_right.Left = this.ClientSize.Width - panel_right.Width;


            }
            else
            {
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                panel_right.Width = 280;
                panel_right.Height = 455;
                panel_right.Left = this.ClientSize.Width - panel_right.Width;
            }
        }

        private void btn_Down_Click(object sender, EventArgs e)
        {
            menu_sesion.Show(btn_Down, btn_Down.Width, 0);
        }

        private void btn_hamb_Click_1(object sender, EventArgs e)
        {
            menu_Main.Show(btn_hamb, btn_hamb.Width, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl_titulo.Text = "Historial de compras";
            mostrarHistorialBuy();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_titulo.Text = "Facturación"; 
            MostrarFacturacion();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbl_titulo.Text = "Historial de ventas";
            mostrarHistorialSell();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirHerencia(new formCat());
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

        private void btn_cobrar_Click(object sender, EventArgs e)
        {
            formCambio closeventa = new formCambio();

            closeventa.Show();
        }
        private void btn_cerrarventa_Click(object sender, EventArgs e)
        {
            formCambio closeventa = new formCambio();

            closeventa.Show();
        }

        private void txt_buscarproductos_TextChanged(object sender, EventArgs e)
        {
            if (txt_buscarproductos.Text == "")
            {
                dgv_productos.DataSource = null;
            }
            else
            {
                DataTable dataTable = new BL_Products().Search(txt_buscarproductos.Text);
                dgv_productos.DataSource = dataTable;
                dgv_productos.Columns["ID"].Visible = false;
            }
        }
    }
}
