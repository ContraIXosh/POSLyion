namespace POSLyion
{
    partial class formCambio
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
            this.lbl_mp = new System.Windows.Forms.Label();
            this.lbl_tarjeta = new System.Windows.Forms.Label();
            this.lbl_efectivo = new System.Windows.Forms.Label();
            this.txt_modificarprecio = new CustomBox.RJControls.RJTextBox();
            this.btn_tipocambio = new CustomBox.RJControls.RJButton();
            this.btn_cancelar = new CustomBox.RJControls.RJButton();
            this.btn_cobrar = new CustomBox.RJControls.RJButton();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_main.Controls.Add(this.lbl_mp);
            this.panel_main.Controls.Add(this.lbl_tarjeta);
            this.panel_main.Controls.Add(this.lbl_efectivo);
            this.panel_main.Controls.Add(this.txt_modificarprecio);
            this.panel_main.Controls.Add(this.btn_tipocambio);
            this.panel_main.Controls.Add(this.btn_cancelar);
            this.panel_main.Controls.Add(this.btn_cobrar);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(779, 362);
            this.panel_main.TabIndex = 1;
            // 
            // lbl_mp
            // 
            this.lbl_mp.AutoSize = true;
            this.lbl_mp.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_mp.Location = new System.Drawing.Point(491, 87);
            this.lbl_mp.Name = "lbl_mp";
            this.lbl_mp.Size = new System.Drawing.Size(185, 21);
            this.lbl_mp.TabIndex = 6;
            this.lbl_mp.Text = "$0,00 Mercado Pago";
            // 
            // lbl_tarjeta
            // 
            this.lbl_tarjeta.AutoSize = true;
            this.lbl_tarjeta.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tarjeta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_tarjeta.Location = new System.Drawing.Point(496, 87);
            this.lbl_tarjeta.Name = "lbl_tarjeta";
            this.lbl_tarjeta.Size = new System.Drawing.Size(128, 21);
            this.lbl_tarjeta.TabIndex = 5;
            this.lbl_tarjeta.Text = "$0,00 Tarjeta";
            // 
            // lbl_efectivo
            // 
            this.lbl_efectivo.AutoSize = true;
            this.lbl_efectivo.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_efectivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_efectivo.Location = new System.Drawing.Point(496, 86);
            this.lbl_efectivo.Name = "lbl_efectivo";
            this.lbl_efectivo.Size = new System.Drawing.Size(137, 21);
            this.lbl_efectivo.TabIndex = 4;
            this.lbl_efectivo.Text = "$0,00 Efectivo";
            // 
            // txt_modificarprecio
            // 
            this.txt_modificarprecio.BackColor = System.Drawing.SystemColors.Window;
            this.txt_modificarprecio.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_modificarprecio.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_modificarprecio.BorderRadius = 0;
            this.txt_modificarprecio.BorderSize = 2;
            this.txt_modificarprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_modificarprecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_modificarprecio.Location = new System.Drawing.Point(18, 82);
            this.txt_modificarprecio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_modificarprecio.Multiline = false;
            this.txt_modificarprecio.Name = "txt_modificarprecio";
            this.txt_modificarprecio.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_modificarprecio.PasswordChar = false;
            this.txt_modificarprecio.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_modificarprecio.PlaceholderText = "";
            this.txt_modificarprecio.Size = new System.Drawing.Size(466, 31);
            this.txt_modificarprecio.TabIndex = 3;
            this.txt_modificarprecio.Texts = "";
            this.txt_modificarprecio.UnderlinedStyle = false;
            this.txt_modificarprecio._TextChanged += new System.EventHandler(this.txt_modificarprecio__TextChanged);
            // 
            // btn_tipocambio
            // 
            this.btn_tipocambio.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_tipocambio.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_tipocambio.BorderColor = System.Drawing.Color.Red;
            this.btn_tipocambio.BorderRadius = 10;
            this.btn_tipocambio.BorderSize = 0;
            this.btn_tipocambio.FlatAppearance.BorderSize = 0;
            this.btn_tipocambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tipocambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tipocambio.ForeColor = System.Drawing.Color.White;
            this.btn_tipocambio.Location = new System.Drawing.Point(12, 217);
            this.btn_tipocambio.Name = "btn_tipocambio";
            this.btn_tipocambio.Size = new System.Drawing.Size(172, 40);
            this.btn_tipocambio.TabIndex = 2;
            this.btn_tipocambio.Text = "TIPO DE CAMBIO";
            this.btn_tipocambio.TextColor = System.Drawing.Color.White;
            this.btn_tipocambio.UseVisualStyleBackColor = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_cancelar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_cancelar.BorderColor = System.Drawing.Color.Red;
            this.btn_cancelar.BorderRadius = 10;
            this.btn_cancelar.BorderSize = 0;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(505, 217);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(172, 40);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.TextColor = System.Drawing.Color.White;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_cobrar
            // 
            this.btn_cobrar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_cobrar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_cobrar.BorderColor = System.Drawing.Color.Red;
            this.btn_cobrar.BorderRadius = 10;
            this.btn_cobrar.BorderSize = 0;
            this.btn_cobrar.FlatAppearance.BorderSize = 0;
            this.btn_cobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cobrar.ForeColor = System.Drawing.Color.White;
            this.btn_cobrar.Location = new System.Drawing.Point(263, 217);
            this.btn_cobrar.Name = "btn_cobrar";
            this.btn_cobrar.Size = new System.Drawing.Size(172, 40);
            this.btn_cobrar.TabIndex = 0;
            this.btn_cobrar.Text = "COBRAR";
            this.btn_cobrar.TextColor = System.Drawing.Color.White;
            this.btn_cobrar.UseVisualStyleBackColor = false;
            this.btn_cobrar.Click += new System.EventHandler(this.btn_cobrar_Click);
            // 
            // formCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 362);
            this.Controls.Add(this.panel_main);
            this.Name = "formCambio";
            this.Text = "formprueba";
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label lbl_mp;
        private System.Windows.Forms.Label lbl_tarjeta;
        private System.Windows.Forms.Label lbl_efectivo;
        private CustomBox.RJControls.RJTextBox txt_modificarprecio;
        private CustomBox.RJControls.RJButton btn_tipocambio;
        private CustomBox.RJControls.RJButton btn_cancelar;
        private CustomBox.RJControls.RJButton btn_cobrar;
    }
}