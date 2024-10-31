namespace POSLyion.Modals
{
    partial class MD_Proveedores
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
            this.dgv_modal_proveedores = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbo_filtro = new CustomBox.RJControls.RJComboBox();
            this.txt_busqueda = new RJCodeAdvance.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modal_proveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_modal_proveedores
            // 
            this.dgv_modal_proveedores.AllowUserToAddRows = false;
            this.dgv_modal_proveedores.AllowUserToDeleteRows = false;
            this.dgv_modal_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_modal_proveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cuit,
            this.descripcion});
            this.dgv_modal_proveedores.Location = new System.Drawing.Point(3, 50);
            this.dgv_modal_proveedores.Name = "dgv_modal_proveedores";
            this.dgv_modal_proveedores.ReadOnly = true;
            this.dgv_modal_proveedores.Size = new System.Drawing.Size(466, 267);
            this.dgv_modal_proveedores.TabIndex = 0;
            this.dgv_modal_proveedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_modal_proveedores_CellDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // cuit
            // 
            this.cuit.HeaderText = "CUIT";
            this.cuit.Name = "cuit";
            this.cuit.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Razon social";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
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
            this.cbo_filtro.Location = new System.Drawing.Point(12, 12);
            this.cbo_filtro.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbo_filtro.Name = "cbo_filtro";
            this.cbo_filtro.Padding = new System.Windows.Forms.Padding(1);
            this.cbo_filtro.Size = new System.Drawing.Size(200, 30);
            this.cbo_filtro.TabIndex = 1;
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
            this.txt_busqueda.Location = new System.Drawing.Point(219, 13);
            this.txt_busqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txt_busqueda.Multiline = false;
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_busqueda.PasswordChar = false;
            this.txt_busqueda.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_busqueda.PlaceholderText = "";
            this.txt_busqueda.Size = new System.Drawing.Size(250, 31);
            this.txt_busqueda.TabIndex = 2;
            this.txt_busqueda.Texts = "";
            this.txt_busqueda.UnderlinedStyle = false;
            this.txt_busqueda._TextChanged += new System.EventHandler(this.txt_busqueda__TextChanged);
            // 
            // MD_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 322);
            this.Controls.Add(this.txt_busqueda);
            this.Controls.Add(this.cbo_filtro);
            this.Controls.Add(this.dgv_modal_proveedores);
            this.Name = "MD_Proveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.MD_Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modal_proveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_modal_proveedores;
        private CustomBox.RJControls.RJComboBox cbo_filtro;
        private RJCodeAdvance.RJControls.RJTextBox txt_busqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
    }
}