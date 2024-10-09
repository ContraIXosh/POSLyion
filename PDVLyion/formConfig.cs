using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDCLyion
{
    public partial class formConfig : Form
    {

        private static Users oUser = new Users();

        public formConfig(Users user)
        {
            InitializeComponent();
            oUser = user;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
