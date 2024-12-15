namespace POSLyion
{
    partial class Form1
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
            this.panel_eftarqr = new System.Windows.Forms.TableLayoutPanel();
            this.txt_dinero_entregado = new System.Windows.Forms.TextBox();
            this.lbl_efectivo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_suma_total = new System.Windows.Forms.Label();
            this.btn_cobrar = new CustomBox.RJControls.RJButton();
            this.btn_cancelar = new CustomBox.RJControls.RJButton();
            this.lbl_total = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_descuento_aplicado = new System.Windows.Forms.Label();
            this.lbl_vuelto = new System.Windows.Forms.Label();
            this.panel_main.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel_eftarqr.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_main.Controls.Add(this.tableLayoutPanel2);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(800, 450);
            this.panel_main.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.panel_eftarqr, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // panel_eftarqr
            // 
            this.panel_eftarqr.ColumnCount = 2;
            this.panel_eftarqr.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panel_eftarqr.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_eftarqr.Controls.Add(this.txt_dinero_entregado, 1, 1);
            this.panel_eftarqr.Controls.Add(this.lbl_efectivo, 1, 0);
            this.panel_eftarqr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_eftarqr.Location = new System.Drawing.Point(0, 99);
            this.panel_eftarqr.Margin = new System.Windows.Forms.Padding(0);
            this.panel_eftarqr.Name = "panel_eftarqr";
            this.panel_eftarqr.RowCount = 2;
            this.panel_eftarqr.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.11037F));
            this.panel_eftarqr.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.44482F));
            this.panel_eftarqr.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.44482F));
            this.panel_eftarqr.Size = new System.Drawing.Size(800, 225);
            this.panel_eftarqr.TabIndex = 16;
            // 
            // txt_dinero_entregado
            // 
            this.txt_dinero_entregado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_dinero_entregado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dinero_entregado.Location = new System.Drawing.Point(3, 114);
            this.txt_dinero_entregado.Name = "txt_dinero_entregado";
            this.txt_dinero_entregado.Size = new System.Drawing.Size(794, 26);
            this.txt_dinero_entregado.TabIndex = 15;
            // 
            // lbl_efectivo
            // 
            this.lbl_efectivo.AutoSize = true;
            this.lbl_efectivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_efectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_efectivo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_efectivo.Location = new System.Drawing.Point(3, 0);
            this.lbl_efectivo.Name = "lbl_efectivo";
            this.lbl_efectivo.Size = new System.Drawing.Size(794, 111);
            this.lbl_efectivo.TabIndex = 16;
            this.lbl_efectivo.Text = "Ingrese el dinero entregado en efectivo:";
            this.lbl_efectivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_suma_total, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_cobrar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_cancelar, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_total, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 373);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 77);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // lbl_suma_total
            // 
            this.lbl_suma_total.AutoSize = true;
            this.lbl_suma_total.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_suma_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_suma_total.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_suma_total.Location = new System.Drawing.Point(195, 0);
            this.lbl_suma_total.Name = "lbl_suma_total";
            this.lbl_suma_total.Size = new System.Drawing.Size(282, 77);
            this.lbl_suma_total.TabIndex = 11;
            this.lbl_suma_total.Text = "0,00";
            this.lbl_suma_total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_cobrar
            // 
            this.btn_cobrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_cobrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cobrar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_cobrar.BorderColor = System.Drawing.Color.Gold;
            this.btn_cobrar.BorderRadius = 10;
            this.btn_cobrar.BorderSize = 2;
            this.btn_cobrar.FlatAppearance.BorderSize = 0;
            this.btn_cobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cobrar.ForeColor = System.Drawing.Color.Gold;
            this.btn_cobrar.Location = new System.Drawing.Point(483, 34);
            this.btn_cobrar.Name = "btn_cobrar";
            this.btn_cobrar.Size = new System.Drawing.Size(154, 40);
            this.btn_cobrar.TabIndex = 7;
            this.btn_cobrar.Text = "COBRAR";
            this.btn_cobrar.TextColor = System.Drawing.Color.Gold;
            this.btn_cobrar.UseVisualStyleBackColor = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.BorderColor = System.Drawing.Color.Red;
            this.btn_cancelar.BorderRadius = 10;
            this.btn_cancelar.BorderSize = 2;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.Red;
            this.btn_cancelar.Location = new System.Drawing.Point(643, 34);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(154, 40);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.TextColor = System.Drawing.Color.Red;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_total.Location = new System.Drawing.Point(24, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(165, 77);
            this.lbl_total.TabIndex = 10;
            this.lbl_total.Text = "Total: $";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(800, 99);
            this.tableLayoutPanel3.TabIndex = 18;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.lbl_descuento_aplicado, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbl_vuelto, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 327);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(794, 43);
            this.tableLayoutPanel4.TabIndex = 19;
            // 
            // lbl_descuento_aplicado
            // 
            this.lbl_descuento_aplicado.AutoSize = true;
            this.lbl_descuento_aplicado.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_descuento_aplicado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descuento_aplicado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_descuento_aplicado.Location = new System.Drawing.Point(3, 0);
            this.lbl_descuento_aplicado.Name = "lbl_descuento_aplicado";
            this.lbl_descuento_aplicado.Size = new System.Drawing.Size(91, 43);
            this.lbl_descuento_aplicado.TabIndex = 14;
            this.lbl_descuento_aplicado.Text = "lbl_descuento";
            this.lbl_descuento_aplicado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_descuento_aplicado.Visible = false;
            // 
            // lbl_vuelto
            // 
            this.lbl_vuelto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_vuelto.AutoSize = true;
            this.lbl_vuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vuelto.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_vuelto.Location = new System.Drawing.Point(584, 3);
            this.lbl_vuelto.Name = "lbl_vuelto";
            this.lbl_vuelto.Size = new System.Drawing.Size(207, 37);
            this.lbl_vuelto.TabIndex = 13;
            this.lbl_vuelto.Text = "Vuelto: $0,00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_main);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_main.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel_eftarqr.ResumeLayout(false);
            this.panel_eftarqr.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel panel_eftarqr;
        private System.Windows.Forms.TextBox txt_dinero_entregado;
        private System.Windows.Forms.Label lbl_efectivo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_suma_total;
        private CustomBox.RJControls.RJButton btn_cobrar;
        private CustomBox.RJControls.RJButton btn_cancelar;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lbl_descuento_aplicado;
        private System.Windows.Forms.Label lbl_vuelto;
    }
}