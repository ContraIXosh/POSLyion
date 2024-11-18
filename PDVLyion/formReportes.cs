using CapaEntidad;
using CapaEntidad.Filtros;
using CapaEntidad.GraficosVentas;
using CapaNegocio;
using ClosedXML.Excel;
using EntityLayer.Filtros;
using POSLyion;
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
            label1.Visible = false;
            label6.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            chart1.Visible = false;
            chart2.Visible = false;
            chart3.Visible = false;
            chart4.Visible = false;

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
            chart1.Series.Clear();
            chart2.Series.Clear();
            chart3.Series.Clear();
            chart4.Series.Clear();
            label1.Visible = true;
            label6.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            chart1.Visible = true;
            chart2.Visible = true;
            chart3.Visible = true;
            chart4.Visible = true;
            label1.Text = "VENTAS MENSUALES";
            label6.Text = "VENTAS POR USUARIO";
            label2.Text = "VENTAS MENSUALES - GRAFICO DONA";
            label3.Text = "VENTAS POR USUARIO - GRAFICO DONA";
            this.DatosVentas();
            this.VentasUsuarios();
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
            chart1.Series.Clear();
            chart2.Series.Clear();
            chart3.Series.Clear();
            chart4.Series.Clear();
            label1.Visible = true;
            label6.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            chart1.Visible = true;
            chart2.Visible = true;
            chart3.Visible = true;
            chart4.Visible = true;
            label1.Text = "COMPRAS MENSUALES";
            label6.Text = "COMPRAS POR USUARIO";
            label2.Text = "COMPRAS MENSUALES - GRAFICO DONA";
            label3.Text = "COMPRAS POR USUARIO - GRAFICO DONA";
            this.DatosCompras();
            this.ComprasUsuarios();
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
            label1.Visible = false;
            label6.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            chart1.Visible = false;
            chart2.Visible = false;
            chart3.Visible = false;
            chart4.Visible = false;
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
            if(caso == 1)
            {
                dgv_historial.Columns.Add("btn_imprimir", "");
            }
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
                        item.FechaRegistro,
                        "Imprimir ticket"
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

        private void VentasUsuarios()
        {
            List<DatosGraficoUsuarios> lista_ventas_usuarios = new CN_Ventas().VentasMensualesUsuarios();
            List<string> usuario = lista_ventas_usuarios.Select(v => v.Nombre_usuario).ToList();
            List<int> cantidades = lista_ventas_usuarios.Select(v => v.Cantidad).ToList();
            this.ConfigurarVentasUsuariosBarra(cantidades, usuario);
            this.ConfigurarVentasUsuariosDona(cantidades, usuario);
        }

        private void ConfigurarVentasUsuariosBarra(List<int> cantidad, List<string> usuario)
        {
            // Crear una nueva serie
            Series series = new Series("Ventas Mensuales por Usuario")
            {
                ChartType = SeriesChartType.Column, // Puedes cambiar el tipo de gráfico
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Int32,
            };

            // Añadir puntos a la serie
            for (int i = 0; i < usuario.Count; i++)
            {
                series.Points.AddXY(usuario[i], cantidad[i]);
            }

            // Configuración para ajustar automáticamente los ejes
            chart4.ChartAreas[0].AxisY.IsStartedFromZero = true;
            chart4.ChartAreas[0].AxisY.Minimum = Double.NaN; // Permite valores mínimos automáticos
            chart4.ChartAreas[0].AxisY.Maximum = Double.NaN; // Permite valores máximos automáticos
            chart4.ChartAreas[0].RecalculateAxesScale(); // Recalcula la escala de los ejes

            // Configurar el Chart
            chart4.Series.Clear(); // Limpiar series anteriores si es necesario
            chart4.Series.Add(series);
            chart4.ChartAreas[0].AxisX.Title = "Usuarios";
            chart4.ChartAreas[0].AxisY.Title = "Cantidad";
            chart4.ChartAreas[0].AxisX.Interval = 1; // Opcional, para que muestre cada usuario
            // Refrescar el gráfico
            chart4.Invalidate();
        }

        private void ConfigurarVentasUsuariosDona(List<int> cantidad, List<string> usuario)
        {
            // Crear una nueva serie
            Series series = new Series("Ventas Mensuales por Usuario")
            {
                ChartType = SeriesChartType.Doughnut, // Puedes cambiar el tipo de gráfico
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Int32,
            };

            // Añadir puntos a la serie
            for (int i = 0; i < usuario.Count; i++)
            {
                series.Points.AddXY(usuario[i], cantidad[i]);
            }

            // Configuración para ajustar automáticamente los ejes
            chart3.ChartAreas[0].AxisY.IsStartedFromZero = true;
            chart3.ChartAreas[0].AxisY.Minimum = Double.NaN; // Permite valores mínimos automáticos
            chart3.ChartAreas[0].AxisY.Maximum = Double.NaN; // Permite valores máximos automáticos
            chart3.ChartAreas[0].RecalculateAxesScale(); // Recalcula la escala de los ejes

            // Configurar el Chart
            chart3.Series.Clear(); // Limpiar series anteriores si es necesario
            chart3.Series.Add(series);
            chart3.ChartAreas[0].AxisX.Title = "Usuarios";
            chart3.ChartAreas[0].AxisY.Title = "Cantidad";
            chart3.ChartAreas[0].AxisX.Interval = 1; // Opcional, para que muestre cada usuario
            // Refrescar el gráfico
            chart3.Invalidate();
        }

        private void DatosVentas()
        {
            List<DatosGraficoMensual> lista_ventas_mensuales = new CN_Ventas().VentasMensuales();
            List<int> meses = lista_ventas_mensuales.Select(v => v.Mes).ToList();
            List<int> cantidades = lista_ventas_mensuales.Select(v => v.Cantidad).ToList();
            this.ConfigurarVentasMensualesBarra(meses, cantidades);
            this.ConfigurarVentasMensualesDona(meses, cantidades);
        }

        private void ConfigurarVentasMensualesBarra(List<int> meses, List<int> cantidad)
        {
            // Crear una nueva serie
            Series series = new Series("Ventas Mensuales")
            {
                ChartType = SeriesChartType.Column, // Puedes cambiar el tipo de gráfico
                XValueType = ChartValueType.Int32,
                YValueType = ChartValueType.Int32
            };

            // Añadir puntos a la serie
            for (int i = 0; i < meses.Count; i++)
            {
                series.Points.AddXY(meses[i], cantidad[i]);
            }

            // Configuración para ajustar automáticamente los ejes
            chart1.ChartAreas[0].AxisY.IsStartedFromZero = true;
            chart1.ChartAreas[0].AxisY.Minimum = Double.NaN; // Permite valores mínimos automáticos
            chart1.ChartAreas[0].AxisY.Maximum = Double.NaN; // Permite valores máximos automáticos
            chart1.ChartAreas[0].RecalculateAxesScale(); // Recalcula la escala de los ejes


            // Configurar el Chart
            chart1.Series.Clear(); // Limpiar series anteriores si es necesario
            chart1.Series.Add(series);
            chart1.ChartAreas[0].AxisX.Title = "Mes";
            chart1.ChartAreas[0].AxisY.Title = "Cantidad de Ventas";
            chart1.ChartAreas[0].AxisX.Interval = 1; // Opcional, para que muestre cada mes
            // Refrescar el gráfico
            chart1.Invalidate();
        }

        private void ConfigurarVentasMensualesDona(List<int> meses, List<int> cantidad)
        {
            // Crear una nueva serie
            Series series = new Series("Ventas Mensuales")
            {
                ChartType = SeriesChartType.Doughnut, // Puedes cambiar el tipo de gráfico
                XValueType = ChartValueType.Int32,
                YValueType = ChartValueType.Int32
            };

            // Añadir puntos a la serie
            for (int i = 0; i < meses.Count; i++)
            {
                series.Points.AddXY("Mes n°:" + meses[i], cantidad[i]);
            }

            // Configuración para ajustar automáticamente los ejes
            chart2.ChartAreas[0].AxisY.IsStartedFromZero = true;
            chart2.ChartAreas[0].AxisY.Minimum = Double.NaN; // Permite valores mínimos automáticos
            chart2.ChartAreas[0].AxisY.Maximum = Double.NaN; // Permite valores máximos automáticos
            chart2.ChartAreas[0].RecalculateAxesScale(); // Recalcula la escala de los ejes

            // Configurar el Chart
            chart2.Series.Clear(); // Limpiar series anteriores si es necesario
            chart2.Series.Add(series);
            chart2.ChartAreas[0].AxisX.Title = "Mes";
            chart2.ChartAreas[0].AxisY.Title = "Cantidad de Ventas";
            chart2.ChartAreas[0].AxisX.Interval = 1; // Opcional, para que muestre cada mes
            // Refrescar el gráfico
            chart2.Invalidate();
        }

        private void DatosCompras()
        {
            List<DatosGraficoMensual> lista_compras_mensuales = new CN_Compras().ComprasMensuales();
            List<int> meses = lista_compras_mensuales.Select(v => v.Mes).ToList();
            List<int> cantidades = lista_compras_mensuales.Select(v => v.Cantidad).ToList();
            this.ConfigurarComprasMensualesBarra(meses, cantidades);
            this.ConfigurarComprasMensualesDona(meses, cantidades);
        }

        private void ConfigurarComprasMensualesBarra(List<int> meses, List<int> cantidad)
        {
            // Crear una nueva serie
            Series series = new Series("Compras Mensuales")
            {
                ChartType = SeriesChartType.Column, // Puedes cambiar el tipo de gráfico
                XValueType = ChartValueType.Int32,
                YValueType = ChartValueType.Int32
            };

            // Añadir puntos a la serie
            for (int i = 0; i < meses.Count; i++)
            {
                series.Points.AddXY(meses[i], cantidad[i]);
            }

            // Configuración para ajustar automáticamente los ejes
            chart1.ChartAreas[0].AxisY.IsStartedFromZero = true;
            chart1.ChartAreas[0].AxisY.Minimum = Double.NaN; // Permite valores mínimos automáticos
            chart1.ChartAreas[0].AxisY.Maximum = Double.NaN; // Permite valores máximos automáticos
            chart1.ChartAreas[0].RecalculateAxesScale(); // Recalcula la escala de los ejes

            // Configurar el Chart
            chart1.Series.Clear(); // Limpiar series anteriores si es necesario
            chart1.Series.Add(series);
            chart1.ChartAreas[0].AxisX.Title = "Mes";
            chart1.ChartAreas[0].AxisY.Title = "Cantidad de Compras";
            chart1.ChartAreas[0].AxisX.Interval = 1; // Opcional, para que muestre cada mes
            // Refrescar el gráfico
            chart1.Invalidate();
        }

        private void ConfigurarComprasMensualesDona(List<int> meses, List<int> cantidad)
        {
            // Crear una nueva serie
            Series series = new Series("Compras Mensuales")
            {
                ChartType = SeriesChartType.Doughnut, // Puedes cambiar el tipo de gráfico
                XValueType = ChartValueType.Int32,
                YValueType = ChartValueType.Int32
            };

            // Añadir puntos a la serie
            for (int i = 0; i < meses.Count; i++)
            {
                series.Points.AddXY("Mes n°:" + meses[i], cantidad[i]);
            }

            // Configuración para ajustar automáticamente los ejes
            chart2.ChartAreas[0].AxisY.IsStartedFromZero = true;
            chart2.ChartAreas[0].AxisY.Minimum = Double.NaN; // Permite valores mínimos automáticos
            chart2.ChartAreas[0].AxisY.Maximum = Double.NaN; // Permite valores máximos automáticos
            chart2.ChartAreas[0].RecalculateAxesScale(); // Recalcula la escala de los ejes

            // Configurar el Chart
            chart2.Series.Clear(); // Limpiar series anteriores si es necesario
            chart2.Series.Add(series);
            chart2.ChartAreas[0].AxisX.Title = "Mes";
            chart2.ChartAreas[0].AxisY.Title = "Cantidad de Compras";
            chart2.ChartAreas[0].AxisX.Interval = 1; // Opcional, para que muestre cada mes
            // Refrescar el gráfico
            chart2.Invalidate();
        }

        private void ComprasUsuarios()
        {
            List<DatosGraficoUsuarios> lista_compras_usuarios = new CN_Compras().ComprasMensualesUsuarios();
            List<string> usuario = lista_compras_usuarios.Select(v => v.Nombre_usuario).ToList();
            List<int> cantidades = lista_compras_usuarios.Select(v => v.Cantidad).ToList();
            this.ConfigurarComprasUsuariosBarra(cantidades, usuario);
            this.ConfigurarComprasUsuariosDona(cantidades, usuario);
        }

        private void ConfigurarComprasUsuariosBarra(List<int> cantidad, List<string> usuario)
        {
            // Crear una nueva serie
            Series series = new Series("Compras Mensuales por Usuario")
            {
                ChartType = SeriesChartType.Column, // Puedes cambiar el tipo de gráfico
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Int32,
            };

            // Añadir puntos a la serie
            for (int i = 0; i < usuario.Count; i++)
            {
                series.Points.AddXY(usuario[i], cantidad[i]);
            }

            // Configuración para ajustar automáticamente los ejes
            chart4.ChartAreas[0].AxisY.IsStartedFromZero = true;
            chart4.ChartAreas[0].AxisY.Minimum = Double.NaN; // Permite valores mínimos automáticos
            chart4.ChartAreas[0].AxisY.Maximum = Double.NaN; // Permite valores máximos automáticos
            chart4.ChartAreas[0].RecalculateAxesScale(); // Recalcula la escala de los ejes

            // Configurar el Chart
            chart4.Series.Clear(); // Limpiar series anteriores si es necesario
            chart4.Series.Add(series);
            chart4.ChartAreas[0].AxisX.Title = "Usuarios";
            chart4.ChartAreas[0].AxisY.Title = "Cantidad";
            chart4.ChartAreas[0].AxisX.Interval = 1; // Opcional, para que muestre cada usuario
            // Refrescar el gráfico
            chart4.Invalidate();
        }

        private void ConfigurarComprasUsuariosDona(List<int> cantidad, List<string> usuario)
        {
            // Crear una nueva serie
            Series series = new Series("Compras Mensuales por Usuario")
            {
                ChartType = SeriesChartType.Doughnut, // Puedes cambiar el tipo de gráfico
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Int32,
            };

            // Añadir puntos a la serie
            for (int i = 0; i < usuario.Count; i++)
            {
                series.Points.AddXY(usuario[i], cantidad[i]);
            }

            // Configuración para ajustar automáticamente los ejes
            chart3.ChartAreas[0].AxisY.IsStartedFromZero = true;
            chart3.ChartAreas[0].AxisY.Minimum = Double.NaN; // Permite valores mínimos automáticos
            chart3.ChartAreas[0].AxisY.Maximum = Double.NaN; // Permite valores máximos automáticos
            chart3.ChartAreas[0].RecalculateAxesScale(); // Recalcula la escala de los ejes

            // Configurar el Chart
            chart3.Series.Clear(); // Limpiar series anteriores si es necesario
            chart3.Series.Add(series);
            chart3.ChartAreas[0].AxisX.Title = "Usuarios";
            chart3.ChartAreas[0].AxisY.Title = "Cantidad";
            chart3.ChartAreas[0].AxisX.Interval = 1; // Opcional, para que muestre cada usuario
            // Refrescar el gráfico
            chart3.Invalidate();
        }

        private void dgv_historial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que se ha hecho clic en la columna "Imprimir ticket"
            if (dgv_historial.Columns[e.ColumnIndex].Name == "btn_imprimir")
            {
                // Obtiene el ID de la fila seleccionada
                int id = Convert.ToInt32(dgv_historial.Rows[e.RowIndex].Cells["id_venta"].Value);
                string usuario = dgv_historial.Rows[e.RowIndex].Cells["usuario_registro"].ToString();
                decimal total = 0;

                // Inicializa un nuevo DataGridView para el resumen
                DataGridView dgv_resumen = new DataGridView();
                dgv_resumen.AllowUserToAddRows = false; // No permitir al usuario añadir filas manualmente
                dgv_resumen.AllowUserToDeleteRows = false; // No permitir al usuario eliminar filas manualmente
                dgv_resumen.ReadOnly = true; // Hacer que el DataGridView sea de solo lectura si es necesario
                dgv_resumen.Columns.Add("dgv_resumen_descripcion", "Descripción");
                dgv_resumen.Columns.Add("dgv_resumen_cantidad", "Cantidad");
                dgv_resumen.Columns.Add("dgv_resumen_precio", "Precio Unitario");
                dgv_resumen.Columns.Add("dgv_resumen_subtotal", "Subtotal");

                // Itera sobre las filas del DataGridView original
                foreach (DataGridViewRow row in dgv_historial.Rows)
                {
                    // Compara el ID de la venta
                    if (Convert.ToInt32(row.Cells["id_venta"].Value) == id)
                    {
                        // Agrega las filas coincidentes al nuevo DataGridView
                        dgv_resumen.Rows.Add(new object[]
                        {
                            row.Cells["descripcion"].Value.ToString(),
                            row.Cells["cantidad"].Value.ToString(),
                            row.Cells["precio_unitario"].Value.ToString(),
                            row.Cells["subtotal"].Value.ToString()
                        });
                        total += Convert.ToDecimal(row.Cells["subtotal"].Value);
                    }
                }
                classTicket.CreaTicket Ticket1 = new classTicket.CreaTicket();
                Ticket1.TextoCentro("Empresa xxxxx ");
                Ticket1.TextoCentro("**********************************");
                Ticket1.TextoIzquierda("");
                Ticket1.TextoCentro("Factura de Venta");
                Ticket1.TextoIzquierda("No Fac:" + id);
                Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
                Ticket1.TextoIzquierda("Le Atendio: " + usuario);
                Ticket1.TextoIzquierda("");
                classTicket.CreaTicket.LineasGuion();
                classTicket.CreaTicket.EncabezadoVenta(dgv_resumen);
                classTicket.CreaTicket.LineasGuion();
                classTicket.CreaTicket.LineasGuion();
                Ticket1.TextoIzquierda(" ");
                Ticket1.AgregaTotales("Total: ", Convert.ToDouble(total));
                Ticket1.TextoIzquierda(" ");
                Ticket1.TextoIzquierda(" ");
                string impresora = "Microsoft XPS Document Writer";
                Ticket1.ImprimirTiket(impresora);
            }
        }
    }
}
