using CapaNegocio;
using CapaEntidad;
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

namespace POSLyion
{
    public partial class formPermisos : Form
    {
        private static Usuarios oUsuario = new Usuarios();
        private Usuarios Usuario_actual = new Usuarios();

        public formPermisos(Usuarios oUsuario)
        {
            InitializeComponent();
            Usuario_actual = oUsuario;
        }

        private void formPermisos_Load(object sender, EventArgs e)
        {
            List<Permisos> lista_permisos = new CN_Permisos().Leer(Usuario_actual.Id_usuario);
            foreach (MaterialCheckbox checkbox in materialCheckedListBox.Items)
            {
                bool found = lista_permisos.Any(c => c.Nombre_menu == checkbox.Name);
                if (found)
                {
                    checkbox.CheckState = CheckState.Checked;
                }
            }
        }
    }
}
