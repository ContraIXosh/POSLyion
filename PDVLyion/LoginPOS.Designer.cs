namespace POSLyion
{
    partial class LoginPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPOS));
            this.panel_container = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.txt_nombre_usuario = new System.Windows.Forms.TextBox();
            this.btn_iniciar_sesion = new CustomBox.RJControls.RJButton();
            this.btn_cerrar = new CustomBox.RJControls.RJButton();
            this.notice = new System.Windows.Forms.Label();
            this.lbl_clave = new System.Windows.Forms.Label();
            this.lbl_nombre_usuario = new System.Windows.Forms.Label();
            this.panel_izq = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_container.SuspendLayout();
            this.panel_izq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_container
            // 
            this.panel_container.BackColor = System.Drawing.Color.White;
            this.panel_container.Controls.Add(this.label1);
            this.panel_container.Controls.Add(this.txt_clave);
            this.panel_container.Controls.Add(this.txt_nombre_usuario);
            this.panel_container.Controls.Add(this.btn_iniciar_sesion);
            this.panel_container.Controls.Add(this.btn_cerrar);
            this.panel_container.Controls.Add(this.notice);
            this.panel_container.Controls.Add(this.lbl_clave);
            this.panel_container.Controls.Add(this.lbl_nombre_usuario);
            this.panel_container.Controls.Add(this.panel_izq);
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.Location = new System.Drawing.Point(0, 0);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(588, 304);
            this.panel_container.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("FORESTS ITALIC PERSONAL USE", 32.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(250, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 52);
            this.label1.TabIndex = 25;
            this.label1.Text = "POSLyion - Inicio WEB";
            // 
            // txt_clave
            // 
            this.txt_clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic);
            this.txt_clave.ForeColor = System.Drawing.Color.Gray;
            this.txt_clave.Location = new System.Drawing.Point(275, 155);
            this.txt_clave.Multiline = true;
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.Size = new System.Drawing.Size(262, 31);
            this.txt_clave.TabIndex = 24;
            this.txt_clave.Text = "123";
            // 
            // txt_nombre_usuario
            // 
            this.txt_nombre_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic);
            this.txt_nombre_usuario.ForeColor = System.Drawing.Color.Gray;
            this.txt_nombre_usuario.Location = new System.Drawing.Point(275, 81);
            this.txt_nombre_usuario.Multiline = true;
            this.txt_nombre_usuario.Name = "txt_nombre_usuario";
            this.txt_nombre_usuario.Size = new System.Drawing.Size(262, 31);
            this.txt_nombre_usuario.TabIndex = 23;
            this.txt_nombre_usuario.Text = "usuario@poslyion";
            // 
            // btn_iniciar_sesion
            // 
            this.btn_iniciar_sesion.BackColor = System.Drawing.Color.Gold;
            this.btn_iniciar_sesion.BackgroundColor = System.Drawing.Color.Gold;
            this.btn_iniciar_sesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_iniciar_sesion.BorderColor = System.Drawing.Color.Black;
            this.btn_iniciar_sesion.BorderRadius = 10;
            this.btn_iniciar_sesion.BorderSize = 2;
            this.btn_iniciar_sesion.FlatAppearance.BorderSize = 0;
            this.btn_iniciar_sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iniciar_sesion.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciar_sesion.ForeColor = System.Drawing.Color.Black;
            this.btn_iniciar_sesion.Image = ((System.Drawing.Image)(resources.GetObject("btn_iniciar_sesion.Image")));
            this.btn_iniciar_sesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_iniciar_sesion.Location = new System.Drawing.Point(275, 250);
            this.btn_iniciar_sesion.Name = "btn_iniciar_sesion";
            this.btn_iniciar_sesion.Size = new System.Drawing.Size(135, 42);
            this.btn_iniciar_sesion.TabIndex = 22;
            this.btn_iniciar_sesion.Text = "Iniciar Sesion";
            this.btn_iniciar_sesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_iniciar_sesion.TextColor = System.Drawing.Color.Black;
            this.btn_iniciar_sesion.UseVisualStyleBackColor = false;
            this.btn_iniciar_sesion.Click += new System.EventHandler(this.btn_iniciar_sesion_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.Red;
            this.btn_cerrar.BackgroundColor = System.Drawing.Color.Red;
            this.btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cerrar.BorderColor = System.Drawing.Color.Black;
            this.btn_cerrar.BorderRadius = 10;
            this.btn_cerrar.BorderSize = 2;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Swis721 BlkCn BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.Black;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cerrar.Location = new System.Drawing.Point(429, 250);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(96, 42);
            this.btn_cerrar.TabIndex = 21;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cerrar.TextColor = System.Drawing.Color.Black;
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // notice
            // 
            this.notice.AutoSize = true;
            this.notice.BackColor = System.Drawing.Color.Transparent;
            this.notice.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notice.ForeColor = System.Drawing.Color.Black;
            this.notice.Location = new System.Drawing.Point(274, 203);
            this.notice.Name = "notice";
            this.notice.Size = new System.Drawing.Size(263, 32);
            this.notice.TabIndex = 20;
            this.notice.Text = "Por favor ingrese su usuario y contraseña\r\npara ingresar al sistema";
            // 
            // lbl_clave
            // 
            this.lbl_clave.AutoSize = true;
            this.lbl_clave.BackColor = System.Drawing.Color.Transparent;
            this.lbl_clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clave.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_clave.Location = new System.Drawing.Point(270, 130);
            this.lbl_clave.Name = "lbl_clave";
            this.lbl_clave.Size = new System.Drawing.Size(153, 29);
            this.lbl_clave.TabIndex = 19;
            this.lbl_clave.Text = "Contraseña:";
            // 
            // lbl_nombre_usuario
            // 
            this.lbl_nombre_usuario.AutoSize = true;
            this.lbl_nombre_usuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_usuario.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_nombre_usuario.Location = new System.Drawing.Point(271, 56);
            this.lbl_nombre_usuario.Name = "lbl_nombre_usuario";
            this.lbl_nombre_usuario.Size = new System.Drawing.Size(110, 29);
            this.lbl_nombre_usuario.TabIndex = 18;
            this.lbl_nombre_usuario.Text = "Usuario:";
            // 
            // panel_izq
            // 
            this.panel_izq.BackColor = System.Drawing.Color.OrangeRed;
            this.panel_izq.Controls.Add(this.pictureBox1);
            this.panel_izq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_izq.Location = new System.Drawing.Point(0, 0);
            this.panel_izq.Name = "panel_izq";
            this.panel_izq.Size = new System.Drawing.Size(243, 304);
            this.panel_izq.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoginPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 304);
            this.ControlBox = false;
            this.Controls.Add(this.panel_container);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "LoginPOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formUserPOS";
            this.panel_container.ResumeLayout(false);
            this.panel_container.PerformLayout();
            this.panel_izq.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.Panel panel_izq;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.TextBox txt_nombre_usuario;
        private CustomBox.RJControls.RJButton btn_iniciar_sesion;
        private CustomBox.RJControls.RJButton btn_cerrar;
        private System.Windows.Forms.Label notice;
        private System.Windows.Forms.Label lbl_clave;
        private System.Windows.Forms.Label lbl_nombre_usuario;
        private System.Windows.Forms.Label label1;
    }
}