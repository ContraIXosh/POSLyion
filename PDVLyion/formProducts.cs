using BusinessLayer;
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
using System.Windows.Shapes;

namespace PDCLyion
{
    public partial class formProducts : Form
    {
        private static Users oUser = new Users();
        private List<Products> Products_list;

        public formProducts()
        {
            InitializeComponent();
            Products_list = new BL_Products().ListAll();
        }

        private void formProducts_Load(object sender, EventArgs e)
        {
            foreach (Products product in Products_list)
            {
                grid_productos.Rows.Add(new object[]
                {
                    "",
                    product.Product_id,
                    product.Bar_code,
                    product.Description,
                    product.oProductCategory.Product_category_id,
                    product.oProductCategory.Description,
                    product.Current_stock,
                    product.Minimum_stock,
                    product.Cost_price,
                    product.Sale_price,
                    product.State == true ? "Activo" : "Inactivo",
                    product.State == true ? 1 : 0
                });
            }
        }

        private void grid_prod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (grid_productos.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                if (index >= 0)
                {
                    Products product = new Products()
                    {
                        Product_id = Convert.ToInt32(grid_productos.Rows[index].Cells["product_id"].Value),
                        Bar_code = grid_productos.Rows[index].Cells["bar_code"].Value.ToString(),
                        Description = grid_productos.Rows[index].Cells["description"].Value.ToString(),
                        oProductCategory = new ProductCategories()
                        {
                            Product_category_id = Convert.ToInt32(grid_productos.Rows[index].Cells["product_category_id"].Value),
                            Description = grid_productos.Rows[index].Cells["category_description"].Value.ToString()
                        },
                        Current_stock = Convert.ToInt32(grid_productos.Rows[index].Cells["current_stock"].Value),
                        Minimum_stock = Convert.ToInt32(grid_productos.Rows[index].Cells["minimum_stock"].Value),
                        Cost_price = Convert.ToDecimal(grid_productos.Rows[index].Cells["cost_price"].Value),
                        Sale_price = Convert.ToDecimal(grid_productos.Rows[index].Cells["sale_price"].Value),
                        State = Convert.ToBoolean(grid_productos.Rows[index].Cells["state_value"].Value)
                    };
                    formProductsAdd frmproductsadd = new formProductsAdd(product);
                    frmproductsadd.Show();
                }
            }
            else if (grid_productos.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {
                if (MessageBox.Show("¿Desea eliminar el producto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (index >= 0)
                    {
                        string message = string.Empty;
                        Products product = new Products()
                        {
                            Product_id = Convert.ToInt32(grid_productos.Rows[index].Cells["product_id"].Value)
                        };
                        bool result = new BL_Products().Delete(product, out message);
                        if (!result)
                        {
                            MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("Producto eliminado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
        }

        private void cb_stock_CheckedChanged(object sender, EventArgs e)
        {
            grid_productos.Rows.Clear();
            if (cb_stock.Checked)
            {
                List<Products> products_list = new BL_Products()
                .ListAll()
                .Where(p => p.Current_stock > 0).ToList();
                foreach (Products product in products_list)
                {
                    grid_productos.Rows.Add(new object[]
                    {
                    "",
                    product.Product_id,
                    product.Bar_code,
                    product.Description,
                    product.oProductCategory.Product_category_id,
                    product.oProductCategory.Description,
                    product.Current_stock,
                    product.Minimum_stock,
                    product.Cost_price,
                    product.Sale_price,
                    product.State == true ? "Activo" : "Inactivo",
                    product.State == true ? 1 : 0
                    });
                }
            }
            else
            {
                foreach (Products product in Products_list)
                {
                    grid_productos.Rows.Add(new object[]
                    {
                    "",
                    product.Product_id,
                    product.Bar_code,
                    product.Description,
                    product.oProductCategory.Product_category_id,
                    product.oProductCategory.Description,
                    product.Current_stock,
                    product.Minimum_stock,
                    product.Cost_price,
                    product.Sale_price,
                    product.State == true ? "Activo" : "Inactivo",
                    product.State == true ? 1 : 0
                    });
                }
            }
        }

        private void cb_inactive_CheckedChanged(object sender, EventArgs e)
        {
            grid_productos.Rows.Clear();
            if (cb_inactive.Checked)
            {
                List<Products> products_list = new BL_Products().ListAll().Where(p => p.State == false).ToList();
                foreach (Products product in products_list)
                {
                    grid_productos.Rows.Add(new object[]
                    {
                    "",
                    product.Product_id,
                    product.Bar_code,
                    product.Description,
                    product.oProductCategory.Product_category_id,
                    product.oProductCategory.Description,
                    product.Current_stock,
                    product.Minimum_stock,
                    product.Cost_price,
                    product.Sale_price,
                    product.State == true ? "Activo" : "Inactivo",
                    product.State == true ? 1 : 0
                    });
                }
            }
            else
            {
                foreach (Products product in Products_list)
                {
                    grid_productos.Rows.Add(new object[]
                    {
                    "",
                    product.Product_id,
                    product.Bar_code,
                    product.Description,
                    product.oProductCategory.Product_category_id,
                    product.oProductCategory.Description,
                    product.Current_stock,
                    product.Minimum_stock,
                    product.Cost_price,
                    product.Sale_price,
                    product.State == true ? "Activo" : "Inactivo",
                    product.State == true ? 1 : 0
                    });
                }
            }
        }

        private void btn_crear_producto_Click(object sender, EventArgs e)
        {
            formProductsAdd frmproductadd = new formProductsAdd();
            frmproductadd.Show();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            grid_productos.Rows.Clear();
            Products_list = new BL_Products().ListAll();
            foreach (Products product in Products_list)
            {
                grid_productos.Rows.Add(new object[]
                {
                    "",
                    product.Product_id,
                    product.Bar_code,
                    product.Description,
                    product.oProductCategory.Product_category_id,
                    product.oProductCategory.Description,
                    product.Current_stock,
                    product.Minimum_stock,
                    product.Cost_price,
                    product.Sale_price,
                    product.State == true ? "Activo" : "Inactivo",
                    product.State == true ? 1 : 0
                });
            }
        }
    }
}
