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
    public class TipoRecompensaController
    {
        Conexion conexion = new Conexion();
        public void Insert(TipoRecompensaEntidad roles)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            string sql = @"INSERT INTO TipoRecompensa(tipoRecompensa) VALUES (@tipoRecompensa)";

            SqlCommand cmd = new SqlCommand(sql, cx);
            cmd.Parameters.AddWithValue(@"tipoRecompensa", roles.tipoRecompensa);


            cx.Open();

            cmd.ExecuteNonQuery();

            cx.Close();

        }
    }
}

