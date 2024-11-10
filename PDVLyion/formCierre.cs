using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PDCLyion
{
    public partial class formCierre : Form
    {
        private double[] valoresBilletes = { 10, 20, 50, 100, 200, 500, 1000, 2000, 10000};
        public formCierre()
        {
            InitializeComponent();
        }

        private void btn_cierre_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            ActualizarSumaTotal();
        }
        private void ActualizarSumaTotal()
        {
            double total = 0;
            TextBox[] textBoxes = new TextBox[] { txt_10, txt_20, txt_50, txt_100, txt_200, txt_500, txt_1mil, txt_2mil, txt_10mil };
            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (double.TryParse(textBoxes[i].Text, out double cantidad))
                {
                    total += cantidad * valoresBilletes[i];
                }
                lbl_sub.Text = total.ToString();
            }
        }
        private void formCierre_Load(object sender, EventArgs e)
        {
            txt_10.TextChanged += new EventHandler(textBox_TextChanged); 
            txt_20.TextChanged += new EventHandler(textBox_TextChanged); 
            txt_50.TextChanged += new EventHandler(textBox_TextChanged); 
            txt_100.TextChanged += new EventHandler(textBox_TextChanged); 
            txt_200.TextChanged += new EventHandler(textBox_TextChanged); 
            txt_500.TextChanged += new EventHandler(textBox_TextChanged); 
            txt_1mil.TextChanged += new EventHandler(textBox_TextChanged); 
            txt_2mil.TextChanged += new EventHandler(textBox_TextChanged); 
            txt_10mil.TextChanged += new EventHandler(textBox_TextChanged);
        }
    }
}
