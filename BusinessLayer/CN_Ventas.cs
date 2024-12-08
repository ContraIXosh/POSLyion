﻿using CapaDatos;
using CapaEntidad;
using CapaEntidad.GraficosVentas;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Ventas
    {

        private CD_Ventas oVenta = new CD_Ventas();

        public bool RestarStock(int id_producto, int cantidad)
        {
            return oVenta.RestarStock(id_producto, cantidad);
        }

        public bool SumarStock(int id_producto, int cantidad)
        {
            return oVenta.SumarStock(id_producto, cantidad);
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
