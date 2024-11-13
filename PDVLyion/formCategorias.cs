using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaEntidad.Filtros;
using CapaNegocio;
using DocumentFormat.OpenXml.Spreadsheet;
using POSLyion.Resources;

namespace POSLyion
{
    public partial class formCategorias : Form
    {
        public formCategorias()
        {
            InitializeComponent();
        }

        private void formCat_Load(object sender, EventArgs e)
        {
            List<Categorias> lista_categorias = new CN_Categorias().ContarProductos();
            foreach(Categorias oCategoria in lista_categorias)
            {
                grid_categoria.Rows.Add(new object[]
                {
                    oCategoria.Id_categoria,
                    oCategoria.Descripcion,
                    oCategoria.Cantidad
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
                    txt_descripcion.Texts = grid_categoria.Rows[index].Cells["descripcion"].Value.ToString();
                    txt_id.Texts = grid_categoria.Rows[index].Cells["id"].Value.ToString();
                }
            }
            else if (grid_categoria.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {
                if (MessageBox.Show("¿Desea eliminar la categoría?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (index >= 0)
                    {
                        string mensaje = string.Empty;
                        Categorias oCategoria = new Categorias()
                        {
                            Id_categoria = Convert.ToInt32(grid_categoria.Rows[index].Cells["id"].Value)
                        };
                        bool resultado = new CN_Categorias().Eliminar(oCategoria, out mensaje);
                        if (!resultado)
                        {
                            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            Categorias oCategoria = new Categorias();
            string mensaje = string.Empty;
            if (Convert.ToInt32(txt_id.Texts) == 0)
            {

                oCategoria.Descripcion = txt_descripcion.Texts;
                int created_productcategory_id = new CN_Categorias().Crear(oCategoria, out mensaje);
                if (created_productcategory_id == 0)
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Categoría creada con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                oCategoria.Id_categoria = Convert.ToInt32(txt_id.Texts);
                oCategoria.Descripcion = txt_descripcion.Texts;
                bool resultado = false;
                resultado = new CN_Categorias().Modificar(oCategoria, out mensaje);
                if (resultado == false)
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            List<Categorias> lista_categorias = new CN_Categorias().ContarProductos();
            foreach (Categorias oCategoria in lista_categorias)
            {
                grid_categoria.Rows.Add(new object[]
                {
                    oCategoria.Id_categoria,
                    oCategoria.Descripcion,
                    oCategoria.Cantidad
                });
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

        }
    }
}
