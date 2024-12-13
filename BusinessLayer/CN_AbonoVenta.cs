using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_AbonoVenta
    {
        private readonly CD_AbonoVenta oAbonoVenta = new CD_AbonoVenta();

        public bool Crear(Abono_ventas abonoVenta, out string mensaje, out int id_abono_generado)
        {
            return oAbonoVenta.Crear(abonoVenta, out mensaje, out id_abono_generado);
        }

        public List<Abono_ventas> Leer()
        {
            return oAbonoVenta.Leer();
        }
    }
}
