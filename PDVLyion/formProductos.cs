﻿using CapaEntidad;
using CapaEntidad.Filtros;
using CapaNegocio;
using POSLyion.Resources;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace POSLyion
{
    public partial class formProductos : Form
    {
        private FiltrosProducto filtros = new FiltrosProducto();
        private List<Productos> _lista_productos;
        private readonly formProductosAlta formProducto;

        public formProductos()
        {
            InitializeComponent();
        }

        private void formProducts_Load(object sender, EventArgs e)
        {
            CargarManejadoresEventos();
            CargarCategorias();
            CargarFiltros();
        }

        private void CargarManejadoresEventos()
        {
            cb_estado.Click += new EventHandler(Buscar);
            txt_busqueda.TextChanged += new EventHandler(Buscar);
            cbo_categorias.OnSelectedIndexChanged += new EventHandler(Buscar);
        }

        private void CargarCategorias()
        {
            var lista_categorias = new CN_Categorias().Leer();

            _ = cbo_categorias.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Todas" });

            foreach (var oCategoria in lista_categorias)
            {
                _ = cbo_categorias.Items.Add(new OpcionCombo() { Valor = oCategoria.Id_categoria, Texto = oCategoria.Descripcion });
            }

            cbo_categorias.DisplayMember = "Texto";
            cbo_categorias.ValueMember = "Valor";
            cbo_categorias.SelectedIndex = 0;
        }

        private void dgv_productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var indiceProducto = e.RowIndex;
            if (dgv_productos.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                if (indiceProducto >= 0)
                {
                    using (var formProductosAlta = new formProductosAlta(GenerarProducto(indiceProducto)))
                    {
                        _ = formProductosAlta.ShowDialog();
                    }
                }
                btn_actualizar_Click(sender, e);
            }
            else if (dgv_productos.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {
                EliminarProducto(indiceProducto);
                btn_actualizar_Click(sender, e);
            }
        }

        private Productos GenerarProducto(int indiceProducto)
        {
            var oProducto = new Productos()
            {
                Id_producto = Convert.ToInt32(dgv_productos.Rows[indiceProducto].Cells["id_producto"].Value),
                Codigo_barras = dgv_productos.Rows[indiceProducto].Cells["codigo_barras"].Value.ToString(),
                Descripcion = dgv_productos.Rows[indiceProducto].Cells["descripcion_producto"].Value.ToString(),
                oCategoria = new Categorias()
                {
                    Id_categoria = Convert.ToInt32(dgv_productos.Rows[indiceProducto].Cells["id_categoria"].Value),
                    Descripcion = dgv_productos.Rows[indiceProducto].Cells["descripcion_categoria"].Value.ToString()
                },
                Stock_actual = Convert.ToInt32(dgv_productos.Rows[indiceProducto].Cells["stock_actual"].Value),
                Stock_minimo = Convert.ToInt32(dgv_productos.Rows[indiceProducto].Cells["stock_minimo"].Value),
                Precio_costo = Convert.ToDecimal(dgv_productos.Rows[indiceProducto].Cells["precio_costo"].Value),
                Precio_venta = Convert.ToDecimal(dgv_productos.Rows[indiceProducto].Cells["precio_venta"].Value),
                Precio_mayorista = Convert.ToDecimal(dgv_productos.Rows[indiceProducto].Cells["precio_mayorista"].Value),
                Estado = Convert.ToBoolean(dgv_productos.Rows[indiceProducto].Cells["estado_valor"].Value)
            };
            return oProducto;
        }

        private void EliminarProducto(int indiceProducto)
        {
            if (MessageBox.Show("¿Desea eliminar el producto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (indiceProducto >= 0)
                {
                    var oProducto = new Productos()
                    {
                        Id_producto = Convert.ToInt32(dgv_productos.Rows[indiceProducto].Cells["id_producto"].Value)
                    };
                    var result = new CN_Productos().Eliminar(oProducto, out var mensaje);
                    _ = !result
                        ? MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        : MessageBox.Show("Producto eliminado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btn_crear_producto_Click(object sender, EventArgs e)
        {
            using (var formProductosAlta = new formProductosAlta())
            {
                _ = formProductosAlta.ShowDialog();
            }
            btn_actualizar_Click(sender, e);
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            dgv_productos.Rows.Clear();
            CargarFiltros();
            MostrarProductos();
        }

        private void Buscar(object sender, EventArgs e)
        {
            dgv_productos.Rows.Clear();
            CargarFiltros();
            MostrarProductos();
        }

        private void MostrarProductos()
        {
            _lista_productos = new CN_Productos().Leer(filtros);
            foreach (var oProducto in _lista_productos)
            {
                _ = dgv_productos.Rows.Add(new object[]
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
                    oProducto.Precio_mayorista,
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
            Buscar(sender, e);
        }

        private void formProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formProducto != null && formProducto.IsDisposed)
            {
                formProducto.Close();
            }
        }
    }
}
