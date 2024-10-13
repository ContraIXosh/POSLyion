using BusinessLayer;
using EntityLayer;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace PDCLyion
{
    public partial class formPermissions : Form
    {
        private static Users oUser = new Users();
        private Users Current_user = new Users();

        public formPermissions(Users oUser)
        {
            InitializeComponent();
            Current_user = oUser;
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

        private void formPermissions_Load(object sender, EventArgs e)
        {
            List<Permissions> permissions_list = new BL_Permissions().Read(Current_user.User_id);
            foreach (MaterialCheckbox checkbox in materialCheckedListBox.Items)
            {
                bool found = permissions_list.Any(c => c.Menu_name == checkbox.Name);
                if (found)
                {
                    checkbox.CheckState = CheckState.Checked;
                }
            }
        }

        private void btn_visualizarUser_Click(object sender, EventArgs e)
        {
            abrirHerencia(new formUsers());
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            abrirHerencia(new Start(oUser));
        }
    }
}
