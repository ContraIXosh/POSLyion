namespace PDCLyion
{
    partial class formProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formProducts));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_top = new System.Windows.Forms.Panel();
            this.btn_hamb = new RJCodeAdvance.RJControls.RJButton();
            this.btn_Down = new CustomBox.RJControls.RJButton();
            this.lbl_POS = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel_top, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.84795F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.78492F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.36712F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(982, 537);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Gold;
            this.panel_top.Controls.Add(this.btn_hamb);
            this.panel_top.Controls.Add(this.btn_Down);
            this.panel_top.Controls.Add(this.lbl_POS);
            this.panel_top.Controls.Add(this.lbl_usuario);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(3, 3);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(956, 61);
            this.panel_top.TabIndex = 3;
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
            this.btn_hamb.Location = new System.Drawing.Point(9, 12);
            this.btn_hamb.Name = "btn_hamb";
            this.btn_hamb.Size = new System.Drawing.Size(39, 38);
            this.btn_hamb.TabIndex = 11;
            this.btn_hamb.TextColor = System.Drawing.Color.White;
            this.btn_hamb.UseVisualStyleBackColor = false;
            // 
            // btn_Down
            // 
            this.btn_Down.BackColor = System.Drawing.Color.Transparent;
            this.btn_Down.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_Down.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Down.BackgroundImage")));
            this.btn_Down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Down.BorderColor = System.Drawing.Color.Red;
            this.btn_Down.BorderRadius = 10;
            this.btn_Down.BorderSize = 0;
            this.btn_Down.FlatAppearance.BorderSize = 0;
            this.btn_Down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Down.ForeColor = System.Drawing.Color.White;
            this.btn_Down.Location = new System.Drawing.Point(709, 15);
            this.btn_Down.Name = "btn_Down";
            this.btn_Down.Size = new System.Drawing.Size(30, 27);
            this.btn_Down.TabIndex = 10;
            this.btn_Down.TextColor = System.Drawing.Color.White;
            this.btn_Down.UseVisualStyleBackColor = false;
            // 
            // lbl_POS
            // 
            this.lbl_POS.AutoSize = true;
            this.lbl_POS.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_POS.Location = new System.Drawing.Point(75, 2);
            this.lbl_POS.Name = "lbl_POS";
            this.lbl_POS.Size = new System.Drawing.Size(248, 55);
            this.lbl_POS.TabIndex = 8;
            this.lbl_POS.Text = "POSLyion";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(736, 14);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(141, 28);
            this.lbl_usuario.TabIndex = 9;
            this.lbl_usuario.Text = "PERSONAL1";
            // 
            // formProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 537);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "formProducts";
            this.Text = "formProducts";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel_top;
        private RJCodeAdvance.RJControls.RJButton btn_hamb;
        private CustomBox.RJControls.RJButton btn_Down;
        private System.Windows.Forms.Label lbl_POS;
        private System.Windows.Forms.Label lbl_usuario;
    }
}