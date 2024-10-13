namespace PDCLyion
{
    partial class formStadistic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formStadistic));
            this.panel_main = new System.Windows.Forms.TableLayoutPanel();
            this.panel_top = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Down = new CustomBox.RJControls.RJButton();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_hamb = new RJCodeAdvance.RJControls.RJButton();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.panel_update = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_mid = new System.Windows.Forms.TableLayoutPanel();
            this.panel_izq = new System.Windows.Forms.TableLayoutPanel();
            this.btn_back = new CustomBox.RJControls.RJButton();
            this.btn_search = new CustomBox.RJControls.RJButton();
            this.date_hasta = new CustomBox.RJControls.RJDatePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbox_turno = new CustomBox.RJControls.RJComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbox_user = new CustomBox.RJControls.RJComboBox();
            this.btn_excel = new CustomBox.RJControls.RJButton();
            this.btn_sql = new CustomBox.RJControls.RJButton();
            this.label6 = new System.Windows.Forms.Label();
            this.date_desde = new CustomBox.RJControls.RJDatePicker();
            this.panel_stadistic = new System.Windows.Forms.TableLayoutPanel();
            this.resumen_stadist = new System.Windows.Forms.Panel();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.stadist_cartesiano = new LiveCharts.WinForms.CartesianChart();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menu_sesion = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.verPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioAdministradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Main = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_main.SuspendLayout();
            this.panel_top.SuspendLayout();
            this.panel_update.SuspendLayout();
            this.panel_mid.SuspendLayout();
            this.panel_izq.SuspendLayout();
            this.panel_stadistic.SuspendLayout();
            this.menu_sesion.SuspendLayout();
            this.menu_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_main.ColumnCount = 1;
            this.panel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_main.Controls.Add(this.panel_top, 0, 0);
            this.panel_main.Controls.Add(this.panel_update, 0, 2);
            this.panel_main.Controls.Add(this.panel_mid, 0, 1);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Margin = new System.Windows.Forms.Padding(0);
            this.panel_main.Name = "panel_main";
            this.panel_main.RowCount = 3;
            this.panel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.panel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.panel_main.Size = new System.Drawing.Size(982, 611);
            this.panel_main.TabIndex = 0;
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Gold;
            this.panel_top.ColumnCount = 4;
            this.panel_top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panel_top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.panel_top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panel_top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.panel_top.Controls.Add(this.btn_Down, 2, 0);
            this.panel_top.Controls.Add(this.label10, 1, 0);
            this.panel_top.Controls.Add(this.btn_hamb, 0, 0);
            this.panel_top.Controls.Add(this.lbl_usuario, 3, 0);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_top.ForeColor = System.Drawing.Color.Black;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Margin = new System.Windows.Forms.Padding(0);
            this.panel_top.Name = "panel_top";
            this.panel_top.RowCount = 1;
            this.panel_top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_top.Size = new System.Drawing.Size(982, 53);
            this.panel_top.TabIndex = 15;
            // 
            // btn_Down
            // 
            this.btn_Down.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Down.BackColor = System.Drawing.Color.Transparent;
            this.btn_Down.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_Down.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Down.BackgroundImage")));
            this.btn_Down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Down.BorderColor = System.Drawing.Color.Red;
            this.btn_Down.BorderRadius = 1;
            this.btn_Down.BorderSize = 0;
            this.btn_Down.FlatAppearance.BorderSize = 0;
            this.btn_Down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Down.ForeColor = System.Drawing.Color.White;
            this.btn_Down.Location = new System.Drawing.Point(677, 13);
            this.btn_Down.Name = "btn_Down";
            this.btn_Down.Size = new System.Drawing.Size(30, 27);
            this.btn_Down.TabIndex = 10;
            this.btn_Down.TextColor = System.Drawing.Color.White;
            this.btn_Down.UseVisualStyleBackColor = false;
            this.btn_Down.Click += new System.EventHandler(this.btn_Down_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(53, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(221, 53);
            this.label10.TabIndex = 0;
            this.label10.Text = "POSLyion";
            // 
            // btn_hamb
            // 
            this.btn_hamb.BackColor = System.Drawing.Color.Transparent;
            this.btn_hamb.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_hamb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_hamb.BackgroundImage")));
            this.btn_hamb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_hamb.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_hamb.BorderRadius = 0;
            this.btn_hamb.BorderSize = 0;
            this.btn_hamb.FlatAppearance.BorderSize = 0;
            this.btn_hamb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hamb.ForeColor = System.Drawing.Color.White;
            this.btn_hamb.Location = new System.Drawing.Point(3, 3);
            this.btn_hamb.Name = "btn_hamb";
            this.btn_hamb.Size = new System.Drawing.Size(44, 45);
            this.btn_hamb.TabIndex = 11;
            this.btn_hamb.TextColor = System.Drawing.Color.White;
            this.btn_hamb.UseVisualStyleBackColor = false;
            this.btn_hamb.Click += new System.EventHandler(this.btn_hamb_Click);
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(720, 12);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(165, 29);
            this.lbl_usuario.TabIndex = 12;
            this.lbl_usuario.Text = "PERSONAL1";
            // 
            // panel_update
            // 
            this.panel_update.BackColor = System.Drawing.Color.Khaki;
            this.panel_update.Controls.Add(this.label4);
            this.panel_update.Controls.Add(this.label5);
            this.panel_update.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_update.Location = new System.Drawing.Point(0, 595);
            this.panel_update.Margin = new System.Windows.Forms.Padding(0);
            this.panel_update.Name = "panel_update";
            this.panel_update.Size = new System.Drawing.Size(982, 16);
            this.panel_update.TabIndex = 35;
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
            // panel_mid
            // 
            this.panel_mid.ColumnCount = 2;
            this.panel_mid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.panel_mid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.panel_mid.Controls.Add(this.panel_izq, 0, 0);
            this.panel_mid.Controls.Add(this.panel_stadistic, 1, 0);
            this.panel_mid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_mid.Location = new System.Drawing.Point(0, 53);
            this.panel_mid.Margin = new System.Windows.Forms.Padding(0);
            this.panel_mid.Name = "panel_mid";
            this.panel_mid.RowCount = 1;
            this.panel_mid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_mid.Size = new System.Drawing.Size(982, 542);
            this.panel_mid.TabIndex = 36;
            // 
            // panel_izq
            // 
            this.panel_izq.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel_izq.ColumnCount = 1;
            this.panel_izq.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_izq.Controls.Add(this.btn_back, 0, 11);
            this.panel_izq.Controls.Add(this.btn_search, 0, 10);
            this.panel_izq.Controls.Add(this.date_hasta, 0, 9);
            this.panel_izq.Controls.Add(this.label9, 0, 8);
            this.panel_izq.Controls.Add(this.label8, 0, 6);
            this.panel_izq.Controls.Add(this.cbox_turno, 0, 5);
            this.panel_izq.Controls.Add(this.label7, 0, 4);
            this.panel_izq.Controls.Add(this.cbox_user, 0, 3);
            this.panel_izq.Controls.Add(this.btn_excel, 0, 0);
            this.panel_izq.Controls.Add(this.btn_sql, 0, 1);
            this.panel_izq.Controls.Add(this.label6, 0, 2);
            this.panel_izq.Controls.Add(this.date_desde, 0, 7);
            this.panel_izq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_izq.Location = new System.Drawing.Point(0, 0);
            this.panel_izq.Margin = new System.Windows.Forms.Padding(0);
            this.panel_izq.Name = "panel_izq";
            this.panel_izq.RowCount = 12;
            this.panel_izq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.10765F));
            this.panel_izq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.91691F));
            this.panel_izq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.958457F));
            this.panel_izq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.086117F));
            this.panel_izq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.075352F));
            this.panel_izq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.086117F));
            this.panel_izq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.064588F));
            this.panel_izq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.10765F));
            this.panel_izq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.064588F));
            this.panel_izq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.10765F));
            this.panel_izq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.10765F));
            this.panel_izq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.317279F));
            this.panel_izq.Size = new System.Drawing.Size(294, 542);
            this.panel_izq.TabIndex = 39;
            // 
            // btn_back
            // 
            this.btn_back.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_back.BackColor = System.Drawing.Color.Red;
            this.btn_back.BackgroundColor = System.Drawing.Color.Red;
            this.btn_back.BorderColor = System.Drawing.Color.Black;
            this.btn_back.BorderRadius = 10;
            this.btn_back.BorderSize = 2;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.Black;
            this.btn_back.Location = new System.Drawing.Point(41, 503);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(212, 36);
            this.btn_back.TabIndex = 39;
            this.btn_back.Text = "Regresar";
            this.btn_back.TextColor = System.Drawing.Color.Black;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_search
            // 
            this.btn_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_search.BackColor = System.Drawing.Color.Green;
            this.btn_search.BackgroundColor = System.Drawing.Color.Green;
            this.btn_search.BorderColor = System.Drawing.Color.Red;
            this.btn_search.BorderRadius = 10;
            this.btn_search.BorderSize = 0;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(41, 449);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(212, 47);
            this.btn_search.TabIndex = 38;
            this.btn_search.Text = "BUSCAR";
            this.btn_search.TextColor = System.Drawing.Color.White;
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // date_hasta
            // 
            this.date_hasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date_hasta.BorderColor = System.Drawing.Color.DodgerBlue;
            this.date_hasta.BorderSize = 0;
            this.date_hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.date_hasta.Location = new System.Drawing.Point(28, 401);
            this.date_hasta.MinimumSize = new System.Drawing.Size(4, 35);
            this.date_hasta.Name = "date_hasta";
            this.date_hasta.Size = new System.Drawing.Size(237, 35);
            this.date_hasta.SkinColor = System.Drawing.Color.DodgerBlue;
            this.date_hasta.TabIndex = 37;
            this.date_hasta.TextColor = System.Drawing.Color.White;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGreen;
            this.label9.Location = new System.Drawing.Point(69, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 22);
            this.label9.TabIndex = 36;
            this.label9.Text = "FECHA HASTA";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGreen;
            this.label8.Location = new System.Drawing.Point(69, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 22);
            this.label8.TabIndex = 34;
            this.label8.Text = "FECHA DESDE";
            // 
            // cbox_turno
            // 
            this.cbox_turno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbox_turno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbox_turno.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbox_turno.BorderSize = 1;
            this.cbox_turno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbox_turno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbox_turno.ForeColor = System.Drawing.Color.DimGray;
            this.cbox_turno.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbox_turno.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbox_turno.ListTextColor = System.Drawing.Color.DimGray;
            this.cbox_turno.Location = new System.Drawing.Point(41, 237);
            this.cbox_turno.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbox_turno.Name = "cbox_turno";
            this.cbox_turno.Padding = new System.Windows.Forms.Padding(1);
            this.cbox_turno.Size = new System.Drawing.Size(212, 30);
            this.cbox_turno.TabIndex = 33;
            this.cbox_turno.Texts = "";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(105, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 22);
            this.label7.TabIndex = 32;
            this.label7.Text = "TURNO";
            // 
            // cbox_user
            // 
            this.cbox_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbox_user.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbox_user.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbox_user.BorderSize = 1;
            this.cbox_user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbox_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbox_user.ForeColor = System.Drawing.Color.DimGray;
            this.cbox_user.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbox_user.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbox_user.ListTextColor = System.Drawing.Color.DimGray;
            this.cbox_user.Location = new System.Drawing.Point(41, 156);
            this.cbox_user.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbox_user.Name = "cbox_user";
            this.cbox_user.Padding = new System.Windows.Forms.Padding(1);
            this.cbox_user.Size = new System.Drawing.Size(212, 30);
            this.cbox_user.TabIndex = 31;
            this.cbox_user.Texts = "";
            // 
            // btn_excel
            // 
            this.btn_excel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_excel.BackColor = System.Drawing.Color.Green;
            this.btn_excel.BackgroundColor = System.Drawing.Color.Green;
            this.btn_excel.BorderColor = System.Drawing.Color.Red;
            this.btn_excel.BorderRadius = 10;
            this.btn_excel.BorderSize = 0;
            this.btn_excel.FlatAppearance.BorderSize = 0;
            this.btn_excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excel.ForeColor = System.Drawing.Color.White;
            this.btn_excel.Location = new System.Drawing.Point(35, 3);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(224, 47);
            this.btn_excel.TabIndex = 28;
            this.btn_excel.Text = "EXPORTAR EXCEL";
            this.btn_excel.TextColor = System.Drawing.Color.White;
            this.btn_excel.UseVisualStyleBackColor = false;
            // 
            // btn_sql
            // 
            this.btn_sql.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_sql.BackColor = System.Drawing.Color.Green;
            this.btn_sql.BackgroundColor = System.Drawing.Color.Green;
            this.btn_sql.BorderColor = System.Drawing.Color.Red;
            this.btn_sql.BorderRadius = 10;
            this.btn_sql.BorderSize = 0;
            this.btn_sql.FlatAppearance.BorderSize = 0;
            this.btn_sql.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sql.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sql.ForeColor = System.Drawing.Color.White;
            this.btn_sql.Location = new System.Drawing.Point(11, 62);
            this.btn_sql.Name = "btn_sql";
            this.btn_sql.Size = new System.Drawing.Size(272, 47);
            this.btn_sql.TabIndex = 29;
            this.btn_sql.Text = "EXPORTAR BASE DE DATOS";
            this.btn_sql.TextColor = System.Drawing.Color.White;
            this.btn_sql.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(94, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 22);
            this.label6.TabIndex = 30;
            this.label6.Text = "USUARIO";
            // 
            // date_desde
            // 
            this.date_desde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date_desde.BorderColor = System.Drawing.Color.DodgerBlue;
            this.date_desde.BorderSize = 0;
            this.date_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.date_desde.Location = new System.Drawing.Point(28, 315);
            this.date_desde.MinimumSize = new System.Drawing.Size(4, 35);
            this.date_desde.Name = "date_desde";
            this.date_desde.Size = new System.Drawing.Size(237, 35);
            this.date_desde.SkinColor = System.Drawing.Color.DodgerBlue;
            this.date_desde.TabIndex = 35;
            this.date_desde.TextColor = System.Drawing.Color.White;
            // 
            // panel_stadistic
            // 
            this.panel_stadistic.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_stadistic.ColumnCount = 2;
            this.panel_stadistic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_stadistic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_stadistic.Controls.Add(this.resumen_stadist, 0, 3);
            this.panel_stadistic.Controls.Add(this.pieChart1, 1, 1);
            this.panel_stadistic.Controls.Add(this.stadist_cartesiano, 0, 1);
            this.panel_stadistic.Controls.Add(this.label3, 0, 0);
            this.panel_stadistic.Controls.Add(this.label1, 1, 0);
            this.panel_stadistic.Controls.Add(this.label2, 0, 2);
            this.panel_stadistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_stadistic.Location = new System.Drawing.Point(294, 0);
            this.panel_stadistic.Margin = new System.Windows.Forms.Padding(0);
            this.panel_stadistic.Name = "panel_stadistic";
            this.panel_stadistic.RowCount = 4;
            this.panel_stadistic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.099265F));
            this.panel_stadistic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.36029F));
            this.panel_stadistic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.099265F));
            this.panel_stadistic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.44118F));
            this.panel_stadistic.Size = new System.Drawing.Size(688, 542);
            this.panel_stadistic.TabIndex = 37;
            // 
            // resumen_stadist
            // 
            this.resumen_stadist.BackColor = System.Drawing.Color.WhiteSmoke;
            this.resumen_stadist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resumen_stadist.Location = new System.Drawing.Point(3, 325);
            this.resumen_stadist.Name = "resumen_stadist";
            this.resumen_stadist.Size = new System.Drawing.Size(338, 214);
            this.resumen_stadist.TabIndex = 4;
            // 
            // pieChart1
            // 
            this.pieChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChart1.Location = new System.Drawing.Point(347, 52);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(338, 218);
            this.pieChart1.TabIndex = 5;
            this.pieChart1.Text = "pieChart1";
            // 
            // stadist_cartesiano
            // 
            this.stadist_cartesiano.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stadist_cartesiano.Location = new System.Drawing.Point(3, 52);
            this.stadist_cartesiano.Name = "stadist_cartesiano";
            this.stadist_cartesiano.Size = new System.Drawing.Size(338, 218);
            this.stadist_cartesiano.TabIndex = 3;
            this.stadist_cartesiano.Text = "cartesianChart1";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(56, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "GRAFICO DE VELAS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(399, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "GRAFICO DE TORTA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(110, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "RESUMEN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menu_sesion
            // 
            this.menu_sesion.DropShadowEnabled = false;
            this.menu_sesion.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_sesion.IsMainMenu = false;
            this.menu_sesion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPerfilToolStripMenuItem,
            this.inicioAdministradorToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.menu_sesion.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menu_sesion.MenuItemHeight = 25;
            this.menu_sesion.MenuItemTextColor = System.Drawing.Color.Black;
            this.menu_sesion.Name = "menu_sesion";
            this.menu_sesion.PrimaryColor = System.Drawing.Color.Gold;
            this.menu_sesion.Size = new System.Drawing.Size(203, 70);
            // 
            // verPerfilToolStripMenuItem
            // 
            this.verPerfilToolStripMenuItem.Name = "verPerfilToolStripMenuItem";
            this.verPerfilToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.verPerfilToolStripMenuItem.Text = "Ver perfil";
            // 
            // inicioAdministradorToolStripMenuItem
            // 
            this.inicioAdministradorToolStripMenuItem.Name = "inicioAdministradorToolStripMenuItem";
            this.inicioAdministradorToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.inicioAdministradorToolStripMenuItem.Text = "Inicio Administrador";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            // 
            // menu_Main
            // 
            this.menu_Main.IsMainMenu = true;
            this.menu_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.configuraciónToolStripMenuItem});
            this.menu_Main.MenuItemHeight = 25;
            this.menu_Main.MenuItemTextColor = System.Drawing.Color.White;
            this.menu_Main.Name = "menu_Main";
            this.menu_Main.PrimaryColor = System.Drawing.Color.Gold;
            this.menu_Main.Size = new System.Drawing.Size(151, 202);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.comprasToolStripMenuItem.Text = "Compras";
            this.comprasToolStripMenuItem.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            this.configuraciónToolStripMenuItem.Click += new System.EventHandler(this.configuraciónToolStripMenuItem_Click);
            // 
            // formStadistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 611);
            this.Controls.Add(this.panel_main);
            this.Name = "formStadistic";
            this.Text = "formStadistic";
            this.panel_main.ResumeLayout(false);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_update.ResumeLayout(false);
            this.panel_update.PerformLayout();
            this.panel_mid.ResumeLayout(false);
            this.panel_izq.ResumeLayout(false);
            this.panel_izq.PerformLayout();
            this.panel_stadistic.ResumeLayout(false);
            this.panel_stadistic.PerformLayout();
            this.menu_sesion.ResumeLayout(false);
            this.menu_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel_main;
        private System.Windows.Forms.Panel panel_update;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel panel_mid;
        private System.Windows.Forms.TableLayoutPanel panel_izq;
        private CustomBox.RJControls.RJButton btn_back;
        private CustomBox.RJControls.RJButton btn_search;
        private CustomBox.RJControls.RJDatePicker date_hasta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private CustomBox.RJControls.RJComboBox cbox_turno;
        private System.Windows.Forms.Label label7;
        private CustomBox.RJControls.RJComboBox cbox_user;
        private CustomBox.RJControls.RJButton btn_excel;
        private CustomBox.RJControls.RJButton btn_sql;
        private System.Windows.Forms.Label label6;
        private CustomBox.RJControls.RJDatePicker date_desde;
        private System.Windows.Forms.TableLayoutPanel panel_stadistic;
        private System.Windows.Forms.Panel resumen_stadist;
        private LiveCharts.WinForms.PieChart pieChart1;
        private LiveCharts.WinForms.CartesianChart stadist_cartesiano;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel panel_top;
        private CustomBox.RJControls.RJButton btn_Down;
        private System.Windows.Forms.Label label10;
        private RJCodeAdvance.RJControls.RJButton btn_hamb;
        private System.Windows.Forms.Label lbl_usuario;
        private RJCodeAdvance.RJControls.RJDropdownMenu menu_sesion;
        private System.Windows.Forms.ToolStripMenuItem verPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioAdministradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private RJCodeAdvance.RJControls.RJDropdownMenu menu_Main;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
    }
}