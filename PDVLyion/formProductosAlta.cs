using CapaEntidad;
using CapaNegocio;
using POSLyion.Resources;
using System;
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
            var lista_categorias = new CN_Categorias().Leer();
            foreach (var oCategoria in lista_categorias)
            {
                _ = cbox_tipo.Items.Add(new OpcionCombo() { Valor = oCategoria.Id_categoria, Texto = oCategoria.Descripcion });
            }
            cbox_tipo.DisplayMember = "Texto";
            cbox_tipo.ValueMember = "Valor";

            _ = cbox_estado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            _ = cbox_estado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Inactivo" });
            cbox_estado.DisplayMember = "Texto";
            cbox_estado.ValueMember = "Valor";

            txt_id.Texts = Producto.Id_producto.ToString();
            txt_codigo_barras.Text = Producto.Codigo_barras;
            txt_cantidad.Text = Producto.Stock_actual.ToString();
            txt_stock_minimo.Text = Producto.Stock_minimo.ToString();
            txt_descripcion.Text = Producto.Descripcion;
            txt_costo.Text = Producto.Precio_costo.ToString();
            txt_precio.Text = Producto.Precio_venta.ToString();

            var cbox_tipo_index = 0;
            var cbox_estado_index = 0;

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
            string mensaje;
            if (Convert.ToInt32(txt_id.Texts) == 0)
            {
                Producto = new Productos()
                {
                    Codigo_barras = txt_codigo_barras.Text,
                    Descripcion = txt_descripcion.Text,
                    oCategoria = new Categorias()
                    {
                        Id_categoria = Convert.ToInt32(((OpcionCombo)cbox_tipo.SelectedItem).Valor)
                    },
                    Precio_costo = Convert.ToDecimal(txt_costo.Text),
                    Precio_venta = Convert.ToDecimal(txt_precio.Text),
                    Stock_actual = Convert.ToInt32(txt_cantidad.Text),
                    Stock_minimo = Convert.ToInt32(txt_stock_minimo.Text),
                };
                var id_generada_producto = new CN_Productos().Create(Producto, out mensaje);
                if (id_generada_producto == 0)
                {
                    _ = MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    _ = MessageBox.Show("Producto generado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Close();
                }
            }
            else
            {
                Anterior_producto = new Productos
                {
                    Id_producto = Producto.Id_producto,
                    Codigo_barras = Producto.Codigo_barras,
                    Descripcion = Producto.Descripcion,
                    oCategoria = new Categorias() { Id_categoria = Producto.oCategoria.Id_categoria },
                    Precio_costo = Producto.Precio_costo,
                    Precio_venta = Producto.Precio_venta,
                    Stock_actual = Producto.Stock_actual,
                    Stock_minimo = Producto.Stock_minimo,
                    Estado = Producto.Estado
                };
                Producto.Codigo_barras = txt_codigo_barras.Text;
                Producto.Descripcion = txt_descripcion.Text;
                Producto.oCategoria.Id_categoria = Convert.ToInt32(((OpcionCombo)cbox_tipo.SelectedItem).Valor);
                Producto.Precio_costo = Convert.ToDecimal(txt_costo.Text);
                Producto.Precio_venta = Convert.ToDecimal(txt_precio.Text);
                Producto.Stock_actual = Convert.ToInt32(txt_cantidad.Text);
                Producto.Stock_minimo = Convert.ToInt32(txt_stock_minimo.Text);
                Producto.Estado = Convert.ToBoolean(((OpcionCombo)cbox_estado.SelectedItem).Valor);
                var resultado = new CN_Productos().Modificar(Producto, out mensaje);
                if (resultado == false)
                {
                    _ = MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    _ = MessageBox.Show("Producto actualizado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Close();
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                _ = MessageBox.Show("Ingresa solo valores numericos positivos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txt_codigo_barras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                _ = MessageBox.Show("Ingresa solo valores numericos positivos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txt_stock_minimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                _ = MessageBox.Show("Ingresa solo valores numericos positivos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txt_costo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf(',') > -1)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
