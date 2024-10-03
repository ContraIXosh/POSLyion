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
    public partial class formProducts2 : Form
    {

        private Products Product;
        private Products Old_product;

        public formProducts2()
        {
            Product = new Products();
            InitializeComponent();
        }

        public formProducts2(Products product)
        {
            Product = product;
            InitializeComponent();
        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_cod.Text) || string.IsNullOrEmpty(txt_desc.Text) || string.IsNullOrEmpty(txt_precio.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else{
                MessageBox.Show("Se guardo el producto con exito", "¡Guardado exitoso!", MessageBoxButtons.OK);
            }

            
            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_cod__TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_cod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
                MessageBox.Show("Ingrese solo numeros");
            }
        }

        private void txt_cod2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { 
                e.Handled = true;
                MessageBox.Show("Por favor, solo introduzca números.", "Valor desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txt_desc__TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
                MessageBox.Show("Por favor, solo introduzca números.", "Valor desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_costo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
                MessageBox.Show("Por favor, solo introduzca números.", "Valor desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_ganancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
                MessageBox.Show("Por favor, solo introduzca números.", "Valor desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
                MessageBox.Show("Por favor, solo introduzca números.", "Valor desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_precio2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
                MessageBox.Show("Por favor, solo introduzca números.", "Valor desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_descuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
                MessageBox.Show("Por favor, solo introduzca números.", "Valor desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cb_active_CheckedChanged(object sender, EventArgs e)
        {
            cb_active.Checked = true;
        }

        private void formProducts2_Load(object sender, EventArgs e)
        {
            List<ProductCategories> productcategories = new BL_ProductCategories().ListAll();
            foreach (ProductCategories productcategory in productcategories)
            {
                cbox_tipo.Items.Add(new OpcionCombo() { Value = productcategory.Product_category_id, Text = productcategory.Description });
            }
            cbox_tipo.DisplayMember = "Text";
            cbox_tipo.ValueMember = "Value";

            //cbo_estado.Items.Add(new OpcionCombo() { Value = 1, Text = "Activo" });
            //cbo_estado.Items.Add(new OpcionCombo() { Value = 0, Text = "Inactivo" });
            //cbo_estado.DisplayMember = "Text";
            //cbo_estado.ValueMember = "Value";

            txt_id.Texts = Product.Product_id.ToString();
            txt_cod.Texts = Product.Bar_code;
            txt_cant.Texts = Product.Current_stock.ToString();
            txt_desc.Texts = Product.Description;
            txt_costo.Texts = Product.Cost_price.ToString();
            txt_precio.Texts = Product.Sale_price.ToString();

            int cbox_tipo_index = 0;
            //int cbo_estado_index = 0;

            if (Convert.ToInt32(txt_id.Texts) == 0)
            {
                cbox_tipo.SelectedIndex = 0;
                //cbo_rol.SelectedIndex = 0;
            }
            else
            {
                //foreach (OpcionCombo opcion_estado in cbo_estado.Items)
                //{
                //    if (Convert.ToInt32(opcion_estado.Value) == (User.State == true ? 1 : 0))
                //    {
                //        cbo_estado_index = cbo_estado.Items.IndexOf(opcion_estado);
                //        break;
                //    }
                //}
                //cbo_estado.SelectedIndex = cbo_estado_index;

                foreach (OpcionCombo opcion_categoria in cbox_tipo.Items)
                {
                    if (Convert.ToInt32(opcion_categoria.Value) == Product.oProductCategory.Product_category_id)
                    {
                        cbox_tipo_index = cbox_tipo.Items.IndexOf(opcion_categoria);
                        break;
                    }
                }
                cbox_tipo.SelectedIndex = cbox_tipo_index;
            }
        }
    }
}
