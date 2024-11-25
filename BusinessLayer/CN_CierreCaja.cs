using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_CierreCaja
    {

        private readonly CD_CierreCaja oCD_CierreCaja = new CD_CierreCaja();

        public int Crear(CierreCaja oCierreCaja, out string mensaje)
        {
            return oCD_CierreCaja.Crear(oCierreCaja, out mensaje);
        }

        public List<CierreCaja> Leer()
        {
            return oCD_CierreCaja.Leer();
        }
    }
}
