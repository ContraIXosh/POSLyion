using CapaEntidad;
using CapaNegocio;
using POSLyion.Resources;
using System;
using System.Windows.Forms;

namespace POSLyion
{

    public partial class formProveedoresAlta : Form
    {
        private Proveedores _proveedor;
        private Proveedores _proveedorAnterior;

        public formProveedoresAlta()
        {
            InitializeComponent();
            _proveedor = new Proveedores();
        }

        public formProveedoresAlta(Proveedores oProveedor)
        {
            InitializeComponent();
            _proveedor = oProveedor;
        }

        private void formProveedoresAlta_Load(object sender, EventArgs e)
        {
            CargarManejadoresEventos();
            CargarValoresPorDefecto();
            CargarDatosProveedor();
            KeyPreview = true;
        }

        private void CargarManejadoresEventos()
        {
            txt_telefono.KeyPress += new KeyPressEventHandler(NoLetras);
            txt_cuit.KeyPress += new KeyPressEventHandler(NoLetras);
        }

        private void CargarValoresPorDefecto()
        {
            cbo_estado.Visible = false;
            lbl_estado.Visible = false;
            btn_reiniciar_datos.Visible = false;

            _ = cbo_estado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            _ = cbo_estado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Inactivo" });
            cbo_estado.DisplayMember = "Texto";
            cbo_estado.ValueMember = "Valor";
        }

        private void CargarDatosProveedor()
        {
            if (_proveedor.Id_proveedor != null)
            {
                CargarRespaldoProveedor();
                cbo_estado.Visible = true;
                lbl_estado.Visible = true;
                btn_reiniciar_datos.Visible = true;

                var cbo_state_index = 0;
                txt_id.Text = _proveedor.Id_proveedor.ToString();
                txt_cuit.Text = _proveedor.Cuit;
                txt_descripcion.Text = _proveedor.Descripcion;
                txt_correo.Text = _proveedor.Correo;
                txt_telefono.Text = _proveedor.Telefono;
                foreach (OpcionCombo opcion_estado in cbo_estado.Items)
                {
                    if (Convert.ToInt32(opcion_estado.Valor) == (_proveedor.Estado == true ? 1 : 0))
                    {
                        cbo_state_index = cbo_estado.Items.IndexOf(opcion_estado);
                        break;
                    }
                }
                cbo_estado.SelectedIndex = cbo_state_index;
            }
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            if (ClientSize.Width > 1000 && ClientSize.Height > 700)
            {
                AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                panel_add.Left = ClientSize.Width - panel_add.Width;
                panel_footer.Left = ClientSize.Width - panel_footer.Width;
                btn_cerrar.Width = 150;
                btn_cerrar.Left = ClientSize.Width - btn_cerrar.Width;
            }
            else
            {
                AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                panel_add.Left = ClientSize.Width - panel_add.Width;
                panel_footer.Left = ClientSize.Width - panel_footer.Width;
                btn_cerrar.Left = ClientSize.Width - btn_cerrar.Width;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (_proveedor.Id_proveedor == null)
                {
                    GenerarProveedor();
                    CrearNuevoProveedor();
                    Close();
                }
                else
                {
                    EditarProveedor();
                }
            }
        }

        private void GenerarProveedor()
        {
            _proveedor = new Proveedores()
            {
                Cuit = txt_cuit.Text,
                Descripcion = txt_descripcion.Text,
                Correo = txt_correo.Text,
                Telefono = txt_telefono.Text,
            };
        }

        private void EditarProveedor()
        {
            _proveedor.Cuit = txt_cuit.Text;
            _proveedor.Descripcion = txt_descripcion.Text;
            _proveedor.Correo = txt_correo.Text;
            _proveedor.Telefono = txt_telefono.Text;
            _proveedor.Estado = Convert.ToInt32(((OpcionCombo)cbo_estado.SelectedItem).Valor) == 1;

            if (new CN_Proveedores().Modificar(_proveedor, out var mensaje))
            {
                _ = MessageBox.Show("Proveedor actualizado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }
            else
            {
                _ = MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CrearNuevoProveedor()
        {
            if (new CN_Proveedores().Crear(_proveedor, out var mensaje) == 0)
            {
                _ = MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                _ = MessageBox.Show("Proveedor generado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }
        }

        private void CargarRespaldoProveedor()
        {
            _proveedorAnterior = new Proveedores
            {
                Id_proveedor = _proveedor.Id_proveedor,
                Descripcion = _proveedor.Descripcion,
                Cuit = _proveedor.Cuit,
                Correo = _proveedor.Correo,
                Telefono = _proveedor.Telefono,
                Estado = _proveedor.Estado
            };
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NoLetras(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool ValidarDatos()
        {
            var resultado = true;
            if (txt_descripcion.Text == "")
            {
                resultado = false;
                errorProvider1.SetError(txt_descripcion, "Inserte un nombre para el proveedor");
            }
            return resultado;
        }

        private void btn_reiniciar_datos_Click(object sender, EventArgs e)
        {
            txt_descripcion.Text = _proveedorAnterior.Descripcion;
            txt_telefono.Text = _proveedorAnterior.Telefono;
            txt_cuit.Text = _proveedorAnterior.Cuit;
            txt_correo.Text = _proveedorAnterior.Correo;
            cbo_estado.SelectedIndex = _proveedorAnterior.Estado ? 0 : 1;
        }

        private void formProveedoresAlta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
