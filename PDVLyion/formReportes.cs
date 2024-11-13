using CapaEntidad;
using CapaEntidad.Filtros;
using CapaNegocio;
using ClosedXML.Excel;
using EntityLayer.Filtros;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace POSLyion
{
    public partial class formReportes : Form
    {

        private string dgv_activo = string.Empty;
        private List<ReportesDetalle> _lista = new List<ReportesDetalle>();
        private Label _lbl_busqueda_proveedor = new Label();
        private Label _lbl_busqueda_cliente = new Label();
        private ComboBox _cbox_proveedores = new ComboBox();
        private ComboBox _cbox_clientes = new ComboBox();
        private FiltrosReportes _filtros = new FiltrosReportes();

        public formReportes()
        {
            InitializeComponent();
        }

        private void formEstadsticas_Load(object sender, EventArgs e)
        {
            FiltrosUsuario filtros_usuario = new FiltrosUsuario();
            cbox_usuarios.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Cualquier usuario" });
            List<Usuarios> lista_usuarios = new CN_Usuarios().Leer(filtros_usuario);
            foreach (Usuarios oUsuario in lista_usuarios)
            {
                cbox_usuarios.Items.Add(new OpcionCombo() { Valor = oUsuario.Id_usuario, Texto = oUsuario.Nombre_usuario });
            }
            cbox_usuarios.DisplayMember = "Texto";
            cbox_usuarios.ValueMember = "Valor";
            cbox_usuarios.SelectedIndex = 0;

            this.CrearControlesCompras();
            FiltrosProveedor filtros_proveedor = new FiltrosProveedor();
            _cbox_proveedores.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Cualquier proveedor" });
            List<Proveedores> lista_proveedores = new CN_Proveedores().Leer(filtros_proveedor);
            foreach (Proveedores oProveedor in lista_proveedores)
            {
                _cbox_proveedores.Items.Add(new OpcionCombo() { Valor = oProveedor.Id_proveedor, Texto = oProveedor.Descripcion });
            }
            _cbox_proveedores.DisplayMember = "Texto";
            _cbox_proveedores.ValueMember = "Valor";
            _cbox_proveedores.SelectedIndex = 0;

            this.CrearControlesVentas();
            FiltrosCliente filtros_clientes = new FiltrosCliente();
            _cbox_clientes.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Cualquier cliente" });
            List<Clientes> lista_clientes = new CN_Clientes().Leer(filtros_clientes);
            foreach (Clientes oCliente in lista_clientes)
            {
                _cbox_clientes.Items.Add(new OpcionCombo() { Valor = oCliente.Id_cliente, Texto = oCliente.Nombre_completo });
            }
            _cbox_clientes.DisplayMember = "Texto";
            _cbox_clientes.ValueMember = "Valor";
            _cbox_clientes.SelectedIndex = 0;
        }

        private void btn_ver_ventas_Click(object sender, EventArgs e)
        {
            dgv_activo = "ventas";
            this.CrearDgv(1);
            if(this.panel_izq.Controls.Container.Contains(_lbl_busqueda_proveedor))
            {
                this.panel_izq.Controls.Remove(_lbl_busqueda_proveedor);
                this.panel_izq.Controls.Remove(_cbox_proveedores);
            }
            this.panel_izq.Controls.Add(_lbl_busqueda_cliente, 0, 11);
            this.panel_izq.Controls.Add(_cbox_clientes, 0, 12);
            this.panel_izq.Controls.Add(btn_buscar, 0, 13);
            dgv_historial.Dock = DockStyle.Fill;
        }

        private void btn_ver_compras_Click(object sender, EventArgs e)
        {
            dgv_activo = "compras";
            this.CrearDgv(2);
            if (this.panel_izq.Controls.Container.Contains(_lbl_busqueda_cliente))
            {
                this.panel_izq.Controls.Remove(_lbl_busqueda_cliente);
                this.panel_izq.Controls.Remove(_cbox_clientes);

            }
            this.panel_izq.Controls.Add(_lbl_busqueda_proveedor, 0, 11);
            this.panel_izq.Controls.Add(_cbox_proveedores, 0, 12);
            this.panel_izq.Controls.Add(btn_buscar, 0, 13);
            dgv_historial.Dock = DockStyle.Fill;
        }

        private void btn_ver_cierres_Click(object sender, EventArgs e)
        {
            dgv_activo = "cierres";
            this.CrearDgv(3);
            if (this.panel_izq.Controls.Container.Contains(_lbl_busqueda_cliente))
            {
                this.panel_izq.Controls.Remove(_lbl_busqueda_cliente);
                this.panel_izq.Controls.Remove(_cbox_clientes);
            }
            if (this.panel_izq.Controls.Container.Contains(_lbl_busqueda_proveedor))
            {
                this.panel_izq.Controls.Remove(_lbl_busqueda_proveedor);
                this.panel_izq.Controls.Remove(_cbox_proveedores);
            }
            dgv_historial.Dock = DockStyle.Fill;
        }

        private void CrearDgv(int caso)
        {
            dgv_historial.Columns.Clear();
            dgv_historial.Rows.Clear();
            if (caso == 3)
            {
                dgv_historial.Columns.Add("id_cierre", "Numero de turno");
                dgv_historial.Columns.Add("nombre_usuario", "Usuario");
                dgv_historial.Columns.Add("monto_ventas", "Total vendido");
                dgv_historial.Columns.Add("monto_caja", "Dinero en caja");
                dgv_historial.Columns.Add("fecha_inicio_turno", "Fecha de inicio de turno");
                dgv_historial.Columns.Add("fecha_fin_turno", "Fecha de fin de turno");
                dgv_historial.Visible = true;
                dgv_historial.Dock = DockStyle.Fill;
                dgv_historial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_historial.ColumnHeadersHeight = 50;
                dgv_historial.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
                dgv_historial.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                return;
            }
            string id = string.Empty;
            string campo_adicional_name = string.Empty;
            string campo_adicional_header = string.Empty;
            if (dgv_activo == "ventas")
            {   
                this.CrearControlesVentas();
                dgv_historial.Columns.Add("id_venta", "Número de venta");
            } 
            else if (dgv_activo == "compras")
            {
                this.CrearControlesCompras();
                dgv_historial.Columns.Add("id_venta", "Número de compra");
            }
            dgv_historial.Columns.Add("codigo_barras", "Código de barras");
            dgv_historial.Columns.Add("descripcion", "Producto");
            dgv_historial.Columns.Add("categoria", "Categoría");
            dgv_historial.Columns.Add("precio_unitario", "Precio unitario");
            dgv_historial.Columns.Add("cantidad", "Cantidad");
            if (caso == 1)
            {
                dgv_historial.Columns.Add("nombre_cliente", "Cliente");
            }
            else if (caso == 2)
            {
                dgv_historial.Columns.Add("nombre_proveedor", "Proveedor");
            }
            dgv_historial.Columns.Add("subtotal", "Subtotal");
            dgv_historial.Columns.Add("usuario_registro", "Usuario");
            if (dgv_activo == "compras")
            {
                dgv_historial.Columns.Add("fecha_documento", "Fecha de documento");
            }
            dgv_historial.Columns.Add("fecha_registro", "Fecha y hora");
            dgv_historial.Visible = true;
            dgv_historial.Dock = DockStyle.Fill;
            dgv_historial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_historial.ColumnHeadersHeight = 50;
            dgv_historial.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold); 
            dgv_historial.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void CrearControlesCompras()
        {
            // 
            // lbl_busqueda_proveedor
            // 
            _lbl_busqueda_proveedor.Anchor = AnchorStyles.None;
            _lbl_busqueda_proveedor.AutoSize = true;
            _lbl_busqueda_proveedor.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            _lbl_busqueda_proveedor.ForeColor = Color.DarkGreen;
            _lbl_busqueda_proveedor.Location = new Point(54, 521);
            _lbl_busqueda_proveedor.Name = "lbl_busqueda_proveedor";
            _lbl_busqueda_proveedor.Size = new Size(186, 24);
            _lbl_busqueda_proveedor.TabIndex = 40;
            _lbl_busqueda_proveedor.Text = "NOMBRE DE PROVEEDOR";
            _lbl_busqueda_proveedor.Visible = true;
            // 
            // cbox_proveedores
            // 
            _cbox_proveedores.Dock = DockStyle.Fill;
            _cbox_proveedores.FormattingEnabled = true;
            _cbox_proveedores.Location = new Point(3, 374);
            _cbox_proveedores.Name = "cbox_proveedores";
            _cbox_proveedores.Size = new Size(288, 21);
            _cbox_proveedores.TabIndex = 45;
        }

        private void CrearControlesVentas()
        {
            // 
            // lbl_busqueda_cliente
            // 
            _lbl_busqueda_cliente.Anchor = AnchorStyles.None;
            _lbl_busqueda_cliente.AutoSize = true;
            _lbl_busqueda_cliente.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            _lbl_busqueda_cliente.ForeColor = Color.DarkGreen;
            _lbl_busqueda_cliente.Location = new Point(54, 521);
            _lbl_busqueda_cliente.Name = "lbl_busqueda_cliente";
            _lbl_busqueda_cliente.Size = new Size(186, 24);
            _lbl_busqueda_cliente.TabIndex = 40;
            _lbl_busqueda_cliente.Text = "NOMBRE DE CLIENTE";
            _lbl_busqueda_cliente.Visible = true;
            // 
            // cbox_clientes
            // 
            _cbox_clientes.Dock = DockStyle.Fill;
            _cbox_clientes.FormattingEnabled = true;
            _cbox_clientes.Location = new Point(3, 374);
            _cbox_clientes.Name = "cbox_clientes";
            _cbox_clientes.Size = new Size(288, 21);
            _cbox_clientes.TabIndex = 45;
        }

        private void MostrarReporte()
        {
            if(dgv_historial.Rows.Count > 0)
            {
                dgv_historial.Rows.Clear();
            }
            if(dgv_activo == "ventas")
            {
                _lista = new CN_Reportes().Venta_Detalle(_filtros);
                foreach (ReportesDetalle item in _lista)
                {
                    dgv_historial.Rows.Add(new object[]
                    {
                        item.Id,
                        item.Codigo_barras,
                        item.Nombre_producto,
                        item.Nombre_categoria,
                        item.Precio_unitario,
                        item.Cantidad,
                        item.Campo_adicional,
                        item.Subtotal,
                        item.UsuarioRegistro,
                        item.FechaRegistro
                    });
                }
            }
            else if (dgv_activo == "compras")
            {
                _lista = new CN_Reportes().Compra_Detalle(_filtros);
                foreach (ReportesDetalle item in _lista)
                {
                    dgv_historial.Rows.Add(new object[]
                    {
                        item.Id,
                        item.Codigo_barras,
                        item.Nombre_producto,
                        item.Nombre_categoria,
                        item.Precio_unitario,
                        item.Cantidad,
                        item.Campo_adicional,
                        item.Subtotal,
                        item.UsuarioRegistro,
                        item.FechaDocumento,
                        item.FechaRegistro
                    });
                }
            }
            else if (dgv_activo == "cierres")
            {
                List<ReportesCierre> lista_cierres = new CN_Reportes().Cierres(_filtros);
                foreach (ReportesCierre cierre in lista_cierres)
                {
                    dgv_historial.Rows.Add(new object[]
                    {
                        cierre.Id_cierre,
                        cierre.Nombre_usuario,
                        cierre.Monto_ventas,
                        cierre.Monto_caja,
                        cierre.Fecha_inicio_turno,
                        cierre.Fecha_fin_turno
                    });
                }
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if(dgv_activo == String.Empty)
            {
                MessageBox.Show("Debe seleccionar ver ventas, compras o cierres de caja", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.CargarFiltros();
            this.MostrarReporte();
        }

        public void CargarFiltros()
        {
            string fecha_desde = date_desde.Value.ToString("yyyy-MM-dd");
            string fecha_hasta = date_hasta.Value.ToString("yyyy-MM-dd");
            int campo_adicional = (dgv_activo == "ventas" ? Convert.ToInt32(((OpcionCombo)_cbox_clientes.SelectedItem).Valor) : Convert.ToInt32(((OpcionCombo)_cbox_proveedores.SelectedItem).Valor));

            _filtros = new FiltrosReportes()
            {
                Fecha_desde = fecha_desde,
                Fecha_hasta = fecha_hasta,
                Id_usuario = Convert.ToInt32(((OpcionCombo)cbox_usuarios.SelectedItem).Valor),
                Campo_adicional = campo_adicional,
                Nombre_producto = txt_busqueda_producto.Text,
            };
        }


        public void ExportarDataGridViewAExcel(DataGridView dataGridView)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Workbook|*.xlsx";
                sfd.Title = "Guardar archivo Excel";
                var nombreArchivos = new Dictionary<string, string>
                {
                    { "ventas", "ReporteVentas_" },
                    { "compras", "ReporteCompras_" },
                    { "cierres", "ReporteCierres_" }
                };

                string nombre_archivo = nombreArchivos.ContainsKey(dgv_activo) ? nombreArchivos[dgv_activo] : string.Empty;

                sfd.FileName = nombre_archivo + DateTime.Now.ToString("ddMMyyyyhhmmss");

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            DataTable dt = new DataTable();

                            // Crear columnas en el DataTable
                            foreach (DataGridViewColumn column in dataGridView.Columns)
                            {
                                dt.Columns.Add(column.HeaderText);
                            }

                            // Añadir filas al DataTable
                            foreach (DataGridViewRow row in dataGridView.Rows)
                            {
                                if (row.IsNewRow) continue;
                                DataRow dataRow = dt.NewRow();
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    dataRow[cell.ColumnIndex] = cell.Value;
                                }
                                dt.Rows.Add(dataRow);
                            }

                            // Añadir el DataTable al libro Excel
                            workbook.Worksheets.Add(dt, "Productos");

                            // Guardar el archivo Excel
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("Datos exportados exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al exportar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void btn_excel_Click(object sender, EventArgs e)
        {
            if(dgv_historial.Rows.Count > 0)
            {
                ExportarDataGridViewAExcel(dgv_historial);
            }
            else
            {
                MessageBox.Show("No hay datos para exportar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
