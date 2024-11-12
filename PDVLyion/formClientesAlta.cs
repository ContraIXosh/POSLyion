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
                txt_nombre_completo.Texts = Cliente.Nombre_completo;
                txt_correo.Texts = Cliente.Correo;
                txt_dni.Texts = Cliente.Dni;
                txt_telefono.Texts = Cliente.Telefono;
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
                    Dni = txt_dni.Texts,
                    Nombre_completo = txt_nombre_completo.Texts,
                    Correo = txt_correo.Texts,
                    Telefono = txt_telefono.Texts,
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
                Cliente.Dni = txt_dni.Texts;
                Cliente.Nombre_completo = txt_nombre_completo.Texts;
                Cliente.Correo = txt_correo.Texts;
                Cliente.Telefono = txt_telefono.Texts;
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
                }
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
