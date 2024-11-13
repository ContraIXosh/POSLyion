using CapaNegocio;
using CapaEntidad;
using POSLyion.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace POSLyion
{
    public partial class formClientesAlta : Form
    {
        private static Usuarios oUsuario = new Usuarios();
        private Clientes Cliente;
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
            cbo_estado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cbo_estado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Inactivo" });
            cbo_estado.DisplayMember = "Texto";
            cbo_estado.ValueMember = "Valor";

            int cbo_estado_index = 0;

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
            if (this.ClientSize.Width > 1000 && this.ClientSize.Height > 700)
            {
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            }
            else
            {
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            if (Convert.ToInt32(txt_id.Text) == 0)
            {
                Clientes oCliente = new Clientes()
                {
                    Dni = txt_dni.Text,
                    Nombre_completo = txt_nombre_completo.Text,
                    Correo = txt_correo.Text,
                    Telefono = txt_telefono.Text,
                    Descuento = Convert.ToInt32(num_descuento.Value)
                };
                int id_generada_cliente = new CN_Clientes().Crear(oCliente, out mensaje);
                if (id_generada_cliente == 0)
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Cliente generado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
            }
            else
            {
                Anterior_Cliente = new Clientes();
                Anterior_Cliente.Id_cliente = Cliente.Id_cliente;
                Anterior_Cliente.Dni = Cliente.Dni;
                Anterior_Cliente.Nombre_completo = Cliente.Nombre_completo;
                Anterior_Cliente.Correo = Cliente.Correo;
                Anterior_Cliente.Telefono = Cliente.Telefono;
                Anterior_Cliente.Estado = Cliente.Estado;
                Cliente.Dni = txt_dni.Text;
                Cliente.Nombre_completo = txt_nombre_completo.Text;
                Cliente.Correo = txt_correo.Text;
                Cliente.Telefono = txt_telefono.Text;
                Cliente.Estado = Convert.ToInt32(((OpcionCombo)cbo_estado.SelectedItem).Valor) == 1 ? true : false;
                Cliente.Descuento = Convert.ToInt32(num_descuento.Value);
                bool resultado = false;
                resultado = new CN_Clientes().Modificar(Cliente, out mensaje);
                if (resultado == false)
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Cliente actualizado con éxito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_nombre_completo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ingrese solo letras", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_correo_Validating(object sender, CancelEventArgs e)
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

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Ingresa solo valores numericos positivos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Ingresa solo valores numericos positivos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
    }
}
