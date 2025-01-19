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
            this.components = new System.ComponentModel.Container();
            this.panel_main = new System.Windows.Forms.Panel();
            this.btn_reiniciar_datos = new CustomBox.RJControls.RJButton();
            this.btn_guardar = new CustomBox.RJControls.RJButton();
            this.btn_cerrar = new CustomBox.RJControls.RJButton();
            this.panel_crimconfg = new System.Windows.Forms.Panel();
            this.panel_config = new System.Windows.Forms.Panel();
            this.txt_precio_mayorista = new System.Windows.Forms.TextBox();
            this.lbl_precio_mayorista = new System.Windows.Forms.Label();
            this.txt_precio_minorista = new System.Windows.Forms.TextBox();
            this.txt_costo = new System.Windows.Forms.TextBox();
            this.lbl_config = new System.Windows.Forms.Label();
            this.lbl_costo = new System.Windows.Forms.Label();
            this.lbl_precio_minorista = new System.Windows.Forms.Label();
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
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.lbl_codigo_barras = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_main.SuspendLayout();
            this.panel_crimconfg.SuspendLayout();
            this.panel_config.SuspendLayout();
            this.panel_crimdesc.SuspendLayout();
            this.panel_desc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.White;
            this.panel_main.Controls.Add(this.btn_reiniciar_datos);
            this.panel_main.Controls.Add(this.btn_guardar);
            this.panel_main.Controls.Add(this.btn_cerrar);
            this.panel_main.Controls.Add(this.panel_crimconfg);
            this.panel_main.Controls.Add(this.panel_crimdesc);
            this.panel_main.Controls.Add(this.label3);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(889, 514);
            this.panel_main.TabIndex = 0;
            // 
            // btn_reiniciar_datos
            // 
            this.btn_reiniciar_datos.BackColor = System.Drawing.Color.Yellow;
            this.btn_reiniciar_datos.BackgroundColor = System.Drawing.Color.Yellow;
            this.btn_reiniciar_datos.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_reiniciar_datos.BorderRadius = 10;
            this.btn_reiniciar_datos.BorderSize = 2;
            this.btn_reiniciar_datos.FlatAppearance.BorderSize = 0;
            this.btn_reiniciar_datos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reiniciar_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reiniciar_datos.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_reiniciar_datos.Location = new System.Drawing.Point(379, 468);
            this.btn_reiniciar_datos.Name = "btn_reiniciar_datos";
            this.btn_reiniciar_datos.Size = new System.Drawing.Size(150, 36);
            this.btn_reiniciar_datos.TabIndex = 15;
            this.btn_reiniciar_datos.Text = "Reiniciar datos";
            this.btn_reiniciar_datos.TextColor = System.Drawing.Color.DarkOrange;
            this.btn_reiniciar_datos.UseVisualStyleBackColor = false;
            this.btn_reiniciar_datos.Click += new System.EventHandler(this.btn_reiniciar_datos_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_guardar.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.btn_guardar.BorderColor = System.Drawing.Color.ForestGreen;
            this.btn_guardar.BorderRadius = 10;
            this.btn_guardar.BorderSize = 2;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_guardar.Location = new System.Drawing.Point(554, 468);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(150, 36);
            this.btn_guardar.TabIndex = 14;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextColor = System.Drawing.Color.DarkGreen;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.Red;
            this.btn_cerrar.BackgroundColor = System.Drawing.Color.Red;
            this.btn_cerrar.BorderColor = System.Drawing.Color.Maroon;
            this.btn_cerrar.BorderRadius = 10;
            this.btn_cerrar.BorderSize = 2;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.Maroon;
            this.btn_cerrar.Location = new System.Drawing.Point(727, 468);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(150, 36);
            this.btn_cerrar.TabIndex = 13;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.TextColor = System.Drawing.Color.Maroon;
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // panel_crimconfg
            // 
            this.panel_crimconfg.BackColor = System.Drawing.Color.OrangeRed;
            this.panel_crimconfg.Controls.Add(this.panel_config);
            this.panel_crimconfg.Location = new System.Drawing.Point(12, 283);
            this.panel_crimconfg.Name = "panel_crimconfg";
            this.panel_crimconfg.Size = new System.Drawing.Size(865, 174);
            this.panel_crimconfg.TabIndex = 11;
            // 
            // panel_config
            // 
            this.panel_config.BackColor = System.Drawing.Color.White;
            this.panel_config.Controls.Add(this.txt_precio_mayorista);
            this.panel_config.Controls.Add(this.lbl_precio_mayorista);
            this.panel_config.Controls.Add(this.txt_precio_minorista);
            this.panel_config.Controls.Add(this.txt_costo);
            this.panel_config.Controls.Add(this.lbl_config);
            this.panel_config.Controls.Add(this.lbl_costo);
            this.panel_config.Controls.Add(this.lbl_precio_minorista);
            this.panel_config.Location = new System.Drawing.Point(3, 3);
            this.panel_config.Name = "panel_config";
            this.panel_config.Size = new System.Drawing.Size(859, 166);
            this.panel_config.TabIndex = 0;
            // 
            // txt_precio_mayorista
            // 
            this.txt_precio_mayorista.BackColor = System.Drawing.Color.PeachPuff;
            this.txt_precio_mayorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio_mayorista.Location = new System.Drawing.Point(610, 82);
            this.txt_precio_mayorista.Name = "txt_precio_mayorista";
            this.txt_precio_mayorista.Size = new System.Drawing.Size(241, 33);
            this.txt_precio_mayorista.TabIndex = 28;
            this.txt_precio_mayorista.Text = "0";
            // 
            // lbl_precio_mayorista
            // 
            this.lbl_precio_mayorista.AutoSize = true;
            this.lbl_precio_mayorista.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio_mayorista.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_precio_mayorista.Location = new System.Drawing.Point(605, 53);
            this.lbl_precio_mayorista.Name = "lbl_precio_mayorista";
            this.lbl_precio_mayorista.Size = new System.Drawing.Size(207, 26);
            this.lbl_precio_mayorista.TabIndex = 27;
            this.lbl_precio_mayorista.Text = "PRECIO MAYORISTA";
            // 
            // txt_precio_minorista
            // 
            this.txt_precio_minorista.BackColor = System.Drawing.Color.PeachPuff;
            this.txt_precio_minorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio_minorista.Location = new System.Drawing.Point(311, 85);
            this.txt_precio_minorista.Name = "txt_precio_minorista";
            this.txt_precio_minorista.Size = new System.Drawing.Size(241, 33);
            this.txt_precio_minorista.TabIndex = 26;
            this.txt_precio_minorista.Text = "0";
            // 
            // txt_costo
            // 
            this.txt_costo.BackColor = System.Drawing.Color.PeachPuff;
            this.txt_costo.Enabled = false;
            this.txt_costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costo.Location = new System.Drawing.Point(8, 85);
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.Size = new System.Drawing.Size(241, 33);
            this.txt_costo.TabIndex = 25;
            this.txt_costo.Text = "0";
            // 
            // lbl_config
            // 
            this.lbl_config.AutoSize = true;
            this.lbl_config.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_config.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_config.Location = new System.Drawing.Point(3, 10);
            this.lbl_config.Name = "lbl_config";
            this.lbl_config.Size = new System.Drawing.Size(342, 26);
            this.lbl_config.TabIndex = 10;
            this.lbl_config.Text = "CONFIGURACIÓN DEL PRODUCTO";
            // 
            // lbl_costo
            // 
            this.lbl_costo.AutoSize = true;
            this.lbl_costo.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_costo.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_costo.Location = new System.Drawing.Point(3, 53);
            this.lbl_costo.Name = "lbl_costo";
            this.lbl_costo.Size = new System.Drawing.Size(80, 26);
            this.lbl_costo.TabIndex = 1;
            this.lbl_costo.Text = "COSTO";
            // 
            // lbl_precio_minorista
            // 
            this.lbl_precio_minorista.AutoSize = true;
            this.lbl_precio_minorista.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio_minorista.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_precio_minorista.Location = new System.Drawing.Point(306, 53);
            this.lbl_precio_minorista.Name = "lbl_precio_minorista";
            this.lbl_precio_minorista.Size = new System.Drawing.Size(188, 26);
            this.lbl_precio_minorista.TabIndex = 5;
            this.lbl_precio_minorista.Text = "PRECIO DE VENTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("FORESTS ITALIC PERSONAL USE", 39.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(234, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(433, 64);
            this.label3.TabIndex = 11;
            this.label3.Text = "CREAR NUEVO PRODUCTO";
            // 
            // panel_crimdesc
            // 
            this.panel_crimdesc.BackColor = System.Drawing.Color.OrangeRed;
            this.panel_crimdesc.Controls.Add(this.panel_desc);
            this.panel_crimdesc.Location = new System.Drawing.Point(12, 58);
            this.panel_crimdesc.Name = "panel_crimdesc";
            this.panel_crimdesc.Size = new System.Drawing.Size(865, 222);
            this.panel_crimdesc.TabIndex = 10;
            // 
            // panel_desc
            // 
            this.panel_desc.BackColor = System.Drawing.Color.White;
            this.panel_desc.Controls.Add(this.txt_stock_minimo);
            this.panel_desc.Controls.Add(this.txt_descripcion);
            this.panel_desc.Controls.Add(this.txt_cantidad);
            this.panel_desc.Controls.Add(this.lbl_prod);
            this.panel_desc.Controls.Add(this.txt_codigo_barras);
            this.panel_desc.Controls.Add(this.lbl_estado);
            this.panel_desc.Controls.Add(this.cbox_estado);
            this.panel_desc.Controls.Add(this.lbl_stock_minimo);
            this.panel_desc.Controls.Add(this.cbox_tipo);
            this.panel_desc.Controls.Add(this.lbl_cantidad);
            this.panel_desc.Controls.Add(this.lbl_codigo_barras);
            this.panel_desc.Controls.Add(this.lbl_descripcion);
            this.panel_desc.Controls.Add(this.lbl_categoria);
            this.panel_desc.Location = new System.Drawing.Point(3, 3);
            this.panel_desc.Name = "panel_desc";
            this.panel_desc.Size = new System.Drawing.Size(859, 216);
            this.panel_desc.TabIndex = 0;
            // 
            // txt_stock_minimo
            // 
            this.txt_stock_minimo.BackColor = System.Drawing.Color.PeachPuff;
            this.txt_stock_minimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stock_minimo.Location = new System.Drawing.Point(610, 172);
            this.txt_stock_minimo.Name = "txt_stock_minimo";
            this.txt_stock_minimo.Size = new System.Drawing.Size(241, 33);
            this.txt_stock_minimo.TabIndex = 24;
            this.txt_stock_minimo.Text = "0";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.BackColor = System.Drawing.Color.PeachPuff;
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(311, 172);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(241, 33);
            this.txt_descripcion.TabIndex = 23;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.BackColor = System.Drawing.Color.PeachPuff;
            this.txt_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.Location = new System.Drawing.Point(610, 83);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(241, 33);
            this.txt_cantidad.TabIndex = 22;
            this.txt_cantidad.Text = "0";
            // 
            // lbl_prod
            // 
            this.lbl_prod.AutoSize = true;
            this.lbl_prod.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prod.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_prod.Location = new System.Drawing.Point(3, 14);
            this.lbl_prod.Name = "lbl_prod";
            this.lbl_prod.Size = new System.Drawing.Size(202, 26);
            this.lbl_prod.TabIndex = 21;
            this.lbl_prod.Text = "PRODUCTO NUEVO";
            // 
            // txt_codigo_barras
            // 
            this.txt_codigo_barras.BackColor = System.Drawing.Color.PeachPuff;
            this.txt_codigo_barras.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_barras.Location = new System.Drawing.Point(8, 83);
            this.txt_codigo_barras.Name = "txt_codigo_barras";
            this.txt_codigo_barras.Size = new System.Drawing.Size(241, 33);
            this.txt_codigo_barras.TabIndex = 20;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_estado.Location = new System.Drawing.Point(3, 142);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(91, 26);
            this.lbl_estado.TabIndex = 18;
            this.lbl_estado.Text = "ESTADO";
            // 
            // cbox_estado
            // 
            this.cbox_estado.BackColor = System.Drawing.Color.OrangeRed;
            this.cbox_estado.BorderColor = System.Drawing.Color.GhostWhite;
            this.cbox_estado.BorderSize = 1;
            this.cbox_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbox_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold);
            this.cbox_estado.ForeColor = System.Drawing.Color.NavajoWhite;
            this.cbox_estado.IconColor = System.Drawing.Color.NavajoWhite;
            this.cbox_estado.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbox_estado.ListTextColor = System.Drawing.Color.DimGray;
            this.cbox_estado.Location = new System.Drawing.Point(8, 172);
            this.cbox_estado.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbox_estado.Name = "cbox_estado";
            this.cbox_estado.Padding = new System.Windows.Forms.Padding(1);
            this.cbox_estado.Size = new System.Drawing.Size(241, 30);
            this.cbox_estado.TabIndex = 14;
            this.cbox_estado.Texts = "";
            // 
            // lbl_stock_minimo
            // 
            this.lbl_stock_minimo.AutoSize = true;
            this.lbl_stock_minimo.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stock_minimo.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_stock_minimo.Location = new System.Drawing.Point(605, 143);
            this.lbl_stock_minimo.Name = "lbl_stock_minimo";
            this.lbl_stock_minimo.Size = new System.Drawing.Size(167, 26);
            this.lbl_stock_minimo.TabIndex = 12;
            this.lbl_stock_minimo.Text = "STOCK MINIMO";
            // 
            // cbox_tipo
            // 
            this.cbox_tipo.BackColor = System.Drawing.Color.OrangeRed;
            this.cbox_tipo.BorderColor = System.Drawing.Color.GhostWhite;
            this.cbox_tipo.BorderSize = 1;
            this.cbox_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbox_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold);
            this.cbox_tipo.ForeColor = System.Drawing.Color.NavajoWhite;
            this.cbox_tipo.IconColor = System.Drawing.Color.NavajoWhite;
            this.cbox_tipo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbox_tipo.ListTextColor = System.Drawing.Color.DimGray;
            this.cbox_tipo.Location = new System.Drawing.Point(311, 82);
            this.cbox_tipo.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbox_tipo.Name = "cbox_tipo";
            this.cbox_tipo.Padding = new System.Windows.Forms.Padding(1);
            this.cbox_tipo.Size = new System.Drawing.Size(241, 34);
            this.cbox_tipo.TabIndex = 4;
            this.cbox_tipo.Texts = "";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_cantidad.Location = new System.Drawing.Point(605, 54);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(117, 26);
            this.lbl_cantidad.TabIndex = 9;
            this.lbl_cantidad.Text = "CANTIDAD";
            // 
            // lbl_codigo_barras
            // 
            this.lbl_codigo_barras.AutoSize = true;
            this.lbl_codigo_barras.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo_barras.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_codigo_barras.Location = new System.Drawing.Point(3, 53);
            this.lbl_codigo_barras.Name = "lbl_codigo_barras";
            this.lbl_codigo_barras.Size = new System.Drawing.Size(177, 26);
            this.lbl_codigo_barras.TabIndex = 1;
            this.lbl_codigo_barras.Text = "CODIGO BARRAS";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_descripcion.Location = new System.Drawing.Point(306, 142);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(144, 26);
            this.lbl_descripcion.TabIndex = 7;
            this.lbl_descripcion.Text = "DESCRIPCIÓN";
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoria.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_categoria.Location = new System.Drawing.Point(306, 53);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(208, 26);
            this.lbl_categoria.TabIndex = 5;
            this.lbl_categoria.Text = "TIPO DE PRODUCTO";
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
            // formProductosAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 514);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "formProductosAlta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear un producto";
            this.Load += new System.EventHandler(this.formProductosAlta_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formProductosAlta_KeyDown);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.panel_crimconfg.ResumeLayout(false);
            this.panel_config.ResumeLayout(false);
            this.panel_config.PerformLayout();
            this.panel_crimdesc.ResumeLayout(false);
            this.panel_desc.ResumeLayout(false);
            this.panel_desc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label lbl_codigo_barras;
        private System.Windows.Forms.Label lbl_categoria;
        private CustomBox.RJControls.RJComboBox cbox_tipo;
        private System.Windows.Forms.Panel panel_crimdesc;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Panel panel_desc;
        private System.Windows.Forms.Panel panel_crimconfg;
        private System.Windows.Forms.Panel panel_config;
        private System.Windows.Forms.Label lbl_config;
        private System.Windows.Forms.Label lbl_costo;
        private System.Windows.Forms.Label lbl_precio_minorista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_stock_minimo;
        private CustomBox.RJControls.RJButton btn_guardar;
        private CustomBox.RJControls.RJButton btn_cerrar;
        private CustomBox.RJControls.RJComboBox cbox_estado;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Label lbl_prod;
        private System.Windows.Forms.TextBox txt_codigo_barras;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_stock_minimo;
        private System.Windows.Forms.TextBox txt_costo;
        private System.Windows.Forms.TextBox txt_precio_minorista;
        private CustomBox.RJControls.RJButton btn_reiniciar_datos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.TextBox txt_precio_mayorista;
        private System.Windows.Forms.Label lbl_precio_mayorista;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
    }
}