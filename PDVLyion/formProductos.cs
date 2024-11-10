using CapaNegocio;
using CapaEntidad;
using CapaEntidad.Filtros;
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
using POSLyion.Resources;

namespace POSLyion
{
    public partial class formProductos : Form
    {
        private static Usuarios oUsuario = new Usuarios();
        FiltrosProducto filtros = new FiltrosProducto();
        private List<Productos> _lista_productos;

        public formProductos()
        {
            InitializeComponent();
            
        }

        private void formProducts_Load(object sender, EventArgs e)
        {
            cbo_categorias.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Todas" });
            List<Categorias> lista_categorias = new CN_Categorias().Leer();
            foreach (Categorias oCategoria in lista_categorias)
            {
                cbo_categorias.Items.Add(new OpcionCombo() { Valor = oCategoria.Id_categoria, Texto = oCategoria.Descripcion });
            }
            cbo_categorias.DisplayMember = "Texto";
            cbo_categorias.ValueMember = "Valor";
            cbo_categorias.SelectedIndex = 0;
            this.CargarFiltros();
            this.MostrarProductos();
        }

        private void grid_productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (dgv_productos.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                if (index >= 0)
                {
                    Productos oProducto = new Productos()
                    {
                        Id_producto = Convert.ToInt32(dgv_productos.Rows[index].Cells["id_producto"].Value),
                        Codigo_barras = dgv_productos.Rows[index].Cells["codigo_barras"].Value.ToString(),
                        Descripcion = dgv_productos.Rows[index].Cells["descripcion_producto"].Value.ToString(),
                        oCategoria = new Categorias()
                        {
                            Id_categoria = Convert.ToInt32(dgv_productos.Rows[index].Cells["id_categoria"].Value),
                            Descripcion = dgv_productos.Rows[index].Cells["descripcion_categoria"].Value.ToString()
                        },
                        Stock_actual = Convert.ToInt32(dgv_productos.Rows[index].Cells["stock_actual"].Value),
                        Stock_minimo = Convert.ToInt32(dgv_productos.Rows[index].Cells["stock_minimo"].Value),
                        Precio_costo = Convert.ToDecimal(dgv_productos.Rows[index].Cells["precio_costo"].Value),
                        Precio_venta = Convert.ToDecimal(dgv_productos.Rows[index].Cells["precio_venta"].Value),
                        Estado = Convert.ToBoolean(dgv_productos.Rows[index].Cells["estado_valor"].Value)
                    };
                    formProductosAlta formProductosAlta = new formProductosAlta(oProducto);
                    formProductosAlta.Show();
                }
            }
            else if (dgv_productos.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {
                if (MessageBox.Show("¿Desea eliminar el producto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (index >= 0)
                    {
                        string mensaje = string.Empty;
                        Productos oProducto = new Productos()
                        {
                            Id_producto = Convert.ToInt32(dgv_productos.Rows[index].Cells["id_producto"].Value)
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

        private void btn_crear_producto_Click(object sender, EventArgs e)
        {
            formProductosAlta formProductosAlta = new formProductosAlta();
            formProductosAlta.Show();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            dgv_productos.Rows.Clear();
            this.CargarFiltros();
            this.MostrarProductos();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dgv_productos.Rows.Clear();
            this.CargarFiltros();
            this.MostrarProductos();
        }

        private void MostrarProductos()
        {
            _lista_productos = new CN_Productos().Leer(filtros);
            foreach (Productos oProducto in _lista_productos)
            {
                dgv_productos.Rows.Add(new object[]
                {
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

        private void CargarFiltros()
        {
            filtros = new FiltrosProducto()
            {
                Nombre_producto = txt_busqueda.Text,
                Id_categoria = Convert.ToInt32(((OpcionCombo)cbo_categorias.SelectedItem).Valor),
                Estado = cb_estado.Checked ? 0 : 1,
            };
        }

        private void btn_limpiar_filtros_Click(object sender, EventArgs e)
        {
            txt_busqueda.Text = "";
            cbo_categorias.SelectedIndex = 0;
            cb_estado.Checked = false;
        }
    }
}
