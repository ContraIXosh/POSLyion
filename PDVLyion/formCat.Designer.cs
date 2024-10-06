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
            this.grid_category = new System.Windows.Forms.DataGridView();
            this.panel_update = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_footer = new System.Windows.Forms.Panel();
            this.txt_id = new CustomBox.RJControls.RJTextBox();
            this.txt_category = new CustomBox.RJControls.RJTextBox();
            this.btn_back = new RJCodeAdvance.RJControls.RJButton();
            this.btn_add_category = new RJCodeAdvance.RJControls.RJButton();
            this.panel_main = new System.Windows.Forms.Panel();
            this.id_cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_prods = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_editar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_category)).BeginInit();
            this.panel_update.SuspendLayout();
            this.panel_footer.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
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
            this.grid_category.Location = new System.Drawing.Point(0, 0);
            this.grid_category.Margin = new System.Windows.Forms.Padding(15);
            this.grid_category.Name = "grid_category";
            this.grid_category.Size = new System.Drawing.Size(982, 459);
            this.grid_category.TabIndex = 13;
            this.grid_category.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_category_CellContentClick);
            // 
            // panel_update
            // 
            this.panel_update.BackColor = System.Drawing.Color.Khaki;
            this.panel_update.Controls.Add(this.label2);
            this.panel_update.Controls.Add(this.label1);
            this.panel_update.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_update.Location = new System.Drawing.Point(0, 60);
            this.panel_update.Name = "panel_update";
            this.panel_update.Size = new System.Drawing.Size(982, 18);
            this.panel_update.TabIndex = 14;
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
            // panel_footer
            // 
            this.panel_footer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_footer.Controls.Add(this.txt_id);
            this.panel_footer.Controls.Add(this.txt_category);
            this.panel_footer.Controls.Add(this.panel_update);
            this.panel_footer.Controls.Add(this.btn_back);
            this.panel_footer.Controls.Add(this.btn_add_category);
            this.panel_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_footer.Location = new System.Drawing.Point(0, 459);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(982, 78);
            this.panel_footer.TabIndex = 12;
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
            this.txt_id.Location = new System.Drawing.Point(298, 13);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Multiline = false;
            this.txt_id.Name = "txt_id";
            this.txt_id.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_id.PasswordChar = false;
            this.txt_id.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_id.PlaceholderText = "";
            this.txt_id.Size = new System.Drawing.Size(46, 31);
            this.txt_id.TabIndex = 16;
            this.txt_id.Texts = "0";
            this.txt_id.UnderlinedStyle = false;
            // 
            // txt_category
            // 
            this.txt_category.BackColor = System.Drawing.SystemColors.Window;
            this.txt_category.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_category.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_category.BorderRadius = 0;
            this.txt_category.BorderSize = 2;
            this.txt_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txt_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_category.Location = new System.Drawing.Point(40, 14);
            this.txt_category.Margin = new System.Windows.Forms.Padding(4);
            this.txt_category.Multiline = false;
            this.txt_category.Name = "txt_category";
            this.txt_category.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_category.PasswordChar = false;
            this.txt_category.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_category.PlaceholderText = "";
            this.txt_category.Size = new System.Drawing.Size(250, 31);
            this.txt_category.TabIndex = 15;
            this.txt_category.Texts = "";
            this.txt_category.UnderlinedStyle = false;
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
            this.btn_back.Location = new System.Drawing.Point(820, 13);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(150, 40);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Regresar";
            this.btn_back.TextColor = System.Drawing.Color.Red;
            this.btn_back.UseVisualStyleBackColor = false;
            // 
            // btn_add_category
            // 
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
            this.btn_add_category.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_category.Location = new System.Drawing.Point(2, 13);
            this.btn_add_category.Name = "btn_add_category";
            this.btn_add_category.Size = new System.Drawing.Size(35, 32);
            this.btn_add_category.TabIndex = 0;
            this.btn_add_category.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add_category.TextColor = System.Drawing.Color.Lime;
            this.btn_add_category.UseVisualStyleBackColor = false;
            this.btn_add_category.Click += new System.EventHandler(this.btn_add_category_Click);
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.Black;
            this.panel_main.Controls.Add(this.grid_category);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(982, 459);
            this.panel_main.TabIndex = 13;
            // 
            // id_cat
            // 
            this.id_cat.HeaderText = "ID";
            this.id_cat.Name = "id_cat";
            // 
            // name_category
            // 
            this.name_category.HeaderText = "Categoria";
            this.name_category.Name = "name_category";
            // 
            // num_prods
            // 
            this.num_prods.HeaderText = "CANTIDAD DE PRODUCTOS ASOCIADOS";
            this.num_prods.Name = "num_prods";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.HeaderText = "ELIMINAR";
            this.btn_eliminar.Name = "btn_eliminar";
            // 
            // btn_editar
            // 
            this.btn_editar.HeaderText = "EDITAR";
            this.btn_editar.Name = "btn_editar";
            // 
            // formCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 537);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_footer);
            this.Name = "formCat";
            this.Text = "formCat";
            this.Load += new System.EventHandler(this.formCat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_category)).EndInit();
            this.panel_update.ResumeLayout(false);
            this.panel_update.PerformLayout();
            this.panel_footer.ResumeLayout(false);
            this.panel_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_category;
        private System.Windows.Forms.Panel panel_update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_footer;
        private CustomBox.RJControls.RJTextBox txt_category;
        private RJCodeAdvance.RJControls.RJButton btn_back;
        private RJCodeAdvance.RJControls.RJButton btn_add_category;
        private CustomBox.RJControls.RJTextBox txt_id;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_prods;
        private System.Windows.Forms.DataGridViewButtonColumn btn_eliminar;
        private System.Windows.Forms.DataGridViewButtonColumn btn_editar;
    }
}