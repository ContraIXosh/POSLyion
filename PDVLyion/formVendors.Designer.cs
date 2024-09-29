namespace PDCLyion
{
    partial class formVendors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formVendors));
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_footer = new System.Windows.Forms.Panel();
            this.panel_update = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_viewvendedor = new RJCodeAdvance.RJControls.RJButton();
            this.btn_back = new RJCodeAdvance.RJControls.RJButton();
            this.btn_addvendedor = new RJCodeAdvance.RJControls.RJButton();
            this.panel_grid = new System.Windows.Forms.Panel();
            this.grid_proveedores = new System.Windows.Forms.DataGridView();
            this.cuit_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razon_social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forma_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_gridelim = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_gridedit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel_main.SuspendLayout();
            this.panel_footer.SuspendLayout();
            this.panel_update.SuspendLayout();
            this.panel_grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_proveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.AutoSize = true;
            this.panel_main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_main.Controls.Add(this.panel_grid);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(982, 537);
            this.panel_main.TabIndex = 0;
            // 
            // panel_footer
            // 
            this.panel_footer.Controls.Add(this.panel_update);
            this.panel_footer.Controls.Add(this.btn_viewvendedor);
            this.panel_footer.Controls.Add(this.btn_back);
            this.panel_footer.Controls.Add(this.btn_addvendedor);
            this.panel_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_footer.Location = new System.Drawing.Point(0, 459);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(982, 78);
            this.panel_footer.TabIndex = 9;
            // 
            // panel_update
            // 
            this.panel_update.BackColor = System.Drawing.Color.Khaki;
            this.panel_update.Controls.Add(this.label2);
            this.panel_update.Controls.Add(this.label1);
            this.panel_update.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_update.Location = new System.Drawing.Point(0, 60);
            this.panel_update.Name = "panel_update";
            this.panel_update.Size = new System.Drawing.Size(982, 18);
            this.panel_update.TabIndex = 14;
            this.panel_update.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_update_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(633, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ultimo chequeo: 10:06:12  - 20/09/2024";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(863, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actualizacion: v1.0.0.5";
            // 
            // btn_viewvendedor
            // 
            this.btn_viewvendedor.BackColor = System.Drawing.Color.Transparent;
            this.btn_viewvendedor.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_viewvendedor.BorderColor = System.Drawing.Color.Gold;
            this.btn_viewvendedor.BorderRadius = 7;
            this.btn_viewvendedor.BorderSize = 2;
            this.btn_viewvendedor.FlatAppearance.BorderSize = 0;
            this.btn_viewvendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewvendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewvendedor.ForeColor = System.Drawing.Color.Gold;
            this.btn_viewvendedor.Image = ((System.Drawing.Image)(resources.GetObject("btn_viewvendedor.Image")));
            this.btn_viewvendedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_viewvendedor.Location = new System.Drawing.Point(256, 13);
            this.btn_viewvendedor.Name = "btn_viewvendedor";
            this.btn_viewvendedor.Size = new System.Drawing.Size(254, 40);
            this.btn_viewvendedor.TabIndex = 8;
            this.btn_viewvendedor.Text = "VISUALIZAR VENDEDORES";
            this.btn_viewvendedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_viewvendedor.TextColor = System.Drawing.Color.Gold;
            this.btn_viewvendedor.UseVisualStyleBackColor = false;
            this.btn_viewvendedor.Click += new System.EventHandler(this.rjButton5_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_back.BorderColor = System.Drawing.Color.Red;
            this.btn_back.BorderRadius = 7;
            this.btn_back.BorderSize = 2;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.Red;
            this.btn_back.Location = new System.Drawing.Point(820, 13);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(150, 40);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Regresar";
            this.btn_back.TextColor = System.Drawing.Color.Red;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // btn_addvendedor
            // 
            this.btn_addvendedor.BackColor = System.Drawing.Color.Transparent;
            this.btn_addvendedor.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_addvendedor.BorderColor = System.Drawing.Color.Lime;
            this.btn_addvendedor.BorderRadius = 7;
            this.btn_addvendedor.BorderSize = 2;
            this.btn_addvendedor.FlatAppearance.BorderSize = 0;
            this.btn_addvendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addvendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addvendedor.ForeColor = System.Drawing.Color.Lime;
            this.btn_addvendedor.Image = ((System.Drawing.Image)(resources.GetObject("btn_addvendedor.Image")));
            this.btn_addvendedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addvendedor.Location = new System.Drawing.Point(2, 13);
            this.btn_addvendedor.Name = "btn_addvendedor";
            this.btn_addvendedor.Size = new System.Drawing.Size(250, 40);
            this.btn_addvendedor.TabIndex = 0;
            this.btn_addvendedor.Text = "AGREGAR VENDEDOR";
            this.btn_addvendedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addvendedor.TextColor = System.Drawing.Color.Lime;
            this.btn_addvendedor.UseVisualStyleBackColor = false;
            this.btn_addvendedor.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // panel_grid
            // 
            this.panel_grid.Controls.Add(this.panel_footer);
            this.panel_grid.Controls.Add(this.grid_proveedores);
            this.panel_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_grid.Location = new System.Drawing.Point(0, 0);
            this.panel_grid.Name = "panel_grid";
            this.panel_grid.Size = new System.Drawing.Size(982, 537);
            this.panel_grid.TabIndex = 10;
            // 
            // grid_proveedores
            // 
            this.grid_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_proveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cuit_proveedor,
            this.name_proveedor,
            this.razon_social,
            this.tipo_cat,
            this.num_tel,
            this.forma_pago,
            this.btn_gridelim,
            this.btn_gridedit});
            this.grid_proveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_proveedores.Location = new System.Drawing.Point(0, 0);
            this.grid_proveedores.Margin = new System.Windows.Forms.Padding(15);
            this.grid_proveedores.Name = "grid_proveedores";
            this.grid_proveedores.Size = new System.Drawing.Size(982, 537);
            this.grid_proveedores.TabIndex = 9;
            this.grid_proveedores.Resize += new System.EventHandler(this.dataGridView1_Resize);
            // 
            // cuit_proveedor
            // 
            this.cuit_proveedor.HeaderText = "CUIT";
            this.cuit_proveedor.Name = "cuit_proveedor";
            // 
            // name_proveedor
            // 
            this.name_proveedor.HeaderText = "EMPRESA";
            this.name_proveedor.Name = "name_proveedor";
            // 
            // razon_social
            // 
            this.razon_social.HeaderText = "RAZON SOCIAL";
            this.razon_social.Name = "razon_social";
            // 
            // tipo_cat
            // 
            this.tipo_cat.HeaderText = "CATEGORIA";
            this.tipo_cat.Name = "tipo_cat";
            // 
            // num_tel
            // 
            this.num_tel.HeaderText = "TELEFONO";
            this.num_tel.Name = "num_tel";
            // 
            // forma_pago
            // 
            this.forma_pago.HeaderText = "FORMAS DE PAGO";
            this.forma_pago.Name = "forma_pago";
            // 
            // btn_gridelim
            // 
            this.btn_gridelim.HeaderText = "ELIMINAR";
            this.btn_gridelim.Name = "btn_gridelim";
            // 
            // btn_gridedit
            // 
            this.btn_gridedit.HeaderText = "EDITAR";
            this.btn_gridedit.Name = "btn_gridedit";
            // 
            // formVendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 537);
            this.Controls.Add(this.panel_main);
            this.Name = "formVendors";
            this.Text = "formVendors";
            this.Load += new System.EventHandler(this.formVendors_Load);
            this.panel_main.ResumeLayout(false);
            this.panel_footer.ResumeLayout(false);
            this.panel_update.ResumeLayout(false);
            this.panel_update.PerformLayout();
            this.panel_grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_proveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private RJCodeAdvance.RJControls.RJButton btn_addvendedor;
        private RJCodeAdvance.RJControls.RJButton btn_back;
        private System.Windows.Forms.DataGridView grid_proveedores;
        private RJCodeAdvance.RJControls.RJButton btn_viewvendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn razon_social;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn forma_pago;
        private System.Windows.Forms.DataGridViewButtonColumn btn_gridelim;
        private System.Windows.Forms.DataGridViewButtonColumn btn_gridedit;
        private System.Windows.Forms.Panel panel_footer;
        private System.Windows.Forms.Panel panel_grid;
        private System.Windows.Forms.Panel panel_update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}