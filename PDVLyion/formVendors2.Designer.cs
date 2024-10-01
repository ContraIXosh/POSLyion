namespace PDCLyion
{
    partial class formVendors2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formVendors2));
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_footer = new System.Windows.Forms.Panel();
            this.btn_viewvendedor = new RJCodeAdvance.RJControls.RJButton();
            this.btn_addvendedor = new RJCodeAdvance.RJControls.RJButton();
            this.btn_back = new RJCodeAdvance.RJControls.RJButton();
            this.panel_add = new System.Windows.Forms.Panel();
            this.btn_borrar = new CustomBox.RJControls.RJButton();
            this.btn_crear = new CustomBox.RJControls.RJButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cbox_cat = new RJCodeAdvance.RJControls.RJComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_cred = new System.Windows.Forms.CheckBox();
            this.cb_card = new System.Windows.Forms.CheckBox();
            this.cb_efect = new System.Windows.Forms.CheckBox();
            this.txt_rsocial = new CustomBox.RJControls.RJTextBox();
            this.txt_tel = new CustomBox.RJControls.RJTextBox();
            this.txt_empresa = new CustomBox.RJControls.RJTextBox();
            this.txt_cuit = new CustomBox.RJControls.RJTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_main.SuspendLayout();
            this.panel_footer.SuspendLayout();
            this.panel_add.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.AutoSize = true;
            this.panel_main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_main.Controls.Add(this.panel_footer);
            this.panel_main.Controls.Add(this.panel_add);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(966, 498);
            this.panel_main.TabIndex = 1;
            // 
            // panel_footer
            // 
            this.panel_footer.Controls.Add(this.panel3);
            this.panel_footer.Controls.Add(this.btn_viewvendedor);
            this.panel_footer.Controls.Add(this.btn_addvendedor);
            this.panel_footer.Controls.Add(this.btn_back);
            this.panel_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_footer.Location = new System.Drawing.Point(0, 421);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(966, 77);
            this.panel_footer.TabIndex = 11;
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
            this.btn_viewvendedor.Location = new System.Drawing.Point(268, 13);
            this.btn_viewvendedor.Name = "btn_viewvendedor";
            this.btn_viewvendedor.Size = new System.Drawing.Size(254, 40);
            this.btn_viewvendedor.TabIndex = 10;
            this.btn_viewvendedor.Text = "VISUALIZAR VENDEDORES";
            this.btn_viewvendedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_viewvendedor.TextColor = System.Drawing.Color.Gold;
            this.btn_viewvendedor.UseVisualStyleBackColor = false;
            this.btn_viewvendedor.Click += new System.EventHandler(this.btn_viewvendedor_Click);
            // 
            // btn_addvendedor
            // 
            this.btn_addvendedor.BackColor = System.Drawing.Color.Transparent;
            this.btn_addvendedor.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_addvendedor.BorderColor = System.Drawing.Color.ForestGreen;
            this.btn_addvendedor.BorderRadius = 7;
            this.btn_addvendedor.BorderSize = 2;
            this.btn_addvendedor.FlatAppearance.BorderSize = 0;
            this.btn_addvendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addvendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addvendedor.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_addvendedor.Image = ((System.Drawing.Image)(resources.GetObject("btn_addvendedor.Image")));
            this.btn_addvendedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addvendedor.Location = new System.Drawing.Point(12, 13);
            this.btn_addvendedor.Name = "btn_addvendedor";
            this.btn_addvendedor.Size = new System.Drawing.Size(250, 40);
            this.btn_addvendedor.TabIndex = 9;
            this.btn_addvendedor.Text = "AGREGAR VENDEDOR";
            this.btn_addvendedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addvendedor.TextColor = System.Drawing.Color.DarkGreen;
            this.btn_addvendedor.UseVisualStyleBackColor = false;
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
            this.btn_back.Location = new System.Drawing.Point(803, 13);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(150, 40);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Regresar";
            this.btn_back.TextColor = System.Drawing.Color.Red;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // panel_add
            // 
            this.panel_add.BackColor = System.Drawing.Color.Teal;
            this.panel_add.Controls.Add(this.btn_borrar);
            this.panel_add.Controls.Add(this.btn_crear);
            this.panel_add.Controls.Add(this.label7);
            this.panel_add.Controls.Add(this.cbox_cat);
            this.panel_add.Controls.Add(this.label6);
            this.panel_add.Controls.Add(this.label5);
            this.panel_add.Controls.Add(this.label4);
            this.panel_add.Controls.Add(this.label3);
            this.panel_add.Controls.Add(this.cb_cred);
            this.panel_add.Controls.Add(this.cb_card);
            this.panel_add.Controls.Add(this.cb_efect);
            this.panel_add.Controls.Add(this.txt_rsocial);
            this.panel_add.Controls.Add(this.txt_tel);
            this.panel_add.Controls.Add(this.txt_empresa);
            this.panel_add.Controls.Add(this.txt_cuit);
            this.panel_add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_add.Location = new System.Drawing.Point(0, 0);
            this.panel_add.Name = "panel_add";
            this.panel_add.Size = new System.Drawing.Size(966, 498);
            this.panel_add.TabIndex = 10;
            this.panel_add.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // btn_borrar
            // 
            this.btn_borrar.BackColor = System.Drawing.Color.Gold;
            this.btn_borrar.BackgroundColor = System.Drawing.Color.Gold;
            this.btn_borrar.BorderColor = System.Drawing.Color.Black;
            this.btn_borrar.BorderRadius = 10;
            this.btn_borrar.BorderSize = 2;
            this.btn_borrar.FlatAppearance.BorderSize = 0;
            this.btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borrar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrar.ForeColor = System.Drawing.Color.Black;
            this.btn_borrar.Location = new System.Drawing.Point(201, 287);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(171, 41);
            this.btn_borrar.TabIndex = 24;
            this.btn_borrar.Text = "BORRAR";
            this.btn_borrar.TextColor = System.Drawing.Color.Black;
            this.btn_borrar.UseVisualStyleBackColor = false;
            // 
            // btn_crear
            // 
            this.btn_crear.BackColor = System.Drawing.Color.Gold;
            this.btn_crear.BackgroundColor = System.Drawing.Color.Gold;
            this.btn_crear.BorderColor = System.Drawing.Color.Black;
            this.btn_crear.BorderRadius = 10;
            this.btn_crear.BorderSize = 2;
            this.btn_crear.FlatAppearance.BorderSize = 0;
            this.btn_crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crear.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crear.ForeColor = System.Drawing.Color.Black;
            this.btn_crear.Location = new System.Drawing.Point(12, 287);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(171, 41);
            this.btn_crear.TabIndex = 23;
            this.btn_crear.Text = "CREAR VENDEDOR";
            this.btn_crear.TextColor = System.Drawing.Color.Black;
            this.btn_crear.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(372, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 28);
            this.label7.TabIndex = 22;
            this.label7.Text = "TELEFONO";
            // 
            // cbox_cat
            // 
            this.cbox_cat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbox_cat.BorderColor = System.Drawing.Color.DarkViolet;
            this.cbox_cat.BorderSize = 2;
            this.cbox_cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbox_cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbox_cat.ForeColor = System.Drawing.Color.DimGray;
            this.cbox_cat.IconColor = System.Drawing.Color.DarkViolet;
            this.cbox_cat.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbox_cat.ListTextColor = System.Drawing.Color.DimGray;
            this.cbox_cat.Location = new System.Drawing.Point(376, 63);
            this.cbox_cat.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbox_cat.Name = "cbox_cat";
            this.cbox_cat.Padding = new System.Windows.Forms.Padding(2);
            this.cbox_cat.Size = new System.Drawing.Size(251, 30);
            this.cbox_cat.TabIndex = 21;
            this.cbox_cat.Texts = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(372, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "CATEGORIA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(29, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 28);
            this.label5.TabIndex = 19;
            this.label5.Text = "RAZON SOCIAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(29, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "EMPRESA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(30, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "CUIT";
            // 
            // cb_cred
            // 
            this.cb_cred.AutoSize = true;
            this.cb_cred.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_cred.ForeColor = System.Drawing.Color.Gold;
            this.cb_cred.Location = new System.Drawing.Point(742, 161);
            this.cb_cred.Name = "cb_cred";
            this.cb_cred.Size = new System.Drawing.Size(131, 29);
            this.cb_cred.TabIndex = 16;
            this.cb_cred.Text = "CREDITO";
            this.cb_cred.UseVisualStyleBackColor = true;
            // 
            // cb_card
            // 
            this.cb_card.AutoSize = true;
            this.cb_card.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_card.ForeColor = System.Drawing.Color.Gold;
            this.cb_card.Location = new System.Drawing.Point(742, 113);
            this.cb_card.Name = "cb_card";
            this.cb_card.Size = new System.Drawing.Size(132, 29);
            this.cb_card.TabIndex = 15;
            this.cb_card.Text = "TARJETA";
            this.cb_card.UseVisualStyleBackColor = true;
            // 
            // cb_efect
            // 
            this.cb_efect.AutoSize = true;
            this.cb_efect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_efect.ForeColor = System.Drawing.Color.Gold;
            this.cb_efect.Location = new System.Drawing.Point(742, 62);
            this.cb_efect.Name = "cb_efect";
            this.cb_efect.Size = new System.Drawing.Size(143, 29);
            this.cb_efect.TabIndex = 14;
            this.cb_efect.Text = "EFECTIVO";
            this.cb_efect.UseVisualStyleBackColor = true;
            // 
            // txt_rsocial
            // 
            this.txt_rsocial.BackColor = System.Drawing.SystemColors.Window;
            this.txt_rsocial.BorderColor = System.Drawing.Color.DarkViolet;
            this.txt_rsocial.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_rsocial.BorderRadius = 0;
            this.txt_rsocial.BorderSize = 2;
            this.txt_rsocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_rsocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_rsocial.Location = new System.Drawing.Point(34, 230);
            this.txt_rsocial.Margin = new System.Windows.Forms.Padding(4);
            this.txt_rsocial.Multiline = false;
            this.txt_rsocial.Name = "txt_rsocial";
            this.txt_rsocial.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_rsocial.PasswordChar = false;
            this.txt_rsocial.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_rsocial.PlaceholderText = "";
            this.txt_rsocial.Size = new System.Drawing.Size(250, 31);
            this.txt_rsocial.TabIndex = 13;
            this.txt_rsocial.Texts = "";
            this.txt_rsocial.UnderlinedStyle = false;
            // 
            // txt_tel
            // 
            this.txt_tel.BackColor = System.Drawing.SystemColors.Window;
            this.txt_tel.BorderColor = System.Drawing.Color.DarkViolet;
            this.txt_tel.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_tel.BorderRadius = 0;
            this.txt_tel.BorderSize = 2;
            this.txt_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_tel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_tel.Location = new System.Drawing.Point(377, 144);
            this.txt_tel.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tel.Multiline = false;
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_tel.PasswordChar = false;
            this.txt_tel.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_tel.PlaceholderText = "";
            this.txt_tel.Size = new System.Drawing.Size(250, 31);
            this.txt_tel.TabIndex = 11;
            this.txt_tel.Texts = "";
            this.txt_tel.UnderlinedStyle = false;
            // 
            // txt_empresa
            // 
            this.txt_empresa.BackColor = System.Drawing.SystemColors.Window;
            this.txt_empresa.BorderColor = System.Drawing.Color.DarkViolet;
            this.txt_empresa.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_empresa.BorderRadius = 0;
            this.txt_empresa.BorderSize = 2;
            this.txt_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_empresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_empresa.Location = new System.Drawing.Point(34, 144);
            this.txt_empresa.Margin = new System.Windows.Forms.Padding(4);
            this.txt_empresa.Multiline = false;
            this.txt_empresa.Name = "txt_empresa";
            this.txt_empresa.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_empresa.PasswordChar = false;
            this.txt_empresa.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_empresa.PlaceholderText = "";
            this.txt_empresa.Size = new System.Drawing.Size(250, 31);
            this.txt_empresa.TabIndex = 10;
            this.txt_empresa.Texts = "";
            this.txt_empresa.UnderlinedStyle = false;
            // 
            // txt_cuit
            // 
            this.txt_cuit.BackColor = System.Drawing.SystemColors.Window;
            this.txt_cuit.BorderColor = System.Drawing.Color.DarkViolet;
            this.txt_cuit.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_cuit.BorderRadius = 0;
            this.txt_cuit.BorderSize = 2;
            this.txt_cuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_cuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_cuit.Location = new System.Drawing.Point(34, 62);
            this.txt_cuit.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cuit.Multiline = false;
            this.txt_cuit.Name = "txt_cuit";
            this.txt_cuit.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_cuit.PasswordChar = false;
            this.txt_cuit.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_cuit.PlaceholderText = "";
            this.txt_cuit.Size = new System.Drawing.Size(250, 31);
            this.txt_cuit.TabIndex = 9;
            this.txt_cuit.Texts = "";
            this.txt_cuit.UnderlinedStyle = false;
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
            this.panel3.TabIndex = 14;
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
            // formVendors2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 498);
            this.Controls.Add(this.panel_main);
            this.Name = "formVendors2";
            this.Text = "formVendors2";
            this.panel_main.ResumeLayout(false);
            this.panel_footer.ResumeLayout(false);
            this.panel_add.ResumeLayout(false);
            this.panel_add.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private RJCodeAdvance.RJControls.RJButton btn_back;
        private System.Windows.Forms.Panel panel_add;
        private CustomBox.RJControls.RJTextBox txt_tel;
        private CustomBox.RJControls.RJTextBox txt_empresa;
        private CustomBox.RJControls.RJTextBox txt_cuit;
        private CustomBox.RJControls.RJTextBox txt_rsocial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_cred;
        private System.Windows.Forms.CheckBox cb_card;
        private System.Windows.Forms.CheckBox cb_efect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private RJCodeAdvance.RJControls.RJComboBox cbox_cat;
        private System.Windows.Forms.Label label7;
        private CustomBox.RJControls.RJButton btn_borrar;
        private CustomBox.RJControls.RJButton btn_crear;
        private System.Windows.Forms.Panel panel_footer;
        private RJCodeAdvance.RJControls.RJButton btn_viewvendedor;
        private RJCodeAdvance.RJControls.RJButton btn_addvendedor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}