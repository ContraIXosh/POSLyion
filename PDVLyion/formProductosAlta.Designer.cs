namespace POSLyion
{
    partial class formProductosAlta
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
            this.btn_guardar = new CustomBox.RJControls.RJButton();
            this.btn_cerrar = new CustomBox.RJControls.RJButton();
            this.panel_crimconfg = new System.Windows.Forms.Panel();
            this.panel_config = new System.Windows.Forms.Panel();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_costo = new System.Windows.Forms.TextBox();
            this.lbl_config = new System.Windows.Forms.Label();
            this.txt_id = new CustomBox.RJControls.RJTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_crimdesc = new System.Windows.Forms.Panel();
            this.panel_desc = new System.Windows.Forms.Panel();
            this.txt_stock_minimo = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.lbl_prod = new System.Windows.Forms.Label();
            this.txt_codigo_barras = new System.Windows.Forms.TextBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.cbox_estado = new CustomBox.RJControls.RJComboBox();
            this.lbl_stock_minimo = new System.Windows.Forms.Label();
            this.cbox_tipo = new CustomBox.RJControls.RJComboBox();
            this.lbl_cantprod = new System.Windows.Forms.Label();
            this.lbl_cod = new System.Windows.Forms.Label();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.lbl_tipoprod = new System.Windows.Forms.Label();
            this.panel_main.SuspendLayout();
            this.panel_crimconfg.SuspendLayout();
            this.panel_config.SuspendLayout();
            this.panel_crimdesc.SuspendLayout();
            this.panel_desc.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_main.Controls.Add(this.btn_guardar);
            this.panel_main.Controls.Add(this.btn_cerrar);
            this.panel_main.Controls.Add(this.panel_crimconfg);
            this.panel_main.Controls.Add(this.txt_id);
            this.panel_main.Controls.Add(this.label3);
            this.panel_main.Controls.Add(this.panel_crimdesc);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(889, 514);
            this.panel_main.TabIndex = 0;
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
            this.btn_guardar.Location = new System.Drawing.Point(554, 468);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(150, 36);
            this.btn_guardar.TabIndex = 14;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextColor = System.Drawing.Color.Lime;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
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
            this.btn_cerrar.Location = new System.Drawing.Point(727, 468);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(150, 36);
            this.btn_cerrar.TabIndex = 13;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.TextColor = System.Drawing.Color.Red;
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // panel_crimconfg
            // 
            this.panel_crimconfg.BackColor = System.Drawing.Color.Crimson;
            this.panel_crimconfg.Controls.Add(this.panel_config);
            this.panel_crimconfg.Location = new System.Drawing.Point(12, 272);
            this.panel_crimconfg.Name = "panel_crimconfg";
            this.panel_crimconfg.Size = new System.Drawing.Size(865, 174);
            this.panel_crimconfg.TabIndex = 11;
            // 
            // panel_config
            // 
            this.panel_config.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_config.Controls.Add(this.txt_precio);
            this.panel_config.Controls.Add(this.txt_costo);
            this.panel_config.Controls.Add(this.lbl_config);
            this.panel_config.Controls.Add(this.label6);
            this.panel_config.Controls.Add(this.label9);
            this.panel_config.Location = new System.Drawing.Point(3, 3);
            this.panel_config.Name = "panel_config";
            this.panel_config.Size = new System.Drawing.Size(859, 166);
            this.panel_config.TabIndex = 0;
            // 
            // txt_precio
            // 
            this.txt_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio.Location = new System.Drawing.Point(311, 85);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(213, 29);
            this.txt_precio.TabIndex = 26;
            // 
            // txt_costo
            // 
            this.txt_costo.Enabled = false;
            this.txt_costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costo.Location = new System.Drawing.Point(8, 85);
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.Size = new System.Drawing.Size(213, 29);
            this.txt_costo.TabIndex = 25;
            this.txt_costo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_costo_KeyPress);
            // 
            // lbl_config
            // 
            this.lbl_config.AutoSize = true;
            this.lbl_config.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_config.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_config.Location = new System.Drawing.Point(3, 10);
            this.lbl_config.Name = "lbl_config";
            this.lbl_config.Size = new System.Drawing.Size(342, 26);
            this.lbl_config.TabIndex = 10;
            this.lbl_config.Text = "CONFIGURACIÓN DEL PRODUCTO";
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.SystemColors.Window;
            this.txt_id.BorderColor = System.Drawing.Color.Crimson;
            this.txt_id.BorderFocusColor = System.Drawing.Color.Crimson;
            this.txt_id.BorderRadius = 0;
            this.txt_id.BorderSize = 2;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_id.Location = new System.Drawing.Point(15, 468);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Multiline = false;
            this.txt_id.Name = "txt_id";
            this.txt_id.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_id.PasswordChar = false;
            this.txt_id.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_id.PlaceholderText = "";
            this.txt_id.Size = new System.Drawing.Size(75, 31);
            this.txt_id.TabIndex = 13;
            this.txt_id.Texts = "0";
            this.txt_id.UnderlinedStyle = false;
            this.txt_id.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(3, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "COSTO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gold;
            this.label9.Location = new System.Drawing.Point(306, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 26);
            this.label9.TabIndex = 5;
            this.label9.Text = "PRECIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(274, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "CREAR NUEVO PRODUCTO";
            // 
            // panel_crimdesc
            // 
            this.panel_crimdesc.BackColor = System.Drawing.Color.Crimson;
            this.panel_crimdesc.Controls.Add(this.panel_desc);
            this.panel_crimdesc.Location = new System.Drawing.Point(12, 44);
            this.panel_crimdesc.Name = "panel_crimdesc";
            this.panel_crimdesc.Size = new System.Drawing.Size(865, 222);
            this.panel_crimdesc.TabIndex = 10;
            // 
            // panel_desc
            // 
            this.panel_desc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_desc.Controls.Add(this.txt_stock_minimo);
            this.panel_desc.Controls.Add(this.txt_descripcion);
            this.panel_desc.Controls.Add(this.txt_cantidad);
            this.panel_desc.Controls.Add(this.lbl_prod);
            this.panel_desc.Controls.Add(this.txt_codigo_barras);
            this.panel_desc.Controls.Add(this.lbl_estado);
            this.panel_desc.Controls.Add(this.cbox_estado);
            this.panel_desc.Controls.Add(this.lbl_stock_minimo);
            this.panel_desc.Controls.Add(this.cbox_tipo);
            this.panel_desc.Controls.Add(this.lbl_cantprod);
            this.panel_desc.Controls.Add(this.lbl_cod);
            this.panel_desc.Controls.Add(this.lbl_desc);
            this.panel_desc.Controls.Add(this.lbl_tipoprod);
            this.panel_desc.Location = new System.Drawing.Point(3, 3);
            this.panel_desc.Name = "panel_desc";
            this.panel_desc.Size = new System.Drawing.Size(859, 216);
            this.panel_desc.TabIndex = 0;
            // 
            // txt_stock_minimo
            // 
            this.txt_stock_minimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stock_minimo.Location = new System.Drawing.Point(616, 172);
            this.txt_stock_minimo.Name = "txt_stock_minimo";
            this.txt_stock_minimo.Size = new System.Drawing.Size(213, 29);
            this.txt_stock_minimo.TabIndex = 24;
            this.txt_stock_minimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_stock_minimo_KeyPress);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(311, 173);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(213, 29);
            this.txt_descripcion.TabIndex = 23;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.Location = new System.Drawing.Point(616, 83);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(213, 29);
            this.txt_cantidad.TabIndex = 22;
            this.txt_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_KeyPress);
            // 
            // lbl_prod
            // 
            this.lbl_prod.AutoSize = true;
            this.lbl_prod.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prod.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_prod.Location = new System.Drawing.Point(3, 14);
            this.lbl_prod.Name = "lbl_prod";
            this.lbl_prod.Size = new System.Drawing.Size(202, 26);
            this.lbl_prod.TabIndex = 21;
            this.lbl_prod.Text = "PRODUCTO NUEVO";
            // 
            // txt_codigo_barras
            // 
            this.txt_codigo_barras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_barras.Location = new System.Drawing.Point(8, 83);
            this.txt_codigo_barras.Name = "txt_codigo_barras";
            this.txt_codigo_barras.Size = new System.Drawing.Size(213, 29);
            this.txt_codigo_barras.TabIndex = 20;
            this.txt_codigo_barras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_barras_KeyPress);
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.ForeColor = System.Drawing.Color.Gold;
            this.lbl_estado.Location = new System.Drawing.Point(3, 142);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(91, 26);
            this.lbl_estado.TabIndex = 18;
            this.lbl_estado.Text = "ESTADO";
            // 
            // cbox_estado
            // 
            this.cbox_estado.BackColor = System.Drawing.Color.Crimson;
            this.cbox_estado.BorderColor = System.Drawing.Color.GhostWhite;
            this.cbox_estado.BorderSize = 1;
            this.cbox_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbox_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbox_estado.ForeColor = System.Drawing.Color.DimGray;
            this.cbox_estado.IconColor = System.Drawing.Color.GhostWhite;
            this.cbox_estado.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbox_estado.ListTextColor = System.Drawing.Color.DimGray;
            this.cbox_estado.Location = new System.Drawing.Point(8, 172);
            this.cbox_estado.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbox_estado.Name = "cbox_estado";
            this.cbox_estado.Padding = new System.Windows.Forms.Padding(1);
            this.cbox_estado.Size = new System.Drawing.Size(213, 30);
            this.cbox_estado.TabIndex = 14;
            this.cbox_estado.Texts = "";
            // 
            // lbl_stock_minimo
            // 
            this.lbl_stock_minimo.AutoSize = true;
            this.lbl_stock_minimo.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stock_minimo.ForeColor = System.Drawing.Color.Gold;
            this.lbl_stock_minimo.Location = new System.Drawing.Point(611, 143);
            this.lbl_stock_minimo.Name = "lbl_stock_minimo";
            this.lbl_stock_minimo.Size = new System.Drawing.Size(167, 26);
            this.lbl_stock_minimo.TabIndex = 12;
            this.lbl_stock_minimo.Text = "STOCK MINIMO";
            // 
            // cbox_tipo
            // 
            this.cbox_tipo.BackColor = System.Drawing.Color.Crimson;
            this.cbox_tipo.BorderColor = System.Drawing.Color.GhostWhite;
            this.cbox_tipo.BorderSize = 1;
            this.cbox_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbox_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbox_tipo.ForeColor = System.Drawing.Color.DimGray;
            this.cbox_tipo.IconColor = System.Drawing.Color.GhostWhite;
            this.cbox_tipo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbox_tipo.ListTextColor = System.Drawing.Color.DimGray;
            this.cbox_tipo.Location = new System.Drawing.Point(311, 82);
            this.cbox_tipo.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbox_tipo.Name = "cbox_tipo";
            this.cbox_tipo.Padding = new System.Windows.Forms.Padding(1);
            this.cbox_tipo.Size = new System.Drawing.Size(213, 30);
            this.cbox_tipo.TabIndex = 4;
            this.cbox_tipo.Texts = "";
            // 
            // lbl_cantprod
            // 
            this.lbl_cantprod.AutoSize = true;
            this.lbl_cantprod.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantprod.ForeColor = System.Drawing.Color.Gold;
            this.lbl_cantprod.Location = new System.Drawing.Point(611, 53);
            this.lbl_cantprod.Name = "lbl_cantprod";
            this.lbl_cantprod.Size = new System.Drawing.Size(117, 26);
            this.lbl_cantprod.TabIndex = 9;
            this.lbl_cantprod.Text = "CANTIDAD";
            // 
            // lbl_cod
            // 
            this.lbl_cod.AutoSize = true;
            this.lbl_cod.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cod.ForeColor = System.Drawing.Color.Gold;
            this.lbl_cod.Location = new System.Drawing.Point(3, 53);
            this.lbl_cod.Name = "lbl_cod";
            this.lbl_cod.Size = new System.Drawing.Size(177, 26);
            this.lbl_cod.TabIndex = 1;
            this.lbl_cod.Text = "CODIGO BARRAS";
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desc.ForeColor = System.Drawing.Color.Gold;
            this.lbl_desc.Location = new System.Drawing.Point(306, 142);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(144, 26);
            this.lbl_desc.TabIndex = 7;
            this.lbl_desc.Text = "DESCRIPCIÓN";
            // 
            // lbl_tipoprod
            // 
            this.lbl_tipoprod.AutoSize = true;
            this.lbl_tipoprod.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipoprod.ForeColor = System.Drawing.Color.Gold;
            this.lbl_tipoprod.Location = new System.Drawing.Point(306, 53);
            this.lbl_tipoprod.Name = "lbl_tipoprod";
            this.lbl_tipoprod.Size = new System.Drawing.Size(208, 26);
            this.lbl_tipoprod.TabIndex = 5;
            this.lbl_tipoprod.Text = "TIPO DE PRODUCTO";
            // 
            // formProductosAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 514);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "formProductosAlta";
            this.Text = "Crear Producto";
            this.Load += new System.EventHandler(this.formProductosAlta_Load);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.panel_crimconfg.ResumeLayout(false);
            this.panel_config.ResumeLayout(false);
            this.panel_config.PerformLayout();
            this.panel_crimdesc.ResumeLayout(false);
            this.panel_desc.ResumeLayout(false);
            this.panel_desc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label lbl_cod;
        private System.Windows.Forms.Label lbl_tipoprod;
        private CustomBox.RJControls.RJComboBox cbox_tipo;
        private System.Windows.Forms.Panel panel_crimdesc;
        private System.Windows.Forms.Label lbl_cantprod;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.Panel panel_desc;
        private System.Windows.Forms.Panel panel_crimconfg;
        private System.Windows.Forms.Panel panel_config;
        private System.Windows.Forms.Label lbl_config;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_stock_minimo;
        private CustomBox.RJControls.RJButton btn_guardar;
        private CustomBox.RJControls.RJButton btn_cerrar;
        private CustomBox.RJControls.RJTextBox txt_id;
        private CustomBox.RJControls.RJComboBox cbox_estado;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Label lbl_prod;
        private System.Windows.Forms.TextBox txt_codigo_barras;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_stock_minimo;
        private System.Windows.Forms.TextBox txt_costo;
        private System.Windows.Forms.TextBox txt_precio;
    }
}