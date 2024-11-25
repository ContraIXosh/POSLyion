using CapaEntidad;
using CapaEntidad.Filtros;
using CapaNegocio;
using POSLyion.Modals;
using POSLyion.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace POSLyion
{
    public partial class formCompras : Form
    {

        private static Compras oCompra;
        private readonly int index = -1;
        private readonly List<Productos> _lista_productos = new List<Productos>();
        private bool _flag_descripcion_producto_TextChanged = false;

        public formCompras()
        {
            InitializeComponent();
            var filtros_producto = new FiltrosProducto();
            _lista_productos = new CN_Productos().Leer(filtros_producto);
        }

        private void formCompras_Load(object sender, EventArgs e)
        {
            _ = cbo_tipo_documento.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });
            _ = cbo_tipo_documento.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            cbo_tipo_documento.DisplayMember = "Texto";
            cbo_tipo_documento.ValueMember = "Valor";
            cbo_tipo_documento.SelectedIndex = 0;

            var filtros_proveedor = new FiltrosProveedor();
            var lista_proveedores = new CN_Proveedores().Leer(filtros_proveedor);
            foreach (var oProveedor in lista_proveedores)
            {
                _ = cbox_proveedores.Items.Add(new OpcionCombo() { Valor = oProveedor.Id_proveedor, Texto = oProveedor.Descripcion });
            }
            cbox_proveedores.DisplayMember = "Texto";
            cbox_proveedores.ValueMember = "Valor";
            cbox_proveedores.SelectedIndex = 0;
            txt_codigo_barras.Select();
        }

        private void btn_buscar_producto_Click(object sender, EventArgs e)
        {
            using (var modal = new MD_Productos())
            {
                var resultado = modal.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    txt_codigo_barras.Text = modal.oProducto.Codigo_barras.ToString();
                    txt_id_producto.Text = modal.oProducto.Id_producto.ToString();
                    _flag_descripcion_producto_TextChanged = true;
                    txt_descripcion_producto.Text = modal.oProducto.Descripcion.ToString();
                    _flag_descripcion_producto_TextChanged = false;
                    num_cantidad.Select();
                    //lbox_productos.Visible = false;
                }
            }
        }

        // Simula un ENTER en el textbox de código de barras
        // Al insertar el código de un producto, e inmediatamente presionar ENTER,
        // se busca el producto solicitado en la base de datos y el textbox se pinta de un color
        private void txt_codigo_barras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                var oProducto = _lista_productos.Where(p => p.Codigo_barras == txt_codigo_barras.Text).FirstOrDefault();
                if (oProducto != null)
                {
                    txt_codigo_barras.BackColor = Color.Honeydew;
                    txt_id_producto.Text = oProducto.Id_producto.ToString();
                    _flag_descripcion_producto_TextChanged = true;
                    txt_descripcion_producto.Text = oProducto.Descripcion.ToString();
                    _flag_descripcion_producto_TextChanged = false;
                    num_cantidad.Select();
                }
                else
                {
                    txt_codigo_barras.BackColor = Color.MistyRose;
                    lbox_productos.Visible = false;
                    txt_id_producto.Text = "";
                    _flag_descripcion_producto_TextChanged = true;
                    txt_descripcion_producto.Text = "";
                    _flag_descripcion_producto_TextChanged = false;
                }
            }
        }

        private void txt_descripcion_producto_TextChanged(object sender, EventArgs e)
        {
            if (_flag_descripcion_producto_TextChanged == true)
            {
                return;
            }
            if (txt_descripcion_producto.Text == "")
            {
                lbox_productos.Visible = false;
                return;
            }
            // Convertir el texto ingresado a minúsculas
            var filtro = txt_descripcion_producto.Text.ToLower();

            // Filtrar los productos que coinciden con la descripción ingresada
            var productosFiltrados = _lista_productos
                .Where(p => p.Descripcion.ToLower().Contains(filtro))
                .ToList();

            // Almacenar las descripciones de los productos filtrados
            var nombres_producto = productosFiltrados
                .Select(p => p.Descripcion)
                .ToList();

            // Limpiar el ListBox y añadir los elementos filtrados
            lbox_productos.Items.Clear();
            lbox_productos.Items.AddRange(nombres_producto.ToArray());

            // Hacer visible el ListBox
            lbox_productos.Visible = true;
        }

        private void lbox_productos_Click(object sender, EventArgs e)
        {
            if (lbox_productos.SelectedItem != null)
            {
                SeleccionarProducto();
            }
        }

        private void txt_descripcion_producto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (lbox_productos.Items.Count > 0)
                {
                    lbox_productos.SelectedIndex = 0;
                    _ = lbox_productos.Focus();
                }
            }
        }

        private void lbox_productos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && lbox_productos.Focused)
            {
                SeleccionarProducto();
            }
        }

        private void SeleccionarProducto()
        {
            txt_id_producto.Text = _lista_productos.Where(p => p.Descripcion == lbox_productos.Text).FirstOrDefault().Id_producto.ToString();
            txt_codigo_barras.Text = _lista_productos.Where(p => p.Descripcion == lbox_productos.Text).FirstOrDefault().Codigo_barras;
            txt_descripcion_producto.Text = lbox_productos.SelectedItem.ToString();
            lbox_productos.Visible = false;
        }

        private void btn_agregar_producto_Click(object sender, EventArgs e)
        {
            var producto_existe = false;
            var indice_fila = 0;
            var mensaje = string.Empty;

            // Se realizan verificaciones antes de insertarlo al DGV
            if (txt_id_producto.Text == "")
            {
                _ = MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txt_precio_costo.Text, out _))
            {
                _ = MessageBox.Show("Formato de moneda incorrecto en precio de costo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_precio_costo.Select();
                return;
            }
            if (num_cantidad.Value == 0)
            {
                mensaje += "Falta la cantidad\n";
            }
            if (mensaje != string.Empty)
            {
                _ = MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            // Verifica si el producto ya existe en el DGV.
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
                var precio_costo = Convert.ToDecimal(txt_precio_costo.Text);
                _ = dgv_compras.Rows.Add(new object[]
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
                Limpiar();
            }
            // Si el producto que se intenta insertar al DGV ya fué agregado anteriormente, se suma la cantidad
            // de producto solicitada y se vuelve a calcular el subtotal, luego se limpian los campos
            // y se calcula el total nuevamente.
            else if (producto_existe)
            {
                var precio_unitario = Convert.ToDecimal(dgv_compras.Rows[indice_fila].Cells["precio_costo"].Value.ToString());
                var cantidad =
    Convert.ToInt32(dgv_compras.Rows[indice_fila].Cells["cantidad"].Value.ToString())
    +
    num_cantidad.Value;
                var subtotal = cantidad * precio_unitario;
                dgv_compras.Rows[indice_fila].Cells["cantidad"].Value = cantidad.ToString();
                dgv_compras.Rows[indice_fila].Cells["subtotal"].Value = subtotal.ToString("0.00");
            }
        }

        // Si se presiona la celda "Eliminar" del DGV, 
        // se remueve dicha fila y se calcula nuevamente el total de la compra
        private void dgv_compras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_compras.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {
                var indice = e.RowIndex;
                if (indice >= 0)
                {
                    dgv_compras.Rows.RemoveAt(indice);
                    CalcularTotal();
                }
            }
            if (dgv_compras.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                var descripcion_producto = dgv_compras.Rows[e.RowIndex].Cells["descripcion_producto"].Value.ToString();
                var cantidad_actual = Convert.ToInt32(dgv_compras.Rows[e.RowIndex].Cells["cantidad"].Value);
                var nueva_cantidad = 0;
                using (var md_editarCantidad = new MD_EditarCantidad(descripcion_producto, cantidad_actual))
                {
                    _ = md_editarCantidad.ShowDialog();
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
                        CalcularTotal();
                    }
                    else
                    {
                        dgv_compras.Rows[e.RowIndex].Cells["cantidad"].Value = 1;
                    }
                }
                else
                {
                    var precio_unitario = Convert.ToDecimal(dgv_compras.Rows[e.RowIndex].Cells["precio_costo"].Value);
                    dgv_compras.Rows[e.RowIndex].Cells["cantidad"].Value = nueva_cantidad;
                    dgv_compras.Rows[e.RowIndex].Cells["subtotal"].Value = nueva_cantidad * precio_unitario;
                    CalcularTotal();
                }
            }
        }

        // Guarda el registro de una compra
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(((OpcionCombo)cbox_proveedores.SelectedItem).Valor) == 1)
            {
                _ = MessageBox.Show("Debe elegir un proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // Se verifica si existe al menos un producto ingresado
            if (dgv_compras.Rows.Count < 1)
            {
                _ = MessageBox.Show("Debe ingresar al menos un producto en la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // Recolección de datos 
                var id_proveedor = Convert.ToInt32(((OpcionCombo)cbox_proveedores.SelectedItem).Valor);
                var total = Convert.ToDecimal(lbl_suma_total.Text);
                var tipo_documento = ((OpcionCombo)cbo_tipo_documento.SelectedItem).Texto;
                var numero_documento = txt_numero_documento.Texts;
                var fecha_documento = date_fecha_doc.Value.ToString("yyyy-MM-dd");
                // Se crea un DataTable para almacenar todos los productos 
                // agregados al DGV y llevarlo a una tabla temporal en la base de datos [ECompra_Detalle]
                var datatable_compra_detalle = new DataTable();
                _ = datatable_compra_detalle.Columns.Add("Id_Producto", typeof(int));
                _ = datatable_compra_detalle.Columns.Add("Precio", typeof(decimal));
                _ = datatable_compra_detalle.Columns.Add("Cantidad", typeof(int));
                _ = datatable_compra_detalle.Columns.Add("Subtotal", typeof(decimal));
                _ = datatable_compra_detalle.Columns.Add("NuevoCosto", typeof(decimal));
                foreach (DataGridViewRow fila in dgv_compras.Rows)
                {
                    var producto = new CN_Productos().BuscarUnProducto(Convert.ToInt32(fila.Cells["id_producto"].Value));
                    var costo_anterior = producto.Precio_costo;
                    var costo_nuevo = Convert.ToDecimal(fila.Cells["precio_costo"].Value);
                    var cantidad_anterior = producto.Stock_actual;
                    var cantidad_nueva = Convert.ToInt32(fila.Cells["cantidad"].Value);
                    var operacion1 = (costo_anterior * Math.Abs(cantidad_anterior)) + (costo_nuevo * cantidad_nueva);
                    decimal operacion2 = Math.Abs(cantidad_anterior) + cantidad_nueva;
                    var calculo_costo = operacion1 / operacion2;
                    _ = datatable_compra_detalle.Rows.Add(new object[]
                    {
                        Convert.ToInt32(fila.Cells["id_producto"].Value.ToString()),
                        fila.Cells["precio_costo"].Value.ToString(),
                        fila.Cells["cantidad"].Value.ToString(),
                        fila.Cells["subtotal"].Value.ToString(),
                        calculo_costo
                    });
                }

                // Se crea el registro Compra "cabecera"
                oCompra = new Compras()
                {
                    oUsuario = new Usuarios() { Id_usuario = VariablesGlobales.Usuario_actual.Id_usuario },
                    oProveedor = new Proveedores() { Id_proveedor = id_proveedor },
                    Total = total,
                    Tipo_documento = tipo_documento,
                    Numero_documento = numero_documento,
                    Fecha_documento = fecha_documento
                };

                // Se intenta registrar la compra mediante la capa de negocios, 
                // se eliminan todos los datos y se vuelve a dejar el total en 0
                var respuesta = new CN_Compras().Crear(oCompra, datatable_compra_detalle, out var mensaje);
                if (respuesta)
                {
                    _ = MessageBox.Show("Compra registrada con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbox_proveedores.SelectedIndex = 0;
                    txt_numero_documento.Texts = "";
                    cbo_tipo_documento.SelectedIndex = 0;
                    txt_cuit_proveedor.Text = "";
                    dgv_compras.Rows.Clear();
                    CalcularTotal();
                    Close();
                }
                else
                {
                    _ = MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Validaciones necesarias para evitar que el usuario ingrese caracteres que no se deben en este textbox
        // o cantidades con 0 por izquierda
        private void txt_precio_costo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                if (txt_precio_costo.Text.Trim().Length == 0 && (e.KeyChar.ToString() == "0"))
                {
                    _ = MessageBox.Show("Ingrese solo valores numericos mayores a 0", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning); e.Handled = true;
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
                    _ = MessageBox.Show("Ingrese solo valores numericos mayores a 0", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning); e.Handled = true;
                    e.Handled = true;
                }
                else
                {
                    if (char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ",")
                    {

                        e.Handled = false;
                    }
                    else
                    {
                        _ = MessageBox.Show("Ingrese solo valores numericos mayores a 0", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning); e.Handled = true;

                        e.Handled = true;
                    }
                    if (e.KeyChar == 13)
                    {
                        btn_agregar_producto_Click(sender, e);
                    }
                }
            }
        }

        private void Limpiar()
        {
            _flag_descripcion_producto_TextChanged = true;
            LimpiarProductos();
            _flag_descripcion_producto_TextChanged = false;
            CalcularTotal();
            txt_codigo_barras.Select();
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
                lbl_suma_total.Text = "0,00";
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Busca un proveedor mediante un modal
        //private void txt_descripcion_proveedor_Click(object sender, EventArgs e)
        //{
        //    using (var modal = new MD_Proveedores())
        //    {
        //        var resultado = modal.ShowDialog();
        //        if (resultado == DialogResult.OK)
        //        {
        //            txt_id_proveedor.Text = modal.oProveedor.Id_proveedor.ToString();
        //            txt_descripcion_proveedor.Text = modal.oProveedor.Descripcion.ToString();
        //            txt_cuit_proveedor.Text = modal.oProveedor.Cuit.ToString();
        //        }
        //    }
        //}

        // Busca un producto mediante un modal
        //private void lbox_productos_MouseMove(object sender, MouseEventArgs e)
        //{
        //    int x = lbox_productos.IndexFromPoint(e.Location);
        //    if (x != index)
        //    {
        //        index = x;
        //        lbox_productos.Invalidate();
        //    }
        //}

        //private void lbox_productos_DrawItem(object sender, DrawItemEventArgs e)
        //{
        //    e.DrawBackground();
        //    if (e.Index == index)
        //    {
        //        e.Graphics.FillRectangle(Brushes.Crimson, e.Bounds);
        //        e.Graphics.DrawString(lbox_productos.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds);
        //    }
        //}
    }
}
