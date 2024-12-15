using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Categorias
    {

        private readonly CD_Categorias oCD_Categoria = new CD_Categorias();

        public int Crear(Categorias oCategoria, out string mensaje)
        {
            mensaje = string.Empty;
            if (oCategoria.Descripcion == "")
            {
                mensaje += "Es necesario la descripción de la categoría.\n";
            }
            return mensaje != string.Empty ? 0 : oCD_Categoria.Crear(oCategoria, out mensaje);
        }

        public List<Categorias> Leer()
        {
            return oCD_Categoria.Leer();
        }

        public bool Modificar(Categorias oCategoria, out string mensaje)
        {
            mensaje = string.Empty;
            if (oCategoria.Descripcion == "")
            {
                mensaje += "Es necesario la descripción de la categoría.\n";
            }
            return mensaje == string.Empty && oCD_Categoria.Modificar(oCategoria, out mensaje);
        }

        public List<Categorias> ContarProductos()
        {
            return oCD_Categoria.ContarProductos();
        }

        public bool Eliminar(Categorias oCategoria, out string mensaje)
        {
            return oCD_Categoria.Eliminar(oCategoria, out mensaje);
        }

        public bool Restaurar(Categorias oCategoria, out string mensaje)
        {
            return oCD_Categoria.Restaurar(oCategoria, out mensaje);
        }
    }
}
