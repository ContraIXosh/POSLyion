using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Productos
    {
        private CD_Productos oCD_Producto = new CD_Productos();

        public int Create(Productos oProducto, out string mensaje)
        {
            mensaje = string.Empty;
            if (oProducto.Codigo_barras == "")
            {
                mensaje += "Es necesario el código de barras.\n";
            }
            if (oProducto.Descripcion == "")
            {
                mensaje += "Es necesario la descripción del producto.\n";
            }
            if (oProducto.Precio_costo == 0)
            {
                mensaje += "Es necesario el costo del producto.\n";
            }
            if (oProducto.Precio_venta == 0)
            {
                mensaje += "Es necesario el precio de venta del producto.\n";
            }
            if (mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return oCD_Producto.Crear(oProducto, out mensaje);
            }
        }

        public List<Productos> Leer()
        {
            return oCD_Producto.Leer();
        }

        public DataTable Buscar(string texto)
        {
            return oCD_Producto.Buscar(texto);
        }

        public bool Modificar(Productos oProducto, out string mensaje)
        {
            mensaje = string.Empty;
            if (oProducto.Codigo_barras == "")
            {
                mensaje += "Es necesario el código de barras.\n";
            }
            if (oProducto.Descripcion == "")
            {
                mensaje += "Es necesario la descripción del producto.\n";
            }
            if (oProducto.Precio_costo == 0)
            {
                mensaje += "Es necesario el costo del producto.\n";
            }
            if (oProducto.Precio_venta == 0)
            {
                mensaje += "Es necesario el precio de venta del producto.\n";
            }
            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return oCD_Producto.Modificar(oProducto, out mensaje);
            }
        }

        public bool Eliminar(Productos oProducto, out string mensaje)
        {
            return oCD_Producto.Eliminar(oProducto, out mensaje);
        }

        public bool Restaurar(Productos oProducto, out string mensaje)
        {
            return oCD_Producto.Restaurar(oProducto, out mensaje);
        }
    }
}
