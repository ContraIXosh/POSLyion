namespace POSLyion
{
    partial class formUsuariosAlta
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
            this.panel_red = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.txt_nombre_completo = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_nombre_usuario = new System.Windows.Forms.TextBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.cbox_estado = new RJCodeAdvance.RJControls.RJComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_rol = new System.Windows.Forms.Label();
            this.cbox_roles = new RJCodeAdvance.RJControls.RJComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_reiniciar_datos = new RJCodeAdvance.RJControls.RJButton();
            this.btn_cerrar = new RJCodeAdvance.RJControls.RJButton();
            this.btn_guardar = new RJCodeAdvance.RJControls.RJButton();
            this.panel_main = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_crearuser = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_red.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_red
            // 
            this.panel_red.BackColor = System.Drawing.Color.Maroon;
            this.panel_red.ColumnCount = 1;
            this.panel_red.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_red.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.panel_red.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_red.Location = new System.Drawing.Point(0, 63);
            this.panel_red.Margin = new System.Windows.Forms.Padding(0);
            this.panel_red.Name = "panel_red";
            this.panel_red.RowCount = 1;
            this.panel_red.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_red.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 252F));
            this.panel_red.Size = new System.Drawing.Size(710, 252);
            this.panel_red.TabIndex = 44;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.txt_telefono, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.txt_dni, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.txt_nombre_completo, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt_correo, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt_nombre_usuario, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.lbl_estado, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.cbox_estado, 1, 7);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.lbl_rol, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.cbox_roles, 0, 7);
            this.tableLayoutPanel4.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbl_username, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.lbl_pass, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.txt_contraseña, 1, 5);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 8;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(710, 252);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.Location = new System.Drawing.Point(54, 158);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(246, 29);
            this.txt_telefono.TabIndex = 103;
            // 
            // txt_dni
            // 
            this.txt_dni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dni.Location = new System.Drawing.Point(54, 96);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(246, 29);
            this.txt_dni.TabIndex = 102;
            // 
            // txt_nombre_completo
            // 
            this.txt_nombre_completo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nombre_completo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_completo.Location = new System.Drawing.Point(54, 34);
            this.txt_nombre_completo.Name = "txt_nombre_completo";
            this.txt_nombre_completo.Size = new System.Drawing.Size(246, 29);
            this.txt_nombre_completo.TabIndex = 101;
            // 
            // txt_correo
            // 
            this.txt_correo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.Location = new System.Drawing.Point(409, 34);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(246, 29);
            this.txt_correo.TabIndex = 100;
            // 
            // txt_nombre_usuario
            // 
            this.txt_nombre_usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nombre_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_usuario.Location = new System.Drawing.Point(409, 96);
            this.txt_nombre_usuario.Name = "txt_nombre_usuario";
            this.txt_nombre_usuario.Size = new System.Drawing.Size(246, 29);
            this.txt_nombre_usuario.TabIndex = 99;
            // 
            // lbl_estado
            // 
            this.lbl_estado.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.ForeColor = System.Drawing.Color.Gold;
            this.lbl_estado.Location = new System.Drawing.Point(482, 189);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(100, 28);
            this.lbl_estado.TabIndex = 97;
            this.lbl_estado.Text = "ESTADO";
            // 
            // cbox_estado
            // 
            this.cbox_estado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbox_estado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbox_estado.BorderColor = System.Drawing.Color.DarkOrange;
            this.cbox_estado.BorderSize = 1;
            this.cbox_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbox_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbox_estado.ForeColor = System.Drawing.Color.DimGray;
            this.cbox_estado.IconColor = System.Drawing.Color.DarkOrange;
            this.cbox_estado.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbox_estado.ListTextColor = System.Drawing.Color.DimGray;
            this.cbox_estado.Location = new System.Drawing.Point(410, 220);
            this.cbox_estado.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbox_estado.Name = "cbox_estado";
            this.cbox_estado.Padding = new System.Windows.Forms.Padding(1);
            this.cbox_estado.Size = new System.Drawing.Size(245, 30);
            this.cbox_estado.TabIndex = 96;
            this.cbox_estado.Texts = "";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(59, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 28);
            this.label3.TabIndex = 78;
            this.label3.Text = "NOMBRE COMPLETO";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(150, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 28);
            this.label5.TabIndex = 80;
            this.label5.Text = "DNI";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(45, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 28);
            this.label6.TabIndex = 81;
            this.label6.Text = "NUMERO DE TELEFONO";
            // 
            // lbl_rol
            // 
            this.lbl_rol.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_rol.AutoSize = true;
            this.lbl_rol.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rol.ForeColor = System.Drawing.Color.Gold;
            this.lbl_rol.Location = new System.Drawing.Point(150, 189);
            this.lbl_rol.Name = "lbl_rol";
            this.lbl_rol.Size = new System.Drawing.Size(55, 28);
            this.lbl_rol.TabIndex = 89;
            this.lbl_rol.Text = "ROL";
            // 
            // cbox_roles
            // 
            this.cbox_roles.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbox_roles.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbox_roles.BorderColor = System.Drawing.Color.DarkOrange;
            this.cbox_roles.BorderSize = 1;
            this.cbox_roles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbox_roles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbox_roles.ForeColor = System.Drawing.Color.DimGray;
            this.cbox_roles.IconColor = System.Drawing.Color.DarkOrange;
            this.cbox_roles.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbox_roles.ListTextColor = System.Drawing.Color.DimGray;
            this.cbox_roles.Location = new System.Drawing.Point(53, 220);
            this.cbox_roles.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbox_roles.Name = "cbox_roles";
            this.cbox_roles.Padding = new System.Windows.Forms.Padding(1);
            this.cbox_roles.Size = new System.Drawing.Size(249, 30);
            this.cbox_roles.TabIndex = 88;
            this.cbox_roles.Texts = "";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(403, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 28);
            this.label7.TabIndex = 91;
            this.label7.Text = "CORREO ELECTRONICO";
            // 
            // lbl_username
            // 
            this.lbl_username.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.Gold;
            this.lbl_username.Location = new System.Drawing.Point(407, 65);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(251, 28);
            this.lbl_username.TabIndex = 93;
            this.lbl_username.Text = "NOMBRE DE USUARIO";
            // 
            // lbl_pass
            // 
            this.lbl_pass.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.ForeColor = System.Drawing.Color.Gold;
            this.lbl_pass.Location = new System.Drawing.Point(450, 127);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(164, 28);
            this.lbl_pass.TabIndex = 95;
            this.lbl_pass.Text = "CONTRASEÑA";
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contraseña.Location = new System.Drawing.Point(409, 158);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(246, 29);
            this.txt_contraseña.TabIndex = 98;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 315);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(710, 54);
            this.tableLayoutPanel1.TabIndex = 43;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Maroon;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.btn_reiniciar_datos, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_cerrar, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_guardar, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(710, 54);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // btn_reiniciar_datos
            // 
            this.btn_reiniciar_datos.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_reiniciar_datos.BackColor = System.Drawing.Color.Orange;
            this.btn_reiniciar_datos.BackgroundColor = System.Drawing.Color.Orange;
            this.btn_reiniciar_datos.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btn_reiniciar_datos.BorderRadius = 5;
            this.btn_reiniciar_datos.BorderSize = 2;
            this.btn_reiniciar_datos.FlatAppearance.BorderSize = 0;
            this.btn_reiniciar_datos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reiniciar_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reiniciar_datos.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_reiniciar_datos.Location = new System.Drawing.Point(245, 10);
            this.btn_reiniciar_datos.Name = "btn_reiniciar_datos";
            this.btn_reiniciar_datos.Size = new System.Drawing.Size(150, 33);
            this.btn_reiniciar_datos.TabIndex = 33;
            this.btn_reiniciar_datos.Text = "Reiniciar datos";
            this.btn_reiniciar_datos.TextColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_reiniciar_datos.UseVisualStyleBackColor = false;
            this.btn_reiniciar_datos.Click += new System.EventHandler(this.btn_reiniciar_datos_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_cerrar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_cerrar.BackgroundColor = System.Drawing.Color.DarkRed;
            this.btn_cerrar.BorderColor = System.Drawing.Color.Red;
            this.btn_cerrar.BorderRadius = 5;
            this.btn_cerrar.BorderSize = 2;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.DarkSalmon;
            this.btn_cerrar.Location = new System.Drawing.Point(557, 10);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(150, 33);
            this.btn_cerrar.TabIndex = 11;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.TextColor = System.Drawing.Color.DarkSalmon;
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_guardar.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_guardar.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.btn_guardar.BorderColor = System.Drawing.Color.ForestGreen;
            this.btn_guardar.BorderRadius = 5;
            this.btn_guardar.BorderSize = 2;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.PaleGreen;
            this.btn_guardar.Location = new System.Drawing.Point(401, 10);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(150, 33);
            this.btn_guardar.TabIndex = 12;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextColor = System.Drawing.Color.PaleGreen;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.Maroon;
            this.panel_main.ColumnCount = 1;
            this.panel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_main.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.panel_main.Controls.Add(this.panel_red, 0, 1);
            this.panel_main.Controls.Add(this.lbl_crearuser, 0, 0);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Margin = new System.Windows.Forms.Padding(0);
            this.panel_main.Name = "panel_main";
            this.panel_main.RowCount = 3;
            this.panel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.1046F));
            this.panel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.41839F));
            this.panel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.47702F));
            this.panel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_main.Size = new System.Drawing.Size(710, 369);
            this.panel_main.TabIndex = 0;
            // 
            // lbl_crearuser
            // 
            this.lbl_crearuser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_crearuser.AutoSize = true;
            this.lbl_crearuser.BackColor = System.Drawing.Color.Maroon;
            this.lbl_crearuser.Font = new System.Drawing.Font("FORESTS ITALIC PERSONAL USE", 50.24999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_crearuser.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_crearuser.Location = new System.Drawing.Point(174, 0);
            this.lbl_crearuser.Name = "lbl_crearuser";
            this.lbl_crearuser.Size = new System.Drawing.Size(361, 63);
            this.lbl_crearuser.TabIndex = 45;
            this.lbl_crearuser.Text = "CREAR USUARIO";
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
            // formUsuariosAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 369);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "formUsuariosAlta";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear un usuario";
            this.Load += new System.EventHandler(this.formUsuariosAlta_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formUsuariosAlta_KeyDown);
            this.panel_red.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel_red;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private RJCodeAdvance.RJControls.RJButton btn_cerrar;
        private RJCodeAdvance.RJControls.RJButton btn_guardar;
        private System.Windows.Forms.TableLayoutPanel panel_main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_rol;
        private RJCodeAdvance.RJControls.RJComboBox cbox_roles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_estado;
        private RJCodeAdvance.RJControls.RJComboBox cbox_estado;
        private System.Windows.Forms.Label lbl_crearuser;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.TextBox txt_nombre_completo;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_nombre_usuario;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private RJCodeAdvance.RJControls.RJButton btn_reiniciar_datos;
        private System.Windows.Forms.ErrorProvider errorProvider4;
    }
}