using CapaEntidad;
using CapaEntidad.GraficosVentas;
using DataLayer;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Ventas
    {

        private readonly CD_Ventas oVenta = new CD_Ventas();

        public async Task<bool> RestarStockAsync(int id_producto, int cantidad)
        {
            return await oVenta.RestarStockAsync(id_producto, cantidad);
        }

        public async Task<bool> SumarStockAsync(int id_producto, int cantidad)
        {
            return await oVenta.SumarStockAsync(id_producto, cantidad);
        }

        public bool Crear(Ventas _oVenta, DataTable VentaDetalle, out string mensaje, out int id_venta_generado)
        {
            return oVenta.Crear(_oVenta, VentaDetalle, out mensaje, out id_venta_generado);
        }

        public List<Ventas> Leer(string fecha_inicio, string fecha_fin)
        {
            return oVenta.Leer(fecha_inicio, fecha_fin);
        }

        public Ventas VerTotalVentasDesde(string fecha_inicio, int id_usuario)
        {
            return oVenta.VerTotalVentasDesde(fecha_inicio, id_usuario);
        }

        public List<DatosGraficoMensual> VentasMensuales()
        {
            return oVenta.VentasMensuales();
        }

        public List<DatosGraficoUsuarios> VentasMensualesUsuarios()
        {
            return oVenta.VentasMensualesUsuarios();
        }
    }
}
