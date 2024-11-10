using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSLyion
{
<<<<<<<< HEAD:PDVLyion/formConfiguracion.cs
    public partial class formConfiguracion : Form
    {
        public formConfiguracion()
        {
            InitializeComponent();
        }
========
    public partial class formLogOut : Form
    {
        public formLogOut()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
>>>>>>>> e3e94cf8613f0271301ae551d0025610fe3b89c5:PDVLyion/formLogOut.cs
    }
}
