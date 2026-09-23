using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eco_Community.Model;
using Microsoft.Data.SqlClient;
using Model.Eco_Community;

namespace Controller
{
    public class DetalleSitiosController
    {
        Conexion conexion = new Conexion();

        public void Insert(DetalleSitiosEntidad detallesitios, long id_InformacionSitio, long id_Usuario)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            string sql = @"INSERT INTO DetalleSitios(id_InformacionSitio,id_Usuario) VALUES (@id_InformacionSitio,@id_Usuario)";

            SqlCommand cmd = new SqlCommand(sql, cx);
            cmd.Parameters.AddWithValue(@"id_InformacionSitio", id_InformacionSitio);
            cmd.Parameters.AddWithValue(@"id_Usuario", id_Usuario);


            cx.Open();
            cmd.ExecuteNonQuery();
            cx.Close();

        }
        public void Delete(long id_InformacionSitio)
        {
            SqlConnection cx = conexion.ObtenerConexion();

            string sql = @"DELETE FROM DetalleSitios 
                   WHERE id_InformacionSitio = @id_InformacionSitio";

            SqlCommand cmd = new SqlCommand(sql, cx);
            cmd.Parameters.AddWithValue("@id_InformacionSitio", id_InformacionSitio);

            cx.Open();
            cmd.ExecuteNonQuery();
            cx.Close();
        }

    }
}
