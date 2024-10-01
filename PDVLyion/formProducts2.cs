using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDCLyion
{
    public partial class formProducts2 : Form
    {
        public formProducts2()
        {
            InitializeComponent();
        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_cod.Text) || string.IsNullOrEmpty(txt_desc.Text) || string.IsNullOrEmpty(txt_precio.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else{
                MessageBox.Show("Se guardo el producto con exito", "¡Guardado exitoso!", MessageBoxButtons.OK);
            }

            
            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_cod__TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_cod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
                MessageBox.Show("Ingrese solo numeros");
            }
        }

        private void txt_cod2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { 
                e.Handled = true;
                MessageBox.Show("Por favor, solo introduzca números.", "Valor desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txt_desc__TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
                MessageBox.Show("Por favor, solo introduzca números.", "Valor desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_costo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
                MessageBox.Show("Por favor, solo introduzca números.", "Valor desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_ganancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
                MessageBox.Show("Por favor, solo introduzca números.", "Valor desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
                MessageBox.Show("Por favor, solo introduzca números.", "Valor desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_precio2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
                MessageBox.Show("Por favor, solo introduzca números.", "Valor desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_descuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
                MessageBox.Show("Por favor, solo introduzca números.", "Valor desconocido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cb_active_CheckedChanged(object sender, EventArgs e)
        {
            cb_active.Checked = true;
        }
    }
}
