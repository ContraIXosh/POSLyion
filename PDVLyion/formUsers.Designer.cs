namespace PDCLyion
{
    partial class formUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUsers));
            this.panel_main = new System.Windows.Forms.Panel();
            this.combo_rol = new System.Windows.Forms.Panel();
            this.btn_deshacer = new CustomBox.RJControls.RJButton();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_rol = new System.Windows.Forms.Label();
            this.cbo_estado = new RJCodeAdvance.RJControls.RJComboBox();
            this.cbo_rol = new RJCodeAdvance.RJControls.RJComboBox();
            this.txt_id = new RJCodeAdvance.RJControls.RJTextBox();
            this.txt_pass = new CustomBox.RJControls.RJTextBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txt_username = new CustomBox.RJControls.RJTextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.txt_tel = new CustomBox.RJControls.RJTextBox();
            this.btn_limpiar = new CustomBox.RJControls.RJButton();
            this.btn_guardar = new CustomBox.RJControls.RJButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_dni = new CustomBox.RJControls.RJTextBox();
            this.txt_correo = new CustomBox.RJControls.RJTextBox();
            this.txt_nombre_completo = new CustomBox.RJControls.RJTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_visualizarUser = new RJCodeAdvance.RJControls.RJButton();
            this.rjButton2 = new RJCodeAdvance.RJControls.RJButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_main.SuspendLayout();
            this.combo_rol.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.AutoSize = true;
            this.panel_main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_main.Controls.Add(this.combo_rol);
            this.panel_main.Controls.Add(this.btn_visualizarUser);
            this.panel_main.Controls.Add(this.rjButton2);
            this.panel_main.Controls.Add(this.panel3);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(982, 537);
            this.panel_main.TabIndex = 2;
            // 
            // combo_rol
            // 
            this.combo_rol.BackColor = System.Drawing.Color.DarkRed;
            this.combo_rol.Controls.Add(this.btn_deshacer);
            this.combo_rol.Controls.Add(this.lbl_estado);
            this.combo_rol.Controls.Add(this.lbl_rol);
            this.combo_rol.Controls.Add(this.cbo_estado);
            this.combo_rol.Controls.Add(this.cbo_rol);
            this.combo_rol.Controls.Add(this.txt_id);
            this.combo_rol.Controls.Add(this.txt_pass);
            this.combo_rol.Controls.Add(this.lbl_pass);
            this.combo_rol.Controls.Add(this.txt_username);
            this.combo_rol.Controls.Add(this.lbl_username);
            this.combo_rol.Controls.Add(this.txt_tel);
            this.combo_rol.Controls.Add(this.btn_limpiar);
            this.combo_rol.Controls.Add(this.btn_guardar);
            this.combo_rol.Controls.Add(this.label6);
            this.combo_rol.Controls.Add(this.txt_dni);
            this.combo_rol.Controls.Add(this.txt_correo);
            this.combo_rol.Controls.Add(this.txt_nombre_completo);
            this.combo_rol.Controls.Add(this.label5);
            this.combo_rol.Controls.Add(this.label3);
            this.combo_rol.Controls.Add(this.label7);
            this.combo_rol.Location = new System.Drawing.Point(258, 15);
            this.combo_rol.Name = "combo_rol";
            this.combo_rol.Size = new System.Drawing.Size(695, 377);
            this.combo_rol.TabIndex = 10;
            // 
            // btn_deshacer
            // 
            this.btn_deshacer.BackColor = System.Drawing.Color.Gold;
            this.btn_deshacer.BackgroundColor = System.Drawing.Color.Gold;
            this.btn_deshacer.BorderColor = System.Drawing.Color.Black;
            this.btn_deshacer.BorderRadius = 10;
            this.btn_deshacer.BorderSize = 2;
            this.btn_deshacer.FlatAppearance.BorderSize = 0;
            this.btn_deshacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deshacer.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deshacer.ForeColor = System.Drawing.Color.Black;
            this.btn_deshacer.Location = new System.Drawing.Point(283, 322);
            this.btn_deshacer.Name = "btn_deshacer";
            this.btn_deshacer.Size = new System.Drawing.Size(148, 52);
            this.btn_deshacer.TabIndex = 37;
            this.btn_deshacer.Text = "DESHACER CAMBIOS";
            this.btn_deshacer.TextColor = System.Drawing.Color.Black;
            this.btn_deshacer.UseVisualStyleBackColor = false;
            this.btn_deshacer.Click += new System.EventHandler(this.btn_deshacer_Click);
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.ForeColor = System.Drawing.Color.Gold;
            this.lbl_estado.Location = new System.Drawing.Point(385, 195);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(100, 28);
            this.lbl_estado.TabIndex = 36;
            this.lbl_estado.Text = "ESTADO";
            // 
            // lbl_rol
            // 
            this.lbl_rol.AutoSize = true;
            this.lbl_rol.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rol.ForeColor = System.Drawing.Color.Gold;
            this.lbl_rol.Location = new System.Drawing.Point(29, 195);
            this.lbl_rol.Name = "lbl_rol";
            this.lbl_rol.Size = new System.Drawing.Size(55, 28);
            this.lbl_rol.TabIndex = 35;
            this.lbl_rol.Text = "ROL";
            // 
            // cbo_estado
            // 
            this.cbo_estado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_estado.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbo_estado.BorderSize = 1;
            this.cbo_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbo_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbo_estado.ForeColor = System.Drawing.Color.DimGray;
            this.cbo_estado.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbo_estado.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbo_estado.ListTextColor = System.Drawing.Color.DimGray;
            this.cbo_estado.Location = new System.Drawing.Point(390, 226);
            this.cbo_estado.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbo_estado.Name = "cbo_estado";
            this.cbo_estado.Padding = new System.Windows.Forms.Padding(1);
            this.cbo_estado.Size = new System.Drawing.Size(245, 30);
            this.cbo_estado.TabIndex = 34;
            this.cbo_estado.Texts = "";
            // 
            // cbo_rol
            // 
            this.cbo_rol.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_rol.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbo_rol.BorderSize = 1;
            this.cbo_rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbo_rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbo_rol.ForeColor = System.Drawing.Color.DimGray;
            this.cbo_rol.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbo_rol.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbo_rol.ListTextColor = System.Drawing.Color.DimGray;
            this.cbo_rol.Location = new System.Drawing.Point(35, 226);
            this.cbo_rol.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbo_rol.Name = "cbo_rol";
            this.cbo_rol.Padding = new System.Windows.Forms.Padding(1);
            this.cbo_rol.Size = new System.Drawing.Size(249, 30);
            this.cbo_rol.TabIndex = 33;
            this.cbo_rol.Texts = "";
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.SystemColors.Window;
            this.txt_id.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_id.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_id.BorderRadius = 0;
            this.txt_id.BorderSize = 2;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_id.Location = new System.Drawing.Point(35, 275);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Multiline = false;
            this.txt_id.Name = "txt_id";
            this.txt_id.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_id.PasswordChar = false;
            this.txt_id.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_id.PlaceholderText = "";
            this.txt_id.Size = new System.Drawing.Size(40, 31);
            this.txt_id.TabIndex = 32;
            this.txt_id.Texts = "0";
            this.txt_id.UnderlinedStyle = false;
            this.txt_id.Visible = false;
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.SystemColors.Window;
            this.txt_pass.BorderColor = System.Drawing.Color.DarkViolet;
            this.txt_pass.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_pass.BorderRadius = 0;
            this.txt_pass.BorderSize = 2;
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_pass.Location = new System.Drawing.Point(389, 160);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pass.Multiline = false;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_pass.PasswordChar = false;
            this.txt_pass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_pass.PlaceholderText = "";
            this.txt_pass.Size = new System.Drawing.Size(250, 31);
            this.txt_pass.TabIndex = 30;
            this.txt_pass.Texts = "";
            this.txt_pass.UnderlinedStyle = false;
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.ForeColor = System.Drawing.Color.Gold;
            this.lbl_pass.Location = new System.Drawing.Point(385, 136);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(164, 28);
            this.lbl_pass.TabIndex = 31;
            this.lbl_pass.Text = "CONTRASEÑA";
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.SystemColors.Window;
            this.txt_username.BorderColor = System.Drawing.Color.DarkViolet;
            this.txt_username.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_username.BorderRadius = 0;
            this.txt_username.BorderSize = 2;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_username.Location = new System.Drawing.Point(388, 101);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_username.Multiline = false;
            this.txt_username.Name = "txt_username";
            this.txt_username.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_username.PasswordChar = false;
            this.txt_username.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_username.PlaceholderText = "";
            this.txt_username.Size = new System.Drawing.Size(250, 31);
            this.txt_username.TabIndex = 28;
            this.txt_username.Texts = "";
            this.txt_username.UnderlinedStyle = false;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.Gold;
            this.lbl_username.Location = new System.Drawing.Point(384, 77);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(251, 28);
            this.lbl_username.TabIndex = 29;
            this.lbl_username.Text = "NOMBRE DE USUARIO";
            // 
            // txt_tel
            // 
            this.txt_tel.BackColor = System.Drawing.SystemColors.Window;
            this.txt_tel.BorderColor = System.Drawing.Color.DarkViolet;
            this.txt_tel.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_tel.BorderRadius = 0;
            this.txt_tel.BorderSize = 2;
            this.txt_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_tel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_tel.Location = new System.Drawing.Point(35, 160);
            this.txt_tel.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tel.Multiline = false;
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_tel.PasswordChar = false;
            this.txt_tel.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_tel.PlaceholderText = "";
            this.txt_tel.Size = new System.Drawing.Size(250, 31);
            this.txt_tel.TabIndex = 25;
            this.txt_tel.Texts = "";
            this.txt_tel.UnderlinedStyle = false;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.Gold;
            this.btn_limpiar.BackgroundColor = System.Drawing.Color.Gold;
            this.btn_limpiar.BorderColor = System.Drawing.Color.Black;
            this.btn_limpiar.BorderRadius = 10;
            this.btn_limpiar.BorderSize = 2;
            this.btn_limpiar.FlatAppearance.BorderSize = 0;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.Color.Black;
            this.btn_limpiar.Location = new System.Drawing.Point(460, 322);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(148, 52);
            this.btn_limpiar.TabIndex = 24;
            this.btn_limpiar.Text = "LIMPIAR CAMPOS";
            this.btn_limpiar.TextColor = System.Drawing.Color.Black;
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Gold;
            this.btn_guardar.BackgroundColor = System.Drawing.Color.Gold;
            this.btn_guardar.BorderColor = System.Drawing.Color.Black;
            this.btn_guardar.BorderRadius = 10;
            this.btn_guardar.BorderSize = 2;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.Black;
            this.btn_guardar.Location = new System.Drawing.Point(106, 322);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(148, 52);
            this.btn_guardar.TabIndex = 23;
            this.btn_guardar.Text = "GUARDAR";
            this.btn_guardar.TextColor = System.Drawing.Color.Black;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(30, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "NUMERO DE TELEFONO";
            // 
            // txt_dni
            // 
            this.txt_dni.BackColor = System.Drawing.SystemColors.Window;
            this.txt_dni.BorderColor = System.Drawing.Color.DarkViolet;
            this.txt_dni.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_dni.BorderRadius = 0;
            this.txt_dni.BorderSize = 2;
            this.txt_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_dni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_dni.Location = new System.Drawing.Point(35, 101);
            this.txt_dni.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dni.Multiline = false;
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_dni.PasswordChar = false;
            this.txt_dni.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_dni.PlaceholderText = "";
            this.txt_dni.Size = new System.Drawing.Size(250, 31);
            this.txt_dni.TabIndex = 13;
            this.txt_dni.Texts = "";
            this.txt_dni.UnderlinedStyle = false;
            // 
            // txt_correo
            // 
            this.txt_correo.BackColor = System.Drawing.SystemColors.Window;
            this.txt_correo.BorderColor = System.Drawing.Color.DarkViolet;
            this.txt_correo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_correo.BorderRadius = 0;
            this.txt_correo.BorderSize = 2;
            this.txt_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_correo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_correo.Location = new System.Drawing.Point(388, 42);
            this.txt_correo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_correo.Multiline = false;
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_correo.PasswordChar = false;
            this.txt_correo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_correo.PlaceholderText = "";
            this.txt_correo.Size = new System.Drawing.Size(250, 31);
            this.txt_correo.TabIndex = 11;
            this.txt_correo.Texts = "";
            this.txt_correo.UnderlinedStyle = false;
            // 
            // txt_nombre_completo
            // 
            this.txt_nombre_completo.BackColor = System.Drawing.SystemColors.Window;
            this.txt_nombre_completo.BorderColor = System.Drawing.Color.DarkViolet;
            this.txt_nombre_completo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_nombre_completo.BorderRadius = 0;
            this.txt_nombre_completo.BorderSize = 2;
            this.txt_nombre_completo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_nombre_completo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nombre_completo.Location = new System.Drawing.Point(34, 42);
            this.txt_nombre_completo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre_completo.Multiline = false;
            this.txt_nombre_completo.Name = "txt_nombre_completo";
            this.txt_nombre_completo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_nombre_completo.PasswordChar = false;
            this.txt_nombre_completo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_nombre_completo.PlaceholderText = "";
            this.txt_nombre_completo.Size = new System.Drawing.Size(250, 31);
            this.txt_nombre_completo.TabIndex = 9;
            this.txt_nombre_completo.Texts = "";
            this.txt_nombre_completo.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(30, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 28);
            this.label5.TabIndex = 19;
            this.label5.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(30, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "NOMBRE COMPLETO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(383, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 28);
            this.label7.TabIndex = 22;
            this.label7.Text = "CORREO ELECTRONICO";
            // 
            // btn_visualizarUser
            // 
            this.btn_visualizarUser.BackColor = System.Drawing.Color.Transparent;
            this.btn_visualizarUser.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_visualizarUser.BorderColor = System.Drawing.Color.Gold;
            this.btn_visualizarUser.BorderRadius = 7;
            this.btn_visualizarUser.BorderSize = 2;
            this.btn_visualizarUser.FlatAppearance.BorderSize = 0;
            this.btn_visualizarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_visualizarUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_visualizarUser.ForeColor = System.Drawing.Color.Gold;
            this.btn_visualizarUser.Image = ((System.Drawing.Image)(resources.GetObject("btn_visualizarUser.Image")));
            this.btn_visualizarUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_visualizarUser.Location = new System.Drawing.Point(12, 15);
            this.btn_visualizarUser.Name = "btn_visualizarUser";
            this.btn_visualizarUser.Size = new System.Drawing.Size(220, 50);
            this.btn_visualizarUser.TabIndex = 8;
            this.btn_visualizarUser.Text = "VISUALIZAR USUARIOS";
            this.btn_visualizarUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_visualizarUser.TextColor = System.Drawing.Color.Gold;
            this.btn_visualizarUser.UseVisualStyleBackColor = false;
            this.btn_visualizarUser.Click += new System.EventHandler(this.btn_visualizarUser_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.Transparent;
            this.rjButton2.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton2.BorderColor = System.Drawing.Color.Chartreuse;
            this.rjButton2.BorderRadius = 7;
            this.rjButton2.BorderSize = 2;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.Lime;
            this.rjButton2.Location = new System.Drawing.Point(813, 398);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(150, 40);
            this.rjButton2.TabIndex = 5;
            this.rjButton2.Text = "Regresar";
            this.rjButton2.TextColor = System.Drawing.Color.Lime;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Khaki;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 459);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(987, 18);
            this.panel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(633, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ultimo chequeo: 10:06:12  - 20/09/2024";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(863, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actualizacion: v1.0.0.5";
            // 
            // formUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 537);
            this.Controls.Add(this.panel_main);
            this.Name = "formUsers";
            this.Text = "formUsers";
            this.Load += new System.EventHandler(this.formUsers_Load);
            this.panel_main.ResumeLayout(false);
            this.combo_rol.ResumeLayout(false);
            this.combo_rol.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel combo_rol;
        private CustomBox.RJControls.RJTextBox txt_tel;
        private CustomBox.RJControls.RJButton btn_limpiar;
        private CustomBox.RJControls.RJButton btn_guardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private CustomBox.RJControls.RJTextBox txt_dni;
        private CustomBox.RJControls.RJTextBox txt_correo;
        private CustomBox.RJControls.RJTextBox txt_nombre_completo;
        private RJCodeAdvance.RJControls.RJButton btn_visualizarUser;
        private RJCodeAdvance.RJControls.RJButton rjButton2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomBox.RJControls.RJTextBox txt_pass;
        private System.Windows.Forms.Label lbl_pass;
        private CustomBox.RJControls.RJTextBox txt_username;
        private System.Windows.Forms.Label lbl_username;
        private RJCodeAdvance.RJControls.RJTextBox txt_id;
        private RJCodeAdvance.RJControls.RJComboBox cbo_estado;
        private RJCodeAdvance.RJControls.RJComboBox cbo_rol;
        private System.Windows.Forms.Label lbl_rol;
        private System.Windows.Forms.Label lbl_estado;
        private CustomBox.RJControls.RJButton btn_deshacer;
    }
}