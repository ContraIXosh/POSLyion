using CapaEntidad;
using CapaNegocio;
using POSLyion.Resources;
using System;
using System.Windows.Forms;

namespace POSLyion
{
    public partial class formClientesAlta : Form
    {
        private static readonly Usuarios _oUsuario = new Usuarios();
        private readonly Clientes _cliente;
        private Clientes _clienteAnterior;

        public formClientesAlta()
        {
            InitializeComponent();
            _cliente = new Clientes();
        }

        public formClientesAlta(Clientes oCliente)
        {
            InitializeComponent();
            _cliente = oCliente;
        }

        private void formClientesAlta_Load(object sender, EventArgs e)
        {
            CargarValoresPorDefecto();
            CargarValoresCliente();
            CargarManejadoresEventos();
            KeyPreview = true;
        }

        private void CargarValoresPorDefecto()
        {
            lbl_estado.Visible = false;
            cbo_estado.Visible = false;
            btn_reiniciar_datos.Visible = false;

            _ = cbo_estado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            _ = cbo_estado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Inactivo" });
            cbo_estado.DisplayMember = "Texto";
            cbo_estado.ValueMember = "Valor";
            cbo_estado.SelectedIndex = 0;
        }

        private void CargarValoresCliente()
        {
            if (_cliente.Id_cliente != null)
            {
                lbl_estado.Visible = true;
                cbo_estado.Visible = true;
                btn_reiniciar_datos.Visible = true;
                GuardarRespaldoCliente();

                var cbo_estado_index = 0;
                txt_id.Text = _cliente.Id_cliente.ToString();
                txt_nombre_completo.Text = _cliente.Nombre_completo;
                txt_correo.Text = _cliente.Correo;
                txt_dni.Text = _cliente.Dni;
                txt_telefono.Text = _cliente.Telefono;
                num_descuento.Value = _cliente.Descuento;
                foreach (OpcionCombo opcion_estado in cbo_estado.Items)
                {
                    if (Convert.ToInt32(opcion_estado.Valor) == (_cliente.Estado == true ? 1 : 0))
                    {
                        cbo_estado_index = cbo_estado.Items.IndexOf(opcion_estado);
                        break;
                    }
                }
                cbo_estado.SelectedIndex = cbo_estado_index;
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

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (_cliente.Id_cliente == null)
                {
                    CrearNuevoCliente();
                }
                else
                {
                    EditarCliente();
                }
            }
        }

        private void CrearNuevoCliente()
        {
            var oCliente = new Clientes()
            {
                Dni = txt_dni.Text,
                Nombre_completo = txt_nombre_completo.Text,
                Correo = txt_correo.Text,
                Telefono = txt_telefono.Text,
                Descuento = Convert.ToInt32(num_descuento.Value)
            };

            if (new CN_Clientes().Crear(oCliente, out var mensaje) == 0)
            {
                _ = MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                _ = MessageBox.Show("Cliente generado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }
        }

        private void EditarCliente()
        {
            _cliente.Dni = txt_dni.Text;
            _cliente.Nombre_completo = txt_nombre_completo.Text;
            _cliente.Correo = txt_correo.Text;
            _cliente.Telefono = txt_telefono.Text;
            _cliente.Estado = Convert.ToInt32(((OpcionCombo)cbo_estado.SelectedItem).Valor) == 1;
            _cliente.Descuento = Convert.ToInt32(num_descuento.Value);

            if (new CN_Clientes().Modificar(_cliente, out var mensaje) == false)
            {
                _ = MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                _ = MessageBox.Show("Cliente actualizado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }
        }

        private bool ValidarDatos()
        {
            var resultado = true;
            if (txt_nombre_completo.Text == "")
            {
                resultado = false;
                errorProvider1.SetError(txt_nombre_completo, "Ingrese un nombre para el cliente");
            }
            return resultado;
        }

        private void GuardarRespaldoCliente()
        {
            _clienteAnterior = new Clientes
            {
                Id_cliente = _cliente.Id_cliente,
                Dni = _cliente.Dni,
                Nombre_completo = _cliente.Nombre_completo,
                Correo = _cliente.Correo,
                Telefono = _cliente.Telefono,
                Estado = _cliente.Estado
            };
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_nombre_completo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                _ = MessageBox.Show("Ingrese solo letras", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NoLetras(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CargarManejadoresEventos()
        {
            txt_dni.KeyPress += new KeyPressEventHandler(NoLetras);
            txt_telefono.KeyPress += new KeyPressEventHandler(NoLetras);
        }

        private void formClientesAlta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void btn_reiniciar_datos_Click(object sender, EventArgs e)
        {
            if (_clienteAnterior != null)
            {
                txt_nombre_completo.Text = _clienteAnterior.Nombre_completo;
                cbo_estado.SelectedIndex = _clienteAnterior.Estado == true ? 0 : 1;
                txt_correo.Text = _clienteAnterior.Correo;
                txt_dni.Text = _clienteAnterior.Dni;
                txt_telefono.Text = _clienteAnterior.Telefono;
                num_descuento.Value = _clienteAnterior.Descuento;
            }
        }
    }
}
