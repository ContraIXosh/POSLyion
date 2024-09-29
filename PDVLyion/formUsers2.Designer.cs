namespace PDCLyion
{
    partial class formUsers2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUsers2));
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_footer = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_viewvendedor = new RJCodeAdvance.RJControls.RJButton();
            this.btn_useradd = new RJCodeAdvance.RJControls.RJButton();
            this.btn_back = new RJCodeAdvance.RJControls.RJButton();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.btn_seleccionar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_nombre_completo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_id_rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_estado_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel_main.SuspendLayout();
            this.panel_footer.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.AutoSize = true;
            this.panel_main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_main.Controls.Add(this.panel_footer);
            this.panel_main.Controls.Add(this.dgvdata);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(966, 498);
            this.panel_main.TabIndex = 4;
            // 
            // panel_footer
            // 
            this.panel_footer.Controls.Add(this.panel3);
            this.panel_footer.Controls.Add(this.btn_viewvendedor);
            this.panel_footer.Controls.Add(this.btn_useradd);
            this.panel_footer.Controls.Add(this.btn_back);
            this.panel_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_footer.Location = new System.Drawing.Point(0, 421);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(966, 77);
            this.panel_footer.TabIndex = 12;
            this.panel_footer.Resize += new System.EventHandler(this.panel_footer_Resize);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Khaki;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(966, 18);
            this.panel3.TabIndex = 13;
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
            this.btn_viewvendedor.Location = new System.Drawing.Point(219, 8);
            this.btn_viewvendedor.Name = "btn_viewvendedor";
            this.btn_viewvendedor.Size = new System.Drawing.Size(225, 40);
            this.btn_viewvendedor.TabIndex = 10;
            this.btn_viewvendedor.Text = "VISUALIZAR USUARIOS";
            this.btn_viewvendedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_viewvendedor.TextColor = System.Drawing.Color.Gold;
            this.btn_viewvendedor.UseVisualStyleBackColor = false;
            this.btn_viewvendedor.Click += new System.EventHandler(this.btn_viewvendedor_Click);
            // 
            // btn_useradd
            // 
            this.btn_useradd.BackColor = System.Drawing.Color.Transparent;
            this.btn_useradd.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_useradd.BorderColor = System.Drawing.Color.Lime;
            this.btn_useradd.BorderRadius = 7;
            this.btn_useradd.BorderSize = 2;
            this.btn_useradd.FlatAppearance.BorderSize = 0;
            this.btn_useradd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_useradd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_useradd.ForeColor = System.Drawing.Color.Lime;
            this.btn_useradd.Image = ((System.Drawing.Image)(resources.GetObject("btn_useradd.Image")));
            this.btn_useradd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_useradd.Location = new System.Drawing.Point(7, 8);
            this.btn_useradd.Name = "btn_useradd";
            this.btn_useradd.Size = new System.Drawing.Size(206, 40);
            this.btn_useradd.TabIndex = 9;
            this.btn_useradd.Text = "AGREGAR USUARIO";
            this.btn_useradd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_useradd.TextColor = System.Drawing.Color.Lime;
            this.btn_useradd.UseVisualStyleBackColor = false;
            this.btn_useradd.Click += new System.EventHandler(this.btn_useradd_Click);
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
            this.btn_back.Location = new System.Drawing.Point(813, 8);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(150, 40);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Regresar";
            this.btn_back.TextColor = System.Drawing.Color.Red;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btn_seleccionar,
            this.data_id,
            this.data_dni,
            this.data_nombre_completo,
            this.data_correo,
            this.data_username,
            this.data_clave,
            this.data_id_rol,
            this.data_rol,
            this.data_tel,
            this.data_estado,
            this.data_estado_valor,
            this.btn_eliminar,
            this.btn_editar});
            this.dgvdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvdata.Location = new System.Drawing.Point(0, 0);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.Size = new System.Drawing.Size(966, 498);
            this.dgvdata.TabIndex = 9;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.HeaderText = "";
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.ReadOnly = true;
            this.btn_seleccionar.Width = 20;
            // 
            // data_id
            // 
            this.data_id.FillWeight = 50F;
            this.data_id.HeaderText = "ID";
            this.data_id.Name = "data_id";
            this.data_id.ReadOnly = true;
            this.data_id.Visible = false;
            this.data_id.Width = 50;
            // 
            // data_dni
            // 
            this.data_dni.HeaderText = "DNI";
            this.data_dni.Name = "data_dni";
            this.data_dni.ReadOnly = true;
            // 
            // data_nombre_completo
            // 
            this.data_nombre_completo.HeaderText = "NOMBRE";
            this.data_nombre_completo.Name = "data_nombre_completo";
            this.data_nombre_completo.ReadOnly = true;
            // 
            // data_correo
            // 
            this.data_correo.HeaderText = "CORREO";
            this.data_correo.Name = "data_correo";
            this.data_correo.ReadOnly = true;
            // 
            // data_username
            // 
            this.data_username.HeaderText = "NOMBRE USUARIO";
            this.data_username.Name = "data_username";
            this.data_username.ReadOnly = true;
            // 
            // data_clave
            // 
            this.data_clave.HeaderText = "CLAVE";
            this.data_clave.Name = "data_clave";
            this.data_clave.ReadOnly = true;
            // 
            // data_id_rol
            // 
            this.data_id_rol.HeaderText = "IDROL";
            this.data_id_rol.Name = "data_id_rol";
            this.data_id_rol.ReadOnly = true;
            this.data_id_rol.Width = 20;
            // 
            // data_rol
            // 
            this.data_rol.HeaderText = "ROL";
            this.data_rol.Name = "data_rol";
            this.data_rol.ReadOnly = true;
            this.data_rol.Width = 20;
            // 
            // data_tel
            // 
            this.data_tel.HeaderText = "TELEFONO";
            this.data_tel.Name = "data_tel";
            this.data_tel.ReadOnly = true;
            // 
            // data_estado
            // 
            this.data_estado.HeaderText = "ESTADO";
            this.data_estado.Name = "data_estado";
            this.data_estado.ReadOnly = true;
            this.data_estado.Width = 50;
            // 
            // data_estado_valor
            // 
            this.data_estado_valor.HeaderText = "ESTADO_VALOR";
            this.data_estado_valor.Name = "data_estado_valor";
            this.data_estado_valor.ReadOnly = true;
            this.data_estado_valor.Visible = false;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.btn_eliminar.FillWeight = 60F;
            this.btn_eliminar.HeaderText = "ELIMINAR";
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.ReadOnly = true;
            this.btn_eliminar.Width = 64;
            // 
            // btn_editar
            // 
            this.btn_editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.btn_editar.FillWeight = 50F;
            this.btn_editar.HeaderText = "EDITAR";
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.ReadOnly = true;
            this.btn_editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btn_editar.Width = 72;
            // 
            // formUsers2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 498);
            this.Controls.Add(this.panel_main);
            this.Name = "formUsers2";
            this.Text = "formUsers2";
            this.Load += new System.EventHandler(this.formUsers2_Load);
            this.Resize += new System.EventHandler(this.formUsers2_Resize);
            this.panel_main.ResumeLayout(false);
            this.panel_footer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn btn_seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_nombre_completo;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_username;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_id_rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_estado_valor;
        private System.Windows.Forms.DataGridViewButtonColumn btn_eliminar;
        private System.Windows.Forms.DataGridViewButtonColumn btn_editar;
        private System.Windows.Forms.Panel panel_footer;
        private RJCodeAdvance.RJControls.RJButton btn_viewvendedor;
        private RJCodeAdvance.RJControls.RJButton btn_useradd;
        private RJCodeAdvance.RJControls.RJButton btn_back;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}