using CapaDatos;
using CapaEntidad;
using CapaEntidad.GraficosVentas;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocio
{
    public class CN_Compras
    {
        private readonly CD_Compras oCompra = new CD_Compras();

        public bool Crear(Compras _oCompra, DataTable CompraDetalle, out string mensaje)
        {
            return oCompra.Crear(_oCompra, CompraDetalle, out mensaje);
        }

        public List<Compras> Leer(string fecha_inicio, string fecha_fin)
        {
            return oCompra.Leer(fecha_inicio, fecha_fin);
        }

        public List<DatosGraficoMensual> ComprasMensuales()
        {
            return oCompra.ComprasMensuales();
        }

        public List<DatosGraficoUsuarios> ComprasMensualesUsuarios()
        {
            return oCompra.ComprasMensualesUsuarios();
        }
    }
}
