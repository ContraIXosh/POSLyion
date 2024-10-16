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

        private void abrirHerencia(Form fh)
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
    }
}
