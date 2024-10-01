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
    public partial class formVendors2 : Form
    {
        public formVendors2()
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
        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            abrirHerencia(new formSales());
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            abrirHerencia(new formVendors());
        }

        private void panel1_Resize(object sender, EventArgs e)
        {


            if (this.ClientSize.Width > 1000 && this.ClientSize.Height > 700)
            {
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                panel_add.Left = this.ClientSize.Width - panel_add.Width;
                panel_footer.Left = this.ClientSize.Width - panel_footer.Width;
                btn_back.Width = 150;
                btn_back.Left = this.ClientSize.Width - btn_back.Width;
            }
            else
            {
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                panel_add.Left = this.ClientSize.Width - panel_add.Width;
                panel_footer.Left = this.ClientSize.Width - panel_footer.Width;
                btn_back.Left = this.ClientSize.Width - btn_back.Width;
            }
        }

        private void btn_viewvendedor_Click(object sender, EventArgs e)
        {
            abrirHerencia(new formVendors());
        }
    }
}
