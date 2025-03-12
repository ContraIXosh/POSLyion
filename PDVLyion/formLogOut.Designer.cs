namespace POSLyion
{
    partial class formLogOut
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
            this.panel_full = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancelar = new CustomBox.RJControls.RJButton();
            this.btn_cerrar = new CustomBox.RJControls.RJButton();
            this.lbl_logout = new System.Windows.Forms.Label();
            this.panel_full.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_full
            // 
            this.panel_full.BackColor = System.Drawing.Color.White;
            this.panel_full.Controls.Add(this.label1);
            this.panel_full.Controls.Add(this.btn_cancelar);
            this.panel_full.Controls.Add(this.btn_cerrar);
            this.panel_full.Controls.Add(this.lbl_logout);
            this.panel_full.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_full.Location = new System.Drawing.Point(0, 0);
            this.panel_full.Name = "panel_full";
            this.panel_full.Size = new System.Drawing.Size(460, 170);
            this.panel_full.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 64);
            this.label1.TabIndex = 3;
            this.label1.Text = "POSLyion";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_cancelar.BackgroundColor = System.Drawing.Color.DarkRed;
            this.btn_cancelar.BorderColor = System.Drawing.Color.Red;
            this.btn_cancelar.BorderRadius = 10;
            this.btn_cancelar.BorderSize = 2;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.Red;
            this.btn_cancelar.Location = new System.Drawing.Point(249, 119);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(150, 39);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextColor = System.Drawing.Color.Red;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.Gold;
            this.btn_cerrar.BackgroundColor = System.Drawing.Color.Gold;
            this.btn_cerrar.BorderColor = System.Drawing.Color.OrangeRed;
            this.btn_cerrar.BorderRadius = 10;
            this.btn_cerrar.BorderSize = 2;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_cerrar.Location = new System.Drawing.Point(61, 119);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(150, 39);
            this.btn_cerrar.TabIndex = 1;
            this.btn_cerrar.Text = "Cerrar sesión";
            this.btn_cerrar.TextColor = System.Drawing.Color.OrangeRed;
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // lbl_logout
            // 
            this.lbl_logout.AutoSize = true;
            this.lbl_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logout.ForeColor = System.Drawing.Color.Black;
            this.lbl_logout.Location = new System.Drawing.Point(56, 75);
            this.lbl_logout.Name = "lbl_logout";
            this.lbl_logout.Size = new System.Drawing.Size(343, 25);
            this.lbl_logout.TabIndex = 0;
            this.lbl_logout.Text = "¿Seguro que desea cerrar sesión?";
            // 
            // formLogOut
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(460, 170);
            this.Controls.Add(this.panel_full);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formLogOut";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cerrar sesion";
            this.panel_full.ResumeLayout(false);
            this.panel_full.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_full;
        private System.Windows.Forms.Label lbl_logout;
        private CustomBox.RJControls.RJButton btn_cancelar;
        private CustomBox.RJControls.RJButton btn_cerrar;
        private System.Windows.Forms.Label label1;
    }
}