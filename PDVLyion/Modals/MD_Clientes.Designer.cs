namespace POSLyion.Modals
{
    partial class MD_Clientes
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
            this.tlp_principal = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_menu = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_infocliente = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.tlp_deuda = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_deuda_monto = new System.Windows.Forms.Label();
            this.lbl_deuda = new System.Windows.Forms.Label();
            this.tlp_botones = new System.Windows.Forms.TableLayoutPanel();
            this.btn_abonar = new System.Windows.Forms.Button();
            this.btn_liquidar_deuda = new System.Windows.Forms.Button();
            this.tlp_tickets = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.codigo_barras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_ventas = new System.Windows.Forms.DataGridView();
            this.id_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlp_principal.SuspendLayout();
            this.tlp_menu.SuspendLayout();
            this.tlp_infocliente.SuspendLayout();
            this.tlp_deuda.SuspendLayout();
            this.tlp_botones.SuspendLayout();
            this.tlp_tickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_principal
            // 
            this.tlp_principal.ColumnCount = 1;
            this.tlp_principal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_principal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_principal.Controls.Add(this.tlp_menu, 0, 0);
            this.tlp_principal.Controls.Add(this.tlp_tickets, 0, 1);
            this.tlp_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_principal.Location = new System.Drawing.Point(0, 0);
            this.tlp_principal.Name = "tlp_principal";
            this.tlp_principal.RowCount = 2;
            this.tlp_principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlp_principal.Size = new System.Drawing.Size(644, 454);
            this.tlp_principal.TabIndex = 0;
            // 
            // tlp_menu
            // 
            this.tlp_menu.ColumnCount = 1;
            this.tlp_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_menu.Controls.Add(this.tlp_infocliente, 0, 0);
            this.tlp_menu.Controls.Add(this.tlp_botones, 0, 1);
            this.tlp_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_menu.Location = new System.Drawing.Point(3, 3);
            this.tlp_menu.Name = "tlp_menu";
            this.tlp_menu.RowCount = 2;
            this.tlp_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_menu.Size = new System.Drawing.Size(638, 84);
            this.tlp_menu.TabIndex = 0;
            // 
            // tlp_infocliente
            // 
            this.tlp_infocliente.ColumnCount = 2;
            this.tlp_infocliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_infocliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_infocliente.Controls.Add(this.lbl_cliente, 0, 0);
            this.tlp_infocliente.Controls.Add(this.tlp_deuda, 1, 0);
            this.tlp_infocliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_infocliente.Location = new System.Drawing.Point(3, 3);
            this.tlp_infocliente.Name = "tlp_infocliente";
            this.tlp_infocliente.RowCount = 1;
            this.tlp_infocliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_infocliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_infocliente.Size = new System.Drawing.Size(632, 36);
            this.tlp_infocliente.TabIndex = 0;
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cliente.Location = new System.Drawing.Point(3, 0);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(310, 36);
            this.lbl_cliente.TabIndex = 0;
            this.lbl_cliente.Text = "Cliente";
            this.lbl_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlp_deuda
            // 
            this.tlp_deuda.ColumnCount = 2;
            this.tlp_deuda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_deuda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_deuda.Controls.Add(this.lbl_deuda_monto, 0, 0);
            this.tlp_deuda.Controls.Add(this.lbl_deuda, 0, 0);
            this.tlp_deuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_deuda.Location = new System.Drawing.Point(319, 3);
            this.tlp_deuda.Name = "tlp_deuda";
            this.tlp_deuda.RowCount = 1;
            this.tlp_deuda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_deuda.Size = new System.Drawing.Size(310, 30);
            this.tlp_deuda.TabIndex = 1;
            // 
            // lbl_deuda_monto
            // 
            this.lbl_deuda_monto.AutoSize = true;
            this.lbl_deuda_monto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_deuda_monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deuda_monto.Location = new System.Drawing.Point(108, 0);
            this.lbl_deuda_monto.Name = "lbl_deuda_monto";
            this.lbl_deuda_monto.Size = new System.Drawing.Size(199, 30);
            this.lbl_deuda_monto.TabIndex = 3;
            this.lbl_deuda_monto.Text = "Deuda";
            this.lbl_deuda_monto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_deuda
            // 
            this.lbl_deuda.AutoSize = true;
            this.lbl_deuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_deuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deuda.Location = new System.Drawing.Point(3, 0);
            this.lbl_deuda.Name = "lbl_deuda";
            this.lbl_deuda.Size = new System.Drawing.Size(99, 30);
            this.lbl_deuda.TabIndex = 2;
            this.lbl_deuda.Text = "Deuda: $";
            this.lbl_deuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlp_botones
            // 
            this.tlp_botones.ColumnCount = 2;
            this.tlp_botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_botones.Controls.Add(this.btn_abonar, 1, 0);
            this.tlp_botones.Controls.Add(this.btn_liquidar_deuda, 0, 0);
            this.tlp_botones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_botones.Location = new System.Drawing.Point(3, 45);
            this.tlp_botones.Name = "tlp_botones";
            this.tlp_botones.RowCount = 1;
            this.tlp_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_botones.Size = new System.Drawing.Size(632, 36);
            this.tlp_botones.TabIndex = 1;
            // 
            // btn_abonar
            // 
            this.btn_abonar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_abonar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_abonar.Location = new System.Drawing.Point(319, 3);
            this.btn_abonar.Name = "btn_abonar";
            this.btn_abonar.Size = new System.Drawing.Size(310, 30);
            this.btn_abonar.TabIndex = 1;
            this.btn_abonar.Text = "Abonar";
            this.btn_abonar.UseVisualStyleBackColor = true;
            this.btn_abonar.Click += new System.EventHandler(this.btn_abonar_Click);
            // 
            // btn_liquidar_deuda
            // 
            this.btn_liquidar_deuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_liquidar_deuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_liquidar_deuda.Location = new System.Drawing.Point(3, 3);
            this.btn_liquidar_deuda.Name = "btn_liquidar_deuda";
            this.btn_liquidar_deuda.Size = new System.Drawing.Size(310, 30);
            this.btn_liquidar_deuda.TabIndex = 0;
            this.btn_liquidar_deuda.Text = "Liquidar adeudo";
            this.btn_liquidar_deuda.UseVisualStyleBackColor = true;
            this.btn_liquidar_deuda.Click += new System.EventHandler(this.btn_liquidar_deuda_Click);
            // 
            // tlp_tickets
            // 
            this.tlp_tickets.ColumnCount = 2;
            this.tlp_tickets.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_tickets.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlp_tickets.Controls.Add(this.dgv_productos, 1, 0);
            this.tlp_tickets.Controls.Add(this.dgv_ventas, 0, 0);
            this.tlp_tickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_tickets.Location = new System.Drawing.Point(3, 93);
            this.tlp_tickets.Name = "tlp_tickets";
            this.tlp_tickets.RowCount = 1;
            this.tlp_tickets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_tickets.Size = new System.Drawing.Size(638, 358);
            this.tlp_tickets.TabIndex = 1;
            // 
            // dgv_productos
            // 
            this.dgv_productos.AllowUserToAddRows = false;
            this.dgv_productos.AllowUserToDeleteRows = false;
            this.dgv_productos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_barras,
            this.descripcion,
            this.precio_venta,
            this.cantidad,
            this.subtotal});
            this.dgv_productos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_productos.Location = new System.Drawing.Point(194, 3);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.ReadOnly = true;
            this.dgv_productos.Size = new System.Drawing.Size(441, 352);
            this.dgv_productos.TabIndex = 1;
            // 
            // codigo_barras
            // 
            this.codigo_barras.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codigo_barras.HeaderText = "Codigo de barras";
            this.codigo_barras.Name = "codigo_barras";
            this.codigo_barras.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Producto";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // precio_venta
            // 
            this.precio_venta.HeaderText = "Precio de venta";
            this.precio_venta.Name = "precio_venta";
            this.precio_venta.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // dgv_ventas
            // 
            this.dgv_ventas.AllowUserToAddRows = false;
            this.dgv_ventas.AllowUserToDeleteRows = false;
            this.dgv_ventas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_venta,
            this.fecha,
            this.total});
            this.dgv_ventas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ventas.Location = new System.Drawing.Point(3, 3);
            this.dgv_ventas.Name = "dgv_ventas";
            this.dgv_ventas.ReadOnly = true;
            this.dgv_ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ventas.Size = new System.Drawing.Size(185, 352);
            this.dgv_ventas.TabIndex = 0;
            this.dgv_ventas.SelectionChanged += new System.EventHandler(this.dgv_ventas_SelectionChanged);
            // 
            // id_venta
            // 
            this.id_venta.HeaderText = "Nro. Venta";
            this.id_venta.Name = "id_venta";
            this.id_venta.ReadOnly = true;
            this.id_venta.Width = 50;
            // 
            // fecha
            // 
            this.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // MD_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 454);
            this.Controls.Add(this.tlp_principal);
            this.Name = "MD_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deuda de cliente";
            this.Load += new System.EventHandler(this.MD_Clientes_Load);
            this.tlp_principal.ResumeLayout(false);
            this.tlp_menu.ResumeLayout(false);
            this.tlp_infocliente.ResumeLayout(false);
            this.tlp_infocliente.PerformLayout();
            this.tlp_deuda.ResumeLayout(false);
            this.tlp_deuda.PerformLayout();
            this.tlp_botones.ResumeLayout(false);
            this.tlp_tickets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ventas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_principal;
        private System.Windows.Forms.TableLayoutPanel tlp_menu;
        private System.Windows.Forms.TableLayoutPanel tlp_infocliente;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.TableLayoutPanel tlp_botones;
        private System.Windows.Forms.Button btn_abonar;
        private System.Windows.Forms.Button btn_liquidar_deuda;
        private System.Windows.Forms.TableLayoutPanel tlp_tickets;
        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.DataGridView dgv_ventas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_barras;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.TableLayoutPanel tlp_deuda;
        private System.Windows.Forms.Label lbl_deuda_monto;
        private System.Windows.Forms.Label lbl_deuda;
    }
}