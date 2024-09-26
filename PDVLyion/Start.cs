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

namespace PDCLyion
{
    public partial class Start : Form
    {

        private static IconMenuItem activeMenu = null;
        private static Form activeForm = null;
        private static Users oUser = new Users();

        public Start(Users user)
        {
            InitializeComponent();
            oUser = user;
            lbl_usuario.Text = user.Full_name;
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

        private void OpenForm (IconMenuItem iconmenuitem, Form form)
        {
            
        }

        private void iconmenuitem_sales_Click(object sender, EventArgs e)
        {
        }

        private void iconmenuitem_purchaseorders_Click(object sender, EventArgs e)
        {
        }

        private void iconmenuitem_products_Click(object sender, EventArgs e)
        {
        }

        private void iconmenuitem_users_Click(object sender, EventArgs e)
        {
        }

        private void iconmenuitem_customers_Click(object sender, EventArgs e)
        {
        }

        private void iconmenuitem_vendors_Click(object sender, EventArgs e)
        {
        }

        private void iconmenuitem_statistics_Click(object sender, EventArgs e)
        {
        }

        private void iconmenuitem_config_Click(object sender, EventArgs e)
        {
        }

        private void panel1_DockChanged(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            menu_sesion.Show(btn_Down, btn_Down.Width, 0);
        }

        private void btn_hamb_Click(object sender, EventArgs e)
        {
            menu_Main.Show(btn_hamb, btn_hamb.Width, 0);
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirHerencia(new formSales());
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirHerencia(new formPurchaseOrders());
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
            abrirHerencia(new formStatistics());
        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirHerencia(new formConfig());
        }
    }
}
