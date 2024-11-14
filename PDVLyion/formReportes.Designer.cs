namespace POSLyion
{
    partial class formReportes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel_main = new System.Windows.Forms.TableLayoutPanel();
            this.panel_bot = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_updateversion = new System.Windows.Forms.Label();
            this.lbl_updatetime = new System.Windows.Forms.Label();
            this.panel_mid = new System.Windows.Forms.TableLayoutPanel();
            this.panel_izq = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_busqueda_usuario = new System.Windows.Forms.Label();
            this.btn_excel = new CustomBox.RJControls.RJButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ver_cierres = new CustomBox.RJControls.RJButton();
            this.btn_ver_compras = new CustomBox.RJControls.RJButton();
            this.btn_ver_ventas = new CustomBox.RJControls.RJButton();
            this.txt_busqueda_producto = new System.Windows.Forms.TextBox();
            this.lbl_desde = new System.Windows.Forms.Label();
            this.date_desde = new CustomBox.RJControls.RJDatePicker();
            this.lbl_hasta = new System.Windows.Forms.Label();
            this.date_hasta = new CustomBox.RJControls.RJDatePicker();
            this.lbl_busqueda_producto = new System.Windows.Forms.Label();
            this.cbox_usuarios = new System.Windows.Forms.ComboBox();
            this.btn_buscar = new CustomBox.RJControls.RJButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_historial = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel_main.SuspendLayout();
            this.panel_bot.SuspendLayout();
            this.panel_mid.SuspendLayout();
            this.panel_izq.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historial)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_main.ColumnCount = 1;
            this.panel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_main.Controls.Add(this.panel_bot, 0, 1);
            this.panel_main.Controls.Add(this.panel_mid, 0, 0);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Margin = new System.Windows.Forms.Padding(0);
            this.panel_main.Name = "panel_main";
            this.panel_main.RowCount = 2;
            this.panel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.panel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_main.Size = new System.Drawing.Size(982, 611);
            this.panel_main.TabIndex = 0;
            // 
            // panel_bot
            // 
            this.panel_bot.BackColor = System.Drawing.Color.Black;
            this.panel_bot.ColumnCount = 3;
            this.panel_bot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_bot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panel_bot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panel_bot.Controls.Add(this.lbl_updateversion, 2, 0);
            this.panel_bot.Controls.Add(this.lbl_updatetime, 1, 0);
            this.panel_bot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_bot.Location = new System.Drawing.Point(0, 595);
            this.panel_bot.Margin = new System.Windows.Forms.Padding(0);
            this.panel_bot.Name = "panel_bot";
            this.panel_bot.RowCount = 1;
            this.panel_bot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_bot.Size = new System.Drawing.Size(982, 16);
            this.panel_bot.TabIndex = 37;
            // 
            // lbl_updateversion
            // 
            this.lbl_updateversion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_updateversion.AutoSize = true;
            this.lbl_updateversion.BackColor = System.Drawing.Color.Black;
            this.lbl_updateversion.ForeColor = System.Drawing.Color.Gold;
            this.lbl_updateversion.Location = new System.Drawing.Point(864, 1);
            this.lbl_updateversion.Name = "lbl_updateversion";
            this.lbl_updateversion.Size = new System.Drawing.Size(115, 13);
            this.lbl_updateversion.TabIndex = 2;
            this.lbl_updateversion.Text = "Actualizacion: v1.0.0.5";
            // 
            // lbl_updatetime
            // 
            this.lbl_updatetime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_updatetime.AutoSize = true;
            this.lbl_updatetime.BackColor = System.Drawing.Color.Black;
            this.lbl_updatetime.ForeColor = System.Drawing.Color.Gold;
            this.lbl_updatetime.Location = new System.Drawing.Point(659, 1);
            this.lbl_updatetime.Name = "lbl_updatetime";
            this.lbl_updatetime.Size = new System.Drawing.Size(199, 13);
            this.lbl_updatetime.TabIndex = 3;
            this.lbl_updatetime.Text = "Ultimo chequeo: 10:06:12  - 20/09/2024";
            // 
            // panel_mid
            // 
            this.panel_mid.BackColor = System.Drawing.Color.Crimson;
            this.panel_mid.ColumnCount = 2;
            this.panel_mid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.panel_mid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.panel_mid.Controls.Add(this.panel_izq, 0, 0);
            this.panel_mid.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.panel_mid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_mid.Location = new System.Drawing.Point(0, 0);
            this.panel_mid.Margin = new System.Windows.Forms.Padding(0);
            this.panel_mid.Name = "panel_mid";
            this.panel_mid.RowCount = 1;
            this.panel_mid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_mid.Size = new System.Drawing.Size(982, 595);
            this.panel_mid.TabIndex = 36;
            // 
            // panel_izq
            // 
            this.panel_izq.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel_izq.ColumnCount = 1;
            this.panel_izq.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_izq.Controls.Add(this.lbl_busqueda_usuario, 0, 7);
            this.panel_izq.Controls.Add(this.btn_excel, 0, 1);
            this.panel_izq.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.panel_izq.Controls.Add(this.txt_busqueda_producto, 0, 10);
            this.panel_izq.Controls.Add(this.lbl_desde, 0, 3);
            this.panel_izq.Controls.Add(this.date_desde, 0, 4);
            this.panel_izq.Controls.Add(this.lbl_hasta, 0, 5);
            this.panel_izq.Controls.Add(this.date_hasta, 0, 6);
            this.panel_izq.Controls.Add(this.lbl_busqueda_producto, 0, 9);
            this.panel_izq.Controls.Add(this.cbox_usuarios, 0, 8);
            this.panel_izq.Controls.Add(this.btn_buscar, 0, 13);
            this.panel_izq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_izq.Location = new System.Drawing.Point(5, 5);
            this.panel_izq.Margin = new System.Windows.Forms.Padding(5);
            this.panel_izq.Name = "panel_izq";
            this.panel_izq.RowCount = 14;
            this.panel_izq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.52448F));
            this.panel_izq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.39109F));
            this.panel_izq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.478217F));
            this.panel_izq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.950108F));
            this.panel_izq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.004895F));
            this.panel_izq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.628059F));
            this.panel_izq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.514685F));
            this.panel_izq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.420372F));
            this.panel_izq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.300588F));
            this.panel_izq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.065166F));
            this.panel_izq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.692202F));
            this.panel_izq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.827795F));
            this.panel_izq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.601175F));
            this.panel_izq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.601175F));
            this.panel_izq.Size = new System.Drawing.Size(382, 585);
            this.panel_izq.TabIndex = 39;
            // 
            // lbl_busqueda_usuario
            // 
            this.lbl_busqueda_usuario.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_busqueda_usuario.AutoSize = true;
            this.lbl_busqueda_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busqueda_usuario.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_busqueda_usuario.Location = new System.Drawing.Point(85, 327);
            this.lbl_busqueda_usuario.Name = "lbl_busqueda_usuario";
            this.lbl_busqueda_usuario.Size = new System.Drawing.Size(212, 24);
            this.lbl_busqueda_usuario.TabIndex = 44;
            this.lbl_busqueda_usuario.Text = "NOMBRE DE USUARIO";
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
            this.btn_excel.Location = new System.Drawing.Point(79, 89);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(224, 40);
            this.btn_excel.TabIndex = 28;
            this.btn_excel.Text = "EXPORTAR EXCEL";
            this.btn_excel.TextColor = System.Drawing.Color.White;
            this.btn_excel.UseVisualStyleBackColor = false;
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btn_ver_cierres, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_ver_compras, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_ver_ventas, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(376, 67);
            this.tableLayoutPanel1.TabIndex = 39;
            // 
            // btn_ver_cierres
            // 
            this.btn_ver_cierres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ver_cierres.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_ver_cierres.BackgroundColor = System.Drawing.Color.OrangeRed;
            this.btn_ver_cierres.BorderColor = System.Drawing.Color.Red;
            this.btn_ver_cierres.BorderRadius = 10;
            this.btn_ver_cierres.BorderSize = 0;
            this.btn_ver_cierres.FlatAppearance.BorderSize = 0;
            this.btn_ver_cierres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ver_cierres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ver_cierres.ForeColor = System.Drawing.Color.Black;
            this.btn_ver_cierres.Location = new System.Drawing.Point(260, 11);
            this.btn_ver_cierres.Name = "btn_ver_cierres";
            this.btn_ver_cierres.Size = new System.Drawing.Size(106, 44);
            this.btn_ver_cierres.TabIndex = 31;
            this.btn_ver_cierres.Text = "Cierres";
            this.btn_ver_cierres.TextColor = System.Drawing.Color.Black;
            this.btn_ver_cierres.UseVisualStyleBackColor = false;
            this.btn_ver_cierres.Click += new System.EventHandler(this.btn_ver_cierres_Click);
            // 
            // btn_ver_compras
            // 
            this.btn_ver_compras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ver_compras.BackColor = System.Drawing.Color.Orange;
            this.btn_ver_compras.BackgroundColor = System.Drawing.Color.Orange;
            this.btn_ver_compras.BorderColor = System.Drawing.Color.Red;
            this.btn_ver_compras.BorderRadius = 10;
            this.btn_ver_compras.BorderSize = 0;
            this.btn_ver_compras.FlatAppearance.BorderSize = 0;
            this.btn_ver_compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ver_compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ver_compras.ForeColor = System.Drawing.Color.Black;
            this.btn_ver_compras.Location = new System.Drawing.Point(138, 11);
            this.btn_ver_compras.Name = "btn_ver_compras";
            this.btn_ver_compras.Size = new System.Drawing.Size(99, 44);
            this.btn_ver_compras.TabIndex = 30;
            this.btn_ver_compras.Text = "Compras";
            this.btn_ver_compras.TextColor = System.Drawing.Color.Black;
            this.btn_ver_compras.UseVisualStyleBackColor = false;
            this.btn_ver_compras.Click += new System.EventHandler(this.btn_ver_compras_Click);
            // 
            // btn_ver_ventas
            // 
            this.btn_ver_ventas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ver_ventas.BackColor = System.Drawing.Color.Gold;
            this.btn_ver_ventas.BackgroundColor = System.Drawing.Color.Gold;
            this.btn_ver_ventas.BorderColor = System.Drawing.Color.Red;
            this.btn_ver_ventas.BorderRadius = 10;
            this.btn_ver_ventas.BorderSize = 0;
            this.btn_ver_ventas.FlatAppearance.BorderSize = 0;
            this.btn_ver_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ver_ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ver_ventas.ForeColor = System.Drawing.Color.Black;
            this.btn_ver_ventas.Location = new System.Drawing.Point(6, 11);
            this.btn_ver_ventas.Name = "btn_ver_ventas";
            this.btn_ver_ventas.Size = new System.Drawing.Size(113, 44);
            this.btn_ver_ventas.TabIndex = 29;
            this.btn_ver_ventas.Text = "Ventas";
            this.btn_ver_ventas.TextColor = System.Drawing.Color.Black;
            this.btn_ver_ventas.UseVisualStyleBackColor = false;
            this.btn_ver_ventas.Click += new System.EventHandler(this.btn_ver_ventas_Click);
            // 
            // txt_busqueda_producto
            // 
            this.txt_busqueda_producto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_busqueda_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busqueda_producto.Location = new System.Drawing.Point(3, 408);
            this.txt_busqueda_producto.Name = "txt_busqueda_producto";
            this.txt_busqueda_producto.Size = new System.Drawing.Size(376, 26);
            this.txt_busqueda_producto.TabIndex = 43;
            // 
            // lbl_desde
            // 
            this.lbl_desde.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_desde.AutoSize = true;
            this.lbl_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desde.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_desde.Location = new System.Drawing.Point(119, 169);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(144, 24);
            this.lbl_desde.TabIndex = 34;
            this.lbl_desde.Text = "FECHA DESDE";
            // 
            // date_desde
            // 
            this.date_desde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date_desde.BorderColor = System.Drawing.Color.DarkCyan;
            this.date_desde.BorderSize = 0;
            this.date_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.date_desde.Location = new System.Drawing.Point(72, 201);
            this.date_desde.MinimumSize = new System.Drawing.Size(4, 35);
            this.date_desde.Name = "date_desde";
            this.date_desde.Size = new System.Drawing.Size(237, 35);
            this.date_desde.SkinColor = System.Drawing.Color.Teal;
            this.date_desde.TabIndex = 35;
            this.date_desde.TextColor = System.Drawing.Color.White;
            // 
            // lbl_hasta
            // 
            this.lbl_hasta.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_hasta.AutoSize = true;
            this.lbl_hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hasta.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_hasta.Location = new System.Drawing.Point(119, 253);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(144, 24);
            this.lbl_hasta.TabIndex = 36;
            this.lbl_hasta.Text = "FECHA HASTA";
            // 
            // date_hasta
            // 
            this.date_hasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date_hasta.BorderColor = System.Drawing.Color.DarkCyan;
            this.date_hasta.BorderSize = 0;
            this.date_hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.date_hasta.Location = new System.Drawing.Point(72, 281);
            this.date_hasta.MinimumSize = new System.Drawing.Size(4, 35);
            this.date_hasta.Name = "date_hasta";
            this.date_hasta.Size = new System.Drawing.Size(237, 35);
            this.date_hasta.SkinColor = System.Drawing.Color.Teal;
            this.date_hasta.TabIndex = 37;
            this.date_hasta.TextColor = System.Drawing.Color.White;
            // 
            // lbl_busqueda_producto
            // 
            this.lbl_busqueda_producto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_busqueda_producto.AutoSize = true;
            this.lbl_busqueda_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busqueda_producto.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_busqueda_producto.Location = new System.Drawing.Point(73, 381);
            this.lbl_busqueda_producto.Name = "lbl_busqueda_producto";
            this.lbl_busqueda_producto.Size = new System.Drawing.Size(235, 24);
            this.lbl_busqueda_producto.TabIndex = 41;
            this.lbl_busqueda_producto.Text = "NOMBRE DE PRODUCTO";
            // 
            // cbox_usuarios
            // 
            this.cbox_usuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbox_usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_usuarios.FormattingEnabled = true;
            this.cbox_usuarios.Location = new System.Drawing.Point(3, 354);
            this.cbox_usuarios.Name = "cbox_usuarios";
            this.cbox_usuarios.Size = new System.Drawing.Size(376, 28);
            this.cbox_usuarios.TabIndex = 45;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_buscar.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_buscar.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.btn_buscar.BorderColor = System.Drawing.Color.DarkGreen;
            this.btn_buscar.BorderRadius = 10;
            this.btn_buscar.BorderSize = 3;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_buscar.Location = new System.Drawing.Point(85, 537);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(212, 37);
            this.btn_buscar.TabIndex = 38;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.TextColor = System.Drawing.SystemColors.Desktop;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(392, 5);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(585, 585);
            this.tableLayoutPanel2.TabIndex = 40;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.dgv_historial, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(585, 287);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // dgv_historial
            // 
            this.dgv_historial.AllowUserToAddRows = false;
            this.dgv_historial.AllowUserToDeleteRows = false;
            this.dgv_historial.BackgroundColor = System.Drawing.Color.Black;
            this.dgv_historial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_historial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_historial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_historial.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_historial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_historial.EnableHeadersVisualStyles = false;
            this.dgv_historial.GridColor = System.Drawing.Color.White;
            this.dgv_historial.Location = new System.Drawing.Point(0, 5);
            this.dgv_historial.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.dgv_historial.Name = "dgv_historial";
            this.dgv_historial.ReadOnly = true;
            this.dgv_historial.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_historial.RowHeadersVisible = false;
            this.dgv_historial.Size = new System.Drawing.Size(580, 277);
            this.dgv_historial.TabIndex = 41;
            this.dgv_historial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_historial_CellContentClick);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.chart4, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.chart2, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.chart1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.chart3, 1, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 292);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(585, 293);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // chart4
            // 
            chartArea1.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart4.Legends.Add(legend1);
            this.chart4.Location = new System.Drawing.Point(3, 197);
            this.chart4.Name = "chart4";
            this.chart4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart4.Series.Add(series1);
            this.chart4.Size = new System.Drawing.Size(285, 92);
            this.chart4.TabIndex = 7;
            this.chart4.Text = "c_ventausuarioBarra";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(295, 51);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(285, 92);
            this.chart2.TabIndex = 5;
            this.chart2.Text = "c_ventageneralDona";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(3, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "VENTAS POR USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(295, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "VENTAS MENSUALES - GRAFICO DONA";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(3, 51);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(285, 92);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "c_ventageneralBarra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "VENTAS MENSUALES - GRAFICO BARRA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(295, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 48);
            this.label3.TabIndex = 3;
            this.label3.Text = "VENTAS MENSUALES USUARIOS-GRAFICO DONA";
            // 
            // chart3
            // 
            chartArea4.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart3.Legends.Add(legend4);
            this.chart3.Location = new System.Drawing.Point(295, 197);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart3.Series.Add(series4);
            this.chart3.Size = new System.Drawing.Size(285, 93);
            this.chart3.TabIndex = 6;
            this.chart3.Text = "c_ventausuarioDona";
            // 
            // formReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 611);
            this.Controls.Add(this.panel_main);
            this.Name = "formReportes";
            this.Text = "formStadistic";
            this.Load += new System.EventHandler(this.formEstadsticas_Load);
            this.panel_main.ResumeLayout(false);
            this.panel_bot.ResumeLayout(false);
            this.panel_bot.PerformLayout();
            this.panel_mid.ResumeLayout(false);
            this.panel_izq.ResumeLayout(false);
            this.panel_izq.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historial)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel_main;
        private System.Windows.Forms.TableLayoutPanel panel_mid;
        private System.Windows.Forms.TableLayoutPanel panel_izq;
        private CustomBox.RJControls.RJButton btn_buscar;
        private CustomBox.RJControls.RJDatePicker date_hasta;
        private System.Windows.Forms.Label lbl_hasta;
        private System.Windows.Forms.Label lbl_desde;
        private CustomBox.RJControls.RJButton btn_excel;
        private CustomBox.RJControls.RJDatePicker date_desde;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomBox.RJControls.RJButton btn_ver_compras;
        private CustomBox.RJControls.RJButton btn_ver_ventas;
        private System.Windows.Forms.Label lbl_busqueda_producto;
        private System.Windows.Forms.TextBox txt_busqueda_producto;
        private System.Windows.Forms.Label lbl_busqueda_usuario;
        private System.Windows.Forms.ComboBox cbox_usuarios;
        private CustomBox.RJControls.RJButton btn_ver_cierres;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dgv_historial;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.TableLayoutPanel panel_bot;
        private System.Windows.Forms.Label lbl_updateversion;
        private System.Windows.Forms.Label lbl_updatetime;
        private System.Windows.Forms.Label label2;
    }
}