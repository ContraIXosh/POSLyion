using CapaEntidad;
using CapaNegocio;
using POSLyion.Resources;
using POSLyion.Resources.Interfaces;
using System;
using System.Windows.Forms;

namespace POSLyion
{
    public partial class formClientesAlta : Form, IFormCRUD
    {
        private Clientes _objeto;
        private Clientes _objetoAnterior;

        public formClientesAlta()
        {
            InitializeComponent();
            _objeto = new Clientes();
        }

        public formClientesAlta(Clientes oCliente)
        {
            InitializeComponent();
            _objeto = oCliente;
        }

        private void formClientesAlta_Load(object sender, EventArgs e)
        {
            CargarManejadoresEventos();
            CargarValoresPorDefecto();
            MostrarDatosObjeto();
            KeyPreview = true;
        }

        public void CargarManejadoresEventos()
        {
            txt_dni.KeyPress += new KeyPressEventHandler(NoLetras);
            txt_telefono.KeyPress += new KeyPressEventHandler(NoLetras);
        }

        public void CargarValoresPorDefecto()
        {
            lbl_estado.Visible = false;
            cbox_estado.Visible = false;
            btn_reiniciar_datos.Visible = false;

            _ = cbox_estado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            _ = cbox_estado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Inactivo" });

            cbox_estado.DisplayMember = "Texto";
            cbox_estado.ValueMember = "Valor";

            cbox_estado.SelectedIndex = 0;
        }

        public void MostrarDatosObjeto()
        {
            if (_objeto.Id_cliente != 0)
            {
                RespaldoDatosObjeto();

                lbl_estado.Visible = true;
                cbox_estado.Visible = true;
                btn_reiniciar_datos.Visible = true;

                txt_nombre_completo.Text = _objeto.Nombre_completo;
                txt_correo.Text = _objeto.Correo;
                txt_dni.Text = _objeto.Dni;
                txt_telefono.Text = _objeto.Telefono;
                num_descuento.Value = _objeto.Descuento;

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
            }
        }

        public void CrearNuevoObjeto()
        {
            _objeto = new Clientes()
            {
                Dni = txt_dni.Text,
                Nombre_completo = txt_nombre_completo.Text,
                Correo = txt_correo.Text,
                Telefono = txt_telefono.Text,
                Descuento = Convert.ToInt32(num_descuento.Value)
            };

            if (new CN_Clientes().Crear(_objeto, out var mensaje) == 0)
            {
                _ = MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                _ = MessageBox.Show("Cliente generado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }
        }

        public void EditarObjeto()
        {
            _objeto.Dni = txt_dni.Text;
            _objeto.Nombre_completo = txt_nombre_completo.Text;
            _objeto.Correo = txt_correo.Text;
            _objeto.Telefono = txt_telefono.Text;
            _objeto.Estado = Convert.ToInt32(((OpcionCombo)cbox_estado.SelectedItem).Valor) == 1;
            _objeto.Descuento = Convert.ToInt32(num_descuento.Value);

            if (new CN_Clientes().Modificar(_objeto, out var mensaje) == false)
            {
                _ = MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                _ = MessageBox.Show("Cliente actualizado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }
        }

        public bool ValidarDatos()
        {
            var resultado = true;
            if (txt_nombre_completo.Text == "")
            {
                resultado = false;
                errorProvider1.SetError(txt_nombre_completo, "Ingrese un nombre para el cliente");
            }
            return resultado;
        }

        public void RespaldoDatosObjeto()
        {
            _objetoAnterior = new Clientes
            {
                Id_cliente = _objeto.Id_cliente,
                Dni = _objeto.Dni,
                Nombre_completo = _objeto.Nombre_completo,
                Correo = _objeto.Correo,
                Telefono = _objeto.Telefono,
                Estado = _objeto.Estado
            };
        }

        private void NoLetras(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void btn_guardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (_objeto.Id_cliente == 0)
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
                txt_nombre_completo.Text = _objetoAnterior.Nombre_completo;
                cbox_estado.SelectedIndex = _objetoAnterior.Estado == true ? 0 : 1;
                txt_correo.Text = _objetoAnterior.Correo;
                txt_dni.Text = _objetoAnterior.Dni;
                txt_telefono.Text = _objetoAnterior.Telefono;
                num_descuento.Value = _objetoAnterior.Descuento;
            }
        }

        private void formClientesAlta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void panel_footer_Resize_1(object sender, EventArgs e)
        {
            if (ClientSize.Width > 1000 && ClientSize.Height > 700)
            {
                AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            }
            else
            {
                AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            }
        }
    }
}
