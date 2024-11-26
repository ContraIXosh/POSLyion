namespace POSLyion
{
    partial class formClientesAlta
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
            this.panel_main = new System.Windows.Forms.TableLayoutPanel();
            this.panel_btttmm = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_reiniciar_datos = new RJCodeAdvance.RJControls.RJButton();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_cerrar = new RJCodeAdvance.RJControls.RJButton();
            this.btn_guardar = new RJCodeAdvance.RJControls.RJButton();
            this.panel_createclient = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_crearcliente = new System.Windows.Forms.Label();
            this.panel_create = new System.Windows.Forms.TableLayoutPanel();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.lbl_descuento = new System.Windows.Forms.Label();
            this.lbl_full_name = new System.Windows.Forms.Label();
            this.num_descuento = new System.Windows.Forms.NumericUpDown();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.cbo_estado = new RJCodeAdvance.RJControls.RJComboBox();
            this.txt_nombre_completo = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_main.SuspendLayout();
            this.panel_btttmm.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel_createclient.SuspendLayout();
            this.panel_create.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_descuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.panel_main.Size = new System.Drawing.Size(714, 373);
            this.panel_main.TabIndex = 0;
            // 
            // panel_btttmm
            // 
            this.panel_btttmm.ColumnCount = 1;
            this.panel_btttmm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_btttmm.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.panel_btttmm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_btttmm.Location = new System.Drawing.Point(0, 317);
            this.panel_btttmm.Margin = new System.Windows.Forms.Padding(0);
            this.panel_btttmm.Name = "panel_btttmm";
            this.panel_btttmm.RowCount = 1;
            this.panel_btttmm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_btttmm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.panel_btttmm.Size = new System.Drawing.Size(714, 56);
            this.panel_btttmm.TabIndex = 16;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.btn_reiniciar_datos, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_id, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_cerrar, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_guardar, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(714, 56);
            this.tableLayoutPanel2.TabIndex = 26;
            // 
            // btn_reiniciar_datos
            // 
            this.btn_reiniciar_datos.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_reiniciar_datos.BackColor = System.Drawing.Color.Transparent;
            this.btn_reiniciar_datos.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_reiniciar_datos.BorderColor = System.Drawing.Color.Yellow;
            this.btn_reiniciar_datos.BorderRadius = 7;
            this.btn_reiniciar_datos.BorderSize = 2;
            this.btn_reiniciar_datos.FlatAppearance.BorderSize = 0;
            this.btn_reiniciar_datos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reiniciar_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reiniciar_datos.ForeColor = System.Drawing.Color.Yellow;
            this.btn_reiniciar_datos.Location = new System.Drawing.Point(249, 8);
            this.btn_reiniciar_datos.Name = "btn_reiniciar_datos";
            this.btn_reiniciar_datos.Size = new System.Drawing.Size(150, 40);
            this.btn_reiniciar_datos.TabIndex = 60;
            this.btn_reiniciar_datos.Text = "Reiniciar datos";
            this.btn_reiniciar_datos.TextColor = System.Drawing.Color.Yellow;
            this.btn_reiniciar_datos.UseVisualStyleBackColor = false;
            this.btn_reiniciar_datos.Click += new System.EventHandler(this.btn_reiniciar_datos_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(3, 3);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(48, 20);
            this.txt_id.TabIndex = 59;
            this.txt_id.Text = "0";
            this.txt_id.Visible = false;
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
            this.btn_cerrar.Location = new System.Drawing.Point(561, 8);
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
            this.btn_guardar.Location = new System.Drawing.Point(405, 8);
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
            this.panel_createclient.Size = new System.Drawing.Size(714, 317);
            this.panel_createclient.TabIndex = 17;
            // 
            // lbl_crearcliente
            // 
            this.lbl_crearcliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_crearcliente.AutoSize = true;
            this.lbl_crearcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_crearcliente.ForeColor = System.Drawing.Color.Orange;
            this.lbl_crearcliente.Location = new System.Drawing.Point(146, 7);
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
            this.panel_create.Controls.Add(this.txt_dni, 0, 3);
            this.panel_create.Controls.Add(this.txt_correo, 2, 1);
            this.panel_create.Controls.Add(this.lbl_descuento, 2, 2);
            this.panel_create.Controls.Add(this.lbl_full_name, 0, 0);
            this.panel_create.Controls.Add(this.num_descuento, 2, 3);
            this.panel_create.Controls.Add(this.lbl_dni, 0, 2);
            this.panel_create.Controls.Add(this.lbl_email, 2, 0);
            this.panel_create.Controls.Add(this.txt_nombre_completo, 0, 1);
            this.panel_create.Controls.Add(this.lbl_estado, 1, 2);
            this.panel_create.Controls.Add(this.lbl_telefono, 1, 0);
            this.panel_create.Controls.Add(this.cbo_estado, 1, 3);
            this.panel_create.Controls.Add(this.txt_telefono, 1, 1);
            this.panel_create.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_create.Location = new System.Drawing.Point(0, 70);
            this.panel_create.Margin = new System.Windows.Forms.Padding(0);
            this.panel_create.Name = "panel_create";
            this.panel_create.RowCount = 4;
            this.panel_create.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel_create.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel_create.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel_create.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel_create.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_create.Size = new System.Drawing.Size(714, 247);
            this.panel_create.TabIndex = 36;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.Location = new System.Drawing.Point(241, 64);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(231, 29);
            this.txt_telefono.TabIndex = 64;
            // 
            // txt_dni
            // 
            this.txt_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dni.Location = new System.Drawing.Point(3, 186);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(231, 29);
            this.txt_dni.TabIndex = 63;
            // 
            // txt_correo
            // 
            this.txt_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.Location = new System.Drawing.Point(479, 64);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(231, 29);
            this.txt_correo.TabIndex = 62;
            // 
            // lbl_descuento
            // 
            this.lbl_descuento.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_descuento.AutoSize = true;
            this.lbl_descuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descuento.ForeColor = System.Drawing.Color.Orange;
            this.lbl_descuento.Location = new System.Drawing.Point(519, 158);
            this.lbl_descuento.Name = "lbl_descuento";
            this.lbl_descuento.Size = new System.Drawing.Size(152, 25);
            this.lbl_descuento.TabIndex = 59;
            this.lbl_descuento.Text = "DESCUENTO";
            // 
            // lbl_full_name
            // 
            this.lbl_full_name.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_full_name.AutoSize = true;
            this.lbl_full_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_full_name.ForeColor = System.Drawing.Color.Orange;
            this.lbl_full_name.Location = new System.Drawing.Point(49, 11);
            this.lbl_full_name.Name = "lbl_full_name";
            this.lbl_full_name.Size = new System.Drawing.Size(140, 50);
            this.lbl_full_name.TabIndex = 49;
            this.lbl_full_name.Text = "NOMBRE Y APELLIDO";
            // 
            // num_descuento
            // 
            this.num_descuento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.num_descuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_descuento.Location = new System.Drawing.Point(520, 186);
            this.num_descuento.Name = "num_descuento";
            this.num_descuento.Size = new System.Drawing.Size(150, 29);
            this.num_descuento.TabIndex = 60;
            // 
            // lbl_dni
            // 
            this.lbl_dni.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dni.ForeColor = System.Drawing.Color.Orange;
            this.lbl_dni.Location = new System.Drawing.Point(94, 158);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(50, 25);
            this.lbl_dni.TabIndex = 51;
            this.lbl_dni.Text = "DNI";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.ForeColor = System.Drawing.Color.Orange;
            this.lbl_telefono.Location = new System.Drawing.Point(290, 36);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(133, 25);
            this.lbl_telefono.TabIndex = 53;
            this.lbl_telefono.Text = "TELEFONO";
            // 
            // lbl_email
            // 
            this.lbl_email.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.Orange;
            this.lbl_email.Location = new System.Drawing.Point(555, 36);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(80, 25);
            this.lbl_email.TabIndex = 55;
            this.lbl_email.Text = "EMAIL";
            // 
            // lbl_estado
            // 
            this.lbl_estado.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.ForeColor = System.Drawing.Color.Orange;
            this.lbl_estado.Location = new System.Drawing.Point(305, 158);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(104, 25);
            this.lbl_estado.TabIndex = 57;
            this.lbl_estado.Text = "ESTADO";
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
            this.cbo_estado.Location = new System.Drawing.Point(241, 186);
            this.cbo_estado.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbo_estado.Name = "cbo_estado";
            this.cbo_estado.Padding = new System.Windows.Forms.Padding(1);
            this.cbo_estado.Size = new System.Drawing.Size(232, 30);
            this.cbo_estado.TabIndex = 58;
            this.cbo_estado.Texts = "";
            // 
            // txt_nombre_completo
            // 
            this.txt_nombre_completo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_completo.Location = new System.Drawing.Point(3, 64);
            this.txt_nombre_completo.Name = "txt_nombre_completo";
            this.txt_nombre_completo.Size = new System.Drawing.Size(231, 29);
            this.txt_nombre_completo.TabIndex = 61;
            this.txt_nombre_completo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_completo_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // formClientesAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 373);
            this.Controls.Add(this.panel_main);
            this.Name = "formClientesAlta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear un cliente";
            this.Load += new System.EventHandler(this.formClientesAlta_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formClientesAlta_KeyDown);
            this.panel_main.ResumeLayout(false);
            this.panel_btttmm.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel_createclient.ResumeLayout(false);
            this.panel_createclient.PerformLayout();
            this.panel_create.ResumeLayout(false);
            this.panel_create.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_descuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel_main;
        private System.Windows.Forms.TableLayoutPanel panel_btttmm;
        private System.Windows.Forms.TableLayoutPanel panel_createclient;
        private System.Windows.Forms.Label lbl_crearcliente;
        private System.Windows.Forms.TableLayoutPanel panel_create;
        private System.Windows.Forms.Label lbl_full_name;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_estado;
        private RJCodeAdvance.RJControls.RJComboBox cbo_estado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private RJCodeAdvance.RJControls.RJButton btn_cerrar;
        private RJCodeAdvance.RJControls.RJButton btn_guardar;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_descuento;
        private System.Windows.Forms.NumericUpDown num_descuento;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_nombre_completo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private RJCodeAdvance.RJControls.RJButton btn_reiniciar_datos;
    }
}