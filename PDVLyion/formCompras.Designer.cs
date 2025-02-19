﻿namespace POSLyion
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_izq = new System.Windows.Forms.Panel();
            this.lbox_productos = new System.Windows.Forms.ListBox();
            this.txt_precio_costo = new System.Windows.Forms.TextBox();
            this.txt_codigo_barras = new System.Windows.Forms.TextBox();
            this.num_cantidad = new System.Windows.Forms.NumericUpDown();
            this.btn_buscar_producto = new CustomBox.RJControls.RJButton();
            this.txt_descripcion_producto = new System.Windows.Forms.TextBox();
            this.lbl_codigo_barras = new System.Windows.Forms.Label();
            this.btn_agregar_producto = new CustomBox.RJControls.RJButton();
            this.lbl_precio_costo = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.lbl_descripcion_producto = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_compras = new System.Windows.Forms.DataGridView();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_barras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_editar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_eliminar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_suma_total = new System.Windows.Forms.Label();
            this.btn_cerrar = new CustomBox.RJControls.RJButton();
            this.btn_guardar = new CustomBox.RJControls.RJButton();
            this.tlpanel_3 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_id_producto = new System.Windows.Forms.TextBox();
            this.txt_cuit_proveedor = new RJCodeAdvance.RJControls.RJTextBox();
            this.tlpanel_2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_fecha_doc = new System.Windows.Forms.Label();
            this.lbl_tipo_doc = new System.Windows.Forms.Label();
            this.cbo_tipo_documento = new CustomBox.RJControls.RJComboBox();
            this.date_fecha_doc = new CustomBox.RJControls.RJDatePicker();
            this.tlpanel_primera = new System.Windows.Forms.TableLayoutPanel();
            this.cbox_proveedores = new CustomBox.RJControls.RJComboBox();
            this.txt_numero_documento = new CustomBox.RJControls.RJTextBox();
            this.lbl_proveedor = new System.Windows.Forms.Label();
            this.lbl_nro_doc = new System.Windows.Forms.Label();
            this.oracleCommandBuilder1 = new System.Data.OracleClient.OracleCommandBuilder();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_main.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_izq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_cantidad)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_compras)).BeginInit();
            this.panel_bottom.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tlpanel_3.SuspendLayout();
            this.tlpanel_2.SuspendLayout();
            this.tlpanel_primera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
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
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.panel_izq);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel_bottom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 399);
            this.panel1.TabIndex = 20;
            // 
            // panel_izq
            // 
            this.panel_izq.BackColor = System.Drawing.Color.DarkOrange;
            this.panel_izq.Controls.Add(this.lbox_productos);
            this.panel_izq.Controls.Add(this.txt_precio_costo);
            this.panel_izq.Controls.Add(this.txt_codigo_barras);
            this.panel_izq.Controls.Add(this.num_cantidad);
            this.panel_izq.Controls.Add(this.btn_buscar_producto);
            this.panel_izq.Controls.Add(this.txt_descripcion_producto);
            this.panel_izq.Controls.Add(this.lbl_codigo_barras);
            this.panel_izq.Controls.Add(this.btn_agregar_producto);
            this.panel_izq.Controls.Add(this.lbl_precio_costo);
            this.panel_izq.Controls.Add(this.lbl_cantidad);
            this.panel_izq.Controls.Add(this.lbl_descripcion_producto);
            this.panel_izq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_izq.Location = new System.Drawing.Point(0, 0);
            this.panel_izq.Margin = new System.Windows.Forms.Padding(5);
            this.panel_izq.Name = "panel_izq";
            this.panel_izq.Size = new System.Drawing.Size(390, 338);
            this.panel_izq.TabIndex = 2;
            // 
            // lbox_productos
            // 
            this.lbox_productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbox_productos.FormattingEnabled = true;
            this.lbox_productos.ItemHeight = 24;
            this.lbox_productos.Location = new System.Drawing.Point(130, 162);
            this.lbox_productos.Name = "lbox_productos";
            this.lbox_productos.Size = new System.Drawing.Size(265, 76);
            this.lbox_productos.TabIndex = 38;
            this.lbox_productos.Visible = false;
            this.lbox_productos.Click += new System.EventHandler(this.lbox_productos_Click);
            this.lbox_productos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbox_productos_KeyPress);
            // 
            // txt_precio_costo
            // 
            this.txt_precio_costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio_costo.Location = new System.Drawing.Point(130, 270);
            this.txt_precio_costo.Name = "txt_precio_costo";
            this.txt_precio_costo.Size = new System.Drawing.Size(232, 29);
            this.txt_precio_costo.TabIndex = 4;
            this.txt_precio_costo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_costo_KeyPress);
            // 
            // txt_codigo_barras
            // 
            this.txt_codigo_barras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_barras.Location = new System.Drawing.Point(16, 65);
            this.txt_codigo_barras.Name = "txt_codigo_barras";
            this.txt_codigo_barras.Size = new System.Drawing.Size(346, 29);
            this.txt_codigo_barras.TabIndex = 1;
            this.txt_codigo_barras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_codigo_barras_KeyDown);
            // 
            // num_cantidad
            // 
            this.num_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_cantidad.Location = new System.Drawing.Point(130, 202);
            this.num_cantidad.Name = "num_cantidad";
            this.num_cantidad.Size = new System.Drawing.Size(232, 29);
            this.num_cantidad.TabIndex = 3;
            // 
            // btn_buscar_producto
            // 
            this.btn_buscar_producto.BackColor = System.Drawing.Color.Gold;
            this.btn_buscar_producto.BackgroundColor = System.Drawing.Color.Gold;
            this.btn_buscar_producto.BorderColor = System.Drawing.Color.DarkRed;
            this.btn_buscar_producto.BorderRadius = 10;
            this.btn_buscar_producto.BorderSize = 2;
            this.btn_buscar_producto.FlatAppearance.BorderSize = 0;
            this.btn_buscar_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_producto.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_buscar_producto.Location = new System.Drawing.Point(192, 10);
            this.btn_buscar_producto.Name = "btn_buscar_producto";
            this.btn_buscar_producto.Size = new System.Drawing.Size(170, 46);
            this.btn_buscar_producto.TabIndex = 32;
            this.btn_buscar_producto.Text = "Buscar producto";
            this.btn_buscar_producto.TextColor = System.Drawing.Color.DarkRed;
            this.btn_buscar_producto.UseVisualStyleBackColor = false;
            this.btn_buscar_producto.Click += new System.EventHandler(this.btn_buscar_producto_Click);
            // 
            // txt_descripcion_producto
            // 
            this.txt_descripcion_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion_producto.Location = new System.Drawing.Point(130, 134);
            this.txt_descripcion_producto.Name = "txt_descripcion_producto";
            this.txt_descripcion_producto.Size = new System.Drawing.Size(232, 29);
            this.txt_descripcion_producto.TabIndex = 2;
            this.txt_descripcion_producto.TextChanged += new System.EventHandler(this.txt_descripcion_producto_TextChanged);
            this.txt_descripcion_producto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_descripcion_producto_KeyDown);
            // 
            // lbl_codigo_barras
            // 
            this.lbl_codigo_barras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_codigo_barras.AutoSize = true;
            this.lbl_codigo_barras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo_barras.ForeColor = System.Drawing.Color.Wheat;
            this.lbl_codigo_barras.Location = new System.Drawing.Point(15, 20);
            this.lbl_codigo_barras.Name = "lbl_codigo_barras";
            this.lbl_codigo_barras.Size = new System.Drawing.Size(171, 24);
            this.lbl_codigo_barras.TabIndex = 29;
            this.lbl_codigo_barras.Text = "Codigo de barras";
            // 
            // btn_agregar_producto
            // 
            this.btn_agregar_producto.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_agregar_producto.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.btn_agregar_producto.BorderColor = System.Drawing.Color.OrangeRed;
            this.btn_agregar_producto.BorderRadius = 10;
            this.btn_agregar_producto.BorderSize = 3;
            this.btn_agregar_producto.FlatAppearance.BorderSize = 0;
            this.btn_agregar_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_producto.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_agregar_producto.Location = new System.Drawing.Point(250, 300);
            this.btn_agregar_producto.Name = "btn_agregar_producto";
            this.btn_agregar_producto.Size = new System.Drawing.Size(137, 37);
            this.btn_agregar_producto.TabIndex = 5;
            this.btn_agregar_producto.Text = "Agregar";
            this.btn_agregar_producto.TextColor = System.Drawing.Color.OrangeRed;
            this.btn_agregar_producto.UseVisualStyleBackColor = false;
            this.btn_agregar_producto.Click += new System.EventHandler(this.btn_agregar_producto_Click);
            // 
            // lbl_precio_costo
            // 
            this.lbl_precio_costo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_precio_costo.AutoSize = true;
            this.lbl_precio_costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio_costo.ForeColor = System.Drawing.Color.Wheat;
            this.lbl_precio_costo.Location = new System.Drawing.Point(9, 270);
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
            this.lbl_cantidad.ForeColor = System.Drawing.Color.Wheat;
            this.lbl_cantidad.Location = new System.Drawing.Point(12, 202);
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
            this.lbl_descripcion_producto.ForeColor = System.Drawing.Color.Wheat;
            this.lbl_descripcion_producto.Location = new System.Drawing.Point(15, 134);
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
            this.panel4.Size = new System.Drawing.Size(594, 338);
            this.panel4.TabIndex = 1;
            // 
            // dgv_compras
            // 
            this.dgv_compras.AllowUserToAddRows = false;
            this.dgv_compras.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_compras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_compras.BackgroundColor = System.Drawing.Color.White;
            this.dgv_compras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_compras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_compras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_compras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_compras.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_compras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_compras.EnableHeadersVisualStyles = false;
            this.dgv_compras.GridColor = System.Drawing.Color.Orange;
            this.dgv_compras.Location = new System.Drawing.Point(0, 0);
            this.dgv_compras.Margin = new System.Windows.Forms.Padding(5);
            this.dgv_compras.Name = "dgv_compras";
            this.dgv_compras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_compras.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_compras.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_compras.Size = new System.Drawing.Size(594, 338);
            this.dgv_compras.TabIndex = 0;
            this.dgv_compras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_compras_CellContentClick);
            // 
            // id_producto
            // 
            this.id_producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_producto.HeaderText = "ID Producto";
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            this.id_producto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_producto.Visible = false;
            // 
            // codigo_barras
            // 
            this.codigo_barras.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codigo_barras.FillWeight = 200F;
            this.codigo_barras.HeaderText = "Cod. de barras";
            this.codigo_barras.Name = "codigo_barras";
            this.codigo_barras.ReadOnly = true;
            // 
            // descripcion_producto
            // 
            this.descripcion_producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcion_producto.FillWeight = 250F;
            this.descripcion_producto.HeaderText = "Descripción";
            this.descripcion_producto.Name = "descripcion_producto";
            this.descripcion_producto.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cantidad.FillWeight = 150F;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // precio_costo
            // 
            this.precio_costo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.precio_costo.FillWeight = 200F;
            this.precio_costo.HeaderText = "Precio Unit.";
            this.precio_costo.Name = "precio_costo";
            this.precio_costo.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subtotal.FillWeight = 150F;
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // btn_editar
            // 
            this.btn_editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btn_editar.HeaderText = "";
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.ReadOnly = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btn_eliminar.HeaderText = "";
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.ReadOnly = true;
            this.btn_eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // panel_bottom
            // 
            this.panel_bottom.BackColor = System.Drawing.Color.White;
            this.panel_bottom.Controls.Add(this.flowLayoutPanel1);
            this.panel_bottom.Controls.Add(this.btn_cerrar);
            this.panel_bottom.Controls.Add(this.btn_guardar);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 338);
            this.panel_bottom.Margin = new System.Windows.Forms.Padding(5);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(984, 61);
            this.panel_bottom.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.OrangeRed;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 8);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(363, 46);
            this.flowLayoutPanel1.TabIndex = 28;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Controls.Add(this.label10);
            this.flowLayoutPanel2.Controls.Add(this.lbl_suma_total);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(356, 39);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.OrangeRed;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 39);
            this.label10.TabIndex = 22;
            this.label10.Text = "Total: $";
            // 
            // lbl_suma_total
            // 
            this.lbl_suma_total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_suma_total.AutoSize = true;
            this.lbl_suma_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_suma_total.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_suma_total.Location = new System.Drawing.Point(149, 2);
            this.lbl_suma_total.Name = "lbl_suma_total";
            this.lbl_suma_total.Size = new System.Drawing.Size(84, 37);
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
            this.btn_cerrar.Location = new System.Drawing.Point(835, 8);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(137, 37);
            this.btn_cerrar.TabIndex = 7;
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
            this.btn_guardar.Location = new System.Drawing.Point(689, 8);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(137, 37);
            this.btn_guardar.TabIndex = 6;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextColor = System.Drawing.Color.Lime;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // tlpanel_3
            // 
            this.tlpanel_3.BackColor = System.Drawing.Color.White;
            this.tlpanel_3.ColumnCount = 5;
            this.tlpanel_3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.81119F));
            this.tlpanel_3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.715F));
            this.tlpanel_3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.958043F));
            this.tlpanel_3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.715F));
            this.tlpanel_3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.80076F));
            this.tlpanel_3.Controls.Add(this.txt_id_producto, 2, 0);
            this.tlpanel_3.Controls.Add(this.txt_cuit_proveedor, 1, 0);
            this.tlpanel_3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpanel_3.Location = new System.Drawing.Point(0, 92);
            this.tlpanel_3.Margin = new System.Windows.Forms.Padding(0);
            this.tlpanel_3.Name = "tlpanel_3";
            this.tlpanel_3.RowCount = 1;
            this.tlpanel_3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpanel_3.Size = new System.Drawing.Size(984, 46);
            this.tlpanel_3.TabIndex = 19;
            // 
            // txt_id_producto
            // 
            this.txt_id_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_producto.Location = new System.Drawing.Point(469, 3);
            this.txt_id_producto.Name = "txt_id_producto";
            this.txt_id_producto.Size = new System.Drawing.Size(52, 29);
            this.txt_id_producto.TabIndex = 39;
            this.txt_id_producto.Visible = false;
            // 
            // txt_cuit_proveedor
            // 
            this.txt_cuit_proveedor.BackColor = System.Drawing.SystemColors.Window;
            this.txt_cuit_proveedor.BorderColor = System.Drawing.Color.DarkOrange;
            this.txt_cuit_proveedor.BorderFocusColor = System.Drawing.Color.DarkOrange;
            this.txt_cuit_proveedor.BorderRadius = 0;
            this.txt_cuit_proveedor.BorderSize = 2;
            this.txt_cuit_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cuit_proveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_cuit_proveedor.Location = new System.Drawing.Point(267, 4);
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
            this.txt_cuit_proveedor.Visible = false;
            // 
            // tlpanel_2
            // 
            this.tlpanel_2.BackColor = System.Drawing.Color.White;
            this.tlpanel_2.ColumnCount = 4;
            this.tlpanel_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99752F));
            this.tlpanel_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00248F));
            this.tlpanel_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99752F));
            this.tlpanel_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00248F));
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
            this.tlpanel_2.Size = new System.Drawing.Size(984, 46);
            this.tlpanel_2.TabIndex = 18;
            // 
            // lbl_fecha_doc
            // 
            this.lbl_fecha_doc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_fecha_doc.AutoSize = true;
            this.lbl_fecha_doc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fecha_doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_doc.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_fecha_doc.Location = new System.Drawing.Point(576, 11);
            this.lbl_fecha_doc.Name = "lbl_fecha_doc";
            this.lbl_fecha_doc.Size = new System.Drawing.Size(157, 24);
            this.lbl_fecha_doc.TabIndex = 18;
            this.lbl_fecha_doc.Text = "Fecha de carga";
            // 
            // lbl_tipo_doc
            // 
            this.lbl_tipo_doc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_tipo_doc.AutoSize = true;
            this.lbl_tipo_doc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tipo_doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo_doc.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_tipo_doc.Location = new System.Drawing.Point(43, 11);
            this.lbl_tipo_doc.Name = "lbl_tipo_doc";
            this.lbl_tipo_doc.Size = new System.Drawing.Size(158, 24);
            this.lbl_tipo_doc.TabIndex = 16;
            this.lbl_tipo_doc.Text = "Tipo de Factura";
            // 
            // cbo_tipo_documento
            // 
            this.cbo_tipo_documento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbo_tipo_documento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_tipo_documento.BorderColor = System.Drawing.Color.DarkOrange;
            this.cbo_tipo_documento.BorderSize = 2;
            this.cbo_tipo_documento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbo_tipo_documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.cbo_tipo_documento.ForeColor = System.Drawing.Color.DimGray;
            this.cbo_tipo_documento.IconColor = System.Drawing.Color.OrangeRed;
            this.cbo_tipo_documento.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbo_tipo_documento.ListTextColor = System.Drawing.Color.DimGray;
            this.cbo_tipo_documento.Location = new System.Drawing.Point(248, 7);
            this.cbo_tipo_documento.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbo_tipo_documento.Name = "cbo_tipo_documento";
            this.cbo_tipo_documento.Padding = new System.Windows.Forms.Padding(2);
            this.cbo_tipo_documento.Size = new System.Drawing.Size(239, 32);
            this.cbo_tipo_documento.TabIndex = 22;
            this.cbo_tipo_documento.Texts = "";
            // 
            // date_fecha_doc
            // 
            this.date_fecha_doc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date_fecha_doc.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.date_fecha_doc.BorderSize = 0;
            this.date_fecha_doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.date_fecha_doc.Location = new System.Drawing.Point(739, 5);
            this.date_fecha_doc.MinimumSize = new System.Drawing.Size(4, 35);
            this.date_fecha_doc.Name = "date_fecha_doc";
            this.date_fecha_doc.Size = new System.Drawing.Size(241, 35);
            this.date_fecha_doc.SkinColor = System.Drawing.Color.DarkOrange;
            this.date_fecha_doc.TabIndex = 23;
            this.date_fecha_doc.TextColor = System.Drawing.Color.Black;
            // 
            // tlpanel_primera
            // 
            this.tlpanel_primera.BackColor = System.Drawing.Color.White;
            this.tlpanel_primera.ColumnCount = 4;
            this.tlpanel_primera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpanel_primera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpanel_primera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpanel_primera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpanel_primera.Controls.Add(this.cbox_proveedores, 0, 0);
            this.tlpanel_primera.Controls.Add(this.txt_numero_documento, 3, 0);
            this.tlpanel_primera.Controls.Add(this.lbl_proveedor, 0, 0);
            this.tlpanel_primera.Controls.Add(this.lbl_nro_doc, 2, 0);
            this.tlpanel_primera.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpanel_primera.Location = new System.Drawing.Point(0, 0);
            this.tlpanel_primera.Margin = new System.Windows.Forms.Padding(0);
            this.tlpanel_primera.Name = "tlpanel_primera";
            this.tlpanel_primera.RowCount = 1;
            this.tlpanel_primera.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpanel_primera.Size = new System.Drawing.Size(984, 46);
            this.tlpanel_primera.TabIndex = 17;
            // 
            // cbox_proveedores
            // 
            this.cbox_proveedores.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbox_proveedores.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbox_proveedores.BorderColor = System.Drawing.Color.DarkOrange;
            this.cbox_proveedores.BorderSize = 2;
            this.cbox_proveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbox_proveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.cbox_proveedores.ForeColor = System.Drawing.Color.DimGray;
            this.cbox_proveedores.IconColor = System.Drawing.Color.OrangeRed;
            this.cbox_proveedores.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbox_proveedores.ListTextColor = System.Drawing.Color.DimGray;
            this.cbox_proveedores.Location = new System.Drawing.Point(249, 7);
            this.cbox_proveedores.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbox_proveedores.Name = "cbox_proveedores";
            this.cbox_proveedores.Padding = new System.Windows.Forms.Padding(2);
            this.cbox_proveedores.Size = new System.Drawing.Size(239, 32);
            this.cbox_proveedores.TabIndex = 23;
            this.cbox_proveedores.Texts = "";
            // 
            // txt_numero_documento
            // 
            this.txt_numero_documento.BackColor = System.Drawing.SystemColors.Window;
            this.txt_numero_documento.BorderColor = System.Drawing.Color.DarkOrange;
            this.txt_numero_documento.BorderFocusColor = System.Drawing.Color.OrangeRed;
            this.txt_numero_documento.BorderRadius = 0;
            this.txt_numero_documento.BorderSize = 2;
            this.txt_numero_documento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_numero_documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.txt_numero_documento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_numero_documento.Location = new System.Drawing.Point(742, 4);
            this.txt_numero_documento.Margin = new System.Windows.Forms.Padding(4);
            this.txt_numero_documento.Multiline = false;
            this.txt_numero_documento.Name = "txt_numero_documento";
            this.txt_numero_documento.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_numero_documento.PasswordChar = false;
            this.txt_numero_documento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_numero_documento.PlaceholderText = "";
            this.txt_numero_documento.Size = new System.Drawing.Size(238, 39);
            this.txt_numero_documento.TabIndex = 19;
            this.txt_numero_documento.Texts = "";
            this.txt_numero_documento.UnderlinedStyle = false;
            // 
            // lbl_proveedor
            // 
            this.lbl_proveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_proveedor.AutoSize = true;
            this.lbl_proveedor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_proveedor.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_proveedor.Location = new System.Drawing.Point(69, 11);
            this.lbl_proveedor.Name = "lbl_proveedor";
            this.lbl_proveedor.Size = new System.Drawing.Size(107, 24);
            this.lbl_proveedor.TabIndex = 16;
            this.lbl_proveedor.Text = "Proveedor";
            // 
            // lbl_nro_doc
            // 
            this.lbl_nro_doc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_nro_doc.AutoSize = true;
            this.lbl_nro_doc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nro_doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nro_doc.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_nro_doc.Location = new System.Drawing.Point(579, 11);
            this.lbl_nro_doc.Name = "lbl_nro_doc";
            this.lbl_nro_doc.Size = new System.Drawing.Size(156, 24);
            this.lbl_nro_doc.TabIndex = 18;
            this.lbl_nro_doc.Text = "Nro. de Factura";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
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
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.formCompras_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formCompras_KeyDown);
            this.panel_main.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel_izq.ResumeLayout(false);
            this.panel_izq.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_cantidad)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_compras)).EndInit();
            this.panel_bottom.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tlpanel_3.ResumeLayout(false);
            this.tlpanel_3.PerformLayout();
            this.tlpanel_2.ResumeLayout(false);
            this.tlpanel_2.PerformLayout();
            this.tlpanel_primera.ResumeLayout(false);
            this.tlpanel_primera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_izq;
        private System.Windows.Forms.Label lbl_precio_costo;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Label lbl_descripcion_producto;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgv_compras;
        private System.Windows.Forms.Panel panel_bottom;
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
        private CustomBox.RJControls.RJTextBox txt_numero_documento;
        private System.Windows.Forms.Label lbl_nro_doc;
        private System.Windows.Forms.Label lbl_proveedor;
        private System.Windows.Forms.Label lbl_suma_total;
        private CustomBox.RJControls.RJButton btn_agregar_producto;
        private System.Windows.Forms.Label lbl_codigo_barras;
        private System.Windows.Forms.TextBox txt_descripcion_producto;
        private CustomBox.RJControls.RJButton btn_buscar_producto;
        private System.Windows.Forms.NumericUpDown num_cantidad;
        private System.Windows.Forms.TextBox txt_precio_costo;
        private System.Windows.Forms.TextBox txt_codigo_barras;
        private RJCodeAdvance.RJControls.RJTextBox txt_cuit_proveedor;
        private System.Windows.Forms.ListBox lbox_productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_barras;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn btn_editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn btn_eliminar;
        private System.Windows.Forms.TextBox txt_id_producto;
        private CustomBox.RJControls.RJComboBox cbox_proveedores;
        private System.Data.OracleClient.OracleCommandBuilder oracleCommandBuilder1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}