namespace POSLyion
{
    partial class formSeleccionCliente
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
            this.panel_container = new System.Windows.Forms.Panel();
            this.panel_color = new System.Windows.Forms.TableLayoutPanel();
            this.panel_bot = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_updateversion = new System.Windows.Forms.Label();
            this.lbl_updatetime = new System.Windows.Forms.Label();
            this.panelgrid = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_completo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_ttop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.panel_container.SuspendLayout();
            this.panel_color.SuspendLayout();
            this.panel_bot.SuspendLayout();
            this.panelgrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.panel_ttop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_container
            // 
            this.panel_container.BackColor = System.Drawing.Color.Black;
            this.panel_container.Controls.Add(this.panel_color);
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.Location = new System.Drawing.Point(0, 0);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(802, 597);
            this.panel_container.TabIndex = 1;
            // 
            // panel_color
            // 
            this.panel_color.ColumnCount = 1;
            this.panel_color.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.panel_color.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.panel_color.Controls.Add(this.panel_bot, 0, 1);
            this.panel_color.Controls.Add(this.panelgrid, 0, 0);
            this.panel_color.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_color.Location = new System.Drawing.Point(0, 0);
            this.panel_color.Name = "panel_color";
            this.panel_color.RowCount = 2;
            this.panel_color.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_color.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_color.Size = new System.Drawing.Size(802, 597);
            this.panel_color.TabIndex = 0;
            // 
            // panel_bot
            // 
            this.panel_bot.BackColor = System.Drawing.Color.Black;
            this.panel_bot.ColumnCount = 3;
            this.panel_bot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_bot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panel_bot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panel_bot.Controls.Add(this.lbl_updateversion, 2, 0);
            this.panel_bot.Controls.Add(this.lbl_updatetime, 1, 0);
            this.panel_bot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_bot.Location = new System.Drawing.Point(0, 577);
            this.panel_bot.Margin = new System.Windows.Forms.Padding(0);
            this.panel_bot.Name = "panel_bot";
            this.panel_bot.RowCount = 1;
            this.panel_bot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_bot.Size = new System.Drawing.Size(802, 20);
            this.panel_bot.TabIndex = 6;
            // 
            // lbl_updateversion
            // 
            this.lbl_updateversion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_updateversion.AutoSize = true;
            this.lbl_updateversion.BackColor = System.Drawing.Color.Black;
            this.lbl_updateversion.ForeColor = System.Drawing.Color.Gold;
            this.lbl_updateversion.Location = new System.Drawing.Point(684, 3);
            this.lbl_updateversion.Name = "lbl_updateversion";
            this.lbl_updateversion.Size = new System.Drawing.Size(115, 13);
            this.lbl_updateversion.TabIndex = 2;
            this.lbl_updateversion.Text = "Actualizacion: v1.0.0.5";
            // 
            // lbl_updatetime
            // 
            this.lbl_updatetime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_updatetime.AutoSize = true;
            this.lbl_updatetime.BackColor = System.Drawing.Color.Black;
            this.lbl_updatetime.ForeColor = System.Drawing.Color.Gold;
            this.lbl_updatetime.Location = new System.Drawing.Point(479, 3);
            this.lbl_updatetime.Name = "lbl_updatetime";
            this.lbl_updatetime.Size = new System.Drawing.Size(199, 13);
            this.lbl_updatetime.TabIndex = 3;
            this.lbl_updatetime.Text = "Ultimo chequeo: 10:06:12  - 20/09/2024";
            // 
            // panelgrid
            // 
            this.panelgrid.BackColor = System.Drawing.Color.Crimson;
            this.panelgrid.ColumnCount = 1;
            this.panelgrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelgrid.Controls.Add(this.dgv_clientes, 0, 1);
            this.panelgrid.Controls.Add(this.panel_ttop, 0, 0);
            this.panelgrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelgrid.Location = new System.Drawing.Point(0, 0);
            this.panelgrid.Margin = new System.Windows.Forms.Padding(0);
            this.panelgrid.Name = "panelgrid";
            this.panelgrid.RowCount = 2;
            this.panelgrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panelgrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelgrid.Size = new System.Drawing.Size(802, 577);
            this.panelgrid.TabIndex = 0;
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.AllowUserToAddRows = false;
            this.dgv_clientes.AllowUserToDeleteRows = false;
            this.dgv_clientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_clientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_clientes.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dni,
            this.nombre_completo,
            this.telefono,
            this.descuento});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_clientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_clientes.EnableHeadersVisualStyles = false;
            this.dgv_clientes.GridColor = System.Drawing.SystemColors.Desktop;
            this.dgv_clientes.Location = new System.Drawing.Point(5, 50);
            this.dgv_clientes.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.dgv_clientes.MultiSelect = false;
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.ReadOnly = true;
            this.dgv_clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_clientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_clientes.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_clientes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_clientes.Size = new System.Drawing.Size(792, 522);
            this.dgv_clientes.TabIndex = 31;
            this.dgv_clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clientes_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // dni
            // 
            this.dni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dni.FillWeight = 80F;
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            // 
            // nombre_completo
            // 
            this.nombre_completo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre_completo.FillWeight = 130F;
            this.nombre_completo.HeaderText = "NOMBRE COMPLETO";
            this.nombre_completo.Name = "nombre_completo";
            this.nombre_completo.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telefono.FillWeight = 80F;
            this.telefono.HeaderText = "TELEFONO";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // descuento
            // 
            this.descuento.HeaderText = "DESCUENTO";
            this.descuento.Name = "descuento";
            this.descuento.ReadOnly = true;
            this.descuento.Visible = false;
            // 
            // panel_ttop
            // 
            this.panel_ttop.BackColor = System.Drawing.Color.Black;
            this.panel_ttop.Controls.Add(this.label1);
            this.panel_ttop.Controls.Add(this.txt_busqueda);
            this.panel_ttop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ttop.Location = new System.Drawing.Point(3, 3);
            this.panel_ttop.Name = "panel_ttop";
            this.panel_ttop.Size = new System.Drawing.Size(796, 44);
            this.panel_ttop.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(22, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "Busqueda";
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busqueda.Location = new System.Drawing.Point(144, 8);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(646, 29);
            this.txt_busqueda.TabIndex = 31;
            this.txt_busqueda.TextChanged += new System.EventHandler(this.txt_busqueda_TextChanged);
            // 
            // formDescuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 597);
            this.Controls.Add(this.panel_container);
            this.Name = "formDescuento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.formDescuento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formDescuento_KeyDown);
            this.panel_container.ResumeLayout(false);
            this.panel_color.ResumeLayout(false);
            this.panel_bot.ResumeLayout(false);
            this.panel_bot.PerformLayout();
            this.panelgrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.panel_ttop.ResumeLayout(false);
            this.panel_ttop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.TableLayoutPanel panel_color;
        private System.Windows.Forms.TableLayoutPanel panel_bot;
        private System.Windows.Forms.Label lbl_updateversion;
        private System.Windows.Forms.Label lbl_updatetime;
        private System.Windows.Forms.TableLayoutPanel panelgrid;
        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.Panel panel_ttop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_completo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
    }
}