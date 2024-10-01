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
            this.panel_main = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.resumen_stadist = new System.Windows.Forms.Panel();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.stadist_cartesiano = new LiveCharts.WinForms.CartesianChart();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_update = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_izq = new System.Windows.Forms.TableLayoutPanel();
            this.rjButton4 = new CustomBox.RJControls.RJButton();
            this.rjButton3 = new CustomBox.RJControls.RJButton();
            this.rjDatePicker2 = new CustomBox.RJControls.RJDatePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rjComboBox2 = new CustomBox.RJControls.RJComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rjComboBox1 = new CustomBox.RJControls.RJComboBox();
            this.rjButton1 = new CustomBox.RJControls.RJButton();
            this.rjButton2 = new CustomBox.RJControls.RJButton();
            this.label6 = new System.Windows.Forms.Label();
            this.rjDatePicker1 = new CustomBox.RJControls.RJDatePicker();
            this.panel_main.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel_update.SuspendLayout();
            this.panel_izq.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_main.Controls.Add(this.tableLayoutPanel2);
            this.panel_main.Controls.Add(this.panel_izq);
            this.panel_main.Controls.Add(this.panel_update);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(982, 537);
            this.panel_main.TabIndex = 28;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.resumen_stadist, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.pieChart1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.stadist_cartesiano, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(329, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.099265F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.36029F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.099265F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.44118F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(653, 519);
            this.tableLayoutPanel2.TabIndex = 30;
            // 
            // resumen_stadist
            // 
            this.resumen_stadist.BackColor = System.Drawing.Color.WhiteSmoke;
            this.resumen_stadist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resumen_stadist.Location = new System.Drawing.Point(3, 311);
            this.resumen_stadist.Name = "resumen_stadist";
            this.resumen_stadist.Size = new System.Drawing.Size(320, 205);
            this.resumen_stadist.TabIndex = 4;
            // 
            // pieChart1
            // 
            this.pieChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChart1.Location = new System.Drawing.Point(329, 50);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(321, 208);
            this.pieChart1.TabIndex = 5;
            this.pieChart1.Text = "pieChart1";
            // 
            // stadist_cartesiano
            // 
            this.stadist_cartesiano.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stadist_cartesiano.Location = new System.Drawing.Point(3, 50);
            this.stadist_cartesiano.Name = "stadist_cartesiano";
            this.stadist_cartesiano.Size = new System.Drawing.Size(320, 208);
            this.stadist_cartesiano.TabIndex = 3;
            this.stadist_cartesiano.Text = "cartesianChart1";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(47, 11);
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
            this.label1.Location = new System.Drawing.Point(372, 11);
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
            this.label2.Location = new System.Drawing.Point(101, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "RESUMEN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_update
            // 
            this.panel_update.BackColor = System.Drawing.Color.Khaki;
            this.panel_update.Controls.Add(this.label4);
            this.panel_update.Controls.Add(this.label5);
            this.panel_update.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_update.Location = new System.Drawing.Point(0, 519);
            this.panel_update.Name = "panel_update";
            this.panel_update.Size = new System.Drawing.Size(982, 18);
            this.panel_update.TabIndex = 31;
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
            // panel_izq
            // 
            this.panel_izq.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel_izq.ColumnCount = 1;
            this.panel_izq.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_izq.Controls.Add(this.rjButton4, 0, 11);
            this.panel_izq.Controls.Add(this.rjButton3, 0, 10);
            this.panel_izq.Controls.Add(this.rjDatePicker2, 0, 9);
            this.panel_izq.Controls.Add(this.label9, 0, 8);
            this.panel_izq.Controls.Add(this.label8, 0, 6);
            this.panel_izq.Controls.Add(this.rjComboBox2, 0, 5);
            this.panel_izq.Controls.Add(this.label7, 0, 4);
            this.panel_izq.Controls.Add(this.rjComboBox1, 0, 3);
            this.panel_izq.Controls.Add(this.rjButton1, 0, 0);
            this.panel_izq.Controls.Add(this.rjButton2, 0, 1);
            this.panel_izq.Controls.Add(this.label6, 0, 2);
            this.panel_izq.Controls.Add(this.rjDatePicker1, 0, 7);
            this.panel_izq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_izq.Location = new System.Drawing.Point(0, 0);
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
            this.panel_izq.Size = new System.Drawing.Size(329, 519);
            this.panel_izq.TabIndex = 33;
            // 
            // rjButton4
            // 
            this.rjButton4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rjButton4.BackColor = System.Drawing.Color.Transparent;
            this.rjButton4.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton4.BorderColor = System.Drawing.Color.Red;
            this.rjButton4.BorderRadius = 10;
            this.rjButton4.BorderSize = 2;
            this.rjButton4.FlatAppearance.BorderSize = 0;
            this.rjButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton4.ForeColor = System.Drawing.Color.Red;
            this.rjButton4.Location = new System.Drawing.Point(58, 482);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Size = new System.Drawing.Size(212, 34);
            this.rjButton4.TabIndex = 39;
            this.rjButton4.Text = "Regresar";
            this.rjButton4.TextColor = System.Drawing.Color.Red;
            this.rjButton4.UseVisualStyleBackColor = false;
            this.rjButton4.Click += new System.EventHandler(this.rjButton4_Click_1);
            // 
            // rjButton3
            // 
            this.rjButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjButton3.BackColor = System.Drawing.Color.Green;
            this.rjButton3.BackgroundColor = System.Drawing.Color.Green;
            this.rjButton3.BorderColor = System.Drawing.Color.Red;
            this.rjButton3.BorderRadius = 10;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Location = new System.Drawing.Point(58, 430);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(212, 46);
            this.rjButton3.TabIndex = 38;
            this.rjButton3.Text = "BUSCAR";
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            // 
            // rjDatePicker2
            // 
            this.rjDatePicker2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjDatePicker2.BorderColor = System.Drawing.Color.DodgerBlue;
            this.rjDatePicker2.BorderSize = 0;
            this.rjDatePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.rjDatePicker2.Location = new System.Drawing.Point(46, 383);
            this.rjDatePicker2.MinimumSize = new System.Drawing.Size(4, 35);
            this.rjDatePicker2.Name = "rjDatePicker2";
            this.rjDatePicker2.Size = new System.Drawing.Size(237, 35);
            this.rjDatePicker2.SkinColor = System.Drawing.Color.DodgerBlue;
            this.rjDatePicker2.TabIndex = 37;
            this.rjDatePicker2.TextColor = System.Drawing.Color.White;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGreen;
            this.label9.Location = new System.Drawing.Point(87, 348);
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
            this.label8.Location = new System.Drawing.Point(87, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 22);
            this.label8.TabIndex = 34;
            this.label8.Text = "FECHA DESDE";
            // 
            // rjComboBox2
            // 
            this.rjComboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjComboBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBox2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox2.BorderSize = 1;
            this.rjComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rjComboBox2.ForeColor = System.Drawing.Color.DimGray;
            this.rjComboBox2.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox2.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjComboBox2.ListTextColor = System.Drawing.Color.DimGray;
            this.rjComboBox2.Location = new System.Drawing.Point(58, 225);
            this.rjComboBox2.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBox2.Name = "rjComboBox2";
            this.rjComboBox2.Padding = new System.Windows.Forms.Padding(1);
            this.rjComboBox2.Size = new System.Drawing.Size(212, 30);
            this.rjComboBox2.TabIndex = 33;
            this.rjComboBox2.Texts = "";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(122, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 22);
            this.label7.TabIndex = 32;
            this.label7.Text = "TURNO";
            // 
            // rjComboBox1
            // 
            this.rjComboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjComboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox1.BorderSize = 1;
            this.rjComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rjComboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.rjComboBox1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjComboBox1.ListTextColor = System.Drawing.Color.DimGray;
            this.rjComboBox1.Location = new System.Drawing.Point(58, 148);
            this.rjComboBox1.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBox1.Name = "rjComboBox1";
            this.rjComboBox1.Padding = new System.Windows.Forms.Padding(1);
            this.rjComboBox1.Size = new System.Drawing.Size(212, 30);
            this.rjComboBox1.TabIndex = 31;
            this.rjComboBox1.Texts = "";
            // 
            // rjButton1
            // 
            this.rjButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjButton1.BackColor = System.Drawing.Color.Green;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Green;
            this.rjButton1.BorderColor = System.Drawing.Color.Red;
            this.rjButton1.BorderRadius = 10;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(52, 3);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(224, 46);
            this.rjButton1.TabIndex = 28;
            this.rjButton1.Text = "EXPORTAR EXCEL";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // rjButton2
            // 
            this.rjButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjButton2.BackColor = System.Drawing.Color.Green;
            this.rjButton2.BackgroundColor = System.Drawing.Color.Green;
            this.rjButton2.BorderColor = System.Drawing.Color.Red;
            this.rjButton2.BorderRadius = 10;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(52, 56);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(224, 53);
            this.rjButton2.TabIndex = 29;
            this.rjButton2.Text = "EXPORTAR BASE DE DATOS";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(111, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 22);
            this.label6.TabIndex = 30;
            this.label6.Text = "USUARIO";
            // 
            // rjDatePicker1
            // 
            this.rjDatePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjDatePicker1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.rjDatePicker1.BorderSize = 0;
            this.rjDatePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.rjDatePicker1.Location = new System.Drawing.Point(46, 300);
            this.rjDatePicker1.MinimumSize = new System.Drawing.Size(4, 35);
            this.rjDatePicker1.Name = "rjDatePicker1";
            this.rjDatePicker1.Size = new System.Drawing.Size(237, 35);
            this.rjDatePicker1.SkinColor = System.Drawing.Color.DodgerBlue;
            this.rjDatePicker1.TabIndex = 35;
            this.rjDatePicker1.TextColor = System.Drawing.Color.White;
            // 
            // formStadistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 537);
            this.Controls.Add(this.panel_main);
            this.Name = "formStadistic";
            this.Text = "formStadistic";
            this.panel_main.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel_update.ResumeLayout(false);
            this.panel_update.PerformLayout();
            this.panel_izq.ResumeLayout(false);
            this.panel_izq.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel resumen_stadist;
        private LiveCharts.WinForms.PieChart pieChart1;
        private LiveCharts.WinForms.CartesianChart stadist_cartesiano;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_update;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel panel_izq;
        private CustomBox.RJControls.RJButton rjButton4;
        private CustomBox.RJControls.RJButton rjButton3;
        private CustomBox.RJControls.RJDatePicker rjDatePicker2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private CustomBox.RJControls.RJComboBox rjComboBox2;
        private System.Windows.Forms.Label label7;
        private CustomBox.RJControls.RJComboBox rjComboBox1;
        private CustomBox.RJControls.RJButton rjButton1;
        private CustomBox.RJControls.RJButton rjButton2;
        private System.Windows.Forms.Label label6;
        private CustomBox.RJControls.RJDatePicker rjDatePicker1;
    }
}