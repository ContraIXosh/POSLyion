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
    public partial class formClientesAlta : Form
    {
        private static readonly Usuarios oUsuario = new Usuarios();
        private readonly Clientes Cliente;
        private Clientes Anterior_Cliente;

        public formClientesAlta()
        {
            InitializeComponent();
            Cliente = new Clientes();
        }

        public formClientesAlta(Clientes oCliente)
        {
            InitializeComponent();
            Cliente = oCliente;
        }

        private void formClientesAlta_Load(object sender, EventArgs e)
        {
            _ = cbo_estado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            _ = cbo_estado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Inactivo" });
            cbo_estado.DisplayMember = "Texto";
            cbo_estado.ValueMember = "Valor";

            var cbo_estado_index = 0;

            if (Cliente.Id_cliente == null)
            {
                cbo_estado.SelectedIndex = 0;
            }
            else
            {
                txt_id.Text = Cliente.Id_cliente.ToString();
                txt_nombre_completo.Text = Cliente.Nombre_completo;
                txt_correo.Text = Cliente.Correo;
                txt_dni.Text = Cliente.Dni;
                txt_telefono.Text = Cliente.Telefono;
                foreach (OpcionCombo opcion_estado in cbo_estado.Items)
                {
                    if (Convert.ToInt32(opcion_estado.Valor) == (Cliente.Estado == true ? 1 : 0))
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
            string mensaje;
            if (Convert.ToInt32(txt_id.Text) == 0)
            {
                var oCliente = new Clientes()
                {
                    Dni = txt_dni.Text,
                    Nombre_completo = txt_nombre_completo.Text,
                    Correo = txt_correo.Text,
                    Telefono = txt_telefono.Text,
                    Descuento = Convert.ToInt32(num_descuento.Value)
                };
                var id_generada_cliente = new CN_Clientes().Crear(oCliente, out mensaje);
                if (id_generada_cliente == 0)
                {
                    _ = MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    _ = MessageBox.Show("Cliente generado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Close();
                }
            }
            else
            {
                Anterior_Cliente = new Clientes
                {
                    Id_cliente = Cliente.Id_cliente,
                    Dni = Cliente.Dni,
                    Nombre_completo = Cliente.Nombre_completo,
                    Correo = Cliente.Correo,
                    Telefono = Cliente.Telefono,
                    Estado = Cliente.Estado
                };
                Cliente.Dni = txt_dni.Text;
                Cliente.Nombre_completo = txt_nombre_completo.Text;
                Cliente.Correo = txt_correo.Text;
                Cliente.Telefono = txt_telefono.Text;
                Cliente.Estado = Convert.ToInt32(((OpcionCombo)cbo_estado.SelectedItem).Valor) == 1;
                Cliente.Descuento = Convert.ToInt32(num_descuento.Value);
                var resultado = new CN_Clientes().Modificar(Cliente, out mensaje);
                if (resultado == false)
                {
                    _ = MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    _ = MessageBox.Show("Cliente actualizado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Close();
                }
            }
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

        private void txt_correo_Validating(object sender, CancelEventArgs e)
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

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                _ = MessageBox.Show("Ingresa solo valores numericos positivos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                _ = MessageBox.Show("Ingresa solo valores numericos positivos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
    }
}
