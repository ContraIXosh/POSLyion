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
            this.panel_update = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_createclient = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_crearcliente = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_borrar = new CustomBox.RJControls.RJButton();
            this.rjButton1 = new CustomBox.RJControls.RJButton();
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_back = new RJCodeAdvance.RJControls.RJButton();
            this.rjButton2 = new RJCodeAdvance.RJControls.RJButton();
            this.rjTextBox1 = new RJCodeAdvance.RJControls.RJTextBox();
            this.panel_main.SuspendLayout();
            this.panel_btttmm.SuspendLayout();
            this.panel_update.SuspendLayout();
            this.panel_createclient.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel_create.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.panel_main.Size = new System.Drawing.Size(982, 537);
            this.panel_main.TabIndex = 0;
            // 
            // panel_btttmm
            // 
            this.panel_btttmm.ColumnCount = 1;
            this.panel_btttmm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_btttmm.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.panel_btttmm.Controls.Add(this.panel_update, 0, 1);
            this.panel_btttmm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_btttmm.Location = new System.Drawing.Point(0, 456);
            this.panel_btttmm.Margin = new System.Windows.Forms.Padding(0);
            this.panel_btttmm.Name = "panel_btttmm";
            this.panel_btttmm.RowCount = 2;
            this.panel_btttmm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_btttmm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_btttmm.Size = new System.Drawing.Size(982, 81);
            this.panel_btttmm.TabIndex = 16;
            // 
            // panel_update
            // 
            this.panel_update.BackColor = System.Drawing.Color.Khaki;
            this.panel_update.Controls.Add(this.label2);
            this.panel_update.Controls.Add(this.label1);
            this.panel_update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_update.Location = new System.Drawing.Point(0, 61);
            this.panel_update.Margin = new System.Windows.Forms.Padding(0);
            this.panel_update.Name = "panel_update";
            this.panel_update.Size = new System.Drawing.Size(982, 20);
            this.panel_update.TabIndex = 25;
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
            // panel_createclient
            // 
            this.panel_createclient.BackColor = System.Drawing.Color.Indigo;
            this.panel_createclient.ColumnCount = 1;
            this.panel_createclient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_createclient.Controls.Add(this.lbl_crearcliente, 0, 0);
            this.panel_createclient.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.panel_createclient.Controls.Add(this.panel_create, 0, 1);
            this.panel_createclient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_createclient.Location = new System.Drawing.Point(0, 0);
            this.panel_createclient.Margin = new System.Windows.Forms.Padding(0);
            this.panel_createclient.Name = "panel_createclient";
            this.panel_createclient.RowCount = 3;
            this.panel_createclient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panel_createclient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.panel_createclient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.panel_createclient.Size = new System.Drawing.Size(982, 456);
            this.panel_createclient.TabIndex = 17;
            // 
            // lbl_crearcliente
            // 
            this.lbl_crearcliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_crearcliente.AutoSize = true;
            this.lbl_crearcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_crearcliente.ForeColor = System.Drawing.Color.Orange;
            this.lbl_crearcliente.Location = new System.Drawing.Point(280, 18);
            this.lbl_crearcliente.Name = "lbl_crearcliente";
            this.lbl_crearcliente.Size = new System.Drawing.Size(422, 55);
            this.lbl_crearcliente.TabIndex = 34;
            this.lbl_crearcliente.Text = "CREAR CLIENTE";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.Controls.Add(this.btn_borrar, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.rjButton1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 410);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(982, 46);
            this.tableLayoutPanel3.TabIndex = 35;
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
            this.btn_borrar.Location = new System.Drawing.Point(199, 3);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(171, 40);
            this.btn_borrar.TabIndex = 40;
            this.btn_borrar.Text = "BORRAR";
            this.btn_borrar.TextColor = System.Drawing.Color.Black;
            this.btn_borrar.UseVisualStyleBackColor = false;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Gold;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Gold;
            this.rjButton1.BorderColor = System.Drawing.Color.Black;
            this.rjButton1.BorderRadius = 10;
            this.rjButton1.BorderSize = 2;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.Black;
            this.rjButton1.Location = new System.Drawing.Point(3, 3);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(171, 40);
            this.rjButton1.TabIndex = 39;
            this.rjButton1.Text = "GUARDAR";
            this.rjButton1.TextColor = System.Drawing.Color.Black;
            this.rjButton1.UseVisualStyleBackColor = false;
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
            this.panel_create.Location = new System.Drawing.Point(0, 91);
            this.panel_create.Margin = new System.Windows.Forms.Padding(0);
            this.panel_create.Name = "panel_create";
            this.panel_create.RowCount = 4;
            this.panel_create.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel_create.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel_create.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel_create.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel_create.Size = new System.Drawing.Size(982, 319);
            this.panel_create.TabIndex = 36;
            // 
            // lbl_full_name
            // 
            this.lbl_full_name.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_full_name.AutoSize = true;
            this.lbl_full_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_full_name.ForeColor = System.Drawing.Color.Orange;
            this.lbl_full_name.Location = new System.Drawing.Point(38, 54);
            this.lbl_full_name.Name = "lbl_full_name";
            this.lbl_full_name.Size = new System.Drawing.Size(250, 25);
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
            this.txt_nombre_completo.Location = new System.Drawing.Point(38, 83);
            this.txt_nombre_completo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre_completo.Multiline = false;
            this.txt_nombre_completo.Name = "txt_nombre_completo";
            this.txt_nombre_completo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_nombre_completo.PasswordChar = false;
            this.txt_nombre_completo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_nombre_completo.PlaceholderText = "";
            this.txt_nombre_completo.Size = new System.Drawing.Size(250, 31);
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
            this.lbl_dni.Location = new System.Drawing.Point(138, 212);
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
            this.txt_dni.Location = new System.Drawing.Point(38, 241);
            this.txt_dni.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dni.Multiline = false;
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_dni.PasswordChar = false;
            this.txt_dni.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_dni.PlaceholderText = "";
            this.txt_dni.Size = new System.Drawing.Size(250, 31);
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
            this.lbl_tel.Location = new System.Drawing.Point(424, 212);
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
            this.txt_tel.Location = new System.Drawing.Point(365, 241);
            this.txt_tel.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tel.Multiline = false;
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_tel.PasswordChar = false;
            this.txt_tel.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_tel.PlaceholderText = "";
            this.txt_tel.Size = new System.Drawing.Size(250, 31);
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
            this.lbl_email.Location = new System.Drawing.Point(778, 54);
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
            this.txt_correo.Location = new System.Drawing.Point(693, 83);
            this.txt_correo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_correo.Multiline = false;
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_correo.PasswordChar = false;
            this.txt_correo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_correo.PlaceholderText = "";
            this.txt_correo.Size = new System.Drawing.Size(250, 31);
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
            this.lbl_state.Location = new System.Drawing.Point(438, 54);
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
            this.cbo_estado.Location = new System.Drawing.Point(371, 82);
            this.cbo_estado.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbo_estado.Name = "cbo_estado";
            this.cbo_estado.Padding = new System.Windows.Forms.Padding(1);
            this.cbo_estado.Size = new System.Drawing.Size(238, 30);
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
            this.txt_id.Location = new System.Drawing.Point(795, 262);
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.Controls.Add(this.btn_back, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.rjButton2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.rjTextBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(982, 61);
            this.tableLayoutPanel2.TabIndex = 26;
            // 
            // btn_back
            // 
            this.btn_back.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_back.BorderColor = System.Drawing.Color.Red;
            this.btn_back.BorderRadius = 7;
            this.btn_back.BorderSize = 2;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.Red;
            this.btn_back.Location = new System.Drawing.Point(829, 10);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(150, 40);
            this.btn_back.TabIndex = 11;
            this.btn_back.Text = "Cancelar";
            this.btn_back.TextColor = System.Drawing.Color.Red;
            this.btn_back.UseVisualStyleBackColor = false;
            // 
            // rjButton2
            // 
            this.rjButton2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rjButton2.BackColor = System.Drawing.Color.Transparent;
            this.rjButton2.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton2.BorderColor = System.Drawing.Color.LimeGreen;
            this.rjButton2.BorderRadius = 7;
            this.rjButton2.BorderSize = 2;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.LimeGreen;
            this.rjButton2.Location = new System.Drawing.Point(629, 10);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(150, 40);
            this.rjButton2.TabIndex = 12;
            this.rjButton2.Text = "Cargar";
            this.rjButton2.TextColor = System.Drawing.Color.LimeGreen;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderRadius = 0;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox1.Location = new System.Drawing.Point(4, 4);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "";
            this.rjTextBox1.Size = new System.Drawing.Size(40, 31);
            this.rjTextBox1.TabIndex = 32;
            this.rjTextBox1.Texts = "0";
            this.rjTextBox1.UnderlinedStyle = false;
            this.rjTextBox1.Visible = false;
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
            this.panel_btttmm.ResumeLayout(false);
            this.panel_update.ResumeLayout(false);
            this.panel_update.PerformLayout();
            this.panel_createclient.ResumeLayout(false);
            this.panel_createclient.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel_create.ResumeLayout(false);
            this.panel_create.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel_main;
        private System.Windows.Forms.TableLayoutPanel panel_btttmm;
        private System.Windows.Forms.Panel panel_update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel panel_createclient;
        private System.Windows.Forms.Label lbl_crearcliente;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private CustomBox.RJControls.RJButton btn_borrar;
        private CustomBox.RJControls.RJButton rjButton1;
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
        private RJCodeAdvance.RJControls.RJButton btn_back;
        private RJCodeAdvance.RJControls.RJButton rjButton2;
        private RJCodeAdvance.RJControls.RJTextBox rjTextBox1;
    }
}