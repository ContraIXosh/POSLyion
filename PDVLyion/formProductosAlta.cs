using CapaNegocio;
using CapaEntidad;
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

namespace POSLyion
{
    public partial class formProductosAlta : Form
    {

        private Productos Producto;
        private Productos Anterior_producto;

        public formProductosAlta()
        {
            Producto = new Productos();
            InitializeComponent();
        }

        public formProductosAlta(Productos oProduct)
        {
            Producto = oProduct;
            InitializeComponent();
        }

        private void formProductosAlta_Load(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Producto.Id_producto) == 0)
            {
                cbox_estado.Visible = false;
                lbl_estado.Visible = false;
            }
            List<Categorias> lista_categorias = new CN_Categorias().Leer();
            foreach (Categorias oCategoria in lista_categorias)
            {
                cbox_tipo.Items.Add(new OpcionCombo() { Valor = oCategoria.Id_categoria, Texto = oCategoria.Descripcion });
            }
            cbox_tipo.DisplayMember = "Text";
            cbox_tipo.ValueMember = "Value";

            cbox_estado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cbox_estado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Inactivo" });
            cbox_estado.DisplayMember = "Text";
            cbox_estado.ValueMember = "Value";

            txt_id.Texts = Producto.Id_producto.ToString();
            txt_codigo_barras.Texts = Producto.Codigo_barras;
            txt_cantidad.Texts = Producto.Stock_actual.ToString();
            txt_stock_minimo.Texts = Producto.Stock_minimo.ToString();
            txt_descripcion.Texts = Producto.Descripcion;
            txt_precio_costo.Texts = Producto.Precio_costo.ToString();
            txt_precio_venta.Texts = Producto.Precio_venta.ToString();

            int cbox_tipo_index = 0;
            int cbox_estado_index = 0;

            if (Convert.ToInt32(txt_id.Texts) == 0)
            {
                cbox_tipo.SelectedIndex = 0;
                cbox_tipo.SelectedIndex = 0;
            }
            else
            {
                foreach (OpcionCombo opcion_estado in cbox_estado.Items)
                {
                    if (Convert.ToInt32(opcion_estado.Valor) == (Producto.Estado == true ? 1 : 0))
                    {
                        cbox_estado_index = cbox_estado.Items.IndexOf(opcion_estado);
                        break;
                    }
                }
                cbox_estado.SelectedIndex = cbox_estado_index;

                foreach (OpcionCombo opcion_categoria in cbox_tipo.Items)
                {
                    if (Convert.ToInt32(opcion_categoria.Valor) == Producto.oCategoria.Id_categoria)
                    {
                        cbox_tipo_index = cbox_tipo.Items.IndexOf(opcion_categoria);
                        break;
                    }
                }
                cbox_tipo.SelectedIndex = cbox_tipo_index;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string mensaje = String.Empty;
            if(Convert.ToInt32(txt_id.Texts) == 0)
            {
                int id_generada_producto = 0;
                Producto = new Productos()
                {
                    Codigo_barras = txt_codigo_barras.Texts,
                    Descripcion = txt_descripcion.Texts,
                    oCategoria = new Categorias()
                    {
                        Id_categoria = Convert.ToInt32(((OpcionCombo)cbox_tipo.SelectedItem).Valor)
                    },
                    Precio_costo = Convert.ToDecimal(txt_precio_costo.Texts),
                    Precio_venta = Convert.ToDecimal(txt_precio_venta.Texts),
                    Stock_actual = Convert.ToInt32(txt_cantidad.Texts),
                    Stock_minimo = Convert.ToInt32(txt_stock_minimo.Texts),
                };
                id_generada_producto = new CN_Productos().Create(Producto, out mensaje);
                if (id_generada_producto == 0)
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Producto generado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                bool resultado = false;
                Anterior_producto = new Productos();
                Anterior_producto.Id_producto = Producto.Id_producto;
                Anterior_producto.Codigo_barras = Producto.Codigo_barras;
                Anterior_producto.Descripcion = Producto.Descripcion;
                Anterior_producto.oCategoria = new Categorias() { Id_categoria = Producto.oCategoria.Id_categoria };
                Anterior_producto.Precio_costo = Producto.Precio_costo;
                Anterior_producto.Precio_venta = Producto.Precio_venta;
                Anterior_producto.Stock_actual = Producto.Stock_actual;
                Anterior_producto.Stock_minimo = Producto.Stock_minimo;
                Anterior_producto.Estado = Producto.Estado;
                Producto.Codigo_barras = txt_codigo_barras.Texts;
                Producto.Descripcion = txt_descripcion.Texts;
                Producto.oCategoria.Id_categoria = Convert.ToInt32(((OpcionCombo)cbox_tipo.SelectedItem).Valor);
                Producto.Precio_costo = Convert.ToDecimal(txt_precio_costo.Texts);
                Producto.Precio_venta = Convert.ToDecimal(txt_precio_venta.Texts);
                Producto.Stock_actual = Convert.ToInt32(txt_cantidad.Texts);
                Producto.Stock_minimo = Convert.ToInt32(txt_stock_minimo.Texts);
                Producto.Estado = Convert.ToBoolean(((OpcionCombo)cbox_estado.SelectedItem).Valor);
                resultado = new CN_Productos().Modificar(Producto, out mensaje);
                if (resultado == false)
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Producto actualizado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
