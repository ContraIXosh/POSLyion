namespace PDCLyion
{
    partial class formStatistics
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.resumen_stadist = new System.Windows.Forms.Panel();
            this.stadist_cartesiano = new LiveCharts.WinForms.CartesianChart();
            this.stadist_cake = new LiveCharts.WinForms.PieChart();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            this.rjButton2 = new RJCodeAdvance.RJControls.RJButton();
            this.rjButton3 = new RJCodeAdvance.RJControls.RJButton();
            this.cat_usuario = new RJCodeAdvance.RJControls.RJComboBox();
            this.cat_producto = new RJCodeAdvance.RJControls.RJComboBox();
            this.cat_fecha = new CustomBox.RJControls.RJDatePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rjButton4 = new RJCodeAdvance.RJControls.RJButton();
            this.panel_main.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.Black;
            this.panel_main.Controls.Add(this.panel3);
            this.panel_main.Controls.Add(this.label3);
            this.panel_main.Controls.Add(this.label2);
            this.panel_main.Controls.Add(this.label1);
            this.panel_main.Controls.Add(this.panel2);
            this.panel_main.Controls.Add(this.resumen_stadist);
            this.panel_main.Controls.Add(this.stadist_cartesiano);
            this.panel_main.Controls.Add(this.stadist_cake);
            this.panel_main.Location = new System.Drawing.Point(0, -2);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(982, 541);
            this.panel_main.TabIndex = 0;
            this.panel_main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_main_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            this.panel2.Controls.Add(this.rjButton4);
            this.panel2.Controls.Add(this.cat_fecha);
            this.panel2.Controls.Add(this.cat_producto);
            this.panel2.Controls.Add(this.cat_usuario);
            this.panel2.Controls.Add(this.rjButton3);
            this.panel2.Controls.Add(this.rjButton2);
            this.panel2.Controls.Add(this.rjButton1);
            this.panel2.Location = new System.Drawing.Point(3, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 504);
            this.panel2.TabIndex = 8;
            // 
            // resumen_stadist
            // 
            this.resumen_stadist.BackColor = System.Drawing.Color.WhiteSmoke;
            this.resumen_stadist.Location = new System.Drawing.Point(649, 246);
            this.resumen_stadist.Name = "resumen_stadist";
            this.resumen_stadist.Size = new System.Drawing.Size(321, 201);
            this.resumen_stadist.TabIndex = 4;
            // 
            // stadist_cartesiano
            // 
            this.stadist_cartesiano.Location = new System.Drawing.Point(355, 39);
            this.stadist_cartesiano.Name = "stadist_cartesiano";
            this.stadist_cartesiano.Size = new System.Drawing.Size(592, 156);
            this.stadist_cartesiano.TabIndex = 3;
            this.stadist_cartesiano.Text = "cartesianChart1";
            // 
            // stadist_cake
            // 
            this.stadist_cake.Location = new System.Drawing.Point(355, 246);
            this.stadist_cake.Name = "stadist_cake";
            this.stadist_cake.Size = new System.Drawing.Size(272, 201);
            this.stadist_cake.TabIndex = 2;
            this.stadist_cake.Text = "pieChart1";
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(46, 23);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(200, 35);
            this.rjButton1.TabIndex = 9;
            this.rjButton1.Text = "ACTUALIZAR ESTADO";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 0;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(46, 90);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(200, 35);
            this.rjButton2.TabIndex = 10;
            this.rjButton2.Text = "EXPORTAR EXCEL";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton3.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton3.BorderRadius = 0;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Location = new System.Drawing.Point(46, 155);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(200, 35);
            this.rjButton3.TabIndex = 11;
            this.rjButton3.Text = "EXPORTAR VISUAL";
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            // 
            // cat_usuario
            // 
            this.cat_usuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cat_usuario.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cat_usuario.BorderSize = 1;
            this.cat_usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cat_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cat_usuario.ForeColor = System.Drawing.Color.DimGray;
            this.cat_usuario.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cat_usuario.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cat_usuario.ListTextColor = System.Drawing.Color.DimGray;
            this.cat_usuario.Location = new System.Drawing.Point(46, 221);
            this.cat_usuario.MinimumSize = new System.Drawing.Size(200, 30);
            this.cat_usuario.Name = "cat_usuario";
            this.cat_usuario.Padding = new System.Windows.Forms.Padding(1);
            this.cat_usuario.Size = new System.Drawing.Size(200, 30);
            this.cat_usuario.TabIndex = 12;
            this.cat_usuario.Texts = "";
            // 
            // cat_producto
            // 
            this.cat_producto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cat_producto.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cat_producto.BorderSize = 1;
            this.cat_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cat_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cat_producto.ForeColor = System.Drawing.Color.DimGray;
            this.cat_producto.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cat_producto.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cat_producto.ListTextColor = System.Drawing.Color.DimGray;
            this.cat_producto.Location = new System.Drawing.Point(46, 283);
            this.cat_producto.MinimumSize = new System.Drawing.Size(200, 30);
            this.cat_producto.Name = "cat_producto";
            this.cat_producto.Padding = new System.Windows.Forms.Padding(1);
            this.cat_producto.Size = new System.Drawing.Size(200, 30);
            this.cat_producto.TabIndex = 13;
            this.cat_producto.Texts = "";
            // 
            // cat_fecha
            // 
            this.cat_fecha.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cat_fecha.BorderSize = 0;
            this.cat_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.cat_fecha.Location = new System.Drawing.Point(46, 343);
            this.cat_fecha.MinimumSize = new System.Drawing.Size(0, 35);
            this.cat_fecha.Name = "cat_fecha";
            this.cat_fecha.Size = new System.Drawing.Size(200, 35);
            this.cat_fecha.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.cat_fecha.TabIndex = 14;
            this.cat_fecha.TextColor = System.Drawing.Color.White;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(529, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "GRAFICO DE VELAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(372, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "GRAFICO DE TORTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(752, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "RESUMEN";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Khaki;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(0, 460);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(987, 18);
            this.panel3.TabIndex = 12;
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
            // rjButton4
            // 
            this.rjButton4.BackColor = System.Drawing.Color.Transparent;
            this.rjButton4.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton4.BorderColor = System.Drawing.Color.Chartreuse;
            this.rjButton4.BorderRadius = 7;
            this.rjButton4.BorderSize = 2;
            this.rjButton4.FlatAppearance.BorderSize = 0;
            this.rjButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton4.ForeColor = System.Drawing.Color.Lime;
            this.rjButton4.Location = new System.Drawing.Point(69, 396);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Size = new System.Drawing.Size(150, 40);
            this.rjButton4.TabIndex = 15;
            this.rjButton4.Text = "Regresar";
            this.rjButton4.TextColor = System.Drawing.Color.Lime;
            this.rjButton4.UseVisualStyleBackColor = false;
            this.rjButton4.Click += new System.EventHandler(this.rjButton4_Click);
            // 
            // formStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 537);
            this.Controls.Add(this.panel_main);
            this.Name = "formStatistics";
            this.Text = "formStatistics";
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel resumen_stadist;
        private LiveCharts.WinForms.CartesianChart stadist_cartesiano;
        private LiveCharts.WinForms.PieChart stadist_cake;
        private System.Windows.Forms.Panel panel2;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private RJCodeAdvance.RJControls.RJComboBox cat_producto;
        private RJCodeAdvance.RJControls.RJComboBox cat_usuario;
        private RJCodeAdvance.RJControls.RJButton rjButton3;
        private RJCodeAdvance.RJControls.RJButton rjButton2;
        private CustomBox.RJControls.RJDatePicker cat_fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private RJCodeAdvance.RJControls.RJButton rjButton4;
    }
}