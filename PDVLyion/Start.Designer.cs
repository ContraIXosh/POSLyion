using System;

namespace POSLyion
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.tlp_principal = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_navbar_principal = new System.Windows.Forms.TableLayoutPanel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.tsmenu_venta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenu_compras = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenu_prods = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenu_users = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenu_clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenu_proveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenu_reports = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenu_cat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenu_config = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlp_navbar_nombres = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_pos = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.panel_formularios = new System.Windows.Forms.Panel();
            this.tlp_principal.SuspendLayout();
            this.tlp_navbar_principal.SuspendLayout();
            this.menu.SuspendLayout();
            this.tlp_navbar_nombres.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_principal
            // 
            this.tlp_principal.ColumnCount = 1;
            this.tlp_principal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_principal.Controls.Add(this.tlp_navbar_principal, 0, 0);
            this.tlp_principal.Controls.Add(this.panel_formularios, 0, 1);
            this.tlp_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_principal.Location = new System.Drawing.Point(0, 0);
            this.tlp_principal.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_principal.Name = "tlp_principal";
            this.tlp_principal.RowCount = 2;
            this.tlp_principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlp_principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tlp_principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_principal.Size = new System.Drawing.Size(982, 611);
            this.tlp_principal.TabIndex = 25;
            // 
            // tlp_navbar_principal
            // 
            this.tlp_navbar_principal.ColumnCount = 1;
            this.tlp_navbar_principal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_navbar_principal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_navbar_principal.Controls.Add(this.menu, 0, 1);
            this.tlp_navbar_principal.Controls.Add(this.tlp_navbar_nombres, 0, 0);
            this.tlp_navbar_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_navbar_principal.Location = new System.Drawing.Point(0, 0);
            this.tlp_navbar_principal.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_navbar_principal.Name = "tlp_navbar_principal";
            this.tlp_navbar_principal.RowCount = 2;
            this.tlp_navbar_principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_navbar_principal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_navbar_principal.Size = new System.Drawing.Size(982, 91);
            this.tlp_navbar_principal.TabIndex = 0;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Gold;
            this.menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmenu_venta,
            this.tsmenu_clientes,
            this.tsmenu_prods,
            this.tsmenu_compras,
            this.tsmenu_users,
            this.tsmenu_proveedor,
            this.tsmenu_reports,
            this.tsmenu_cat,
            this.tsmenu_config,
            this.cerrarSesionToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 45);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(0);
            this.menu.Size = new System.Drawing.Size(982, 46);
            this.menu.TabIndex = 27;
            this.menu.Text = "menuStrip1";
            // 
            // tsmenu_venta
            // 
            this.tsmenu_venta.BackColor = System.Drawing.Color.Transparent;
            this.tsmenu_venta.Image = ((System.Drawing.Image)(resources.GetObject("tsmenu_venta.Image")));
            this.tsmenu_venta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmenu_venta.MergeIndex = 0;
            this.tsmenu_venta.Name = "tsmenu_venta";
            this.tsmenu_venta.Size = new System.Drawing.Size(76, 46);
            this.tsmenu_venta.Text = "Ventas (F1)";
            this.tsmenu_venta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmenu_compras
            // 
            this.tsmenu_compras.Image = ((System.Drawing.Image)(resources.GetObject("tsmenu_compras.Image")));
            this.tsmenu_compras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmenu_compras.MergeIndex = 1;
            this.tsmenu_compras.Name = "tsmenu_compras";
            this.tsmenu_compras.Size = new System.Drawing.Size(67, 46);
            this.tsmenu_compras.Text = "Compras";
            this.tsmenu_compras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmenu_prods
            // 
            this.tsmenu_prods.Image = ((System.Drawing.Image)(resources.GetObject("tsmenu_prods.Image")));
            this.tsmenu_prods.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmenu_prods.MergeIndex = 2;
            this.tsmenu_prods.Name = "tsmenu_prods";
            this.tsmenu_prods.Size = new System.Drawing.Size(96, 46);
            this.tsmenu_prods.Text = "Productos (F3)";
            this.tsmenu_prods.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmenu_users
            // 
            this.tsmenu_users.BackColor = System.Drawing.Color.Gold;
            this.tsmenu_users.Image = ((System.Drawing.Image)(resources.GetObject("tsmenu_users.Image")));
            this.tsmenu_users.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmenu_users.MergeIndex = 3;
            this.tsmenu_users.Name = "tsmenu_users";
            this.tsmenu_users.Size = new System.Drawing.Size(64, 46);
            this.tsmenu_users.Text = "Usuarios";
            this.tsmenu_users.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmenu_clientes
            // 
            this.tsmenu_clientes.Image = ((System.Drawing.Image)(resources.GetObject("tsmenu_clientes.Image")));
            this.tsmenu_clientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmenu_clientes.MergeIndex = 4;
            this.tsmenu_clientes.Name = "tsmenu_clientes";
            this.tsmenu_clientes.Size = new System.Drawing.Size(84, 46);
            this.tsmenu_clientes.Text = "Clientes (F2)";
            this.tsmenu_clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmenu_proveedor
            // 
            this.tsmenu_proveedor.Image = ((System.Drawing.Image)(resources.GetObject("tsmenu_proveedor.Image")));
            this.tsmenu_proveedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmenu_proveedor.MergeIndex = 5;
            this.tsmenu_proveedor.Name = "tsmenu_proveedor";
            this.tsmenu_proveedor.Size = new System.Drawing.Size(84, 46);
            this.tsmenu_proveedor.Text = "Proveedores";
            this.tsmenu_proveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmenu_reports
            // 
            this.tsmenu_reports.Image = ((System.Drawing.Image)(resources.GetObject("tsmenu_reports.Image")));
            this.tsmenu_reports.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmenu_reports.MergeIndex = 6;
            this.tsmenu_reports.Name = "tsmenu_reports";
            this.tsmenu_reports.Size = new System.Drawing.Size(65, 46);
            this.tsmenu_reports.Text = "Reportes";
            this.tsmenu_reports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmenu_cat
            // 
            this.tsmenu_cat.Image = ((System.Drawing.Image)(resources.GetObject("tsmenu_cat.Image")));
            this.tsmenu_cat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmenu_cat.MergeIndex = 7;
            this.tsmenu_cat.Name = "tsmenu_cat";
            this.tsmenu_cat.Size = new System.Drawing.Size(75, 46);
            this.tsmenu_cat.Text = "Categorias";
            this.tsmenu_cat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmenu_config
            // 
            this.tsmenu_config.Image = ((System.Drawing.Image)(resources.GetObject("tsmenu_config.Image")));
            this.tsmenu_config.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmenu_config.MergeIndex = 8;
            this.tsmenu_config.Name = "tsmenu_config";
            this.tsmenu_config.Size = new System.Drawing.Size(95, 46);
            this.tsmenu_config.Text = "Configuración";
            this.tsmenu_config.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cerrarSesionToolStripMenuItem.Image")));
            this.cerrarSesionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cerrarSesionToolStripMenuItem.MergeIndex = 9;
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(87, 46);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            this.cerrarSesionToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tlp_navbar_nombres
            // 
            this.tlp_navbar_nombres.ColumnCount = 2;
            this.tlp_navbar_nombres.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_navbar_nombres.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_navbar_nombres.Controls.Add(this.lbl_pos, 0, 0);
            this.tlp_navbar_nombres.Controls.Add(this.lbl_usuario, 1, 0);
            this.tlp_navbar_nombres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_navbar_nombres.Location = new System.Drawing.Point(0, 0);
            this.tlp_navbar_nombres.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_navbar_nombres.Name = "tlp_navbar_nombres";
            this.tlp_navbar_nombres.RowCount = 1;
            this.tlp_navbar_nombres.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_navbar_nombres.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_navbar_nombres.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlp_navbar_nombres.Size = new System.Drawing.Size(982, 45);
            this.tlp_navbar_nombres.TabIndex = 0;
            // 
            // lbl_pos
            // 
            this.lbl_pos.AutoSize = true;
            this.lbl_pos.BackColor = System.Drawing.Color.Crimson;
            this.lbl_pos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_pos.Enabled = false;
            this.lbl_pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pos.Location = new System.Drawing.Point(0, 0);
            this.lbl_pos.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_pos.Name = "lbl_pos";
            this.lbl_pos.Size = new System.Drawing.Size(491, 45);
            this.lbl_pos.TabIndex = 25;
            this.lbl_pos.Text = "POSLyion";
            this.lbl_pos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.BackColor = System.Drawing.Color.Crimson;
            this.lbl_usuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_usuario.Enabled = false;
            this.lbl_usuario.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(491, 0);
            this.lbl_usuario.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(491, 45);
            this.lbl_usuario.TabIndex = 27;
            this.lbl_usuario.Text = "Usuario1";
            this.lbl_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel_formularios
            // 
            this.panel_formularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_formularios.Location = new System.Drawing.Point(0, 91);
            this.panel_formularios.Margin = new System.Windows.Forms.Padding(0);
            this.panel_formularios.Name = "panel_formularios";
            this.panel_formularios.Size = new System.Drawing.Size(982, 520);
            this.panel_formularios.TabIndex = 1;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 611);
            this.Controls.Add(this.tlp_principal);
            this.Name = "Start";
            this.Text = "POSLyion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Start_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Start_KeyDown);
            this.tlp_principal.ResumeLayout(false);
            this.tlp_navbar_principal.ResumeLayout(false);
            this.tlp_navbar_principal.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tlp_navbar_nombres.ResumeLayout(false);
            this.tlp_navbar_nombres.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlp_principal;
        private System.Windows.Forms.TableLayoutPanel tlp_navbar_principal;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem tsmenu_venta;
        private System.Windows.Forms.ToolStripMenuItem tsmenu_compras;
        private System.Windows.Forms.ToolStripMenuItem tsmenu_prods;
        private System.Windows.Forms.ToolStripMenuItem tsmenu_users;
        private System.Windows.Forms.ToolStripMenuItem tsmenu_clientes;
        private System.Windows.Forms.ToolStripMenuItem tsmenu_proveedor;
        private System.Windows.Forms.ToolStripMenuItem tsmenu_reports;
        private System.Windows.Forms.ToolStripMenuItem tsmenu_cat;
        private System.Windows.Forms.ToolStripMenuItem tsmenu_config;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tlp_navbar_nombres;
        private System.Windows.Forms.Label lbl_pos;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Panel panel_formularios;
    }
}