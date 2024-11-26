using CapaEntidad;
using CapaNegocio;
using POSLyion.Resources;
using System;
using System.Windows.Forms;

namespace POSLyion
{
    public partial class formProductosAlta : Form
    {
        private Productos _producto;
        private Productos _productoAnterior;

        public formProductosAlta()
        {
            _producto = new Productos();
            InitializeComponent();
        }

        public formProductosAlta(Productos producto)
        {
            _producto = producto;
            InitializeComponent();
        }

        private void formProductosAlta_Load(object sender, EventArgs e)
        {
            CargarManejadoresEventos();
            CargarValoresPorDefecto();
            CargarValoresProducto();
            KeyPreview = true;
        }

        private void CargarValoresPorDefecto()
        {
            //Ocultar los controles para asignar un estado
            cbox_estado.Visible = false;
            lbl_estado.Visible = false;
            btn_reiniciar_datos.Visible = false;

            //Carga de categorías
            var lista_categorias = new CN_Categorias().Leer();
            foreach (var oCategoria in lista_categorias)
            {
                _ = cbox_tipo.Items.Add(new OpcionCombo() { Valor = oCategoria.Id_categoria, Texto = oCategoria.Descripcion });
            }
            cbox_tipo.DisplayMember = "Texto";
            cbox_tipo.ValueMember = "Valor";

            //Cargar los estados
            _ = cbox_estado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            _ = cbox_estado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Inactivo" });
            cbox_estado.DisplayMember = "Texto";
            cbox_estado.ValueMember = "Valor";

            //Seleccionar la categoría y estado que se muestra por defecto
            cbox_tipo.SelectedIndex = 0;
            cbox_tipo.SelectedIndex = 0;
        }

        private void CargarValoresProducto()
        {
            if (_producto.Id_producto != 0)
            {
                CargarRespaldoProducto();

                lbl_estado.Visible = true;
                cbox_estado.Visible = true;
                btn_reiniciar_datos.Visible = true;

                txt_codigo_barras.Text = _producto.Codigo_barras;
                txt_cantidad.Text = _producto.Stock_actual.ToString();
                txt_stock_minimo.Text = _producto.Stock_minimo.ToString();
                txt_descripcion.Text = _producto.Descripcion;
                txt_costo.Text = _producto.Precio_costo.ToString();
                txt_precio.Text = _producto.Precio_venta.ToString();

                var cbox_tipo_index = 0;
                var cbox_estado_index = 0;

                foreach (OpcionCombo opcion_estado in cbox_estado.Items)
                {
                    if (Convert.ToInt32(opcion_estado.Valor) == (_producto.Estado == true ? 1 : 0))
                    {
                        cbox_estado_index = cbox_estado.Items.IndexOf(opcion_estado);
                        break;
                    }
                }
                cbox_estado.SelectedIndex = cbox_estado_index;

                foreach (OpcionCombo opcion_categoria in cbox_tipo.Items)
                {
                    if (Convert.ToInt32(opcion_categoria.Valor) == _producto.oCategoria.Id_categoria)
                    {
                        cbox_tipo_index = cbox_tipo.Items.IndexOf(opcion_categoria);
                        break;
                    }
                }
                cbox_tipo.SelectedIndex = cbox_tipo_index;
            }
        }

        private void CrearNuevoProducto()
        {
            _producto = new Productos()
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
            var id_generada_producto = new CN_Productos().Create(_producto, out var mensaje);
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

        private void EditarProducto()
        {
            _producto.Codigo_barras = txt_codigo_barras.Text;
            _producto.Descripcion = txt_descripcion.Text;
            _producto.oCategoria.Id_categoria = Convert.ToInt32(((OpcionCombo)cbox_tipo.SelectedItem).Valor);
            _producto.Precio_costo = Convert.ToDecimal(txt_costo.Text);
            _producto.Precio_venta = Convert.ToDecimal(txt_precio.Text);
            _producto.Stock_actual = Convert.ToInt32(txt_cantidad.Text);
            _producto.Stock_minimo = Convert.ToInt32(txt_stock_minimo.Text);
            _producto.Estado = Convert.ToBoolean(((OpcionCombo)cbox_estado.SelectedItem).Valor);
            var resultado = new CN_Productos().Modificar(_producto, out var mensaje);
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

        private void CargarRespaldoProducto()
        {
            _productoAnterior = new Productos
            {
                Id_producto = _producto.Id_producto,
                Codigo_barras = _producto.Codigo_barras,
                Descripcion = _producto.Descripcion,
                oCategoria = new Categorias() { Id_categoria = _producto.oCategoria.Id_categoria },
                Precio_costo = _producto.Precio_costo,
                Precio_venta = _producto.Precio_venta,
                Stock_actual = _producto.Stock_actual,
                Stock_minimo = _producto.Stock_minimo,
                Estado = _producto.Estado
            };
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (_producto.Id_producto == 0)
                {
                    CrearNuevoProducto();
                }
                else
                {
                    EditarProducto();
                }
            }
        }

        private bool ValidarDatos()
        {
            var resultado = true;

            if (txt_codigo_barras.Text == "")
            {
                resultado = false;
                errorProvider1.SetError(txt_codigo_barras, "Ingresar un código de barras");
            }

            if (txt_cantidad.Text == "")
            {
                resultado = false;
                txt_cantidad.Text = "0";
            }

            if (txt_descripcion.Text == "")
            {
                resultado = false;
                errorProvider2.SetError(txt_descripcion, "Ingresar una descripción del producto");
            }

            if (txt_stock_minimo.Text == "")
            {
                resultado = false;
                txt_stock_minimo.Text = "0";
            }

            if (txt_precio.Text == "")
            {
                resultado = false;
                txt_precio.Text = "0";
            }

            return resultado;
        }

        private void btn_reiniciar_datos_Click(object sender, EventArgs e)
        {
            if (_productoAnterior != null)
            {
                txt_codigo_barras.Text = _productoAnterior.Codigo_barras;
                cbox_tipo.SelectedIndex = _productoAnterior.oCategoria.Id_categoria - 1;
                txt_cantidad.Text = _productoAnterior.Stock_actual.ToString();
                cbox_estado.SelectedIndex = _productoAnterior.Estado == true ? 0 : 1;
                txt_descripcion.Text = _productoAnterior.Descripcion;
                txt_stock_minimo.Text = _productoAnterior.Stock_minimo.ToString();
                txt_costo.Text = _productoAnterior.Precio_costo.ToString();
                txt_precio.Text = _productoAnterior.Precio_venta.ToString();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargarManejadoresEventos()
        {
            txt_cantidad.KeyPress += new KeyPressEventHandler(NoLetras);
            txt_codigo_barras.KeyPress += new KeyPressEventHandler(NoLetras);
            txt_stock_minimo.KeyPress += new KeyPressEventHandler(NoLetras);
            txt_cantidad.KeyPress += new KeyPressEventHandler(NoLetras);
        }

        private void NoLetras(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                //_ = MessageBox.Show("Ingresa solo valores numericos positivos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void formProductosAlta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
