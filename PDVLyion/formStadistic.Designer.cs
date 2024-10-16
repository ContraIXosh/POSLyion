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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.panel_main = new System.Windows.Forms.TableLayoutPanel();
            this.panel_update = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_mid = new System.Windows.Forms.TableLayoutPanel();
            this.panel_izq = new System.Windows.Forms.TableLayoutPanel();
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.graf_velas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graf_torta = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label10 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel_main.SuspendLayout();
            this.panel_update.SuspendLayout();
            this.panel_mid.SuspendLayout();
            this.panel_izq.SuspendLayout();
            this.panel_stadistic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graf_velas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graf_torta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_main.ColumnCount = 1;
            this.panel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_main.Controls.Add(this.panel_update, 0, 1);
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
            this.panel_izq.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.panel_izq.Size = new System.Drawing.Size(294, 595);
            this.panel_izq.TabIndex = 39;
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
            this.btn_search.Location = new System.Drawing.Point(41, 501);
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
            this.date_hasta.Location = new System.Drawing.Point(28, 447);
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
            this.label9.Location = new System.Drawing.Point(69, 406);
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
            this.label8.Location = new System.Drawing.Point(69, 310);
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
            this.cbox_turno.Location = new System.Drawing.Point(41, 264);
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
            this.label7.Location = new System.Drawing.Point(105, 223);
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
            this.cbox_user.Location = new System.Drawing.Point(41, 174);
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
            this.btn_excel.Location = new System.Drawing.Point(35, 6);
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
            this.btn_sql.Location = new System.Drawing.Point(11, 71);
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
            this.label6.Location = new System.Drawing.Point(94, 136);
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
            this.date_desde.Location = new System.Drawing.Point(28, 351);
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
            this.panel_stadistic.Controls.Add(this.label10, 0, 2);
            this.panel_stadistic.Controls.Add(this.chart1, 0, 3);
            this.panel_stadistic.Controls.Add(this.graf_torta, 1, 1);
            this.panel_stadistic.Controls.Add(this.label3, 0, 0);
            this.panel_stadistic.Controls.Add(this.label1, 1, 0);
            this.panel_stadistic.Controls.Add(this.graf_velas, 0, 1);
            this.panel_stadistic.Controls.Add(this.label2, 1, 2);
            this.panel_stadistic.Controls.Add(this.resumen_stadist, 1, 3);
            this.panel_stadistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_stadistic.Location = new System.Drawing.Point(294, 0);
            this.panel_stadistic.Margin = new System.Windows.Forms.Padding(0);
            this.panel_stadistic.Name = "panel_stadistic";
            this.panel_stadistic.RowCount = 4;
            this.panel_stadistic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.099265F));
            this.panel_stadistic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.36029F));
            this.panel_stadistic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.099265F));
            this.panel_stadistic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.44118F));
            this.panel_stadistic.Size = new System.Drawing.Size(688, 595);
            this.panel_stadistic.TabIndex = 37;
            // 
            // resumen_stadist
            // 
            this.resumen_stadist.BackColor = System.Drawing.Color.WhiteSmoke;
            this.resumen_stadist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resumen_stadist.Location = new System.Drawing.Point(347, 357);
            this.resumen_stadist.Name = "resumen_stadist";
            this.resumen_stadist.Size = new System.Drawing.Size(338, 235);
            this.resumen_stadist.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(56, 14);
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
            this.label1.Location = new System.Drawing.Point(399, 14);
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
            this.label2.Location = new System.Drawing.Point(454, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "RESUMEN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // graf_velas
            // 
            this.graf_velas.BackColor = System.Drawing.Color.Transparent;
            chartArea10.Name = "ChartArea1";
            this.graf_velas.ChartAreas.Add(chartArea10);
            this.graf_velas.Dock = System.Windows.Forms.DockStyle.Fill;
            legend10.Name = "Legend1";
            this.graf_velas.Legends.Add(legend10);
            this.graf_velas.Location = new System.Drawing.Point(3, 57);
            this.graf_velas.Name = "graf_velas";
            this.graf_velas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            series10.Points.Add(dataPoint10);
            this.graf_velas.Series.Add(series10);
            this.graf_velas.Size = new System.Drawing.Size(338, 240);
            this.graf_velas.TabIndex = 12;
            this.graf_velas.Text = "chart1";
            // 
            // graf_torta
            // 
            this.graf_torta.BackColor = System.Drawing.Color.Transparent;
            chartArea11.Name = "ChartArea1";
            this.graf_torta.ChartAreas.Add(chartArea11);
            this.graf_torta.Dock = System.Windows.Forms.DockStyle.Fill;
            legend11.Name = "Legend1";
            this.graf_torta.Legends.Add(legend11);
            this.graf_torta.Location = new System.Drawing.Point(347, 57);
            this.graf_torta.Name = "graf_torta";
            this.graf_torta.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            series11.Points.Add(dataPoint11);
            this.graf_torta.Series.Add(series11);
            this.graf_torta.Size = new System.Drawing.Size(338, 240);
            this.graf_torta.TabIndex = 13;
            this.graf_torta.Text = "chart2";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gold;
            this.label10.Location = new System.Drawing.Point(46, 314);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(251, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "GRAFICO DE PUNTOS";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea12.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea12);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend12.Name = "Legend1";
            this.chart1.Legends.Add(legend12);
            this.chart1.Location = new System.Drawing.Point(3, 357);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            series12.Points.Add(dataPoint12);
            this.chart1.Series.Add(series12);
            this.chart1.Size = new System.Drawing.Size(338, 235);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart2";
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
            this.panel_update.ResumeLayout(false);
            this.panel_update.PerformLayout();
            this.panel_mid.ResumeLayout(false);
            this.panel_izq.ResumeLayout(false);
            this.panel_izq.PerformLayout();
            this.panel_stadistic.ResumeLayout(false);
            this.panel_stadistic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graf_velas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graf_torta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel_main;
        private System.Windows.Forms.Panel panel_update;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel panel_mid;
        private System.Windows.Forms.TableLayoutPanel panel_izq;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart graf_velas;
        private System.Windows.Forms.DataVisualization.Charting.Chart graf_torta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}