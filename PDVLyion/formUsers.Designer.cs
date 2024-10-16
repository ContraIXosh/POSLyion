namespace PDCLyion
{
    partial class formUsers
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUsers));
            this.panel_main = new System.Windows.Forms.TableLayoutPanel();
            this.panel_bottom = new System.Windows.Forms.TableLayoutPanel();
            this.panel_updates = new System.Windows.Forms.Panel();
            this.lbl_updatetime = new System.Windows.Forms.Label();
            this.lbl_updateversion = new System.Windows.Forms.Label();
            this.panel_mid = new System.Windows.Forms.TableLayoutPanel();
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
            this.data_estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.data_estado_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel_midizq = new System.Windows.Forms.TableLayoutPanel();
            this.panel_btns = new System.Windows.Forms.TableLayoutPanel();
            this.btn_addprod = new RJCodeAdvance.RJControls.RJButton();
            this.btn_actualizar = new CustomBox.RJControls.RJButton();
            this.panel_filter = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_search = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.cbox_empresa = new CustomBox.RJControls.RJComboBox();
            this.cb_inactive = new System.Windows.Forms.CheckBox();
            this.menu_sesion = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.verPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioAdministradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Main = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_main.SuspendLayout();
            this.panel_bottom.SuspendLayout();
            this.panel_updates.SuspendLayout();
            this.panel_mid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.panel_midizq.SuspendLayout();
            this.panel_btns.SuspendLayout();
            this.panel_filter.SuspendLayout();
            this.menu_sesion.SuspendLayout();
            this.menu_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_main.ColumnCount = 1;
            this.panel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_main.Controls.Add(this.panel_bottom, 0, 1);
            this.panel_main.Controls.Add(this.panel_mid, 0, 0);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Margin = new System.Windows.Forms.Padding(0);
            this.panel_main.Name = "panel_main";
            this.panel_main.RowCount = 2;
            this.panel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_main.Size = new System.Drawing.Size(1086, 537);
            this.panel_main.TabIndex = 1;
            // 
            // panel_bottom
            // 
            this.panel_bottom.ColumnCount = 1;
            this.panel_bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_bottom.Controls.Add(this.panel_updates, 0, 0);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_bottom.Location = new System.Drawing.Point(0, 517);
            this.panel_bottom.Margin = new System.Windows.Forms.Padding(0);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.RowCount = 1;
            this.panel_bottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_bottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_bottom.Size = new System.Drawing.Size(1086, 20);
            this.panel_bottom.TabIndex = 0;
            // 
            // panel_updates
            // 
            this.panel_updates.BackColor = System.Drawing.Color.Khaki;
            this.panel_updates.Controls.Add(this.lbl_updatetime);
            this.panel_updates.Controls.Add(this.lbl_updateversion);
            this.panel_updates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_updates.Location = new System.Drawing.Point(0, 0);
            this.panel_updates.Margin = new System.Windows.Forms.Padding(0);
            this.panel_updates.Name = "panel_updates";
            this.panel_updates.Size = new System.Drawing.Size(1086, 20);
            this.panel_updates.TabIndex = 10;
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
            // panel_mid
            // 
            this.panel_mid.ColumnCount = 2;
            this.panel_mid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.panel_mid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.19048F));
            this.panel_mid.Controls.Add(this.dgvdata, 1, 0);
            this.panel_mid.Controls.Add(this.panel_midizq, 0, 0);
            this.panel_mid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_mid.Location = new System.Drawing.Point(0, 0);
            this.panel_mid.Margin = new System.Windows.Forms.Padding(0);
            this.panel_mid.Name = "panel_mid";
            this.panel_mid.RowCount = 1;
            this.panel_mid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_mid.Size = new System.Drawing.Size(1086, 517);
            this.panel_mid.TabIndex = 1;
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.AllowUserToDeleteRows = false;
            this.dgvdata.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvdata.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
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
            this.btn_editar,
            this.btn_eliminar});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvdata.EnableHeadersVisualStyles = false;
            this.dgvdata.GridColor = System.Drawing.Color.DarkRed;
            this.dgvdata.Location = new System.Drawing.Point(258, 0);
            this.dgvdata.Margin = new System.Windows.Forms.Padding(0);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvdata.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdata.Size = new System.Drawing.Size(828, 517);
            this.dgvdata.TabIndex = 32;
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
            this.data_dni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.data_dni.FillWeight = 80F;
            this.data_dni.HeaderText = "DNI";
            this.data_dni.Name = "data_dni";
            this.data_dni.ReadOnly = true;
            // 
            // data_nombre_completo
            // 
            this.data_nombre_completo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.data_nombre_completo.FillWeight = 150F;
            this.data_nombre_completo.HeaderText = "NOMBRE";
            this.data_nombre_completo.Name = "data_nombre_completo";
            this.data_nombre_completo.ReadOnly = true;
            // 
            // data_correo
            // 
            this.data_correo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.data_correo.FillWeight = 150F;
            this.data_correo.HeaderText = "CORREO";
            this.data_correo.Name = "data_correo";
            this.data_correo.ReadOnly = true;
            this.data_correo.Visible = false;
            // 
            // data_username
            // 
            this.data_username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.data_username.FillWeight = 120F;
            this.data_username.HeaderText = "NOMBRE USUARIO";
            this.data_username.Name = "data_username";
            this.data_username.ReadOnly = true;
            // 
            // data_clave
            // 
            this.data_clave.HeaderText = "CLAVE";
            this.data_clave.Name = "data_clave";
            this.data_clave.ReadOnly = true;
            this.data_clave.Visible = false;
            // 
            // data_id_rol
            // 
            this.data_id_rol.HeaderText = "IDROL";
            this.data_id_rol.Name = "data_id_rol";
            this.data_id_rol.ReadOnly = true;
            this.data_id_rol.Visible = false;
            this.data_id_rol.Width = 20;
            // 
            // data_rol
            // 
            this.data_rol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.data_rol.FillWeight = 40F;
            this.data_rol.HeaderText = "ROL";
            this.data_rol.Name = "data_rol";
            this.data_rol.ReadOnly = true;
            // 
            // data_tel
            // 
            this.data_tel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.data_tel.FillWeight = 80F;
            this.data_tel.HeaderText = "TELEFONO";
            this.data_tel.Name = "data_tel";
            this.data_tel.ReadOnly = true;
            // 
            // data_estado
            // 
            this.data_estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.data_estado.FillWeight = 80F;
            this.data_estado.HeaderText = "ESTADO";
            this.data_estado.Name = "data_estado";
            this.data_estado.ReadOnly = true;
            this.data_estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.data_estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // data_estado_valor
            // 
            this.data_estado_valor.HeaderText = "ESTADO_VALOR";
            this.data_estado_valor.Name = "data_estado_valor";
            this.data_estado_valor.ReadOnly = true;
            this.data_estado_valor.Visible = false;
            // 
            // btn_editar
            // 
            this.btn_editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btn_editar.FillWeight = 60F;
            this.btn_editar.HeaderText = "EDITAR";
            this.btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar.Image")));
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.ReadOnly = true;
            this.btn_editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btn_eliminar.FillWeight = 60F;
            this.btn_eliminar.HeaderText = "ELIMINAR";
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.ReadOnly = true;
            this.btn_eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // panel_midizq
            // 
            this.panel_midizq.ColumnCount = 1;
            this.panel_midizq.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_midizq.Controls.Add(this.panel_btns, 0, 1);
            this.panel_midizq.Controls.Add(this.panel_filter, 0, 0);
            this.panel_midizq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_midizq.Location = new System.Drawing.Point(0, 0);
            this.panel_midizq.Margin = new System.Windows.Forms.Padding(0);
            this.panel_midizq.Name = "panel_midizq";
            this.panel_midizq.RowCount = 2;
            this.panel_midizq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.panel_midizq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.panel_midizq.Size = new System.Drawing.Size(258, 517);
            this.panel_midizq.TabIndex = 14;
            // 
            // panel_btns
            // 
            this.panel_btns.ColumnCount = 1;
            this.panel_btns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_btns.Controls.Add(this.btn_addprod, 0, 0);
            this.panel_btns.Controls.Add(this.btn_actualizar, 0, 1);
            this.panel_btns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_btns.Location = new System.Drawing.Point(3, 364);
            this.panel_btns.Name = "panel_btns";
            this.panel_btns.RowCount = 3;
            this.panel_btns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panel_btns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panel_btns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panel_btns.Size = new System.Drawing.Size(252, 150);
            this.panel_btns.TabIndex = 16;
            // 
            // btn_addprod
            // 
            this.btn_addprod.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btn_addprod.Location = new System.Drawing.Point(13, 4);
            this.btn_addprod.Margin = new System.Windows.Forms.Padding(0);
            this.btn_addprod.Name = "btn_addprod";
            this.btn_addprod.Size = new System.Drawing.Size(225, 40);
            this.btn_addprod.TabIndex = 15;
            this.btn_addprod.Text = "AGREGAR USUARIO";
            this.btn_addprod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addprod.TextColor = System.Drawing.Color.Chartreuse;
            this.btn_addprod.UseVisualStyleBackColor = false;
            this.btn_addprod.Click += new System.EventHandler(this.btn_addprod_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btn_actualizar.Location = new System.Drawing.Point(13, 54);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(225, 38);
            this.btn_actualizar.TabIndex = 13;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.TextColor = System.Drawing.Color.PaleTurquoise;
            this.btn_actualizar.UseVisualStyleBackColor = false;
            // 
            // panel_filter
            // 
            this.panel_filter.ColumnCount = 1;
            this.panel_filter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_filter.Controls.Add(this.label3, 0, 2);
            this.panel_filter.Controls.Add(this.lbl_search, 0, 0);
            this.panel_filter.Controls.Add(this.txt_search, 0, 1);
            this.panel_filter.Controls.Add(this.cbox_empresa, 0, 3);
            this.panel_filter.Controls.Add(this.cb_inactive, 0, 5);
            this.panel_filter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_filter.Location = new System.Drawing.Point(0, 0);
            this.panel_filter.Margin = new System.Windows.Forms.Padding(0);
            this.panel_filter.Name = "panel_filter";
            this.panel_filter.RowCount = 8;
            this.panel_filter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.7551F));
            this.panel_filter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.7551F));
            this.panel_filter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.7551F));
            this.panel_filter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.7551F));
            this.panel_filter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.7551F));
            this.panel_filter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.7551F));
            this.panel_filter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.7551F));
            this.panel_filter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.71429F));
            this.panel_filter.Size = new System.Drawing.Size(258, 361);
            this.panel_filter.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(100, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "ROL";
            // 
            // lbl_search
            // 
            this.lbl_search.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_search.AutoSize = true;
            this.lbl_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search.ForeColor = System.Drawing.Color.Gold;
            this.lbl_search.Location = new System.Drawing.Point(60, 21);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(137, 25);
            this.lbl_search.TabIndex = 13;
            this.lbl_search.Text = "BUSQUEDA";
            // 
            // txt_search
            // 
            this.txt_search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(3, 49);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(251, 29);
            this.txt_search.TabIndex = 11;
            // 
            // cbox_empresa
            // 
            this.cbox_empresa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbox_empresa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbox_empresa.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbox_empresa.BorderSize = 1;
            this.cbox_empresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbox_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbox_empresa.ForeColor = System.Drawing.Color.DimGray;
            this.cbox_empresa.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbox_empresa.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbox_empresa.ListTextColor = System.Drawing.Color.DimGray;
            this.cbox_empresa.Location = new System.Drawing.Point(3, 141);
            this.cbox_empresa.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbox_empresa.Name = "cbox_empresa";
            this.cbox_empresa.Padding = new System.Windows.Forms.Padding(1);
            this.cbox_empresa.Size = new System.Drawing.Size(251, 30);
            this.cbox_empresa.TabIndex = 15;
            this.cbox_empresa.Texts = "";
            // 
            // cb_inactive
            // 
            this.cb_inactive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_inactive.AutoSize = true;
            this.cb_inactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_inactive.ForeColor = System.Drawing.Color.Gold;
            this.cb_inactive.Location = new System.Drawing.Point(47, 241);
            this.cb_inactive.Name = "cb_inactive";
            this.cb_inactive.Size = new System.Drawing.Size(164, 24);
            this.cb_inactive.TabIndex = 18;
            this.cb_inactive.Text = "Mostrar inactivos";
            this.cb_inactive.UseVisualStyleBackColor = true;
            // 
            // menu_sesion
            // 
            this.menu_sesion.DropShadowEnabled = false;
            this.menu_sesion.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_sesion.IsMainMenu = false;
            this.menu_sesion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPerfilToolStripMenuItem,
            this.inicioAdministradorToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.menu_sesion.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menu_sesion.MenuItemHeight = 25;
            this.menu_sesion.MenuItemTextColor = System.Drawing.Color.Black;
            this.menu_sesion.Name = "menu_sesion";
            this.menu_sesion.PrimaryColor = System.Drawing.Color.Gold;
            this.menu_sesion.Size = new System.Drawing.Size(203, 70);
            // 
            // verPerfilToolStripMenuItem
            // 
            this.verPerfilToolStripMenuItem.Name = "verPerfilToolStripMenuItem";
            this.verPerfilToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.verPerfilToolStripMenuItem.Text = "Ver perfil";
            // 
            // inicioAdministradorToolStripMenuItem
            // 
            this.inicioAdministradorToolStripMenuItem.Name = "inicioAdministradorToolStripMenuItem";
            this.inicioAdministradorToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.inicioAdministradorToolStripMenuItem.Text = "Inicio Administrador";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            // 
            // menu_Main
            // 
            this.menu_Main.IsMainMenu = true;
            this.menu_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.configuraciónToolStripMenuItem});
            this.menu_Main.MenuItemHeight = 25;
            this.menu_Main.MenuItemTextColor = System.Drawing.Color.White;
            this.menu_Main.Name = "menu_Main";
            this.menu_Main.PrimaryColor = System.Drawing.Color.Gold;
            this.menu_Main.Size = new System.Drawing.Size(151, 202);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // formUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 537);
            this.Controls.Add(this.panel_main);
            this.Name = "formUsers";
            this.Text = "formUsers2";
            this.Load += new System.EventHandler(this.formUsers2_Load);
            this.Resize += new System.EventHandler(this.formUsers2_Resize);
            this.panel_main.ResumeLayout(false);
            this.panel_bottom.ResumeLayout(false);
            this.panel_updates.ResumeLayout(false);
            this.panel_updates.PerformLayout();
            this.panel_mid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.panel_midizq.ResumeLayout(false);
            this.panel_btns.ResumeLayout(false);
            this.panel_filter.ResumeLayout(false);
            this.panel_filter.PerformLayout();
            this.menu_sesion.ResumeLayout(false);
            this.menu_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel_main;
        private System.Windows.Forms.TableLayoutPanel panel_bottom;
        private System.Windows.Forms.Panel panel_updates;
        private System.Windows.Forms.Label lbl_updatetime;
        private System.Windows.Forms.Label lbl_updateversion;
        private System.Windows.Forms.TableLayoutPanel panel_mid;
        private System.Windows.Forms.TableLayoutPanel panel_midizq;
        private System.Windows.Forms.TableLayoutPanel panel_btns;
        private RJCodeAdvance.RJControls.RJButton btn_addprod;
        private CustomBox.RJControls.RJButton btn_actualizar;
        private System.Windows.Forms.TableLayoutPanel panel_filter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.TextBox txt_search;
        private CustomBox.RJControls.RJComboBox cbox_empresa;
        private System.Windows.Forms.CheckBox cb_inactive;
        private System.Windows.Forms.DataGridView dgvdata;
        private RJCodeAdvance.RJControls.RJDropdownMenu menu_sesion;
        private System.Windows.Forms.ToolStripMenuItem verPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioAdministradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private RJCodeAdvance.RJControls.RJDropdownMenu menu_Main;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn data_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_estado_valor;
        private System.Windows.Forms.DataGridViewImageColumn btn_editar;
        private System.Windows.Forms.DataGridViewImageColumn btn_eliminar;
    }
}