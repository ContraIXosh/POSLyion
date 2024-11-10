﻿namespace POSLyion
{
    partial class formEstadsticas
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
            this.panel_main = new System.Windows.Forms.TableLayoutPanel();
            this.panel_update = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_mid = new System.Windows.Forms.TableLayoutPanel();
            this.panel_izq = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_busqueda_usuario = new System.Windows.Forms.Label();
            this.btn_sql = new CustomBox.RJControls.RJButton();
            this.btn_excel = new CustomBox.RJControls.RJButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ver_compras = new CustomBox.RJControls.RJButton();
            this.btn_ver_ventas = new CustomBox.RJControls.RJButton();
            this.txt_busqueda_producto = new System.Windows.Forms.TextBox();
            this.btn_buscar = new CustomBox.RJControls.RJButton();
            this.label8 = new System.Windows.Forms.Label();
            this.date_desde = new CustomBox.RJControls.RJDatePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.date_hasta = new CustomBox.RJControls.RJDatePicker();
            this.lbl_busqueda_producto = new System.Windows.Forms.Label();
            this.cbox_usuarios = new System.Windows.Forms.ComboBox();
            this.dgv_historial = new System.Windows.Forms.DataGridView();
            this.panel_main.SuspendLayout();
            this.panel_update.SuspendLayout();
            this.panel_mid.SuspendLayout();
            this.panel_izq.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historial)).BeginInit();
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
            this.panel_mid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_mid.Controls.Add(this.panel_izq, 0, 0);
            this.panel_mid.Controls.Add(this.dgv_historial, 1, 0);
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
            this.panel_izq.Controls.Add(this.btn_sql, 0, 2);
            this.panel_izq.Controls.Add(this.btn_excel, 0, 1);
            this.panel_izq.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.panel_izq.Controls.Add(this.txt_busqueda_producto, 0, 10);
            this.panel_izq.Controls.Add(this.btn_buscar, 0, 13);
            this.panel_izq.Controls.Add(this.label8, 0, 3);
            this.panel_izq.Controls.Add(this.date_desde, 0, 4);
            this.panel_izq.Controls.Add(this.label9, 0, 5);
            this.panel_izq.Controls.Add(this.date_hasta, 0, 6);
            this.panel_izq.Controls.Add(this.lbl_busqueda_producto, 0, 9);
            this.panel_izq.Controls.Add(this.cbox_usuarios, 0, 8);
            this.panel_izq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_izq.Location = new System.Drawing.Point(0, 0);
            this.panel_izq.Margin = new System.Windows.Forms.Padding(0);
            this.panel_izq.Name = "panel_izq";
            this.panel_izq.RowCount = 14;
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
            this.panel_izq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_izq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_izq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_izq.Size = new System.Drawing.Size(294, 595);
            this.panel_izq.TabIndex = 39;
            // 
            // lbl_busqueda_usuario
            // 
            this.lbl_busqueda_usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_busqueda_usuario.AutoSize = true;
            this.lbl_busqueda_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busqueda_usuario.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_busqueda_usuario.Location = new System.Drawing.Point(41, 331);
            this.lbl_busqueda_usuario.Name = "lbl_busqueda_usuario";
            this.lbl_busqueda_usuario.Size = new System.Drawing.Size(212, 24);
            this.lbl_busqueda_usuario.TabIndex = 44;
            this.lbl_busqueda_usuario.Text = "NOMBRE DE USUARIO";
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
            this.btn_sql.Location = new System.Drawing.Point(11, 125);
            this.btn_sql.Name = "btn_sql";
            this.btn_sql.Size = new System.Drawing.Size(272, 27);
            this.btn_sql.TabIndex = 29;
            this.btn_sql.Text = "EXPORTAR BASE DE DATOS";
            this.btn_sql.TextColor = System.Drawing.Color.White;
            this.btn_sql.UseVisualStyleBackColor = false;
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
            this.btn_excel.Location = new System.Drawing.Point(35, 65);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(224, 47);
            this.btn_excel.TabIndex = 28;
            this.btn_excel.Text = "EXPORTAR EXCEL";
            this.btn_excel.TextColor = System.Drawing.Color.White;
            this.btn_excel.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_ver_compras, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_ver_ventas, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(288, 50);
            this.tableLayoutPanel1.TabIndex = 39;
            // 
            // btn_ver_compras
            // 
            this.btn_ver_compras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ver_compras.BackColor = System.Drawing.Color.Green;
            this.btn_ver_compras.BackgroundColor = System.Drawing.Color.Green;
            this.btn_ver_compras.BorderColor = System.Drawing.Color.Red;
            this.btn_ver_compras.BorderRadius = 10;
            this.btn_ver_compras.BorderSize = 0;
            this.btn_ver_compras.FlatAppearance.BorderSize = 0;
            this.btn_ver_compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ver_compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ver_compras.ForeColor = System.Drawing.Color.White;
            this.btn_ver_compras.Location = new System.Drawing.Point(147, 3);
            this.btn_ver_compras.Name = "btn_ver_compras";
            this.btn_ver_compras.Size = new System.Drawing.Size(138, 44);
            this.btn_ver_compras.TabIndex = 30;
            this.btn_ver_compras.Text = "Compras";
            this.btn_ver_compras.TextColor = System.Drawing.Color.White;
            this.btn_ver_compras.UseVisualStyleBackColor = false;
            this.btn_ver_compras.Click += new System.EventHandler(this.btn_ver_compras_Click);
            // 
            // btn_ver_ventas
            // 
            this.btn_ver_ventas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ver_ventas.BackColor = System.Drawing.Color.Green;
            this.btn_ver_ventas.BackgroundColor = System.Drawing.Color.Green;
            this.btn_ver_ventas.BorderColor = System.Drawing.Color.Red;
            this.btn_ver_ventas.BorderRadius = 10;
            this.btn_ver_ventas.BorderSize = 0;
            this.btn_ver_ventas.FlatAppearance.BorderSize = 0;
            this.btn_ver_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ver_ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ver_ventas.ForeColor = System.Drawing.Color.White;
            this.btn_ver_ventas.Location = new System.Drawing.Point(3, 3);
            this.btn_ver_ventas.Name = "btn_ver_ventas";
            this.btn_ver_ventas.Size = new System.Drawing.Size(138, 44);
            this.btn_ver_ventas.TabIndex = 29;
            this.btn_ver_ventas.Text = "Ventas";
            this.btn_ver_ventas.TextColor = System.Drawing.Color.White;
            this.btn_ver_ventas.UseVisualStyleBackColor = false;
            this.btn_ver_ventas.Click += new System.EventHandler(this.btn_ver_ventas_Click);
            // 
            // txt_busqueda_producto
            // 
            this.txt_busqueda_producto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_busqueda_producto.Location = new System.Drawing.Point(3, 463);
            this.txt_busqueda_producto.Name = "txt_busqueda_producto";
            this.txt_busqueda_producto.Size = new System.Drawing.Size(288, 20);
            this.txt_busqueda_producto.TabIndex = 43;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_buscar.BackColor = System.Drawing.Color.Green;
            this.btn_buscar.BackgroundColor = System.Drawing.Color.Green;
            this.btn_buscar.BorderColor = System.Drawing.Color.Red;
            this.btn_buscar.BorderRadius = 10;
            this.btn_buscar.BorderSize = 0;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Location = new System.Drawing.Point(41, 574);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(212, 18);
            this.btn_buscar.TabIndex = 38;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.TextColor = System.Drawing.Color.White;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGreen;
            this.label8.Location = new System.Drawing.Point(75, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 24);
            this.label8.TabIndex = 34;
            this.label8.Text = "FECHA DESDE";
            // 
            // date_desde
            // 
            this.date_desde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date_desde.BorderColor = System.Drawing.Color.DodgerBlue;
            this.date_desde.BorderSize = 0;
            this.date_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.date_desde.Location = new System.Drawing.Point(28, 202);
            this.date_desde.MinimumSize = new System.Drawing.Size(4, 35);
            this.date_desde.Name = "date_desde";
            this.date_desde.Size = new System.Drawing.Size(237, 35);
            this.date_desde.SkinColor = System.Drawing.Color.DodgerBlue;
            this.date_desde.TabIndex = 35;
            this.date_desde.TextColor = System.Drawing.Color.White;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGreen;
            this.label9.Location = new System.Drawing.Point(75, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 24);
            this.label9.TabIndex = 36;
            this.label9.Text = "FECHA HASTA";
            // 
            // date_hasta
            // 
            this.date_hasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date_hasta.BorderColor = System.Drawing.Color.DodgerBlue;
            this.date_hasta.BorderSize = 0;
            this.date_hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.date_hasta.Location = new System.Drawing.Point(28, 285);
            this.date_hasta.MinimumSize = new System.Drawing.Size(4, 35);
            this.date_hasta.Name = "date_hasta";
            this.date_hasta.Size = new System.Drawing.Size(237, 35);
            this.date_hasta.SkinColor = System.Drawing.Color.DodgerBlue;
            this.date_hasta.TabIndex = 37;
            this.date_hasta.TextColor = System.Drawing.Color.White;
            // 
            // lbl_busqueda_producto
            // 
            this.lbl_busqueda_producto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_busqueda_producto.AutoSize = true;
            this.lbl_busqueda_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busqueda_producto.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_busqueda_producto.Location = new System.Drawing.Point(29, 420);
            this.lbl_busqueda_producto.Name = "lbl_busqueda_producto";
            this.lbl_busqueda_producto.Size = new System.Drawing.Size(235, 24);
            this.lbl_busqueda_producto.TabIndex = 41;
            this.lbl_busqueda_producto.Text = "NOMBRE DE PRODUCTO";
            // 
            // cbox_usuarios
            // 
            this.cbox_usuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbox_usuarios.FormattingEnabled = true;
            this.cbox_usuarios.Location = new System.Drawing.Point(3, 374);
            this.cbox_usuarios.Name = "cbox_usuarios";
            this.cbox_usuarios.Size = new System.Drawing.Size(288, 21);
            this.cbox_usuarios.TabIndex = 45;
            // 
            // dgv_historial
            // 
            this.dgv_historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_historial.Location = new System.Drawing.Point(297, 3);
            this.dgv_historial.Name = "dgv_historial";
            this.dgv_historial.Size = new System.Drawing.Size(682, 589);
            this.dgv_historial.TabIndex = 40;
            // 
            // formEstadsticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 611);
            this.Controls.Add(this.panel_main);
            this.Name = "formEstadsticas";
            this.Text = "formStadistic";
            this.Load += new System.EventHandler(this.formEstadsticas_Load);
            this.panel_main.ResumeLayout(false);
            this.panel_update.ResumeLayout(false);
            this.panel_update.PerformLayout();
            this.panel_mid.ResumeLayout(false);
            this.panel_izq.ResumeLayout(false);
            this.panel_izq.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel_main;
        private System.Windows.Forms.Panel panel_update;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel panel_mid;
        private System.Windows.Forms.TableLayoutPanel panel_izq;
        private CustomBox.RJControls.RJButton btn_buscar;
        private CustomBox.RJControls.RJDatePicker date_hasta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private CustomBox.RJControls.RJButton btn_excel;
        private CustomBox.RJControls.RJButton btn_sql;
        private CustomBox.RJControls.RJDatePicker date_desde;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomBox.RJControls.RJButton btn_ver_compras;
        private CustomBox.RJControls.RJButton btn_ver_ventas;
        private System.Windows.Forms.DataGridView dgv_historial;
        private System.Windows.Forms.Label lbl_busqueda_producto;
        private System.Windows.Forms.TextBox txt_busqueda_producto;
        private System.Windows.Forms.Label lbl_busqueda_usuario;
        private System.Windows.Forms.ComboBox cbox_usuarios;
    }
}