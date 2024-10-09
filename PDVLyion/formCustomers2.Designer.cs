namespace PDCLyion
{
    partial class formCustomers2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCustomers2));
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_footer = new System.Windows.Forms.Panel();
            this.panel_update = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_viewvendedor = new RJCodeAdvance.RJControls.RJButton();
            this.btn_addvendedor = new RJCodeAdvance.RJControls.RJButton();
            this.btn_back = new RJCodeAdvance.RJControls.RJButton();
            this.panel_addclient = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_state = new System.Windows.Forms.Label();
            this.cbo_estado = new RJCodeAdvance.RJControls.RJComboBox();
            this.txt_id = new CustomBox.RJControls.RJTextBox();
            this.btn_borrar = new CustomBox.RJControls.RJButton();
            this.btn_guardar = new CustomBox.RJControls.RJButton();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.lbl_full_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tel = new CustomBox.RJControls.RJTextBox();
            this.txt_correo = new CustomBox.RJControls.RJTextBox();
            this.txt_dni = new CustomBox.RJControls.RJTextBox();
            this.txt_nombre_completo = new CustomBox.RJControls.RJTextBox();
            this.panel_main.SuspendLayout();
            this.panel_footer.SuspendLayout();
            this.panel_update.SuspendLayout();
            this.panel_addclient.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_main.Controls.Add(this.panel_footer);
            this.panel_main.Controls.Add(this.panel_addclient);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(982, 537);
            this.panel_main.TabIndex = 0;
            // 
            // panel_footer
            // 
            this.panel_footer.Controls.Add(this.panel_update);
            this.panel_footer.Controls.Add(this.btn_viewvendedor);
            this.panel_footer.Controls.Add(this.btn_addvendedor);
            this.panel_footer.Controls.Add(this.btn_back);
            this.panel_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_footer.Location = new System.Drawing.Point(0, 457);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(982, 80);
            this.panel_footer.TabIndex = 13;
            this.panel_footer.Resize += new System.EventHandler(this.panel_footer_Resize_1);
            // 
            // panel_update
            // 
            this.panel_update.BackColor = System.Drawing.Color.Khaki;
            this.panel_update.Controls.Add(this.label2);
            this.panel_update.Controls.Add(this.label1);
            this.panel_update.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_update.Location = new System.Drawing.Point(0, 62);
            this.panel_update.Name = "panel_update";
            this.panel_update.Size = new System.Drawing.Size(982, 18);
            this.panel_update.TabIndex = 24;
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
            // btn_viewvendedor
            // 
            this.btn_viewvendedor.BackColor = System.Drawing.Color.Transparent;
            this.btn_viewvendedor.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_viewvendedor.BorderColor = System.Drawing.Color.Gold;
            this.btn_viewvendedor.BorderRadius = 7;
            this.btn_viewvendedor.BorderSize = 2;
            this.btn_viewvendedor.FlatAppearance.BorderSize = 0;
            this.btn_viewvendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewvendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewvendedor.ForeColor = System.Drawing.Color.Gold;
            this.btn_viewvendedor.Image = ((System.Drawing.Image)(resources.GetObject("btn_viewvendedor.Image")));
            this.btn_viewvendedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_viewvendedor.Location = new System.Drawing.Point(215, 11);
            this.btn_viewvendedor.Name = "btn_viewvendedor";
            this.btn_viewvendedor.Size = new System.Drawing.Size(254, 40);
            this.btn_viewvendedor.TabIndex = 23;
            this.btn_viewvendedor.Text = "VISUALIZAR VENDEDORES";
            this.btn_viewvendedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_viewvendedor.TextColor = System.Drawing.Color.Gold;
            this.btn_viewvendedor.UseVisualStyleBackColor = false;
            this.btn_viewvendedor.Click += new System.EventHandler(this.btn_viewvendedor_Click_1);
            // 
            // btn_addvendedor
            // 
            this.btn_addvendedor.BackColor = System.Drawing.Color.Transparent;
            this.btn_addvendedor.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_addvendedor.BorderColor = System.Drawing.Color.ForestGreen;
            this.btn_addvendedor.BorderRadius = 7;
            this.btn_addvendedor.BorderSize = 2;
            this.btn_addvendedor.FlatAppearance.BorderSize = 0;
            this.btn_addvendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addvendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addvendedor.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_addvendedor.Image = ((System.Drawing.Image)(resources.GetObject("btn_addvendedor.Image")));
            this.btn_addvendedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addvendedor.Location = new System.Drawing.Point(7, 11);
            this.btn_addvendedor.Name = "btn_addvendedor";
            this.btn_addvendedor.Size = new System.Drawing.Size(202, 40);
            this.btn_addvendedor.TabIndex = 21;
            this.btn_addvendedor.Text = "AGREGAR CLIENTE";
            this.btn_addvendedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addvendedor.TextColor = System.Drawing.Color.ForestGreen;
            this.btn_addvendedor.UseVisualStyleBackColor = false;
            this.btn_addvendedor.Click += new System.EventHandler(this.btn_addvendedor_Click_1);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_back.BorderColor = System.Drawing.Color.Red;
            this.btn_back.BorderRadius = 7;
            this.btn_back.BorderSize = 2;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.Red;
            this.btn_back.Location = new System.Drawing.Point(825, 11);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(150, 40);
            this.btn_back.TabIndex = 22;
            this.btn_back.Text = "Regresar";
            this.btn_back.TextColor = System.Drawing.Color.Red;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click_1);
            // 
            // panel_addclient
            // 
            this.panel_addclient.BackColor = System.Drawing.Color.Indigo;
            this.panel_addclient.Controls.Add(this.panel1);
            this.panel_addclient.Controls.Add(this.lbl_state);
            this.panel_addclient.Controls.Add(this.cbo_estado);
            this.panel_addclient.Controls.Add(this.txt_id);
            this.panel_addclient.Controls.Add(this.btn_borrar);
            this.panel_addclient.Controls.Add(this.btn_guardar);
            this.panel_addclient.Controls.Add(this.lbl_email);
            this.panel_addclient.Controls.Add(this.lbl_tel);
            this.panel_addclient.Controls.Add(this.lbl_dni);
            this.panel_addclient.Controls.Add(this.lbl_full_name);
            this.panel_addclient.Controls.Add(this.label3);
            this.panel_addclient.Controls.Add(this.txt_tel);
            this.panel_addclient.Controls.Add(this.txt_correo);
            this.panel_addclient.Controls.Add(this.txt_dni);
            this.panel_addclient.Controls.Add(this.txt_nombre_completo);
            this.panel_addclient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_addclient.Location = new System.Drawing.Point(0, 0);
            this.panel_addclient.Name = "panel_addclient";
            this.panel_addclient.Size = new System.Drawing.Size(982, 537);
            this.panel_addclient.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 519);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 18);
            this.panel1.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(633, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ultimo chequeo: 10:06:12  - 20/09/2024";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(863, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Actualizacion: v1.0.0.5";
            // 
            // lbl_state
            // 
            this.lbl_state.AutoSize = true;
            this.lbl_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_state.ForeColor = System.Drawing.Color.Orange;
            this.lbl_state.Location = new System.Drawing.Point(694, 77);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(104, 25);
            this.lbl_state.TabIndex = 29;
            this.lbl_state.Text = "ESTADO";
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
            this.cbo_estado.Location = new System.Drawing.Point(699, 106);
            this.cbo_estado.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbo_estado.Name = "cbo_estado";
            this.cbo_estado.Padding = new System.Windows.Forms.Padding(1);
            this.cbo_estado.Size = new System.Drawing.Size(200, 30);
            this.cbo_estado.TabIndex = 28;
            this.cbo_estado.Texts = "";
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.SystemColors.Window;
            this.txt_id.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_id.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_id.BorderRadius = 0;
            this.txt_id.BorderSize = 2;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_id.Location = new System.Drawing.Point(38, 24);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_id.Multiline = false;
            this.txt_id.Name = "txt_id";
            this.txt_id.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_id.PasswordChar = false;
            this.txt_id.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_id.PlaceholderText = "";
            this.txt_id.Size = new System.Drawing.Size(45, 31);
            this.txt_id.TabIndex = 27;
            this.txt_id.Texts = "";
            this.txt_id.UnderlinedStyle = false;
            this.txt_id.Visible = false;
            // 
            // btn_borrar
            // 
            this.btn_borrar.BackColor = System.Drawing.Color.Gold;
            this.btn_borrar.BackgroundColor = System.Drawing.Color.Gold;
            this.btn_borrar.BorderColor = System.Drawing.Color.Black;
            this.btn_borrar.BorderRadius = 10;
            this.btn_borrar.BorderSize = 2;
            this.btn_borrar.FlatAppearance.BorderSize = 0;
            this.btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borrar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrar.ForeColor = System.Drawing.Color.Black;
            this.btn_borrar.Location = new System.Drawing.Point(215, 258);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(171, 41);
            this.btn_borrar.TabIndex = 26;
            this.btn_borrar.Text = "BORRAR";
            this.btn_borrar.TextColor = System.Drawing.Color.Black;
            this.btn_borrar.UseVisualStyleBackColor = false;
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
            this.btn_guardar.Location = new System.Drawing.Point(38, 258);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(171, 41);
            this.btn_guardar.TabIndex = 25;
            this.btn_guardar.Text = "GUARDAR";
            this.btn_guardar.TextColor = System.Drawing.Color.Black;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.Orange;
            this.lbl_email.Location = new System.Drawing.Point(392, 161);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(80, 25);
            this.lbl_email.TabIndex = 8;
            this.lbl_email.Text = "EMAIL";
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tel.ForeColor = System.Drawing.Color.Orange;
            this.lbl_tel.Location = new System.Drawing.Point(392, 77);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(133, 25);
            this.lbl_tel.TabIndex = 7;
            this.lbl_tel.Text = "TELEFONO";
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dni.ForeColor = System.Drawing.Color.Orange;
            this.lbl_dni.Location = new System.Drawing.Point(33, 161);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(50, 25);
            this.lbl_dni.TabIndex = 6;
            this.lbl_dni.Text = "DNI";
            // 
            // lbl_full_name
            // 
            this.lbl_full_name.AutoSize = true;
            this.lbl_full_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_full_name.ForeColor = System.Drawing.Color.Orange;
            this.lbl_full_name.Location = new System.Drawing.Point(33, 77);
            this.lbl_full_name.Name = "lbl_full_name";
            this.lbl_full_name.Size = new System.Drawing.Size(250, 25);
            this.lbl_full_name.TabIndex = 5;
            this.lbl_full_name.Text = "NOMBRE Y APELLIDO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(289, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(422, 55);
            this.label3.TabIndex = 4;
            this.label3.Text = "CREAR CLIENTE";
            // 
            // txt_tel
            // 
            this.txt_tel.BackColor = System.Drawing.SystemColors.Window;
            this.txt_tel.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_tel.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_tel.BorderRadius = 0;
            this.txt_tel.BorderSize = 2;
            this.txt_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_tel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_tel.Location = new System.Drawing.Point(397, 106);
            this.txt_tel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tel.Multiline = false;
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_tel.PasswordChar = false;
            this.txt_tel.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_tel.PlaceholderText = "";
            this.txt_tel.Size = new System.Drawing.Size(250, 31);
            this.txt_tel.TabIndex = 3;
            this.txt_tel.Texts = "";
            this.txt_tel.UnderlinedStyle = false;
            // 
            // txt_correo
            // 
            this.txt_correo.BackColor = System.Drawing.SystemColors.Window;
            this.txt_correo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_correo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_correo.BorderRadius = 0;
            this.txt_correo.BorderSize = 2;
            this.txt_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_correo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_correo.Location = new System.Drawing.Point(397, 190);
            this.txt_correo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_correo.Multiline = false;
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_correo.PasswordChar = false;
            this.txt_correo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_correo.PlaceholderText = "";
            this.txt_correo.Size = new System.Drawing.Size(250, 31);
            this.txt_correo.TabIndex = 2;
            this.txt_correo.Texts = "";
            this.txt_correo.UnderlinedStyle = false;
            // 
            // txt_dni
            // 
            this.txt_dni.BackColor = System.Drawing.SystemColors.Window;
            this.txt_dni.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_dni.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_dni.BorderRadius = 0;
            this.txt_dni.BorderSize = 2;
            this.txt_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_dni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_dni.Location = new System.Drawing.Point(38, 190);
            this.txt_dni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_dni.Multiline = false;
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_dni.PasswordChar = false;
            this.txt_dni.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_dni.PlaceholderText = "";
            this.txt_dni.Size = new System.Drawing.Size(250, 31);
            this.txt_dni.TabIndex = 1;
            this.txt_dni.Texts = "";
            this.txt_dni.UnderlinedStyle = false;
            // 
            // txt_nombre_completo
            // 
            this.txt_nombre_completo.BackColor = System.Drawing.SystemColors.Window;
            this.txt_nombre_completo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_nombre_completo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_nombre_completo.BorderRadius = 0;
            this.txt_nombre_completo.BorderSize = 2;
            this.txt_nombre_completo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_nombre_completo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nombre_completo.Location = new System.Drawing.Point(38, 106);
            this.txt_nombre_completo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nombre_completo.Multiline = false;
            this.txt_nombre_completo.Name = "txt_nombre_completo";
            this.txt_nombre_completo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_nombre_completo.PasswordChar = false;
            this.txt_nombre_completo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_nombre_completo.PlaceholderText = "";
            this.txt_nombre_completo.Size = new System.Drawing.Size(250, 31);
            this.txt_nombre_completo.TabIndex = 0;
            this.txt_nombre_completo.Texts = "";
            this.txt_nombre_completo.UnderlinedStyle = false;
            // 
            // formCustomers2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 537);
            this.Controls.Add(this.panel_main);
            this.Name = "formCustomers2";
            this.Text = "formCustomers2";
            this.Load += new System.EventHandler(this.formCustomers2_Load);
            this.panel_main.ResumeLayout(false);
            this.panel_footer.ResumeLayout(false);
            this.panel_update.ResumeLayout(false);
            this.panel_update.PerformLayout();
            this.panel_addclient.ResumeLayout(false);
            this.panel_addclient.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_addclient;
        private CustomBox.RJControls.RJTextBox txt_correo;
        private CustomBox.RJControls.RJTextBox txt_dni;
        private CustomBox.RJControls.RJTextBox txt_nombre_completo;
        private System.Windows.Forms.Label label3;
        private CustomBox.RJControls.RJTextBox txt_tel;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.Label lbl_full_name;
        private CustomBox.RJControls.RJButton btn_borrar;
        private CustomBox.RJControls.RJButton btn_guardar;
        private System.Windows.Forms.Panel panel_footer;
        private System.Windows.Forms.Panel panel_update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJButton btn_viewvendedor;
        private RJCodeAdvance.RJControls.RJButton btn_addvendedor;
        private RJCodeAdvance.RJControls.RJButton btn_back;
        private CustomBox.RJControls.RJTextBox txt_id;
        private System.Windows.Forms.Label lbl_state;
        private RJCodeAdvance.RJControls.RJComboBox cbo_estado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}