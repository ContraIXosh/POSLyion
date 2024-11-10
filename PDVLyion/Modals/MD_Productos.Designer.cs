namespace POSLyion.Modals
{
    partial class MD_Productos
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
            this.txt_busqueda = new RJCodeAdvance.RJControls.RJTextBox();
            this.cbo_filtro = new CustomBox.RJControls.RJComboBox();
            this.dgv_modal_productos = new System.Windows.Forms.DataGridView();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo_barras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modal_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.BackColor = System.Drawing.SystemColors.Window;
            this.txt_busqueda.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_busqueda.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_busqueda.BorderRadius = 0;
            this.txt_busqueda.BorderSize = 2;
            this.txt_busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_busqueda.Location = new System.Drawing.Point(228, 3);
            this.txt_busqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txt_busqueda.Multiline = false;
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_busqueda.PasswordChar = false;
            this.txt_busqueda.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_busqueda.PlaceholderText = "";
            this.txt_busqueda.Size = new System.Drawing.Size(303, 31);
            this.txt_busqueda.TabIndex = 5;
            this.txt_busqueda.Texts = "";
            this.txt_busqueda.UnderlinedStyle = false;
            this.txt_busqueda._TextChanged += new System.EventHandler(this.txt_busqueda__TextChanged);
            // 
            // cbo_filtro
            // 
            this.cbo_filtro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_filtro.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbo_filtro.BorderSize = 1;
            this.cbo_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbo_filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbo_filtro.ForeColor = System.Drawing.Color.DimGray;
            this.cbo_filtro.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbo_filtro.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbo_filtro.ListTextColor = System.Drawing.Color.DimGray;
            this.cbo_filtro.Location = new System.Drawing.Point(12, 3);
            this.cbo_filtro.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbo_filtro.Name = "cbo_filtro";
            this.cbo_filtro.Padding = new System.Windows.Forms.Padding(1);
            this.cbo_filtro.Size = new System.Drawing.Size(209, 30);
            this.cbo_filtro.TabIndex = 4;
            this.cbo_filtro.Texts = "";
            // 
            // dgv_modal_productos
            // 
            this.dgv_modal_productos.AllowUserToAddRows = false;
            this.dgv_modal_productos.AllowUserToDeleteRows = false;
            this.dgv_modal_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_modal_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_producto,
            this.codigo_barras,
            this.descripcion_producto,
            this.id_categoria,
            this.descripcion_categoria,
            this.stock,
            this.precio_costo,
            this.precio_venta});
            this.dgv_modal_productos.Location = new System.Drawing.Point(12, 41);
            this.dgv_modal_productos.Name = "dgv_modal_productos";
            this.dgv_modal_productos.ReadOnly = true;
            this.dgv_modal_productos.Size = new System.Drawing.Size(520, 267);
            this.dgv_modal_productos.TabIndex = 3;
            this.dgv_modal_productos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_modal_productos_CellDoubleClick);
            // 
            // id_producto
            // 
            this.id_producto.HeaderText = "ID_Producto";
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            this.id_producto.Visible = false;
            // 
            // codigo_barras
            // 
            this.codigo_barras.HeaderText = "Codigo de barras";
            this.codigo_barras.Name = "codigo_barras";
            this.codigo_barras.ReadOnly = true;
            // 
            // descripcion_producto
            // 
            this.descripcion_producto.HeaderText = "Descripcion";
            this.descripcion_producto.Name = "descripcion_producto";
            this.descripcion_producto.ReadOnly = true;
            // 
            // id_categoria
            // 
            this.id_categoria.HeaderText = "ID_Categoria";
            this.id_categoria.Name = "id_categoria";
            this.id_categoria.ReadOnly = true;
            this.id_categoria.Visible = false;
            // 
            // descripcion_categoria
            // 
            this.descripcion_categoria.HeaderText = "Categoria";
            this.descripcion_categoria.Name = "descripcion_categoria";
            this.descripcion_categoria.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // precio_costo
            // 
            this.precio_costo.HeaderText = "Precio costo";
            this.precio_costo.Name = "precio_costo";
            this.precio_costo.ReadOnly = true;
            this.precio_costo.Visible = false;
            // 
            // precio_venta
            // 
            this.precio_venta.HeaderText = "Precio venta";
            this.precio_venta.Name = "precio_venta";
            this.precio_venta.ReadOnly = true;
            this.precio_venta.Visible = false;
            // 
            // MD_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 312);
            this.Controls.Add(this.txt_busqueda);
            this.Controls.Add(this.cbo_filtro);
            this.Controls.Add(this.dgv_modal_productos);
            this.Name = "MD_Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MD_Productos";
            this.Load += new System.EventHandler(this.MD_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modal_productos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RJCodeAdvance.RJControls.RJTextBox txt_busqueda;
        private CustomBox.RJControls.RJComboBox cbo_filtro;
        private System.Windows.Forms.DataGridView dgv_modal_productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_barras;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_venta;
    }
}