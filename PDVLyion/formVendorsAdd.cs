using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using BusinessLayer;
using PDCLyion.Resources;
using static System.Windows.Forms.AxHost;

namespace PDCLyion
{

    public partial class formVendorsAdd : Form
    {
        private static Users oUser = new Users();
        private Vendors Vendor;
        private Vendors Old_vendor;

        public formVendorsAdd()
        {
            InitializeComponent();
            Vendor = new Vendors();
        }

        public formVendorsAdd(Vendors vendor)
        {
            InitializeComponent();
            Vendor = vendor;
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
            abrirHerencia(new Start(oUser));
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

        private void formVendors2_Load(object sender, EventArgs e)
        {
            if (Vendor.Vendor_id == 0)
            {
                cbo_state.Visible = false;
                lbl_state.Visible = false;
            }
            cbo_state.Items.Add(new OpcionCombo() { Value = 1, Text = "Activo" });
            cbo_state.Items.Add(new OpcionCombo() { Value = 0, Text = "Inactivo" });
            cbo_state.DisplayMember = "Text";
            cbo_state.ValueMember = "Value";

            if(Vendor.Vendor_id != 0)
            {
                int cbo_state_index = 0;
                txt_vendor_id.Texts = Vendor.Vendor_id.ToString();
                txt_cuit.Texts = Vendor.Cuit;
                txt_company_name.Texts = Vendor.Company_name;
                txt_email.Texts = Vendor.Email;
                txt_phone.Texts = Vendor.Phone;
                foreach (OpcionCombo opcion_estado in cbo_state.Items)
                {
                    if (Convert.ToInt32(opcion_estado.Value) == (Vendor.State == true ? 1 : 0))
                    {
                        cbo_state_index = cbo_state.Items.IndexOf(opcion_estado);
                        break;
                    }
                }
                cbo_state.SelectedIndex = cbo_state_index;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            if (Convert.ToInt32(txt_vendor_id.Texts) == 0)
            {
                Vendor = new Vendors()
                {
                    Cuit = txt_cuit.Texts,
                    Company_name = txt_company_name.Texts,
                    Email = txt_email.Texts,
                    Phone = txt_phone.Texts,
                };
                int created_vendor_id = new BL_Vendors().Create(Vendor, out message);
                if (created_vendor_id == 0)
                {
                    MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Proveedor generado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                Old_vendor = new Vendors();
                Old_vendor.Vendor_id = Vendor.Vendor_id;
                Old_vendor.Cuit = Vendor.Cuit;
                Old_vendor.Email = Vendor.Email;
                Old_vendor.Phone = Vendor.Phone;
                Old_vendor.State = Vendor.State;
                Vendor.Cuit = txt_cuit.Texts;
                Vendor.Company_name = txt_company_name.Texts;
                Vendor.Email = txt_email.Texts;
                Vendor.Phone = txt_phone.Texts;
                Vendor.State = Convert.ToInt32(((OpcionCombo)cbo_state.SelectedItem).Value) == 1 ? true : false;
                bool result = false;
                result = new BL_Vendors().Update(Vendor, out message);
                if (result == false)
                {
                    MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Proveedor actualizado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
