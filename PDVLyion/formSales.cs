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
    public partial class formSales : Form
    {
        public formSales()
        {
            InitializeComponent();
        }

        private void formSales_Resize(object sender, EventArgs e)
        {
            if (this.ClientSize.Width > 1000 && this.ClientSize.Height > 700)
            {
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
        }

        private void btn_hamb_Click(object sender, EventArgs e)
        {

        }
    }
}
