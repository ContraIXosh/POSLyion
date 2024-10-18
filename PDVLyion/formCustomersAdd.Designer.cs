namespace PDCLyion
{
    partial class formCustomersAdd
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
            this.panel_main = new System.Windows.Forms.TableLayoutPanel();
            this.panel_btttmm = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_cerrar = new RJCodeAdvance.RJControls.RJButton();
            this.btn_guardar = new RJCodeAdvance.RJControls.RJButton();
            this.panel_createclient = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_crearcliente = new System.Windows.Forms.Label();
            this.panel_create = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_full_name = new System.Windows.Forms.Label();
            this.txt_nombre_completo = new CustomBox.RJControls.RJTextBox();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.txt_dni = new CustomBox.RJControls.RJTextBox();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.txt_tel = new CustomBox.RJControls.RJTextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_correo = new CustomBox.RJControls.RJTextBox();
            this.lbl_state = new System.Windows.Forms.Label();
            this.cbo_estado = new RJCodeAdvance.RJControls.RJComboBox();
            this.txt_id = new CustomBox.RJControls.RJTextBox();
            this.panel_main.SuspendLayout();
            this.panel_btttmm.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel_createclient.SuspendLayout();
            this.panel_create.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_main.ColumnCount = 1;
            this.panel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_main.Controls.Add(this.panel_btttmm, 0, 1);
            this.panel_main.Controls.Add(this.panel_createclient, 0, 0);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Margin = new System.Windows.Forms.Padding(0);
            this.panel_main.Name = "panel_main";
            this.panel_main.RowCount = 2;
            this.panel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.panel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.panel_main.Size = new System.Drawing.Size(714, 406);
            this.panel_main.TabIndex = 0;
            // 
            // panel_btttmm
            // 
            this.panel_btttmm.ColumnCount = 1;
            this.panel_btttmm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_btttmm.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.panel_btttmm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_btttmm.Location = new System.Drawing.Point(0, 345);
            this.panel_btttmm.Margin = new System.Windows.Forms.Padding(0);
            this.panel_btttmm.Name = "panel_btttmm";
            this.panel_btttmm.RowCount = 1;
            this.panel_btttmm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_btttmm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.panel_btttmm.Size = new System.Drawing.Size(714, 61);
            this.panel_btttmm.TabIndex = 16;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.Controls.Add(this.btn_cerrar, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_guardar, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(714, 61);
            this.tableLayoutPanel2.TabIndex = 26;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_cerrar.BorderColor = System.Drawing.Color.Red;
            this.btn_cerrar.BorderRadius = 7;
            this.btn_cerrar.BorderSize = 2;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.Red;
            this.btn_cerrar.Location = new System.Drawing.Point(561, 10);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(150, 40);
            this.btn_cerrar.TabIndex = 11;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.TextColor = System.Drawing.Color.Red;
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_guardar.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn_guardar.BorderRadius = 7;
            this.btn_guardar.BorderSize = 2;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.LimeGreen;
            this.btn_guardar.Location = new System.Drawing.Point(361, 10);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(150, 40);
            this.btn_guardar.TabIndex = 12;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextColor = System.Drawing.Color.LimeGreen;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // panel_createclient
            // 
            this.panel_createclient.BackColor = System.Drawing.Color.Indigo;
            this.panel_createclient.ColumnCount = 1;
            this.panel_createclient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_createclient.Controls.Add(this.lbl_crearcliente, 0, 0);
            this.panel_createclient.Controls.Add(this.panel_create, 0, 1);
            this.panel_createclient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_createclient.Location = new System.Drawing.Point(0, 0);
            this.panel_createclient.Margin = new System.Windows.Forms.Padding(0);
            this.panel_createclient.Name = "panel_createclient";
            this.panel_createclient.RowCount = 2;
            this.panel_createclient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.panel_createclient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.77778F));
            this.panel_createclient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_createclient.Size = new System.Drawing.Size(714, 345);
            this.panel_createclient.TabIndex = 17;
            // 
            // lbl_crearcliente
            // 
            this.lbl_crearcliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_crearcliente.AutoSize = true;
            this.lbl_crearcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_crearcliente.ForeColor = System.Drawing.Color.Orange;
            this.lbl_crearcliente.Location = new System.Drawing.Point(146, 10);
            this.lbl_crearcliente.Name = "lbl_crearcliente";
            this.lbl_crearcliente.Size = new System.Drawing.Size(422, 55);
            this.lbl_crearcliente.TabIndex = 34;
            this.lbl_crearcliente.Text = "CREAR CLIENTE";
            // 
            // panel_create
            // 
            this.panel_create.BackColor = System.Drawing.Color.Indigo;
            this.panel_create.ColumnCount = 3;
            this.panel_create.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panel_create.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panel_create.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panel_create.Controls.Add(this.lbl_full_name, 0, 0);
            this.panel_create.Controls.Add(this.txt_nombre_completo, 0, 1);
            this.panel_create.Controls.Add(this.lbl_dni, 0, 2);
            this.panel_create.Controls.Add(this.txt_dni, 0, 3);
            this.panel_create.Controls.Add(this.lbl_tel, 1, 2);
            this.panel_create.Controls.Add(this.txt_tel, 1, 3);
            this.panel_create.Controls.Add(this.lbl_email, 2, 0);
            this.panel_create.Controls.Add(this.txt_correo, 2, 1);
            this.panel_create.Controls.Add(this.lbl_state, 1, 0);
            this.panel_create.Controls.Add(this.cbo_estado, 1, 1);
            this.panel_create.Controls.Add(this.txt_id, 2, 3);
            this.panel_create.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_create.Location = new System.Drawing.Point(0, 76);
            this.panel_create.Margin = new System.Windows.Forms.Padding(0);
            this.panel_create.Name = "panel_create";
            this.panel_create.RowCount = 4;
            this.panel_create.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel_create.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel_create.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel_create.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel_create.Size = new System.Drawing.Size(714, 269);
            this.panel_create.TabIndex = 36;
            // 
            // lbl_full_name
            // 
            this.lbl_full_name.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_full_name.AutoSize = true;
            this.lbl_full_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_full_name.ForeColor = System.Drawing.Color.Orange;
            this.lbl_full_name.Location = new System.Drawing.Point(49, 17);
            this.lbl_full_name.Name = "lbl_full_name";
            this.lbl_full_name.Size = new System.Drawing.Size(140, 50);
            this.lbl_full_name.TabIndex = 49;
            this.lbl_full_name.Text = "NOMBRE Y APELLIDO";
            // 
            // txt_nombre_completo
            // 
            this.txt_nombre_completo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_nombre_completo.BackColor = System.Drawing.SystemColors.Window;
            this.txt_nombre_completo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_nombre_completo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_nombre_completo.BorderRadius = 0;
            this.txt_nombre_completo.BorderSize = 2;
            this.txt_nombre_completo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_nombre_completo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nombre_completo.Location = new System.Drawing.Point(4, 71);
            this.txt_nombre_completo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre_completo.Multiline = false;
            this.txt_nombre_completo.Name = "txt_nombre_completo";
            this.txt_nombre_completo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_nombre_completo.PasswordChar = false;
            this.txt_nombre_completo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_nombre_completo.PlaceholderText = "";
            this.txt_nombre_completo.Size = new System.Drawing.Size(230, 31);
            this.txt_nombre_completo.TabIndex = 50;
            this.txt_nombre_completo.Texts = "";
            this.txt_nombre_completo.UnderlinedStyle = false;
            // 
            // lbl_dni
            // 
            this.lbl_dni.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dni.ForeColor = System.Drawing.Color.Orange;
            this.lbl_dni.Location = new System.Drawing.Point(94, 176);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(50, 25);
            this.lbl_dni.TabIndex = 51;
            this.lbl_dni.Text = "DNI";
            // 
            // txt_dni
            // 
            this.txt_dni.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_dni.BackColor = System.Drawing.SystemColors.Window;
            this.txt_dni.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_dni.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_dni.BorderRadius = 0;
            this.txt_dni.BorderSize = 2;
            this.txt_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_dni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_dni.Location = new System.Drawing.Point(4, 205);
            this.txt_dni.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dni.Multiline = false;
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_dni.PasswordChar = false;
            this.txt_dni.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_dni.PlaceholderText = "";
            this.txt_dni.Size = new System.Drawing.Size(230, 31);
            this.txt_dni.TabIndex = 52;
            this.txt_dni.Texts = "";
            this.txt_dni.UnderlinedStyle = false;
            // 
            // lbl_tel
            // 
            this.lbl_tel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tel.ForeColor = System.Drawing.Color.Orange;
            this.lbl_tel.Location = new System.Drawing.Point(290, 176);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(133, 25);
            this.lbl_tel.TabIndex = 53;
            this.lbl_tel.Text = "TELEFONO";
            // 
            // txt_tel
            // 
            this.txt_tel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_tel.BackColor = System.Drawing.SystemColors.Window;
            this.txt_tel.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_tel.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_tel.BorderRadius = 0;
            this.txt_tel.BorderSize = 2;
            this.txt_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_tel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_tel.Location = new System.Drawing.Point(242, 205);
            this.txt_tel.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tel.Multiline = false;
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_tel.PasswordChar = false;
            this.txt_tel.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_tel.PlaceholderText = "";
            this.txt_tel.Size = new System.Drawing.Size(230, 31);
            this.txt_tel.TabIndex = 54;
            this.txt_tel.Texts = "";
            this.txt_tel.UnderlinedStyle = false;
            // 
            // lbl_email
            // 
            this.lbl_email.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.Orange;
            this.lbl_email.Location = new System.Drawing.Point(555, 42);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(80, 25);
            this.lbl_email.TabIndex = 55;
            this.lbl_email.Text = "EMAIL";
            // 
            // txt_correo
            // 
            this.txt_correo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_correo.BackColor = System.Drawing.SystemColors.Window;
            this.txt_correo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_correo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_correo.BorderRadius = 0;
            this.txt_correo.BorderSize = 2;
            this.txt_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_correo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_correo.Location = new System.Drawing.Point(480, 71);
            this.txt_correo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_correo.Multiline = false;
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_correo.PasswordChar = false;
            this.txt_correo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_correo.PlaceholderText = "";
            this.txt_correo.Size = new System.Drawing.Size(230, 31);
            this.txt_correo.TabIndex = 56;
            this.txt_correo.Texts = "";
            this.txt_correo.UnderlinedStyle = false;
            // 
            // lbl_state
            // 
            this.lbl_state.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_state.AutoSize = true;
            this.lbl_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_state.ForeColor = System.Drawing.Color.Orange;
            this.lbl_state.Location = new System.Drawing.Point(305, 42);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(104, 25);
            this.lbl_state.TabIndex = 57;
            this.lbl_state.Text = "ESTADO";
            // 
            // cbo_estado
            // 
            this.cbo_estado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbo_estado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_estado.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbo_estado.BorderSize = 1;
            this.cbo_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbo_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbo_estado.ForeColor = System.Drawing.Color.DimGray;
            this.cbo_estado.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbo_estado.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbo_estado.ListTextColor = System.Drawing.Color.DimGray;
            this.cbo_estado.Location = new System.Drawing.Point(241, 70);
            this.cbo_estado.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbo_estado.Name = "cbo_estado";
            this.cbo_estado.Padding = new System.Windows.Forms.Padding(1);
            this.cbo_estado.Size = new System.Drawing.Size(232, 30);
            this.cbo_estado.TabIndex = 58;
            this.cbo_estado.Texts = "";
            // 
            // txt_id
            // 
            this.txt_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_id.BackColor = System.Drawing.SystemColors.Window;
            this.txt_id.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_id.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_id.BorderRadius = 0;
            this.txt_id.BorderSize = 2;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_id.Location = new System.Drawing.Point(572, 219);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Multiline = false;
            this.txt_id.Name = "txt_id";
            this.txt_id.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_id.PasswordChar = false;
            this.txt_id.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_id.PlaceholderText = "";
            this.txt_id.Size = new System.Drawing.Size(45, 31);
            this.txt_id.TabIndex = 59;
            this.txt_id.Texts = "";
            this.txt_id.UnderlinedStyle = false;
            this.txt_id.Visible = false;
            // 
            // formCustomersAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 406);
            this.Controls.Add(this.panel_main);
            this.Name = "formCustomersAdd";
            this.Text = "formCustomers2";
            this.Load += new System.EventHandler(this.formCustomersAdd_Load);
            this.panel_main.ResumeLayout(false);
            this.panel_btttmm.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel_createclient.ResumeLayout(false);
            this.panel_createclient.PerformLayout();
            this.panel_create.ResumeLayout(false);
            this.panel_create.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel_main;
        private System.Windows.Forms.TableLayoutPanel panel_btttmm;
        private System.Windows.Forms.TableLayoutPanel panel_createclient;
        private System.Windows.Forms.Label lbl_crearcliente;
        private System.Windows.Forms.TableLayoutPanel panel_create;
        private System.Windows.Forms.Label lbl_full_name;
        private CustomBox.RJControls.RJTextBox txt_nombre_completo;
        private System.Windows.Forms.Label lbl_dni;
        private CustomBox.RJControls.RJTextBox txt_dni;
        private System.Windows.Forms.Label lbl_tel;
        private CustomBox.RJControls.RJTextBox txt_tel;
        private System.Windows.Forms.Label lbl_email;
        private CustomBox.RJControls.RJTextBox txt_correo;
        private System.Windows.Forms.Label lbl_state;
        private RJCodeAdvance.RJControls.RJComboBox cbo_estado;
        private CustomBox.RJControls.RJTextBox txt_id;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private RJCodeAdvance.RJControls.RJButton btn_cerrar;
        private RJCodeAdvance.RJControls.RJButton btn_guardar;
    }
}