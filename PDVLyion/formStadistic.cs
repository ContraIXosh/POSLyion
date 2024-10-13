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
    public partial class formStadistic : Form
    {
        private static Users oUser = new Users();
        public formStadistic()
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
        private void rjButton4_Click(object sender, EventArgs e)
        {

        }

        private void rjButton4_Click_1(object sender, EventArgs e)
        {
            abrirHerencia(new Start(oUser));
            this.panel_izq.Hide();
        }

        private void btn_hamb_Click(object sender, EventArgs e)
        {
            menu_Main.Show(btn_hamb, btn_hamb.Width, 0);
        }

        private void btn_Down_Click(object sender, EventArgs e)
        {
            menu_sesion.Show(btn_Down, btn_Down.Width, 0);
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirHerencia(new Start(oUser));
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirHerencia(new formPurchaseOrders(oUser));
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            abrirHerencia(new Start(oUser));
        }
    }
}
