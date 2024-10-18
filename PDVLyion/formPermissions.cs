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
    }
}
