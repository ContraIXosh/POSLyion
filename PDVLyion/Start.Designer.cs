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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.titlemenu = new System.Windows.Forms.MenuStrip();
            this.lbltitle = new System.Windows.Forms.Label();
            this.container = new System.Windows.Forms.Panel();
            this.iconmenuitem_sales = new FontAwesome.Sharp.IconMenuItem();
            this.iconmenuitem_purchaseorders = new FontAwesome.Sharp.IconMenuItem();
            this.iconmenuitem_products = new FontAwesome.Sharp.IconMenuItem();
            this.iconmenuitem_users = new FontAwesome.Sharp.IconMenuItem();
            this.iconmenuitem_customers = new FontAwesome.Sharp.IconMenuItem();
            this.iconmenuitem_vendors = new FontAwesome.Sharp.IconMenuItem();
            this.iconmenuitem_statistics = new FontAwesome.Sharp.IconMenuItem();
            this.iconmenuitem_config = new FontAwesome.Sharp.IconMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconmenuitem_sales,
            this.iconmenuitem_purchaseorders,
            this.iconmenuitem_products,
            this.iconmenuitem_users,
            this.iconmenuitem_customers,
            this.iconmenuitem_vendors,
            this.iconmenuitem_statistics,
            this.iconmenuitem_config});
            this.menu.Location = new System.Drawing.Point(0, 48);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(853, 38);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // titlemenu
            // 
            this.titlemenu.AutoSize = false;
            this.titlemenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(170)))), ((int)(((byte)(219)))));
            this.titlemenu.Location = new System.Drawing.Point(0, 0);
            this.titlemenu.Name = "titlemenu";
            this.titlemenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.titlemenu.Size = new System.Drawing.Size(853, 48);
            this.titlemenu.TabIndex = 1;
            this.titlemenu.Text = "menuStrip2";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(170)))), ((int)(((byte)(219)))));
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(12, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(200, 31);
            this.lbltitle.TabIndex = 2;
            this.lbltitle.Text = "Punto de Venta";
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 86);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(853, 452);
            this.container.TabIndex = 3;
            // 
            // iconmenuitem_sales
            // 
            this.iconmenuitem_sales.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.iconmenuitem_sales.IconColor = System.Drawing.Color.Black;
            this.iconmenuitem_sales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconmenuitem_sales.IconSize = 30;
            this.iconmenuitem_sales.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconmenuitem_sales.Name = "iconmenuitem_sales";
            this.iconmenuitem_sales.Size = new System.Drawing.Size(83, 34);
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
            this.iconmenuitem_purchaseorders.Size = new System.Drawing.Size(97, 34);
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
            this.iconmenuitem_products.Size = new System.Drawing.Size(103, 34);
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
            this.iconmenuitem_users.Size = new System.Drawing.Size(94, 34);
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
            this.iconmenuitem_customers.Size = new System.Drawing.Size(91, 34);
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
            this.iconmenuitem_vendors.Size = new System.Drawing.Size(114, 34);
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
            this.iconmenuitem_statistics.Size = new System.Drawing.Size(95, 34);
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
            this.iconmenuitem_config.Size = new System.Drawing.Size(125, 34);
            this.iconmenuitem_config.Text = "Configuración";
            this.iconmenuitem_config.Click += new System.EventHandler(this.iconmenuitem_config_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 538);
            this.Controls.Add(this.container);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.titlemenu);
            this.MainMenuStrip = this.menu;
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Punto de Venta - Lyion";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip titlemenu;
        private FontAwesome.Sharp.IconMenuItem iconmenuitem_config;
        private System.Windows.Forms.Label lbltitle;
        private FontAwesome.Sharp.IconMenuItem iconmenuitem_sales;
        private FontAwesome.Sharp.IconMenuItem iconmenuitem_purchaseorders;
        private FontAwesome.Sharp.IconMenuItem iconmenuitem_products;
        private FontAwesome.Sharp.IconMenuItem iconmenuitem_customers;
        private FontAwesome.Sharp.IconMenuItem iconmenuitem_vendors;
        private FontAwesome.Sharp.IconMenuItem iconmenuitem_statistics;
        private System.Windows.Forms.Panel container;
        private FontAwesome.Sharp.IconMenuItem iconmenuitem_users;
    }
}

