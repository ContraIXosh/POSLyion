namespace POSLyion
{
    partial class formConfiguracion
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
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_general = new System.Windows.Forms.TableLayoutPanel();
            this.panel_bot = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_updateversion = new System.Windows.Forms.Label();
            this.lbl_updatetime = new System.Windows.Forms.Label();
            this.panel_main2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_izq = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel_mid = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btb_backup_bd = new CustomBox.RJControls.RJButton();
            this.lbl_bdd = new System.Windows.Forms.Label();
            this.btn_restaurar_bd = new CustomBox.RJControls.RJButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_cerrar = new RJCodeAdvance.RJControls.RJButton();
            this.panel_info = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_informe = new System.Windows.Forms.Label();
            this.lbl_fecha_vencimiento = new System.Windows.Forms.Label();
            this.btn_añadir = new CustomBox.RJControls.RJButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_configuracion = new System.Windows.Forms.Label();
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
            this.panel_general.SuspendLayout();
            this.panel_bot.SuspendLayout();
            this.panel_main2.SuspendLayout();
            this.panel_izq.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel_mid.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel_info.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_main.Controls.Add(this.panel_general);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(561, 579);
            this.panel_main.TabIndex = 0;
            // 
            // panel_general
            // 
            this.panel_general.ColumnCount = 1;
            this.panel_general.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_general.Controls.Add(this.panel_bot, 0, 1);
            this.panel_general.Controls.Add(this.panel_main2, 0, 0);
            this.panel_general.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_general.Location = new System.Drawing.Point(0, 0);
            this.panel_general.Name = "panel_general";
            this.panel_general.RowCount = 2;
            this.panel_general.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_general.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_general.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_general.Size = new System.Drawing.Size(561, 579);
            this.panel_general.TabIndex = 2;
            // 
            // panel_bot
            // 
            this.panel_bot.BackColor = System.Drawing.Color.Black;
            this.panel_bot.ColumnCount = 3;
            this.panel_bot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_bot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.panel_bot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.panel_bot.Controls.Add(this.lbl_updateversion, 2, 0);
            this.panel_bot.Controls.Add(this.lbl_updatetime, 1, 0);
            this.panel_bot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_bot.Location = new System.Drawing.Point(0, 559);
            this.panel_bot.Margin = new System.Windows.Forms.Padding(0);
            this.panel_bot.Name = "panel_bot";
            this.panel_bot.RowCount = 1;
            this.panel_bot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_bot.Size = new System.Drawing.Size(561, 20);
            this.panel_bot.TabIndex = 4;
            // 
            // lbl_updateversion
            // 
            this.lbl_updateversion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_updateversion.AutoSize = true;
            this.lbl_updateversion.BackColor = System.Drawing.Color.Black;
            this.lbl_updateversion.ForeColor = System.Drawing.Color.Gold;
            this.lbl_updateversion.Location = new System.Drawing.Point(364, 3);
            this.lbl_updateversion.Name = "lbl_updateversion";
            this.lbl_updateversion.Size = new System.Drawing.Size(115, 13);
            this.lbl_updateversion.TabIndex = 2;
            this.lbl_updateversion.Text = "Actualizacion: v1.0.0.5";
            // 
            // lbl_updatetime
            // 
            this.lbl_updatetime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_updatetime.AutoSize = true;
            this.lbl_updatetime.BackColor = System.Drawing.Color.Black;
            this.lbl_updatetime.ForeColor = System.Drawing.Color.Gold;
            this.lbl_updatetime.Location = new System.Drawing.Point(114, 3);
            this.lbl_updatetime.Name = "lbl_updatetime";
            this.lbl_updatetime.Size = new System.Drawing.Size(199, 13);
            this.lbl_updatetime.TabIndex = 3;
            this.lbl_updatetime.Text = "Ultimo chequeo: 10:06:12  - 20/09/2024";
            // 
            // panel_main2
            // 
            this.panel_main2.BackColor = System.Drawing.Color.Crimson;
            this.panel_main2.ColumnCount = 1;
            this.panel_main2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.94297F));
            this.panel_main2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.05703F));
            this.panel_main2.Controls.Add(this.panel_izq, 0, 0);
            this.panel_main2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main2.Location = new System.Drawing.Point(0, 0);
            this.panel_main2.Margin = new System.Windows.Forms.Padding(0);
            this.panel_main2.Name = "panel_main2";
            this.panel_main2.RowCount = 1;
            this.panel_main2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panel_main2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_main2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.panel_main2.Size = new System.Drawing.Size(561, 559);
            this.panel_main2.TabIndex = 3;
            // 
            // panel_izq
            // 
            this.panel_izq.BackColor = System.Drawing.Color.Crimson;
            this.panel_izq.ColumnCount = 1;
            this.panel_izq.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_izq.Controls.Add(this.panel6, 0, 1);
            this.panel_izq.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.panel_izq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_izq.Location = new System.Drawing.Point(0, 0);
            this.panel_izq.Margin = new System.Windows.Forms.Padding(0);
            this.panel_izq.Name = "panel_izq";
            this.panel_izq.RowCount = 2;
            this.panel_izq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.52942F));
            this.panel_izq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.47059F));
            this.panel_izq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_izq.Size = new System.Drawing.Size(561, 559);
            this.panel_izq.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.panel_mid);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 131);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(555, 425);
            this.panel6.TabIndex = 3;
            // 
            // panel_mid
            // 
            this.panel_mid.BackColor = System.Drawing.Color.Crimson;
            this.panel_mid.ColumnCount = 1;
            this.panel_mid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_mid.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.panel_mid.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.panel_mid.Controls.Add(this.panel_info, 0, 1);
            this.panel_mid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_mid.Location = new System.Drawing.Point(0, 0);
            this.panel_mid.Margin = new System.Windows.Forms.Padding(0);
            this.panel_mid.Name = "panel_mid";
            this.panel_mid.RowCount = 3;
            this.panel_mid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.46154F));
            this.panel_mid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.15385F));
            this.panel_mid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.panel_mid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_mid.Size = new System.Drawing.Size(555, 425);
            this.panel_mid.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.btb_backup_bd, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.lbl_bdd, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btn_restaurar_bd, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(555, 160);
            this.tableLayoutPanel5.TabIndex = 82;
            // 
            // btb_backup_bd
            // 
            this.btb_backup_bd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btb_backup_bd.BackColor = System.Drawing.Color.Transparent;
            this.btb_backup_bd.BackgroundColor = System.Drawing.Color.Transparent;
            this.btb_backup_bd.BorderColor = System.Drawing.Color.SpringGreen;
            this.btb_backup_bd.BorderRadius = 3;
            this.btb_backup_bd.BorderSize = 2;
            this.btb_backup_bd.FlatAppearance.BorderSize = 0;
            this.btb_backup_bd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btb_backup_bd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btb_backup_bd.ForeColor = System.Drawing.Color.SpringGreen;
            this.btb_backup_bd.Location = new System.Drawing.Point(93, 113);
            this.btb_backup_bd.Name = "btb_backup_bd";
            this.btb_backup_bd.Size = new System.Drawing.Size(181, 40);
            this.btb_backup_bd.TabIndex = 78;
            this.btb_backup_bd.Text = "Backup BD";
            this.btb_backup_bd.TextColor = System.Drawing.Color.SpringGreen;
            this.btb_backup_bd.UseVisualStyleBackColor = false;
            this.btb_backup_bd.Click += new System.EventHandler(this.btb_exportar_bd_Click);
            // 
            // lbl_bdd
            // 
            this.lbl_bdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_bdd.AutoSize = true;
            this.lbl_bdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bdd.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_bdd.Location = new System.Drawing.Point(48, 12);
            this.lbl_bdd.Name = "lbl_bdd";
            this.lbl_bdd.Size = new System.Drawing.Size(180, 29);
            this.lbl_bdd.TabIndex = 77;
            this.lbl_bdd.Text = "Base de datos";
            // 
            // btn_restaurar_bd
            // 
            this.btn_restaurar_bd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_restaurar_bd.BackColor = System.Drawing.Color.Transparent;
            this.btn_restaurar_bd.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_restaurar_bd.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_restaurar_bd.BorderRadius = 3;
            this.btn_restaurar_bd.BorderSize = 2;
            this.btn_restaurar_bd.FlatAppearance.BorderSize = 0;
            this.btn_restaurar_bd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_restaurar_bd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restaurar_bd.ForeColor = System.Drawing.Color.LightCyan;
            this.btn_restaurar_bd.Location = new System.Drawing.Point(93, 59);
            this.btn_restaurar_bd.Name = "btn_restaurar_bd";
            this.btn_restaurar_bd.Size = new System.Drawing.Size(181, 40);
            this.btn_restaurar_bd.TabIndex = 79;
            this.btn_restaurar_bd.Text = "Restaurar BD";
            this.btn_restaurar_bd.TextColor = System.Drawing.Color.LightCyan;
            this.btn_restaurar_bd.UseVisualStyleBackColor = false;
            this.btn_restaurar_bd.Click += new System.EventHandler(this.btn_restaurar_bd_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btn_cerrar, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 359);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(549, 66);
            this.tableLayoutPanel2.TabIndex = 81;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_cerrar.BorderColor = System.Drawing.Color.Red;
            this.btn_cerrar.BorderRadius = 7;
            this.btn_cerrar.BorderSize = 2;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.Red;
            this.btn_cerrar.Location = new System.Drawing.Point(396, 13);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(150, 40);
            this.btn_cerrar.TabIndex = 12;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.TextColor = System.Drawing.Color.Red;
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // panel_info
            // 
            this.panel_info.BackColor = System.Drawing.Color.Black;
            this.panel_info.ColumnCount = 2;
            this.panel_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.panel_info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.panel_info.Controls.Add(this.label2, 0, 0);
            this.panel_info.Controls.Add(this.lbl_informe, 0, 1);
            this.panel_info.Controls.Add(this.lbl_fecha_vencimiento, 0, 2);
            this.panel_info.Controls.Add(this.btn_añadir, 1, 2);
            this.panel_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_info.Location = new System.Drawing.Point(0, 163);
            this.panel_info.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel_info.Name = "panel_info";
            this.panel_info.RowCount = 3;
            this.panel_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panel_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panel_info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panel_info.Size = new System.Drawing.Size(555, 193);
            this.panel_info.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vinculación de cuenta";
            // 
            // lbl_informe
            // 
            this.lbl_informe.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_informe.AutoSize = true;
            this.lbl_informe.ForeColor = System.Drawing.Color.White;
            this.lbl_informe.Location = new System.Drawing.Point(3, 89);
            this.lbl_informe.Name = "lbl_informe";
            this.lbl_informe.Size = new System.Drawing.Size(207, 13);
            this.lbl_informe.TabIndex = 1;
            this.lbl_informe.Text = "nombredueño-nombreempresa-nrosucursal";
            this.lbl_informe.Visible = false;
            // 
            // lbl_fecha_vencimiento
            // 
            this.lbl_fecha_vencimiento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_fecha_vencimiento.AutoSize = true;
            this.lbl_fecha_vencimiento.ForeColor = System.Drawing.Color.White;
            this.lbl_fecha_vencimiento.Location = new System.Drawing.Point(3, 154);
            this.lbl_fecha_vencimiento.Name = "lbl_fecha_vencimiento";
            this.lbl_fecha_vencimiento.Size = new System.Drawing.Size(151, 13);
            this.lbl_fecha_vencimiento.TabIndex = 3;
            this.lbl_fecha_vencimiento.Text = "fecha de vencimiento de pago";
            this.lbl_fecha_vencimiento.Visible = false;
            // 
            // btn_añadir
            // 
            this.btn_añadir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_añadir.BackColor = System.Drawing.Color.Gold;
            this.btn_añadir.BackgroundColor = System.Drawing.Color.Gold;
            this.btn_añadir.BorderColor = System.Drawing.Color.Red;
            this.btn_añadir.BorderRadius = 9;
            this.btn_añadir.BorderSize = 0;
            this.btn_añadir.FlatAppearance.BorderSize = 0;
            this.btn_añadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_añadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_añadir.ForeColor = System.Drawing.Color.Black;
            this.btn_añadir.Location = new System.Drawing.Point(369, 131);
            this.btn_añadir.Name = "btn_añadir";
            this.btn_añadir.Size = new System.Drawing.Size(150, 31);
            this.btn_añadir.TabIndex = 4;
            this.btn_añadir.Text = "Añadir cuenta";
            this.btn_añadir.TextColor = System.Drawing.Color.Black;
            this.btn_añadir.UseVisualStyleBackColor = false;
            this.btn_añadir.Click += new System.EventHandler(this.btn_añadir_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_configuracion, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(555, 125);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // lbl_configuracion
            // 
            this.lbl_configuracion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_configuracion.AutoSize = true;
            this.lbl_configuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_configuracion.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_configuracion.Location = new System.Drawing.Point(145, 41);
            this.lbl_configuracion.Name = "lbl_configuracion";
            this.lbl_configuracion.Size = new System.Drawing.Size(262, 42);
            this.lbl_configuracion.TabIndex = 2;
            this.lbl_configuracion.Text = "Configuración";
            // 
            // menu_sesion
            // 
            this.menu_sesion.IsMainMenu = false;
            this.menu_sesion.MenuItemHeight = 25;
            this.menu_sesion.MenuItemTextColor = System.Drawing.Color.Empty;
            this.menu_sesion.Name = "menu_sesion";
            this.menu_sesion.PrimaryColor = System.Drawing.Color.Empty;
            this.menu_sesion.Size = new System.Drawing.Size(61, 4);
            // 
            // verPerfilToolStripMenuItem
            // 
            this.verPerfilToolStripMenuItem.Name = "verPerfilToolStripMenuItem";
            this.verPerfilToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.verPerfilToolStripMenuItem.Text = "Ver perfil";
            // 
            // inicioAdministradorToolStripMenuItem
            // 
            this.inicioAdministradorToolStripMenuItem.Name = "inicioAdministradorToolStripMenuItem";
            this.inicioAdministradorToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            // 
            // menu_Main
            // 
            this.menu_Main.IsMainMenu = false;
            this.menu_Main.MenuItemHeight = 25;
            this.menu_Main.MenuItemTextColor = System.Drawing.Color.Empty;
            this.menu_Main.Name = "menu_Main";
            this.menu_Main.PrimaryColor = System.Drawing.Color.Empty;
            this.menu_Main.Size = new System.Drawing.Size(61, 4);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // formConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 579);
            this.Controls.Add(this.panel_main);
            this.Name = "formConfiguracion";
            this.Text = "formConfig";
            this.panel_main.ResumeLayout(false);
            this.panel_general.ResumeLayout(false);
            this.panel_bot.ResumeLayout(false);
            this.panel_bot.PerformLayout();
            this.panel_main2.ResumeLayout(false);
            this.panel_izq.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel_mid.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel_info.ResumeLayout(false);
            this.panel_info.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.TableLayoutPanel panel_general;
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
        private System.Windows.Forms.TableLayoutPanel panel_main2;
        private System.Windows.Forms.TableLayoutPanel panel_izq;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TableLayoutPanel panel_bot;
        private System.Windows.Forms.Label lbl_updateversion;
        private System.Windows.Forms.Label lbl_updatetime;
        private System.Windows.Forms.TableLayoutPanel panel_mid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_configuracion;
        private System.Windows.Forms.TableLayoutPanel panel_info;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_informe;
        private System.Windows.Forms.Label lbl_fecha_vencimiento;
        private CustomBox.RJControls.RJButton btn_añadir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private CustomBox.RJControls.RJButton btb_backup_bd;
        private System.Windows.Forms.Label lbl_bdd;
        private CustomBox.RJControls.RJButton btn_restaurar_bd;
        private RJCodeAdvance.RJControls.RJButton btn_cerrar;
    }
}