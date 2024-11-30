﻿namespace POSLyion
{
    partial class formCobro
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
            this.tlp_principal = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_cobro = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.tlp_monto_cambio = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_vuelto = new System.Windows.Forms.Label();
            this.lbl_cambio = new System.Windows.Forms.Label();
            this.lbl_paga_con = new System.Windows.Forms.Label();
            this.lbl_suma_total = new System.Windows.Forms.Label();
            this.lbl_total_a_cobrar = new System.Windows.Forms.Label();
            this.txt_dinero_entregado = new System.Windows.Forms.TextBox();
            this.tlp_cliente = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_nombre_cliente = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_nombre_cliente = new System.Windows.Forms.Label();
            this.lbl_cliente_seleccionado = new System.Windows.Forms.Label();
            this.tlp_detalle_venta = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_botones = new System.Windows.Forms.TableLayoutPanel();
            this.btn_cobrar_sin_imprimir = new CustomBox.RJControls.RJButton();
            this.btn_cancelar = new CustomBox.RJControls.RJButton();
            this.btn_cobrar_imprimir = new CustomBox.RJControls.RJButton();
            this.tlp_principal.SuspendLayout();
            this.tlp_cobro.SuspendLayout();
            this.tlp_monto_cambio.SuspendLayout();
            this.tlp_cliente.SuspendLayout();
            this.tlp_nombre_cliente.SuspendLayout();
            this.tlp_detalle_venta.SuspendLayout();
            this.tlp_botones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_principal
            // 
            this.tlp_principal.BackColor = System.Drawing.Color.Black;
            this.tlp_principal.ColumnCount = 2;
            this.tlp_principal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlp_principal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp_principal.Controls.Add(this.tlp_cobro, 0, 0);
            this.tlp_principal.Controls.Add(this.tlp_detalle_venta, 1, 0);
            this.tlp_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_principal.Location = new System.Drawing.Point(0, 0);
            this.tlp_principal.Name = "tlp_principal";
            this.tlp_principal.RowCount = 1;
            this.tlp_principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_principal.Size = new System.Drawing.Size(930, 589);
            this.tlp_principal.TabIndex = 0;
            // 
            // tlp_cobro
            // 
            this.tlp_cobro.ColumnCount = 1;
            this.tlp_cobro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_cobro.Controls.Add(this.lbl_titulo, 0, 0);
            this.tlp_cobro.Controls.Add(this.tlp_monto_cambio, 0, 1);
            this.tlp_cobro.Controls.Add(this.tlp_cliente, 0, 2);
            this.tlp_cobro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_cobro.Location = new System.Drawing.Point(3, 3);
            this.tlp_cobro.Name = "tlp_cobro";
            this.tlp_cobro.RowCount = 3;
            this.tlp_cobro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlp_cobro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlp_cobro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_cobro.Size = new System.Drawing.Size(552, 583);
            this.tlp_cobro.TabIndex = 0;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.Gold;
            this.lbl_titulo.Location = new System.Drawing.Point(3, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(546, 87);
            this.lbl_titulo.TabIndex = 12;
            this.lbl_titulo.Text = "Cierre de venta";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlp_monto_cambio
            // 
            this.tlp_monto_cambio.ColumnCount = 1;
            this.tlp_monto_cambio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_monto_cambio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_monto_cambio.Controls.Add(this.lbl_vuelto, 0, 4);
            this.tlp_monto_cambio.Controls.Add(this.lbl_cambio, 0, 5);
            this.tlp_monto_cambio.Controls.Add(this.lbl_paga_con, 0, 2);
            this.tlp_monto_cambio.Controls.Add(this.lbl_suma_total, 0, 1);
            this.tlp_monto_cambio.Controls.Add(this.lbl_total_a_cobrar, 0, 0);
            this.tlp_monto_cambio.Controls.Add(this.txt_dinero_entregado, 0, 3);
            this.tlp_monto_cambio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_monto_cambio.Location = new System.Drawing.Point(3, 90);
            this.tlp_monto_cambio.Name = "tlp_monto_cambio";
            this.tlp_monto_cambio.RowCount = 6;
            this.tlp_monto_cambio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_monto_cambio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_monto_cambio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_monto_cambio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_monto_cambio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_monto_cambio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_monto_cambio.Size = new System.Drawing.Size(546, 343);
            this.tlp_monto_cambio.TabIndex = 13;
            // 
            // lbl_vuelto
            // 
            this.lbl_vuelto.AutoSize = true;
            this.lbl_vuelto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_vuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vuelto.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_vuelto.Location = new System.Drawing.Point(3, 228);
            this.lbl_vuelto.Name = "lbl_vuelto";
            this.lbl_vuelto.Size = new System.Drawing.Size(540, 57);
            this.lbl_vuelto.TabIndex = 18;
            this.lbl_vuelto.Text = "Vuelto:";
            this.lbl_vuelto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_cambio
            // 
            this.lbl_cambio.AutoSize = true;
            this.lbl_cambio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_cambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cambio.ForeColor = System.Drawing.Color.Green;
            this.lbl_cambio.Location = new System.Drawing.Point(3, 285);
            this.lbl_cambio.Name = "lbl_cambio";
            this.lbl_cambio.Size = new System.Drawing.Size(540, 58);
            this.lbl_cambio.TabIndex = 16;
            this.lbl_cambio.Text = "$ lbl_total";
            this.lbl_cambio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_paga_con
            // 
            this.lbl_paga_con.AutoSize = true;
            this.lbl_paga_con.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_paga_con.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paga_con.ForeColor = System.Drawing.Color.Gold;
            this.lbl_paga_con.Location = new System.Drawing.Point(3, 114);
            this.lbl_paga_con.Name = "lbl_paga_con";
            this.lbl_paga_con.Size = new System.Drawing.Size(540, 57);
            this.lbl_paga_con.TabIndex = 15;
            this.lbl_paga_con.Text = "Paga con:";
            this.lbl_paga_con.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_suma_total
            // 
            this.lbl_suma_total.AutoSize = true;
            this.lbl_suma_total.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_suma_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_suma_total.ForeColor = System.Drawing.Color.Green;
            this.lbl_suma_total.Location = new System.Drawing.Point(3, 57);
            this.lbl_suma_total.Name = "lbl_suma_total";
            this.lbl_suma_total.Size = new System.Drawing.Size(540, 57);
            this.lbl_suma_total.TabIndex = 14;
            this.lbl_suma_total.Text = "$ lbl_total";
            this.lbl_suma_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_total_a_cobrar
            // 
            this.lbl_total_a_cobrar.AutoSize = true;
            this.lbl_total_a_cobrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_total_a_cobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_a_cobrar.ForeColor = System.Drawing.Color.Gold;
            this.lbl_total_a_cobrar.Location = new System.Drawing.Point(3, 0);
            this.lbl_total_a_cobrar.Name = "lbl_total_a_cobrar";
            this.lbl_total_a_cobrar.Size = new System.Drawing.Size(540, 57);
            this.lbl_total_a_cobrar.TabIndex = 13;
            this.lbl_total_a_cobrar.Text = "Total a cobrar:";
            this.lbl_total_a_cobrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_dinero_entregado
            // 
            this.txt_dinero_entregado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_dinero_entregado.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dinero_entregado.ForeColor = System.Drawing.Color.Green;
            this.txt_dinero_entregado.Location = new System.Drawing.Point(175, 181);
            this.txt_dinero_entregado.Margin = new System.Windows.Forms.Padding(175, 10, 175, 10);
            this.txt_dinero_entregado.Name = "txt_dinero_entregado";
            this.txt_dinero_entregado.Size = new System.Drawing.Size(196, 42);
            this.txt_dinero_entregado.TabIndex = 19;
            this.txt_dinero_entregado.Text = "$";
            this.txt_dinero_entregado.TextChanged += new System.EventHandler(this.txt_dinero_entregado_TextChanged);
            this.txt_dinero_entregado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dinero_entregado_KeyPress);
            // 
            // tlp_cliente
            // 
            this.tlp_cliente.ColumnCount = 2;
            this.tlp_cliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlp_cliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_cliente.Controls.Add(this.tlp_nombre_cliente, 0, 0);
            this.tlp_cliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_cliente.Location = new System.Drawing.Point(3, 439);
            this.tlp_cliente.Name = "tlp_cliente";
            this.tlp_cliente.RowCount = 1;
            this.tlp_cliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_cliente.Size = new System.Drawing.Size(546, 141);
            this.tlp_cliente.TabIndex = 14;
            // 
            // tlp_nombre_cliente
            // 
            this.tlp_nombre_cliente.ColumnCount = 1;
            this.tlp_nombre_cliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_nombre_cliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_nombre_cliente.Controls.Add(this.lbl_nombre_cliente, 0, 1);
            this.tlp_nombre_cliente.Controls.Add(this.lbl_cliente_seleccionado, 0, 0);
            this.tlp_nombre_cliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_nombre_cliente.Location = new System.Drawing.Point(3, 3);
            this.tlp_nombre_cliente.Name = "tlp_nombre_cliente";
            this.tlp_nombre_cliente.RowCount = 2;
            this.tlp_nombre_cliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_nombre_cliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_nombre_cliente.Size = new System.Drawing.Size(403, 135);
            this.tlp_nombre_cliente.TabIndex = 0;
            // 
            // lbl_nombre_cliente
            // 
            this.lbl_nombre_cliente.AutoSize = true;
            this.lbl_nombre_cliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_nombre_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_cliente.ForeColor = System.Drawing.Color.Gold;
            this.lbl_nombre_cliente.Location = new System.Drawing.Point(3, 67);
            this.lbl_nombre_cliente.Name = "lbl_nombre_cliente";
            this.lbl_nombre_cliente.Size = new System.Drawing.Size(397, 68);
            this.lbl_nombre_cliente.TabIndex = 18;
            this.lbl_nombre_cliente.Text = "lbl_nombre_cliente";
            this.lbl_nombre_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_cliente_seleccionado
            // 
            this.lbl_cliente_seleccionado.AutoSize = true;
            this.lbl_cliente_seleccionado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_cliente_seleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cliente_seleccionado.ForeColor = System.Drawing.Color.Gold;
            this.lbl_cliente_seleccionado.Location = new System.Drawing.Point(3, 0);
            this.lbl_cliente_seleccionado.Name = "lbl_cliente_seleccionado";
            this.lbl_cliente_seleccionado.Size = new System.Drawing.Size(397, 67);
            this.lbl_cliente_seleccionado.TabIndex = 17;
            this.lbl_cliente_seleccionado.Text = "Cliente seleccionado:";
            this.lbl_cliente_seleccionado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlp_detalle_venta
            // 
            this.tlp_detalle_venta.ColumnCount = 1;
            this.tlp_detalle_venta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_detalle_venta.Controls.Add(this.tlp_botones, 0, 1);
            this.tlp_detalle_venta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_detalle_venta.Location = new System.Drawing.Point(561, 3);
            this.tlp_detalle_venta.Name = "tlp_detalle_venta";
            this.tlp_detalle_venta.RowCount = 2;
            this.tlp_detalle_venta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tlp_detalle_venta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlp_detalle_venta.Size = new System.Drawing.Size(366, 583);
            this.tlp_detalle_venta.TabIndex = 1;
            // 
            // tlp_botones
            // 
            this.tlp_botones.ColumnCount = 3;
            this.tlp_botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_botones.Controls.Add(this.btn_cobrar_sin_imprimir, 0, 0);
            this.tlp_botones.Controls.Add(this.btn_cancelar, 2, 0);
            this.tlp_botones.Controls.Add(this.btn_cobrar_imprimir, 0, 0);
            this.tlp_botones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_botones.Location = new System.Drawing.Point(3, 498);
            this.tlp_botones.Name = "tlp_botones";
            this.tlp_botones.RowCount = 1;
            this.tlp_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_botones.Size = new System.Drawing.Size(360, 82);
            this.tlp_botones.TabIndex = 0;
            // 
            // btn_cobrar_sin_imprimir
            // 
            this.btn_cobrar_sin_imprimir.BackColor = System.Drawing.Color.Transparent;
            this.btn_cobrar_sin_imprimir.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_cobrar_sin_imprimir.BorderColor = System.Drawing.Color.Gold;
            this.btn_cobrar_sin_imprimir.BorderRadius = 10;
            this.btn_cobrar_sin_imprimir.BorderSize = 2;
            this.btn_cobrar_sin_imprimir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_cobrar_sin_imprimir.FlatAppearance.BorderSize = 0;
            this.btn_cobrar_sin_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cobrar_sin_imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cobrar_sin_imprimir.ForeColor = System.Drawing.Color.Gold;
            this.btn_cobrar_sin_imprimir.Location = new System.Drawing.Point(123, 3);
            this.btn_cobrar_sin_imprimir.Name = "btn_cobrar_sin_imprimir";
            this.btn_cobrar_sin_imprimir.Size = new System.Drawing.Size(114, 76);
            this.btn_cobrar_sin_imprimir.TabIndex = 10;
            this.btn_cobrar_sin_imprimir.Text = "COBRAR SIN IMPRIMIR - F2";
            this.btn_cobrar_sin_imprimir.TextColor = System.Drawing.Color.Gold;
            this.btn_cobrar_sin_imprimir.UseVisualStyleBackColor = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.BorderColor = System.Drawing.Color.Red;
            this.btn_cancelar.BorderRadius = 10;
            this.btn_cancelar.BorderSize = 2;
            this.btn_cancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.Red;
            this.btn_cancelar.Location = new System.Drawing.Point(243, 3);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(114, 76);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.TextColor = System.Drawing.Color.Red;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_cobrar_imprimir
            // 
            this.btn_cobrar_imprimir.BackColor = System.Drawing.Color.Transparent;
            this.btn_cobrar_imprimir.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_cobrar_imprimir.BorderColor = System.Drawing.Color.Gold;
            this.btn_cobrar_imprimir.BorderRadius = 10;
            this.btn_cobrar_imprimir.BorderSize = 2;
            this.btn_cobrar_imprimir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_cobrar_imprimir.FlatAppearance.BorderSize = 0;
            this.btn_cobrar_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cobrar_imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cobrar_imprimir.ForeColor = System.Drawing.Color.Gold;
            this.btn_cobrar_imprimir.Location = new System.Drawing.Point(3, 3);
            this.btn_cobrar_imprimir.Name = "btn_cobrar_imprimir";
            this.btn_cobrar_imprimir.Size = new System.Drawing.Size(114, 76);
            this.btn_cobrar_imprimir.TabIndex = 8;
            this.btn_cobrar_imprimir.Text = "COBRAR E IMPRIMIR - F1";
            this.btn_cobrar_imprimir.TextColor = System.Drawing.Color.Gold;
            this.btn_cobrar_imprimir.UseVisualStyleBackColor = false;
            this.btn_cobrar_imprimir.Click += new System.EventHandler(this.btn_cobrar_Click);
            // 
            // formCobro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(930, 589);
            this.Controls.Add(this.tlp_principal);
            this.Name = "formCobro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tlp_principal.ResumeLayout(false);
            this.tlp_cobro.ResumeLayout(false);
            this.tlp_cobro.PerformLayout();
            this.tlp_monto_cambio.ResumeLayout(false);
            this.tlp_monto_cambio.PerformLayout();
            this.tlp_cliente.ResumeLayout(false);
            this.tlp_nombre_cliente.ResumeLayout(false);
            this.tlp_nombre_cliente.PerformLayout();
            this.tlp_detalle_venta.ResumeLayout(false);
            this.tlp_botones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private RJCodeAdvance.RJControls.RJButton btn_elimtj;
        private RJCodeAdvance.RJControls.RJButton btn_elimef;
        private System.Windows.Forms.NumericUpDown nbud_precio;
        private RJCodeAdvance.RJControls.RJComboBox cbox_tipocambio;
        private System.Windows.Forms.TableLayoutPanel tlp_principal;
        private System.Windows.Forms.TableLayoutPanel tlp_cobro;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TableLayoutPanel tlp_monto_cambio;
        private System.Windows.Forms.Label lbl_vuelto;
        private System.Windows.Forms.Label lbl_cambio;
        private System.Windows.Forms.Label lbl_paga_con;
        private System.Windows.Forms.Label lbl_suma_total;
        private System.Windows.Forms.Label lbl_total_a_cobrar;
        private System.Windows.Forms.TextBox txt_dinero_entregado;
        private System.Windows.Forms.TableLayoutPanel tlp_cliente;
        private System.Windows.Forms.TableLayoutPanel tlp_nombre_cliente;
        private System.Windows.Forms.Label lbl_nombre_cliente;
        private System.Windows.Forms.Label lbl_cliente_seleccionado;
        private System.Windows.Forms.TableLayoutPanel tlp_detalle_venta;
        private System.Windows.Forms.TableLayoutPanel tlp_botones;
        private CustomBox.RJControls.RJButton btn_cobrar_imprimir;
        private CustomBox.RJControls.RJButton btn_cancelar;
        private CustomBox.RJControls.RJButton btn_cobrar_sin_imprimir;
    }
}