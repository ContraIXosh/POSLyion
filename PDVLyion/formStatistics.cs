using OxyPlot;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Serialization;

namespace PDCLyion
{
    public partial class formStatistics : Form
    {
        public formStatistics()
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

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_grafico_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_grafico_Click(object sender, EventArgs e)
        {
         

            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            abrirHerencia(new formSales());
        }
    }
}
