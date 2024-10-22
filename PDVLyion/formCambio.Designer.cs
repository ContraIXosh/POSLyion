﻿namespace PDCLyion
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
            this.lbl_vuelto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_tipocambio = new RJCodeAdvance.RJControls.RJComboBox();
            this.txt_modificarprecio = new System.Windows.Forms.TextBox();
            this.lbl_mp = new System.Windows.Forms.Label();
            this.lbl_cambio = new System.Windows.Forms.Label();
            this.lbl_tarjeta = new System.Windows.Forms.Label();
            this.lbl_efectivo = new System.Windows.Forms.Label();
            this.btn_cancelar = new CustomBox.RJControls.RJButton();
            this.btn_cobrar = new CustomBox.RJControls.RJButton();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_main.Controls.Add(this.lbl_vuelto);
            this.panel_main.Controls.Add(this.label1);
            this.panel_main.Controls.Add(this.cbox_tipocambio);
            this.panel_main.Controls.Add(this.txt_modificarprecio);
            this.panel_main.Controls.Add(this.lbl_mp);
            this.panel_main.Controls.Add(this.lbl_cambio);
            this.panel_main.Controls.Add(this.lbl_tarjeta);
            this.panel_main.Controls.Add(this.lbl_efectivo);
            this.panel_main.Controls.Add(this.btn_cancelar);
            this.panel_main.Controls.Add(this.btn_cobrar);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(779, 362);
            this.panel_main.TabIndex = 1;
            // 
            // lbl_vuelto
            // 
            this.lbl_vuelto.AutoSize = true;
            this.lbl_vuelto.Font = new System.Drawing.Font("Kitchener", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vuelto.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_vuelto.Location = new System.Drawing.Point(21, 243);
            this.lbl_vuelto.Name = "lbl_vuelto";
            this.lbl_vuelto.Size = new System.Drawing.Size(155, 37);
            this.lbl_vuelto.TabIndex = 12;
            this.lbl_vuelto.Text = "Vuelto: $0,00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Holguin Stamp", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 75);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cierre de venta";
            // 
            // cbox_tipocambio
            // 
            this.cbox_tipocambio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbox_tipocambio.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbox_tipocambio.BorderSize = 1;
            this.cbox_tipocambio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbox_tipocambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbox_tipocambio.ForeColor = System.Drawing.Color.DimGray;
            this.cbox_tipocambio.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbox_tipocambio.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbox_tipocambio.ListTextColor = System.Drawing.Color.DimGray;
            this.cbox_tipocambio.Location = new System.Drawing.Point(407, 87);
            this.cbox_tipocambio.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbox_tipocambio.Name = "cbox_tipocambio";
            this.cbox_tipocambio.Padding = new System.Windows.Forms.Padding(1);
            this.cbox_tipocambio.Size = new System.Drawing.Size(311, 30);
            this.cbox_tipocambio.TabIndex = 9;
            this.cbox_tipocambio.Texts = "";
            // 
            // txt_modificarprecio
            // 
            this.txt_modificarprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_modificarprecio.Location = new System.Drawing.Point(23, 87);
            this.txt_modificarprecio.Name = "txt_modificarprecio";
            this.txt_modificarprecio.Size = new System.Drawing.Size(311, 31);
            this.txt_modificarprecio.TabIndex = 8;
            // 
            // lbl_mp
            // 
            this.lbl_mp.AutoSize = true;
            this.lbl_mp.Font = new System.Drawing.Font("Kitchener", 27.75F);
            this.lbl_mp.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_mp.Location = new System.Drawing.Point(528, 183);
            this.lbl_mp.Name = "lbl_mp";
            this.lbl_mp.Size = new System.Drawing.Size(219, 37);
            this.lbl_mp.TabIndex = 7;
            this.lbl_mp.Text = "$0,00 Mercado Pago";
            // 
            // lbl_cambio
            // 
            this.lbl_cambio.AutoSize = true;
            this.lbl_cambio.Font = new System.Drawing.Font("Kitchener", 27.75F);
            this.lbl_cambio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_cambio.Location = new System.Drawing.Point(21, 131);
            this.lbl_cambio.Name = "lbl_cambio";
            this.lbl_cambio.Size = new System.Drawing.Size(146, 37);
            this.lbl_cambio.TabIndex = 6;
            this.lbl_cambio.Text = "Total: $0,00";
            // 
            // lbl_tarjeta
            // 
            this.lbl_tarjeta.AutoSize = true;
            this.lbl_tarjeta.Font = new System.Drawing.Font("Kitchener", 27.75F);
            this.lbl_tarjeta.ForeColor = System.Drawing.Color.Orange;
            this.lbl_tarjeta.Location = new System.Drawing.Point(291, 183);
            this.lbl_tarjeta.Name = "lbl_tarjeta";
            this.lbl_tarjeta.Size = new System.Drawing.Size(162, 37);
            this.lbl_tarjeta.TabIndex = 5;
            this.lbl_tarjeta.Text = "$0,00 Tarjeta";
            // 
            // lbl_efectivo
            // 
            this.lbl_efectivo.AutoSize = true;
            this.lbl_efectivo.Font = new System.Drawing.Font("Kitchener", 27.75F);
            this.lbl_efectivo.ForeColor = System.Drawing.Color.YellowGreen;
            this.lbl_efectivo.Location = new System.Drawing.Point(21, 183);
            this.lbl_efectivo.Name = "lbl_efectivo";
            this.lbl_efectivo.Size = new System.Drawing.Size(165, 37);
            this.lbl_efectivo.TabIndex = 4;
            this.lbl_efectivo.Text = "$0,00 Efectivo";
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
            this.btn_cancelar.Location = new System.Drawing.Point(595, 310);
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
            this.btn_cobrar.Location = new System.Drawing.Point(396, 310);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formprueba";
            this.Load += new System.EventHandler(this.formCambio_Load);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label lbl_cambio;
        private System.Windows.Forms.Label lbl_tarjeta;
        private System.Windows.Forms.Label lbl_efectivo;
        private CustomBox.RJControls.RJButton btn_cancelar;
        private CustomBox.RJControls.RJButton btn_cobrar;
        private System.Windows.Forms.Label lbl_mp;
        private System.Windows.Forms.TextBox txt_modificarprecio;
        private RJCodeAdvance.RJControls.RJComboBox cbox_tipocambio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_vuelto;
    }
}