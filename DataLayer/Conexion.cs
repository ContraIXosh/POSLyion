using System.Configuration;

namespace CapaDatos
{
    public class Conexion
    {
        public static string CadenaConexion = ConfigurationManager.ConnectionStrings["CadenaConexion"].ToString();
    }
}
