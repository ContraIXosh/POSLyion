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

namespace PDCLyion
{
    public partial class formProducts : Form
    {

        private List<Products> Products_list;

        public formProducts()
        {
            InitializeComponent();
            Products_list = new BL_Products().ListAll();
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
        private void btn_back_Click(object sender, EventArgs e)
        {
            abrirHerencia(new formSales());
        }

        private void btn_addprod_Click(object sender, EventArgs e)
        {
            formProducts2 crearprod = new formProducts2();

            crearprod.Show();
        }

        private void formProducts_Load(object sender, EventArgs e)
        {
            foreach (Products product in Products_list)
            {
                grid_prod.Rows.Add(new object[]
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
            if (grid_prod.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                if (index >= 0)
                {
                    Products product = new Products()
                    {
                        Product_id = Convert.ToInt32(grid_prod.Rows[index].Cells["prod_id"].Value),
                        Bar_code = grid_prod.Rows[index].Cells["prod_cod"].Value.ToString(),
                        Description = grid_prod.Rows[index].Cells["prod_desc"].Value.ToString(),
                        oProductCategory = new ProductCategories()
                        {
                            Product_category_id = Convert.ToInt32(grid_prod.Rows[index].Cells["prod_id_cat"].Value),
                            Description = grid_prod.Rows[index].Cells["prod_cat"].Value.ToString()
                        },
                        Current_stock = Convert.ToInt32(grid_prod.Rows[index].Cells["prod_stock"].Value),
                        Minimum_stock = Convert.ToInt32(grid_prod.Rows[index].Cells["prod_stock_min"].Value),
                        Cost_price = Convert.ToDecimal(grid_prod.Rows[index].Cells["prod_precio_costo"].Value),
                        Sale_price = Convert.ToDecimal(grid_prod.Rows[index].Cells["prod_precio_venta"].Value),
                        State = Convert.ToBoolean(grid_prod.Rows[index].Cells["prod_estado_valor"].Value)
                    };
                    abrirHerencia(new formProducts2(product));
                }
            }
            else if (grid_prod.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {
                if (MessageBox.Show("¿Desea eliminar el producto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (index >= 0)
                    {
                        string message = string.Empty;
                        Products product = new Products()
                        {
                            Product_id = Convert.ToInt32(grid_prod.Rows[index].Cells["prod_id"].Value)
                        };
                        bool result = new BL_Products().Delete(product, out message);
                        if (!result)
                        {
                            MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("Producto eliminado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            abrirHerencia(new formProducts());
                        }
                    }
                }
            }
        }

        private void cb_stock_CheckedChanged(object sender, EventArgs e)
        {
            grid_prod.Rows.Clear();
            if (cb_stock.Checked)
            {
                List<Products> products_list = new BL_Products()
                .ListAll()
                .Where(p => p.Current_stock > 0).ToList();
                foreach (Products product in products_list)
                {
                    grid_prod.Rows.Add(new object[]
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
                    grid_prod.Rows.Add(new object[]
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
            grid_prod.Rows.Clear();
            if (cb_inactive.Checked)
            {
                List<Products> products_list = new BL_Products().ListAll().Where(p => p.State == false).ToList();
                foreach (Products product in products_list)
                {
                    grid_prod.Rows.Add(new object[]
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
                    grid_prod.Rows.Add(new object[]
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
}
