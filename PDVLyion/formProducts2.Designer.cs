namespace PDCLyion
{
    partial class formProducts2
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
            this.btn_cancelar = new CustomBox.RJControls.RJButton();
            this.panel_crimactividad = new System.Windows.Forms.Panel();
            this.panel_actividad = new System.Windows.Forms.Panel();
            this.cb_res = new System.Windows.Forms.CheckBox();
            this.cb_applyion = new System.Windows.Forms.CheckBox();
            this.cb_fraccion = new System.Windows.Forms.CheckBox();
            this.cb_active = new System.Windows.Forms.CheckBox();
            this.lbl_actividad = new System.Windows.Forms.Label();
            this.panel_crimconfg = new System.Windows.Forms.Panel();
            this.panel_config = new System.Windows.Forms.Panel();
            this.txt_descuento = new CustomBox.RJControls.RJTextBox();
            this.cbox_iva = new CustomBox.RJControls.RJComboBox();
            this.txt_precio2 = new CustomBox.RJControls.RJTextBox();
            this.txt_precio = new CustomBox.RJControls.RJTextBox();
            this.txt_ganancia = new CustomBox.RJControls.RJTextBox();
            this.txt_costo = new CustomBox.RJControls.RJTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_config = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_crimdesc = new System.Windows.Forms.Panel();
            this.panel_desc = new System.Windows.Forms.Panel();
            this.cbox_proveedor = new CustomBox.RJControls.RJComboBox();
            this.lbl_proveedor = new System.Windows.Forms.Label();
            this.lbl_descrip = new System.Windows.Forms.Label();
            this.cbox_tipo = new CustomBox.RJControls.RJComboBox();
            this.lbl_cantprod = new System.Windows.Forms.Label();
            this.txt_cod = new CustomBox.RJControls.RJTextBox();
            this.txt_cant = new CustomBox.RJControls.RJTextBox();
            this.lbl_cod = new System.Windows.Forms.Label();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.txt_cod2 = new CustomBox.RJControls.RJTextBox();
            this.txt_desc = new CustomBox.RJControls.RJTextBox();
            this.lbl_cod2 = new System.Windows.Forms.Label();
            this.lbl_tipoprod = new System.Windows.Forms.Label();
            this.panel_main.SuspendLayout();
            this.panel_crimactividad.SuspendLayout();
            this.panel_actividad.SuspendLayout();
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
            this.panel_main.Controls.Add(this.btn_cancelar);
            this.panel_main.Controls.Add(this.panel_crimactividad);
            this.panel_main.Controls.Add(this.panel_crimconfg);
            this.panel_main.Controls.Add(this.label3);
            this.panel_main.Controls.Add(this.panel_crimdesc);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(889, 647);
            this.panel_main.TabIndex = 0;
            this.panel_main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_main_Paint);
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
            this.btn_guardar.Text = "GUARDAR";
            this.btn_guardar.TextColor = System.Drawing.Color.Lime;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.BorderColor = System.Drawing.Color.Red;
            this.btn_cancelar.BorderRadius = 10;
            this.btn_cancelar.BorderSize = 2;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.Red;
            this.btn_cancelar.Location = new System.Drawing.Point(724, 607);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(150, 36);
            this.btn_cancelar.TabIndex = 13;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.TextColor = System.Drawing.Color.Red;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
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
            this.panel_actividad.Controls.Add(this.cb_res);
            this.panel_actividad.Controls.Add(this.cb_applyion);
            this.panel_actividad.Controls.Add(this.cb_fraccion);
            this.panel_actividad.Controls.Add(this.cb_active);
            this.panel_actividad.Controls.Add(this.lbl_actividad);
            this.panel_actividad.Location = new System.Drawing.Point(3, 3);
            this.panel_actividad.Name = "panel_actividad";
            this.panel_actividad.Size = new System.Drawing.Size(859, 93);
            this.panel_actividad.TabIndex = 0;
            // 
            // cb_res
            // 
            this.cb_res.AutoSize = true;
            this.cb_res.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_res.ForeColor = System.Drawing.Color.Gold;
            this.cb_res.Location = new System.Drawing.Point(664, 53);
            this.cb_res.Name = "cb_res";
            this.cb_res.Size = new System.Drawing.Size(154, 28);
            this.cb_res.TabIndex = 14;
            this.cb_res.Text = "RES. 5329/23";
            this.cb_res.UseVisualStyleBackColor = true;
            // 
            // cb_applyion
            // 
            this.cb_applyion.AutoSize = true;
            this.cb_applyion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_applyion.ForeColor = System.Drawing.Color.Gold;
            this.cb_applyion.Location = new System.Drawing.Point(361, 53);
            this.cb_applyion.Name = "cb_applyion";
            this.cb_applyion.Size = new System.Drawing.Size(268, 28);
            this.cb_applyion.TabIndex = 13;
            this.cb_applyion.Text = "PUBLICAR EN APPLYION";
            this.cb_applyion.UseVisualStyleBackColor = true;
            // 
            // cb_fraccion
            // 
            this.cb_fraccion.AutoSize = true;
            this.cb_fraccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_fraccion.ForeColor = System.Drawing.Color.Gold;
            this.cb_fraccion.Location = new System.Drawing.Point(153, 53);
            this.cb_fraccion.Name = "cb_fraccion";
            this.cb_fraccion.Size = new System.Drawing.Size(178, 28);
            this.cb_fraccion.TabIndex = 12;
            this.cb_fraccion.Text = "FRACCIONADO";
            this.cb_fraccion.UseVisualStyleBackColor = true;
            // 
            // cb_active
            // 
            this.cb_active.AutoSize = true;
            this.cb_active.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_active.ForeColor = System.Drawing.Color.Gold;
            this.cb_active.Location = new System.Drawing.Point(9, 53);
            this.cb_active.Name = "cb_active";
            this.cb_active.Size = new System.Drawing.Size(105, 28);
            this.cb_active.TabIndex = 11;
            this.cb_active.Text = "ACTIVO";
            this.cb_active.UseVisualStyleBackColor = true;
            this.cb_active.CheckedChanged += new System.EventHandler(this.cb_active_CheckedChanged);
            // 
            // lbl_actividad
            // 
            this.lbl_actividad.AutoSize = true;
            this.lbl_actividad.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_actividad.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_actividad.Location = new System.Drawing.Point(3, 10);
            this.lbl_actividad.Name = "lbl_actividad";
            this.lbl_actividad.Size = new System.Drawing.Size(281, 26);
            this.lbl_actividad.TabIndex = 10;
            this.lbl_actividad.Text = "ACTIVIDAD DEL PRODUCTO";
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
            this.panel_config.Controls.Add(this.txt_descuento);
            this.panel_config.Controls.Add(this.cbox_iva);
            this.panel_config.Controls.Add(this.txt_precio2);
            this.panel_config.Controls.Add(this.txt_precio);
            this.panel_config.Controls.Add(this.txt_ganancia);
            this.panel_config.Controls.Add(this.txt_costo);
            this.panel_config.Controls.Add(this.label10);
            this.panel_config.Controls.Add(this.lbl_config);
            this.panel_config.Controls.Add(this.label5);
            this.panel_config.Controls.Add(this.label6);
            this.panel_config.Controls.Add(this.label7);
            this.panel_config.Controls.Add(this.label8);
            this.panel_config.Controls.Add(this.label9);
            this.panel_config.Location = new System.Drawing.Point(3, 3);
            this.panel_config.Name = "panel_config";
            this.panel_config.Size = new System.Drawing.Size(859, 216);
            this.panel_config.TabIndex = 0;
            // 
            // txt_descuento
            // 
            this.txt_descuento.BackColor = System.Drawing.SystemColors.Window;
            this.txt_descuento.BorderColor = System.Drawing.Color.Crimson;
            this.txt_descuento.BorderFocusColor = System.Drawing.Color.Crimson;
            this.txt_descuento.BorderRadius = 0;
            this.txt_descuento.BorderSize = 2;
            this.txt_descuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_descuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_descuento.Location = new System.Drawing.Point(625, 173);
            this.txt_descuento.Margin = new System.Windows.Forms.Padding(4);
            this.txt_descuento.Multiline = false;
            this.txt_descuento.Name = "txt_descuento";
            this.txt_descuento.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_descuento.PasswordChar = false;
            this.txt_descuento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_descuento.PlaceholderText = "";
            this.txt_descuento.Size = new System.Drawing.Size(213, 31);
            this.txt_descuento.TabIndex = 17;
            this.txt_descuento.Texts = "";
            this.txt_descuento.UnderlinedStyle = false;
            this.txt_descuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_descuento_KeyPress);
            // 
            // cbox_iva
            // 
            this.cbox_iva.BackColor = System.Drawing.Color.Crimson;
            this.cbox_iva.BorderColor = System.Drawing.Color.GhostWhite;
            this.cbox_iva.BorderSize = 1;
            this.cbox_iva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbox_iva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbox_iva.ForeColor = System.Drawing.Color.DimGray;
            this.cbox_iva.IconColor = System.Drawing.Color.GhostWhite;
            this.cbox_iva.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbox_iva.ListTextColor = System.Drawing.Color.DimGray;
            this.cbox_iva.Location = new System.Drawing.Point(625, 95);
            this.cbox_iva.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbox_iva.Name = "cbox_iva";
            this.cbox_iva.Padding = new System.Windows.Forms.Padding(1);
            this.cbox_iva.Size = new System.Drawing.Size(213, 30);
            this.cbox_iva.TabIndex = 13;
            this.cbox_iva.Texts = "";
            // 
            // txt_precio2
            // 
            this.txt_precio2.BackColor = System.Drawing.SystemColors.Window;
            this.txt_precio2.BorderColor = System.Drawing.Color.Crimson;
            this.txt_precio2.BorderFocusColor = System.Drawing.Color.Crimson;
            this.txt_precio2.BorderRadius = 0;
            this.txt_precio2.BorderSize = 2;
            this.txt_precio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_precio2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_precio2.Location = new System.Drawing.Point(340, 173);
            this.txt_precio2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_precio2.Multiline = false;
            this.txt_precio2.Name = "txt_precio2";
            this.txt_precio2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_precio2.PasswordChar = false;
            this.txt_precio2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_precio2.PlaceholderText = "";
            this.txt_precio2.Size = new System.Drawing.Size(213, 31);
            this.txt_precio2.TabIndex = 16;
            this.txt_precio2.Texts = "";
            this.txt_precio2.UnderlinedStyle = false;
            this.txt_precio2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio2_KeyPress);
            // 
            // txt_precio
            // 
            this.txt_precio.BackColor = System.Drawing.SystemColors.Window;
            this.txt_precio.BorderColor = System.Drawing.Color.Crimson;
            this.txt_precio.BorderFocusColor = System.Drawing.Color.Crimson;
            this.txt_precio.BorderRadius = 0;
            this.txt_precio.BorderSize = 2;
            this.txt_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_precio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_precio.Location = new System.Drawing.Point(340, 94);
            this.txt_precio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_precio.Multiline = false;
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_precio.PasswordChar = false;
            this.txt_precio.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_precio.PlaceholderText = "";
            this.txt_precio.Size = new System.Drawing.Size(213, 31);
            this.txt_precio.TabIndex = 15;
            this.txt_precio.Texts = "";
            this.txt_precio.UnderlinedStyle = false;
            this.txt_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_KeyPress);
            // 
            // txt_ganancia
            // 
            this.txt_ganancia.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ganancia.BorderColor = System.Drawing.Color.Crimson;
            this.txt_ganancia.BorderFocusColor = System.Drawing.Color.Crimson;
            this.txt_ganancia.BorderRadius = 0;
            this.txt_ganancia.BorderSize = 2;
            this.txt_ganancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_ganancia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ganancia.Location = new System.Drawing.Point(8, 173);
            this.txt_ganancia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ganancia.Multiline = false;
            this.txt_ganancia.Name = "txt_ganancia";
            this.txt_ganancia.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_ganancia.PasswordChar = false;
            this.txt_ganancia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_ganancia.PlaceholderText = "";
            this.txt_ganancia.Size = new System.Drawing.Size(213, 31);
            this.txt_ganancia.TabIndex = 14;
            this.txt_ganancia.Texts = "";
            this.txt_ganancia.UnderlinedStyle = false;
            this.txt_ganancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ganancia_KeyPress);
            // 
            // txt_costo
            // 
            this.txt_costo.BackColor = System.Drawing.SystemColors.Window;
            this.txt_costo.BorderColor = System.Drawing.Color.Crimson;
            this.txt_costo.BorderFocusColor = System.Drawing.Color.Crimson;
            this.txt_costo.BorderRadius = 0;
            this.txt_costo.BorderSize = 2;
            this.txt_costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_costo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_costo.Location = new System.Drawing.Point(8, 83);
            this.txt_costo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_costo.Multiline = false;
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_costo.PasswordChar = false;
            this.txt_costo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_costo.PlaceholderText = "";
            this.txt_costo.Size = new System.Drawing.Size(213, 31);
            this.txt_costo.TabIndex = 13;
            this.txt_costo.Texts = "";
            this.txt_costo.UnderlinedStyle = false;
            this.txt_costo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_costo_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gold;
            this.label10.Location = new System.Drawing.Point(620, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(239, 26);
            this.label10.TabIndex = 11;
            this.label10.Text = "CONDICIÓN DE IVA (%)";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(620, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "DESC. MAXIMO";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(335, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 26);
            this.label7.TabIndex = 7;
            this.label7.Text = "PRECIO 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(3, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 26);
            this.label8.TabIndex = 3;
            this.label8.Text = "GANANCIA EN (%)";
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
            this.panel_desc.Controls.Add(this.cbox_proveedor);
            this.panel_desc.Controls.Add(this.lbl_proveedor);
            this.panel_desc.Controls.Add(this.lbl_descrip);
            this.panel_desc.Controls.Add(this.cbox_tipo);
            this.panel_desc.Controls.Add(this.lbl_cantprod);
            this.panel_desc.Controls.Add(this.txt_cod);
            this.panel_desc.Controls.Add(this.txt_cant);
            this.panel_desc.Controls.Add(this.lbl_cod);
            this.panel_desc.Controls.Add(this.lbl_desc);
            this.panel_desc.Controls.Add(this.txt_cod2);
            this.panel_desc.Controls.Add(this.txt_desc);
            this.panel_desc.Controls.Add(this.lbl_cod2);
            this.panel_desc.Controls.Add(this.lbl_tipoprod);
            this.panel_desc.Location = new System.Drawing.Point(3, 3);
            this.panel_desc.Name = "panel_desc";
            this.panel_desc.Size = new System.Drawing.Size(859, 216);
            this.panel_desc.TabIndex = 0;
            // 
            // cbox_proveedor
            // 
            this.cbox_proveedor.BackColor = System.Drawing.Color.Crimson;
            this.cbox_proveedor.BorderColor = System.Drawing.Color.GhostWhite;
            this.cbox_proveedor.BorderSize = 1;
            this.cbox_proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbox_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbox_proveedor.ForeColor = System.Drawing.Color.DimGray;
            this.cbox_proveedor.IconColor = System.Drawing.Color.GhostWhite;
            this.cbox_proveedor.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbox_proveedor.ListTextColor = System.Drawing.Color.DimGray;
            this.cbox_proveedor.Location = new System.Drawing.Point(616, 172);
            this.cbox_proveedor.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbox_proveedor.Name = "cbox_proveedor";
            this.cbox_proveedor.Padding = new System.Windows.Forms.Padding(1);
            this.cbox_proveedor.Size = new System.Drawing.Size(213, 30);
            this.cbox_proveedor.TabIndex = 11;
            this.cbox_proveedor.Texts = "";
            // 
            // lbl_proveedor
            // 
            this.lbl_proveedor.AutoSize = true;
            this.lbl_proveedor.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_proveedor.ForeColor = System.Drawing.Color.Gold;
            this.lbl_proveedor.Location = new System.Drawing.Point(611, 143);
            this.lbl_proveedor.Name = "lbl_proveedor";
            this.lbl_proveedor.Size = new System.Drawing.Size(133, 26);
            this.lbl_proveedor.TabIndex = 12;
            this.lbl_proveedor.Text = "PROVEEDOR";
            // 
            // lbl_descrip
            // 
            this.lbl_descrip.AutoSize = true;
            this.lbl_descrip.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descrip.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_descrip.Location = new System.Drawing.Point(3, 10);
            this.lbl_descrip.Name = "lbl_descrip";
            this.lbl_descrip.Size = new System.Drawing.Size(304, 26);
            this.lbl_descrip.TabIndex = 10;
            this.lbl_descrip.Text = "DESCRIPCIÓN DEL PRODUCTO";
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
            // txt_cod
            // 
            this.txt_cod.BackColor = System.Drawing.SystemColors.Window;
            this.txt_cod.BorderColor = System.Drawing.Color.Crimson;
            this.txt_cod.BorderFocusColor = System.Drawing.Color.Crimson;
            this.txt_cod.BorderRadius = 0;
            this.txt_cod.BorderSize = 2;
            this.txt_cod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_cod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_cod.Location = new System.Drawing.Point(8, 83);
            this.txt_cod.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cod.Multiline = false;
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_cod.PasswordChar = false;
            this.txt_cod.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_cod.PlaceholderText = "";
            this.txt_cod.Size = new System.Drawing.Size(213, 31);
            this.txt_cod.TabIndex = 0;
            this.txt_cod.Texts = "";
            this.txt_cod.UnderlinedStyle = false;
            this.txt_cod._TextChanged += new System.EventHandler(this.txt_cod__TextChanged);
            this.txt_cod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cod_KeyPress);
            // 
            // txt_cant
            // 
            this.txt_cant.BackColor = System.Drawing.SystemColors.Window;
            this.txt_cant.BorderColor = System.Drawing.Color.Crimson;
            this.txt_cant.BorderFocusColor = System.Drawing.Color.Crimson;
            this.txt_cant.BorderRadius = 0;
            this.txt_cant.BorderSize = 2;
            this.txt_cant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_cant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_cant.Location = new System.Drawing.Point(616, 83);
            this.txt_cant.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cant.Multiline = false;
            this.txt_cant.Name = "txt_cant";
            this.txt_cant.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_cant.PasswordChar = false;
            this.txt_cant.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_cant.PlaceholderText = "";
            this.txt_cant.Size = new System.Drawing.Size(213, 31);
            this.txt_cant.TabIndex = 8;
            this.txt_cant.Texts = "";
            this.txt_cant.UnderlinedStyle = false;
            this.txt_cant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cant_KeyPress);
            // 
            // lbl_cod
            // 
            this.lbl_cod.AutoSize = true;
            this.lbl_cod.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cod.ForeColor = System.Drawing.Color.Gold;
            this.lbl_cod.Location = new System.Drawing.Point(3, 53);
            this.lbl_cod.Name = "lbl_cod";
            this.lbl_cod.Size = new System.Drawing.Size(111, 26);
            this.lbl_cod.TabIndex = 1;
            this.lbl_cod.Text = "CODIGO 1";
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
            // txt_cod2
            // 
            this.txt_cod2.BackColor = System.Drawing.SystemColors.Window;
            this.txt_cod2.BorderColor = System.Drawing.Color.Crimson;
            this.txt_cod2.BorderFocusColor = System.Drawing.Color.Crimson;
            this.txt_cod2.BorderRadius = 0;
            this.txt_cod2.BorderSize = 2;
            this.txt_cod2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_cod2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_cod2.Location = new System.Drawing.Point(8, 172);
            this.txt_cod2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cod2.Multiline = false;
            this.txt_cod2.Name = "txt_cod2";
            this.txt_cod2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_cod2.PasswordChar = false;
            this.txt_cod2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_cod2.PlaceholderText = "";
            this.txt_cod2.Size = new System.Drawing.Size(213, 31);
            this.txt_cod2.TabIndex = 2;
            this.txt_cod2.Texts = "";
            this.txt_cod2.UnderlinedStyle = false;
            this.txt_cod2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cod2_KeyPress);
            // 
            // txt_desc
            // 
            this.txt_desc.BackColor = System.Drawing.SystemColors.Window;
            this.txt_desc.BorderColor = System.Drawing.Color.Crimson;
            this.txt_desc.BorderFocusColor = System.Drawing.Color.Crimson;
            this.txt_desc.BorderRadius = 0;
            this.txt_desc.BorderSize = 2;
            this.txt_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_desc.Location = new System.Drawing.Point(311, 172);
            this.txt_desc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_desc.Multiline = false;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_desc.PasswordChar = false;
            this.txt_desc.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_desc.PlaceholderText = "";
            this.txt_desc.Size = new System.Drawing.Size(213, 31);
            this.txt_desc.TabIndex = 6;
            this.txt_desc.Texts = "";
            this.txt_desc.UnderlinedStyle = false;
            this.txt_desc._TextChanged += new System.EventHandler(this.txt_desc__TextChanged);
            // 
            // lbl_cod2
            // 
            this.lbl_cod2.AutoSize = true;
            this.lbl_cod2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cod2.ForeColor = System.Drawing.Color.Gold;
            this.lbl_cod2.Location = new System.Drawing.Point(3, 142);
            this.lbl_cod2.Name = "lbl_cod2";
            this.lbl_cod2.Size = new System.Drawing.Size(111, 26);
            this.lbl_cod2.TabIndex = 3;
            this.lbl_cod2.Text = "CODIGO 2";
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
            // formProducts2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 647);
            this.ControlBox = false;
            this.Controls.Add(this.panel_main);
            this.Name = "formProducts2";
            this.Text = "Crear Producto";
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.panel_crimactividad.ResumeLayout(false);
            this.panel_actividad.ResumeLayout(false);
            this.panel_actividad.PerformLayout();
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
        private CustomBox.RJControls.RJTextBox txt_cod;
        private System.Windows.Forms.Label lbl_tipoprod;
        private CustomBox.RJControls.RJComboBox cbox_tipo;
        private System.Windows.Forms.Label lbl_cod2;
        private CustomBox.RJControls.RJTextBox txt_cod2;
        private System.Windows.Forms.Panel panel_crimdesc;
        private System.Windows.Forms.Label lbl_cantprod;
        private CustomBox.RJControls.RJTextBox txt_cant;
        private System.Windows.Forms.Label lbl_desc;
        private CustomBox.RJControls.RJTextBox txt_desc;
        private System.Windows.Forms.Panel panel_desc;
        private System.Windows.Forms.Panel panel_crimconfg;
        private System.Windows.Forms.Panel panel_config;
        private System.Windows.Forms.Label lbl_config;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_descrip;
        private CustomBox.RJControls.RJTextBox txt_precio2;
        private CustomBox.RJControls.RJTextBox txt_precio;
        private CustomBox.RJControls.RJTextBox txt_ganancia;
        private CustomBox.RJControls.RJTextBox txt_costo;
        private System.Windows.Forms.Label label10;
        private CustomBox.RJControls.RJComboBox cbox_proveedor;
        private System.Windows.Forms.Label lbl_proveedor;
        private System.Windows.Forms.Panel panel_crimactividad;
        private System.Windows.Forms.Panel panel_actividad;
        private System.Windows.Forms.Label lbl_actividad;
        private CustomBox.RJControls.RJTextBox txt_descuento;
        private CustomBox.RJControls.RJComboBox cbox_iva;
        private CustomBox.RJControls.RJButton btn_guardar;
        private CustomBox.RJControls.RJButton btn_cancelar;
        private System.Windows.Forms.CheckBox cb_res;
        private System.Windows.Forms.CheckBox cb_applyion;
        private System.Windows.Forms.CheckBox cb_fraccion;
        private System.Windows.Forms.CheckBox cb_active;
    }
}