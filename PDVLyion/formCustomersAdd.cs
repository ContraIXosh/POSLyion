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
        private Customers Old_Customer;

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

        private void formCustomersAdd_Load(object sender, EventArgs e)
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

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            if (Convert.ToInt32(txt_id.Texts) == 0)
            {
                Customers customer = new Customers()
                {
                    Dni = txt_dni.Texts,
                    Full_name = txt_nombre_completo.Texts,
                    Email = txt_correo.Texts,
                    Phone = txt_tel.Texts,
                };
                int created_customer_id = new BL_Customers().Create(customer, out message);
                if (created_customer_id == 0)
                {
                    MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Cliente generado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                Old_Customer = new Customers();
                Old_Customer.Customer_id = Customer.Customer_id;
                Old_Customer.Dni = Customer.Dni;
                Old_Customer.Full_name = Customer.Full_name;
                Old_Customer.Email = Customer.Email;
                Old_Customer.Phone = Customer.Phone;
                Old_Customer.State = Customer.State;
                Customer.Dni = txt_dni.Texts;
                Customer.Full_name = txt_nombre_completo.Texts;
                Customer.Email = txt_correo.Texts;
                Customer.Phone = txt_tel.Texts;
                Customer.State = Convert.ToInt32(((OpcionCombo)cbo_estado.SelectedItem).Value) == 1 ? true : false;
                bool result = false;
                result = new BL_Customers().Update(Customer, out message);
                if (result == false)
                {
                    MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Cliente actualizado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
