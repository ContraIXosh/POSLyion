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
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.notice = new System.Windows.Forms.Label();
            this.iconpicturebox_lock = new FontAwesome.Sharp.IconPictureBox();
            this.btnlogin = new FontAwesome.Sharp.IconButton();
            this.btncancel = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconpicturebox_lock)).BeginInit();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.White;
            this.txtusername.Location = new System.Drawing.Point(87, 84);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(234, 20);
            this.txtusername.TabIndex = 0;
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.White;
            this.txtpassword.Location = new System.Drawing.Point(87, 135);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(234, 20);
            this.txtpassword.TabIndex = 1;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.Transparent;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(33, 87);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(54, 13);
            this.lblusername.TabIndex = 2;
            this.lblusername.Text = "Usuario:";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(12, 138);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(75, 13);
            this.lblpassword.TabIndex = 3;
            this.lblpassword.Text = "Contraseña:";
            // 
            // notice
            // 
            this.notice.AutoSize = true;
            this.notice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.notice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notice.ForeColor = System.Drawing.Color.Black;
            this.notice.Location = new System.Drawing.Point(84, 21);
            this.notice.Name = "notice";
            this.notice.Size = new System.Drawing.Size(243, 26);
            this.notice.TabIndex = 4;
            this.notice.Text = "Por favor ingrese su usuario y contraseña\r\npara ingresar al sistema";
            // 
            // iconpicturebox_lock
            // 
            this.iconpicturebox_lock.BackColor = System.Drawing.Color.Transparent;
            this.iconpicturebox_lock.ForeColor = System.Drawing.Color.Black;
            this.iconpicturebox_lock.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconpicturebox_lock.IconColor = System.Drawing.Color.Black;
            this.iconpicturebox_lock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconpicturebox_lock.IconSize = 49;
            this.iconpicturebox_lock.Location = new System.Drawing.Point(26, 12);
            this.iconpicturebox_lock.Name = "iconpicturebox_lock";
            this.iconpicturebox_lock.Size = new System.Drawing.Size(52, 49);
            this.iconpicturebox_lock.TabIndex = 5;
            this.iconpicturebox_lock.TabStop = false;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnlogin.IconColor = System.Drawing.Color.Black;
            this.btnlogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlogin.IconSize = 30;
            this.btnlogin.Location = new System.Drawing.Point(47, 182);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(121, 42);
            this.btnlogin.TabIndex = 7;
            this.btnlogin.Text = "Ingresar";
            this.btnlogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(53)))), ((int)(((byte)(17)))));
            this.btncancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
            this.btncancel.IconColor = System.Drawing.Color.Black;
            this.btncancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncancel.IconSize = 30;
            this.btncancel.Location = new System.Drawing.Point(240, 182);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(121, 42);
            this.btncancel.TabIndex = 8;
            this.btncancel.Text = "Cancelar";
            this.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PDCLyion.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(411, 227);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.iconpicturebox_lock);
            this.Controls.Add(this.notice);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POSLyion - Ingreso de usuario";
            ((System.ComponentModel.ISupportInitialize)(this.iconpicturebox_lock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label notice;
        private FontAwesome.Sharp.IconPictureBox iconpicturebox_lock;
        private FontAwesome.Sharp.IconButton btnlogin;
        private FontAwesome.Sharp.IconButton btncancel;
    }
}