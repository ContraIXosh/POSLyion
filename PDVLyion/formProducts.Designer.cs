namespace PDCLyion
{
    partial class formProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formProducts));
            this.panel_main = new System.Windows.Forms.Panel();
            this.grid_prod = new System.Windows.Forms.DataGridView();
            this.btn_seleccionar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_id_cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_stock_min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_precio_costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_precio_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_estado_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_btn = new System.Windows.Forms.Panel();
            this.btn_addprod = new RJCodeAdvance.RJControls.RJButton();
            this.btn_back = new RJCodeAdvance.RJControls.RJButton();
            this.btn_actualizar = new CustomBox.RJControls.RJButton();
            this.cb_inactive = new System.Windows.Forms.CheckBox();
            this.cb_stock = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbox_empresa = new CustomBox.RJControls.RJComboBox();
            this.lbl_cat = new System.Windows.Forms.Label();
            this.cbox_cat = new CustomBox.RJControls.RJComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lbl_search = new System.Windows.Forms.Label();
            this.panel_updates = new System.Windows.Forms.Panel();
            this.lbl_updatetime = new System.Windows.Forms.Label();
            this.lbl_updateversion = new System.Windows.Forms.Label();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_prod)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_btn.SuspendLayout();
            this.panel_updates.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_main.Controls.Add(this.grid_prod);
            this.panel_main.Controls.Add(this.panel2);
            this.panel_main.Controls.Add(this.panel_updates);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1086, 537);
            this.panel_main.TabIndex = 0;
            // 
            // grid_prod
            // 
            this.grid_prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_prod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btn_seleccionar,
            this.prod_id,
            this.prod_cod,
            this.prod_desc,
            this.prod_id_cat,
            this.prod_cat,
            this.prod_stock,
            this.prod_stock_min,
            this.prod_precio_costo,
            this.prod_precio_venta,
            this.prod_estado,
            this.prod_estado_valor,
            this.btn_editar,
            this.btn_eliminar});
            this.grid_prod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_prod.Location = new System.Drawing.Point(295, 0);
            this.grid_prod.Name = "grid_prod";
            this.grid_prod.Size = new System.Drawing.Size(791, 518);
            this.grid_prod.TabIndex = 8;
            this.grid_prod.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_prod_CellContentClick);
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.HeaderText = "";
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Width = 20;
            // 
            // prod_id
            // 
            this.prod_id.HeaderText = "ID";
            this.prod_id.Name = "prod_id";
            this.prod_id.Visible = false;
            // 
            // prod_cod
            // 
            this.prod_cod.HeaderText = "COD. BARRAS";
            this.prod_cod.Name = "prod_cod";
            // 
            // prod_desc
            // 
            this.prod_desc.HeaderText = "DESCRIPCIÓN";
            this.prod_desc.Name = "prod_desc";
            // 
            // prod_id_cat
            // 
            this.prod_id_cat.HeaderText = "ID CATEGORIA";
            this.prod_id_cat.Name = "prod_id_cat";
            this.prod_id_cat.Visible = false;
            // 
            // prod_cat
            // 
            this.prod_cat.HeaderText = "CATEGORÍA";
            this.prod_cat.Name = "prod_cat";
            // 
            // prod_stock
            // 
            this.prod_stock.HeaderText = "STOCK ACTUAL";
            this.prod_stock.Name = "prod_stock";
            this.prod_stock.Width = 40;
            // 
            // prod_stock_min
            // 
            this.prod_stock_min.HeaderText = "STOCK MIN";
            this.prod_stock_min.Name = "prod_stock_min";
            this.prod_stock_min.Width = 40;
            // 
            // prod_precio_costo
            // 
            this.prod_precio_costo.HeaderText = "PRECIO COSTO";
            this.prod_precio_costo.Name = "prod_precio_costo";
            this.prod_precio_costo.Width = 70;
            // 
            // prod_precio_venta
            // 
            this.prod_precio_venta.HeaderText = "PRECIO VENTA";
            this.prod_precio_venta.Name = "prod_precio_venta";
            this.prod_precio_venta.Width = 70;
            // 
            // prod_estado
            // 
            this.prod_estado.HeaderText = "ESTADO";
            this.prod_estado.Name = "prod_estado";
            this.prod_estado.Width = 70;
            // 
            // prod_estado_valor
            // 
            this.prod_estado_valor.HeaderText = "ESTADO VALOR";
            this.prod_estado_valor.Name = "prod_estado_valor";
            this.prod_estado_valor.Visible = false;
            // 
            // btn_editar
            // 
            this.btn_editar.HeaderText = "EDITAR";
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Width = 70;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.HeaderText = "ELIMINAR";
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Width = 70;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel_btn);
            this.panel2.Controls.Add(this.cb_inactive);
            this.panel2.Controls.Add(this.cb_stock);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbox_empresa);
            this.panel2.Controls.Add(this.lbl_cat);
            this.panel2.Controls.Add(this.cbox_cat);
            this.panel2.Controls.Add(this.txt_search);
            this.panel2.Controls.Add(this.lbl_search);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 518);
            this.panel2.TabIndex = 7;
            // 
            // panel_btn
            // 
            this.panel_btn.Controls.Add(this.btn_addprod);
            this.panel_btn.Controls.Add(this.btn_back);
            this.panel_btn.Controls.Add(this.btn_actualizar);
            this.panel_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_btn.Location = new System.Drawing.Point(0, 391);
            this.panel_btn.Name = "panel_btn";
            this.panel_btn.Size = new System.Drawing.Size(295, 127);
            this.panel_btn.TabIndex = 13;
            // 
            // btn_addprod
            // 
            this.btn_addprod.BackColor = System.Drawing.Color.Transparent;
            this.btn_addprod.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_addprod.BorderColor = System.Drawing.Color.LawnGreen;
            this.btn_addprod.BorderRadius = 7;
            this.btn_addprod.BorderSize = 2;
            this.btn_addprod.FlatAppearance.BorderSize = 0;
            this.btn_addprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addprod.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_addprod.Image = ((System.Drawing.Image)(resources.GetObject("btn_addprod.Image")));
            this.btn_addprod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addprod.Location = new System.Drawing.Point(34, 45);
            this.btn_addprod.Name = "btn_addprod";
            this.btn_addprod.Size = new System.Drawing.Size(225, 40);
            this.btn_addprod.TabIndex = 12;
            this.btn_addprod.Text = "AGREGAR PRODUCTO";
            this.btn_addprod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addprod.TextColor = System.Drawing.Color.Chartreuse;
            this.btn_addprod.UseVisualStyleBackColor = false;
            this.btn_addprod.Click += new System.EventHandler(this.btn_addprod_Click);
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
            this.btn_back.Location = new System.Drawing.Point(34, 84);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(225, 40);
            this.btn_back.TabIndex = 11;
            this.btn_back.Text = "Regresar";
            this.btn_back.TextColor = System.Drawing.Color.Red;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_actualizar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_actualizar.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btn_actualizar.BorderRadius = 10;
            this.btn_actualizar.BorderSize = 2;
            this.btn_actualizar.FlatAppearance.BorderSize = 0;
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btn_actualizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_actualizar.Image")));
            this.btn_actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_actualizar.Location = new System.Drawing.Point(34, 3);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(225, 38);
            this.btn_actualizar.TabIndex = 6;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.TextColor = System.Drawing.Color.PaleTurquoise;
            this.btn_actualizar.UseVisualStyleBackColor = false;
            // 
            // cb_inactive
            // 
            this.cb_inactive.AutoSize = true;
            this.cb_inactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_inactive.ForeColor = System.Drawing.Color.Gold;
            this.cb_inactive.Location = new System.Drawing.Point(17, 271);
            this.cb_inactive.Name = "cb_inactive";
            this.cb_inactive.Size = new System.Drawing.Size(164, 24);
            this.cb_inactive.TabIndex = 10;
            this.cb_inactive.Text = "Mostrar inactivos";
            this.cb_inactive.UseVisualStyleBackColor = true;
            this.cb_inactive.CheckedChanged += new System.EventHandler(this.cb_inactive_CheckedChanged);
            // 
            // cb_stock
            // 
            this.cb_stock.AutoSize = true;
            this.cb_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_stock.ForeColor = System.Drawing.Color.Gold;
            this.cb_stock.Location = new System.Drawing.Point(17, 238);
            this.cb_stock.Name = "cb_stock";
            this.cb_stock.Size = new System.Drawing.Size(209, 24);
            this.cb_stock.TabIndex = 9;
            this.cb_stock.Text = "Mostrar solo con stock";
            this.cb_stock.UseVisualStyleBackColor = true;
            this.cb_stock.CheckedChanged += new System.EventHandler(this.cb_stock_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(80, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "EMPRESA";
            // 
            // cbox_empresa
            // 
            this.cbox_empresa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbox_empresa.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbox_empresa.BorderSize = 1;
            this.cbox_empresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbox_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbox_empresa.ForeColor = System.Drawing.Color.DimGray;
            this.cbox_empresa.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbox_empresa.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbox_empresa.ListTextColor = System.Drawing.Color.DimGray;
            this.cbox_empresa.Location = new System.Drawing.Point(17, 190);
            this.cbox_empresa.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbox_empresa.Name = "cbox_empresa";
            this.cbox_empresa.Padding = new System.Windows.Forms.Padding(1);
            this.cbox_empresa.Size = new System.Drawing.Size(261, 30);
            this.cbox_empresa.TabIndex = 7;
            this.cbox_empresa.Texts = "";
            // 
            // lbl_cat
            // 
            this.lbl_cat.AutoSize = true;
            this.lbl_cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cat.ForeColor = System.Drawing.Color.Gold;
            this.lbl_cat.Location = new System.Drawing.Point(80, 88);
            this.lbl_cat.Name = "lbl_cat";
            this.lbl_cat.Size = new System.Drawing.Size(143, 25);
            this.lbl_cat.TabIndex = 5;
            this.lbl_cat.Text = "CATEGORIA";
            // 
            // cbox_cat
            // 
            this.cbox_cat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbox_cat.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbox_cat.BorderSize = 1;
            this.cbox_cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbox_cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbox_cat.ForeColor = System.Drawing.Color.DimGray;
            this.cbox_cat.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbox_cat.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbox_cat.ListTextColor = System.Drawing.Color.DimGray;
            this.cbox_cat.Location = new System.Drawing.Point(17, 116);
            this.cbox_cat.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbox_cat.Name = "cbox_cat";
            this.cbox_cat.Padding = new System.Windows.Forms.Padding(1);
            this.cbox_cat.Size = new System.Drawing.Size(261, 30);
            this.cbox_cat.TabIndex = 1;
            this.cbox_cat.Texts = "";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(17, 39);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(261, 29);
            this.txt_search.TabIndex = 0;
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search.ForeColor = System.Drawing.Color.Gold;
            this.lbl_search.Location = new System.Drawing.Point(80, 12);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(137, 25);
            this.lbl_search.TabIndex = 4;
            this.lbl_search.Text = "BUSQUEDA";
            // 
            // panel_updates
            // 
            this.panel_updates.BackColor = System.Drawing.Color.Khaki;
            this.panel_updates.Controls.Add(this.lbl_updatetime);
            this.panel_updates.Controls.Add(this.lbl_updateversion);
            this.panel_updates.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_updates.Location = new System.Drawing.Point(0, 518);
            this.panel_updates.Margin = new System.Windows.Forms.Padding(0);
            this.panel_updates.Name = "panel_updates";
            this.panel_updates.Size = new System.Drawing.Size(1086, 19);
            this.panel_updates.TabIndex = 3;
            // 
            // lbl_updatetime
            // 
            this.lbl_updatetime.AutoSize = true;
            this.lbl_updatetime.Location = new System.Drawing.Point(633, 3);
            this.lbl_updatetime.Name = "lbl_updatetime";
            this.lbl_updatetime.Size = new System.Drawing.Size(199, 13);
            this.lbl_updatetime.TabIndex = 1;
            this.lbl_updatetime.Text = "Ultimo chequeo: 10:06:12  - 20/09/2024";
            // 
            // lbl_updateversion
            // 
            this.lbl_updateversion.AutoSize = true;
            this.lbl_updateversion.Location = new System.Drawing.Point(863, 2);
            this.lbl_updateversion.Name = "lbl_updateversion";
            this.lbl_updateversion.Size = new System.Drawing.Size(115, 13);
            this.lbl_updateversion.TabIndex = 0;
            this.lbl_updateversion.Text = "Actualizacion: v1.0.0.5";
            // 
            // formProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 537);
            this.Controls.Add(this.panel_main);
            this.Name = "formProducts";
            this.Text = "formProducts";
            this.Load += new System.EventHandler(this.formProducts_Load);
            this.panel_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_prod)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_btn.ResumeLayout(false);
            this.panel_updates.ResumeLayout(false);
            this.panel_updates.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_updates;
        private System.Windows.Forms.Label lbl_updatetime;
        private System.Windows.Forms.Label lbl_updateversion;
        private System.Windows.Forms.DataGridView grid_prod;
        private System.Windows.Forms.Panel panel2;
        private CustomBox.RJControls.RJComboBox cbox_cat;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lbl_cat;
        private System.Windows.Forms.Label lbl_search;
        private CustomBox.RJControls.RJButton btn_actualizar;
        private System.Windows.Forms.Label label3;
        private CustomBox.RJControls.RJComboBox cbox_empresa;
        private System.Windows.Forms.CheckBox cb_inactive;
        private System.Windows.Forms.CheckBox cb_stock;
        private RJCodeAdvance.RJControls.RJButton btn_back;
        private RJCodeAdvance.RJControls.RJButton btn_addprod;
        private System.Windows.Forms.Panel panel_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn btn_seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_id_cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_stock_min;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_precio_costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_precio_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_estado_valor;
        private System.Windows.Forms.DataGridViewButtonColumn btn_editar;
        private System.Windows.Forms.DataGridViewButtonColumn btn_eliminar;
    }
}