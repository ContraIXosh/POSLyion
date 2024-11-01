namespace PDCLyion.Modals
{
    partial class MD_EditarCantidad
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
            this.lbl_descripcion_producto = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.num_nueva_cantidad = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num_nueva_cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_descripcion_producto
            // 
            this.lbl_descripcion_producto.AutoSize = true;
            this.lbl_descripcion_producto.Location = new System.Drawing.Point(90, 9);
            this.lbl_descripcion_producto.Name = "lbl_descripcion_producto";
            this.lbl_descripcion_producto.Size = new System.Drawing.Size(104, 13);
            this.lbl_descripcion_producto.TabIndex = 1;
            this.lbl_descripcion_producto.Text = "Nombre de producto";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Location = new System.Drawing.Point(1, 37);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(86, 13);
            this.lbl_cantidad.TabIndex = 2;
            this.lbl_cantidad.Text = "Nueva cantidad:";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(45, 66);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 3;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(176, 66);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // num_nueva_cantidad
            // 
            this.num_nueva_cantidad.Location = new System.Drawing.Point(93, 33);
            this.num_nueva_cantidad.Name = "num_nueva_cantidad";
            this.num_nueva_cantidad.Size = new System.Drawing.Size(120, 20);
            this.num_nueva_cantidad.TabIndex = 5;
            // 
            // MD_EditarCantidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 101);
            this.Controls.Add(this.num_nueva_cantidad);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.lbl_descripcion_producto);
            this.Name = "MD_EditarCantidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MD_EditarCantidad";
            ((System.ComponentModel.ISupportInitialize)(this.num_nueva_cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_descripcion_producto;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.NumericUpDown num_nueva_cantidad;
    }
}