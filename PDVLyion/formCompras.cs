using POSLyion.Resources;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSLyion.Modals;
using CapaNegocio;
using LiveCharts.Helpers;
using Google.Protobuf.WellKnownTypes;
using PDCLyion.Modals;

namespace POSLyion
{
    public partial class formCompras : Form
    {

        private static Usuarios oUsuario = new Usuarios();
        private static Compras oCompra;
        private int index = -1;

        public formCompras(Usuarios usuario)
        {
            InitializeComponent();
            oUsuario = usuario;
        }

        private void formCompras_Load(object sender, EventArgs e)
        {
            cbo_tipo_documento.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });
            cbo_tipo_documento.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            cbo_tipo_documento.DisplayMember = "Texto";
            cbo_tipo_documento.ValueMember = "Valor";
            cbo_tipo_documento.SelectedIndex = 0;
            txt_codigo_barras.Select();
        }

        // <resumen>
        // Busca un proveedor mediante un modal
        // <resumen>
        private void txt_descripcion_proveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new MD_Proveedores())
            {
                var resultado = modal.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    txt_id_proveedor.Text = modal.oProveedor.Id_proveedor.ToString();
                    txt_descripcion_proveedor.Text = modal.oProveedor.Descripcion.ToString();
                    txt_cuit_proveedor.Text = modal.oProveedor.Cuit.ToString();
                }
            }
        }

        // <resumen>
        // Busca un producto mediante un modal
        // <resumen>
        private void btn_buscar_producto_Click(object sender, EventArgs e)
        {
            using (var modal = new MD_Productos())
            {
                var resultado = modal.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    txt_codigo_barras.Text = modal.oProducto.Codigo_barras.ToString();
                    txt_id_producto.Text = modal.oProducto.Id_producto.ToString();
                    txt_descripcion_producto.Text = modal.oProducto.Descripcion.ToString();
                    num_cantidad.Select();
                    lbox_productos.Visible = false;
                }
            }
        }

        // <resumen>
        // Simula un ENTER en el textbox de código de barras
        // Al insertar el código de un producto, e inmediatamente presionar ENTER,
        // se busca el producto solicitado en la base de datos y el textbox se pinta de un color
        // <resumen>
        private void txt_codigo_barras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Productos oProducto = new CN_Productos().Leer().Where(p => p.Codigo_barras == txt_codigo_barras.Text && p.Estado == true).FirstOrDefault();
                if (oProducto != null)
                {
                    txt_codigo_barras.BackColor = Color.Honeydew;
                    txt_id_producto.Text = oProducto.Id_producto.ToString();
                    txt_descripcion_producto.Text = oProducto.Descripcion.ToString();
                    num_cantidad.Select();
                }
                else
                {
                    txt_codigo_barras.BackColor = Color.MistyRose;
                    txt_id_producto.Text = "0";
                    txt_descripcion_producto.Text = "";
                }
            }
        }

        //private void txt_descripcion_producto_TextChanged(object sender, EventArgs e)
        //{
        //    List<Productos> lista_productos = new CN_Productos().Leer();
        //    lbox_productos.Items.Clear();
        //    string consulta = txt_descripcion_producto.Text.ToLower();
        //    var resultado = lista_productos.Where(p => p.Descripcion.ToLower().Contains(consulta)).ToList();
        //    if (resultado.Any())
        //    {
        //        lbox_productos.Visible = true;
        //        foreach (Productos producto in resultado)
        //        {
        //            lbox_productos.Items.Add(producto.Descripcion);
        //        }
        //    }
        //    else
        //    {
        //        lbox_productos.Visible = false;
        //    }
        //}

        //private void lbox_productos_Click(object sender, EventArgs e)
        //{
        //    if (lbox_productos.SelectedItems != null)
        //    {
        //        txt_descripcion_producto.Text = lbox_productos.SelectedItem.ToString();
        //        lbox_productos.Visible = false;
        //    }
        //}

        // <resumen>
        // Si se presiona la celda "Eliminar" del DGV, 
        // se remueve dicha fila y se calcula nuevamente el total de la compra
        // <resumen>
        private void dgv_compras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_compras.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    dgv_compras.Rows.RemoveAt(indice);
                    this.CalcularTotal();
                }
            }
            if (dgv_compras.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                string descripcion_producto = dgv_compras.Rows[e.RowIndex].Cells["descripcion_producto"].Value.ToString();
                int cantidad_actual = Convert.ToInt32(dgv_compras.Rows[e.RowIndex].Cells["cantidad"].Value);
                int nueva_cantidad = 0;
                using (var md_editarCantidad = new MD_EditarCantidad(descripcion_producto, cantidad_actual))
                {
                    md_editarCantidad.ShowDialog();
                    nueva_cantidad = md_editarCantidad.nueva_cantidad;
                }
                // Verifica si la cantidad ingresada es mayor a 0 o no es nula
                if (nueva_cantidad < 1)
                {
                    var resultado_dialogo = MessageBox.Show("La cantidad ingresada es menor a 1. \n¿Desea eliminar el producto del registro?", "Mensaje",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado_dialogo == DialogResult.Yes)
                    {
                        dgv_compras.Rows.RemoveAt(e.RowIndex);
                        this.CalcularTotal();
                    }
                    else
                    {
                        dgv_compras.Rows[e.RowIndex].Cells["cantidad"].Value = 1;
                    }
                }
                else
                {
                    dgv_compras.Rows[e.RowIndex].Cells["cantidad"].Value = nueva_cantidad;
                }
            }
        }

        // <resumen>
        // Guarda el registro de una compra
        // <resumen>
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            int? id_proveedor = null;
            // Se verifica si existe al menos un producto ingresado
            if (dgv_compras.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar al menos un producto en la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Se crea un DataTable para almacenar todos los productos 
            // agregados al DGV y llevarlo a una tabla temporal en la base de datos [ECompra_Detalle]
            DataTable datatable_compra_detalle = new DataTable();
            datatable_compra_detalle.Columns.Add("Id_Producto", typeof(int));
            datatable_compra_detalle.Columns.Add("Precio", typeof(decimal));
            datatable_compra_detalle.Columns.Add("Cantidad", typeof(int));
            datatable_compra_detalle.Columns.Add("Subtotal", typeof(decimal));

            foreach (DataGridViewRow fila in dgv_compras.Rows)
            {
                datatable_compra_detalle.Rows.Add(new object[]
                {
                    Convert.ToInt32(fila.Cells["id_producto"].Value.ToString()),
                    fila.Cells["precio_costo"].Value.ToString(),
                    fila.Cells["cantidad"].Value.ToString(),
                    fila.Cells["subtotal"].Value.ToString()
                });
            }
            
            if(txt_id_proveedor.Text != "")
            {
                id_proveedor = Convert.ToInt32(txt_id_proveedor.Text);
            }
            // Se crea el registro Compra "cabecera"
            oCompra = new Compras()
            {
                oUsuario = new Usuarios() { Id_usuario = oUsuario.Id_usuario },
                oProveedor = new Proveedores() { Id_proveedor = id_proveedor},
                Total = Convert.ToDecimal(lbl_suma_total.Text),
                Tipo_documento = ((OpcionCombo)cbo_tipo_documento.SelectedItem).Texto,
                Numero_documento = txt_numero_documento.Text,
                Fecha_documento = date_fecha_doc.Value.ToString("yyyy-MM-dd")
            };

            // Se intenta registrar la compra mediante la capa de negocios, 
            // se eliminan todos los datos y se vuelve a dejar el total en 0
            string mensaje = string.Empty;
            bool respuesta = new CN_Compras().Crear(oCompra, datatable_compra_detalle, out mensaje);
            if (respuesta)
            {
                MessageBox.Show("Compra registrada con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_id_proveedor.Text = "";
                txt_descripcion_proveedor.Text = "";
                cbo_tipo_documento.SelectedIndex = 0;
                txt_cuit_proveedor.Text = "";
                dgv_compras.Rows.Clear();
                this.CalcularTotal();
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // <resumen>
        // Se agrega el producto seleccionado al DGV
        // <resumen>
        private void btn_agregar_producto_Click(object sender, EventArgs e)
        {
            bool producto_existe = false;
            int indice_fila = 0;
            decimal precio_costo = 0;
            string mensaje = string.Empty;

            // Se realizan verificaciones antes de insertarlo al DGV
            if (txt_id_producto.Text == "")
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!decimal.TryParse(txt_precio_costo.Text, out precio_costo))
            {
                MessageBox.Show("Formato de moneda incorrecto en precio de costo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_precio_costo.Select();
                return;
            }
            if (num_cantidad.Value == 0)
            {
                mensaje += "Falta la cantidad\n";
            }
            if (mensaje != string.Empty)
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            foreach (DataGridViewRow fila in dgv_compras.Rows)
            {
                if (fila.Cells["id_producto"].Value.ToString() == txt_id_producto.Text)
                {
                    producto_existe = true;
                    indice_fila = fila.Index;
                    break;
                }
            }

            // Si el producto que se intenta insertar al DGV no fué agregado anteriormente,
            // se inserta de forma normal, se limpian los campos escritos y se calcula el total
            if (!producto_existe && mensaje == string.Empty)
            {
                precio_costo = Convert.ToDecimal(txt_precio_costo.Text);
                dgv_compras.Rows.Add(new object[]
                {
                    txt_id_producto.Text,
                    txt_codigo_barras.Text,
                    txt_descripcion_producto.Text,
                    num_cantidad.Value.ToString(),
                    precio_costo.ToString(),
                    (num_cantidad.Value * precio_costo).ToString("0.00"),
                    "Editar cantidad",
                    "Eliminar producto"
                });
                this.LimpiarProductos();
                this.CalcularTotal();
                txt_codigo_barras.Select();
            }
            // Si el producto que se intenta insertar al DGV ya fué agregado anteriormente, se suma la cantidad
            // de producto solicitada y se vuelve a calcular el subtotal, luego se limpian los campos
            // y se calcula el total nuevamente.
            else if (producto_existe)
            {
                decimal cantidad = 0;
                decimal precio_unitario = 0;
                decimal subtotal = 0;
                precio_unitario = Convert.ToDecimal(dgv_compras.Rows[indice_fila].Cells["precio_costo"].Value.ToString());
                cantidad = 
                    Convert.ToInt32(dgv_compras.Rows[indice_fila].Cells["cantidad"].Value.ToString())
                    + 
                    num_cantidad.Value;
                subtotal = cantidad * precio_unitario;
                dgv_compras.Rows[indice_fila].Cells["cantidad"].Value = cantidad.ToString();
                dgv_compras.Rows[indice_fila].Cells["subtotal"].Value = subtotal.ToString("0.00");

                this.LimpiarProductos();
                this.CalcularTotal();
                txt_codigo_barras.Select();
            }
        }

        private void lbox_productos_MouseMove(object sender, MouseEventArgs e)
        {
            int x = lbox_productos.IndexFromPoint(e.Location);
            if (x != index)
            {
                index = x;
                lbox_productos.Invalidate();
            }
        }

        private void lbox_productos_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index == index)
            {
                e.Graphics.FillRectangle(Brushes.Crimson, e.Bounds);
                e.Graphics.DrawString(lbox_productos.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds);
            }
        }

        // <resumen>
        // Validaciones necesarias para evitar que el usuario
        // ingrese caracteres que no se deben en este textbox
        // o cantidades con 0 por izquierda
        // <resumen>
        private void txt_precio_costo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                if(txt_precio_costo.Text.Trim().Length == 0 && (e.KeyChar.ToString() == "0"))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (txt_precio_costo.Text.Trim().Length == 0 && (e.KeyChar.ToString() == ","))
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ",")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void LimpiarProductos()
        {
            txt_id_producto.Text = "";
            txt_codigo_barras.Text = "";
            txt_descripcion_producto.Text = "";
            num_cantidad.Value = 0;
            txt_precio_costo.Text = "";
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            if (dgv_compras.Rows.Count > 0)
            {
                foreach (DataGridViewRow fila in dgv_compras.Rows)
                {
                    total += Convert.ToDecimal(fila.Cells["subtotal"].Value.ToString());
                }
                lbl_suma_total.Text = total.ToString();
            }
            else
            {
                total = 0;
                lbl_suma_total.Text = "0,00";
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
