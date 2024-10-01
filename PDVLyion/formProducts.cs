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
    public partial class formProducts : Form
    {
        public formProducts()
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
        private void btn_back_Click(object sender, EventArgs e)
        {
            abrirHerencia(new formSales());
        }

        private void btn_addprod_Click(object sender, EventArgs e)
        {
            formProducts2 crearprod = new formProducts2();

            crearprod.Show();
        }
    }
}
