﻿using System;
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
        private static ToolStripMenuItem activeMenu = null;
        private static Form activeForm = null;
        private static Users oUser = new Users();
        public formVendors()
        {
            InitializeComponent();
        }


        private void dataGridView1_Resize(object sender, EventArgs e)
        {
            if (this.ClientSize.Width > 1000 && this.ClientSize.Height > 700)
            {
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            }
            else
            {
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
                            
                        }
                    }
                }
            }
        }

        private void btn_addvendedor_Click(object sender, EventArgs e)
        {
            formVendorsAdd vendoradd = new formVendorsAdd();
            vendoradd.Show();
        }
    }
}
   
