using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Eco_Community.Model
{
    public class Conexion
    {
        private readonly string cadenaConexion = @"Server=AAGF09;Database=Eco_Community; Integrated Security=True;TrustServerCertificate=True";
        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
