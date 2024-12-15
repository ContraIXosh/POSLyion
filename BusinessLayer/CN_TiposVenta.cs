using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_TiposVenta
    {
        private readonly CD_TiposVenta oTiposVenta = new CD_TiposVenta();

        public List<Tipo_Venta> Leer()
        {
            return oTiposVenta.Leer();
        }
    }
}
