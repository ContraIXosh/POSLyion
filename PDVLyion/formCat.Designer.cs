namespace PDCLyion
{
    partial class formCat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCat));
            this.panel_bott = new System.Windows.Forms.TableLayoutPanel();
            this.panel_bottom = new System.Windows.Forms.TableLayoutPanel();
            this.btn_back = new RJCodeAdvance.RJControls.RJButton();
            this.txt_category = new CustomBox.RJControls.RJTextBox();
            this.btn_add_category = new RJCodeAdvance.RJControls.RJButton();
            this.txt_id = new CustomBox.RJControls.RJTextBox();
            this.panel_updates = new System.Windows.Forms.Panel();
            this.lbl_updateversion = new System.Windows.Forms.Label();
            this.lbl_updatetime = new System.Windows.Forms.Label();
            this.panel_grid = new System.Windows.Forms.TableLayoutPanel();
            this.grid_category = new System.Windows.Forms.DataGridView();
            this.btn_editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.num_prods = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_top = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.btn_hamb = new RJCodeAdvance.RJControls.RJButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Down = new CustomBox.RJControls.RJButton();
            this.panel_main = new System.Windows.Forms.TableLayoutPanel();
            this.panel_bott.SuspendLayout();
            this.panel_bottom.SuspendLayout();
            this.panel_updates.SuspendLayout();
            this.panel_grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_category)).BeginInit();
            this.panel_top.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bott
            // 
            this.panel_bott.ColumnCount = 1;
            this.panel_bott.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_bott.Controls.Add(this.panel_updates, 0, 1);
            this.panel_bott.Controls.Add(this.panel_bottom, 0, 0);
            this.panel_bott.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_bott.Location = new System.Drawing.Point(0, 462);
            this.panel_bott.Margin = new System.Windows.Forms.Padding(0);
            this.panel_bott.Name = "panel_bott";
            this.panel_bott.RowCount = 2;
            this.panel_bott.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_bott.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_bott.Size = new System.Drawing.Size(984, 82);
            this.panel_bott.TabIndex = 17;
            // 
            // panel_bottom
            // 
            this.panel_bottom.ColumnCount = 4;
            this.panel_bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.panel_bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.panel_bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.panel_bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel_bottom.Controls.Add(this.txt_id, 2, 0);
            this.panel_bottom.Controls.Add(this.btn_add_category, 0, 0);
            this.panel_bottom.Controls.Add(this.txt_category, 1, 0);
            this.panel_bottom.Controls.Add(this.btn_back, 3, 0);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_bottom.Location = new System.Drawing.Point(0, 0);
            this.panel_bottom.Margin = new System.Windows.Forms.Padding(0);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.RowCount = 1;
            this.panel_bottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_bottom.Size = new System.Drawing.Size(984, 62);
            this.panel_bottom.TabIndex = 0;
            // 
            // btn_back
            // 
            this.btn_back.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_back.BorderColor = System.Drawing.Color.Red;
            this.btn_back.BorderRadius = 1;
            this.btn_back.BorderSize = 2;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.Red;
            this.btn_back.Location = new System.Drawing.Point(772, 11);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(150, 40);
            this.btn_back.TabIndex = 36;
            this.btn_back.Text = "Regresar";
            this.btn_back.TextColor = System.Drawing.Color.Red;
            this.btn_back.UseVisualStyleBackColor = false;
            // 
            // txt_category
            // 
            this.txt_category.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_category.BackColor = System.Drawing.SystemColors.Window;
            this.txt_category.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_category.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_category.BorderRadius = 0;
            this.txt_category.BorderSize = 2;
            this.txt_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_category.Location = new System.Drawing.Point(64, 15);
            this.txt_category.Margin = new System.Windows.Forms.Padding(4);
            this.txt_category.Multiline = false;
            this.txt_category.Name = "txt_category";
            this.txt_category.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_category.PasswordChar = false;
            this.txt_category.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_category.PlaceholderText = "";
            this.txt_category.Size = new System.Drawing.Size(356, 31);
            this.txt_category.TabIndex = 37;
            this.txt_category.Texts = "";
            this.txt_category.UnderlinedStyle = false;
            // 
            // btn_add_category
            // 
            this.btn_add_category.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_add_category.BackColor = System.Drawing.Color.Transparent;
            this.btn_add_category.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_add_category.BorderColor = System.Drawing.Color.Lime;
            this.btn_add_category.BorderRadius = 7;
            this.btn_add_category.BorderSize = 2;
            this.btn_add_category.FlatAppearance.BorderSize = 0;
            this.btn_add_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_category.ForeColor = System.Drawing.Color.Lime;
            this.btn_add_category.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_category.Image")));
            this.btn_add_category.Location = new System.Drawing.Point(3, 15);
            this.btn_add_category.Name = "btn_add_category";
            this.btn_add_category.Size = new System.Drawing.Size(54, 32);
            this.btn_add_category.TabIndex = 35;
            this.btn_add_category.TextColor = System.Drawing.Color.Lime;
            this.btn_add_category.UseVisualStyleBackColor = false;
            // 
            // txt_id
            // 
            this.txt_id.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_id.BackColor = System.Drawing.SystemColors.Window;
            this.txt_id.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_id.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_id.BorderRadius = 0;
            this.txt_id.BorderSize = 2;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_id.Location = new System.Drawing.Point(708, 15);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Multiline = false;
            this.txt_id.Name = "txt_id";
            this.txt_id.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_id.PasswordChar = false;
            this.txt_id.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_id.PlaceholderText = "";
            this.txt_id.Size = new System.Drawing.Size(46, 31);
            this.txt_id.TabIndex = 38;
            this.txt_id.Texts = "0";
            this.txt_id.UnderlinedStyle = false;
            this.txt_id.Visible = false;
            // 
            // panel_updates
            // 
            this.panel_updates.BackColor = System.Drawing.Color.Khaki;
            this.panel_updates.Controls.Add(this.lbl_updatetime);
            this.panel_updates.Controls.Add(this.lbl_updateversion);
            this.panel_updates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_updates.Location = new System.Drawing.Point(0, 62);
            this.panel_updates.Margin = new System.Windows.Forms.Padding(0);
            this.panel_updates.Name = "panel_updates";
            this.panel_updates.Size = new System.Drawing.Size(984, 20);
            this.panel_updates.TabIndex = 2;
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
            // lbl_updatetime
            // 
            this.lbl_updatetime.AutoSize = true;
            this.lbl_updatetime.Location = new System.Drawing.Point(633, 3);
            this.lbl_updatetime.Name = "lbl_updatetime";
            this.lbl_updatetime.Size = new System.Drawing.Size(199, 13);
            this.lbl_updatetime.TabIndex = 1;
            this.lbl_updatetime.Text = "Ultimo chequeo: 10:06:12  - 20/09/2024";
            // 
            // panel_grid
            // 
            this.panel_grid.ColumnCount = 2;
            this.panel_grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.panel_grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.panel_grid.Controls.Add(this.grid_category, 1, 0);
            this.panel_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_grid.Location = new System.Drawing.Point(0, 54);
            this.panel_grid.Margin = new System.Windows.Forms.Padding(0);
            this.panel_grid.Name = "panel_grid";
            this.panel_grid.RowCount = 1;
            this.panel_grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_grid.Size = new System.Drawing.Size(984, 408);
            this.panel_grid.TabIndex = 16;
            // 
            // grid_category
            // 
            this.grid_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_category.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cat,
            this.name_category,
            this.num_prods,
            this.btn_eliminar,
            this.btn_editar});
            this.grid_category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_category.Location = new System.Drawing.Point(344, 0);
            this.grid_category.Margin = new System.Windows.Forms.Padding(0);
            this.grid_category.Name = "grid_category";
            this.grid_category.RowHeadersWidth = 51;
            this.grid_category.Size = new System.Drawing.Size(640, 408);
            this.grid_category.TabIndex = 36;
            // 
            // btn_editar
            // 
            this.btn_editar.HeaderText = "EDITAR";
            this.btn_editar.MinimumWidth = 6;
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Width = 125;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.HeaderText = "ELIMINAR";
            this.btn_eliminar.MinimumWidth = 6;
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Width = 125;
            // 
            // num_prods
            // 
            this.num_prods.HeaderText = "CANTIDAD DE PRODUCTOS ASOCIADOS";
            this.num_prods.MinimumWidth = 6;
            this.num_prods.Name = "num_prods";
            this.num_prods.Width = 125;
            // 
            // name_category
            // 
            this.name_category.HeaderText = "Categoria";
            this.name_category.MinimumWidth = 6;
            this.name_category.Name = "name_category";
            this.name_category.Width = 125;
            // 
            // id_cat
            // 
            this.id_cat.HeaderText = "ID";
            this.id_cat.MinimumWidth = 6;
            this.id_cat.Name = "id_cat";
            this.id_cat.Width = 125;
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Gold;
            this.panel_top.ColumnCount = 4;
            this.panel_top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panel_top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.panel_top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panel_top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.panel_top.Controls.Add(this.btn_Down, 2, 0);
            this.panel_top.Controls.Add(this.label6, 1, 0);
            this.panel_top.Controls.Add(this.btn_hamb, 0, 0);
            this.panel_top.Controls.Add(this.lbl_usuario, 3, 0);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_top.ForeColor = System.Drawing.Color.Black;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Margin = new System.Windows.Forms.Padding(0);
            this.panel_top.Name = "panel_top";
            this.panel_top.RowCount = 1;
            this.panel_top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_top.Size = new System.Drawing.Size(984, 54);
            this.panel_top.TabIndex = 15;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(721, 12);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(165, 29);
            this.lbl_usuario.TabIndex = 12;
            this.lbl_usuario.Text = "PERSONAL1";
            // 
            // btn_hamb
            // 
            this.btn_hamb.BackColor = System.Drawing.Color.Transparent;
            this.btn_hamb.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_hamb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_hamb.BackgroundImage")));
            this.btn_hamb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_hamb.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_hamb.BorderRadius = 0;
            this.btn_hamb.BorderSize = 0;
            this.btn_hamb.FlatAppearance.BorderSize = 0;
            this.btn_hamb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hamb.ForeColor = System.Drawing.Color.White;
            this.btn_hamb.Location = new System.Drawing.Point(3, 3);
            this.btn_hamb.Name = "btn_hamb";
            this.btn_hamb.Size = new System.Drawing.Size(44, 39);
            this.btn_hamb.TabIndex = 11;
            this.btn_hamb.TextColor = System.Drawing.Color.White;
            this.btn_hamb.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 53);
            this.label6.TabIndex = 0;
            this.label6.Text = "POSLyion";
            // 
            // btn_Down
            // 
            this.btn_Down.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Down.BackColor = System.Drawing.Color.Transparent;
            this.btn_Down.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_Down.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Down.BackgroundImage")));
            this.btn_Down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Down.BorderColor = System.Drawing.Color.Red;
            this.btn_Down.BorderRadius = 1;
            this.btn_Down.BorderSize = 0;
            this.btn_Down.FlatAppearance.BorderSize = 0;
            this.btn_Down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Down.ForeColor = System.Drawing.Color.White;
            this.btn_Down.Location = new System.Drawing.Point(678, 13);
            this.btn_Down.Name = "btn_Down";
            this.btn_Down.Size = new System.Drawing.Size(30, 27);
            this.btn_Down.TabIndex = 10;
            this.btn_Down.TextColor = System.Drawing.Color.White;
            this.btn_Down.UseVisualStyleBackColor = false;
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_main.ColumnCount = 1;
            this.panel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_main.Controls.Add(this.panel_top, 0, 0);
            this.panel_main.Controls.Add(this.panel_grid, 0, 1);
            this.panel_main.Controls.Add(this.panel_bott, 0, 2);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Margin = new System.Windows.Forms.Padding(0);
            this.panel_main.Name = "panel_main";
            this.panel_main.RowCount = 3;
            this.panel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.panel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.panel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.panel_main.Size = new System.Drawing.Size(984, 544);
            this.panel_main.TabIndex = 37;
            // 
            // formCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 544);
            this.Controls.Add(this.panel_main);
            this.Name = "formCat";
            this.Text = "formCat";
            this.Load += new System.EventHandler(this.formCat_Load);
            this.panel_bott.ResumeLayout(false);
            this.panel_bottom.ResumeLayout(false);
            this.panel_updates.ResumeLayout(false);
            this.panel_updates.PerformLayout();
            this.panel_grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_category)).EndInit();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel_bott;
        private System.Windows.Forms.Panel panel_updates;
        private System.Windows.Forms.Label lbl_updatetime;
        private System.Windows.Forms.Label lbl_updateversion;
        private System.Windows.Forms.TableLayoutPanel panel_bottom;
        private CustomBox.RJControls.RJTextBox txt_id;
        private RJCodeAdvance.RJControls.RJButton btn_add_category;
        private CustomBox.RJControls.RJTextBox txt_category;
        private RJCodeAdvance.RJControls.RJButton btn_back;
        private System.Windows.Forms.TableLayoutPanel panel_grid;
        private System.Windows.Forms.DataGridView grid_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_prods;
        private System.Windows.Forms.DataGridViewButtonColumn btn_eliminar;
        private System.Windows.Forms.DataGridViewButtonColumn btn_editar;
        private System.Windows.Forms.TableLayoutPanel panel_top;
        private CustomBox.RJControls.RJButton btn_Down;
        private System.Windows.Forms.Label label6;
        private RJCodeAdvance.RJControls.RJButton btn_hamb;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.TableLayoutPanel panel_main;
    }
}