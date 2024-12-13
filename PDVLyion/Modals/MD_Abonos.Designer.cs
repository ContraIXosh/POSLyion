namespace POSLyion.Modals
{
    partial class MD_Abonos
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
            this.tlp_monto_botones = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_monto = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_ingrese_monto = new System.Windows.Forms.Label();
            this.txt_monto_abonado = new System.Windows.Forms.TextBox();
            this.tlp_botones = new System.Windows.Forms.TableLayoutPanel();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_deuda = new System.Windows.Forms.Label();
            this.tlp_principal = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_monto_botones.SuspendLayout();
            this.tlp_monto.SuspendLayout();
            this.tlp_botones.SuspendLayout();
            this.tlp_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_monto_botones
            // 
            this.tlp_monto_botones.ColumnCount = 1;
            this.tlp_monto_botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_monto_botones.Controls.Add(this.tlp_monto, 0, 0);
            this.tlp_monto_botones.Controls.Add(this.tlp_botones, 0, 1);
            this.tlp_monto_botones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_monto_botones.Location = new System.Drawing.Point(3, 55);
            this.tlp_monto_botones.Name = "tlp_monto_botones";
            this.tlp_monto_botones.RowCount = 2;
            this.tlp_monto_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlp_monto_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_monto_botones.Size = new System.Drawing.Size(436, 202);
            this.tlp_monto_botones.TabIndex = 1;
            // 
            // tlp_monto
            // 
            this.tlp_monto.ColumnCount = 1;
            this.tlp_monto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_monto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_monto.Controls.Add(this.lbl_ingrese_monto, 0, 0);
            this.tlp_monto.Controls.Add(this.txt_monto_abonado, 0, 1);
            this.tlp_monto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_monto.Location = new System.Drawing.Point(3, 3);
            this.tlp_monto.Name = "tlp_monto";
            this.tlp_monto.RowCount = 2;
            this.tlp_monto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_monto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_monto.Size = new System.Drawing.Size(430, 155);
            this.tlp_monto.TabIndex = 0;
            // 
            // lbl_ingrese_monto
            // 
            this.lbl_ingrese_monto.AutoSize = true;
            this.lbl_ingrese_monto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_ingrese_monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ingrese_monto.Location = new System.Drawing.Point(3, 0);
            this.lbl_ingrese_monto.Name = "lbl_ingrese_monto";
            this.lbl_ingrese_monto.Size = new System.Drawing.Size(424, 77);
            this.lbl_ingrese_monto.TabIndex = 0;
            this.lbl_ingrese_monto.Text = "Ingrese un monto a abonar:";
            this.lbl_ingrese_monto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_monto_abonado
            // 
            this.txt_monto_abonado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_monto_abonado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_monto_abonado.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monto_abonado.Location = new System.Drawing.Point(100, 80);
            this.txt_monto_abonado.Margin = new System.Windows.Forms.Padding(100, 3, 100, 3);
            this.txt_monto_abonado.Name = "txt_monto_abonado";
            this.txt_monto_abonado.Size = new System.Drawing.Size(230, 49);
            this.txt_monto_abonado.TabIndex = 1;
            this.txt_monto_abonado.Text = "$";
            this.txt_monto_abonado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_monto_abonado_KeyPress);
            // 
            // tlp_botones
            // 
            this.tlp_botones.ColumnCount = 2;
            this.tlp_botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_botones.Controls.Add(this.btn_aceptar, 0, 0);
            this.tlp_botones.Controls.Add(this.btn_cancelar, 1, 0);
            this.tlp_botones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_botones.Location = new System.Drawing.Point(3, 164);
            this.tlp_botones.Name = "tlp_botones";
            this.tlp_botones.RowCount = 1;
            this.tlp_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_botones.Size = new System.Drawing.Size(430, 35);
            this.tlp_botones.TabIndex = 1;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.Location = new System.Drawing.Point(3, 3);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(209, 29);
            this.btn_aceptar.TabIndex = 0;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(218, 3);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(209, 29);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_deuda
            // 
            this.lbl_deuda.AutoSize = true;
            this.lbl_deuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_deuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deuda.Location = new System.Drawing.Point(3, 0);
            this.lbl_deuda.Name = "lbl_deuda";
            this.lbl_deuda.Size = new System.Drawing.Size(436, 52);
            this.lbl_deuda.TabIndex = 0;
            this.lbl_deuda.Text = "Deuda pendiente: $";
            this.lbl_deuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_deuda.UseCompatibleTextRendering = true;
            // 
            // tlp_principal
            // 
            this.tlp_principal.ColumnCount = 1;
            this.tlp_principal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_principal.Controls.Add(this.lbl_deuda, 0, 0);
            this.tlp_principal.Controls.Add(this.tlp_monto_botones, 0, 1);
            this.tlp_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_principal.Location = new System.Drawing.Point(0, 0);
            this.tlp_principal.Name = "tlp_principal";
            this.tlp_principal.RowCount = 2;
            this.tlp_principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlp_principal.Size = new System.Drawing.Size(442, 260);
            this.tlp_principal.TabIndex = 0;
            // 
            // MD_Abonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 260);
            this.Controls.Add(this.tlp_principal);
            this.Name = "MD_Abonos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abonos";
            this.tlp_monto_botones.ResumeLayout(false);
            this.tlp_monto.ResumeLayout(false);
            this.tlp_monto.PerformLayout();
            this.tlp_botones.ResumeLayout(false);
            this.tlp_principal.ResumeLayout(false);
            this.tlp_principal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_monto_botones;
        private System.Windows.Forms.TableLayoutPanel tlp_monto;
        private System.Windows.Forms.Label lbl_ingrese_monto;
        private System.Windows.Forms.TextBox txt_monto_abonado;
        private System.Windows.Forms.TableLayoutPanel tlp_botones;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_deuda;
        private System.Windows.Forms.TableLayoutPanel tlp_principal;
    }
}