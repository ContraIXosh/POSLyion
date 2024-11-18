namespace POSLyion.Modals
{
    partial class MD_Clientes
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
            this.cbo_filtro = new RJCodeAdvance.RJControls.RJComboBox();
            this.txt_busqueda = new RJCodeAdvance.RJControls.RJTextBox();
            this.btn_buscar = new RJCodeAdvance.RJControls.RJButton();
            this.dgv_modal_clientes = new System.Windows.Forms.DataGridView();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_completo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modal_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_filtro
            // 
            this.cbo_filtro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo_filtro.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbo_filtro.BorderSize = 1;
            this.cbo_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbo_filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbo_filtro.ForeColor = System.Drawing.Color.DimGray;
            this.cbo_filtro.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbo_filtro.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbo_filtro.ListTextColor = System.Drawing.Color.DimGray;
            this.cbo_filtro.Location = new System.Drawing.Point(66, 80);
            this.cbo_filtro.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbo_filtro.Name = "cbo_filtro";
            this.cbo_filtro.Padding = new System.Windows.Forms.Padding(1);
            this.cbo_filtro.Size = new System.Drawing.Size(200, 30);
            this.cbo_filtro.TabIndex = 0;
            this.cbo_filtro.Texts = "";
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.BackColor = System.Drawing.SystemColors.Window;
            this.txt_busqueda.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_busqueda.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_busqueda.BorderRadius = 0;
            this.txt_busqueda.BorderSize = 2;
            this.txt_busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_busqueda.Location = new System.Drawing.Point(287, 79);
            this.txt_busqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txt_busqueda.Multiline = false;
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_busqueda.PasswordChar = false;
            this.txt_busqueda.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_busqueda.PlaceholderText = "";
            this.txt_busqueda.Size = new System.Drawing.Size(250, 31);
            this.txt_busqueda.TabIndex = 1;
            this.txt_busqueda.Texts = "";
            this.txt_busqueda.UnderlinedStyle = false;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_buscar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_buscar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_buscar.BorderRadius = 0;
            this.btn_buscar.BorderSize = 0;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Location = new System.Drawing.Point(568, 79);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(150, 40);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextColor = System.Drawing.Color.White;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // dgv_modal_clientes
            // 
            this.dgv_modal_clientes.AllowUserToAddRows = false;
            this.dgv_modal_clientes.AllowUserToDeleteRows = false;
            this.dgv_modal_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_modal_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dni,
            this.nombre_completo});
            this.dgv_modal_clientes.Location = new System.Drawing.Point(66, 117);
            this.dgv_modal_clientes.Name = "dgv_modal_clientes";
            this.dgv_modal_clientes.ReadOnly = true;
            this.dgv_modal_clientes.Size = new System.Drawing.Size(652, 333);
            this.dgv_modal_clientes.TabIndex = 3;
            this.dgv_modal_clientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_modal_clientes_CellContentDoubleClick);
            // 
            // dni
            // 
            this.dni.HeaderText = "Numero de Documento";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            // 
            // nombre_completo
            // 
            this.nombre_completo.HeaderText = "Nombre completo";
            this.nombre_completo.Name = "nombre_completo";
            this.nombre_completo.ReadOnly = true;
            // 
            // MD_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_modal_clientes);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_busqueda);
            this.Controls.Add(this.cbo_filtro);
            this.Name = "MD_Clientes";
            this.Text = "MD_Clientes";
            this.Load += new System.EventHandler(this.MD_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modal_clientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RJCodeAdvance.RJControls.RJComboBox cbo_filtro;
        private RJCodeAdvance.RJControls.RJTextBox txt_busqueda;
        private RJCodeAdvance.RJControls.RJButton btn_buscar;
        private System.Windows.Forms.DataGridView dgv_modal_clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_completo;
    }
}