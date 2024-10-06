using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using BusinessLayer;

namespace PDCLyion
{
    public partial class formVendors : Form
    {
        public formVendors()
        {
            InitializeComponent();
        }


        private void abrirHerencia(object formhija)
        {
            if (this.panel_main.Controls.Count > 0)
            {
                this.panel_main.Controls.RemoveAt(0);
                Form fh = formhija as Form;
                fh.TopLevel = false; //dependencia
                fh.Dock = DockStyle.Fill;
                fh.FormBorderStyle = FormBorderStyle.None;
                this.panel_main.Controls.Add(fh);
                this.panel_main.Tag = fh;
                fh.BringToFront();
                this.panel_main.Refresh();
                fh.Show();

            }
        }
        private void rjButton2_Click(object sender, EventArgs e)
        {
            
                   abrirHerencia(new formSales());

        }

        private void rjButton5_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            abrirHerencia(new formVendors2());
        }

        private void dataGridView1_Resize(object sender, EventArgs e)
        {
            if (this.ClientSize.Width > 1000 && this.ClientSize.Height > 700)
            {
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                panel_grid.Left = this.ClientSize.Width - panel_grid.Width;
                panel_footer.Left = this.ClientSize.Width - panel_footer.Width;
                btn_back.Width = 150; 
                btn_back.Left = this.ClientSize.Width - btn_back.Width; 
            }
            else
            {
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                panel_grid.Left = this.ClientSize.Width - panel_grid.Width;
                panel_footer.Left = this.ClientSize.Width - panel_footer.Width;
                btn_back.Left = this.ClientSize.Width - btn_back.Width;
            }
        }

        private void formVendors_Load(object sender, EventArgs e)
        {
            List<Vendors> vendors_list = new BL_Vendors().ListAll();
            foreach (Vendors vendor in vendors_list)
            {
                grid_proveedores.Rows.Add(new object[]
                {
                    vendor.Vendor_id,
                    vendor.Cuit,
                    vendor.Company_name,
                    vendor.Email,
                    vendor.Phone,
                    vendor.State == true ? "Activo" : "Inactivo",
                    vendor.State == true ? 1 : 0
                }); 
            }
        }

        private void panel_update_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grid_proveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (grid_proveedores.Columns[e.ColumnIndex].Name == "btn_editar")
            {
                if (index >= 0)
                {
                    Vendors vendor = new Vendors()
                    {
                        Vendor_id = Convert.ToInt32(grid_proveedores.Rows[index].Cells["vendor_id"].Value),
                        Cuit = grid_proveedores.Rows[index].Cells["cuit"].Value.ToString(),
                        Company_name = grid_proveedores.Rows[index].Cells["company_name"].Value.ToString(),
                        Email = grid_proveedores.Rows[index].Cells["email"].Value.ToString(),
                        Phone = grid_proveedores.Rows[index].Cells["phone"].Value.ToString(),
                        State = Convert.ToBoolean(grid_proveedores.Rows[index].Cells["state_value"].Value)
                    };
                    abrirHerencia(new formVendors2(vendor));
                }
            }
            else if (grid_proveedores.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {
                if (MessageBox.Show("¿Desea eliminar el proveedor?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (index >= 0)
                    {
                        string message = string.Empty;
                        Vendors vendor = new Vendors()
                        {
                            Vendor_id = Convert.ToInt32(grid_proveedores.Rows[index].Cells["vendor_id"].Value)
                        };
                        bool result = new BL_Vendors().Delete(vendor, out message);
                        if (!result)
                        {
                            MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("Proveedor eliminado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            abrirHerencia(new formVendors());
                        }
                    }
                }
            }
        }
    }
}
   
