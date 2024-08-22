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

namespace PDCLyion
{
    public partial class Start : Form
    {

        private static IconMenuItem activeMenu = null;
        private static Form activeForm = null;

        public Start()
        {
            InitializeComponent();
        }

        private void OpenForm (IconMenuItem iconmenuitem, Form form)
        {
            if (activeMenu != null)
            {
                activeMenu.BackColor = Color.White;
            }
            iconmenuitem.BackColor = Color.Silver;
            activeMenu = iconmenuitem;
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            container.Controls.Add(form);
            form.Show();
        }

        private void iconmenuitem_sales_Click(object sender, EventArgs e)
        {
            OpenForm((IconMenuItem)sender, new formSales());
        }

        private void iconmenuitem_purchaseorders_Click(object sender, EventArgs e)
        {
            OpenForm((IconMenuItem)sender, new formPurchaseOrders());
        }

        private void iconmenuitem_products_Click(object sender, EventArgs e)
        {
            OpenForm((IconMenuItem)sender, new formProducts());
        }

        private void iconmenuitem_users_Click(object sender, EventArgs e)
        {
            OpenForm((IconMenuItem)sender, new formUsers());
        }

        private void iconmenuitem_customers_Click(object sender, EventArgs e)
        {
            OpenForm((IconMenuItem)sender, new formCustomers());
        }

        private void iconmenuitem_vendors_Click(object sender, EventArgs e)
        {
            OpenForm((IconMenuItem)sender, new formVendors());
        }

        private void iconmenuitem_statistics_Click(object sender, EventArgs e)
        {
            OpenForm((IconMenuItem)sender, new formStatistics());
        }

        private void iconmenuitem_config_Click(object sender, EventArgs e)
        {
            OpenForm((IconMenuItem)sender, new formConfig());
        }
    }
}
