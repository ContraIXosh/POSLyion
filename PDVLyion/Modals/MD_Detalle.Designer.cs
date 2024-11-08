namespace PDCLyion.Modals
{
    partial class MD_Detalle
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
            this.dgv_detalle = new System.Windows.Forms.DataGridView();
            this.codigo_barras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_detalle
            // 
            this.dgv_detalle.AllowUserToAddRows = false;
            this.dgv_detalle.AllowUserToDeleteRows = false;
            this.dgv_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_barras,
            this.nombre_producto,
            this.nombre_categoria,
            this.precio_unitario,
            this.cantidad,
            this.subtotal});
            this.dgv_detalle.Location = new System.Drawing.Point(13, 12);
            this.dgv_detalle.Name = "dgv_detalle";
            this.dgv_detalle.ReadOnly = true;
            this.dgv_detalle.Size = new System.Drawing.Size(628, 331);
            this.dgv_detalle.TabIndex = 1;
            // 
            // codigo_barras
            // 
            this.codigo_barras.HeaderText = "Codigo de barras";
            this.codigo_barras.Name = "codigo_barras";
            this.codigo_barras.ReadOnly = true;
            // 
            // nombre_producto
            // 
            this.nombre_producto.HeaderText = "Producto";
            this.nombre_producto.Name = "nombre_producto";
            this.nombre_producto.ReadOnly = true;
            // 
            // nombre_categoria
            // 
            this.nombre_categoria.HeaderText = "Categoria";
            this.nombre_categoria.Name = "nombre_categoria";
            this.nombre_categoria.ReadOnly = true;
            // 
            // precio_unitario
            // 
            this.precio_unitario.HeaderText = "Precio unitario";
            this.precio_unitario.Name = "precio_unitario";
            this.precio_unitario.ReadOnly = true;
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
            // MD_Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 350);
            this.Controls.Add(this.dgv_detalle);
            this.Name = "MD_Detalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles";
            this.Load += new System.EventHandler(this.MD_ComprasDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_barras;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}