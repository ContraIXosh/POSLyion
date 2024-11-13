using System;
using System.Collections.Generic;
using CapaDatos;
using CapaEntidad;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocio
{
    public class CN_Compras
    {
        private CD_Compras oCompra = new CD_Compras();

        public bool Crear(Compras _oCompra, DataTable CompraDetalle, out string mensaje)
        {
            return oCompra.Crear(_oCompra, CompraDetalle, out mensaje);
        }

        public List<Compras> Leer(string fecha_inicio, string fecha_fin)
        {
            return oCompra.Leer(fecha_inicio, fecha_fin);
        }
    }
}
