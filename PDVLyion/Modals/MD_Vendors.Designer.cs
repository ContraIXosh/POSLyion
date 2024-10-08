namespace PDCLyion.Modals
{
    partial class MD_Vendors
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vendor_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.document_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vendor_id,
            this.document_number,
            this.company_name});
            this.dataGridView1.Location = new System.Drawing.Point(0, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(453, 267);
            this.dataGridView1.TabIndex = 0;
            // 
            // vendor_id
            // 
            this.vendor_id.HeaderText = "ID";
            this.vendor_id.Name = "vendor_id";
            this.vendor_id.Visible = false;
            // 
            // document_number
            // 
            this.document_number.HeaderText = "Nro. Documento";
            this.document_number.Name = "document_number";
            // 
            // company_name
            // 
            this.company_name.HeaderText = "Razon social";
            this.company_name.Name = "company_name";
            // 
            // MD_Vendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 270);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MD_Vendors";
            this.Text = " ";
            this.Load += new System.EventHandler(this.MD_Vendors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendor_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn document_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn company_name;
    }
}