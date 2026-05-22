using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Conexion
    {
        private readonly string stringConexion = ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString;

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(stringConexion);
        }
    }
}
