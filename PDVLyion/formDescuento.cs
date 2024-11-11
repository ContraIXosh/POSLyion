using CapaEntidad;
using CapaEntidad.Filtros;
using CapaNegocio;
using DocumentFormat.OpenXml.Spreadsheet;
using POSLyion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDCLyion
{
    public partial class formDescuento : Form
    {
        public formDescuento()
        {
            InitializeComponent();
        }


        private void txt_busqueda_TextChanged(object sender, EventArgs e)
        {
            txt_busqueda.Select();
        }
    }
}
