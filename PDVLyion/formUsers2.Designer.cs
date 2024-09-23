namespace PDCLyion
{
    partial class formUsers2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUsers2));
            this.panel_main = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_visualizarUser = new RJCodeAdvance.RJControls.RJButton();
            this.rjButton2 = new RJCodeAdvance.RJControls.RJButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_addUser = new RJCodeAdvance.RJControls.RJButton();
            this.data_idUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_nameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_ApellidoUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_dniUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_telUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataSet1 = new System.Data.DataSet();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.AutoSize = true;
            this.panel_main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_main.Controls.Add(this.dataGridView1);
            this.panel_main.Controls.Add(this.btn_visualizarUser);
            this.panel_main.Controls.Add(this.rjButton2);
            this.panel_main.Controls.Add(this.panel3);
            this.panel_main.Controls.Add(this.btn_addUser);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(966, 498);
            this.panel_main.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data_idUser,
            this.data_nameUser,
            this.data_ApellidoUser,
            this.data_dniUser,
            this.data_telUser,
            this.btn_eliminar,
            this.btn_editar});
            this.dataGridView1.Location = new System.Drawing.Point(248, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(695, 377);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_visualizarUser
            // 
            this.btn_visualizarUser.BackColor = System.Drawing.Color.Transparent;
            this.btn_visualizarUser.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_visualizarUser.BorderColor = System.Drawing.Color.Gold;
            this.btn_visualizarUser.BorderRadius = 7;
            this.btn_visualizarUser.BorderSize = 2;
            this.btn_visualizarUser.FlatAppearance.BorderSize = 0;
            this.btn_visualizarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_visualizarUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_visualizarUser.ForeColor = System.Drawing.Color.Gold;
            this.btn_visualizarUser.Image = ((System.Drawing.Image)(resources.GetObject("btn_visualizarUser.Image")));
            this.btn_visualizarUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_visualizarUser.Location = new System.Drawing.Point(12, 58);
            this.btn_visualizarUser.Name = "btn_visualizarUser";
            this.btn_visualizarUser.Size = new System.Drawing.Size(220, 50);
            this.btn_visualizarUser.TabIndex = 8;
            this.btn_visualizarUser.Text = "VISUALIZAR USUARIO";
            this.btn_visualizarUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_visualizarUser.TextColor = System.Drawing.Color.Gold;
            this.btn_visualizarUser.UseVisualStyleBackColor = false;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.Transparent;
            this.rjButton2.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton2.BorderColor = System.Drawing.Color.Chartreuse;
            this.rjButton2.BorderRadius = 7;
            this.rjButton2.BorderSize = 2;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.Lime;
            this.rjButton2.Location = new System.Drawing.Point(813, 398);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(150, 40);
            this.rjButton2.TabIndex = 5;
            this.rjButton2.Text = "Regresar";
            this.rjButton2.TextColor = System.Drawing.Color.Lime;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
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
            // btn_addUser
            // 
            this.btn_addUser.BackColor = System.Drawing.Color.Transparent;
            this.btn_addUser.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_addUser.BorderColor = System.Drawing.Color.Gold;
            this.btn_addUser.BorderRadius = 7;
            this.btn_addUser.BorderSize = 2;
            this.btn_addUser.FlatAppearance.BorderSize = 0;
            this.btn_addUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addUser.ForeColor = System.Drawing.Color.Gold;
            this.btn_addUser.Image = ((System.Drawing.Image)(resources.GetObject("btn_addUser.Image")));
            this.btn_addUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addUser.Location = new System.Drawing.Point(12, 12);
            this.btn_addUser.Name = "btn_addUser";
            this.btn_addUser.Size = new System.Drawing.Size(220, 40);
            this.btn_addUser.TabIndex = 0;
            this.btn_addUser.Text = "AGREGAR USUARIO";
            this.btn_addUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addUser.TextColor = System.Drawing.Color.Gold;
            this.btn_addUser.UseVisualStyleBackColor = false;
            this.btn_addUser.Click += new System.EventHandler(this.btn_addUser_Click);
            // 
            // data_idUser
            // 
            this.data_idUser.FillWeight = 50F;
            this.data_idUser.HeaderText = "ID";
            this.data_idUser.Name = "data_idUser";
            this.data_idUser.Width = 50;
            // 
            // data_nameUser
            // 
            this.data_nameUser.HeaderText = "NOMBRE";
            this.data_nameUser.Name = "data_nameUser";
            // 
            // data_ApellidoUser
            // 
            this.data_ApellidoUser.HeaderText = "APELLIDO";
            this.data_ApellidoUser.Name = "data_ApellidoUser";
            // 
            // data_dniUser
            // 
            this.data_dniUser.HeaderText = "DNI";
            this.data_dniUser.Name = "data_dniUser";
            // 
            // data_telUser
            // 
            this.data_telUser.HeaderText = "TELEFONO";
            this.data_telUser.Name = "data_telUser";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.btn_eliminar.FillWeight = 60F;
            this.btn_eliminar.HeaderText = "ELIMINAR";
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Width = 64;
            // 
            // btn_editar
            // 
            this.btn_editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.btn_editar.FillWeight = 50F;
            this.btn_editar.HeaderText = "EDITAR";
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btn_editar.Width = 72;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // formUsers2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 498);
            this.Controls.Add(this.panel_main);
            this.Name = "formUsers2";
            this.Text = "formUsers2";
            this.panel_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private RJCodeAdvance.RJControls.RJButton btn_visualizarUser;
        private RJCodeAdvance.RJControls.RJButton rjButton2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJButton btn_addUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_idUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_nameUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_ApellidoUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_dniUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_telUser;
        private System.Windows.Forms.DataGridViewButtonColumn btn_eliminar;
        private System.Windows.Forms.DataGridViewButtonColumn btn_editar;
        private System.Data.DataSet dataSet1;
    }
}