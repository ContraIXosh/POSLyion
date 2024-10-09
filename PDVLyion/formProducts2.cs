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
        private static Users oUser = new Users();

        public formProducts2(Users user)
        {
            Product = new Products();
            InitializeComponent();
            oUser = user;
        }

        public formProducts2(Products product, Users user)
        {
            Product = product;
            oUser = user;
            InitializeComponent();
        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string message = String.Empty;
            if(Convert.ToInt32(txt_id.Texts) == 0)
            {
                int created_product_id = 0;
                Product = new Products()
                {
                    Bar_code = txt_cod.Texts,
                    Description = txt_desc.Texts,
                    oProductCategory = new ProductCategories()
                    {
                        Product_category_id = Convert.ToInt32(((OpcionCombo)cbox_tipo.SelectedItem).Value)
                    },
                    Cost_price = Convert.ToDecimal(txt_costo.Texts),
                    Sale_price = Convert.ToDecimal(txt_precio.Texts),
                    Current_stock = Convert.ToInt32(txt_cant.Texts),
                    Minimum_stock = Convert.ToInt32(txt_cant_min.Texts),
                };
                created_product_id = new BL_Products().Create(Product, out message);
                if (created_product_id == 0)
                {
                    MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Producto generado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                bool result = false;
                Old_product = new Products();
                Old_product.Product_id = Product.Product_id;
                Old_product.Bar_code = Product.Bar_code;
                Old_product.Description = Product.Description;
                Old_product.oProductCategory = new ProductCategories() { Product_category_id = Product.oProductCategory.Product_category_id };
                Old_product.Cost_price = Product.Cost_price;
                Old_product.Sale_price = Product.Sale_price;
                Old_product.Current_stock = Product.Current_stock;
                Old_product.Minimum_stock = Product.Minimum_stock;
                Old_product.State = Product.State;
                Product.Bar_code = txt_cod.Texts;
                Product.Description = txt_desc.Texts;
                Product.oProductCategory.Product_category_id = Convert.ToInt32(((OpcionCombo)cbox_tipo.SelectedItem).Value);
                Product.Cost_price = Convert.ToDecimal(txt_costo.Texts);
                Product.Sale_price = Convert.ToDecimal(txt_precio.Texts);
                Product.Current_stock = Convert.ToInt32(txt_cant.Texts);
                Product.Minimum_stock = Convert.ToInt32(txt_cant_min.Texts);
                Product.State = Convert.ToBoolean(((OpcionCombo)cbox_estado.SelectedItem).Value);
                result = new BL_Products().Update(Product, out message);
                if (result == false)
                {
                    MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Producto actualizado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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

        private void formProducts2_Load(object sender, EventArgs e)
        {
            if(Convert.ToInt32(Product.Product_id) == 0)
            {
                cbox_estado.Visible = false;
                lbl_estado.Visible = false;
            }
            List<ProductCategories> productcategories = new BL_ProductCategories().ListAll();
            foreach (ProductCategories productcategory in productcategories)
            {
                cbox_tipo.Items.Add(new OpcionCombo() { Value = productcategory.Product_category_id, Text = productcategory.Description });
            }
            cbox_tipo.DisplayMember = "Text";
            cbox_tipo.ValueMember = "Value";

            cbox_estado.Items.Add(new OpcionCombo() { Value = 1, Text = "Activo" });
            cbox_estado.Items.Add(new OpcionCombo() { Value = 0, Text = "Inactivo" });
            cbox_estado.DisplayMember = "Text";
            cbox_estado.ValueMember = "Value";

            txt_id.Texts = Product.Product_id.ToString();
            txt_cod.Texts = Product.Bar_code;
            txt_cant.Texts = Product.Current_stock.ToString();
            txt_cant_min.Texts = Product.Minimum_stock.ToString();
            txt_desc.Texts = Product.Description;
            txt_costo.Texts = Product.Cost_price.ToString();
            txt_precio.Texts = Product.Sale_price.ToString();

            int cbox_tipo_index = 0;
            int cbox_estado_index = 0;

            if (Convert.ToInt32(txt_id.Texts) == 0)
            {
                cbox_tipo.SelectedIndex = 0;
                cbox_tipo.SelectedIndex = 0;
            }
            else
            {
                foreach (OpcionCombo opcion_estado in cbox_estado.Items)
                {
                    if (Convert.ToInt32(opcion_estado.Value) == (Product.State == true ? 1 : 0))
                    {
                        cbox_estado_index = cbox_estado.Items.IndexOf(opcion_estado);
                        break;
                    }
                }
                cbox_estado.SelectedIndex = cbox_estado_index;

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
