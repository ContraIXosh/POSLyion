using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using POSLyion.Resources;
using static System.Windows.Forms.AxHost;

namespace POSLyion
{

    public partial class formProveedoresAlta : Form
    {
        private static Usuarios oUsuario = new Usuarios();
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
            cbo_estado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cbo_estado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Inactivo" });
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
                int cbo_state_index = 0;
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
            if (this.ClientSize.Width > 1000 && this.ClientSize.Height > 700)
            {
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                panel_add.Left = this.ClientSize.Width - panel_add.Width;
                panel_footer.Left = this.ClientSize.Width - panel_footer.Width;
                btn_cerrar.Width = 150;
                btn_cerrar.Left = this.ClientSize.Width - btn_cerrar.Width;
            }
            else
            {
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                panel_add.Left = this.ClientSize.Width - panel_add.Width;
                panel_footer.Left = this.ClientSize.Width - panel_footer.Width;
                btn_cerrar.Left = this.ClientSize.Width - btn_cerrar.Width;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            if (txt_id.Text == "0")
            {
                Proveedor = new Proveedores()
                {
                    Cuit = txt_cuit.Text,
                    Descripcion = txt_descripcion.Text,
                    Correo = txt_correo.Text,
                    Telefono = txt_telefono.Text,
                };
                int id_generada_proveedor = new CN_Proveedores().Crear(Proveedor, out mensaje);
                if (id_generada_proveedor == 0)
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Proveedor generado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
            }
            else
            {
                Anterior_proveedor = new Proveedores();
                Anterior_proveedor.Id_proveedor = Proveedor.Id_proveedor;
                Anterior_proveedor.Cuit = Proveedor.Cuit;
                Anterior_proveedor.Correo = Proveedor.Correo;
                Anterior_proveedor.Telefono = Proveedor.Telefono;
                Anterior_proveedor.Estado = Proveedor.Estado;
                Proveedor.Cuit = txt_cuit.Text;
                Proveedor.Descripcion = txt_descripcion.Text;
                Proveedor.Correo = txt_correo.Text;
                Proveedor.Telefono = txt_telefono.Text;
                Proveedor.Estado = Convert.ToInt32(((OpcionCombo)cbo_estado.SelectedItem).Valor) == 1 ? true : false;
                bool resultado = false;
                resultado = new CN_Proveedores().Modificar(Proveedor, out mensaje);
                if (resultado == false)
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Proveedor actualizado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_telefono_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Ingresa solo valores numericos positivos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txt_cuit_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Ingresa solo valores numericos positivos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txt_correo_Validating_1(object sender, CancelEventArgs e)
        {
            string email = txt_correo.Text; string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; if (!Regex.IsMatch(email, pattern))
            {
                e.Cancel = true;
                txt_correo.BackColor = Color.LightCoral;
                MessageBox.Show("Ingresa un correo electrónico válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txt_correo.BackColor = SystemColors.Window;
            }
        }
    }
}
