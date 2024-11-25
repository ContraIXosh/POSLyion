using CapaEntidad;
using CapaNegocio;
using POSLyion.Resources;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace POSLyion
{

    public partial class formProveedoresAlta : Form
    {
        private static readonly Usuarios oUsuario = new Usuarios();
        private Proveedores Proveedor;
        private Proveedores Anterior_proveedor;

        public formProveedoresAlta()
        {
            InitializeComponent();
            Proveedor = new Proveedores();
        }

        public formProveedoresAlta(Proveedores oProveedor)
        {
            InitializeComponent();
            Proveedor = oProveedor;
        }

        private void formProveedoresAlta_Load(object sender, EventArgs e)
        {
            _ = cbo_estado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            _ = cbo_estado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Inactivo" });
            cbo_estado.DisplayMember = "Texto";
            cbo_estado.ValueMember = "Valor";

            if (Proveedor.Id_proveedor == null)
            {
                txt_id.Text = "0";
                cbo_estado.Visible = false;
                lbl_estado.Visible = false;
            }
            else
            {
                var cbo_state_index = 0;
                txt_id.Text = Proveedor.Id_proveedor.ToString();
                txt_cuit.Text = Proveedor.Cuit;
                txt_descripcion.Text = Proveedor.Descripcion;
                txt_correo.Text = Proveedor.Correo;
                txt_telefono.Text = Proveedor.Telefono;
                foreach (OpcionCombo opcion_estado in cbo_estado.Items)
                {
                    if (Convert.ToInt32(opcion_estado.Valor) == (Proveedor.Estado == true ? 1 : 0))
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
            string mensaje;
            if (txt_id.Text == "0")
            {
                Proveedor = new Proveedores()
                {
                    Cuit = txt_cuit.Text,
                    Descripcion = txt_descripcion.Text,
                    Correo = txt_correo.Text,
                    Telefono = txt_telefono.Text,
                };
                var id_generada_proveedor = new CN_Proveedores().Crear(Proveedor, out mensaje);
                if (id_generada_proveedor == 0)
                {
                    _ = MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    _ = MessageBox.Show("Proveedor generado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Close();
                }
            }
            else
            {
                Anterior_proveedor = new Proveedores
                {
                    Id_proveedor = Proveedor.Id_proveedor,
                    Cuit = Proveedor.Cuit,
                    Correo = Proveedor.Correo,
                    Telefono = Proveedor.Telefono,
                    Estado = Proveedor.Estado
                };
                Proveedor.Cuit = txt_cuit.Text;
                Proveedor.Descripcion = txt_descripcion.Text;
                Proveedor.Correo = txt_correo.Text;
                Proveedor.Telefono = txt_telefono.Text;
                Proveedor.Estado = Convert.ToInt32(((OpcionCombo)cbo_estado.SelectedItem).Valor) == 1;
                var resultado = new CN_Proveedores().Modificar(Proveedor, out mensaje);
                _ = resultado == false
                    ? MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    : MessageBox.Show("Proveedor actualizado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_telefono_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                _ = MessageBox.Show("Ingresa solo valores numericos positivos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txt_cuit_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                _ = MessageBox.Show("Ingresa solo valores numericos positivos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txt_correo_Validating_1(object sender, CancelEventArgs e)
        {
            var email = txt_correo.Text; var pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; if (!Regex.IsMatch(email, pattern))
            {
                e.Cancel = true;
                txt_correo.BackColor = Color.LightCoral;
                _ = MessageBox.Show("Ingresa un correo electrónico válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txt_correo.BackColor = SystemColors.Window;
            }
        }
    }
}
