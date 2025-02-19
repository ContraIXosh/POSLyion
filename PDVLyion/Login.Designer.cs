﻿namespace POSLyion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lbl_nombre_usuario = new System.Windows.Forms.Label();
            this.lbl_clave = new System.Windows.Forms.Label();
            this.notice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rjCircularPictureBox1 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.txt_nombre_usuario = new System.Windows.Forms.TextBox();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_iniciar_sesion = new CustomBox.RJControls.RJButton();
            this.btn_cerrar = new CustomBox.RJControls.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nombre_usuario
            // 
            this.lbl_nombre_usuario.AutoSize = true;
            this.lbl_nombre_usuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_usuario.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_nombre_usuario.Location = new System.Drawing.Point(292, 67);
            this.lbl_nombre_usuario.Name = "lbl_nombre_usuario";
            this.lbl_nombre_usuario.Size = new System.Drawing.Size(110, 29);
            this.lbl_nombre_usuario.TabIndex = 2;
            this.lbl_nombre_usuario.Text = "Usuario:";
            // 
            // lbl_clave
            // 
            this.lbl_clave.AutoSize = true;
            this.lbl_clave.BackColor = System.Drawing.Color.Transparent;
            this.lbl_clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clave.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_clave.Location = new System.Drawing.Point(290, 136);
            this.lbl_clave.Name = "lbl_clave";
            this.lbl_clave.Size = new System.Drawing.Size(153, 29);
            this.lbl_clave.TabIndex = 3;
            this.lbl_clave.Text = "Contraseña:";
            // 
            // notice
            // 
            this.notice.AutoSize = true;
            this.notice.BackColor = System.Drawing.Color.Transparent;
            this.notice.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notice.ForeColor = System.Drawing.Color.Black;
            this.notice.Location = new System.Drawing.Point(295, 210);
            this.notice.Name = "notice";
            this.notice.Size = new System.Drawing.Size(263, 32);
            this.notice.TabIndex = 4;
            this.notice.Text = "Por favor ingrese su usuario y contraseña\r\npara ingresar al sistema";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.rjCircularPictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 306);
            this.panel1.TabIndex = 15;
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.Gold;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.Crimson;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("rjCircularPictureBox1.Image")));
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(6, 21);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(255, 255);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 0;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // txt_nombre_usuario
            // 
            this.txt_nombre_usuario.BackColor = System.Drawing.Color.PapayaWhip;
            this.txt_nombre_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_usuario.ForeColor = System.Drawing.Color.Gray;
            this.txt_nombre_usuario.Location = new System.Drawing.Point(298, 92);
            this.txt_nombre_usuario.Name = "txt_nombre_usuario";
            this.txt_nombre_usuario.Size = new System.Drawing.Size(262, 31);
            this.txt_nombre_usuario.TabIndex = 16;
            this.txt_nombre_usuario.Text = "Ejemplo: warchi123";
            // 
            // txt_clave
            // 
            this.txt_clave.BackColor = System.Drawing.Color.PapayaWhip;
            this.txt_clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clave.ForeColor = System.Drawing.Color.Gray;
            this.txt_clave.Location = new System.Drawing.Point(295, 161);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.Size = new System.Drawing.Size(262, 31);
            this.txt_clave.TabIndex = 17;
            this.txt_clave.Text = "Ingrese su contraseña";
            this.txt_clave.TextChanged += new System.EventHandler(this.txtpassword_TextChanged_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("FORESTS ITALIC PERSONAL USE", 47.99999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(308, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 77);
            this.label1.TabIndex = 18;
            this.label1.Text = "POS Lyion";
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
            this.btn_iniciar_sesion.Font = new System.Drawing.Font("Swis721 BlkCn BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciar_sesion.ForeColor = System.Drawing.Color.Black;
            this.btn_iniciar_sesion.Image = ((System.Drawing.Image)(resources.GetObject("btn_iniciar_sesion.Image")));
            this.btn_iniciar_sesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_iniciar_sesion.Location = new System.Drawing.Point(295, 256);
            this.btn_iniciar_sesion.Name = "btn_iniciar_sesion";
            this.btn_iniciar_sesion.Size = new System.Drawing.Size(148, 40);
            this.btn_iniciar_sesion.TabIndex = 12;
            this.btn_iniciar_sesion.Text = "Iniciar Sesion";
            this.btn_iniciar_sesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_iniciar_sesion.TextColor = System.Drawing.Color.Black;
            this.btn_iniciar_sesion.UseVisualStyleBackColor = false;
            this.btn_iniciar_sesion.Click += new System.EventHandler(this.btn_abrir_sesion_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.Red;
            this.btn_cerrar.BackgroundColor = System.Drawing.Color.Red;
            this.btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cerrar.BorderColor = System.Drawing.Color.Black;
            this.btn_cerrar.BorderRadius = 10;
            this.btn_cerrar.BorderSize = 2;
            this.btn_cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Swis721 BlkCn BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.Black;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cerrar.Location = new System.Drawing.Point(461, 256);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(96, 40);
            this.btn_cerrar.TabIndex = 11;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cerrar.TextColor = System.Drawing.Color.Black;
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(588, 304);
            this.ControlBox = false;
            this.Controls.Add(this.txt_nombre_usuario);
            this.Controls.Add(this.lbl_nombre_usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_clave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_iniciar_sesion);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.notice);
            this.Controls.Add(this.lbl_clave);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POSLyion - Ingreso de usuario";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_nombre_usuario;
        private System.Windows.Forms.Label lbl_clave;
        private System.Windows.Forms.Label notice;
        private CustomBox.RJControls.RJButton btn_cerrar;
        private CustomBox.RJControls.RJButton btn_iniciar_sesion;
        private System.Windows.Forms.Panel panel1;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private System.Windows.Forms.TextBox txt_nombre_usuario;
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.Label label1;
    }
}