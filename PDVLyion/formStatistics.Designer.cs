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
            this.btn_grafico = new System.Windows.Forms.Button();
            this.stadist_cake = new LiveCharts.WinForms.PieChart();
            this.stadist_cartesiano = new LiveCharts.WinForms.CartesianChart();
            this.resumen_stadist = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dia_mes_año = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.user_system = new System.Windows.Forms.ComboBox();
            this.panel_main.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.Black;
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
            // btn_grafico
            // 
            this.btn_grafico.Location = new System.Drawing.Point(39, 48);
            this.btn_grafico.Name = "btn_grafico";
            this.btn_grafico.Size = new System.Drawing.Size(145, 27);
            this.btn_grafico.TabIndex = 1;
            this.btn_grafico.Text = "Actualizar ventas";
            this.btn_grafico.UseVisualStyleBackColor = true;
            this.btn_grafico.Click += new System.EventHandler(this.btn_grafico_Click);
            // 
            // stadist_cake
            // 
            this.stadist_cake.Location = new System.Drawing.Point(355, 308);
            this.stadist_cake.Name = "stadist_cake";
            this.stadist_cake.Size = new System.Drawing.Size(272, 201);
            this.stadist_cake.TabIndex = 2;
            this.stadist_cake.Text = "pieChart1";
            // 
            // stadist_cartesiano
            // 
            this.stadist_cartesiano.Location = new System.Drawing.Point(355, 114);
            this.stadist_cartesiano.Name = "stadist_cartesiano";
            this.stadist_cartesiano.Size = new System.Drawing.Size(615, 173);
            this.stadist_cartesiano.TabIndex = 3;
            this.stadist_cartesiano.Text = "cartesianChart1";
            // 
            // resumen_stadist
            // 
            this.resumen_stadist.BackColor = System.Drawing.Color.WhiteSmoke;
            this.resumen_stadist.Location = new System.Drawing.Point(648, 291);
            this.resumen_stadist.Name = "resumen_stadist";
            this.resumen_stadist.Size = new System.Drawing.Size(321, 228);
            this.resumen_stadist.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exportar excel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "Importar visual";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dia_mes_año
            // 
            this.dia_mes_año.FormattingEnabled = true;
            this.dia_mes_año.Location = new System.Drawing.Point(39, 242);
            this.dia_mes_año.Name = "dia_mes_año";
            this.dia_mes_año.Size = new System.Drawing.Size(145, 21);
            this.dia_mes_año.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(29)))));
            this.panel2.Controls.Add(this.user_system);
            this.panel2.Controls.Add(this.btn_grafico);
            this.panel2.Controls.Add(this.dia_mes_año);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(133, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 504);
            this.panel2.TabIndex = 8;
            // 
            // user_system
            // 
            this.user_system.FormattingEnabled = true;
            this.user_system.Location = new System.Drawing.Point(39, 298);
            this.user_system.Name = "user_system";
            this.user_system.Size = new System.Drawing.Size(145, 21);
            this.user_system.TabIndex = 8;
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
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Button btn_grafico;
        private System.Windows.Forms.Panel resumen_stadist;
        private LiveCharts.WinForms.CartesianChart stadist_cartesiano;
        private LiveCharts.WinForms.PieChart stadist_cake;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox dia_mes_año;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox user_system;
    }
}