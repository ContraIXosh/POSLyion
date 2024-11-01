namespace POSLyion
{
    partial class formCompras
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
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_precio_costo = new System.Windows.Forms.TextBox();
            this.txt_codigo_barras = new System.Windows.Forms.TextBox();
            this.txt_id_producto = new System.Windows.Forms.TextBox();
            this.num_cantidad = new System.Windows.Forms.NumericUpDown();
            this.lbox_productos = new System.Windows.Forms.ListBox();
            this.btn_buscar_producto = new CustomBox.RJControls.RJButton();
            this.txt_descripcion_producto = new System.Windows.Forms.TextBox();
            this.lbl_codigo_barras = new System.Windows.Forms.Label();
            this.btn_agregar_producto = new CustomBox.RJControls.RJButton();
            this.lbl_precio_costo = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.lbl_descripcion_producto = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_compras = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_suma_total = new System.Windows.Forms.Label();
            this.btn_cerrar = new CustomBox.RJControls.RJButton();
            this.btn_guardar = new CustomBox.RJControls.RJButton();
            this.label10 = new System.Windows.Forms.Label();
            this.tlpanel_3 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_cuit_proveedor = new RJCodeAdvance.RJControls.RJTextBox();
            this.txt_id_proveedor = new System.Windows.Forms.TextBox();
            this.tlpanel_2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_fecha_doc = new System.Windows.Forms.Label();
            this.lbl_tipo_doc = new System.Windows.Forms.Label();
            this.cbo_tipo_documento = new CustomBox.RJControls.RJComboBox();
            this.date_fecha_doc = new CustomBox.RJControls.RJDatePicker();
            this.tlpanel_primera = new System.Windows.Forms.TableLayoutPanel();
            this.txt_descripcion_proveedor = new System.Windows.Forms.TextBox();
            this.rjTextBox2 = new CustomBox.RJControls.RJTextBox();
            this.lbl_guion = new System.Windows.Forms.Label();
            this.txt_numero_documento = new CustomBox.RJControls.RJTextBox();
            this.lbl_nro_doc = new System.Windows.Forms.Label();
            this.lbl_proveedor = new System.Windows.Forms.Label();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_barras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_editar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_eliminar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_main.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_cantidad)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_compras)).BeginInit();
            this.panel2.SuspendLayout();
            this.tlpanel_3.SuspendLayout();
            this.tlpanel_2.SuspendLayout();
            this.tlpanel_primera.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_main.Controls.Add(this.panel1);
            this.panel_main.Controls.Add(this.tlpanel_3);
            this.panel_main.Controls.Add(this.tlpanel_2);
            this.panel_main.Controls.Add(this.tlpanel_primera);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(984, 537);
            this.panel_main.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 399);
            this.panel1.TabIndex = 20;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txt_precio_costo);
            this.panel5.Controls.Add(this.txt_codigo_barras);
            this.panel5.Controls.Add(this.txt_id_producto);
            this.panel5.Controls.Add(this.num_cantidad);
            this.panel5.Controls.Add(this.lbox_productos);
            this.panel5.Controls.Add(this.btn_buscar_producto);
            this.panel5.Controls.Add(this.txt_descripcion_producto);
            this.panel5.Controls.Add(this.lbl_codigo_barras);
            this.panel5.Controls.Add(this.btn_agregar_producto);
            this.panel5.Controls.Add(this.lbl_precio_costo);
            this.panel5.Controls.Add(this.lbl_cantidad);
            this.panel5.Controls.Add(this.lbl_descripcion_producto);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(389, 299);
            this.panel5.TabIndex = 2;
            // 
            // txt_precio_costo
            // 
            this.txt_precio_costo.Location = new System.Drawing.Point(123, 236);
            this.txt_precio_costo.Name = "txt_precio_costo";
            this.txt_precio_costo.Size = new System.Drawing.Size(247, 20);
            this.txt_precio_costo.TabIndex = 37;
            this.txt_precio_costo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_costo_KeyPress);
            // 
            // txt_codigo_barras
            // 
            this.txt_codigo_barras.Location = new System.Drawing.Point(120, 37);
            this.txt_codigo_barras.Name = "txt_codigo_barras";
            this.txt_codigo_barras.Size = new System.Drawing.Size(250, 20);
            this.txt_codigo_barras.TabIndex = 36;
            this.txt_codigo_barras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_codigo_barras_KeyDown);
            // 
            // txt_id_producto
            // 
            this.txt_id_producto.Location = new System.Drawing.Point(21, 37);
            this.txt_id_producto.Name = "txt_id_producto";
            this.txt_id_producto.Size = new System.Drawing.Size(69, 20);
            this.txt_id_producto.TabIndex = 35;
            // 
            // num_cantidad
            // 
            this.num_cantidad.Location = new System.Drawing.Point(120, 161);
            this.num_cantidad.Name = "num_cantidad";
            this.num_cantidad.Size = new System.Drawing.Size(250, 20);
            this.num_cantidad.TabIndex = 34;
            // 
            // lbox_productos
            // 
            this.lbox_productos.FormattingEnabled = true;
            this.lbox_productos.Location = new System.Drawing.Point(120, 112);
            this.lbox_productos.Name = "lbox_productos";
            this.lbox_productos.ScrollAlwaysVisible = true;
            this.lbox_productos.Size = new System.Drawing.Size(250, 121);
            this.lbox_productos.TabIndex = 33;
            this.lbox_productos.Visible = false;
            // 
            // btn_buscar_producto
            // 
            this.btn_buscar_producto.BackColor = System.Drawing.Color.Transparent;
            this.btn_buscar_producto.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_buscar_producto.BorderColor = System.Drawing.Color.White;
            this.btn_buscar_producto.BorderRadius = 10;
            this.btn_buscar_producto.BorderSize = 2;
            this.btn_buscar_producto.FlatAppearance.BorderSize = 0;
            this.btn_buscar_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_producto.ForeColor = System.Drawing.Color.White;
            this.btn_buscar_producto.Location = new System.Drawing.Point(290, 87);
            this.btn_buscar_producto.Name = "btn_buscar_producto";
            this.btn_buscar_producto.Size = new System.Drawing.Size(99, 29);
            this.btn_buscar_producto.TabIndex = 32;
            this.btn_buscar_producto.Text = "Buscar";
            this.btn_buscar_producto.TextColor = System.Drawing.Color.White;
            this.btn_buscar_producto.UseVisualStyleBackColor = false;
            this.btn_buscar_producto.Click += new System.EventHandler(this.btn_buscar_producto_Click);
            // 
            // txt_descripcion_producto
            // 
            this.txt_descripcion_producto.Location = new System.Drawing.Point(120, 92);
            this.txt_descripcion_producto.Name = "txt_descripcion_producto";
            this.txt_descripcion_producto.Size = new System.Drawing.Size(170, 20);
            this.txt_descripcion_producto.TabIndex = 31;
            // 
            // lbl_codigo_barras
            // 
            this.lbl_codigo_barras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_codigo_barras.AutoSize = true;
            this.lbl_codigo_barras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo_barras.ForeColor = System.Drawing.Color.Gold;
            this.lbl_codigo_barras.Location = new System.Drawing.Point(160, 0);
            this.lbl_codigo_barras.Name = "lbl_codigo_barras";
            this.lbl_codigo_barras.Size = new System.Drawing.Size(171, 24);
            this.lbl_codigo_barras.TabIndex = 29;
            this.lbl_codigo_barras.Text = "Codigo de barras";
            // 
            // btn_agregar_producto
            // 
            this.btn_agregar_producto.BackColor = System.Drawing.Color.Transparent;
            this.btn_agregar_producto.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_agregar_producto.BorderColor = System.Drawing.Color.Lime;
            this.btn_agregar_producto.BorderRadius = 10;
            this.btn_agregar_producto.BorderSize = 2;
            this.btn_agregar_producto.FlatAppearance.BorderSize = 0;
            this.btn_agregar_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_producto.ForeColor = System.Drawing.Color.Lime;
            this.btn_agregar_producto.Location = new System.Drawing.Point(252, 261);
            this.btn_agregar_producto.Name = "btn_agregar_producto";
            this.btn_agregar_producto.Size = new System.Drawing.Size(137, 37);
            this.btn_agregar_producto.TabIndex = 26;
            this.btn_agregar_producto.Text = "Agregar";
            this.btn_agregar_producto.TextColor = System.Drawing.Color.Lime;
            this.btn_agregar_producto.UseVisualStyleBackColor = false;
            this.btn_agregar_producto.Click += new System.EventHandler(this.btn_agregar_producto_Click);
            // 
            // lbl_precio_costo
            // 
            this.lbl_precio_costo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_precio_costo.AutoSize = true;
            this.lbl_precio_costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio_costo.ForeColor = System.Drawing.Color.Gold;
            this.lbl_precio_costo.Location = new System.Drawing.Point(8, 228);
            this.lbl_precio_costo.Name = "lbl_precio_costo";
            this.lbl_precio_costo.Size = new System.Drawing.Size(108, 24);
            this.lbl_precio_costo.TabIndex = 22;
            this.lbl_precio_costo.Text = "Precio Un.";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.ForeColor = System.Drawing.Color.Gold;
            this.lbl_cantidad.Location = new System.Drawing.Point(8, 158);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(92, 24);
            this.lbl_cantidad.TabIndex = 20;
            this.lbl_cantidad.Text = "Cantidad";
            // 
            // lbl_descripcion_producto
            // 
            this.lbl_descripcion_producto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_descripcion_producto.AutoSize = true;
            this.lbl_descripcion_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion_producto.ForeColor = System.Drawing.Color.Gold;
            this.lbl_descripcion_producto.Location = new System.Drawing.Point(8, 87);
            this.lbl_descripcion_producto.Name = "lbl_descripcion_producto";
            this.lbl_descripcion_producto.Size = new System.Drawing.Size(94, 24);
            this.lbl_descripcion_producto.TabIndex = 18;
            this.lbl_descripcion_producto.Text = "Producto";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgv_compras);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(390, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(594, 299);
            this.panel4.TabIndex = 1;
            // 
            // dgv_compras
            // 
            this.dgv_compras.AllowUserToAddRows = false;
            this.dgv_compras.AllowUserToDeleteRows = false;
            this.dgv_compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_compras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_producto,
            this.codigo_barras,
            this.descripcion_producto,
            this.cantidad,
            this.precio_costo,
            this.subtotal,
            this.btn_editar,
            this.btn_eliminar});
            this.dgv_compras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_compras.Location = new System.Drawing.Point(0, 0);
            this.dgv_compras.Name = "dgv_compras";
            this.dgv_compras.ReadOnly = true;
            this.dgv_compras.Size = new System.Drawing.Size(594, 299);
            this.dgv_compras.TabIndex = 0;
            this.dgv_compras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_compras_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.lbl_suma_total);
            this.panel2.Controls.Add(this.btn_cerrar);
            this.panel2.Controls.Add(this.btn_guardar);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 299);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 100);
            this.panel2.TabIndex = 0;
            // 
            // lbl_suma_total
            // 
            this.lbl_suma_total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_suma_total.AutoSize = true;
            this.lbl_suma_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_suma_total.ForeColor = System.Drawing.Color.Gold;
            this.lbl_suma_total.Location = new System.Drawing.Point(398, 56);
            this.lbl_suma_total.Name = "lbl_suma_total";
            this.lbl_suma_total.Size = new System.Drawing.Size(49, 24);
            this.lbl_suma_total.TabIndex = 27;
            this.lbl_suma_total.Text = "0,00";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_cerrar.BorderColor = System.Drawing.Color.Red;
            this.btn_cerrar.BorderRadius = 10;
            this.btn_cerrar.BorderSize = 2;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.Red;
            this.btn_cerrar.Location = new System.Drawing.Point(832, 47);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(137, 37);
            this.btn_cerrar.TabIndex = 26;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.TextColor = System.Drawing.Color.Red;
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_guardar.BorderColor = System.Drawing.Color.Lime;
            this.btn_guardar.BorderRadius = 10;
            this.btn_guardar.BorderSize = 2;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.Lime;
            this.btn_guardar.Location = new System.Drawing.Point(682, 47);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(137, 37);
            this.btn_guardar.TabIndex = 25;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextColor = System.Drawing.Color.Lime;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gold;
            this.label10.Location = new System.Drawing.Point(324, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 24);
            this.label10.TabIndex = 22;
            this.label10.Text = "Total: $";
            // 
            // tlpanel_3
            // 
            this.tlpanel_3.ColumnCount = 5;
            this.tlpanel_3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.22036F));
            this.tlpanel_3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.22036F));
            this.tlpanel_3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.15425F));
            this.tlpanel_3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.22036F));
            this.tlpanel_3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.18468F));
            this.tlpanel_3.Controls.Add(this.txt_cuit_proveedor, 1, 0);
            this.tlpanel_3.Controls.Add(this.txt_id_proveedor, 0, 0);
            this.tlpanel_3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpanel_3.Location = new System.Drawing.Point(0, 92);
            this.tlpanel_3.Margin = new System.Windows.Forms.Padding(0);
            this.tlpanel_3.Name = "tlpanel_3";
            this.tlpanel_3.RowCount = 1;
            this.tlpanel_3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpanel_3.Size = new System.Drawing.Size(984, 46);
            this.tlpanel_3.TabIndex = 19;
            // 
            // txt_cuit_proveedor
            // 
            this.txt_cuit_proveedor.BackColor = System.Drawing.SystemColors.Window;
            this.txt_cuit_proveedor.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_cuit_proveedor.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_cuit_proveedor.BorderRadius = 0;
            this.txt_cuit_proveedor.BorderSize = 2;
            this.txt_cuit_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cuit_proveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_cuit_proveedor.Location = new System.Drawing.Point(202, 4);
            this.txt_cuit_proveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cuit_proveedor.Multiline = false;
            this.txt_cuit_proveedor.Name = "txt_cuit_proveedor";
            this.txt_cuit_proveedor.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_cuit_proveedor.PasswordChar = false;
            this.txt_cuit_proveedor.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_cuit_proveedor.PlaceholderText = "";
            this.txt_cuit_proveedor.Size = new System.Drawing.Size(190, 31);
            this.txt_cuit_proveedor.TabIndex = 1;
            this.txt_cuit_proveedor.Texts = "";
            this.txt_cuit_proveedor.UnderlinedStyle = false;
            // 
            // txt_id_proveedor
            // 
            this.txt_id_proveedor.Location = new System.Drawing.Point(3, 3);
            this.txt_id_proveedor.Name = "txt_id_proveedor";
            this.txt_id_proveedor.Size = new System.Drawing.Size(100, 20);
            this.txt_id_proveedor.TabIndex = 2;
            // 
            // tlpanel_2
            // 
            this.tlpanel_2.ColumnCount = 4;
            this.tlpanel_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.98949F));
            this.tlpanel_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00496F));
            this.tlpanel_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.0006F));
            this.tlpanel_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00496F));
            this.tlpanel_2.Controls.Add(this.lbl_fecha_doc, 2, 0);
            this.tlpanel_2.Controls.Add(this.lbl_tipo_doc, 0, 0);
            this.tlpanel_2.Controls.Add(this.cbo_tipo_documento, 1, 0);
            this.tlpanel_2.Controls.Add(this.date_fecha_doc, 3, 0);
            this.tlpanel_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpanel_2.Location = new System.Drawing.Point(0, 46);
            this.tlpanel_2.Margin = new System.Windows.Forms.Padding(0);
            this.tlpanel_2.Name = "tlpanel_2";
            this.tlpanel_2.RowCount = 1;
            this.tlpanel_2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpanel_2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpanel_2.Size = new System.Drawing.Size(984, 46);
            this.tlpanel_2.TabIndex = 18;
            // 
            // lbl_fecha_doc
            // 
            this.lbl_fecha_doc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_fecha_doc.AutoSize = true;
            this.lbl_fecha_doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_doc.ForeColor = System.Drawing.Color.Gold;
            this.lbl_fecha_doc.Location = new System.Drawing.Point(554, 11);
            this.lbl_fecha_doc.Name = "lbl_fecha_doc";
            this.lbl_fecha_doc.Size = new System.Drawing.Size(180, 24);
            this.lbl_fecha_doc.TabIndex = 18;
            this.lbl_fecha_doc.Text = "Fecha documento";
            // 
            // lbl_tipo_doc
            // 
            this.lbl_tipo_doc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_tipo_doc.AutoSize = true;
            this.lbl_tipo_doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo_doc.ForeColor = System.Drawing.Color.Gold;
            this.lbl_tipo_doc.Location = new System.Drawing.Point(36, 11);
            this.lbl_tipo_doc.Name = "lbl_tipo_doc";
            this.lbl_tipo_doc.Size = new System.Drawing.Size(193, 24);
            this.lbl_tipo_doc.TabIndex = 16;
            this.lbl_tipo_doc.Text = "Tipo de documento";
            // 
            // cbo_tipo_documento
            // 
            this.cbo_tipo_documento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbo_tipo_documento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_tipo_documento.BorderColor = System.Drawing.Color.Orange;
            this.cbo_tipo_documento.BorderSize = 2;
            this.cbo_tipo_documento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbo_tipo_documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbo_tipo_documento.ForeColor = System.Drawing.Color.DimGray;
            this.cbo_tipo_documento.IconColor = System.Drawing.Color.Orange;
            this.cbo_tipo_documento.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbo_tipo_documento.ListTextColor = System.Drawing.Color.DimGray;
            this.cbo_tipo_documento.Location = new System.Drawing.Point(268, 8);
            this.cbo_tipo_documento.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbo_tipo_documento.Name = "cbo_tipo_documento";
            this.cbo_tipo_documento.Padding = new System.Windows.Forms.Padding(2);
            this.cbo_tipo_documento.Size = new System.Drawing.Size(239, 30);
            this.cbo_tipo_documento.TabIndex = 22;
            this.cbo_tipo_documento.Texts = "";
            // 
            // date_fecha_doc
            // 
            this.date_fecha_doc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date_fecha_doc.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.date_fecha_doc.BorderSize = 0;
            this.date_fecha_doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.date_fecha_doc.Location = new System.Drawing.Point(740, 5);
            this.date_fecha_doc.MinimumSize = new System.Drawing.Size(4, 35);
            this.date_fecha_doc.Name = "date_fecha_doc";
            this.date_fecha_doc.Size = new System.Drawing.Size(241, 35);
            this.date_fecha_doc.SkinColor = System.Drawing.Color.Orange;
            this.date_fecha_doc.TabIndex = 23;
            this.date_fecha_doc.TextColor = System.Drawing.Color.White;
            // 
            // tlpanel_primera
            // 
            this.tlpanel_primera.ColumnCount = 6;
            this.tlpanel_primera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.03024F));
            this.tlpanel_primera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.99784F));
            this.tlpanel_primera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.59827F));
            this.tlpanel_primera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.01512F));
            this.tlpanel_primera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.159827F));
            this.tlpanel_primera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.19871F));
            this.tlpanel_primera.Controls.Add(this.txt_descripcion_proveedor, 0, 0);
            this.tlpanel_primera.Controls.Add(this.rjTextBox2, 5, 0);
            this.tlpanel_primera.Controls.Add(this.lbl_guion, 4, 0);
            this.tlpanel_primera.Controls.Add(this.txt_numero_documento, 3, 0);
            this.tlpanel_primera.Controls.Add(this.lbl_nro_doc, 2, 0);
            this.tlpanel_primera.Controls.Add(this.lbl_proveedor, 0, 0);
            this.tlpanel_primera.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpanel_primera.Location = new System.Drawing.Point(0, 0);
            this.tlpanel_primera.Margin = new System.Windows.Forms.Padding(0);
            this.tlpanel_primera.Name = "tlpanel_primera";
            this.tlpanel_primera.RowCount = 1;
            this.tlpanel_primera.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpanel_primera.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpanel_primera.Size = new System.Drawing.Size(984, 46);
            this.tlpanel_primera.TabIndex = 17;
            // 
            // txt_descripcion_proveedor
            // 
            this.txt_descripcion_proveedor.Location = new System.Drawing.Point(219, 3);
            this.txt_descripcion_proveedor.Name = "txt_descripcion_proveedor";
            this.txt_descripcion_proveedor.Size = new System.Drawing.Size(250, 20);
            this.txt_descripcion_proveedor.TabIndex = 32;
            this.txt_descripcion_proveedor.Click += new System.EventHandler(this.txt_descripcion_proveedor_Click);
            // 
            // rjTextBox2
            // 
            this.rjTextBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rjTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox2.BorderColor = System.Drawing.Color.Orange;
            this.rjTextBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox2.BorderRadius = 0;
            this.rjTextBox2.BorderSize = 2;
            this.rjTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.rjTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox2.Location = new System.Drawing.Point(826, 7);
            this.rjTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox2.Multiline = false;
            this.rjTextBox2.Name = "rjTextBox2";
            this.rjTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox2.PasswordChar = false;
            this.rjTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox2.PlaceholderText = "";
            this.rjTextBox2.Size = new System.Drawing.Size(143, 31);
            this.rjTextBox2.TabIndex = 21;
            this.rjTextBox2.Texts = "";
            this.rjTextBox2.UnderlinedStyle = false;
            // 
            // lbl_guion
            // 
            this.lbl_guion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_guion.AutoSize = true;
            this.lbl_guion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_guion.ForeColor = System.Drawing.Color.Gold;
            this.lbl_guion.Location = new System.Drawing.Point(804, 11);
            this.lbl_guion.Name = "lbl_guion";
            this.lbl_guion.Size = new System.Drawing.Size(15, 24);
            this.lbl_guion.TabIndex = 20;
            this.lbl_guion.Text = "-";
            // 
            // txt_numero_documento
            // 
            this.txt_numero_documento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_numero_documento.BackColor = System.Drawing.SystemColors.Window;
            this.txt_numero_documento.BorderColor = System.Drawing.Color.Orange;
            this.txt_numero_documento.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_numero_documento.BorderRadius = 0;
            this.txt_numero_documento.BorderSize = 2;
            this.txt_numero_documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_numero_documento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_numero_documento.Location = new System.Drawing.Point(697, 7);
            this.txt_numero_documento.Margin = new System.Windows.Forms.Padding(4);
            this.txt_numero_documento.Multiline = false;
            this.txt_numero_documento.Name = "txt_numero_documento";
            this.txt_numero_documento.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_numero_documento.PasswordChar = false;
            this.txt_numero_documento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_numero_documento.PlaceholderText = "";
            this.txt_numero_documento.Size = new System.Drawing.Size(99, 31);
            this.txt_numero_documento.TabIndex = 19;
            this.txt_numero_documento.Texts = "";
            this.txt_numero_documento.UnderlinedStyle = false;
            // 
            // lbl_nro_doc
            // 
            this.lbl_nro_doc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_nro_doc.AutoSize = true;
            this.lbl_nro_doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nro_doc.ForeColor = System.Drawing.Color.Gold;
            this.lbl_nro_doc.Location = new System.Drawing.Point(499, 11);
            this.lbl_nro_doc.Name = "lbl_nro_doc";
            this.lbl_nro_doc.Size = new System.Drawing.Size(191, 24);
            this.lbl_nro_doc.TabIndex = 18;
            this.lbl_nro_doc.Text = "Nro. de documento";
            // 
            // lbl_proveedor
            // 
            this.lbl_proveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_proveedor.AutoSize = true;
            this.lbl_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_proveedor.ForeColor = System.Drawing.Color.Gold;
            this.lbl_proveedor.Location = new System.Drawing.Point(54, 11);
            this.lbl_proveedor.Name = "lbl_proveedor";
            this.lbl_proveedor.Size = new System.Drawing.Size(107, 24);
            this.lbl_proveedor.TabIndex = 16;
            this.lbl_proveedor.Text = "Proveedor";
            // 
            // id_producto
            // 
            this.id_producto.HeaderText = "ID Producto";
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            this.id_producto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_producto.Visible = false;
            // 
            // codigo_barras
            // 
            this.codigo_barras.HeaderText = "Cod. de barras";
            this.codigo_barras.Name = "codigo_barras";
            this.codigo_barras.ReadOnly = true;
            // 
            // descripcion_producto
            // 
            this.descripcion_producto.HeaderText = "Descripción";
            this.descripcion_producto.Name = "descripcion_producto";
            this.descripcion_producto.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // precio_costo
            // 
            this.precio_costo.HeaderText = "Precio Unit.";
            this.precio_costo.Name = "precio_costo";
            this.precio_costo.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // btn_editar
            // 
            this.btn_editar.HeaderText = "";
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.ReadOnly = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.HeaderText = "";
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.ReadOnly = true;
            this.btn_eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // formCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 537);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "formCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formPurchaseOrders";
            this.Load += new System.EventHandler(this.formCompras_Load);
            this.panel_main.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_cantidad)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_compras)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tlpanel_3.ResumeLayout(false);
            this.tlpanel_3.PerformLayout();
            this.tlpanel_2.ResumeLayout(false);
            this.tlpanel_2.PerformLayout();
            this.tlpanel_primera.ResumeLayout(false);
            this.tlpanel_primera.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_precio_costo;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Label lbl_descripcion_producto;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgv_compras;
        private System.Windows.Forms.Panel panel2;
        private CustomBox.RJControls.RJButton btn_cerrar;
        private CustomBox.RJControls.RJButton btn_guardar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tlpanel_3;
        private System.Windows.Forms.TableLayoutPanel tlpanel_2;
        private System.Windows.Forms.Label lbl_fecha_doc;
        private System.Windows.Forms.Label lbl_tipo_doc;
        private CustomBox.RJControls.RJComboBox cbo_tipo_documento;
        private CustomBox.RJControls.RJDatePicker date_fecha_doc;
        private System.Windows.Forms.TableLayoutPanel tlpanel_primera;
        private CustomBox.RJControls.RJTextBox rjTextBox2;
        private System.Windows.Forms.Label lbl_guion;
        private CustomBox.RJControls.RJTextBox txt_numero_documento;
        private System.Windows.Forms.Label lbl_nro_doc;
        private System.Windows.Forms.Label lbl_proveedor;
        private System.Windows.Forms.Label lbl_suma_total;
        private CustomBox.RJControls.RJButton btn_agregar_producto;
        private System.Windows.Forms.Label lbl_codigo_barras;
        private RJCodeAdvance.RJControls.RJTextBox txt_cuit_proveedor;
        private System.Windows.Forms.TextBox txt_descripcion_producto;
        private System.Windows.Forms.TextBox txt_descripcion_proveedor;
        private CustomBox.RJControls.RJButton btn_buscar_producto;
        private System.Windows.Forms.ListBox lbox_productos;
        private System.Windows.Forms.NumericUpDown num_cantidad;
        private System.Windows.Forms.TextBox txt_precio_costo;
        private System.Windows.Forms.TextBox txt_codigo_barras;
        private System.Windows.Forms.TextBox txt_id_producto;
        private System.Windows.Forms.TextBox txt_id_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_barras;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn btn_editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn btn_eliminar;
    }
}