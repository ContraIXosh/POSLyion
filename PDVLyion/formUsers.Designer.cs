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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUsers));
            this.panel_main = new System.Windows.Forms.TableLayoutPanel();
            this.panel_bottom = new System.Windows.Forms.TableLayoutPanel();
            this.panel_updates = new System.Windows.Forms.Panel();
            this.lbl_updatetime = new System.Windows.Forms.Label();
            this.lbl_updateversion = new System.Windows.Forms.Label();
            this.panel_mid = new System.Windows.Forms.TableLayoutPanel();
            this.grid_usuarios = new System.Windows.Forms.DataGridView();
            this.panel_midizq = new System.Windows.Forms.TableLayoutPanel();
            this.panel_btns = new System.Windows.Forms.TableLayoutPanel();
            this.btn_crear_usuario = new RJCodeAdvance.RJControls.RJButton();
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
            this.btn_seleccionar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel_main.SuspendLayout();
            this.panel_bottom.SuspendLayout();
            this.panel_updates.SuspendLayout();
            this.panel_mid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_usuarios)).BeginInit();
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
            this.panel_mid.Controls.Add(this.grid_usuarios, 1, 0);
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
            // grid_usuarios
            // 
            this.grid_usuarios.AllowUserToAddRows = false;
            this.grid_usuarios.AllowUserToDeleteRows = false;
            this.grid_usuarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.grid_usuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_usuarios.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grid_usuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_usuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_usuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btn_seleccionar,
            this.user_id,
            this.dni,
            this.full_name,
            this.email,
            this.username,
            this.password,
            this.rol_id,
            this.rol_description,
            this.phone,
            this.state,
            this.state_value,
            this.btn_editar,
            this.btn_eliminar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_usuarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_usuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_usuarios.EnableHeadersVisualStyles = false;
            this.grid_usuarios.GridColor = System.Drawing.Color.DarkRed;
            this.grid_usuarios.Location = new System.Drawing.Point(258, 0);
            this.grid_usuarios.Margin = new System.Windows.Forms.Padding(0);
            this.grid_usuarios.MultiSelect = false;
            this.grid_usuarios.Name = "grid_usuarios";
            this.grid_usuarios.ReadOnly = true;
            this.grid_usuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_usuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_usuarios.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.grid_usuarios.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_usuarios.Size = new System.Drawing.Size(828, 517);
            this.grid_usuarios.TabIndex = 32;
            this.grid_usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
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
            this.panel_btns.Controls.Add(this.btn_crear_usuario, 0, 0);
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
            // btn_crear_usuario
            // 
            this.btn_crear_usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_crear_usuario.BackColor = System.Drawing.Color.Transparent;
            this.btn_crear_usuario.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_crear_usuario.BorderColor = System.Drawing.Color.LawnGreen;
            this.btn_crear_usuario.BorderRadius = 7;
            this.btn_crear_usuario.BorderSize = 2;
            this.btn_crear_usuario.FlatAppearance.BorderSize = 0;
            this.btn_crear_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crear_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crear_usuario.ForeColor = System.Drawing.Color.Chartreuse;
            this.btn_crear_usuario.Image = ((System.Drawing.Image)(resources.GetObject("btn_crear_usuario.Image")));
            this.btn_crear_usuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_crear_usuario.Location = new System.Drawing.Point(13, 4);
            this.btn_crear_usuario.Margin = new System.Windows.Forms.Padding(0);
            this.btn_crear_usuario.Name = "btn_crear_usuario";
            this.btn_crear_usuario.Size = new System.Drawing.Size(225, 40);
            this.btn_crear_usuario.TabIndex = 15;
            this.btn_crear_usuario.Text = "AGREGAR USUARIO";
            this.btn_crear_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_crear_usuario.TextColor = System.Drawing.Color.Chartreuse;
            this.btn_crear_usuario.UseVisualStyleBackColor = false;
            this.btn_crear_usuario.Click += new System.EventHandler(this.btn_crear_usuario_Click);
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
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
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
            // btn_seleccionar
            // 
            this.btn_seleccionar.HeaderText = "";
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.ReadOnly = true;
            this.btn_seleccionar.Width = 20;
            // 
            // user_id
            // 
            this.user_id.FillWeight = 50F;
            this.user_id.HeaderText = "ID";
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            this.user_id.Visible = false;
            this.user_id.Width = 50;
            // 
            // dni
            // 
            this.dni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dni.FillWeight = 80F;
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            // 
            // full_name
            // 
            this.full_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.full_name.FillWeight = 150F;
            this.full_name.HeaderText = "NOMBRE";
            this.full_name.Name = "full_name";
            this.full_name.ReadOnly = true;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.FillWeight = 150F;
            this.email.HeaderText = "CORREO";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Visible = false;
            // 
            // username
            // 
            this.username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.username.FillWeight = 120F;
            this.username.HeaderText = "NOMBRE USUARIO";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // password
            // 
            this.password.HeaderText = "CLAVE";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Visible = false;
            // 
            // rol_id
            // 
            this.rol_id.HeaderText = "IDROL";
            this.rol_id.Name = "rol_id";
            this.rol_id.ReadOnly = true;
            this.rol_id.Visible = false;
            this.rol_id.Width = 20;
            // 
            // rol_description
            // 
            this.rol_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rol_description.FillWeight = 40F;
            this.rol_description.HeaderText = "ROL";
            this.rol_description.Name = "rol_description";
            this.rol_description.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phone.FillWeight = 80F;
            this.phone.HeaderText = "TELEFONO";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // state
            // 
            this.state.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.state.FillWeight = 80F;
            this.state.HeaderText = "ESTADO";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            this.state.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // state_value
            // 
            this.state_value.HeaderText = "ESTADO_VALOR";
            this.state_value.Name = "state_value";
            this.state_value.ReadOnly = true;
            this.state_value.Visible = false;
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
            // formUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 537);
            this.Controls.Add(this.panel_main);
            this.Name = "formUsers";
            this.Text = "formUsers2";
            this.Load += new System.EventHandler(this.formUsersAdd_Load);
            this.Resize += new System.EventHandler(this.formUsers2_Resize);
            this.panel_main.ResumeLayout(false);
            this.panel_bottom.ResumeLayout(false);
            this.panel_updates.ResumeLayout(false);
            this.panel_updates.PerformLayout();
            this.panel_mid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_usuarios)).EndInit();
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
        private RJCodeAdvance.RJControls.RJButton btn_crear_usuario;
        private CustomBox.RJControls.RJButton btn_actualizar;
        private System.Windows.Forms.TableLayoutPanel panel_filter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.TextBox txt_search;
        private CustomBox.RJControls.RJComboBox cbox_empresa;
        private System.Windows.Forms.CheckBox cb_inactive;
        private System.Windows.Forms.DataGridView grid_usuarios;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn state_value;
        private System.Windows.Forms.DataGridViewImageColumn btn_editar;
        private System.Windows.Forms.DataGridViewImageColumn btn_eliminar;
    }
}