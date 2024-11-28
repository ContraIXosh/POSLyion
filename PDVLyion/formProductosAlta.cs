using CapaEntidad;
using CapaNegocio;
using POSLyion.Resources;
using POSLyion.Resources.Interfaces;
using System;
using System.Windows.Forms;

namespace POSLyion
{
    public partial class formProductosAlta : Form, IFormCRUD
    {
        private Productos _objeto;
        private Productos _objetoAnterior;

        public formProductosAlta()
        {
            _objeto = new Productos();
            InitializeComponent();
        }

        public formProductosAlta(Productos producto)
        {
            _objeto = producto;
            InitializeComponent();
        }

        private void formProductosAlta_Load(object sender, EventArgs e)
        {
            CargarManejadoresEventos();
            CargarValoresPorDefecto();
            MostrarDatosObjeto();
            KeyPreview = true;
        }

        public void CargarManejadoresEventos()
        {
            txt_cantidad.KeyPress += new KeyPressEventHandler(NoLetras);
            txt_codigo_barras.KeyPress += new KeyPressEventHandler(NoLetras);
            txt_stock_minimo.KeyPress += new KeyPressEventHandler(NoLetras);
            txt_cantidad.KeyPress += new KeyPressEventHandler(NoLetras);
        }

        public void CargarValoresPorDefecto()
        {
            cbox_estado.Visible = false;
            lbl_estado.Visible = false;
            btn_reiniciar_datos.Visible = false;

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

            cbox_tipo.SelectedIndex = 0;
            cbox_tipo.SelectedIndex = 0;
        }

        public void MostrarDatosObjeto()
        {
            if (_objeto.Id_producto != 0)
            {
                RespaldoDatosObjeto();

                lbl_estado.Visible = true;
                cbox_estado.Visible = true;
                btn_reiniciar_datos.Visible = true;

                txt_codigo_barras.Text = _objeto.Codigo_barras;
                txt_cantidad.Text = _objeto.Stock_actual.ToString();
                txt_stock_minimo.Text = _objeto.Stock_minimo.ToString();
                txt_descripcion.Text = _objeto.Descripcion;
                txt_costo.Text = _objeto.Precio_costo.ToString();
                txt_precio.Text = _objeto.Precio_venta.ToString();

                var cbox_tipo_index = 0;
                var cbox_estado_index = 0;

                foreach (OpcionCombo opcion_estado in cbox_estado.Items)
                {
                    if (Convert.ToInt32(opcion_estado.Valor) == (_objeto.Estado == true ? 1 : 0))
                    {
                        cbox_estado_index = cbox_estado.Items.IndexOf(opcion_estado);
                        break;
                    }
                }
                cbox_estado.SelectedIndex = cbox_estado_index;

                foreach (OpcionCombo opcion_categoria in cbox_tipo.Items)
                {
                    if (Convert.ToInt32(opcion_categoria.Valor) == _objeto.oCategoria.Id_categoria)
                    {
                        cbox_tipo_index = cbox_tipo.Items.IndexOf(opcion_categoria);
                        break;
                    }
                }
                cbox_tipo.SelectedIndex = cbox_tipo_index;
            }
        }

        public void CrearNuevoObjeto()
        {
            _objeto = new Productos()
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
            var id_generada_producto = new CN_Productos().Create(_objeto, out var mensaje);
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

        public void EditarObjeto()
        {
            _objeto.Codigo_barras = txt_codigo_barras.Text;
            _objeto.Descripcion = txt_descripcion.Text;
            _objeto.oCategoria.Id_categoria = Convert.ToInt32(((OpcionCombo)cbox_tipo.SelectedItem).Valor);
            _objeto.Precio_costo = Convert.ToDecimal(txt_costo.Text);
            _objeto.Precio_venta = Convert.ToDecimal(txt_precio.Text);
            _objeto.Stock_actual = Convert.ToInt32(txt_cantidad.Text);
            _objeto.Stock_minimo = Convert.ToInt32(txt_stock_minimo.Text);
            _objeto.Estado = Convert.ToBoolean(((OpcionCombo)cbox_estado.SelectedItem).Valor);

            if (new CN_Productos().Modificar(_objeto, out var mensaje) == false)
            {
                _ = MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                _ = MessageBox.Show("Producto actualizado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }
        }

        public bool ValidarDatos()
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

        public void RespaldoDatosObjeto()
        {
            _objetoAnterior = new Productos
            {
                Id_producto = _objeto.Id_producto,
                Codigo_barras = _objeto.Codigo_barras,
                Descripcion = _objeto.Descripcion,
                oCategoria = new Categorias() { Id_categoria = _objeto.oCategoria.Id_categoria },
                Precio_costo = _objeto.Precio_costo,
                Precio_venta = _objeto.Precio_venta,
                Stock_actual = _objeto.Stock_actual,
                Stock_minimo = _objeto.Stock_minimo,
                Estado = _objeto.Estado
            };
        }

        private void NoLetras(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                //_ = MessageBox.Show("Ingresa solo valores numericos positivos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        public void btn_guardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (_objeto.Id_producto == 0)
                {
                    CrearNuevoObjeto();
                }
                else
                {
                    EditarObjeto();
                }
            }
        }

        public void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void btn_reiniciar_datos_Click(object sender, EventArgs e)
        {
            if (_objetoAnterior != null)
            {
                txt_codigo_barras.Text = _objetoAnterior.Codigo_barras;
                cbox_tipo.SelectedIndex = _objetoAnterior.oCategoria.Id_categoria - 1;
                txt_cantidad.Text = _objetoAnterior.Stock_actual.ToString();
                cbox_estado.SelectedIndex = _objetoAnterior.Estado == true ? 0 : 1;
                txt_descripcion.Text = _objetoAnterior.Descripcion;
                txt_stock_minimo.Text = _objetoAnterior.Stock_minimo.ToString();
                txt_costo.Text = _objetoAnterior.Precio_costo.ToString();
                txt_precio.Text = _objetoAnterior.Precio_venta.ToString();
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
