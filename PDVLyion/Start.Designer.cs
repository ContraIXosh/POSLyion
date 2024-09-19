namespace PDCLyion
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
            this.container = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.iconmenuitem_sales = new FontAwesome.Sharp.IconMenuItem();
            this.iconmenuitem_purchaseorders = new FontAwesome.Sharp.IconMenuItem();
            this.iconmenuitem_products = new FontAwesome.Sharp.IconMenuItem();
            this.iconmenuitem_users = new FontAwesome.Sharp.IconMenuItem();
            this.iconmenuitem_customers = new FontAwesome.Sharp.IconMenuItem();
            this.iconmenuitem_vendors = new FontAwesome.Sharp.IconMenuItem();
            this.iconmenuitem_statistics = new FontAwesome.Sharp.IconMenuItem();
            this.iconmenuitem_config = new FontAwesome.Sharp.IconMenuItem();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_POS = new System.Windows.Forms.Label();
            this.rjButton1 = new ClassLibrary1.RJButton();
            this.container.SuspendLayout();
            this.menu.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.container.Controls.Add(this.rjButton1);
            this.container.Controls.Add(this.menu);
            this.container.Controls.Add(this.panel5);
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(983, 538);
            this.container.TabIndex = 3;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Gold;
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconmenuitem_sales,
            this.iconmenuitem_purchaseorders,
            this.iconmenuitem_products,
            this.iconmenuitem_users,
            this.iconmenuitem_customers,
            this.iconmenuitem_vendors,
            this.iconmenuitem_statistics,
            this.iconmenuitem_config});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menu.Size = new System.Drawing.Size(131, 538);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // iconmenuitem_sales
            // 
            this.iconmenuitem_sales.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.iconmenuitem_sales.IconColor = System.Drawing.Color.Black;
            this.iconmenuitem_sales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconmenuitem_sales.IconSize = 30;
            this.iconmenuitem_sales.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconmenuitem_sales.Name = "iconmenuitem_sales";
            this.iconmenuitem_sales.Size = new System.Drawing.Size(118, 34);
            this.iconmenuitem_sales.Text = "Ventas";
            this.iconmenuitem_sales.Click += new System.EventHandler(this.iconmenuitem_sales_Click);
            // 
            // iconmenuitem_purchaseorders
            // 
            this.iconmenuitem_purchaseorders.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.iconmenuitem_purchaseorders.IconColor = System.Drawing.Color.Black;
            this.iconmenuitem_purchaseorders.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconmenuitem_purchaseorders.IconSize = 30;
            this.iconmenuitem_purchaseorders.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconmenuitem_purchaseorders.Name = "iconmenuitem_purchaseorders";
            this.iconmenuitem_purchaseorders.Size = new System.Drawing.Size(118, 34);
            this.iconmenuitem_purchaseorders.Text = "Compras";
            this.iconmenuitem_purchaseorders.Click += new System.EventHandler(this.iconmenuitem_purchaseorders_Click);
            // 
            // iconmenuitem_products
            // 
            this.iconmenuitem_products.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.iconmenuitem_products.IconColor = System.Drawing.Color.Black;
            this.iconmenuitem_products.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconmenuitem_products.IconSize = 30;
            this.iconmenuitem_products.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconmenuitem_products.Name = "iconmenuitem_products";
            this.iconmenuitem_products.Size = new System.Drawing.Size(118, 34);
            this.iconmenuitem_products.Text = "Productos";
            this.iconmenuitem_products.Click += new System.EventHandler(this.iconmenuitem_products_Click);
            // 
            // iconmenuitem_users
            // 
            this.iconmenuitem_users.IconChar = FontAwesome.Sharp.IconChar.UsersGear;
            this.iconmenuitem_users.IconColor = System.Drawing.Color.Black;
            this.iconmenuitem_users.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconmenuitem_users.IconSize = 30;
            this.iconmenuitem_users.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconmenuitem_users.Name = "iconmenuitem_users";
            this.iconmenuitem_users.Size = new System.Drawing.Size(118, 34);
            this.iconmenuitem_users.Text = "Usuarios";
            this.iconmenuitem_users.Click += new System.EventHandler(this.iconmenuitem_users_Click);
            // 
            // iconmenuitem_customers
            // 
            this.iconmenuitem_customers.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.iconmenuitem_customers.IconColor = System.Drawing.Color.Black;
            this.iconmenuitem_customers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconmenuitem_customers.IconSize = 30;
            this.iconmenuitem_customers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconmenuitem_customers.Name = "iconmenuitem_customers";
            this.iconmenuitem_customers.Size = new System.Drawing.Size(118, 34);
            this.iconmenuitem_customers.Text = "Clientes";
            this.iconmenuitem_customers.Click += new System.EventHandler(this.iconmenuitem_customers_Click);
            // 
            // iconmenuitem_vendors
            // 
            this.iconmenuitem_vendors.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.iconmenuitem_vendors.IconColor = System.Drawing.Color.Black;
            this.iconmenuitem_vendors.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconmenuitem_vendors.IconSize = 30;
            this.iconmenuitem_vendors.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconmenuitem_vendors.Name = "iconmenuitem_vendors";
            this.iconmenuitem_vendors.Size = new System.Drawing.Size(118, 34);
            this.iconmenuitem_vendors.Text = "Proveedores";
            this.iconmenuitem_vendors.Click += new System.EventHandler(this.iconmenuitem_vendors_Click);
            // 
            // iconmenuitem_statistics
            // 
            this.iconmenuitem_statistics.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.iconmenuitem_statistics.IconColor = System.Drawing.Color.Black;
            this.iconmenuitem_statistics.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconmenuitem_statistics.IconSize = 30;
            this.iconmenuitem_statistics.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconmenuitem_statistics.Name = "iconmenuitem_statistics";
            this.iconmenuitem_statistics.Size = new System.Drawing.Size(118, 34);
            this.iconmenuitem_statistics.Text = "Reportes";
            this.iconmenuitem_statistics.Click += new System.EventHandler(this.iconmenuitem_statistics_Click);
            // 
            // iconmenuitem_config
            // 
            this.iconmenuitem_config.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.iconmenuitem_config.IconColor = System.Drawing.Color.Black;
            this.iconmenuitem_config.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconmenuitem_config.IconSize = 30;
            this.iconmenuitem_config.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconmenuitem_config.Name = "iconmenuitem_config";
            this.iconmenuitem_config.Size = new System.Drawing.Size(118, 34);
            this.iconmenuitem_config.Text = "Configuración";
            this.iconmenuitem_config.Click += new System.EventHandler(this.iconmenuitem_config_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(226)))), ((int)(((byte)(4)))));
            this.panel5.Controls.Add(this.lbl_usuario);
            this.panel5.Controls.Add(this.lbl_POS);
            this.panel5.Location = new System.Drawing.Point(126, -1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(855, 67);
            this.panel5.TabIndex = 2;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(739, 21);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(105, 20);
            this.lbl_usuario.TabIndex = 1;
            this.lbl_usuario.Text = "PERSONAL1";
            // 
            // lbl_POS
            // 
            this.lbl_POS.AutoSize = true;
            this.lbl_POS.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_POS.Location = new System.Drawing.Point(67, 6);
            this.lbl_POS.Name = "lbl_POS";
            this.lbl_POS.Size = new System.Drawing.Size(248, 55);
            this.lbl_POS.TabIndex = 0;
            this.lbl_POS.Text = "POSLyion";
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 10;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Image = ((System.Drawing.Image)(resources.GetObject("rjButton1.Image")));
            this.rjButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton1.Location = new System.Drawing.Point(393, 221);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(265, 56);
            this.rjButton1.TabIndex = 3;
            this.rjButton1.Text = "rjButton1";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 537);
            this.Controls.Add(this.container);
            this.MainMenuStrip = this.menu;
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Punto de Venta - Lyion";
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem iconmenuitem_sales;
        private FontAwesome.Sharp.IconMenuItem iconmenuitem_purchaseorders;
        private FontAwesome.Sharp.IconMenuItem iconmenuitem_products;
        private FontAwesome.Sharp.IconMenuItem iconmenuitem_users;
        private FontAwesome.Sharp.IconMenuItem iconmenuitem_customers;
        private FontAwesome.Sharp.IconMenuItem iconmenuitem_vendors;
        private FontAwesome.Sharp.IconMenuItem iconmenuitem_statistics;
        private FontAwesome.Sharp.IconMenuItem iconmenuitem_config;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_POS;
        private ClassLibrary1.RJButton rjButton1;
    }
}

