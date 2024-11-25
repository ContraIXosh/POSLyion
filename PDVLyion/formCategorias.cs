using CapaEntidad;
using CapaNegocio;
using System;
using System.Windows.Forms;

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
            lbl_edicion.Visible = false;
            txt_categoryedit.Visible = false;
            btn_editar_categoria.Visible = false;
            btn_cancelar.Visible = false;
            var lista_categorias = new CN_Categorias().ContarProductos();
            foreach (var oCategoria in lista_categorias)
            {
                _ = grid_categoria.Rows.Add(new object[]
                {
                    oCategoria.Id_categoria,
                    oCategoria.Descripcion,
                    oCategoria.Cantidad
                });
            }
        }

        private void grid_category_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            if (grid_categoria.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                if (index >= 0)
                {
                    lbl_crear.Visible = false;
                    txt_descripcion.Visible = false;
                    btn_crear_categoria.Visible = false;
                    lbl_edicion.Visible = true;
                    txt_categoryedit.Visible = true;
                    btn_editar_categoria.Visible = true;
                    btn_cancelar.Visible = true;
                    txt_categoryedit.Texts = grid_categoria.Rows[index].Cells["descripcion"].Value.ToString();
                    txt_id.Texts = grid_categoria.Rows[index].Cells["id"].Value.ToString();
                }
            }
            else if (grid_categoria.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {
                if (MessageBox.Show("¿Desea eliminar la categoría?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (index >= 0)
                    {
                        var oCategoria = new Categorias()
                        {
                            Id_categoria = Convert.ToInt32(grid_categoria.Rows[index].Cells["id"].Value)
                        };
                        var resultado = new CN_Categorias().Eliminar(oCategoria, out var mensaje);
                        _ = !resultado
                            ? MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            : MessageBox.Show("Categoría eliminado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void btn_crear_categoria_Click(object sender, EventArgs e)
        {
            var oCategoria = new Categorias();
            if (Convert.ToInt32(txt_id.Texts) == 0)
            {

                oCategoria.Descripcion = txt_descripcion.Texts;
                var created_productcategory_id = new CN_Categorias().Crear(oCategoria, out var mensaje);
                _ = created_productcategory_id == 0
                    ? MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    : MessageBox.Show("Categoría creada con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            txt_descripcion.Texts = "";
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            grid_categoria.Rows.Clear();
            var lista_categorias = new CN_Categorias().ContarProductos();
            foreach (var oCategoria in lista_categorias)
            {
                _ = grid_categoria.Rows.Add(new object[]
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

        private void btn_editar_categoria_Click(object sender, EventArgs e)
        {
            var oCategoria = new Categorias
            {
                Id_categoria = Convert.ToInt32(txt_id.Texts),
                Descripcion = txt_categoryedit.Texts
            };
            var resultado = new CN_Categorias().Modificar(oCategoria, out var mensaje);
            _ = resultado == false
                ? MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                : MessageBox.Show("Categoría actualizada con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            TerminarEdicion();

        }

        private void TerminarEdicion()
        {
            txt_id.Texts = "0";
            txt_categoryedit.Text = "";
            lbl_edicion.Visible = false;
            txt_categoryedit.Visible = false;
            btn_editar_categoria.Visible = false;
            btn_cancelar.Visible = false;
            lbl_crear.Visible = true;
            txt_descripcion.Visible = true;
            btn_crear_categoria.Visible = true;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            TerminarEdicion();
        }
    }
}
