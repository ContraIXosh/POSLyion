namespace PDCLyion
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
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.notice = new System.Windows.Forms.Label();
            this.rjToggleButton1 = new CustomBox.RJControls.RJToggleButton();
            this.rjButton2 = new CustomBox.RJControls.RJButton();
            this.abrir_sesion = new CustomBox.RJControls.RJButton();
            this.txtpassword = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtusername = new RJCodeAdvance.RJControls.RJTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rjCircularPictureBox1 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.Transparent;
            this.lblusername.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.Gold;
            this.lblusername.Location = new System.Drawing.Point(289, 70);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(86, 20);
            this.lblusername.TabIndex = 2;
            this.lblusername.Text = "Usuario:";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblpassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.Color.Gold;
            this.lblpassword.Location = new System.Drawing.Point(289, 146);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(120, 20);
            this.lblpassword.TabIndex = 3;
            this.lblpassword.Text = "Contraseña:";
            // 
            // notice
            // 
            this.notice.AutoSize = true;
            this.notice.BackColor = System.Drawing.Color.Transparent;
            this.notice.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notice.ForeColor = System.Drawing.Color.White;
            this.notice.Location = new System.Drawing.Point(295, 18);
            this.notice.Name = "notice";
            this.notice.Size = new System.Drawing.Size(263, 32);
            this.notice.TabIndex = 4;
            this.notice.Text = "Por favor ingrese su usuario y contraseña\r\npara ingresar al sistema";
            // 
            // rjToggleButton1
            // 
            this.rjToggleButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.rjToggleButton1.AutoSize = true;
            this.rjToggleButton1.BackColor = System.Drawing.Color.Transparent;
            this.rjToggleButton1.ForeColor = System.Drawing.Color.GreenYellow;
            this.rjToggleButton1.Location = new System.Drawing.Point(293, 218);
            this.rjToggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.rjToggleButton1.Name = "rjToggleButton1";
            this.rjToggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.rjToggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.rjToggleButton1.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjToggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.rjToggleButton1.Size = new System.Drawing.Size(45, 22);
            this.rjToggleButton1.TabIndex = 10;
            this.rjToggleButton1.UseVisualStyleBackColor = false;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.Crimson;
            this.rjButton2.BackgroundColor = System.Drawing.Color.Crimson;
            this.rjButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rjButton2.BorderColor = System.Drawing.Color.Red;
            this.rjButton2.BorderRadius = 10;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Image = ((System.Drawing.Image)(resources.GetObject("rjButton2.Image")));
            this.rjButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton2.Location = new System.Drawing.Point(447, 261);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(111, 31);
            this.rjButton2.TabIndex = 11;
            this.rjButton2.Text = "Cancelar";
            this.rjButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // abrir_sesion
            // 
            this.abrir_sesion.BackColor = System.Drawing.Color.Gold;
            this.abrir_sesion.BackgroundColor = System.Drawing.Color.Gold;
            this.abrir_sesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.abrir_sesion.BorderColor = System.Drawing.Color.Red;
            this.abrir_sesion.BorderRadius = 10;
            this.abrir_sesion.BorderSize = 0;
            this.abrir_sesion.FlatAppearance.BorderSize = 0;
            this.abrir_sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abrir_sesion.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abrir_sesion.ForeColor = System.Drawing.Color.Black;
            this.abrir_sesion.Image = ((System.Drawing.Image)(resources.GetObject("abrir_sesion.Image")));
            this.abrir_sesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.abrir_sesion.Location = new System.Drawing.Point(276, 261);
            this.abrir_sesion.Name = "abrir_sesion";
            this.abrir_sesion.Size = new System.Drawing.Size(154, 31);
            this.abrir_sesion.TabIndex = 12;
            this.abrir_sesion.Text = "Iniciar Sesion";
            this.abrir_sesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.abrir_sesion.TextColor = System.Drawing.Color.Black;
            this.abrir_sesion.UseVisualStyleBackColor = false;
            this.abrir_sesion.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtpassword.BorderColor = System.Drawing.Color.Goldenrod;
            this.txtpassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtpassword.BorderRadius = 0;
            this.txtpassword.BorderSize = 2;
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpassword.Location = new System.Drawing.Point(293, 170);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtpassword.Multiline = false;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtpassword.PasswordChar = false;
            this.txtpassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtpassword.PlaceholderText = "";
            this.txtpassword.Size = new System.Drawing.Size(265, 31);
            this.txtpassword.TabIndex = 13;
            this.txtpassword.Texts = "";
            this.txtpassword.UnderlinedStyle = false;
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.SystemColors.Window;
            this.txtusername.BorderColor = System.Drawing.Color.Goldenrod;
            this.txtusername.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtusername.BorderRadius = 0;
            this.txtusername.BorderSize = 2;
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtusername.Location = new System.Drawing.Point(293, 94);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4);
            this.txtusername.Multiline = false;
            this.txtusername.Name = "txtusername";
            this.txtusername.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtusername.PasswordChar = false;
            this.txtusername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtusername.PlaceholderText = "";
            this.txtusername.Size = new System.Drawing.Size(265, 31);
            this.txtusername.TabIndex = 14;
            this.txtusername.Texts = "";
            this.txtusername.UnderlinedStyle = false;
            this.txtusername._TextChanged += new System.EventHandler(this.txtusername__TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rjCircularPictureBox1);
            this.panel1.Location = new System.Drawing.Point(-7, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 408);
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
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(19, 18);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(255, 255);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 0;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(588, 304);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.abrir_sesion);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.rjToggleButton1);
            this.Controls.Add(this.notice);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POSLyion - Ingreso de usuario";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label notice;
        private CustomBox.RJControls.RJToggleButton rjToggleButton1;
        private CustomBox.RJControls.RJButton rjButton2;
        private CustomBox.RJControls.RJButton abrir_sesion;
        private RJCodeAdvance.RJControls.RJTextBox txtpassword;
        private RJCodeAdvance.RJControls.RJTextBox txtusername;
        private System.Windows.Forms.Panel panel1;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox1;
    }
}