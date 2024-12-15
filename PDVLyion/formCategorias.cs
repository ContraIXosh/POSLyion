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
            txt_descripcion_editar.Visible = false;
            btn_editar_categoria.Visible = false;
            btn_cancelar.Visible = false;
            MostrarCategorias();
        }

        private void dgv_categorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            if (dgv_categorias.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                if (index >= 0)
                {
                    lbl_crear.Visible = false;
                    txt_descripcion.Visible = false;
                    btn_crear_categoria.Visible = false;
                    lbl_edicion.Visible = true;
                    txt_descripcion_editar.Visible = true;
                    btn_editar_categoria.Visible = true;
                    btn_cancelar.Visible = true;
                    txt_descripcion_editar.Texts = dgv_categorias.Rows[index].Cells["descripcion"].Value.ToString();
                    txt_id.Texts = dgv_categorias.Rows[index].Cells["id"].Value.ToString();
                }
            }
            else if (dgv_categorias.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {
                if (MessageBox.Show("¿Desea eliminar la categoría?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (index >= 0)
                    {
                        var oCategoria = new Categorias()
                        {
                            Id_categoria = Convert.ToInt32(dgv_categorias.Rows[index].Cells["id"].Value)
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
            if (ValidarDatosCrear())
            {
                var oCategoria = new Categorias();
                if (Convert.ToInt32(txt_id.Texts) == 0)
                {
                    oCategoria.Descripcion = txt_descripcion.Texts;
                    _ = new CN_Categorias().Crear(oCategoria, out var mensaje) == 0
                        ? MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        : MessageBox.Show("Categoría creada con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                txt_descripcion.Texts = "";
                MostrarCategorias();
            }
        }

        private bool ValidarDatosCrear()
        {
            var resultado = true;
            if (txt_descripcion.Texts == "")
            {
                resultado = false;
                errorProvider1.SetError(txt_descripcion, "Ingrese el nombre de la categoría");
            }
            return resultado;
        }

        private bool ValidarDatosEditar()
        {
            var resultado = true;
            if (txt_descripcion_editar.Texts == "")
            {
                resultado = false;
                errorProvider2.SetError(txt_descripcion_editar, "Ingrese el nombre de la categoría");
            }
            return resultado;
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            dgv_categorias.Rows.Clear();
            MostrarCategorias();
        }

        private void btn_editar_categoria_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (ValidarDatosEditar())
            {
                var oCategoria = new Categorias
                {
                    Id_categoria = Convert.ToInt32(txt_id.Texts),
                    Descripcion = txt_descripcion_editar.Texts
                };
                _ = new CN_Categorias().Modificar(oCategoria, out var mensaje)
                    ? MessageBox.Show("Categoría actualizada con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    : MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TerminarEdicion();
                MostrarCategorias();
            }
        }

        private void TerminarEdicion()
        {
            txt_id.Texts = "0";
            txt_descripcion_editar.Text = "";
            lbl_edicion.Visible = false;
            txt_descripcion_editar.Visible = false;
            btn_editar_categoria.Visible = false;
            btn_cancelar.Visible = false;
            lbl_crear.Visible = true;
            txt_descripcion.Visible = true;
            btn_crear_categoria.Visible = true;
            errorProvider1.Clear();
            errorProvider2.Clear();
        }

        private void MostrarCategorias()
        {
            if (dgv_categorias.Rows.Count > 0)
            {
                dgv_categorias.Rows.Clear();
            }
            var lista_categorias = new CN_Categorias().ContarProductos();
            foreach (var oCategoria in lista_categorias)
            {
                _ = dgv_categorias.Rows.Add(new object[]
                {
                oCategoria.Id_categoria,
                oCategoria.Descripcion,
                oCategoria.Cantidad,
                });
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            TerminarEdicion();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

        }
    }
}
