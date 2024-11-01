using CapaEntidad;
using CapaNegocio;
using POSLyion.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSLyion.Modals
{
    public partial class MD_Productos : Form
    {

        public Productos oProducto { get; set; }

        public MD_Productos()
        {
            InitializeComponent();
        }

        private void MD_Productos_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgv_modal_productos.Columns)
            {
                if (columna.Visible == true)
                {
                    cbo_filtro.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }

            cbo_filtro.DisplayMember = "Texto";
            cbo_filtro.ValueMember = "Valor";
            cbo_filtro.SelectedIndex = 1;

            List<Productos> lista_productos = new CN_Productos().Leer();
            foreach (Productos oProducto in lista_productos)
            {
                dgv_modal_productos.Rows.Add(new object[]
                {
                    oProducto.Id_producto,
                    oProducto.Codigo_barras,
                    oProducto.Descripcion,
                    oProducto.oCategoria.Id_categoria,
                    oProducto.oCategoria.Descripcion,
                    oProducto.Stock_actual,
                    oProducto.Precio_costo,
                    oProducto.Precio_venta
                });
            }
        }

        private void dgv_modal_productos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice_fila = e.RowIndex;
            int indice_columna = e.ColumnIndex;
            if (indice_fila >= 0 && indice_columna >= 0)
            {
                oProducto = new Productos()
                {
                    Codigo_barras = dgv_modal_productos.Rows[indice_fila].Cells["codigo_barras"].Value.ToString(),
                    Id_producto = Convert.ToInt32(dgv_modal_productos.Rows[indice_fila].Cells["id_producto"].Value),
                    Descripcion = dgv_modal_productos.Rows[indice_fila].Cells["descripcion_producto"].Value.ToString(),
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void txt_busqueda__TextChanged(object sender, EventArgs e)
        {
            string filtro = ((OpcionCombo)cbo_filtro.SelectedItem).Valor.ToString();
            if (dgv_modal_productos.Rows.Count > 0)
            {
                foreach (DataGridViewRow fila in dgv_modal_productos.Rows)
                {
                    if (fila.Cells[filtro].Value.ToString().Trim().ToUpper().Contains(txt_busqueda.Texts.Trim().ToUpper()))
                    {
                        fila.Visible = true;
                    }
                    else
                    {
                        fila.Visible = false;
                    }
                }
            }
        }
    }
}
