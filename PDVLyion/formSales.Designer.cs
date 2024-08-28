namespace PDCLyion
{
    partial class formSales
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_card = new FontAwesome.Sharp.IconButton();
            this.btn_busqueda = new FontAwesome.Sharp.IconButton();
            this.tb_busqueda = new System.Windows.Forms.TextBox();
            this.lbl_dinero = new System.Windows.Forms.Label();
            this.panel_fact = new System.Windows.Forms.Panel();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.btn_closeSell = new System.Windows.Forms.Button();
            this.panel_result = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_fact = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_fact.SuspendLayout();
            this.panel_result.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btn_card);
            this.panel1.Controls.Add(this.btn_busqueda);
            this.panel1.Controls.Add(this.tb_busqueda);
            this.panel1.Controls.Add(this.panel_fact);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 540);
            this.panel1.TabIndex = 0;
            // 
            // btn_card
            // 
            this.btn_card.BackgroundImage = global::PDCLyion.Properties.Resources.listitoe;
            this.btn_card.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_card.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_card.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_card.IconColor = System.Drawing.Color.Black;
            this.btn_card.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_card.Location = new System.Drawing.Point(145, 79);
            this.btn_card.Name = "btn_card";
            this.btn_card.Size = new System.Drawing.Size(36, 34);
            this.btn_card.TabIndex = 12;
            this.btn_card.UseVisualStyleBackColor = true;
            // 
            // btn_busqueda
            // 
            this.btn_busqueda.BackgroundImage = global::PDCLyion.Properties.Resources.lupitanegra;
            this.btn_busqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_busqueda.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_busqueda.IconColor = System.Drawing.Color.Black;
            this.btn_busqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_busqueda.Location = new System.Drawing.Point(651, 79);
            this.btn_busqueda.Name = "btn_busqueda";
            this.btn_busqueda.Size = new System.Drawing.Size(35, 36);
            this.btn_busqueda.TabIndex = 11;
            this.btn_busqueda.UseVisualStyleBackColor = true;
            // 
            // tb_busqueda
            // 
            this.tb_busqueda.Location = new System.Drawing.Point(187, 79);
            this.tb_busqueda.Multiline = true;
            this.tb_busqueda.Name = "tb_busqueda";
            this.tb_busqueda.Size = new System.Drawing.Size(457, 34);
            this.tb_busqueda.TabIndex = 9;
            // 
            // lbl_dinero
            // 
            this.lbl_dinero.AutoSize = true;
            this.lbl_dinero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dinero.Location = new System.Drawing.Point(135, 394);
            this.lbl_dinero.Name = "lbl_dinero";
            this.lbl_dinero.Size = new System.Drawing.Size(58, 25);
            this.lbl_dinero.TabIndex = 4;
            this.lbl_dinero.Text = "0,00";
            // 
            // panel_fact
            // 
            this.panel_fact.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_fact.Controls.Add(this.lbl_dinero);
            this.panel_fact.Controls.Add(this.lbl_precio);
            this.panel_fact.Controls.Add(this.btn_closeSell);
            this.panel_fact.Controls.Add(this.panel_result);
            this.panel_fact.Controls.Add(this.panel3);
            this.panel_fact.Location = new System.Drawing.Point(702, 69);
            this.panel_fact.Name = "panel_fact";
            this.panel_fact.Size = new System.Drawing.Size(280, 471);
            this.panel_fact.TabIndex = 10;
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio.Location = new System.Drawing.Point(33, 396);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(96, 20);
            this.lbl_precio.TabIndex = 3;
            this.lbl_precio.Text = "PRECIO: $";
            // 
            // btn_closeSell
            // 
            this.btn_closeSell.BackColor = System.Drawing.Color.Gold;
            this.btn_closeSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_closeSell.ForeColor = System.Drawing.Color.Black;
            this.btn_closeSell.Location = new System.Drawing.Point(12, 429);
            this.btn_closeSell.Name = "btn_closeSell";
            this.btn_closeSell.Size = new System.Drawing.Size(256, 33);
            this.btn_closeSell.TabIndex = 2;
            this.btn_closeSell.Text = "CERRAR VENTA";
            this.btn_closeSell.UseVisualStyleBackColor = false;
            // 
            // panel_result
            // 
            this.panel_result.Controls.Add(this.label6);
            this.panel_result.Location = new System.Drawing.Point(7, 66);
            this.panel_result.Name = "panel_result";
            this.panel_result.Size = new System.Drawing.Size(265, 310);
            this.panel_result.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "RESUMEN DE PRODUCTOS";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Controls.Add(this.lbl_fact);
            this.panel3.Location = new System.Drawing.Point(0, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 59);
            this.panel3.TabIndex = 0;
            // 
            // lbl_fact
            // 
            this.lbl_fact.AutoSize = true;
            this.lbl_fact.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fact.Location = new System.Drawing.Point(7, 16);
            this.lbl_fact.Name = "lbl_fact";
            this.lbl_fact.Size = new System.Drawing.Size(266, 29);
            this.lbl_fact.TabIndex = 0;
            this.lbl_fact.Text = "FACTURA DE VENTA";
            // 
            // formSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 537);
            this.Controls.Add(this.panel1);
            this.Name = "formSales";
            this.Text = "formSales";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_fact.ResumeLayout(false);
            this.panel_fact.PerformLayout();
            this.panel_result.ResumeLayout(false);
            this.panel_result.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_card;
        private FontAwesome.Sharp.IconButton btn_busqueda;
        private System.Windows.Forms.TextBox tb_busqueda;
        private System.Windows.Forms.Panel panel_fact;
        private System.Windows.Forms.Label lbl_dinero;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Button btn_closeSell;
        private System.Windows.Forms.Panel panel_result;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_fact;
    }
}