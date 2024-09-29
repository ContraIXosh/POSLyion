namespace PDCLyion
{
    partial class formCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCustomers));
            this.panel_main = new System.Windows.Forms.Panel();
            this.grid_proveedores = new System.Windows.Forms.DataGridView();
            this.cliente_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente_fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente_dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente_eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cliente_editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel_footer = new System.Windows.Forms.Panel();
            this.panel_update = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_viewvendedor = new RJCodeAdvance.RJControls.RJButton();
            this.btn_back = new RJCodeAdvance.RJControls.RJButton();
            this.btn_addvendedor = new RJCodeAdvance.RJControls.RJButton();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_proveedores)).BeginInit();
            this.panel_footer.SuspendLayout();
            this.panel_update.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_main.Controls.Add(this.panel_footer);
            this.panel_main.Controls.Add(this.grid_proveedores);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(982, 537);
            this.panel_main.TabIndex = 0;
            // 
            // grid_proveedores
            // 
            this.grid_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_proveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cliente_id,
            this.cliente_fullname,
            this.cliente_dni,
            this.cliente_tel,
            this.cliente_email,
            this.cliente_eliminar,
            this.cliente_editar});
            this.grid_proveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_proveedores.Location = new System.Drawing.Point(0, 0);
            this.grid_proveedores.Margin = new System.Windows.Forms.Padding(15);
            this.grid_proveedores.Name = "grid_proveedores";
            this.grid_proveedores.Size = new System.Drawing.Size(982, 537);
            this.grid_proveedores.TabIndex = 15;
            // 
            // cliente_id
            // 
            this.cliente_id.HeaderText = "ID";
            this.cliente_id.Name = "cliente_id";
            // 
            // cliente_fullname
            // 
            this.cliente_fullname.HeaderText = "NOMBRE COMPLETO";
            this.cliente_fullname.Name = "cliente_fullname";
            // 
            // cliente_dni
            // 
            this.cliente_dni.HeaderText = "DNI";
            this.cliente_dni.Name = "cliente_dni";
            // 
            // cliente_tel
            // 
            this.cliente_tel.HeaderText = "TELEFONO";
            this.cliente_tel.Name = "cliente_tel";
            // 
            // cliente_email
            // 
            this.cliente_email.HeaderText = "EMAIL";
            this.cliente_email.Name = "cliente_email";
            // 
            // cliente_eliminar
            // 
            this.cliente_eliminar.HeaderText = "ELIMINAR";
            this.cliente_eliminar.Name = "cliente_eliminar";
            // 
            // cliente_editar
            // 
            this.cliente_editar.HeaderText = "EDITAR";
            this.cliente_editar.Name = "cliente_editar";
            // 
            // panel_footer
            // 
            this.panel_footer.Controls.Add(this.panel_update);
            this.panel_footer.Controls.Add(this.btn_viewvendedor);
            this.panel_footer.Controls.Add(this.btn_addvendedor);
            this.panel_footer.Controls.Add(this.btn_back);
            this.panel_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_footer.Location = new System.Drawing.Point(0, 457);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(982, 80);
            this.panel_footer.TabIndex = 16;
            this.panel_footer.Resize += new System.EventHandler(this.panel_footer_Resize_1);
            // 
            // panel_update
            // 
            this.panel_update.BackColor = System.Drawing.Color.Khaki;
            this.panel_update.Controls.Add(this.label2);
            this.panel_update.Controls.Add(this.label1);
            this.panel_update.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_update.Location = new System.Drawing.Point(0, 62);
            this.panel_update.Name = "panel_update";
            this.panel_update.Size = new System.Drawing.Size(982, 18);
            this.panel_update.TabIndex = 20;
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
            this.btn_viewvendedor.Location = new System.Drawing.Point(238, 10);
            this.btn_viewvendedor.Name = "btn_viewvendedor";
            this.btn_viewvendedor.Size = new System.Drawing.Size(254, 40);
            this.btn_viewvendedor.TabIndex = 19;
            this.btn_viewvendedor.Text = "VISUALIZAR VENDEDORES";
            this.btn_viewvendedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_viewvendedor.TextColor = System.Drawing.Color.Gold;
            this.btn_viewvendedor.UseVisualStyleBackColor = false;
            this.btn_viewvendedor.Click += new System.EventHandler(this.btn_viewvendedor_Click_1);
            // 
            // btn_back
            // 
            this.btn_back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_back.BorderColor = System.Drawing.Color.Red;
            this.btn_back.BorderRadius = 7;
            this.btn_back.BorderSize = 2;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.Red;
            this.btn_back.Location = new System.Drawing.Point(820, 10);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(150, 40);
            this.btn_back.TabIndex = 18;
            this.btn_back.Text = "Regresar";
            this.btn_back.TextColor = System.Drawing.Color.Red;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click_1);
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
            this.btn_addvendedor.Location = new System.Drawing.Point(7, 10);
            this.btn_addvendedor.Name = "btn_addvendedor";
            this.btn_addvendedor.Size = new System.Drawing.Size(225, 40);
            this.btn_addvendedor.TabIndex = 17;
            this.btn_addvendedor.Text = "AGREGAR VENDEDOR";
            this.btn_addvendedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addvendedor.TextColor = System.Drawing.Color.Lime;
            this.btn_addvendedor.UseVisualStyleBackColor = false;
            this.btn_addvendedor.Click += new System.EventHandler(this.btn_addvendedor_Click_1);
            // 
            // formCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 537);
            this.Controls.Add(this.panel_main);
            this.Name = "formCustomers";
            this.Text = "formCustomers";
            this.panel_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_proveedores)).EndInit();
            this.panel_footer.ResumeLayout(false);
            this.panel_update.ResumeLayout(false);
            this.panel_update.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.DataGridView grid_proveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente_fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente_dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente_email;
        private System.Windows.Forms.DataGridViewButtonColumn cliente_eliminar;
        private System.Windows.Forms.DataGridViewButtonColumn cliente_editar;
        private System.Windows.Forms.Panel panel_footer;
        private System.Windows.Forms.Panel panel_update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJButton btn_viewvendedor;
        private RJCodeAdvance.RJControls.RJButton btn_back;
        private RJCodeAdvance.RJControls.RJButton btn_addvendedor;
    }
}