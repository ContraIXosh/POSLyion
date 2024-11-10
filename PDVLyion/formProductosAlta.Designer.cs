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
            this.panel_crimactividad = new System.Windows.Forms.Panel();
            this.panel_actividad = new System.Windows.Forms.Panel();
            this.panel_crimconfg = new System.Windows.Forms.Panel();
            this.panel_config = new System.Windows.Forms.Panel();
            this.txt_precio_venta = new CustomBox.RJControls.RJTextBox();
            this.txt_precio_costo = new CustomBox.RJControls.RJTextBox();
            this.lbl_config = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_crimdesc = new System.Windows.Forms.Panel();
            this.panel_desc = new System.Windows.Forms.Panel();
            this.txt_stock_minimo = new CustomBox.RJControls.RJTextBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.txt_id = new CustomBox.RJControls.RJTextBox();
            this.cbox_estado = new CustomBox.RJControls.RJComboBox();
            this.lbl_stock_minimo = new System.Windows.Forms.Label();
            this.cbox_tipo = new CustomBox.RJControls.RJComboBox();
            this.lbl_cantprod = new System.Windows.Forms.Label();
            this.txt_codigo_barras = new CustomBox.RJControls.RJTextBox();
            this.txt_cantidad = new CustomBox.RJControls.RJTextBox();
            this.lbl_cod = new System.Windows.Forms.Label();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.txt_descripcion = new CustomBox.RJControls.RJTextBox();
            this.lbl_tipoprod = new System.Windows.Forms.Label();
            this.panel_main.SuspendLayout();
            this.panel_crimactividad.SuspendLayout();
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
            this.panel_main.Controls.Add(this.panel_crimactividad);
            this.panel_main.Controls.Add(this.panel_crimconfg);
            this.panel_main.Controls.Add(this.label3);
            this.panel_main.Controls.Add(this.panel_crimdesc);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(889, 647);
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
            this.btn_guardar.Location = new System.Drawing.Point(558, 607);
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
            this.btn_cerrar.Location = new System.Drawing.Point(724, 607);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(150, 36);
            this.btn_cerrar.TabIndex = 13;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.TextColor = System.Drawing.Color.Red;
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // panel_crimactividad
            // 
            this.panel_crimactividad.BackColor = System.Drawing.Color.Crimson;
            this.panel_crimactividad.Controls.Add(this.panel_actividad);
            this.panel_crimactividad.Location = new System.Drawing.Point(12, 500);
            this.panel_crimactividad.Name = "panel_crimactividad";
            this.panel_crimactividad.Size = new System.Drawing.Size(865, 101);
            this.panel_crimactividad.TabIndex = 12;
            // 
            // panel_actividad
            // 
            this.panel_actividad.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_actividad.Location = new System.Drawing.Point(3, 3);
            this.panel_actividad.Name = "panel_actividad";
            this.panel_actividad.Size = new System.Drawing.Size(859, 93);
            this.panel_actividad.TabIndex = 0;
            // 
            // panel_crimconfg
            // 
            this.panel_crimconfg.BackColor = System.Drawing.Color.Crimson;
            this.panel_crimconfg.Controls.Add(this.panel_config);
            this.panel_crimconfg.Location = new System.Drawing.Point(12, 272);
            this.panel_crimconfg.Name = "panel_crimconfg";
            this.panel_crimconfg.Size = new System.Drawing.Size(865, 222);
            this.panel_crimconfg.TabIndex = 11;
            // 
            // panel_config
            // 
            this.panel_config.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_config.Controls.Add(this.txt_precio_venta);
            this.panel_config.Controls.Add(this.txt_precio_costo);
            this.panel_config.Controls.Add(this.lbl_config);
            this.panel_config.Controls.Add(this.label6);
            this.panel_config.Controls.Add(this.label9);
            this.panel_config.Location = new System.Drawing.Point(3, 3);
            this.panel_config.Name = "panel_config";
            this.panel_config.Size = new System.Drawing.Size(859, 216);
            this.panel_config.TabIndex = 0;
            // 
            // txt_precio_venta
            // 
            this.txt_precio_venta.BackColor = System.Drawing.SystemColors.Window;
            this.txt_precio_venta.BorderColor = System.Drawing.Color.Crimson;
            this.txt_precio_venta.BorderFocusColor = System.Drawing.Color.Crimson;
            this.txt_precio_venta.BorderRadius = 0;
            this.txt_precio_venta.BorderSize = 2;
            this.txt_precio_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_precio_venta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_precio_venta.Location = new System.Drawing.Point(340, 94);
            this.txt_precio_venta.Margin = new System.Windows.Forms.Padding(4);
            this.txt_precio_venta.Multiline = false;
            this.txt_precio_venta.Name = "txt_precio_venta";
            this.txt_precio_venta.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_precio_venta.PasswordChar = false;
            this.txt_precio_venta.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_precio_venta.PlaceholderText = "";
            this.txt_precio_venta.Size = new System.Drawing.Size(213, 31);
            this.txt_precio_venta.TabIndex = 15;
            this.txt_precio_venta.Texts = "";
            this.txt_precio_venta.UnderlinedStyle = false;
            // 
            // txt_precio_costo
            // 
            this.txt_precio_costo.BackColor = System.Drawing.SystemColors.Window;
            this.txt_precio_costo.BorderColor = System.Drawing.Color.Crimson;
            this.txt_precio_costo.BorderFocusColor = System.Drawing.Color.Crimson;
            this.txt_precio_costo.BorderRadius = 0;
            this.txt_precio_costo.BorderSize = 2;
            this.txt_precio_costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_precio_costo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_precio_costo.Location = new System.Drawing.Point(8, 83);
            this.txt_precio_costo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_precio_costo.Multiline = false;
            this.txt_precio_costo.Name = "txt_precio_costo";
            this.txt_precio_costo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_precio_costo.PasswordChar = false;
            this.txt_precio_costo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_precio_costo.PlaceholderText = "";
            this.txt_precio_costo.Size = new System.Drawing.Size(213, 31);
            this.txt_precio_costo.TabIndex = 13;
            this.txt_precio_costo.Texts = "";
            this.txt_precio_costo.UnderlinedStyle = false;
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
            this.label9.Location = new System.Drawing.Point(335, 53);
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
            this.panel_desc.Controls.Add(this.lbl_estado);
            this.panel_desc.Controls.Add(this.txt_id);
            this.panel_desc.Controls.Add(this.cbox_estado);
            this.panel_desc.Controls.Add(this.lbl_stock_minimo);
            this.panel_desc.Controls.Add(this.cbox_tipo);
            this.panel_desc.Controls.Add(this.lbl_cantprod);
            this.panel_desc.Controls.Add(this.txt_codigo_barras);
            this.panel_desc.Controls.Add(this.txt_cantidad);
            this.panel_desc.Controls.Add(this.lbl_cod);
            this.panel_desc.Controls.Add(this.lbl_desc);
            this.panel_desc.Controls.Add(this.txt_descripcion);
            this.panel_desc.Controls.Add(this.lbl_tipoprod);
            this.panel_desc.Location = new System.Drawing.Point(3, 3);
            this.panel_desc.Name = "panel_desc";
            this.panel_desc.Size = new System.Drawing.Size(859, 216);
            this.panel_desc.TabIndex = 0;
            // 
            // txt_stock_minimo
            // 
            this.txt_stock_minimo.BackColor = System.Drawing.SystemColors.Window;
            this.txt_stock_minimo.BorderColor = System.Drawing.Color.Crimson;
            this.txt_stock_minimo.BorderFocusColor = System.Drawing.Color.Crimson;
            this.txt_stock_minimo.BorderRadius = 0;
            this.txt_stock_minimo.BorderSize = 2;
            this.txt_stock_minimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_stock_minimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_stock_minimo.Location = new System.Drawing.Point(616, 171);
            this.txt_stock_minimo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_stock_minimo.Multiline = false;
            this.txt_stock_minimo.Name = "txt_stock_minimo";
            this.txt_stock_minimo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_stock_minimo.PasswordChar = false;
            this.txt_stock_minimo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_stock_minimo.PlaceholderText = "";
            this.txt_stock_minimo.Size = new System.Drawing.Size(213, 31);
            this.txt_stock_minimo.TabIndex = 19;
            this.txt_stock_minimo.Texts = "";
            this.txt_stock_minimo.UnderlinedStyle = false;
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
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.SystemColors.Window;
            this.txt_id.BorderColor = System.Drawing.Color.Crimson;
            this.txt_id.BorderFocusColor = System.Drawing.Color.Crimson;
            this.txt_id.BorderRadius = 0;
            this.txt_id.BorderSize = 2;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_id.Location = new System.Drawing.Point(314, 5);
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
            // txt_codigo_barras
            // 
            this.txt_codigo_barras.BackColor = System.Drawing.SystemColors.Window;
            this.txt_codigo_barras.BorderColor = System.Drawing.Color.Crimson;
            this.txt_codigo_barras.BorderFocusColor = System.Drawing.Color.Crimson;
            this.txt_codigo_barras.BorderRadius = 0;
            this.txt_codigo_barras.BorderSize = 2;
            this.txt_codigo_barras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_codigo_barras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_codigo_barras.Location = new System.Drawing.Point(8, 83);
            this.txt_codigo_barras.Margin = new System.Windows.Forms.Padding(4);
            this.txt_codigo_barras.Multiline = false;
            this.txt_codigo_barras.Name = "txt_codigo_barras";
            this.txt_codigo_barras.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_codigo_barras.PasswordChar = false;
            this.txt_codigo_barras.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_codigo_barras.PlaceholderText = "";
            this.txt_codigo_barras.Size = new System.Drawing.Size(213, 31);
            this.txt_codigo_barras.TabIndex = 0;
            this.txt_codigo_barras.Texts = "";
            this.txt_codigo_barras.UnderlinedStyle = false;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.BackColor = System.Drawing.SystemColors.Window;
            this.txt_cantidad.BorderColor = System.Drawing.Color.Crimson;
            this.txt_cantidad.BorderFocusColor = System.Drawing.Color.Crimson;
            this.txt_cantidad.BorderRadius = 0;
            this.txt_cantidad.BorderSize = 2;
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_cantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_cantidad.Location = new System.Drawing.Point(616, 83);
            this.txt_cantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cantidad.Multiline = false;
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_cantidad.PasswordChar = false;
            this.txt_cantidad.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_cantidad.PlaceholderText = "";
            this.txt_cantidad.Size = new System.Drawing.Size(213, 31);
            this.txt_cantidad.TabIndex = 8;
            this.txt_cantidad.Texts = "";
            this.txt_cantidad.UnderlinedStyle = false;
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
            // txt_descripcion
            // 
            this.txt_descripcion.BackColor = System.Drawing.SystemColors.Window;
            this.txt_descripcion.BorderColor = System.Drawing.Color.Crimson;
            this.txt_descripcion.BorderFocusColor = System.Drawing.Color.Crimson;
            this.txt_descripcion.BorderRadius = 0;
            this.txt_descripcion.BorderSize = 2;
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_descripcion.Location = new System.Drawing.Point(311, 172);
            this.txt_descripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_descripcion.Multiline = false;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_descripcion.PasswordChar = false;
            this.txt_descripcion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_descripcion.PlaceholderText = "";
            this.txt_descripcion.Size = new System.Drawing.Size(213, 31);
            this.txt_descripcion.TabIndex = 6;
            this.txt_descripcion.Texts = "";
            this.txt_descripcion.UnderlinedStyle = false;
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
            this.ClientSize = new System.Drawing.Size(889, 647);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "formProductosAlta";
            this.Text = "Crear Producto";
            this.Load += new System.EventHandler(this.formProductosAlta_Load);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.panel_crimactividad.ResumeLayout(false);
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
        private CustomBox.RJControls.RJTextBox txt_codigo_barras;
        private System.Windows.Forms.Label lbl_tipoprod;
        private CustomBox.RJControls.RJComboBox cbox_tipo;
        private System.Windows.Forms.Panel panel_crimdesc;
        private System.Windows.Forms.Label lbl_cantprod;
        private CustomBox.RJControls.RJTextBox txt_cantidad;
        private System.Windows.Forms.Label lbl_desc;
        private CustomBox.RJControls.RJTextBox txt_descripcion;
        private System.Windows.Forms.Panel panel_desc;
        private System.Windows.Forms.Panel panel_crimconfg;
        private System.Windows.Forms.Panel panel_config;
        private System.Windows.Forms.Label lbl_config;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private CustomBox.RJControls.RJTextBox txt_precio_venta;
        private CustomBox.RJControls.RJTextBox txt_precio_costo;
        private System.Windows.Forms.Label lbl_stock_minimo;
        private System.Windows.Forms.Panel panel_crimactividad;
        private System.Windows.Forms.Panel panel_actividad;
        private CustomBox.RJControls.RJButton btn_guardar;
        private CustomBox.RJControls.RJButton btn_cerrar;
        private CustomBox.RJControls.RJTextBox txt_id;
        private CustomBox.RJControls.RJComboBox cbox_estado;
        private System.Windows.Forms.Label lbl_estado;
        private CustomBox.RJControls.RJTextBox txt_stock_minimo;
    }
}