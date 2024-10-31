using CapaNegocio;
using CapaEntidad;
using POSLyion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace POSLyion
{
    public partial class Start : Form
    {

        private static Usuarios oUser = new Usuarios();
        private decimal total = 0;

        public Start(Usuarios user)
        {
            InitializeComponent();
            oUser = user;
            lbl_usuario.Text = user.Nombre_completo;
        }

        private void Start_Load(object sender, EventArgs e)
        {
            txt_buscarproductos.Select();
        }

        // <resumen>
        // Busca productos en la base de datos que coincidan con la descripcion en el textbox
        // y agrega todos los resultados en dgv_productos
        // <resumen>
        private void txt_buscarproductos_TextChanged(object sender, EventArgs e)
        {
            dgv_productos.Rows.Clear();
            if (txt_buscarproductos.Text != "")
            {
                DataTable tabla_productos = new CN_Productos().Buscar(txt_buscarproductos.Text);
                foreach (DataRow fila in tabla_productos.Rows)
                {
                    dgv_productos.Rows.Add(new object[]
                    {
                        fila["ID"],
                        fila["Descripcion"],
                        fila["Precio"],
                        fila["Stock actual"],
                    });
                }
            }
        }

        // <resumen>
        // Si se selecciona una fila en dgv_productos, el producto se agrega al dgv_resumen
        // <resumen>

        private void dgv_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            decimal total = 0;
            int indice_fila = 0;
            bool productoExiste = false;
            if (e.RowIndex >= 0)
            {
                // Verifica si el producto ya está en el dgv_resumen
                foreach (DataGridViewRow fila in dgv_resumen.Rows)
                {
                    if (fila.Cells["dgv_resumen_id"].Value.ToString() == dgv_productos.Rows[e.RowIndex].Cells["dgv_productos_id"].Value.ToString())
                    {
                        productoExiste = true;
                        indice_fila = fila.Index;
                        break;
                    }
                }

                // Si el producto no existe en dgv_resumen, lo agrega con cantidad inicial de 1
                if (!productoExiste)
                {
                    dgv_resumen.Rows.Add(new object[] 
                    {
                        dgv_productos.Rows[e.RowIndex].Cells["dgv_productos_id"].Value.ToString(),
                        dgv_productos.Rows[e.RowIndex].Cells["dgv_productos_descripcion"].Value.ToString(),
                        1,
                        dgv_productos.Rows[e.RowIndex].Cells["dgv_productos_precio"].Value,
                        dgv_productos.Rows[e.RowIndex].Cells["dgv_productos_precio"].Value,
                        "Editar cantidad",
                        "Eliminar producto"
                    });
                    txt_buscarproductos.Text = "";
                    dgv_productos.Rows.Clear();
                    txt_buscarproductos.Select();
                }
                // Si el producto ya existe en dgv_resumen, suma a 1 la cantidad 
                // y vuelve a calcular el subtotal
                else
                {
                    dgv_resumen.Rows[indice_fila].Cells["dgv_resumen_cantidad"].Value =
                        Convert.ToInt32(dgv_resumen.Rows[indice_fila].Cells["dgv_resumen_cantidad"].Value) + 1;
                    dgv_resumen.Rows[indice_fila].Cells["dgv_resumen_subtotal"].Value = 
                        Convert.ToInt32(dgv_resumen.Rows[indice_fila].Cells["dgv_resumen_cantidad"].Value)
                        * 
                        Convert.ToDecimal(dgv_resumen.Rows[indice_fila].Cells["dgv_resumen_subtotal"].Value);
                    txt_buscarproductos.Text = "";
                    dgv_productos.Rows.Clear();
                    txt_buscarproductos.Select();
                }
            }
            this.CalcularTotal();
        }

        private void btn_cerrarventa_Click(object sender, EventArgs e)
        {
            if(dgv_resumen.Rows.Count > 0)
            {
                using (var formularioCobro = new formCambio(total, oUser))
                {
                    formularioCobro.ShowDialog();
                    // Después de cerrar, se obtiene el valor del vuelto
                    decimal vuelto = formularioCobro.vuelto;
                    // Start se suscribe al evento VentanaCerrada en cuanto sea invocado
                    formularioCobro.VentanaCerrada += formCambio_VentanaCerrada;
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar al menos un producto al carrito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgv_resumen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_resumen.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    dgv_resumen.Rows.RemoveAt(indice);
                    this.CalcularTotal();
                }
            }
            if (dgv_resumen.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                int indice_columna = dgv_resumen.Columns["dgv_resumen_cantidad"].Index;
                dgv_resumen.CurrentCell = dgv_resumen.Rows[e.RowIndex].Cells[indice_columna];
                dgv_resumen.BeginEdit(true);
            }
        }

        private void dgv_resumen_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_resumen.Columns[e.ColumnIndex].Name == "dgv_resumen_cantidad")
            {
                // Verifica si la cantidad ingresada es mayor a 0 o no es nula
                if (
                    Convert.ToInt32(dgv_resumen.Rows[e.RowIndex].Cells["dgv_resumen_cantidad"].Value) > 0
                    &&
                    dgv_resumen.Rows[e.RowIndex].Cells["dgv_resumen_cantidad"].Value.ToString() != null
                    )
                {
                    // Vuelve a calcular el subtotal con la nueva cantidad
                    dgv_resumen.Rows[e.RowIndex].Cells["dgv_resumen_subtotal"].Value =
                    Convert.ToInt32(dgv_resumen.Rows[e.RowIndex].Cells["dgv_resumen_cantidad"].Value)
                    *
                    Convert.ToDecimal(dgv_resumen.Rows[e.RowIndex].Cells["dgv_resumen_precio"].Value);
                    // Verificación de si hay 0 a la izquierda
                    // Obtiene el valor de la celda como texto
                    string valorCantidad = dgv_resumen.Rows[e.RowIndex].Cells["dgv_resumen_cantidad"].Value?.ToString();
                    // Si el valor no es nulo ni vacío, elimina los ceros a la izquierda
                    if (!string.IsNullOrEmpty(valorCantidad))
                    {
                        // Convierte el valor en un número para eliminar los ceros a la izquierda
                        if (int.TryParse(valorCantidad, out int cantidadSinCeros))
                        {
                            // Actualiza la celda con el valor sin ceros a la izquierda
                            dgv_resumen.Rows[e.RowIndex].Cells["dgv_resumen_cantidad"].Value = cantidadSinCeros.ToString();
                        }
                    }
                    this.CalcularTotal();
                }
                else
                {
                    var resultado_dialogo = MessageBox.Show("La cantidad ingresada es menor a 1. \n¿Desea eliminar el producto del carrito?", "Mensaje",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(resultado_dialogo == DialogResult.Yes)
                    {
                        dgv_resumen.Rows.RemoveAt(e.RowIndex);
                        this.CalcularTotal();
                    }
                    else
                    {
                        dgv_resumen.Rows[e.RowIndex].Cells["dgv_resumen_cantidad"].Value = 1;
                    }
                }
            }
        }

        private void dgv_resumen_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // Verifica si la columna editada es la de "cantidad"
            if (dgv_resumen.CurrentCell.ColumnIndex == dgv_resumen.Columns["dgv_resumen_cantidad"].Index)
            {
                // Remueve cualquier controlador existente para evitar duplicados
                e.Control.KeyPress -= new KeyPressEventHandler(ValidarEntradaNumeros);
                // Agrega el controlador para validar solo números
                e.Control.KeyPress += new KeyPressEventHandler(ValidarEntradaNumeros);
            }
            else
            {
                // Remueve el controlador si no es la columna "cantidad"
                e.Control.KeyPress -= new KeyPressEventHandler(ValidarEntradaNumeros);
            }
        }

        private void ValidarEntradaNumeros(object sender, KeyPressEventArgs e)
        {
            // Obtiene el control de edición del DataGridView
            TextBox celda = sender as TextBox;
            // Bloquea la entrada del "0" si es el primer carácter
            if (celda != null && celda.Text.Length == 0 && e.KeyChar == '0')
            {
                e.Handled = true; 
            }
            // Permitir solo números y teclas de control (como retroceso)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Anula la entrada de la tecla si no es un número
            }
        }


        // Si se invoca el evento VentanaCerrada, se limpia dgv_resumen y el total se vuelve a 0
        private void formCambio_VentanaCerrada(object sender, EventArgs e)
        {
            dgv_resumen.Rows.Clear();
            this.CalcularTotal();
        }

        private void CalcularTotal()
        {
            total = 0;
            if (dgv_resumen.Rows.Count > 0)
            {
                foreach (DataGridViewRow fila in dgv_resumen.Rows)
                {
                    total += Convert.ToDecimal(fila.Cells["dgv_resumen_subtotal"].Value.ToString());
                }
                lbl_suma_total.Text = total.ToString();
            }
            else
            {
                total = 0;
                lbl_suma_total.Text = "0,00";
            }
        }

        private void AbrirVentana(ToolStripMenuItem menu, Form fh)
        {

            if (panel_main.Controls.Count > 0)
                panel_main.Controls.RemoveAt(0);

            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;

            panel_main.Controls.Add(fh);
            panel_main.Tag = fh;
            fh.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoverStripMenu();
            AbrirVentana((ToolStripMenuItem)sender, new Start(oUser));
        }

        private void comprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formCompras compras = new formCompras(oUser);
            compras.Show();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirVentana(tsmenu_prods, new formProductos());
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirVentana(tsmenu_users, new formUsuarios());
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirVentana(tsmenu_clientes, new formClientes());
        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirVentana(tsmenu_proveedor, new formProveedores());
        }

        private void reportesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirVentana(tsmenu_reports, new formEstadsticas());
        }

        private void categoriasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirVentana(tsmenu_cat, new formCategorias());
        }

        private void configuraciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirVentana(tsmenu_config, new formConfiguracion());
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formLogOut logout = new formLogOut();
            logout.Show();
        }

        private void RemoverStripMenu()
        {
            foreach (Control control in this.Controls)
            {
                if (control is MenuStrip)
                {
                    this.Controls.Remove(control);
                }
            }
        }

        private void btn_compra_Click(object sender, EventArgs e)
        {
            lbl_titulo.Text = "Facturación";
            MostrarFacturacion();
        }

        private void btn_factura_Click(object sender, EventArgs e)
        {
            lbl_titulo.Text = "Historial de compra";
            mostrarHistorialSell();
        }

        private void btn_venta_Click(object sender, EventArgs e)
        {
            lbl_titulo.Text = "Historial de ventas";
            mostrarHistorialSell();
        }

        private void btn_cfinal_Click(object sender, EventArgs e)
        {
            lbl_tipoticket.Text = "CONSUMIDOR FINAL";
            btn_cfinal.ForeColor = Color.White;
            btn_cfinal.BackColor = Color.BlueViolet;
            btn_cfinal.Enabled = false;
            if (btn_eventual.Enabled == false)
            {
                btn_cfinal.ForeColor = Color.White;
                btn_cfinal.BackColor = Color.BlueViolet;
                btn_eventual.Enabled = true;
            }
        }

        private void btn_eventual_Click(object sender, EventArgs e)
        {
            lbl_tipoticket.Text = "EVENTUAL";
            btn_eventual.ForeColor = Color.White;
            btn_eventual.BackColor = Color.DarkMagenta;
            btn_eventual.Enabled = false;
            if (btn_cfinal.Enabled == false)
            {
                btn_eventual.ForeColor = Color.White;
                btn_eventual.BackColor = Color.DarkMagenta;
                btn_cfinal.Enabled = true;
            }
        }
        private void MostrarFacturacion()
        {
            panel_resumen.Controls.Clear();
            ListBox lstProductos = new ListBox();
            lstProductos.Items.Add("Producto 1 - $10");
            lstProductos.Items.Add("Producto 2 - $20");
            panel_resumen.Controls.Add(lstProductos);
        }

        private void mostrarHistorialBuy()
        {
            panel_resumen.Controls.Clear();
            DataGridView dgvCompra = new DataGridView();


        }
        private void mostrarHistorialSell()
        {
            float precio = 0;
            float total = precio;

            if (precio > 0)
            {

            }
            DataGridView dgvCompra = new DataGridView();
            dgvCompra.Columns.Add("Hora", "Hora");
            dgvCompra.Columns.Add("Precio", "Precio");
            dgvCompra.Columns.Add("Productos", "Productos");
            dgvCompra.Columns.Add("Fecha", "Fecha");
            dgvCompra.Rows.Add("16:52:16", "$1620", "Last product", "10/02/2025");
            dgvCompra.Rows.Add("16:53:42", "$1920", "Last product", "10/02/2025");
            panel_resumen.Controls.Add(dgvCompra);

            dgvCompra.Columns.Add("Fecha", "Fecha");
            dgvCompra.Columns.Add("Producto", "Producto");
            dgvCompra.Columns.Add("Precio", "Precio");

            dgvCompra.Rows.Add("01/10/2024", "Producto A", "$15");
            dgvCompra.Rows.Add("02/10/2024", "Producto B", "$25");

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

        DataGridView dgv_ampliar = new DataGridView();
        private void flagdgv()
        {
            if (!panel_container.Controls.Container.Contains(dgv_ampliar))
            {
                dgv_ampliar.Columns.Clear();
                dgv_ampliar.Columns.Add("prod", "Producto");
                dgv_ampliar.Columns.Add("cantidad", "Cantidad");
                dgv_ampliar.Columns.Add("precio", "Precio");

                lbl_total.Visible = true;
                lbl_total.Text = "0.00";
                panel_container.Controls.Add(dgv_ampliar, 0, 1);
                dgv_ampliar.Dock = DockStyle.Fill;
                dgv_resumen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_ampliar.BackgroundColor = Color.MediumSlateBlue;
                dgv_ampliar.BorderStyle = BorderStyle.None;
                dgv_ampliar.CellBorderStyle = DataGridViewCellBorderStyle.None;
                dgv_ampliar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgv_ampliar.ColumnHeadersDefaultCellStyle.BackColor = Color.Maroon;
                dgv_ampliar.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv_ampliar.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Maroon;
                dgv_ampliar.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
                dgv_ampliar.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                dgv_ampliar.RowHeadersVisible = false;
                dgv_ampliar.EnableHeadersVisualStyles = false;
                dgv_ampliar.AllowUserToAddRows = false;
                dgv_ampliar.AllowUserToDeleteRows = false;
                dgv_ampliar.AllowUserToResizeRows = false;
            }
        }

        private void btn_factura_Click_1(object sender, EventArgs e)
        {
            if (panel_container.Controls.Container.Contains(dgv_ampliar))
            {
                panel_container.Controls.Remove(dgv_ampliar);
                lbl_total.Visible = true;
            }
            dgv_resumen.Columns.Clear();
            dgv_resumen.Columns.Add("desc", "Producto");
            dgv_resumen.Columns.Add("cantidad", "Cantidad");
            dgv_resumen.Columns.Add("precio", "Precio");
            dgv_resumen.Dock = DockStyle.Fill;
            dgv_resumen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_resumen.Visible = true;
        }

        private void btn_compra_Click_1(object sender, EventArgs e)
        {
            flagdgv();
            dgv_resumen.Columns.Clear();
            dgv_resumen.Columns.Add("fecha", "Fecha");
            dgv_resumen.Columns.Add("hora", "Hora");
            dgv_resumen.Columns.Add("empresa", "Empresa");
            dgv_resumen.Columns.Add("cantidad", "Cantidad");

            dgv_ampliar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_resumen.Visible = true;
            dgv_resumen.Dock = DockStyle.Fill;

            panel_container.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panel_container.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            panel_container.Controls.Add(dgv_resumen, 0, 0);
        }

        private void btn_venta_Click_1(object sender, EventArgs e)
        {
            flagdgv();
            dgv_resumen.Columns.Clear();
            dgv_resumen.Columns.Add("fecha", "Fecha");
            dgv_resumen.Columns.Add("hora", "Hora");
            dgv_resumen.Columns.Add("Producto", "Producto");
            dgv_resumen.Columns.Add("cantidad", "Cantidad de Prods");

            dgv_ampliar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_resumen.Visible = true;
            dgv_resumen.Dock = DockStyle.Fill;

            panel_container.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panel_container.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

           
            panel_container.Controls.Add(dgv_resumen, 0, 0);
        }

        private void btn_eventual_Click_1(object sender, EventArgs e)
        {
            lbl_tipoticket.Text = "Eventual";
        }

        private void btn_cfinal_Click_1(object sender, EventArgs e)
        {
            lbl_tipoticket.Text = "Consumidor Final";
        } 
    }
}
