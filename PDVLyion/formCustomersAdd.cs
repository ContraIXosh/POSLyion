using BusinessLayer;
using EntityLayer;
using PDCLyion.Resources;
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
    public partial class formCustomersAdd : Form
    {
        private static Users oUser = new Users();
        private Customers Customer;

        public formCustomersAdd()
        {
            InitializeComponent();
            Customer = new Customers();
        }

        public formCustomersAdd(Customers customer)
        {
            InitializeComponent();
            Customer = customer;
        }

        private void abrirHerencia(Form formhija)
        {
            this.panel_main.Controls.Clear();
            formhija.TopLevel = false;
            formhija.FormBorderStyle = FormBorderStyle.None;
            formhija.Dock = DockStyle.Fill;

            panel_main.Controls.Add(formhija);
            formhija.Show();
        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_viewvendedor_Click(object sender, EventArgs e)
        {
            abrirHerencia(new formCustomers());
        }

        private void panel_footer_Resize(object sender, EventArgs e)
        {
            
        }

        private void btn_addvendedor_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            abrirHerencia(new Start(oUser));
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            abrirHerencia(new Start(oUser));
        }

        private void panel_footer_Resize_1(object sender, EventArgs e)
        {
            if (this.ClientSize.Width > 1000 && this.ClientSize.Height > 700)
            {
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            }
            else
            {
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            }
        }

        private void btn_addvendedor_Click_1(object sender, EventArgs e)
        {
        }

        private void btn_viewvendedor_Click_1(object sender, EventArgs e)
        {
            abrirHerencia(new formCustomers());
        }

        private void formCustomers2_Load(object sender, EventArgs e)
        {
            cbo_estado.Items.Add(new OpcionCombo() { Value = 1, Text = "Activo" });
            cbo_estado.Items.Add(new OpcionCombo() { Value = 0, Text = "Inactivo" });
            cbo_estado.DisplayMember = "Text";
            cbo_estado.ValueMember = "Value";

            txt_id.Texts = Customer.Customer_id.ToString();
            txt_nombre_completo.Texts = Customer.Full_name;
            txt_correo.Texts = Customer.Email;
            txt_dni.Texts = Customer.Dni;
            txt_tel.Texts = Customer.Phone;
            int cbo_estado_index = 0;

            if (Convert.ToInt32(txt_id.Texts) == 0)
            {
                cbo_estado.SelectedIndex = 0;
            }
            else
            {
                foreach (OpcionCombo opcion_estado in cbo_estado.Items)
                {
                    if (Convert.ToInt32(opcion_estado.Value) == (Customer.State == true ? 1 : 0))
                    {
                        cbo_estado_index = cbo_estado.Items.IndexOf(opcion_estado);
                        break;
                    }
                }
                cbo_estado.SelectedIndex = cbo_estado_index;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
