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
            CargarComboBox();
            txt_codigo_barras.Select();
            KeyPreview = true;
        }

        private void CargarComboBox()
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
        }

        private void btn_buscar_producto_Click(object sender, EventArgs e)
        {
            using (var modalProductos = new MD_Productos())
            {
                var resultado = modalProductos.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    CargarProductoSeleccionado(modalProductos);
                }
            }
        }

        private void CargarProductoSeleccionado(MD_Productos modalProductos)
        {
            txt_codigo_barras.Text = modalProductos.oProducto.Codigo_barras.ToString();
            txt_id_producto.Text = modalProductos.oProducto.Id_producto.ToString();
            _flag_descripcion_producto_TextChanged = true;
            txt_descripcion_producto.Text = modalProductos.oProducto.Descripcion.ToString();
            _flag_descripcion_producto_TextChanged = false;
            num_cantidad.Text = "";
            num_cantidad.Select();
        }

        private void txt_codigo_barras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                var oProducto = _lista_productos.Where(p => p.Codigo_barras == txt_codigo_barras.Text).FirstOrDefault();

                if (oProducto != null)
                {
                    MostrarProductoCodigoBarras(oProducto);
                }
                else
                {
                    ProductoNoEncontrado();
                }
            }
        }

        private void MostrarProductoCodigoBarras(Productos oProducto)
        {
            txt_codigo_barras.BackColor = Color.Honeydew;
            txt_id_producto.Text = oProducto.Id_producto.ToString();
            _flag_descripcion_producto_TextChanged = true;
            txt_descripcion_producto.Text = oProducto.Descripcion.ToString();
            _flag_descripcion_producto_TextChanged = false;
            num_cantidad.Text = "";
            num_cantidad.Select();
        }

        private void ProductoNoEncontrado()
        {
            txt_codigo_barras.BackColor = Color.MistyRose;
            lbox_productos.Visible = false;
            txt_id_producto.Text = "";
            _flag_descripcion_producto_TextChanged = true;
            txt_descripcion_producto.Text = "";
            _flag_descripcion_producto_TextChanged = false;
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

        private void SeleccionarProducto()
        {
            txt_id_producto.Text = _lista_productos.Where(p => p.Descripcion == lbox_productos.Text).FirstOrDefault().Id_producto.ToString();
            txt_codigo_barras.Text = _lista_productos.Where(p => p.Descripcion == lbox_productos.Text).FirstOrDefault().Codigo_barras;
            txt_descripcion_producto.Text = lbox_productos.SelectedItem.ToString();
            lbox_productos.Visible = false;
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

        private void btn_agregar_producto_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (!VerificarExistenciaProducto(out var indiceFilaProducto))
                {
                    AgregarProducto();
                }
                else
                {
                    EditarProducto(indiceFilaProducto);
                }
                Limpiar();
            }
        }

        private void AgregarProducto()
        {
            var precioCosto = Convert.ToDecimal(txt_precio_costo.Text);
            _ = dgv_compras.Rows.Add(new object[]
            {
                        txt_id_producto.Text,
                        txt_codigo_barras.Text,
                        txt_descripcion_producto.Text,
                        num_cantidad.Value.ToString(),
                        precioCosto.ToString(),
                        (num_cantidad.Value * precioCosto).ToString("0.00"),
                        "Editar cantidad",
                        "Eliminar producto"
            });
        }

        private void EditarProducto(int indiceFilaProducto)
        {
            var precioUnitario = Convert.ToDecimal(dgv_compras.Rows[indiceFilaProducto].Cells["precio_costo"].Value.ToString());

            if (precioUnitario != Convert.ToDecimal(txt_precio_costo.Text))
            {
                var resultado = MessageBox.Show($"¿Desea sobreescribir el precio de costo?\n" +
                    $"Precio anterior: {precioUnitario}\n" +
                    $"Nuevo precio: {Convert.ToDecimal(txt_precio_costo.Text)}",
                    "Mensaje",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    precioUnitario = Convert.ToDecimal(txt_precio_costo.Text);
                    dgv_compras.Rows[indiceFilaProducto].Cells["precio_costo"].Value = precioUnitario;
                }
            }

            var cantidad =
            Convert.ToInt32(dgv_compras.Rows[indiceFilaProducto].Cells["cantidad"].Value.ToString())
            +
            num_cantidad.Value;
            var subtotal = cantidad * precioUnitario;
            dgv_compras.Rows[indiceFilaProducto].Cells["cantidad"].Value = cantidad.ToString();
            dgv_compras.Rows[indiceFilaProducto].Cells["subtotal"].Value = subtotal.ToString("0.00");
        }

        private bool ValidarDatos()
        {
            var resultado = true;
            if (txt_id_producto.Text == "")
            {
                resultado = false;
                errorProvider1.SetError(txt_descripcion_producto, "Debe seleccionar un producto");
            }
            if (!decimal.TryParse(txt_precio_costo.Text, out _))
            {
                resultado = false;
                errorProvider2.SetError(txt_precio_costo, "Formato de moneda incorrecto");
                txt_precio_costo.Select();
            }
            if (num_cantidad.Value == 0)
            {
                resultado = false;
                errorProvider3.SetError(num_cantidad, "Ingrese una cantidad");
            }
            return resultado;
        }

        private bool VerificarExistenciaProducto(out int indiceFilaProducto)
        {
            var resultado = false;
            indiceFilaProducto = 0;
            foreach (DataGridViewRow fila in dgv_compras.Rows)
            {
                if (fila.Cells["id_producto"].Value.ToString() == txt_id_producto.Text)
                {
                    resultado = true;
                    indiceFilaProducto = fila.Index;
                    break;
                }
            }
            return resultado;
        }

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
                var descripcionProducto = dgv_compras.Rows[e.RowIndex].Cells["descripcion_producto"].Value.ToString();
                var cantidadActual = Convert.ToInt32(dgv_compras.Rows[e.RowIndex].Cells["cantidad"].Value);
                var nuevaCantidad = 0;

                using (var md_editarCantidad = new MD_EditarCantidad(descripcionProducto, cantidadActual))
                {
                    _ = md_editarCantidad.ShowDialog();
                    nuevaCantidad = md_editarCantidad.nueva_cantidad;
                }

                VerificarCantidadIngresada(nuevaCantidad, e);
            }
        }

        private void VerificarCantidadIngresada(int nuevaCantidad, DataGridViewCellEventArgs e)
        {
            if (nuevaCantidad < 1)
            {
                ManejarCantidadInvalida(e);
            }
            else
            {
                var precio_unitario = Convert.ToDecimal(dgv_compras.Rows[e.RowIndex].Cells["precio_costo"].Value);
                dgv_compras.Rows[e.RowIndex].Cells["cantidad"].Value = nuevaCantidad;
                dgv_compras.Rows[e.RowIndex].Cells["subtotal"].Value = nuevaCantidad * precio_unitario;
                CalcularTotal();
            }
        }

        private void ManejarCantidadInvalida(DataGridViewCellEventArgs e)
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

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (cbox_proveedores.SelectedIndex == 0)
            {
                errorProvider4.SetError(cbox_proveedores, "Debe elegir un proveedor");
                return;
            }
            // Se verifica si existe al menos un producto ingresado
            if (dgv_compras.Rows.Count < 1)
            {
                _ = MessageBox.Show("Debe ingresar al menos un producto en la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var dataTable = GenerarCompraDetalles();
                var oCompra = GenerarCompraCabecera();

                if (new CN_Compras().Crear(oCompra, dataTable, out var mensaje))
                {
                    _ = MessageBox.Show("Compra registrada con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbox_proveedores.SelectedIndex = 0;
                    txt_numero_documento.Texts = "";
                    cbo_tipo_documento.SelectedIndex = 0;
                    txt_cuit_proveedor.Text = "";
                    dgv_compras.Rows.Clear();
                    BorrarMensajesError();
                    CalcularTotal();
                    Close();
                }
                else
                {
                    _ = MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BorrarMensajesError()
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();
        }

        private Compras GenerarCompraCabecera()
        {
            var id_proveedor = Convert.ToInt32(((OpcionCombo)cbox_proveedores.SelectedItem).Valor);
            var total = Convert.ToDecimal(lbl_suma_total.Text);
            var tipo_documento = ((OpcionCombo)cbo_tipo_documento.SelectedItem).Texto;
            var numero_documento = txt_numero_documento.Texts;
            var fecha_documento = date_fecha_doc.Value.ToString("yyyy-MM-dd");

            var oCompra = new Compras()
            {
                oUsuario = new Usuarios() { Id_usuario = VariablesGlobales.Usuario_actual.Id_usuario },
                oProveedor = new Proveedores() { Id_proveedor = id_proveedor },
                Total = total,
                Tipo_documento = tipo_documento,
                Numero_documento = numero_documento,
                Fecha_documento = fecha_documento
            };

            return oCompra;
        }

        private DataTable GenerarCompraDetalles()
        {
            var dataTable = CrearDataTable();

            foreach (DataGridViewRow filaProducto in dgv_compras.Rows)
            {
                var nuevoCostoProducto = CalcularCostoProducto(filaProducto);

                _ = dataTable.Rows.Add(new object[]
                {
                        Convert.ToInt32(filaProducto.Cells["id_producto"].Value.ToString()),
                        filaProducto.Cells["precio_costo"].Value.ToString(),
                        filaProducto.Cells["cantidad"].Value.ToString(),
                        filaProducto.Cells["subtotal"].Value.ToString(),
                        nuevoCostoProducto
                });
            }
            return dataTable;
        }

        private DataTable CrearDataTable()
        {
            var dataTable = new DataTable();
            _ = dataTable.Columns.Add("Id_Producto", typeof(int));
            _ = dataTable.Columns.Add("Precio", typeof(decimal));
            _ = dataTable.Columns.Add("Cantidad", typeof(int));
            _ = dataTable.Columns.Add("Subtotal", typeof(decimal));
            _ = dataTable.Columns.Add("NuevoCosto", typeof(decimal));

            return dataTable;
        }

        private decimal CalcularCostoProducto(DataGridViewRow filaProducto)
        {
            var oProducto = new CN_Productos().BuscarUnProducto(Convert.ToInt32(filaProducto.Cells["id_producto"].Value));
            var costoAnterior = oProducto.Precio_costo;
            var cantidadAnterior = oProducto.Stock_actual;
            var costoNuevo = Convert.ToDecimal(filaProducto.Cells["precio_costo"].Value);
            var cantidadNueva = Convert.ToInt32(filaProducto.Cells["cantidad"].Value);
            var nuevoCostoProducto = ((costoAnterior * Math.Abs(cantidadAnterior)) + (costoNuevo * cantidadNueva)) / (Math.Abs(cantidadAnterior) + cantidadNueva);
            return nuevoCostoProducto;
        }

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
            BorrarMensajesError();
            Close();
        }

        private void formCompras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
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
