namespace POSLyion
{
    partial class formVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle127 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle128 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle129 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle130 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle131 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle132 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_principal = new System.Windows.Forms.Panel();
            this.tlp_principal = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_productos_carrito = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_productos = new System.Windows.Forms.TableLayoutPanel();
            this.txt_buscarproductos = new System.Windows.Forms.TextBox();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.dgv_productos_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_productos_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_productos_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_productos_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_suma_total = new System.Windows.Forms.Label();
            this.lbl_totale = new System.Windows.Forms.Label();
            this.tlp_tickets = new System.Windows.Forms.TableLayoutPanel();
            this.panel_right = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_factura = new System.Windows.Forms.Panel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_venta = new System.Windows.Forms.Button();
            this.btn_compra = new System.Windows.Forms.Button();
            this.btn_factura = new System.Windows.Forms.Button();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_tipoticket = new System.Windows.Forms.Label();
            this.btn_cerrarventa = new RJCodeAdvance.RJControls.RJButton();
            this.panel_resumen = new System.Windows.Forms.Panel();
            this.panel_container = new System.Windows.Forms.TableLayoutPanel();
            this.panel_resumido = new System.Windows.Forms.Panel();
            this.dgv_resumen = new System.Windows.Forms.DataGridView();
            this.dgv_resumen_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_resumen_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_resumen_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_resumen_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_resumen_subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_editar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_eliminar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_resumen = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_bottom = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_cerrarcaja = new RJCodeAdvance.RJControls.RJButton();
            this.btn_desc = new RJCodeAdvance.RJControls.RJButton();
            this.lbl_f2 = new System.Windows.Forms.Label();
            this.btn_nuevo_ticket = new RJCodeAdvance.RJControls.RJButton();
            this.panel_bot = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_updateversion = new System.Windows.Forms.Label();
            this.lbl_updatetime = new System.Windows.Forms.Label();
            this.panel_principal.SuspendLayout();
            this.tlp_principal.SuspendLayout();
            this.tlp_productos_carrito.SuspendLayout();
            this.tlp_productos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.tableLayoutPanel12.SuspendLayout();
            this.panel_right.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.panel_factura.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.panel_resumen.SuspendLayout();
            this.panel_container.SuspendLayout();
            this.panel_resumido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resumen)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel_bottom.SuspendLayout();
            this.panel_bot.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_principal
            // 
            this.panel_principal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_principal.Controls.Add(this.tlp_principal);
            this.panel_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_principal.Location = new System.Drawing.Point(0, 0);
            this.panel_principal.Name = "panel_principal";
            this.panel_principal.Size = new System.Drawing.Size(891, 553);
            this.panel_principal.TabIndex = 26;
            // 
            // tlp_principal
            // 
            this.tlp_principal.ColumnCount = 1;
            this.tlp_principal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_principal.Controls.Add(this.tlp_productos_carrito, 0, 0);
            this.tlp_principal.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tlp_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_principal.Location = new System.Drawing.Point(0, 0);
            this.tlp_principal.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_principal.Name = "tlp_principal";
            this.tlp_principal.RowCount = 2;
            this.tlp_principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_principal.Size = new System.Drawing.Size(891, 553);
            this.tlp_principal.TabIndex = 1;
            // 
            // tlp_productos_carrito
            // 
            this.tlp_productos_carrito.ColumnCount = 2;
            this.tlp_productos_carrito.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.46722F));
            this.tlp_productos_carrito.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.53279F));
            this.tlp_productos_carrito.Controls.Add(this.tlp_productos, 0, 0);
            this.tlp_productos_carrito.Controls.Add(this.panel_right, 1, 0);
            this.tlp_productos_carrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_productos_carrito.Location = new System.Drawing.Point(0, 0);
            this.tlp_productos_carrito.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_productos_carrito.Name = "tlp_productos_carrito";
            this.tlp_productos_carrito.RowCount = 1;
            this.tlp_productos_carrito.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_productos_carrito.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 453F));
            this.tlp_productos_carrito.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 453F));
            this.tlp_productos_carrito.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 453F));
            this.tlp_productos_carrito.Size = new System.Drawing.Size(891, 453);
            this.tlp_productos_carrito.TabIndex = 24;
            // 
            // tlp_productos
            // 
            this.tlp_productos.ColumnCount = 1;
            this.tlp_productos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_productos.Controls.Add(this.txt_buscarproductos, 0, 1);
            this.tlp_productos.Controls.Add(this.dgv_productos, 0, 2);
            this.tlp_productos.Controls.Add(this.tableLayoutPanel12, 0, 3);
            this.tlp_productos.Controls.Add(this.tlp_tickets, 0, 0);
            this.tlp_productos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_productos.Location = new System.Drawing.Point(0, 0);
            this.tlp_productos.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_productos.Name = "tlp_productos";
            this.tlp_productos.RowCount = 4;
            this.tlp_productos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_productos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_productos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_productos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_productos.Size = new System.Drawing.Size(618, 453);
            this.tlp_productos.TabIndex = 20;
            // 
            // txt_buscarproductos
            // 
            this.txt_buscarproductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscarproductos.Location = new System.Drawing.Point(3, 43);
            this.txt_buscarproductos.Name = "txt_buscarproductos";
            this.txt_buscarproductos.Size = new System.Drawing.Size(612, 26);
            this.txt_buscarproductos.TabIndex = 1;
            this.txt_buscarproductos.TextChanged += new System.EventHandler(this.txt_buscarproductos_TextChanged);
            // 
            // dgv_productos
            // 
            this.dgv_productos.AllowUserToAddRows = false;
            this.dgv_productos.AllowUserToDeleteRows = false;
            this.dgv_productos.AllowUserToResizeColumns = false;
            this.dgv_productos.AllowUserToResizeRows = false;
            dataGridViewCellStyle127.BackColor = System.Drawing.Color.Orchid;
            dataGridViewCellStyle127.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle127.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle127.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle127.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_productos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle127;
            this.dgv_productos.BackgroundColor = System.Drawing.Color.Black;
            this.dgv_productos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_productos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_productos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle128.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle128.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle128.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle128.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle128.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle128.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle128.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle128;
            this.dgv_productos.ColumnHeadersHeight = 35;
            this.dgv_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_productos_id,
            this.dgv_productos_descripcion,
            this.dgv_productos_precio,
            this.dgv_productos_stock});
            dataGridViewCellStyle129.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle129.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle129.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle129.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle129.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle129.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle129.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_productos.DefaultCellStyle = dataGridViewCellStyle129;
            this.dgv_productos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_productos.EnableHeadersVisualStyles = false;
            this.dgv_productos.GridColor = System.Drawing.Color.Crimson;
            this.dgv_productos.Location = new System.Drawing.Point(0, 80);
            this.dgv_productos.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_productos.MultiSelect = false;
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.ReadOnly = true;
            dataGridViewCellStyle130.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle130.BackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle130.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle130.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle130.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle130.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle130.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_productos.RowHeadersDefaultCellStyle = dataGridViewCellStyle130;
            this.dgv_productos.RowHeadersVisible = false;
            this.dgv_productos.RowHeadersWidth = 25;
            this.dgv_productos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_productos.RowTemplate.Height = 25;
            this.dgv_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_productos.Size = new System.Drawing.Size(618, 333);
            this.dgv_productos.TabIndex = 10;
            this.dgv_productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productos_CellClick);
            // 
            // dgv_productos_id
            // 
            this.dgv_productos_id.HeaderText = "ID";
            this.dgv_productos_id.Name = "dgv_productos_id";
            this.dgv_productos_id.ReadOnly = true;
            this.dgv_productos_id.Visible = false;
            // 
            // dgv_productos_descripcion
            // 
            this.dgv_productos_descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_productos_descripcion.FillWeight = 120F;
            this.dgv_productos_descripcion.HeaderText = "DESCRIPCION";
            this.dgv_productos_descripcion.Name = "dgv_productos_descripcion";
            this.dgv_productos_descripcion.ReadOnly = true;
            // 
            // dgv_productos_precio
            // 
            this.dgv_productos_precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_productos_precio.FillWeight = 60F;
            this.dgv_productos_precio.HeaderText = "PRECIO";
            this.dgv_productos_precio.Name = "dgv_productos_precio";
            this.dgv_productos_precio.ReadOnly = true;
            // 
            // dgv_productos_stock
            // 
            this.dgv_productos_stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_productos_stock.FillWeight = 60F;
            this.dgv_productos_stock.HeaderText = "STOCK";
            this.dgv_productos_stock.Name = "dgv_productos_stock";
            this.dgv_productos_stock.ReadOnly = true;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.BackColor = System.Drawing.Color.HotPink;
            this.tableLayoutPanel12.ColumnCount = 3;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel12.Controls.Add(this.lbl_suma_total, 2, 0);
            this.tableLayoutPanel12.Controls.Add(this.lbl_totale, 1, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(0, 413);
            this.tableLayoutPanel12.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(618, 40);
            this.tableLayoutPanel12.TabIndex = 11;
            // 
            // lbl_suma_total
            // 
            this.lbl_suma_total.AutoSize = true;
            this.lbl_suma_total.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_suma_total.Enabled = false;
            this.lbl_suma_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_suma_total.Location = new System.Drawing.Point(544, 0);
            this.lbl_suma_total.Name = "lbl_suma_total";
            this.lbl_suma_total.Size = new System.Drawing.Size(71, 40);
            this.lbl_suma_total.TabIndex = 6;
            this.lbl_suma_total.Text = "0,00";
            this.lbl_suma_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_totale
            // 
            this.lbl_totale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_totale.AutoSize = true;
            this.lbl_totale.Enabled = false;
            this.lbl_totale.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_totale.Location = new System.Drawing.Point(425, 4);
            this.lbl_totale.Name = "lbl_totale";
            this.lbl_totale.Size = new System.Drawing.Size(113, 31);
            this.lbl_totale.TabIndex = 9;
            this.lbl_totale.Text = "Total: $";
            // 
            // tlp_tickets
            // 
            this.tlp_tickets.AutoScroll = true;
            this.tlp_tickets.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tlp_tickets.ColumnCount = 1;
            this.tlp_tickets.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_tickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_tickets.Location = new System.Drawing.Point(0, 0);
            this.tlp_tickets.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_tickets.Name = "tlp_tickets";
            this.tlp_tickets.RowCount = 1;
            this.tlp_tickets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_tickets.Size = new System.Drawing.Size(618, 40);
            this.tlp_tickets.TabIndex = 12;
            // 
            // panel_right
            // 
            this.panel_right.ColumnCount = 1;
            this.panel_right.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_right.Controls.Add(this.tableLayoutPanel10, 0, 0);
            this.panel_right.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.panel_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_right.Location = new System.Drawing.Point(618, 0);
            this.panel_right.Margin = new System.Windows.Forms.Padding(0);
            this.panel_right.Name = "panel_right";
            this.panel_right.RowCount = 2;
            this.panel_right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panel_right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.panel_right.Size = new System.Drawing.Size(273, 453);
            this.panel_right.TabIndex = 17;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.BackColor = System.Drawing.Color.DarkMagenta;
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Controls.Add(this.panel_factura, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel11, 0, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(273, 90);
            this.tableLayoutPanel10.TabIndex = 15;
            // 
            // panel_factura
            // 
            this.panel_factura.BackColor = System.Drawing.Color.Crimson;
            this.panel_factura.Controls.Add(this.lbl_titulo);
            this.panel_factura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_factura.Location = new System.Drawing.Point(3, 30);
            this.panel_factura.Name = "panel_factura";
            this.panel_factura.Size = new System.Drawing.Size(267, 57);
            this.panel_factura.TabIndex = 0;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Enabled = false;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(20, 16);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(224, 31);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "FACTURACION";
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 3;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel11.Controls.Add(this.btn_venta, 2, 0);
            this.tableLayoutPanel11.Controls.Add(this.btn_compra, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.btn_factura, 0, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(273, 27);
            this.tableLayoutPanel11.TabIndex = 1;
            // 
            // btn_venta
            // 
            this.btn_venta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_venta.Location = new System.Drawing.Point(182, 0);
            this.btn_venta.Margin = new System.Windows.Forms.Padding(0);
            this.btn_venta.Name = "btn_venta";
            this.btn_venta.Size = new System.Drawing.Size(91, 27);
            this.btn_venta.TabIndex = 4;
            this.btn_venta.Text = "Ventas";
            this.btn_venta.UseVisualStyleBackColor = true;
            this.btn_venta.Click += new System.EventHandler(this.btn_venta_Click);
            // 
            // btn_compra
            // 
            this.btn_compra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_compra.Location = new System.Drawing.Point(91, 0);
            this.btn_compra.Margin = new System.Windows.Forms.Padding(0);
            this.btn_compra.Name = "btn_compra";
            this.btn_compra.Size = new System.Drawing.Size(91, 27);
            this.btn_compra.TabIndex = 3;
            this.btn_compra.Text = "Compra";
            this.btn_compra.UseVisualStyleBackColor = true;
            this.btn_compra.Click += new System.EventHandler(this.btn_compra_Click);
            // 
            // btn_factura
            // 
            this.btn_factura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_factura.Location = new System.Drawing.Point(0, 0);
            this.btn_factura.Margin = new System.Windows.Forms.Padding(0);
            this.btn_factura.Name = "btn_factura";
            this.btn_factura.Size = new System.Drawing.Size(91, 27);
            this.btn_factura.TabIndex = 2;
            this.btn_factura.Text = "Facturación";
            this.btn_factura.UseVisualStyleBackColor = true;
            this.btn_factura.Click += new System.EventHandler(this.btn_factura_Click);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.BackColor = System.Drawing.Color.DarkMagenta;
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.btn_cerrarventa, 1, 4);
            this.tableLayoutPanel8.Controls.Add(this.panel_resumen, 1, 2);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 90);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 5;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(273, 363);
            this.tableLayoutPanel8.TabIndex = 16;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.BackColor = System.Drawing.Color.MediumVioletRed;
            this.tableLayoutPanel9.ColumnCount = 3;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel9.Controls.Add(this.lbl_tipoticket, 1, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(10, 0);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 3;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(253, 40);
            this.tableLayoutPanel9.TabIndex = 13;
            // 
            // lbl_tipoticket
            // 
            this.lbl_tipoticket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_tipoticket.AutoSize = true;
            this.lbl_tipoticket.Enabled = false;
            this.lbl_tipoticket.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipoticket.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_tipoticket.Location = new System.Drawing.Point(36, 6);
            this.lbl_tipoticket.Name = "lbl_tipoticket";
            this.lbl_tipoticket.Size = new System.Drawing.Size(181, 28);
            this.lbl_tipoticket.TabIndex = 0;
            this.lbl_tipoticket.Text = "Consumidor final";
            this.lbl_tipoticket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_cerrarventa
            // 
            this.btn_cerrarventa.BackColor = System.Drawing.Color.Black;
            this.btn_cerrarventa.BackgroundColor = System.Drawing.Color.Black;
            this.btn_cerrarventa.BorderColor = System.Drawing.Color.Gold;
            this.btn_cerrarventa.BorderRadius = 5;
            this.btn_cerrarventa.BorderSize = 2;
            this.btn_cerrarventa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_cerrarventa.FlatAppearance.BorderSize = 0;
            this.btn_cerrarventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrarventa.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrarventa.ForeColor = System.Drawing.Color.Gold;
            this.btn_cerrarventa.Location = new System.Drawing.Point(10, 323);
            this.btn_cerrarventa.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btn_cerrarventa.Name = "btn_cerrarventa";
            this.btn_cerrarventa.Size = new System.Drawing.Size(253, 37);
            this.btn_cerrarventa.TabIndex = 5;
            this.btn_cerrarventa.Text = "CERRAR VENTA (F10)";
            this.btn_cerrarventa.TextColor = System.Drawing.Color.Gold;
            this.btn_cerrarventa.UseVisualStyleBackColor = false;
            this.btn_cerrarventa.Click += new System.EventHandler(this.btn_cerrarventa_Click);
            // 
            // panel_resumen
            // 
            this.panel_resumen.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel_resumen.Controls.Add(this.panel_container);
            this.panel_resumen.Controls.Add(this.lbl_resumen);
            this.panel_resumen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_resumen.Location = new System.Drawing.Point(13, 46);
            this.panel_resumen.Name = "panel_resumen";
            this.panel_resumen.Size = new System.Drawing.Size(247, 269);
            this.panel_resumen.TabIndex = 14;
            // 
            // panel_container
            // 
            this.panel_container.BackColor = System.Drawing.Color.Black;
            this.panel_container.ColumnCount = 1;
            this.panel_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_container.Controls.Add(this.panel_resumido, 0, 0);
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.Location = new System.Drawing.Point(0, 0);
            this.panel_container.Name = "panel_container";
            this.panel_container.RowCount = 2;
            this.panel_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.panel_container.Size = new System.Drawing.Size(247, 269);
            this.panel_container.TabIndex = 1;
            // 
            // panel_resumido
            // 
            this.panel_resumido.Controls.Add(this.dgv_resumen);
            this.panel_resumido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_resumido.Location = new System.Drawing.Point(0, 0);
            this.panel_resumido.Margin = new System.Windows.Forms.Padding(0);
            this.panel_resumido.Name = "panel_resumido";
            this.panel_resumido.Size = new System.Drawing.Size(247, 259);
            this.panel_resumido.TabIndex = 0;
            // 
            // dgv_resumen
            // 
            this.dgv_resumen.AllowUserToAddRows = false;
            this.dgv_resumen.AllowUserToDeleteRows = false;
            this.dgv_resumen.AllowUserToResizeRows = false;
            this.dgv_resumen.BackgroundColor = System.Drawing.Color.Black;
            this.dgv_resumen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_resumen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_resumen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle131.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle131.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle131.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle131.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle131.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle131.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle131.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_resumen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle131;
            this.dgv_resumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_resumen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_resumen_id,
            this.dgv_resumen_descripcion,
            this.dgv_resumen_cantidad,
            this.dgv_resumen_precio,
            this.dgv_resumen_subtotal,
            this.btn_editar,
            this.btn_eliminar});
            dataGridViewCellStyle132.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle132.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle132.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle132.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle132.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle132.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle132.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_resumen.DefaultCellStyle = dataGridViewCellStyle132;
            this.dgv_resumen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_resumen.EnableHeadersVisualStyles = false;
            this.dgv_resumen.Location = new System.Drawing.Point(0, 0);
            this.dgv_resumen.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_resumen.Name = "dgv_resumen";
            this.dgv_resumen.ReadOnly = true;
            this.dgv_resumen.RowHeadersVisible = false;
            this.dgv_resumen.Size = new System.Drawing.Size(247, 259);
            this.dgv_resumen.TabIndex = 8;
            this.dgv_resumen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_resumen_CellContentClick);
            // 
            // dgv_resumen_id
            // 
            this.dgv_resumen_id.HeaderText = "ID";
            this.dgv_resumen_id.Name = "dgv_resumen_id";
            this.dgv_resumen_id.ReadOnly = true;
            this.dgv_resumen_id.Visible = false;
            // 
            // dgv_resumen_descripcion
            // 
            this.dgv_resumen_descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_resumen_descripcion.FillWeight = 200F;
            this.dgv_resumen_descripcion.HeaderText = "Producto";
            this.dgv_resumen_descripcion.Name = "dgv_resumen_descripcion";
            this.dgv_resumen_descripcion.ReadOnly = true;
            // 
            // dgv_resumen_cantidad
            // 
            this.dgv_resumen_cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_resumen_cantidad.HeaderText = "Cantidad";
            this.dgv_resumen_cantidad.Name = "dgv_resumen_cantidad";
            this.dgv_resumen_cantidad.ReadOnly = true;
            // 
            // dgv_resumen_precio
            // 
            this.dgv_resumen_precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_resumen_precio.HeaderText = "Precio";
            this.dgv_resumen_precio.Name = "dgv_resumen_precio";
            this.dgv_resumen_precio.ReadOnly = true;
            // 
            // dgv_resumen_subtotal
            // 
            this.dgv_resumen_subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_resumen_subtotal.HeaderText = "Subtotal";
            this.dgv_resumen_subtotal.Name = "dgv_resumen_subtotal";
            this.dgv_resumen_subtotal.ReadOnly = true;
            // 
            // btn_editar
            // 
            this.btn_editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btn_editar.FillWeight = 60F;
            this.btn_editar.HeaderText = "";
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.ReadOnly = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btn_eliminar.FillWeight = 60F;
            this.btn_eliminar.HeaderText = "";
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.ReadOnly = true;
            // 
            // lbl_resumen
            // 
            this.lbl_resumen.AutoSize = true;
            this.lbl_resumen.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resumen.ForeColor = System.Drawing.Color.Gold;
            this.lbl_resumen.Location = new System.Drawing.Point(26, 15);
            this.lbl_resumen.Name = "lbl_resumen";
            this.lbl_resumen.Size = new System.Drawing.Size(0, 21);
            this.lbl_resumen.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.Crimson;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.panel_bot, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 453);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(891, 100);
            this.tableLayoutPanel6.TabIndex = 22;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.panel_bottom, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(885, 74);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Crimson;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(265, 74);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 37);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(265, 37);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // panel_bottom
            // 
            this.panel_bottom.BackColor = System.Drawing.Color.Crimson;
            this.panel_bottom.ColumnCount = 4;
            this.panel_bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel_bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel_bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel_bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel_bottom.Controls.Add(this.lbl_cerrarcaja, 3, 1);
            this.panel_bottom.Controls.Add(this.btn_desc, 2, 1);
            this.panel_bottom.Controls.Add(this.lbl_f2, 2, 0);
            this.panel_bottom.Controls.Add(this.btn_nuevo_ticket, 1, 1);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_bottom.Location = new System.Drawing.Point(265, 0);
            this.panel_bottom.Margin = new System.Windows.Forms.Padding(0);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.RowCount = 2;
            this.panel_bottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_bottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_bottom.Size = new System.Drawing.Size(620, 74);
            this.panel_bottom.TabIndex = 9;
            // 
            // lbl_cerrarcaja
            // 
            this.lbl_cerrarcaja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cerrarcaja.AutoSize = true;
            this.lbl_cerrarcaja.BackColor = System.Drawing.Color.Gold;
            this.lbl_cerrarcaja.BackgroundColor = System.Drawing.Color.Gold;
            this.lbl_cerrarcaja.BorderColor = System.Drawing.Color.Black;
            this.lbl_cerrarcaja.BorderRadius = 0;
            this.lbl_cerrarcaja.BorderSize = 0;
            this.lbl_cerrarcaja.FlatAppearance.BorderSize = 0;
            this.lbl_cerrarcaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_cerrarcaja.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cerrarcaja.ForeColor = System.Drawing.Color.Black;
            this.lbl_cerrarcaja.Location = new System.Drawing.Point(468, 40);
            this.lbl_cerrarcaja.Name = "lbl_cerrarcaja";
            this.lbl_cerrarcaja.Size = new System.Drawing.Size(149, 31);
            this.lbl_cerrarcaja.TabIndex = 7;
            this.lbl_cerrarcaja.Text = "CERRAR CAJA";
            this.lbl_cerrarcaja.TextColor = System.Drawing.Color.Black;
            this.lbl_cerrarcaja.UseVisualStyleBackColor = false;
            this.lbl_cerrarcaja.Click += new System.EventHandler(this.lbl_cerrarcaja_Click);
            // 
            // btn_desc
            // 
            this.btn_desc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_desc.AutoSize = true;
            this.btn_desc.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_desc.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_desc.BorderColor = System.Drawing.Color.Black;
            this.btn_desc.BorderRadius = 0;
            this.btn_desc.BorderSize = 0;
            this.btn_desc.FlatAppearance.BorderSize = 0;
            this.btn_desc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_desc.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desc.ForeColor = System.Drawing.Color.White;
            this.btn_desc.Location = new System.Drawing.Point(313, 40);
            this.btn_desc.Name = "btn_desc";
            this.btn_desc.Size = new System.Drawing.Size(149, 31);
            this.btn_desc.TabIndex = 6;
            this.btn_desc.Text = "CLIENTE";
            this.btn_desc.TextColor = System.Drawing.Color.White;
            this.btn_desc.UseVisualStyleBackColor = false;
            this.btn_desc.Click += new System.EventHandler(this.btn_desc_Click);
            // 
            // lbl_f2
            // 
            this.lbl_f2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_f2.AutoSize = true;
            this.lbl_f2.Enabled = false;
            this.lbl_f2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_f2.ForeColor = System.Drawing.Color.FloralWhite;
            this.lbl_f2.Location = new System.Drawing.Point(373, 7);
            this.lbl_f2.Name = "lbl_f2";
            this.lbl_f2.Size = new System.Drawing.Size(29, 22);
            this.lbl_f2.TabIndex = 8;
            this.lbl_f2.Text = "F2";
            // 
            // btn_nuevo_ticket
            // 
            this.btn_nuevo_ticket.AutoSize = true;
            this.btn_nuevo_ticket.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_nuevo_ticket.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_nuevo_ticket.BorderColor = System.Drawing.Color.Black;
            this.btn_nuevo_ticket.BorderRadius = 0;
            this.btn_nuevo_ticket.BorderSize = 0;
            this.btn_nuevo_ticket.FlatAppearance.BorderSize = 0;
            this.btn_nuevo_ticket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo_ticket.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo_ticket.ForeColor = System.Drawing.Color.White;
            this.btn_nuevo_ticket.Location = new System.Drawing.Point(158, 40);
            this.btn_nuevo_ticket.Name = "btn_nuevo_ticket";
            this.btn_nuevo_ticket.Size = new System.Drawing.Size(149, 31);
            this.btn_nuevo_ticket.TabIndex = 9;
            this.btn_nuevo_ticket.Text = "TICKET PENDIENTE";
            this.btn_nuevo_ticket.TextColor = System.Drawing.Color.White;
            this.btn_nuevo_ticket.UseVisualStyleBackColor = false;
            this.btn_nuevo_ticket.Click += new System.EventHandler(this.btn_nuevo_ticket_Click);
            // 
            // panel_bot
            // 
            this.panel_bot.BackColor = System.Drawing.Color.Black;
            this.panel_bot.ColumnCount = 3;
            this.panel_bot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_bot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panel_bot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panel_bot.Controls.Add(this.lbl_updateversion, 2, 0);
            this.panel_bot.Controls.Add(this.lbl_updatetime, 1, 0);
            this.panel_bot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_bot.Location = new System.Drawing.Point(0, 80);
            this.panel_bot.Margin = new System.Windows.Forms.Padding(0);
            this.panel_bot.Name = "panel_bot";
            this.panel_bot.RowCount = 1;
            this.panel_bot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_bot.Size = new System.Drawing.Size(891, 20);
            this.panel_bot.TabIndex = 3;
            // 
            // lbl_updateversion
            // 
            this.lbl_updateversion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_updateversion.AutoSize = true;
            this.lbl_updateversion.BackColor = System.Drawing.Color.Black;
            this.lbl_updateversion.ForeColor = System.Drawing.Color.Gold;
            this.lbl_updateversion.Location = new System.Drawing.Point(773, 3);
            this.lbl_updateversion.Name = "lbl_updateversion";
            this.lbl_updateversion.Size = new System.Drawing.Size(115, 13);
            this.lbl_updateversion.TabIndex = 2;
            this.lbl_updateversion.Text = "Actualizacion: v1.0.0.5";
            // 
            // lbl_updatetime
            // 
            this.lbl_updatetime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_updatetime.AutoSize = true;
            this.lbl_updatetime.BackColor = System.Drawing.Color.Black;
            this.lbl_updatetime.ForeColor = System.Drawing.Color.Gold;
            this.lbl_updatetime.Location = new System.Drawing.Point(568, 3);
            this.lbl_updatetime.Name = "lbl_updatetime";
            this.lbl_updatetime.Size = new System.Drawing.Size(199, 13);
            this.lbl_updatetime.TabIndex = 3;
            this.lbl_updatetime.Text = "Ultimo chequeo: 10:06:12  - 20/09/2024";
            // 
            // formVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 553);
            this.Controls.Add(this.panel_principal);
            this.Name = "formVentas";
            this.Text = "formVentas";
            this.Load += new System.EventHandler(this.formVentas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formVentas_KeyDown);
            this.panel_principal.ResumeLayout(false);
            this.tlp_principal.ResumeLayout(false);
            this.tlp_productos_carrito.ResumeLayout(false);
            this.tlp_productos.ResumeLayout(false);
            this.tlp_productos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.panel_right.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.panel_factura.ResumeLayout(false);
            this.panel_factura.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.panel_resumen.ResumeLayout(false);
            this.panel_resumen.PerformLayout();
            this.panel_container.ResumeLayout(false);
            this.panel_resumido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resumen)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.panel_bot.ResumeLayout(false);
            this.panel_bot.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_principal;
        private System.Windows.Forms.TableLayoutPanel tlp_principal;
        private System.Windows.Forms.TableLayoutPanel tlp_productos_carrito;
        private System.Windows.Forms.TableLayoutPanel panel_right;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Panel panel_factura;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Button btn_venta;
        private System.Windows.Forms.Button btn_compra;
        private System.Windows.Forms.Button btn_factura;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label lbl_tipoticket;
        private RJCodeAdvance.RJControls.RJButton btn_cerrarventa;
        private System.Windows.Forms.Panel panel_resumen;
        private System.Windows.Forms.TableLayoutPanel panel_container;
        private System.Windows.Forms.Panel panel_resumido;
        private System.Windows.Forms.DataGridView dgv_resumen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_resumen_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_resumen_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_resumen_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_resumen_precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_resumen_subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn btn_editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn btn_eliminar;
        private System.Windows.Forms.Label lbl_resumen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel panel_bottom;
        private RJCodeAdvance.RJControls.RJButton lbl_cerrarcaja;
        private RJCodeAdvance.RJControls.RJButton btn_desc;
        private System.Windows.Forms.Label lbl_f2;
        private System.Windows.Forms.TableLayoutPanel panel_bot;
        private System.Windows.Forms.Label lbl_updateversion;
        private System.Windows.Forms.Label lbl_updatetime;
        private RJCodeAdvance.RJControls.RJButton btn_nuevo_ticket;
        private System.Windows.Forms.TableLayoutPanel tlp_productos;
        private System.Windows.Forms.TextBox txt_buscarproductos;
        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_productos_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_productos_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_productos_precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_productos_stock;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.Label lbl_suma_total;
        private System.Windows.Forms.Label lbl_totale;
        private System.Windows.Forms.TableLayoutPanel tlp_tickets;
    }
}