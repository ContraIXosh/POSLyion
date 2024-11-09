using CapaEntidad;
using CapaNegocio;
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
    public partial class formEstadsticas : Form
    {

        public formEstadsticas()
        {
            InitializeComponent();
        }

        private void btn_ver_ventas_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            string fecha_formato = fecha.ToString("yyyy-MM-dd");
            this.MostrarReporte("Numero de venta");
            List<ReportesDetalle> lista_ventas = new CN_Reportes().Venta_Detalle(fecha_formato, fecha_formato, 0);
            foreach(ReportesDetalle venta in lista_ventas)
            {
                dgv_historial.Rows.Add(new object[]
                {
                    venta.Id,
                    venta.Codigo_barras,
                    venta.Nombre_producto,
                    venta.Nombre_categoria,
                    venta.Precio_unitario,
                    venta.Cantidad,
                    venta.Subtotal,
                    venta.UsuarioRegistro,
                    venta.Fecha
                });
            }
        }

        private void btn_ver_compras_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            string fecha_formato = fecha.ToString("yyyy-MM-dd");
            this.MostrarReporte("Numero de venta");
            List<ReportesDetalle> lista_compras = new CN_Reportes().Compra_Detalle(fecha_formato, fecha_formato, 0);
            foreach (ReportesDetalle venta in lista_compras)
            {
                dgv_historial.Rows.Add(new object[]
                {
                    venta.Id,
                    venta.Codigo_barras,
                    venta.Nombre_producto,
                    venta.Nombre_categoria,
                    venta.Precio_unitario,
                    venta.Cantidad,
                    venta.Subtotal,
                    venta.UsuarioRegistro,
                    venta.Fecha
                });
            }
        }

        private void MostrarReporte(string caso)
        {
            dgv_historial.Columns.Clear();
            dgv_historial.Rows.Clear();
            dgv_historial.Columns.Add("id", caso);
            dgv_historial.Columns.Add("codigo_barras", "Código de barras");
            dgv_historial.Columns.Add("descripcion", "Producto");
            dgv_historial.Columns.Add("categoria", "Categoría");
            dgv_historial.Columns.Add("precio_unitario", "Precio unitario");
            dgv_historial.Columns.Add("cantidad", "Cantidad");
            dgv_historial.Columns.Add("subtotal", "Subtotal");
            dgv_historial.Columns.Add("usuario_registro", "Usuario");
            dgv_historial.Columns.Add("fecha_venta", "Fecha y hora");
            dgv_historial.Visible = true;
            dgv_historial.Dock = DockStyle.Fill;
        }
    }
}
