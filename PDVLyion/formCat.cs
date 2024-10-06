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

namespace PDCLyion
{
    public partial class formCat : Form
    {
        public formCat()
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

        private void formCat_Load(object sender, EventArgs e)
        {
            List<ProductCategories> product_categories_list = new BL_ProductCategories().CountProducts();
            foreach(ProductCategories product_category in product_categories_list)
            {
                grid_category.Rows.Add(new object[]
                {
                    product_category.Product_category_id,
                    product_category.Description,
                    product_category.Quantity
                });
            }
        }

        private void grid_category_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (grid_category.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                if (index >= 0)
                {
                    int cbo_estado_index = 0;
                    txt_category.Texts = grid_category.Rows[index].Cells["name_category"].Value.ToString();
                    txt_id.Texts = grid_category.Rows[index].Cells["id_cat"].Value.ToString();
                }
            }
            else if (grid_category.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {
                if (MessageBox.Show("¿Desea eliminar la categoría?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (index >= 0)
                    {
                        string message = string.Empty;
                        ProductCategories product_category = new ProductCategories()
                        {
                            Product_category_id = Convert.ToInt32(grid_category.Rows[index].Cells["id_cat"].Value)
                        };
                        bool result = new BL_ProductCategories().Delete(product_category, out message);
                        if (!result)
                        {
                            MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("Categoría eliminado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            abrirHerencia(new formCat());
                        }
                    }
                }
            }
        }

        private void btn_add_category_Click(object sender, EventArgs e)
        {
            ProductCategories product_categories = new ProductCategories();
            string message = string.Empty;
            if (Convert.ToInt32(txt_id.Texts) == 0)
            {
                
                product_categories.Description = txt_category.Texts;
                int created_productcategory_id = new BL_ProductCategories().Create(product_categories, out message);
                if(created_productcategory_id == 0)
                {
                    MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Categoría creada con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    abrirHerencia(new formCat());
                }
            }
            else
            {
                product_categories.Product_category_id = Convert.ToInt32(txt_id.Texts);
                product_categories.Description = txt_category.Texts;
                bool result = false;
                result = new BL_ProductCategories().Update(product_categories, out message);
                if (result == false)
                {
                    MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Categoría actualizada con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    abrirHerencia(new formCat());
                }
            }
        }
    }
}
