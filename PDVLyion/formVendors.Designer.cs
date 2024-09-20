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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rjButton2 = new RJCodeAdvance.RJControls.RJButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rjButton5 = new RJCodeAdvance.RJControls.RJButton();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            this.cuit_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razon_social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forma_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_main.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.AutoSize = true;
            this.panel_main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_main.Controls.Add(this.dataGridView1);
            this.panel_main.Controls.Add(this.rjButton5);
            this.panel_main.Controls.Add(this.rjButton2);
            this.panel_main.Controls.Add(this.panel3);
            this.panel_main.Controls.Add(this.rjButton1);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(982, 537);
            this.panel_main.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Khaki;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 459);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(987, 18);
            this.panel3.TabIndex = 3;
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
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.Transparent;
            this.rjButton2.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton2.BorderColor = System.Drawing.Color.Chartreuse;
            this.rjButton2.BorderRadius = 7;
            this.rjButton2.BorderSize = 2;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.Lime;
            this.rjButton2.Location = new System.Drawing.Point(813, 398);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(150, 40);
            this.rjButton2.TabIndex = 5;
            this.rjButton2.Text = "Regresar";
            this.rjButton2.TextColor = System.Drawing.Color.Lime;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cuit_proveedor,
            this.name_proveedor,
            this.razon_social,
            this.tipo_cat,
            this.num_tel,
            this.forma_pago});
            this.dataGridView1.Location = new System.Drawing.Point(250, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(720, 374);
            this.dataGridView1.TabIndex = 9;
            // 
            // rjButton5
            // 
            this.rjButton5.BackColor = System.Drawing.Color.Transparent;
            this.rjButton5.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton5.BorderColor = System.Drawing.Color.Gold;
            this.rjButton5.BorderRadius = 7;
            this.rjButton5.BorderSize = 2;
            this.rjButton5.FlatAppearance.BorderSize = 0;
            this.rjButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton5.ForeColor = System.Drawing.Color.Gold;
            this.rjButton5.Image = ((System.Drawing.Image)(resources.GetObject("rjButton5.Image")));
            this.rjButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton5.Location = new System.Drawing.Point(12, 58);
            this.rjButton5.Name = "rjButton5";
            this.rjButton5.Size = new System.Drawing.Size(220, 50);
            this.rjButton5.TabIndex = 8;
            this.rjButton5.Text = "VISUALIZAR VENDEDORES";
            this.rjButton5.TextColor = System.Drawing.Color.Gold;
            this.rjButton5.UseVisualStyleBackColor = false;
            this.rjButton5.Click += new System.EventHandler(this.rjButton5_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Transparent;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton1.BorderColor = System.Drawing.Color.Gold;
            this.rjButton1.BorderRadius = 7;
            this.rjButton1.BorderSize = 2;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.Gold;
            this.rjButton1.Image = ((System.Drawing.Image)(resources.GetObject("rjButton1.Image")));
            this.rjButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton1.Location = new System.Drawing.Point(12, 12);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(220, 40);
            this.rjButton1.TabIndex = 0;
            this.rjButton1.Text = "AGREGAR VENDEDOR";
            this.rjButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjButton1.TextColor = System.Drawing.Color.Gold;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
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
            // formVendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 537);
            this.Controls.Add(this.panel_main);
            this.Name = "formVendors";
            this.Text = "formVendors";
            this.panel_main.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJButton rjButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RJCodeAdvance.RJControls.RJButton rjButton5;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn razon_social;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn forma_pago;
    }
}