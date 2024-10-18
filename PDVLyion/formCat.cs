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

        private void formCat_Load(object sender, EventArgs e)
        {
            List<ProductCategories> product_categories_list = new BL_ProductCategories().CountProducts();
            foreach(ProductCategories product_category in product_categories_list)
            {
                grid_categoria.Rows.Add(new object[]
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
            if (grid_categoria.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                if (index >= 0)
                {
                    txt_categorynew.Texts = grid_categoria.Rows[index].Cells["name"].Value.ToString();
                    txt_id.Texts = grid_categoria.Rows[index].Cells["id"].Value.ToString();
                }
            }
            else if (grid_categoria.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {
                if (MessageBox.Show("¿Desea eliminar la categoría?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (index >= 0)
                    {
                        string message = string.Empty;
                        ProductCategories product_category = new ProductCategories()
                        {
                            Product_category_id = Convert.ToInt32(grid_categoria.Rows[index].Cells["id_cat"].Value)
                        };
                        bool result = new BL_ProductCategories().Delete(product_category, out message);
                        if (!result)
                        {
                            MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("Categoría eliminado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
        }

        private void btn_crear_categoria_Click(object sender, EventArgs e)
        {
            ProductCategories product_categories = new ProductCategories();
            string message = string.Empty;
            if (Convert.ToInt32(txt_id.Texts) == 0)
            {

                product_categories.Description = txt_categorynew.Texts;
                int created_productcategory_id = new BL_ProductCategories().Create(product_categories, out message);
                if (created_productcategory_id == 0)
                {
                    MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Categoría creada con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                product_categories.Product_category_id = Convert.ToInt32(txt_id.Texts);
                product_categories.Description = txt_categorynew.Texts;
                bool result = false;
                result = new BL_ProductCategories().Update(product_categories, out message);
                if (result == false)
                {
                    MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Categoría actualizada con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            grid_categoria.Rows.Clear();
            List<ProductCategories> product_categories_list = new BL_ProductCategories().CountProducts();
            foreach (ProductCategories product_category in product_categories_list)
            {
                grid_categoria.Rows.Add(new object[]
                {
                    product_category.Product_category_id,
                    product_category.Description,
                    product_category.Quantity
                });
            }
        }
    }
}
