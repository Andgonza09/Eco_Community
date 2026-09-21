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
    public class Detalle_MisionController
    {
        Conexion conexion = new Conexion();
        public void Insert(Detalle_MisionEntidad detalle_mision)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            string sql = @"INSERT INTO Detalle_Mision(estado_Mision,id_Usuario,id_Mision) VALUES (@estado_Mision,@id_Usuario,@id_Mision)";

            SqlCommand cmd = new SqlCommand(sql, cx);
            cmd.Parameters.AddWithValue(@"estado_Mision", detalle_mision.estado_Mision);
            cmd.Parameters.AddWithValue(@"id_Usuario", detalle_mision.id_Usuario);
            cmd.Parameters.AddWithValue(@"id_Mision", detalle_mision.id_Mision);

            cx.Open();

            cmd.ExecuteNonQuery();

            cx.Close();

        }
    }
}
