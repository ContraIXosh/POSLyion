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
    }
}
