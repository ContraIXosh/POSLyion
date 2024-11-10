﻿using CapaNegocio;
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
using PDCLyion;

namespace POSLyion
{
    public partial class Start : Form
    {

        private static Usuarios oUser = new Usuarios();
        private decimal total = 0;
        private decimal vuelto = 0;
        private string dgv_activo = "factura";
        private List<Ventas_Detalle> respaldo_carrito = new List<Ventas_Detalle>();

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
        // y a una lista de productos para respaldo
        // <resumen>
        private void dgv_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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
                            "Editar cantidad",
                            "Eliminar producto"
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

        private void dgv_resumen_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                if(dgv_activo == "compras")
                {
                    int id = Convert.ToInt32(dgv_resumen.Rows[e.RowIndex].Cells["id_compra"].Value);
                    MD_Detalle modalDetalle = new MD_Detalle(id, 1);
                    modalDetalle.ShowDialog();
                }
                else if (dgv_activo == "ventas")
                {
                    int id = Convert.ToInt32(dgv_resumen.Rows[e.RowIndex].Cells["id_venta"].Value);
                    MD_Detalle modalDetalle = new MD_Detalle(id, 2);
                    modalDetalle.ShowDialog();
                }
                
            }
        }

        // Si se invoca el evento VentanaCerrada, se limpia dgv_resumen y el respaldo de productos
        // el total se vuelve a 0
        private void CrearVenta()
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

        //private void btn_compra_Click(object sender, EventArgs e)
        //{
        //    lbl_titulo.Text = "Facturación";
        //    MostrarFacturacion();
        //}

        //private void btn_factura_Click(object sender, EventArgs e)
        //{
        //    lbl_titulo.Text = "Historial de compra";
        //    mostrarHistorialSell();
        //}

        //private void btn_venta_Click(object sender, EventArgs e)
        //{
        //    lbl_titulo.Text = "Historial de ventas";
        //    mostrarHistorialSell();
        //}

        //private void btn_cfinal_Click(object sender, EventArgs e)
        //{
        //    lbl_tipoticket.Text = "CONSUMIDOR FINAL";
        //    btn_cfinal.ForeColor = Color.White;
        //    btn_cfinal.BackColor = Color.BlueViolet;
        //    btn_cfinal.Enabled = false;
        //    if (btn_eventual.Enabled == false)
        //    {
        //        btn_cfinal.ForeColor = Color.White;
        //        btn_cfinal.BackColor = Color.BlueViolet;
        //        btn_eventual.Enabled = true;
        //    }
        //}

        //private void btn_eventual_Click(object sender, EventArgs e)
        //{
        //    lbl_tipoticket.Text = "EVENTUAL";
        //    btn_eventual.ForeColor = Color.White;
        //    btn_eventual.BackColor = Color.DarkMagenta;
        //    btn_eventual.Enabled = false;
        //    if (btn_cfinal.Enabled == false)
        //    {
        //        btn_eventual.ForeColor = Color.White;
        //        btn_eventual.BackColor = Color.DarkMagenta;
        //        btn_cfinal.Enabled = true;
        //    }
        //}
        //private void MostrarFacturacion()
        //{
        //    panel_resumen.Controls.Clear();
        //    ListBox lstProductos = new ListBox();
        //    lstProductos.Items.Add("Producto 1 - $10");
        //    lstProductos.Items.Add("Producto 2 - $20");
        //    panel_resumen.Controls.Add(lstProductos);
        //}

        //private void mostrarHistorialBuy()
        //{
        //    panel_resumen.Controls.Clear();
        //    DataGridView dgvCompra = new DataGridView();
        //}

        //private void mostrarHistorialSell()
        //{
        //    float precio = 0;
        //    float total = precio;

        //    if (precio > 0)
        //    {

        //    }
        //    DataGridView dgvCompra = new DataGridView();
        //    dgvCompra.Columns.Add("Hora", "Hora");
        //    dgvCompra.Columns.Add("Precio", "Precio");
        //    dgvCompra.Columns.Add("Productos", "Productos");
        //    dgvCompra.Columns.Add("Fecha", "Fecha");
        //    dgvCompra.Rows.Add("16:52:16", "$1620", "Last product", "10/02/2025");
        //    dgvCompra.Rows.Add("16:53:42", "$1920", "Last product", "10/02/2025");
        //    panel_resumen.Controls.Add(dgvCompra);

        //    dgvCompra.Columns.Add("Fecha", "Fecha");
        //    dgvCompra.Columns.Add("Producto", "Producto");
        //    dgvCompra.Columns.Add("Precio", "Precio");

        //    dgvCompra.Rows.Add("01/10/2024", "Producto A", "$15");
        //    dgvCompra.Rows.Add("02/10/2024", "Producto B", "$25");

        //    DataGridView dgvAmpliar = new DataGridView();
        //    dgvCompra.Columns.Add("Fecha", "Fecha");
        //    dgvCompra.Columns.Add("Producto", "Producto");
        //    dgvCompra.Columns.Add("Cantidad", "Cantidad");
        //    dgvCompra.Columns.Add("Precio", "precio");
        //    dgvCompra.Rows.Add("01/10/2024", "Salsa golf LC", "8", precio = 3999);
        //    dgvCompra.Rows.Add("01/10/2024", "Heineken lata 473", "6", precio = 124);
        //    dgvCompra.Rows.Add("01/10/2024", "Amstel lata 473", "15", precio = 15);
        //    dgvCompra.Rows.Add("Total =", total);
        //}

        DataGridView dgv_ampliar = new DataGridView();
        private void flagdgv()
        {
            if (!panel_container.Controls.Container.Contains(dgv_ampliar))
            {
                dgv_ampliar.Columns.Clear();
                dgv_ampliar.Columns.Add("prod", "Producto");
                dgv_ampliar.Columns.Add("cantidad", "Cantidad");
                dgv_ampliar.Columns.Add("precio", "Precio");

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

        private void btn_factura_Click(object sender, EventArgs e)
        {
            dgv_activo = "factura";
            if (panel_container.Controls.Container.Contains(dgv_ampliar))
            {
                panel_container.Controls.Remove(dgv_ampliar);
            }
            dgv_resumen.Columns.Clear();
            dgv_resumen.Columns.Add("dgv_resumen_id", "ID");
            dgv_resumen.Columns.Add("dgv_resumen_descripcion", "Producto");
            dgv_resumen.Columns.Add("dgv_resumen_cantidad", "Cantidad");
            dgv_resumen.Columns.Add("dgv_resumen_precio", "Precio");
            dgv_resumen.Columns.Add("dgv_resumen_subtotal", "Subtotal");
            dgv_resumen.Columns.Add("btn_editar", "");
            dgv_resumen.Columns.Add("btn_eliminar", "");
            if (respaldo_carrito.Count > 0)
            {
                this.MostrarCarrito();
            }
            dgv_resumen.Dock = DockStyle.Fill;
            dgv_resumen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_resumen.Visible = true;
        }

        private void btn_compra_Click(object sender, EventArgs e)
        {
            if(dgv_resumen.Rows.Count > 0 && dgv_activo == "factura")
            {
                this.GuardarCarrito();
            }
            dgv_activo = "compras";
            DateTime fecha_hoy = DateTime.Now;
            string formato_fecha_hoy = fecha_hoy.ToString("yyyy-MM-dd");
            List<Compras> lista_compras = new CN_Compras().Leer(formato_fecha_hoy, formato_fecha_hoy);
            flagdgv();
            dgv_resumen.Columns.Clear();
            dgv_resumen.Columns.Add("id_compra", "Nro. Compra");
            dgv_resumen.Columns.Add("fecha_documento", "Fecha");
            dgv_resumen.Columns.Add("numero_documento", "Nro. Documento");
            dgv_resumen.Columns.Add("total", "Total");
            dgv_resumen.Columns.Add("btn_ver_detalle", "");
            dgv_ampliar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_resumen.Visible = true;
            dgv_resumen.Dock = DockStyle.Fill;
            panel_container.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panel_container.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panel_container.Controls.Add(dgv_resumen, 0, 0);
            foreach(Compras compra in lista_compras)
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

        private void btn_venta_Click(object sender, EventArgs e)
        {
            if (dgv_resumen.Rows.Count > 0 && dgv_activo == "factura")
            {
                this.GuardarCarrito();
            }
            dgv_activo = "ventas";
            DateTime fecha_hoy = DateTime.Now;
            string formato_fecha_hoy = fecha_hoy.ToString("yyyy-MM-dd");
            List<Ventas> lista_ventas = new CN_Ventas().Leer(formato_fecha_hoy, formato_fecha_hoy);
            flagdgv();
            dgv_resumen.Columns.Clear();
            dgv_resumen.Columns.Add("id_venta", "Nro. Venta");
            dgv_resumen.Columns.Add("fecha_venta", "Fecha y hora");
            dgv_resumen.Columns.Add("nombre_cliente", "Cliente");
            dgv_resumen.Columns.Add("total", "Total");
            dgv_resumen.Columns.Add("btn_ver_detalle", "Ver detalle");
            dgv_ampliar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                    "Editar cantidad",
                    "Eliminar producto"
                });
            }
            respaldo_carrito.Clear();
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
