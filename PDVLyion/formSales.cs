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
    public partial class formSales : Form
    {
        public formSales()
        {
            InitializeComponent();
        }

        private void mostrarHistorialSell()
        {
            float precio = 0;
            float total = precio;

            if (precio > 0)
            {

            }
            panel_container.Controls.Clear();
            DataGridView dgvCompra = new DataGridView();
            dgvCompra.Columns.Add("Hora", "Hora");
            dgvCompra.Columns.Add("Precio", "Precio");
            dgvCompra.Columns.Add("Productos", "Productos");
            dgvCompra.Columns.Add("Fecha", "Fecha");
            dgvCompra.Rows.Add("16:52:16", "$1620", "Last product", "10/02/2025");
            dgvCompra.Rows.Add("16:53:42", "$1920", "Last product", "10/02/2025");
            panel_container.Controls.Add(dgvCompra);

            dgvCompra.Columns.Add("Fecha", "Fecha");
            dgvCompra.Columns.Add("Producto", "Producto");
            dgvCompra.Columns.Add("Precio", "Precio");

            dgvCompra.Rows.Add("01/10/2024", "Producto A", "$15");
            dgvCompra.Rows.Add("02/10/2024", "Producto B", "$25");
            panel_container.Controls.Add(dgvCompra, 0, 0);

            DataGridView dgvAmpliar = new DataGridView();
            dgvCompra.Columns.Add("Fecha", "Fecha");
            dgvCompra.Columns.Add("Producto", "Producto");
            dgvCompra.Columns.Add("Cantidad", "Cantidad");
            dgvCompra.Columns.Add("Precio", "precio");
            dgvCompra.Rows.Add("01/10/2024", "Salsa golf LC", "8", precio = 3999);
            dgvCompra.Rows.Add("01/10/2024", "Heineken lata 473", "6", precio = 124);
            dgvCompra.Rows.Add("01/10/2024", "Amstel lata 473", "15", precio = 15);
            dgvCompra.Rows.Add("Total =", total);
        }

        private void MostrarFacturacion()
        {
            panel_container.Controls.Clear();
            ListBox lstProductos = new ListBox();
            lstProductos.Items.Add("Producto 1 - $10");
            lstProductos.Items.Add("Producto 2 - $20");
            panel_container.Controls.Add(lstProductos);
        }

        private void mostrarHistorialBuy()
        {
            panel_container.Controls.Clear();
            DataGridView dgvCompra = new DataGridView();


        }
        private void formSales_Resize(object sender, EventArgs e)
        {
            if (this.ClientSize.Width > 1000 && this.ClientSize.Height > 700)
            {
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                panel_right.Width = 500;
                panel_right.Height = 860;
                panel_right.Left = this.ClientSize.Width - panel_right.Width;


            }
            else
            {
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                panel_right.Width = 280;
                panel_right.Height = 455;
                panel_right.Left = this.ClientSize.Width - panel_right.Width;
            }
        }

        private void btn_Down_Click(object sender, EventArgs e)
        {
        }

        private void btn_hamb_Click(object sender, EventArgs e)
        {

        }

        private void btn_factura_Click(object sender, EventArgs e)
        {
            lbl_titulo.Text = "Facturación";
            MostrarFacturacion();
        }

        private void btn_venta_Click(object sender, EventArgs e)
        {
            lbl_titulo.Text = "Historial de Ventas";
            mostrarHistorialSell();
        }

        private void btn_compra_Click(object sender, EventArgs e)
        {
            lbl_titulo.Text = "Historial de compras";
            mostrarHistorialBuy();
        }
    }
}
