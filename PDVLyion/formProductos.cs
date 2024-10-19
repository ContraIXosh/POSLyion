using CapaNegocio;
using CapaEntidad;
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

namespace POSLyion
{
    public partial class formProductos : Form
    {
        private static Usuarios oUsuario = new Usuarios();
        private List<Productos> Lista_productos;

        public formProductos()
        {
            InitializeComponent();
            Lista_productos = new CN_Productos().Leer();
        }

        private void formProducts_Load(object sender, EventArgs e)
        {
            foreach (Productos oProducto in Lista_productos)
            {
                grid_productos.Rows.Add(new object[]
                {
                    "",
                    oProducto.Id_producto,
                    oProducto.Codigo_barras,
                    oProducto.Descripcion,
                    oProducto.oCategoria.Id_categoria,
                    oProducto.oCategoria.Descripcion,
                    oProducto.Stock_actual,
                    oProducto.Stock_minimo,
                    oProducto.Precio_costo,
                    oProducto.Precio_venta,
                    oProducto.Estado == true ? "Activo" : "Inactivo",
                    oProducto.Estado == true ? 1 : 0
                });
            }
        }

        private void grid_productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (grid_productos.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                if (index >= 0)
                {
                    Productos oProducto = new Productos()
                    {
                        Id_producto = Convert.ToInt32(grid_productos.Rows[index].Cells["id_producto"].Value),
                        Codigo_barras = grid_productos.Rows[index].Cells["codigo_barras"].Value.ToString(),
                        Descripcion = grid_productos.Rows[index].Cells["descripcion_producto"].Value.ToString(),
                        oCategoria = new Categorias()
                        {
                            Id_categoria = Convert.ToInt32(grid_productos.Rows[index].Cells["id_categoria"].Value),
                            Descripcion = grid_productos.Rows[index].Cells["descripcion_categoria"].Value.ToString()
                        },
                        Stock_actual = Convert.ToInt32(grid_productos.Rows[index].Cells["stock_actual"].Value),
                        Stock_minimo = Convert.ToInt32(grid_productos.Rows[index].Cells["stock_minimo"].Value),
                        Precio_costo = Convert.ToDecimal(grid_productos.Rows[index].Cells["precio_costo"].Value),
                        Precio_venta = Convert.ToDecimal(grid_productos.Rows[index].Cells["precio_venta"].Value),
                        Estado = Convert.ToBoolean(grid_productos.Rows[index].Cells["estado_valor"].Value)
                    };
                    formProductosAlta formProductosAlta = new formProductosAlta(oProducto);
                    formProductosAlta.Show();
                }
            }
            else if (grid_productos.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {
                if (MessageBox.Show("¿Desea eliminar el producto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (index >= 0)
                    {
                        string mensaje = string.Empty;
                        Productos oProducto = new Productos()
                        {
                            Id_producto = Convert.ToInt32(grid_productos.Rows[index].Cells["id_producto"].Value)
                        };
                        bool result = new CN_Productos().Eliminar(oProducto, out mensaje);
                        if (!result)
                        {
                            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                List<Productos> lista_productos = new CN_Productos()
                .Leer()
                .Where(p => p.Stock_actual > 0).ToList();
                foreach (Productos oProducto in lista_productos)
                {
                    grid_productos.Rows.Add(new object[]
                    {
                    "",
                    oProducto.Id_producto,
                    oProducto.Codigo_barras,
                    oProducto.Descripcion,
                    oProducto.oCategoria.Id_categoria,
                    oProducto.oCategoria.Descripcion,
                    oProducto.Stock_actual,
                    oProducto.Stock_minimo,
                    oProducto.Precio_costo,
                    oProducto.Precio_venta,
                    oProducto.Estado == true ? "Activo" : "Inactivo",
                    oProducto.Estado == true ? 1 : 0
                    });
                }
            }
            else
            {
                foreach (Productos oProducto in Lista_productos)
                {
                    grid_productos.Rows.Add(new object[]
                    {
                    "",
                    oProducto.Id_producto,
                    oProducto.Codigo_barras,
                    oProducto.Descripcion,
                    oProducto.oCategoria.Id_categoria,
                    oProducto.oCategoria.Descripcion,
                    oProducto.Stock_actual,
                    oProducto.Stock_minimo,
                    oProducto.Precio_costo,
                    oProducto.Precio_venta,
                    oProducto.Estado == true ? "Activo" : "Inactivo",
                    oProducto.Estado == true ? 1 : 0
                    });
                }
            }
        }

        private void cb_inactive_CheckedChanged(object sender, EventArgs e)
        {
            grid_productos.Rows.Clear();
            if (cb_inactive.Checked)
            {
                List<Productos> lista_productos = new CN_Productos().Leer().Where(p => p.Estado == false).ToList();
                foreach (Productos oProducto in lista_productos)
                {
                    grid_productos.Rows.Add(new object[]
                    {
                    "",
                    oProducto.Id_producto,
                    oProducto.Codigo_barras,
                    oProducto.Descripcion,
                    oProducto.oCategoria.Id_categoria,
                    oProducto.oCategoria.Descripcion,
                    oProducto.Stock_actual,
                    oProducto.Stock_minimo,
                    oProducto.Precio_costo,
                    oProducto.Precio_venta,
                    oProducto.Estado == true ? "Activo" : "Inactivo",
                    oProducto.Estado == true ? 1 : 0
                    });
                }
            }
            else
            {
                foreach (Productos oProducto in Lista_productos)
                {
                    grid_productos.Rows.Add(new object[]
                    {
                    "",
                    oProducto.Id_producto,
                    oProducto.Codigo_barras,
                    oProducto.Descripcion,
                    oProducto.oCategoria.Id_categoria,
                    oProducto.oCategoria.Descripcion,
                    oProducto.Stock_actual,
                    oProducto.Stock_minimo,
                    oProducto.Precio_costo,
                    oProducto.Precio_venta,
                    oProducto.Estado == true ? "Activo" : "Inactivo",
                    oProducto.Estado == true ? 1 : 0
                    });
                }
            }
        }

        private void btn_crear_producto_Click(object sender, EventArgs e)
        {
            formProductosAlta formProductosAlta = new formProductosAlta();
            formProductosAlta.Show();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            grid_productos.Rows.Clear();
            Lista_productos = new CN_Productos().Leer();
            foreach (Productos oProducto in Lista_productos)
            {
                grid_productos.Rows.Add(new object[]
                {
                    "",
                    oProducto.Id_producto,
                    oProducto.Codigo_barras,
                    oProducto.Descripcion,
                    oProducto.oCategoria.Id_categoria,
                    oProducto.oCategoria.Descripcion,
                    oProducto.Stock_actual,
                    oProducto.Stock_minimo,
                    oProducto.Precio_costo,
                    oProducto.Precio_venta,
                    oProducto.Estado == true ? "Activo" : "Inactivo",
                    oProducto.Estado == true ? 1 : 0
                });
            }
        }
    }
}
