﻿namespace POSLyion
{
    partial class formCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCategorias));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_retoque = new System.Windows.Forms.TableLayoutPanel();
            this.panel_bot = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_updateversion = new System.Windows.Forms.Label();
            this.lbl_updatetime = new System.Windows.Forms.Label();
            this.panel_mid = new System.Windows.Forms.TableLayoutPanel();
            this.panel_midizq = new System.Windows.Forms.TableLayoutPanel();
            this.panel_btns = new System.Windows.Forms.TableLayoutPanel();
            this.btn_cancelar = new RJCodeAdvance.RJControls.RJButton();
            this.lbl_edicion = new System.Windows.Forms.Label();
            this.txt_descripcion_editar = new CustomBox.RJControls.RJTextBox();
            this.btn_buscar = new RJCodeAdvance.RJControls.RJButton();
            this.btn_actualizar = new CustomBox.RJControls.RJButton();
            this.btn_crear_categoria = new RJCodeAdvance.RJControls.RJButton();
            this.txt_descripcion = new CustomBox.RJControls.RJTextBox();
            this.lbl_crear = new System.Windows.Forms.Label();
            this.btn_editar_categoria = new RJCodeAdvance.RJControls.RJButton();
            this.panel_filter = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_search = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.txt_id = new CustomBox.RJControls.RJTextBox();
            this.dgv_categorias = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menu_sesion.SuspendLayout();
            this.menu_Main.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.panel_retoque.SuspendLayout();
            this.panel_bot.SuspendLayout();
            this.panel_mid.SuspendLayout();
            this.panel_midizq.SuspendLayout();
            this.panel_btns.SuspendLayout();
            this.panel_filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
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
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_main.Controls.Add(this.panel_retoque);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Margin = new System.Windows.Forms.Padding(0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(982, 537);
            this.panel_main.TabIndex = 2;
            // 
            // panel_retoque
            // 
            this.panel_retoque.ColumnCount = 1;
            this.panel_retoque.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_retoque.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_retoque.Controls.Add(this.panel_bot, 0, 1);
            this.panel_retoque.Controls.Add(this.panel_mid, 0, 0);
            this.panel_retoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_retoque.Location = new System.Drawing.Point(0, 0);
            this.panel_retoque.Margin = new System.Windows.Forms.Padding(0);
            this.panel_retoque.Name = "panel_retoque";
            this.panel_retoque.RowCount = 2;
            this.panel_retoque.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_retoque.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_retoque.Size = new System.Drawing.Size(982, 537);
            this.panel_retoque.TabIndex = 0;
            // 
            // panel_bot
            // 
            this.panel_bot.BackColor = System.Drawing.Color.OrangeRed;
            this.panel_bot.ColumnCount = 3;
            this.panel_bot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_bot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panel_bot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panel_bot.Controls.Add(this.lbl_updateversion, 2, 0);
            this.panel_bot.Controls.Add(this.lbl_updatetime, 1, 0);
            this.panel_bot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_bot.Location = new System.Drawing.Point(0, 517);
            this.panel_bot.Margin = new System.Windows.Forms.Padding(0);
            this.panel_bot.Name = "panel_bot";
            this.panel_bot.RowCount = 1;
            this.panel_bot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_bot.Size = new System.Drawing.Size(982, 20);
            this.panel_bot.TabIndex = 18;
            // 
            // lbl_updateversion
            // 
            this.lbl_updateversion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_updateversion.AutoSize = true;
            this.lbl_updateversion.BackColor = System.Drawing.Color.OrangeRed;
            this.lbl_updateversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_updateversion.ForeColor = System.Drawing.Color.Gold;
            this.lbl_updateversion.Location = new System.Drawing.Point(841, 3);
            this.lbl_updateversion.Name = "lbl_updateversion";
            this.lbl_updateversion.Size = new System.Drawing.Size(138, 13);
            this.lbl_updateversion.TabIndex = 2;
            this.lbl_updateversion.Text = "Actualizacion: v1.0.0.5";
            // 
            // lbl_updatetime
            // 
            this.lbl_updatetime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_updatetime.AutoSize = true;
            this.lbl_updatetime.BackColor = System.Drawing.Color.OrangeRed;
            this.lbl_updatetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_updatetime.ForeColor = System.Drawing.Color.Gold;
            this.lbl_updatetime.Location = new System.Drawing.Point(598, 3);
            this.lbl_updatetime.Name = "lbl_updatetime";
            this.lbl_updatetime.Size = new System.Drawing.Size(237, 13);
            this.lbl_updatetime.TabIndex = 3;
            this.lbl_updatetime.Text = "Ultimo chequeo: 10:06:12  - 20/09/2024";
            // 
            // panel_mid
            // 
            this.panel_mid.BackColor = System.Drawing.Color.OrangeRed;
            this.panel_mid.ColumnCount = 2;
            this.panel_mid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.panel_mid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.panel_mid.Controls.Add(this.panel_midizq, 0, 0);
            this.panel_mid.Controls.Add(this.dgv_categorias, 1, 0);
            this.panel_mid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_mid.Location = new System.Drawing.Point(0, 0);
            this.panel_mid.Margin = new System.Windows.Forms.Padding(0);
            this.panel_mid.Name = "panel_mid";
            this.panel_mid.RowCount = 1;
            this.panel_mid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_mid.Size = new System.Drawing.Size(982, 517);
            this.panel_mid.TabIndex = 17;
            // 
            // panel_midizq
            // 
            this.panel_midizq.BackColor = System.Drawing.Color.OrangeRed;
            this.panel_midizq.ColumnCount = 1;
            this.panel_midizq.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_midizq.Controls.Add(this.panel_btns, 0, 1);
            this.panel_midizq.Controls.Add(this.panel_filter, 0, 0);
            this.panel_midizq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_midizq.Location = new System.Drawing.Point(0, 0);
            this.panel_midizq.Margin = new System.Windows.Forms.Padding(0);
            this.panel_midizq.Name = "panel_midizq";
            this.panel_midizq.RowCount = 2;
            this.panel_midizq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panel_midizq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.panel_midizq.Size = new System.Drawing.Size(294, 517);
            this.panel_midizq.TabIndex = 29;
            // 
            // panel_btns
            // 
            this.panel_btns.BackColor = System.Drawing.Color.Firebrick;
            this.panel_btns.ColumnCount = 1;
            this.panel_btns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_btns.Controls.Add(this.btn_cancelar, 0, 3);
            this.panel_btns.Controls.Add(this.lbl_edicion, 0, 0);
            this.panel_btns.Controls.Add(this.txt_descripcion_editar, 0, 1);
            this.panel_btns.Controls.Add(this.btn_buscar, 0, 8);
            this.panel_btns.Controls.Add(this.btn_actualizar, 0, 7);
            this.panel_btns.Controls.Add(this.btn_crear_categoria, 0, 6);
            this.panel_btns.Controls.Add(this.txt_descripcion, 0, 5);
            this.panel_btns.Controls.Add(this.lbl_crear, 0, 4);
            this.panel_btns.Controls.Add(this.btn_editar_categoria, 0, 2);
            this.panel_btns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_btns.Location = new System.Drawing.Point(5, 108);
            this.panel_btns.Margin = new System.Windows.Forms.Padding(5);
            this.panel_btns.Name = "panel_btns";
            this.panel_btns.RowCount = 9;
            this.panel_btns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.498484F));
            this.panel_btns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.39818F));
            this.panel_btns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.30048F));
            this.panel_btns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.30048F));
            this.panel_btns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.30048F));
            this.panel_btns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.30048F));
            this.panel_btns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.30048F));
            this.panel_btns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.30048F));
            this.panel_btns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.30048F));
            this.panel_btns.Size = new System.Drawing.Size(284, 404);
            this.panel_btns.TabIndex = 16;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_cancelar.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_cancelar.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.btn_cancelar.BorderColor = System.Drawing.Color.Red;
            this.btn_cancelar.BorderRadius = 6;
            this.btn_cancelar.BorderSize = 2;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.Red;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(23, 132);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(238, 34);
            this.btn_cancelar.TabIndex = 46;
            this.btn_cancelar.Text = "CANCELAR EDICION";
            this.btn_cancelar.TextColor = System.Drawing.Color.Red;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_edicion
            // 
            this.lbl_edicion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_edicion.AutoSize = true;
            this.lbl_edicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_edicion.ForeColor = System.Drawing.Color.Gold;
            this.lbl_edicion.Location = new System.Drawing.Point(90, 13);
            this.lbl_edicion.Name = "lbl_edicion";
            this.lbl_edicion.Size = new System.Drawing.Size(104, 25);
            this.lbl_edicion.TabIndex = 43;
            this.lbl_edicion.Text = "EDICION";
            // 
            // txt_descripcion_editar
            // 
            this.txt_descripcion_editar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_descripcion_editar.BackColor = System.Drawing.SystemColors.Window;
            this.txt_descripcion_editar.BorderColor = System.Drawing.Color.DarkOrange;
            this.txt_descripcion_editar.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_descripcion_editar.BorderRadius = 0;
            this.txt_descripcion_editar.BorderSize = 2;
            this.txt_descripcion_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion_editar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_descripcion_editar.Location = new System.Drawing.Point(10, 42);
            this.txt_descripcion_editar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_descripcion_editar.Multiline = false;
            this.txt_descripcion_editar.Name = "txt_descripcion_editar";
            this.txt_descripcion_editar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_descripcion_editar.PasswordChar = false;
            this.txt_descripcion_editar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_descripcion_editar.PlaceholderText = "";
            this.txt_descripcion_editar.Size = new System.Drawing.Size(264, 35);
            this.txt_descripcion_editar.TabIndex = 42;
            this.txt_descripcion_editar.Texts = "";
            this.txt_descripcion_editar.UnderlinedStyle = false;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_buscar.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_buscar.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.btn_buscar.BorderColor = System.Drawing.Color.ForestGreen;
            this.btn_buscar.BorderRadius = 6;
            this.btn_buscar.BorderSize = 2;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar.Location = new System.Drawing.Point(24, 357);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(236, 35);
            this.btn_buscar.TabIndex = 45;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.TextColor = System.Drawing.Color.ForestGreen;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Visible = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_actualizar.BackColor = System.Drawing.Color.Teal;
            this.btn_actualizar.BackgroundColor = System.Drawing.Color.Teal;
            this.btn_actualizar.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btn_actualizar.BorderRadius = 6;
            this.btn_actualizar.BorderSize = 2;
            this.btn_actualizar.FlatAppearance.BorderSize = 0;
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btn_actualizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_actualizar.Image")));
            this.btn_actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_actualizar.Location = new System.Drawing.Point(24, 313);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(236, 37);
            this.btn_actualizar.TabIndex = 13;
            this.btn_actualizar.Text = "Actualizar grilla";
            this.btn_actualizar.TextColor = System.Drawing.Color.PaleTurquoise;
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_crear_categoria
            // 
            this.btn_crear_categoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_crear_categoria.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_crear_categoria.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btn_crear_categoria.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn_crear_categoria.BorderRadius = 7;
            this.btn_crear_categoria.BorderSize = 2;
            this.btn_crear_categoria.FlatAppearance.BorderSize = 0;
            this.btn_crear_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crear_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crear_categoria.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_crear_categoria.Image = ((System.Drawing.Image)(resources.GetObject("btn_crear_categoria.Image")));
            this.btn_crear_categoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_crear_categoria.Location = new System.Drawing.Point(25, 267);
            this.btn_crear_categoria.Name = "btn_crear_categoria";
            this.btn_crear_categoria.Size = new System.Drawing.Size(234, 39);
            this.btn_crear_categoria.TabIndex = 27;
            this.btn_crear_categoria.Text = "   AGREGAR CATEGORIA";
            this.btn_crear_categoria.TextColor = System.Drawing.Color.MidnightBlue;
            this.btn_crear_categoria.UseVisualStyleBackColor = false;
            this.btn_crear_categoria.Click += new System.EventHandler(this.btn_crear_categoria_Click);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_descripcion.BackColor = System.Drawing.SystemColors.Window;
            this.txt_descripcion.BorderColor = System.Drawing.Color.DarkOrange;
            this.txt_descripcion.BorderFocusColor = System.Drawing.Color.Teal;
            this.txt_descripcion.BorderRadius = 0;
            this.txt_descripcion.BorderSize = 2;
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_descripcion.Location = new System.Drawing.Point(10, 224);
            this.txt_descripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_descripcion.Multiline = false;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_descripcion.PasswordChar = false;
            this.txt_descripcion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_descripcion.PlaceholderText = "";
            this.txt_descripcion.Size = new System.Drawing.Size(264, 35);
            this.txt_descripcion.TabIndex = 39;
            this.txt_descripcion.Texts = "";
            this.txt_descripcion.UnderlinedStyle = false;
            // 
            // lbl_crear
            // 
            this.lbl_crear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_crear.AutoSize = true;
            this.lbl_crear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_crear.ForeColor = System.Drawing.Color.Gold;
            this.lbl_crear.Location = new System.Drawing.Point(19, 199);
            this.lbl_crear.Name = "lbl_crear";
            this.lbl_crear.Size = new System.Drawing.Size(246, 20);
            this.lbl_crear.TabIndex = 44;
            this.lbl_crear.Text = "CREAR NUEVA CATEGORÍA";
            // 
            // btn_editar_categoria
            // 
            this.btn_editar_categoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_editar_categoria.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_editar_categoria.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.btn_editar_categoria.BorderColor = System.Drawing.Color.ForestGreen;
            this.btn_editar_categoria.BorderRadius = 6;
            this.btn_editar_categoria.BorderSize = 2;
            this.btn_editar_categoria.FlatAppearance.BorderSize = 0;
            this.btn_editar_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar_categoria.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_editar_categoria.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar_categoria.Image")));
            this.btn_editar_categoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editar_categoria.Location = new System.Drawing.Point(23, 87);
            this.btn_editar_categoria.Name = "btn_editar_categoria";
            this.btn_editar_categoria.Size = new System.Drawing.Size(238, 35);
            this.btn_editar_categoria.TabIndex = 41;
            this.btn_editar_categoria.Text = "EDITAR CATEGORÍA";
            this.btn_editar_categoria.TextColor = System.Drawing.Color.DarkGreen;
            this.btn_editar_categoria.UseVisualStyleBackColor = false;
            this.btn_editar_categoria.Click += new System.EventHandler(this.btn_editar_categoria_Click);
            // 
            // panel_filter
            // 
            this.panel_filter.BackColor = System.Drawing.Color.Firebrick;
            this.panel_filter.ColumnCount = 1;
            this.panel_filter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_filter.Controls.Add(this.lbl_search, 0, 0);
            this.panel_filter.Controls.Add(this.txt_search, 0, 1);
            this.panel_filter.Controls.Add(this.txt_id, 0, 2);
            this.panel_filter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_filter.Location = new System.Drawing.Point(5, 5);
            this.panel_filter.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.panel_filter.Name = "panel_filter";
            this.panel_filter.RowCount = 3;
            this.panel_filter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.7551F));
            this.panel_filter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.7551F));
            this.panel_filter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.7551F));
            this.panel_filter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.7551F));
            this.panel_filter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.7551F));
            this.panel_filter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.7551F));
            this.panel_filter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.7551F));
            this.panel_filter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.71429F));
            this.panel_filter.Size = new System.Drawing.Size(284, 98);
            this.panel_filter.TabIndex = 17;
            // 
            // lbl_search
            // 
            this.lbl_search.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_search.AutoSize = true;
            this.lbl_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search.ForeColor = System.Drawing.Color.Gold;
            this.lbl_search.Location = new System.Drawing.Point(73, 7);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(137, 25);
            this.lbl_search.TabIndex = 13;
            this.lbl_search.Text = "BUSQUEDA";
            // 
            // txt_search
            // 
            this.txt_search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(16, 35);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(251, 29);
            this.txt_search.TabIndex = 11;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.SystemColors.Window;
            this.txt_id.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_id.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_id.BorderRadius = 0;
            this.txt_id.BorderSize = 2;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_id.Location = new System.Drawing.Point(4, 68);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Multiline = false;
            this.txt_id.Name = "txt_id";
            this.txt_id.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_id.PasswordChar = false;
            this.txt_id.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_id.PlaceholderText = "";
            this.txt_id.Size = new System.Drawing.Size(32, 31);
            this.txt_id.TabIndex = 40;
            this.txt_id.Texts = "0";
            this.txt_id.UnderlinedStyle = false;
            this.txt_id.Visible = false;
            // 
            // dgv_categorias
            // 
            this.dgv_categorias.AllowUserToAddRows = false;
            this.dgv_categorias.AllowUserToDeleteRows = false;
            this.dgv_categorias.AllowUserToResizeColumns = false;
            this.dgv_categorias.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_categorias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_categorias.BackgroundColor = System.Drawing.Color.White;
            this.dgv_categorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_categorias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_categorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_categorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_categorias.ColumnHeadersHeight = 30;
            this.dgv_categorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descripcion,
            this.cantidad,
            this.btn_editar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_categorias.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_categorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_categorias.EnableHeadersVisualStyles = false;
            this.dgv_categorias.GridColor = System.Drawing.Color.LightSalmon;
            this.dgv_categorias.Location = new System.Drawing.Point(294, 5);
            this.dgv_categorias.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.dgv_categorias.MultiSelect = false;
            this.dgv_categorias.Name = "dgv_categorias";
            this.dgv_categorias.ReadOnly = true;
            this.dgv_categorias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_categorias.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_categorias.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_categorias.RowTemplate.Height = 35;
            this.dgv_categorias.RowTemplate.ReadOnly = true;
            this.dgv_categorias.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_categorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_categorias.Size = new System.Drawing.Size(683, 507);
            this.dgv_categorias.TabIndex = 17;
            this.dgv_categorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_categorias_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcion.FillWeight = 130F;
            this.descripcion.HeaderText = "CATEGORÍA";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cantidad.HeaderText = "CANT. ASOCIADA";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // btn_editar
            // 
            this.btn_editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btn_editar.HeaderText = "EDITAR";
            this.btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar.Image")));
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.ReadOnly = true;
            this.btn_editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // formCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 537);
            this.Controls.Add(this.panel_main);
            this.Name = "formCategorias";
            this.Text = "POSLyion";
            this.Load += new System.EventHandler(this.formCat_Load);
            this.menu_sesion.ResumeLayout(false);
            this.menu_Main.ResumeLayout(false);
            this.panel_main.ResumeLayout(false);
            this.panel_retoque.ResumeLayout(false);
            this.panel_bot.ResumeLayout(false);
            this.panel_bot.PerformLayout();
            this.panel_mid.ResumeLayout(false);
            this.panel_midizq.ResumeLayout(false);
            this.panel_btns.ResumeLayout(false);
            this.panel_btns.PerformLayout();
            this.panel_filter.ResumeLayout(false);
            this.panel_filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.TableLayoutPanel panel_retoque;
        private System.Windows.Forms.TableLayoutPanel panel_mid;
        private System.Windows.Forms.TableLayoutPanel panel_midizq;
        private System.Windows.Forms.TableLayoutPanel panel_btns;
        private RJCodeAdvance.RJControls.RJButton btn_crear_categoria;
        private CustomBox.RJControls.RJButton btn_actualizar;
        private System.Windows.Forms.TableLayoutPanel panel_filter;
        private System.Windows.Forms.Label lbl_crear;
        private System.Windows.Forms.Label lbl_edicion;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.TextBox txt_search;
        private CustomBox.RJControls.RJTextBox txt_descripcion;
        private CustomBox.RJControls.RJTextBox txt_descripcion_editar;
        private RJCodeAdvance.RJControls.RJButton btn_editar_categoria;
        private CustomBox.RJControls.RJTextBox txt_id;
        private System.Windows.Forms.DataGridView dgv_categorias;
        private System.Windows.Forms.TableLayoutPanel panel_bot;
        private System.Windows.Forms.Label lbl_updateversion;
        private System.Windows.Forms.Label lbl_updatetime;
        private RJCodeAdvance.RJControls.RJButton btn_buscar;
        private RJCodeAdvance.RJControls.RJButton btn_cancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewImageColumn btn_editar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}