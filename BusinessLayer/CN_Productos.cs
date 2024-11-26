using CapaDatos;
using CapaEntidad;
using CapaEntidad.Filtros;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocio
{
    public class CN_Productos
    {
        private readonly CD_Productos oCD_Producto = new CD_Productos();

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
            return mensaje != string.Empty ? 0 : oCD_Producto.Crear(oProducto, out mensaje);
        }

        public List<Productos> Leer(FiltrosProducto filtros)
        {
            return oCD_Producto.Leer(filtros);
        }

        public Productos BuscarUnProducto(int id)
        {
            return oCD_Producto.BuscarUnProducto(id);
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
            return mensaje == string.Empty && oCD_Producto.Modificar(oProducto, out mensaje);
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
