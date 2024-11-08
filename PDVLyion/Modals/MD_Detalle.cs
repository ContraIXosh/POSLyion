using System;
using CapaEntidad;
using CapaNegocio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDCLyion.Modals
{
    public partial class MD_Detalle : Form
    {

        private List<ReportesDetalle> _lista_detalle = new List<ReportesDetalle>();

        public MD_Detalle(int id, int caso)
        {
            InitializeComponent();
            if(caso == 1)
            {
                _lista_detalle = new CN_Reportes().Compra_Detalle(id);
            }
            else if(caso == 2)
            {
                _lista_detalle = new CN_Reportes().Venta_Detalle(id);
            }            
        }

        private void MD_ComprasDetalle_Load(object sender, EventArgs e)
        {
            foreach(ReportesDetalle compra_detalle in _lista_detalle)
            {
                dgv_detalle.Rows.Add(new object[]
                {
                    compra_detalle.Codigo_barras,
                    compra_detalle.Nombre_producto,
                    compra_detalle.Nombre_categoria,
                    compra_detalle.Precio_unitario,
                    compra_detalle.Cantidad,
                    compra_detalle.Subtotal
                });
            }
        }
    }
}
