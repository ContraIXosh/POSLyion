using CapaEntidad;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_CierreCaja
    {

        private CD_CierreCaja oCD_CierreCaja = new CD_CierreCaja();

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
