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
using PDCLyion.Modals;
using System.Runtime.Serialization;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using CapaEntidad.Filtros;
using PDCLyion;

namespace POSLyion
{
    public partial class Start : Form
    {
        DataGridView dgv_detalle = new DataGridView();
        private static Usuarios oUser = new Usuarios();
        private decimal total = 0;
        private decimal vuelto = 0;
        private string dgv_activo = "factura";
        private List<Ventas_Detalle> respaldo_carrito = new List<Ventas_Detalle>();
        private ToolStripMenuItem currentSelectedMenuItem;

        public Start(Usuarios user)
        {
            InitializeComponent();
            oUser = user;
            lbl_usuario.Text = user.Nombre_completo;
            this.KeyPreview = true;
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
            txt_buscarproductos.Select();
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
        // y a una lista de productos para respaldo
        // <resumen>
        private void dgv_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice_fila = 0;
            bool productoExiste = false;
            if (e.RowIndex >= 0)
            {
                if(!String.Equals(dgv_activo, "factura"))
                {
                    this.btn_factura_Click("Facturación", e);
                }
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
                    bool respuesta = new CN_Ventas().
                        RestarStock(Convert.ToInt32(dgv_productos.Rows[e.RowIndex].Cells["dgv_productos_id"].Value), 1);

                    // Si el producto se resta del stock de forma temporal correctamente, entonces se añade al dgv_resumen
                    // y a la lista de respaldo de productos
                    if (respuesta)
                    {
                        dgv_resumen.Rows.Add(new object[]
                        {
                            dgv_productos.Rows[e.RowIndex].Cells["dgv_productos_id"].Value.ToString(),
                            dgv_productos.Rows[e.RowIndex].Cells["dgv_productos_descripcion"].Value.ToString(),
                            1,
                            dgv_productos.Rows[e.RowIndex].Cells["dgv_productos_precio"].Value,
                            dgv_productos.Rows[e.RowIndex].Cells["dgv_productos_precio"].Value,
                            "Editar",
                            "Eliminar"
                        });

                        txt_buscarproductos.Text = "";
                        dgv_productos.Rows.Clear();
                        txt_buscarproductos.Select();
                    }
                }
                // Si el producto ya existe en dgv_resumen, suma a 1 la cantidad en dgv_resumen y en el listado de respaldo,
                // y vuelve a calcular el subtotal
                else
                {
                    bool respuesta = new CN_Ventas().
                        RestarStock(Convert.ToInt32(dgv_productos.Rows[e.RowIndex].Cells["dgv_productos_id"].Value), 1);
                    if (respuesta)
                    {
                        dgv_resumen.Rows[indice_fila].Cells["dgv_resumen_cantidad"].Value =
                        Convert.ToInt32(dgv_resumen.Rows[indice_fila].Cells["dgv_resumen_cantidad"].Value) + 1;
                        dgv_resumen.Rows[indice_fila].Cells["dgv_resumen_subtotal"].Value =
                            Convert.ToInt32(dgv_resumen.Rows[indice_fila].Cells["dgv_resumen_cantidad"].Value)
                            *
                            Convert.ToDecimal(dgv_resumen.Rows[indice_fila].Cells["dgv_resumen_precio"].Value);

                        txt_buscarproductos.Text = "";
                        dgv_productos.Rows.Clear();
                        txt_buscarproductos.Select();
                    }
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
                    vuelto = formularioCobro.vuelto;
                    // Start se suscribe al evento VentanaCerrada en cuanto sea invocado
                    if(formularioCobro.venta_cerrada)
                    {
                        this.CrearVenta();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar al menos un producto al carrito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void dgv_resumen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Si el botón presionado es "eliminar", se devuelve al stock la 
            // cantidad que estaba agregada al carrito
            dgv_resumen.EndEdit();
            if (dgv_resumen.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {
                int id_producto = Convert.ToInt32(dgv_resumen.Rows[e.RowIndex].Cells["dgv_resumen_id"].Value);
                bool respuesta = new CN_Ventas().SumarStock
                    (id_producto, Convert.ToInt32(dgv_resumen.Rows[e.RowIndex].Cells["dgv_resumen_cantidad"].Value));
                // Si se sumó al stock correctamente, se elimina el producto del carrito
                if (respuesta)
                {
                    int indice = e.RowIndex;
                    if (indice >= 0)
                    {
                        dgv_resumen.Rows.RemoveAt(indice);
                        this.CalcularTotal();
                    }
                }
                txt_buscarproductos.Text = "";
                dgv_productos.Rows.Clear();
            }
            if (dgv_resumen.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                int id_producto_editado = Convert.ToInt32(dgv_resumen.Rows[e.RowIndex].Cells["dgv_resumen_id"].Value);
                string descripcion_producto = dgv_resumen.Rows[e.RowIndex].Cells["dgv_resumen_descripcion"].Value.ToString();
                int cantidad_actual = Convert.ToInt32(dgv_resumen.Rows[e.RowIndex].Cells["dgv_resumen_cantidad"].Value);
                int stock_actual = new CN_Productos().BuscarUnProducto(id_producto_editado).Stock_actual;
                int nueva_cantidad = 0;
                using (var md_editarCantidad = new MD_EditarCantidad(descripcion_producto, cantidad_actual))
                {
                    md_editarCantidad.ShowDialog();
                    nueva_cantidad = md_editarCantidad.nueva_cantidad;
                }
                // Verifica si la cantidad ingresada es mayor a 0 o no es nula
                if (nueva_cantidad > 0)
                {
                    // Si la nueva cantidad es mayor a la que tenía antes, entonces se resta la diferencia al stock
                    if (nueva_cantidad > cantidad_actual)
                    {
                        int cantidad_a_descontar = nueva_cantidad - cantidad_actual;
                        bool respuesta = new CN_Ventas().RestarStock(id_producto_editado, cantidad_a_descontar);
                        // Si se restó del stock temporalmente de forma correcta,
                        // vuelve a calcular el subtotal con la nueva cantidad
                        if (respuesta)
                        {
                            dgv_resumen.Rows[e.RowIndex].Cells["dgv_resumen_cantidad"].Value = nueva_cantidad;
                            dgv_resumen.Rows[e.RowIndex].Cells["dgv_resumen_subtotal"].Value =
                                                nueva_cantidad
                                                *
                                                Convert.ToDecimal(dgv_resumen.Rows[e.RowIndex].Cells["dgv_resumen_precio"].Value);
                            this.CalcularTotal();
                        }
                    }
                    // Si la nueva cantidad es mayor a la que tenía antes, entonces se suma la diferencia al stock
                    else if (nueva_cantidad < cantidad_actual)
                    {
                        int cantidad_a_sumar = cantidad_actual - nueva_cantidad;
                        bool respuesta = new CN_Ventas().SumarStock(id_producto_editado, cantidad_a_sumar);
                        // Si se restó del stock temporalmente de forma correcta,
                        // vuelve a calcular el subtotal con la nueva cantidad
                        if (respuesta)
                        {
                            dgv_resumen.Rows[e.RowIndex].Cells["dgv_resumen_cantidad"].Value = nueva_cantidad;
                            dgv_resumen.Rows[e.RowIndex].Cells["dgv_resumen_subtotal"].Value =
                                                nueva_cantidad
                                                *
                                                Convert.ToDecimal(dgv_resumen.Rows[e.RowIndex].Cells["dgv_resumen_precio"].Value);
                            this.CalcularTotal();
                        }
                    }
                }
                else
                {
                    var resultado_dialogo = MessageBox.Show("La cantidad ingresada es menor a 1. \n¿Desea eliminar el producto del carrito?", "Mensaje",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado_dialogo == DialogResult.Yes)
                    {
                        bool respuesta = new CN_Ventas().SumarStock(id_producto_editado, cantidad_actual);
                        if(respuesta)
                        {
                            dgv_resumen.Rows.RemoveAt(e.RowIndex);
                            this.CalcularTotal();
                        }
                    }
                    else
                    {
                        dgv_resumen.Rows[e.RowIndex].Cells["dgv_resumen_cantidad"].Value = 1;
                    }
                }
            }
            if (dgv_resumen.Columns[e.ColumnIndex].Name == "btn_ver_detalle")
            {
                int id = 0;
                if(dgv_activo == "compras")
                {
                    id = Convert.ToInt32(dgv_resumen.Rows[e.RowIndex].Cells["id_compra"].Value);
                }
                else if (dgv_activo == "ventas")
                {
                    id = Convert.ToInt32(dgv_resumen.Rows[e.RowIndex].Cells["id_venta"].Value);
                }
                FiltrosReportes filtros = new FiltrosReportes()
                {
                    Id = id
                };
                if(dgv_detalle.Rows.Count > 0)
                {
                    dgv_detalle.Rows.Clear();
                }
                List<ReportesDetalle> _lista_detalle = new List<ReportesDetalle>();
                if (dgv_activo == "compras")
                {
                    _lista_detalle = new CN_Reportes().Compra_Detalle(filtros);
                    this.VerDetalle(_lista_detalle);
                }
                else if (dgv_activo == "ventas")
                {
                    _lista_detalle = new CN_Reportes().Venta_Detalle(filtros);
                    this.VerDetalle(_lista_detalle);
                }
            }
        }

        // Si se invoca el evento VentanaCerrada, se limpia dgv_resumen y el respaldo de productos
        // el total se vuelve a 0
        public void CrearVenta()
        {
            DataTable ventaDetalle = new DataTable();
            ventaDetalle.Columns.Add("Id_Producto", typeof(int));
            ventaDetalle.Columns.Add("Precio", typeof(decimal));
            ventaDetalle.Columns.Add("Cantidad", typeof(int));
            ventaDetalle.Columns.Add("Subtotal", typeof(decimal));

            foreach (DataGridViewRow fila in dgv_resumen.Rows)
            {
                ventaDetalle.Rows.Add(new object[]
                {
                    fila.Cells["dgv_resumen_id"].Value.ToString(),
                    fila.Cells["dgv_resumen_precio"].Value.ToString(),
                    fila.Cells["dgv_resumen_cantidad"].Value.ToString(),
                    fila.Cells["dgv_resumen_subtotal"].Value.ToString(),
                });
            }

            Ventas oVenta = new Ventas()
            {
                oUsuario = new Usuarios() { Id_usuario = oUser.Id_usuario },
                oCliente = new Clientes() { Id_cliente = 1 },
                Total = Convert.ToDecimal(lbl_suma_total.Text),
                Vuelto = vuelto,
            };

            string mensaje = string.Empty;
            bool respuesta = new CN_Ventas().Crear(oVenta, ventaDetalle, out mensaje);

            if (respuesta)
            {
                MessageBox.Show("Venta creada con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_resumen.Rows.Clear();
                this.CalcularTotal();
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void CalcularTotal()
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

        public void VerDetalle(List<ReportesDetalle> lista_detalle)
        {
            foreach (ReportesDetalle item in lista_detalle)
            {
                dgv_detalle.Rows.Add(new object[]
                {
                    item.Codigo_barras,
                    item.Nombre_producto,
                    item.Nombre_categoria,
                    item.Precio_unitario,
                    item.Cantidad,
                    item.Subtotal
                });
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
            
            if (currentSelectedMenuItem != null)
            {
                currentSelectedMenuItem.BackColor = Color.Transparent; 
            } 
            menu.BackColor = Color.Teal;
            currentSelectedMenuItem = menu;
            tsmenu_venta.BackColor = Color.Transparent;
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

            if (currentSelectedMenuItem != null)
            {
                currentSelectedMenuItem.BackColor = SystemColors.Control;
                currentSelectedMenuItem = null;
            }
        }
        private void lbl_cerrarcaja_Click(object sender, EventArgs e)
        {
            formCierre cierrecaja = new formCierre();
            cierrecaja.Show();
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
        private void ActualizarColorSeleccionado(ToolStripMenuItem menuItem)
        {
            if (currentSelectedMenuItem != null)
            {
                currentSelectedMenuItem.BackColor = Color.Transparent; 
            } 
            menuItem.BackColor = Color.Teal; 
            currentSelectedMenuItem = menuItem; 
        }
                private void flagdgv()
        {
            if (!panel_container.Controls.Container.Contains(dgv_detalle))
            {
                dgv_detalle.Columns.Clear();
                dgv_detalle.Columns.Add("dgv_detalle_codigo", "Cod. barras");
                dgv_detalle.Columns.Add("dgv_detalle_producto", "Producto");
                dgv_detalle.Columns.Add("dgv_detalle_categoria", "Categoria");
                dgv_detalle.Columns.Add("dgv_detalle_precio", "Precio unitario");
                dgv_detalle.Columns.Add("dgv_detalle_cantidad", "Cantidad");
                dgv_detalle.Columns.Add("dgv_detalle_subtotal", "Subtotal");
                panel_container.Controls.Add(dgv_detalle, 0, 1);
                dgv_detalle.Dock = DockStyle.Fill;
                dgv_resumen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_detalle.BackgroundColor = Color.MediumSlateBlue;
                dgv_detalle.BorderStyle = BorderStyle.None;
                dgv_detalle.CellBorderStyle = DataGridViewCellBorderStyle.None;
                dgv_detalle.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgv_detalle.ColumnHeadersDefaultCellStyle.BackColor = Color.Maroon;
                dgv_detalle.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv_detalle.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Maroon;
                dgv_detalle.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
                dgv_detalle.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                dgv_detalle.RowHeadersVisible = false;
                dgv_detalle.EnableHeadersVisualStyles = false;
                dgv_detalle.AllowUserToAddRows = false;
                dgv_detalle.AllowUserToDeleteRows = false;
                dgv_detalle.AllowUserToResizeRows = false;
            }
        }

        private void CambioVentanas(string p_lbl_titulo, string p_dgv_activo)
        {
            lbl_titulo.Text = p_lbl_titulo;
            string dgv_anterior = dgv_activo.ToString();
            dgv_activo = p_dgv_activo;

            if(String.Equals(p_dgv_activo, "compras") || String.Equals(p_dgv_activo, "ventas"))
            {
                dgv_detalle.Rows.Clear();
                if (btn_cerrarventa.Visible == true)
                {
                    btn_cerrarventa.Visible = false;
                }

                if (respaldo_carrito.Count == 0 && String.Equals(dgv_anterior, "factura"))
                {
                    this.GuardarCarrito();
                }
            }
            else if (String.Equals(p_dgv_activo, "factura"))
            {
                if (panel_container.Controls.Container.Contains(dgv_detalle))
                {
                    panel_container.Controls.Remove(dgv_detalle);
                }
                if (btn_cerrarventa.Visible == false)
                {
                    btn_cerrarventa.Visible = true;
                }
                if (respaldo_carrito.Count > 0)
                {
                    this.MostrarCarrito();
                }
            }
        }

        private void btn_factura_Click(object sender, EventArgs e)
        {
            if (!String.Equals(dgv_activo, "factura"))
            {
                dgv_resumen.Rows.Clear();
                dgv_resumen.Columns.Clear();
                dgv_resumen.Columns.Add("dgv_resumen_id", "ID");
                dgv_resumen.Columns.Add("dgv_resumen_descripcion", "Producto");
                dgv_resumen.Columns.Add("dgv_resumen_cantidad", "Cantidad");
                dgv_resumen.Columns.Add("dgv_resumen_precio", "Precio");
                dgv_resumen.Columns.Add("dgv_resumen_subtotal", "Subtotal");
                dgv_resumen.Columns.Add("btn_editar", "");
                dgv_resumen.Columns.Add("btn_eliminar", "");
                dgv_resumen.Columns["dgv_resumen_id"].Visible = false;
                dgv_resumen.Dock = DockStyle.Fill;
                dgv_resumen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_resumen.Visible = true;
                this.CambioVentanas("Facturación", "factura");
            }
        }

        private void btn_compra_Click(object sender, EventArgs e)
        {
            if (!String.Equals(dgv_activo, "compras"))
            {
                DateTime fecha_hoy = DateTime.Now;
                string formato_fecha_hoy = fecha_hoy.ToString("yyyy-MM-dd");
                List<Compras> lista_compras = new CN_Compras().Leer(formato_fecha_hoy, formato_fecha_hoy);
                this.CambioVentanas("Compras del día", "compras");
                flagdgv();
                dgv_resumen.Columns.Clear();
                dgv_resumen.Columns.Add("id_compra", "Nro. Compra");
                dgv_resumen.Columns.Add("fecha_documento", "Fecha");
                dgv_resumen.Columns.Add("numero_documento", "Nro. Documento");
                dgv_resumen.Columns.Add("total", "Total");
                dgv_resumen.Columns.Add("btn_ver_detalle", "");
                dgv_detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_resumen.Visible = true;
                dgv_resumen.Dock = DockStyle.Fill;
                panel_container.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                panel_container.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                panel_container.Controls.Add(dgv_resumen, 0, 0);
                foreach (Compras compra in lista_compras)
                {
                    dgv_resumen.Rows.Add(new object[]
                    {
                    compra.Id_compra,
                    compra.Fecha_documento,
                    compra.Numero_documento,
                    compra.Total,
                    "Ver detalle"
                    });
                }
            }
        }

        private void btn_venta_Click(object sender, EventArgs e)
        {
            if (!String.Equals(dgv_activo, "ventas"))
            {
                DateTime fecha_hoy = DateTime.Now;
                string formato_fecha_hoy = fecha_hoy.ToString("yyyy-MM-dd");
                List<Ventas> lista_ventas = new CN_Ventas().Leer(formato_fecha_hoy, formato_fecha_hoy);
                this.CambioVentanas("Ventas del día", "ventas");
                flagdgv();
                dgv_resumen.Columns.Clear();
                dgv_resumen.Columns.Add("id_venta", "Nro. Venta");
                dgv_resumen.Columns.Add("fecha_venta", "Fecha y hora");
                dgv_resumen.Columns.Add("nombre_cliente", "Cliente");
                dgv_resumen.Columns.Add("total", "Total");
                dgv_resumen.Columns.Add("btn_ver_detalle", "");
                dgv_detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_resumen.Visible = true;
                dgv_resumen.Dock = DockStyle.Fill;
                panel_container.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                panel_container.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                panel_container.Controls.Add(dgv_resumen, 0, 0);
                foreach (Ventas venta in lista_ventas)
                {
                    dgv_resumen.Rows.Add(new object[]
                    {
                    venta.Id_venta,
                    venta.Create_date,
                    venta.oCliente.Nombre_completo,
                    venta.Total,
                    "Ver detalle"
                    });
                }
            }
        }

        private void GuardarCarrito()
        {
            foreach (DataGridViewRow producto in dgv_resumen.Rows)
            {
                respaldo_carrito.Add(new Ventas_Detalle()
                {
                    oProducto = new Productos()
                    {
                        Id_producto = Convert.ToInt32(producto.Cells["dgv_resumen_id"].Value),
                        Descripcion = producto.Cells["dgv_resumen_descripcion"].Value.ToString()
                    },
                    Cantidad = Convert.ToInt32(producto.Cells["dgv_resumen_cantidad"].Value),
                    Precio = Convert.ToDecimal(producto.Cells["dgv_resumen_precio"].Value),
                    Subtotal = Convert.ToDecimal(producto.Cells["dgv_resumen_subtotal"].Value)
                });
            }
        }

        private void MostrarCarrito()
        {
            foreach(Ventas_Detalle producto in respaldo_carrito)
            {
                dgv_resumen.Rows.Add(new object[]
                {
                    producto.oProducto.Id_producto,
                    producto.oProducto.Descripcion,
                    producto.Cantidad,
                    producto.Precio,
                    producto.Subtotal,
                    "Editar",
                    "Eliminar"
                });
            }
            respaldo_carrito.Clear();
        }

        private void btn_desc_Click(object sender, EventArgs e)
        {
            formDescuento descuento = new formDescuento();
            descuento.Show();
        }

        private void Start_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btn_desc.PerformClick();
            }
            if (e.KeyCode == Keys.F10)
            {
                btn_cerrarventa.PerformClick();
            }
        }


        //private void btn_eventual_Click_1(object sender, EventArgs e)
        //{
        //    lbl_tipoticket.Text = "Eventual";
        //}

        //private void btn_cfinal_Click_1(object sender, EventArgs e)
        //{
        //    lbl_tipoticket.Text = "Consumidor Final";
        //}
    }
}
