namespace POSLyion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.tlp_monto_cambio = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_vuelto = new System.Windows.Forms.Label();
            this.lbl_vueltex = new System.Windows.Forms.Label();
            this.txt_dinero_entregado = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_total_a_cobrar = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.total_completo = new System.Windows.Forms.Label();
            this.lbl_textcondesc = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_totaldesc = new System.Windows.Forms.Label();
            this.lbl_textporc = new System.Windows.Forms.Label();
            this.dgv_resumen = new System.Windows.Forms.DataGridView();
            this.tlp_botones = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_cliente = new System.Windows.Forms.TableLayoutPanel();
            this.btn_tipo_venta = new CustomBox.RJControls.RJButton();
            this.tlp_nombre_cliente = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_nombre_cliente = new System.Windows.Forms.Label();
            this.lbl_cliente_seleccionado = new System.Windows.Forms.Label();
            this.btn_cancelar = new CustomBox.RJControls.RJButton();
            this.btn_notas_venta = new CustomBox.RJControls.RJButton();
            this.btn_cobrar_sin_imprimir = new CustomBox.RJControls.RJButton();
            this.btn_cobrar_imprimir = new CustomBox.RJControls.RJButton();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_cambio = new System.Windows.Forms.Label();
            this.lbl_paga_con = new System.Windows.Forms.Label();
            this.productos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tlp_monto_cambio.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resumen)).BeginInit();
            this.tlp_botones.SuspendLayout();
            this.tlp_cliente.SuspendLayout();
            this.tlp_nombre_cliente.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Salmon;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tlp_botones, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgv_resumen, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(930, 589);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tlp_monto_cambio, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_titulo, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(924, 288);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_titulo.Location = new System.Drawing.Point(225, 1);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(474, 55);
            this.lbl_titulo.TabIndex = 18;
            this.lbl_titulo.Text = "CIERRE DE VENTA";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlp_monto_cambio
            // 
            this.tlp_monto_cambio.ColumnCount = 1;
            this.tlp_monto_cambio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_monto_cambio.Controls.Add(this.tableLayoutPanel3, 0, 4);
            this.tlp_monto_cambio.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tlp_monto_cambio.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tlp_monto_cambio.Controls.Add(this.tableLayoutPanel7, 0, 2);
            this.tlp_monto_cambio.Controls.Add(this.tableLayoutPanel8, 2, 3);
            this.tlp_monto_cambio.Location = new System.Drawing.Point(3, 60);
            this.tlp_monto_cambio.Name = "tlp_monto_cambio";
            this.tlp_monto_cambio.RowCount = 5;
            this.tlp_monto_cambio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_monto_cambio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_monto_cambio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_monto_cambio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_monto_cambio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_monto_cambio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_monto_cambio.Size = new System.Drawing.Size(918, 225);
            this.tlp_monto_cambio.TabIndex = 19;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.lbl_vuelto, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_vueltex, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 180);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(918, 45);
            this.tableLayoutPanel3.TabIndex = 32;
            // 
            // lbl_vuelto
            // 
            this.lbl_vuelto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_vuelto.AutoSize = true;
            this.lbl_vuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vuelto.ForeColor = System.Drawing.Color.Green;
            this.lbl_vuelto.Location = new System.Drawing.Point(126, 4);
            this.lbl_vuelto.Name = "lbl_vuelto";
            this.lbl_vuelto.Size = new System.Drawing.Size(55, 37);
            this.lbl_vuelto.TabIndex = 23;
            this.lbl_vuelto.Text = "$0";
            this.lbl_vuelto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_vuelto.Visible = false;
            // 
            // lbl_vueltex
            // 
            this.lbl_vueltex.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_vueltex.AutoSize = true;
            this.lbl_vueltex.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vueltex.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_vueltex.Location = new System.Drawing.Point(3, 4);
            this.lbl_vueltex.Name = "lbl_vueltex";
            this.lbl_vueltex.Size = new System.Drawing.Size(117, 37);
            this.lbl_vueltex.TabIndex = 21;
            this.lbl_vueltex.Text = "Vuelto:";
            this.lbl_vueltex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_vueltex.Visible = false;
            // 
            // txt_dinero_entregado
            // 
            this.txt_dinero_entregado.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dinero_entregado.ForeColor = System.Drawing.Color.Green;
            this.txt_dinero_entregado.Location = new System.Drawing.Point(504, 0);
            this.txt_dinero_entregado.Margin = new System.Windows.Forms.Padding(0);
            this.txt_dinero_entregado.Name = "txt_dinero_entregado";
            this.txt_dinero_entregado.Size = new System.Drawing.Size(321, 42);
            this.txt_dinero_entregado.TabIndex = 22;
            this.txt_dinero_entregado.Text = "$";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tableLayoutPanel4.Controls.Add(this.lbl_total_a_cobrar, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbl_total, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 45);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(918, 45);
            this.tableLayoutPanel4.TabIndex = 27;
            // 
            // lbl_total_a_cobrar
            // 
            this.lbl_total_a_cobrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_total_a_cobrar.AutoSize = true;
            this.lbl_total_a_cobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_a_cobrar.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_total_a_cobrar.Location = new System.Drawing.Point(15, 0);
            this.lbl_total_a_cobrar.Name = "lbl_total_a_cobrar";
            this.lbl_total_a_cobrar.Size = new System.Drawing.Size(226, 37);
            this.lbl_total_a_cobrar.TabIndex = 32;
            this.lbl_total_a_cobrar.Text = "Total a cobrar:";
            this.lbl_total_a_cobrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_total
            // 
            this.lbl_total.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbl_total.Location = new System.Drawing.Point(260, 4);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(227, 37);
            this.lbl_total.TabIndex = 31;
            this.lbl_total.Text = "$lbl_totaldesc";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tableLayoutPanel6.Controls.Add(this.total_completo, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.lbl_textcondesc, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(918, 45);
            this.tableLayoutPanel6.TabIndex = 26;
            // 
            // total_completo
            // 
            this.total_completo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.total_completo.AutoSize = true;
            this.total_completo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_completo.ForeColor = System.Drawing.Color.DarkGreen;
            this.total_completo.Location = new System.Drawing.Point(260, 4);
            this.total_completo.Name = "total_completo";
            this.total_completo.Size = new System.Drawing.Size(156, 37);
            this.total_completo.TabIndex = 30;
            this.total_completo.Text = "$lbl_total";
            this.total_completo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_textcondesc
            // 
            this.lbl_textcondesc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_textcondesc.AutoSize = true;
            this.lbl_textcondesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_textcondesc.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_textcondesc.Location = new System.Drawing.Point(48, 0);
            this.lbl_textcondesc.Name = "lbl_textcondesc";
            this.lbl_textcondesc.Size = new System.Drawing.Size(160, 37);
            this.lbl_textcondesc.TabIndex = 27;
            this.lbl_textcondesc.Text = "Total real:";
            this.lbl_textcondesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tableLayoutPanel7.Controls.Add(this.lbl_totaldesc, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.lbl_textporc, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 90);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(918, 45);
            this.tableLayoutPanel7.TabIndex = 28;
            // 
            // lbl_totaldesc
            // 
            this.lbl_totaldesc.AutoSize = true;
            this.lbl_totaldesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totaldesc.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_totaldesc.Location = new System.Drawing.Point(260, 0);
            this.lbl_totaldesc.Name = "lbl_totaldesc";
            this.lbl_totaldesc.Size = new System.Drawing.Size(249, 37);
            this.lbl_totaldesc.TabIndex = 29;
            this.lbl_totaldesc.Text = "$lbl_porcentaje";
            this.lbl_totaldesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_textporc
            // 
            this.lbl_textporc.AutoSize = true;
            this.lbl_textporc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_textporc.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_textporc.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_textporc.Location = new System.Drawing.Point(3, 0);
            this.lbl_textporc.Name = "lbl_textporc";
            this.lbl_textporc.Size = new System.Drawing.Size(251, 45);
            this.lbl_textporc.TabIndex = 28;
            this.lbl_textporc.Text = "Descuento:";
            this.lbl_textporc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_resumen
            // 
            this.dgv_resumen.AllowUserToAddRows = false;
            this.dgv_resumen.AllowUserToDeleteRows = false;
            this.dgv_resumen.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_resumen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_resumen.BackgroundColor = System.Drawing.Color.White;
            this.dgv_resumen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_resumen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_resumen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_resumen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_resumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_resumen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productos,
            this.cantidad,
            this.precio,
            this.subtotal});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_resumen.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_resumen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_resumen.EnableHeadersVisualStyles = false;
            this.dgv_resumen.Location = new System.Drawing.Point(0, 294);
            this.dgv_resumen.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_resumen.Name = "dgv_resumen";
            this.dgv_resumen.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_resumen.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_resumen.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_resumen.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_resumen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_resumen.Size = new System.Drawing.Size(930, 176);
            this.dgv_resumen.TabIndex = 11;
            // 
            // tlp_botones
            // 
            this.tlp_botones.BackColor = System.Drawing.Color.White;
            this.tlp_botones.ColumnCount = 5;
            this.tlp_botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.02041F));
            this.tlp_botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.2449F));
            this.tlp_botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.2449F));
            this.tlp_botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.2449F));
            this.tlp_botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.2449F));
            this.tlp_botones.Controls.Add(this.tlp_cliente, 0, 0);
            this.tlp_botones.Controls.Add(this.btn_cancelar, 4, 0);
            this.tlp_botones.Controls.Add(this.btn_notas_venta, 3, 0);
            this.tlp_botones.Controls.Add(this.btn_cobrar_imprimir, 1, 0);
            this.tlp_botones.Controls.Add(this.btn_cobrar_sin_imprimir, 2, 0);
            this.tlp_botones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_botones.Location = new System.Drawing.Point(3, 473);
            this.tlp_botones.Name = "tlp_botones";
            this.tlp_botones.RowCount = 1;
            this.tlp_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_botones.Size = new System.Drawing.Size(924, 113);
            this.tlp_botones.TabIndex = 12;
            // 
            // tlp_cliente
            // 
            this.tlp_cliente.ColumnCount = 2;
            this.tlp_cliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlp_cliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_cliente.Controls.Add(this.btn_tipo_venta, 0, 0);
            this.tlp_cliente.Controls.Add(this.tlp_nombre_cliente, 0, 0);
            this.tlp_cliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_cliente.Location = new System.Drawing.Point(3, 3);
            this.tlp_cliente.Name = "tlp_cliente";
            this.tlp_cliente.RowCount = 1;
            this.tlp_cliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_cliente.Size = new System.Drawing.Size(465, 107);
            this.tlp_cliente.TabIndex = 16;
            // 
            // btn_tipo_venta
            // 
            this.btn_tipo_venta.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_tipo_venta.BackgroundColor = System.Drawing.Color.OrangeRed;
            this.btn_tipo_venta.BorderColor = System.Drawing.Color.DarkOrange;
            this.btn_tipo_venta.BorderRadius = 10;
            this.btn_tipo_venta.BorderSize = 2;
            this.btn_tipo_venta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_tipo_venta.FlatAppearance.BorderSize = 0;
            this.btn_tipo_venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tipo_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tipo_venta.ForeColor = System.Drawing.Color.Wheat;
            this.btn_tipo_venta.Location = new System.Drawing.Point(351, 3);
            this.btn_tipo_venta.Name = "btn_tipo_venta";
            this.btn_tipo_venta.Size = new System.Drawing.Size(111, 101);
            this.btn_tipo_venta.TabIndex = 9;
            this.btn_tipo_venta.Text = "VENTA\r\nA\r\nCREDITO\r\n(F3)\r\n";
            this.btn_tipo_venta.TextColor = System.Drawing.Color.Wheat;
            this.btn_tipo_venta.UseVisualStyleBackColor = false;
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
            this.tlp_nombre_cliente.Size = new System.Drawing.Size(342, 101);
            this.tlp_nombre_cliente.TabIndex = 0;
            // 
            // lbl_nombre_cliente
            // 
            this.lbl_nombre_cliente.AutoSize = true;
            this.lbl_nombre_cliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_nombre_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_cliente.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_nombre_cliente.Location = new System.Drawing.Point(3, 50);
            this.lbl_nombre_cliente.Name = "lbl_nombre_cliente";
            this.lbl_nombre_cliente.Size = new System.Drawing.Size(336, 51);
            this.lbl_nombre_cliente.TabIndex = 18;
            this.lbl_nombre_cliente.Text = "lbl_nombre_cliente";
            this.lbl_nombre_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_cliente_seleccionado
            // 
            this.lbl_cliente_seleccionado.AutoSize = true;
            this.lbl_cliente_seleccionado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_cliente_seleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cliente_seleccionado.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_cliente_seleccionado.Location = new System.Drawing.Point(3, 0);
            this.lbl_cliente_seleccionado.Name = "lbl_cliente_seleccionado";
            this.lbl_cliente_seleccionado.Size = new System.Drawing.Size(336, 50);
            this.lbl_cliente_seleccionado.TabIndex = 17;
            this.lbl_cliente_seleccionado.Text = "Cliente seleccionado:";
            this.lbl_cliente_seleccionado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btn_cancelar.BackgroundColor = System.Drawing.Color.Firebrick;
            this.btn_cancelar.BorderColor = System.Drawing.Color.OrangeRed;
            this.btn_cancelar.BorderRadius = 10;
            this.btn_cancelar.BorderSize = 2;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.Snow;
            this.btn_cancelar.Location = new System.Drawing.Point(813, 3);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(108, 104);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "CANCELAR\r\n(Escape)";
            this.btn_cancelar.TextColor = System.Drawing.Color.Snow;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // btn_notas_venta
            // 
            this.btn_notas_venta.BackColor = System.Drawing.Color.Gold;
            this.btn_notas_venta.BackgroundColor = System.Drawing.Color.Gold;
            this.btn_notas_venta.BorderColor = System.Drawing.Color.OrangeRed;
            this.btn_notas_venta.BorderRadius = 10;
            this.btn_notas_venta.BorderSize = 2;
            this.btn_notas_venta.FlatAppearance.BorderSize = 0;
            this.btn_notas_venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_notas_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_notas_venta.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_notas_venta.Location = new System.Drawing.Point(700, 3);
            this.btn_notas_venta.Name = "btn_notas_venta";
            this.btn_notas_venta.Size = new System.Drawing.Size(107, 104);
            this.btn_notas_venta.TabIndex = 11;
            this.btn_notas_venta.Text = "INGRESAR\r\nNOTAS DE\r\nVENTA\r\n(F4)";
            this.btn_notas_venta.TextColor = System.Drawing.Color.OrangeRed;
            this.btn_notas_venta.UseVisualStyleBackColor = false;
            // 
            // btn_cobrar_sin_imprimir
            // 
            this.btn_cobrar_sin_imprimir.BackColor = System.Drawing.Color.Salmon;
            this.btn_cobrar_sin_imprimir.BackgroundColor = System.Drawing.Color.Salmon;
            this.btn_cobrar_sin_imprimir.BorderColor = System.Drawing.Color.Gold;
            this.btn_cobrar_sin_imprimir.BorderRadius = 10;
            this.btn_cobrar_sin_imprimir.BorderSize = 2;
            this.btn_cobrar_sin_imprimir.FlatAppearance.BorderSize = 0;
            this.btn_cobrar_sin_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cobrar_sin_imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cobrar_sin_imprimir.ForeColor = System.Drawing.Color.Gold;
            this.btn_cobrar_sin_imprimir.Location = new System.Drawing.Point(587, 3);
            this.btn_cobrar_sin_imprimir.Name = "btn_cobrar_sin_imprimir";
            this.btn_cobrar_sin_imprimir.Size = new System.Drawing.Size(107, 104);
            this.btn_cobrar_sin_imprimir.TabIndex = 10;
            this.btn_cobrar_sin_imprimir.Text = "COBRAR \r\nSIN \r\nIMPRIMIR\r\n(F2)";
            this.btn_cobrar_sin_imprimir.TextColor = System.Drawing.Color.Gold;
            this.btn_cobrar_sin_imprimir.UseVisualStyleBackColor = false;
            // 
            // btn_cobrar_imprimir
            // 
            this.btn_cobrar_imprimir.BackColor = System.Drawing.Color.Coral;
            this.btn_cobrar_imprimir.BackgroundColor = System.Drawing.Color.Coral;
            this.btn_cobrar_imprimir.BorderColor = System.Drawing.Color.OrangeRed;
            this.btn_cobrar_imprimir.BorderRadius = 10;
            this.btn_cobrar_imprimir.BorderSize = 2;
            this.btn_cobrar_imprimir.FlatAppearance.BorderSize = 0;
            this.btn_cobrar_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cobrar_imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cobrar_imprimir.ForeColor = System.Drawing.Color.Linen;
            this.btn_cobrar_imprimir.Location = new System.Drawing.Point(474, 3);
            this.btn_cobrar_imprimir.Name = "btn_cobrar_imprimir";
            this.btn_cobrar_imprimir.Size = new System.Drawing.Size(107, 107);
            this.btn_cobrar_imprimir.TabIndex = 8;
            this.btn_cobrar_imprimir.Text = "COBRAR E\r\nIMPRIMIR\r\n(F1)";
            this.btn_cobrar_imprimir.TextColor = System.Drawing.Color.Linen;
            this.btn_cobrar_imprimir.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel8.Controls.Add(this.lbl_cambio, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.txt_dinero_entregado, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.lbl_paga_con, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 135);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(918, 45);
            this.tableLayoutPanel8.TabIndex = 33;
            // 
            // lbl_cambio
            // 
            this.lbl_cambio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_cambio.AutoSize = true;
            this.lbl_cambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cambio.ForeColor = System.Drawing.Color.Green;
            this.lbl_cambio.Location = new System.Drawing.Point(828, 4);
            this.lbl_cambio.Name = "lbl_cambio";
            this.lbl_cambio.Size = new System.Drawing.Size(55, 37);
            this.lbl_cambio.TabIndex = 24;
            this.lbl_cambio.Text = "$0";
            this.lbl_cambio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_cambio.Visible = false;
            // 
            // lbl_paga_con
            // 
            this.lbl_paga_con.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_paga_con.AutoSize = true;
            this.lbl_paga_con.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paga_con.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_paga_con.Location = new System.Drawing.Point(34, 0);
            this.lbl_paga_con.Name = "lbl_paga_con";
            this.lbl_paga_con.Size = new System.Drawing.Size(435, 37);
            this.lbl_paga_con.TabIndex = 25;
            this.lbl_paga_con.Text = "Venta en efectivo - Paga con:";
            this.lbl_paga_con.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productos
            // 
            this.productos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productos.FillWeight = 200F;
            this.productos.HeaderText = "Productos";
            this.productos.Name = "productos";
            this.productos.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // formCobro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(930, 589);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "formCobro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cierre de venta";
            this.Load += new System.EventHandler(this.formCobro_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formCobro_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tlp_monto_cambio.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resumen)).EndInit();
            this.tlp_botones.ResumeLayout(false);
            this.tlp_cliente.ResumeLayout(false);
            this.tlp_nombre_cliente.ResumeLayout(false);
            this.tlp_nombre_cliente.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private RJCodeAdvance.RJControls.RJButton btn_elimtj;
        private RJCodeAdvance.RJControls.RJButton btn_elimef;
        private System.Windows.Forms.NumericUpDown nbud_precio;
        private RJCodeAdvance.RJControls.RJComboBox cbox_tipocambio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TableLayoutPanel tlp_monto_cambio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbl_vuelto;
        private System.Windows.Forms.Label lbl_vueltex;
        private System.Windows.Forms.TextBox txt_dinero_entregado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lbl_total_a_cobrar;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label total_completo;
        private System.Windows.Forms.Label lbl_textcondesc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label lbl_totaldesc;
        private System.Windows.Forms.Label lbl_textporc;
        private System.Windows.Forms.DataGridView dgv_resumen;
        private System.Windows.Forms.TableLayoutPanel tlp_botones;
        private System.Windows.Forms.TableLayoutPanel tlp_cliente;
        private CustomBox.RJControls.RJButton btn_tipo_venta;
        private System.Windows.Forms.TableLayoutPanel tlp_nombre_cliente;
        private System.Windows.Forms.Label lbl_nombre_cliente;
        private System.Windows.Forms.Label lbl_cliente_seleccionado;
        private CustomBox.RJControls.RJButton btn_cancelar;
        private CustomBox.RJControls.RJButton btn_notas_venta;
        private CustomBox.RJControls.RJButton btn_cobrar_imprimir;
        private CustomBox.RJControls.RJButton btn_cobrar_sin_imprimir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label lbl_cambio;
        private System.Windows.Forms.Label lbl_paga_con;
        private System.Windows.Forms.DataGridViewTextBoxColumn productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}