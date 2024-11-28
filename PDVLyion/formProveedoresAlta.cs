using CapaEntidad;
using CapaNegocio;
using POSLyion.Resources;
using POSLyion.Resources.Interfaces;
using System;
using System.Windows.Forms;

namespace POSLyion
{

    public partial class formProveedoresAlta : Form, IFormCRUD
    {
        private Proveedores _objeto;
        private Proveedores _objetoAnterior;

        public formProveedoresAlta()
        {
            InitializeComponent();
            _objeto = new Proveedores();
        }

        public formProveedoresAlta(Proveedores oProveedor)
        {
            InitializeComponent();
            _objeto = oProveedor;
        }

        private void formProveedoresAlta_Load(object sender, EventArgs e)
        {
            CargarValoresPorDefecto();
            MostrarDatosObjeto();
            CargarManejadoresEventos();
            KeyPreview = true;
        }

        public void CargarManejadoresEventos()
        {
            txt_telefono.KeyPress += new KeyPressEventHandler(NoLetras);
            txt_cuit.KeyPress += new KeyPressEventHandler(NoLetras);
        }

        public void CargarValoresPorDefecto()
        {
            cbox_estado.Visible = false;
            lbl_estado.Visible = false;
            btn_reiniciar_datos.Visible = false;

            _ = cbox_estado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            _ = cbox_estado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Inactivo" });
            cbox_estado.DisplayMember = "Texto";
            cbox_estado.ValueMember = "Valor";

            cbox_estado.SelectedIndex = 0;
        }

        public void MostrarDatosObjeto()
        {
            if (_objeto.Id_proveedor != 0)
            {
                RespaldoDatosObjeto();

                lbl_estado.Visible = true;
                cbox_estado.Visible = true;
                btn_reiniciar_datos.Visible = true;


                txt_cuit.Text = _objeto.Cuit;
                txt_descripcion.Text = _objeto.Descripcion;
                txt_correo.Text = _objeto.Correo;
                txt_telefono.Text = _objeto.Telefono;

                var cbox_state_index = 0;
                foreach (OpcionCombo opcion_estado in cbox_estado.Items)
                {
                    if (Convert.ToInt32(opcion_estado.Valor) == (_objeto.Estado == true ? 1 : 0))
                    {
                        cbox_state_index = cbox_estado.Items.IndexOf(opcion_estado);
                        break;
                    }
                }
                cbox_estado.SelectedIndex = cbox_state_index;
            }
        }

        public void CrearNuevoObjeto()
        {
            _objeto = new Proveedores()
            {
                Cuit = txt_cuit.Text,
                Descripcion = txt_descripcion.Text,
                Correo = txt_correo.Text,
                Telefono = txt_telefono.Text,
            };

            if (new CN_Proveedores().Crear(_objeto, out var mensaje) == 0)
            {
                _ = MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                _ = MessageBox.Show("Proveedor generado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }
        }

        public void EditarObjeto()
        {
            _objeto.Cuit = txt_cuit.Text;
            _objeto.Descripcion = txt_descripcion.Text;
            _objeto.Correo = txt_correo.Text;
            _objeto.Telefono = txt_telefono.Text;
            _objeto.Estado = Convert.ToInt32(((OpcionCombo)cbox_estado.SelectedItem).Valor) == 1;

            if (new CN_Proveedores().Modificar(_objeto, out var mensaje) == false)
            {
                _ = MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                _ = MessageBox.Show("Proveedor actualizado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }
        }

        public bool ValidarDatos()
        {
            var resultado = true;
            if (txt_descripcion.Text == "")
            {
                resultado = false;
                errorProvider1.SetError(txt_descripcion, "Inserte un nombre para el proveedor");
            }
            return resultado;
        }

        public void RespaldoDatosObjeto()
        {
            _objetoAnterior = new Proveedores
            {
                Id_proveedor = _objeto.Id_proveedor,
                Descripcion = _objeto.Descripcion,
                Cuit = _objeto.Cuit,
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
                if (_objeto.Id_proveedor == 0)
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
            txt_descripcion.Text = _objetoAnterior.Descripcion;
            txt_telefono.Text = _objetoAnterior.Telefono;
            txt_cuit.Text = _objetoAnterior.Cuit;
            txt_correo.Text = _objetoAnterior.Correo;
            cbox_estado.SelectedIndex = _objetoAnterior.Estado ? 0 : 1;
        }

        private void formProveedoresAlta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
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

    }
}
