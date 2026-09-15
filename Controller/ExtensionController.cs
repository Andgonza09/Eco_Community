using Eco_Community.Model;
using Microsoft.Data.SqlClient;
using Model.Eco_Community;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ExtensionController
    {
        Conexion conexion = new Conexion();

        public void Insert(ExtensionEntidad extension)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            string sql = @"INSERT INTO Extension(tipo_Extension) VALUES (@tipo_Extension)";

            SqlCommand cmd = new SqlCommand(sql, cx);
            cmd.Parameters.AddWithValue(@"tipo_Extension", extension.tipo_Extension);


            cx.Open();

            cmd.ExecuteNonQuery();

            cx.Close();
        }
    }
}
