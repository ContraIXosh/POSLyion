namespace POSLyion
{
    partial class formPermisos
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
            this.panel_main = new System.Windows.Forms.Panel();
            this.combo_rol = new System.Windows.Forms.Panel();
            this.materialCheckedListBox = new MaterialSkin.Controls.MaterialCheckedListBox();
            this.configToolStripMenuItem = new MaterialSkin.Controls.MaterialCheckbox();
            this.clientesToolStripMenuItem = new MaterialSkin.Controls.MaterialCheckbox();
            this.proveedoresToolStripMenuItem = new MaterialSkin.Controls.MaterialCheckbox();
            this.usuariosToolStripMenuItem = new MaterialSkin.Controls.MaterialCheckbox();
            this.reportesToolStripMenuItem = new MaterialSkin.Controls.MaterialCheckbox();
            this.ventasToolStripMenuItem = new MaterialSkin.Controls.MaterialCheckbox();
            this.comprasToolStripMenuItem = new MaterialSkin.Controls.MaterialCheckbox();
            this.productosToolStripMenuItem = new MaterialSkin.Controls.MaterialCheckbox();
            this.btn_editar_permisos = new CustomBox.RJControls.RJButton();
            this.btn_deshacer = new CustomBox.RJControls.RJButton();
            this.txt_id = new RJCodeAdvance.RJControls.RJTextBox();
            this.btn_guardar = new CustomBox.RJControls.RJButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productosToolStripMenu = new MaterialSkin.Controls.MaterialCheckbox();
            this.comprasToolStripMenu = new MaterialSkin.Controls.MaterialCheckbox();
            this.ventasToolStripMenu = new MaterialSkin.Controls.MaterialCheckbox();
            this.reportesToolStripMenu = new MaterialSkin.Controls.MaterialCheckbox();
            this.usuariosToolStripMenu = new MaterialSkin.Controls.MaterialCheckbox();
            this.proveedoresToolStripMenu = new MaterialSkin.Controls.MaterialCheckbox();
            this.clientesToolStripMenu = new MaterialSkin.Controls.MaterialCheckbox();
            this.configToolStripMenu = new MaterialSkin.Controls.MaterialCheckbox();
            this.panel_main.SuspendLayout();
            this.combo_rol.SuspendLayout();
            this.materialCheckedListBox.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.AutoSize = true;
            this.panel_main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_main.Controls.Add(this.combo_rol);
            this.panel_main.Controls.Add(this.panel3);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(999, 494);
            this.panel_main.TabIndex = 3;
            // 
            // combo_rol
            // 
            this.combo_rol.BackColor = System.Drawing.Color.DarkRed;
            this.combo_rol.Controls.Add(this.materialCheckedListBox);
            this.combo_rol.Controls.Add(this.btn_editar_permisos);
            this.combo_rol.Controls.Add(this.btn_deshacer);
            this.combo_rol.Controls.Add(this.txt_id);
            this.combo_rol.Controls.Add(this.btn_guardar);
            this.combo_rol.Location = new System.Drawing.Point(258, 15);
            this.combo_rol.Name = "combo_rol";
            this.combo_rol.Size = new System.Drawing.Size(695, 377);
            this.combo_rol.TabIndex = 10;
            // 
            // materialCheckedListBox
            // 
            this.materialCheckedListBox.AutoScroll = true;
            this.materialCheckedListBox.BackColor = System.Drawing.Color.DarkRed;
            this.materialCheckedListBox.Controls.Add(this.configToolStripMenuItem);
            this.materialCheckedListBox.Controls.Add(this.clientesToolStripMenuItem);
            this.materialCheckedListBox.Controls.Add(this.proveedoresToolStripMenuItem);
            this.materialCheckedListBox.Controls.Add(this.usuariosToolStripMenuItem);
            this.materialCheckedListBox.Controls.Add(this.reportesToolStripMenuItem);
            this.materialCheckedListBox.Controls.Add(this.ventasToolStripMenuItem);
            this.materialCheckedListBox.Controls.Add(this.comprasToolStripMenuItem);
            this.materialCheckedListBox.Controls.Add(this.productosToolStripMenuItem);
            this.materialCheckedListBox.Depth = 0;
            this.materialCheckedListBox.Location = new System.Drawing.Point(84, 71);
            this.materialCheckedListBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckedListBox.Name = "materialCheckedListBox";
            this.materialCheckedListBox.Size = new System.Drawing.Size(509, 185);
            this.materialCheckedListBox.Striped = false;
            this.materialCheckedListBox.StripeDarkColor = System.Drawing.Color.Empty;
            this.materialCheckedListBox.TabIndex = 39;
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.AutoSize = true;
            this.configToolStripMenuItem.Depth = 0;
            this.configToolStripMenuItem.Location = new System.Drawing.Point(322, 111);
            this.configToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0);
            this.configToolStripMenuItem.MouseLocation = new System.Drawing.Point(-1, -1);
            this.configToolStripMenuItem.MouseState = MaterialSkin.MouseState.HOVER;
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.ReadOnly = false;
            this.configToolStripMenuItem.Ripple = true;
            this.configToolStripMenuItem.Size = new System.Drawing.Size(151, 37);
            this.configToolStripMenuItem.TabIndex = 7;
            this.configToolStripMenuItem.Text = "Configuraciones";
            this.configToolStripMenuItem.UseVisualStyleBackColor = true;
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.AutoSize = true;
            this.clientesToolStripMenuItem.Depth = 0;
            this.clientesToolStripMenuItem.Location = new System.Drawing.Point(322, 74);
            this.clientesToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0);
            this.clientesToolStripMenuItem.MouseLocation = new System.Drawing.Point(-1, -1);
            this.clientesToolStripMenuItem.MouseState = MaterialSkin.MouseState.HOVER;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.ReadOnly = false;
            this.clientesToolStripMenuItem.Ripple = true;
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(170, 37);
            this.clientesToolStripMenuItem.TabIndex = 6;
            this.clientesToolStripMenuItem.Text = "Formulario clientes";
            this.clientesToolStripMenuItem.UseVisualStyleBackColor = true;
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.AutoSize = true;
            this.proveedoresToolStripMenuItem.Depth = 0;
            this.proveedoresToolStripMenuItem.Location = new System.Drawing.Point(322, 37);
            this.proveedoresToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0);
            this.proveedoresToolStripMenuItem.MouseLocation = new System.Drawing.Point(-1, -1);
            this.proveedoresToolStripMenuItem.MouseState = MaterialSkin.MouseState.HOVER;
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.ReadOnly = false;
            this.proveedoresToolStripMenuItem.Ripple = true;
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(202, 37);
            this.proveedoresToolStripMenuItem.TabIndex = 5;
            this.proveedoresToolStripMenuItem.Text = "Formulario proveedores";
            this.proveedoresToolStripMenuItem.UseVisualStyleBackColor = true;
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.AutoSize = true;
            this.usuariosToolStripMenuItem.Depth = 0;
            this.usuariosToolStripMenuItem.Location = new System.Drawing.Point(322, 0);
            this.usuariosToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0);
            this.usuariosToolStripMenuItem.MouseLocation = new System.Drawing.Point(-1, -1);
            this.usuariosToolStripMenuItem.MouseState = MaterialSkin.MouseState.HOVER;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.ReadOnly = false;
            this.usuariosToolStripMenuItem.Ripple = true;
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(177, 37);
            this.usuariosToolStripMenuItem.TabIndex = 4;
            this.usuariosToolStripMenuItem.Text = "Formulario usuarios";
            this.usuariosToolStripMenuItem.UseVisualStyleBackColor = true;
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.AutoSize = true;
            this.reportesToolStripMenuItem.Depth = 0;
            this.reportesToolStripMenuItem.Location = new System.Drawing.Point(0, 111);
            this.reportesToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0);
            this.reportesToolStripMenuItem.MouseLocation = new System.Drawing.Point(-1, -1);
            this.reportesToolStripMenuItem.MouseState = MaterialSkin.MouseState.HOVER;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.ReadOnly = false;
            this.reportesToolStripMenuItem.Ripple = true;
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(173, 37);
            this.reportesToolStripMenuItem.TabIndex = 3;
            this.reportesToolStripMenuItem.Text = "Formulario reportes";
            this.reportesToolStripMenuItem.UseVisualStyleBackColor = true;
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.AutoSize = true;
            this.ventasToolStripMenuItem.Depth = 0;
            this.ventasToolStripMenuItem.Location = new System.Drawing.Point(0, 74);
            this.ventasToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0);
            this.ventasToolStripMenuItem.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ventasToolStripMenuItem.MouseState = MaterialSkin.MouseState.HOVER;
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.ReadOnly = false;
            this.ventasToolStripMenuItem.Ripple = true;
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(163, 37);
            this.ventasToolStripMenuItem.TabIndex = 2;
            this.ventasToolStripMenuItem.Text = "Formulario ventas";
            this.ventasToolStripMenuItem.UseVisualStyleBackColor = true;
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.AutoSize = true;
            this.comprasToolStripMenuItem.Depth = 0;
            this.comprasToolStripMenuItem.Location = new System.Drawing.Point(0, 37);
            this.comprasToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0);
            this.comprasToolStripMenuItem.MouseLocation = new System.Drawing.Point(-1, -1);
            this.comprasToolStripMenuItem.MouseState = MaterialSkin.MouseState.HOVER;
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.ReadOnly = false;
            this.comprasToolStripMenuItem.Ripple = true;
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(178, 37);
            this.comprasToolStripMenuItem.TabIndex = 1;
            this.comprasToolStripMenuItem.Text = "Formulario compras";
            this.comprasToolStripMenuItem.UseVisualStyleBackColor = true;
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.AutoSize = true;
            this.productosToolStripMenuItem.Depth = 0;
            this.productosToolStripMenuItem.Location = new System.Drawing.Point(0, 0);
            this.productosToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0);
            this.productosToolStripMenuItem.MouseLocation = new System.Drawing.Point(-1, -1);
            this.productosToolStripMenuItem.MouseState = MaterialSkin.MouseState.HOVER;
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.ReadOnly = false;
            this.productosToolStripMenuItem.Ripple = true;
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(187, 37);
            this.productosToolStripMenuItem.TabIndex = 0;
            this.productosToolStripMenuItem.Text = "Formulario productos";
            this.productosToolStripMenuItem.UseVisualStyleBackColor = true;
            // 
            // btn_editar_permisos
            // 
            this.btn_editar_permisos.BackColor = System.Drawing.Color.Gold;
            this.btn_editar_permisos.BackgroundColor = System.Drawing.Color.Gold;
            this.btn_editar_permisos.BorderColor = System.Drawing.Color.Black;
            this.btn_editar_permisos.BorderRadius = 10;
            this.btn_editar_permisos.BorderSize = 2;
            this.btn_editar_permisos.FlatAppearance.BorderSize = 0;
            this.btn_editar_permisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar_permisos.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar_permisos.ForeColor = System.Drawing.Color.Black;
            this.btn_editar_permisos.Location = new System.Drawing.Point(453, 322);
            this.btn_editar_permisos.Name = "btn_editar_permisos";
            this.btn_editar_permisos.Size = new System.Drawing.Size(148, 52);
            this.btn_editar_permisos.TabIndex = 38;
            this.btn_editar_permisos.Text = "EDITAR PERMISOS";
            this.btn_editar_permisos.TextColor = System.Drawing.Color.Black;
            this.btn_editar_permisos.UseVisualStyleBackColor = false;
            // 
            // btn_deshacer
            // 
            this.btn_deshacer.BackColor = System.Drawing.Color.Gold;
            this.btn_deshacer.BackgroundColor = System.Drawing.Color.Gold;
            this.btn_deshacer.BorderColor = System.Drawing.Color.Black;
            this.btn_deshacer.BorderRadius = 10;
            this.btn_deshacer.BorderSize = 2;
            this.btn_deshacer.FlatAppearance.BorderSize = 0;
            this.btn_deshacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deshacer.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deshacer.ForeColor = System.Drawing.Color.Black;
            this.btn_deshacer.Location = new System.Drawing.Point(276, 322);
            this.btn_deshacer.Name = "btn_deshacer";
            this.btn_deshacer.Size = new System.Drawing.Size(148, 52);
            this.btn_deshacer.TabIndex = 37;
            this.btn_deshacer.Text = "DESHACER CAMBIOS";
            this.btn_deshacer.TextColor = System.Drawing.Color.Black;
            this.btn_deshacer.UseVisualStyleBackColor = false;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.SystemColors.Window;
            this.txt_id.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_id.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_id.BorderRadius = 0;
            this.txt_id.BorderSize = 2;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_id.Location = new System.Drawing.Point(35, 275);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Multiline = false;
            this.txt_id.Name = "txt_id";
            this.txt_id.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_id.PasswordChar = false;
            this.txt_id.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_id.PlaceholderText = "";
            this.txt_id.Size = new System.Drawing.Size(40, 31);
            this.txt_id.TabIndex = 32;
            this.txt_id.Texts = "0";
            this.txt_id.UnderlinedStyle = false;
            this.txt_id.Visible = false;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Gold;
            this.btn_guardar.BackgroundColor = System.Drawing.Color.Gold;
            this.btn_guardar.BorderColor = System.Drawing.Color.Black;
            this.btn_guardar.BorderRadius = 10;
            this.btn_guardar.BorderSize = 2;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.Black;
            this.btn_guardar.Location = new System.Drawing.Point(84, 322);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(148, 52);
            this.btn_guardar.TabIndex = 23;
            this.btn_guardar.Text = "GUARDAR";
            this.btn_guardar.TextColor = System.Drawing.Color.Black;
            this.btn_guardar.UseVisualStyleBackColor = false;
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
            // productosToolStripMenu
            // 
            this.productosToolStripMenu.Depth = 0;
            this.productosToolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.productosToolStripMenu.Margin = new System.Windows.Forms.Padding(0);
            this.productosToolStripMenu.MouseLocation = new System.Drawing.Point(-1, -1);
            this.productosToolStripMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.productosToolStripMenu.Name = "productosToolStripMenu";
            this.productosToolStripMenu.ReadOnly = true;
            this.productosToolStripMenu.Ripple = true;
            this.productosToolStripMenu.Size = new System.Drawing.Size(104, 37);
            this.productosToolStripMenu.TabIndex = 0;
            this.productosToolStripMenu.Text = "chk_productos";
            this.productosToolStripMenu.UseVisualStyleBackColor = false;
            // 
            // comprasToolStripMenu
            // 
            this.comprasToolStripMenu.Depth = 0;
            this.comprasToolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.comprasToolStripMenu.Margin = new System.Windows.Forms.Padding(0);
            this.comprasToolStripMenu.MouseLocation = new System.Drawing.Point(-1, -1);
            this.comprasToolStripMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.comprasToolStripMenu.Name = "comprasToolStripMenu";
            this.comprasToolStripMenu.ReadOnly = false;
            this.comprasToolStripMenu.Ripple = true;
            this.comprasToolStripMenu.Size = new System.Drawing.Size(104, 37);
            this.comprasToolStripMenu.TabIndex = 0;
            this.comprasToolStripMenu.Text = "chk_compras";
            this.comprasToolStripMenu.UseVisualStyleBackColor = true;
            // 
            // ventasToolStripMenu
            // 
            this.ventasToolStripMenu.Depth = 0;
            this.ventasToolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.ventasToolStripMenu.Margin = new System.Windows.Forms.Padding(0);
            this.ventasToolStripMenu.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ventasToolStripMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.ventasToolStripMenu.Name = "ventasToolStripMenu";
            this.ventasToolStripMenu.ReadOnly = false;
            this.ventasToolStripMenu.Ripple = true;
            this.ventasToolStripMenu.Size = new System.Drawing.Size(104, 37);
            this.ventasToolStripMenu.TabIndex = 0;
            this.ventasToolStripMenu.Text = "chk_ventas";
            this.ventasToolStripMenu.UseVisualStyleBackColor = true;
            // 
            // reportesToolStripMenu
            // 
            this.reportesToolStripMenu.Depth = 0;
            this.reportesToolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.reportesToolStripMenu.Margin = new System.Windows.Forms.Padding(0);
            this.reportesToolStripMenu.MouseLocation = new System.Drawing.Point(-1, -1);
            this.reportesToolStripMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.reportesToolStripMenu.Name = "reportesToolStripMenu";
            this.reportesToolStripMenu.ReadOnly = false;
            this.reportesToolStripMenu.Ripple = true;
            this.reportesToolStripMenu.Size = new System.Drawing.Size(104, 37);
            this.reportesToolStripMenu.TabIndex = 0;
            this.reportesToolStripMenu.Text = "chk_reportes";
            this.reportesToolStripMenu.UseVisualStyleBackColor = true;
            // 
            // usuariosToolStripMenu
            // 
            this.usuariosToolStripMenu.Depth = 0;
            this.usuariosToolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.usuariosToolStripMenu.Margin = new System.Windows.Forms.Padding(0);
            this.usuariosToolStripMenu.MouseLocation = new System.Drawing.Point(-1, -1);
            this.usuariosToolStripMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.usuariosToolStripMenu.Name = "usuariosToolStripMenu";
            this.usuariosToolStripMenu.ReadOnly = false;
            this.usuariosToolStripMenu.Ripple = true;
            this.usuariosToolStripMenu.Size = new System.Drawing.Size(104, 37);
            this.usuariosToolStripMenu.TabIndex = 0;
            this.usuariosToolStripMenu.Text = "chk_usuarios";
            this.usuariosToolStripMenu.UseVisualStyleBackColor = true;
            // 
            // proveedoresToolStripMenu
            // 
            this.proveedoresToolStripMenu.Depth = 0;
            this.proveedoresToolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.proveedoresToolStripMenu.Margin = new System.Windows.Forms.Padding(0);
            this.proveedoresToolStripMenu.MouseLocation = new System.Drawing.Point(-1, -1);
            this.proveedoresToolStripMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.proveedoresToolStripMenu.Name = "proveedoresToolStripMenu";
            this.proveedoresToolStripMenu.ReadOnly = false;
            this.proveedoresToolStripMenu.Ripple = true;
            this.proveedoresToolStripMenu.Size = new System.Drawing.Size(104, 37);
            this.proveedoresToolStripMenu.TabIndex = 0;
            this.proveedoresToolStripMenu.Text = "chk_proveedores";
            this.proveedoresToolStripMenu.UseVisualStyleBackColor = true;
            // 
            // clientesToolStripMenu
            // 
            this.clientesToolStripMenu.Depth = 0;
            this.clientesToolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.clientesToolStripMenu.Margin = new System.Windows.Forms.Padding(0);
            this.clientesToolStripMenu.MouseLocation = new System.Drawing.Point(-1, -1);
            this.clientesToolStripMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.clientesToolStripMenu.Name = "clientesToolStripMenu";
            this.clientesToolStripMenu.ReadOnly = false;
            this.clientesToolStripMenu.Ripple = true;
            this.clientesToolStripMenu.Size = new System.Drawing.Size(104, 37);
            this.clientesToolStripMenu.TabIndex = 0;
            this.clientesToolStripMenu.Text = "chk_clientes";
            this.clientesToolStripMenu.UseVisualStyleBackColor = true;
            // 
            // configToolStripMenu
            // 
            this.configToolStripMenu.Depth = 0;
            this.configToolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.configToolStripMenu.Margin = new System.Windows.Forms.Padding(0);
            this.configToolStripMenu.MouseLocation = new System.Drawing.Point(-1, -1);
            this.configToolStripMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.configToolStripMenu.Name = "configToolStripMenu";
            this.configToolStripMenu.ReadOnly = false;
            this.configToolStripMenu.Ripple = true;
            this.configToolStripMenu.Size = new System.Drawing.Size(104, 37);
            this.configToolStripMenu.TabIndex = 0;
            this.configToolStripMenu.Text = "chk_config";
            this.configToolStripMenu.UseVisualStyleBackColor = true;
            // 
            // formPermissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 494);
            this.Controls.Add(this.panel_main);
            this.Name = "formPermissions";
            this.Text = "formPermissions";
            this.Load += new System.EventHandler(this.formPermisos_Load);
            this.panel_main.ResumeLayout(false);
            this.combo_rol.ResumeLayout(false);
            this.materialCheckedListBox.ResumeLayout(false);
            this.materialCheckedListBox.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel combo_rol;
        private CustomBox.RJControls.RJButton btn_editar_permisos;
        private CustomBox.RJControls.RJButton btn_deshacer;
        private RJCodeAdvance.RJControls.RJTextBox txt_id;
        private CustomBox.RJControls.RJButton btn_guardar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialCheckedListBox materialCheckedListBox;
        private MaterialSkin.Controls.MaterialCheckbox configToolStripMenuItem;
        private MaterialSkin.Controls.MaterialCheckbox clientesToolStripMenuItem;
        private MaterialSkin.Controls.MaterialCheckbox proveedoresToolStripMenuItem;
        private MaterialSkin.Controls.MaterialCheckbox usuariosToolStripMenuItem;
        private MaterialSkin.Controls.MaterialCheckbox reportesToolStripMenuItem;
        private MaterialSkin.Controls.MaterialCheckbox ventasToolStripMenuItem;
        private MaterialSkin.Controls.MaterialCheckbox comprasToolStripMenuItem;
        private MaterialSkin.Controls.MaterialCheckbox productosToolStripMenuItem;
        private MaterialSkin.Controls.MaterialCheckbox productosToolStripMenu;
        private MaterialSkin.Controls.MaterialCheckbox comprasToolStripMenu;
        private MaterialSkin.Controls.MaterialCheckbox ventasToolStripMenu;
        private MaterialSkin.Controls.MaterialCheckbox reportesToolStripMenu;
        private MaterialSkin.Controls.MaterialCheckbox usuariosToolStripMenu;
        private MaterialSkin.Controls.MaterialCheckbox proveedoresToolStripMenu;
        private MaterialSkin.Controls.MaterialCheckbox clientesToolStripMenu;
        private MaterialSkin.Controls.MaterialCheckbox configToolStripMenu;
    }
}