using Eco_Community.Model;
using Microsoft.Data.SqlClient;
using Model.Eco_Community;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;

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
            cmd.Parameters.AddWithValue("@id_InformacionSitio", id_InformacionSitio);
            cmd.Parameters.AddWithValue("@id_Usuario", id_Usuario);

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
        public void DeleteUserInformation(long id_Usuario)
        {
            SqlConnection cx = conexion.ObtenerConexion();

            string sql = @"DELETE FROM DetalleSitios 
                   WHERE id_Usuario = @id_Usuario";

            SqlCommand cmd = new SqlCommand(sql, cx);
            cmd.Parameters.AddWithValue("@id_Usuario", id_Usuario);

            cx.Open();
            cmd.ExecuteNonQuery();
            cx.Close();
        }
        public int CountSitesAproved(long id_Usuario)
        {

            SqlConnection cx = conexion.ObtenerConexion();
            string sql = @"SELECT COUNT(*) FROM DetalleSitios INNER JOIN Solicitudes ON Solicitudes.id_UsuarioEstandar = DetalleSitios.id_Usuario
            AND Solicitudes.id_InformacionSitio = DetalleSitios.id_InformacionSitio WHERE Solicitudes.estado_Solicitud = 'Aprobada'
            AND DetalleSitios.id_Usuario = @id_Usuario";

            SqlCommand cmd = new SqlCommand(sql, cx);
            cmd.Parameters.AddWithValue("@id_Usuario", id_Usuario);
            cx.Open();
            
            int totalSitiosAprobados = Convert.ToInt32(cmd.ExecuteScalar());
            
            cx.Close();

            return totalSitiosAprobados;
        }
        public int CountAllSitesAproved()
        {
            SqlConnection cx = conexion.ObtenerConexion();
            string sql = @"SELECT COUNT(DISTINCT DetalleSitios.id_InformacionSitio) FROM DetalleSitios
            INNER JOIN Solicitudes ON Solicitudes.id_InformacionSitio = DetalleSitios.id_InformacionSitio
            WHERE Solicitudes.estado_Solicitud = 'Aprobada'";

            SqlCommand cmd = new SqlCommand(sql, cx);
            cx.Open();
            int totalSitiosAprobados = Convert.ToInt32(cmd.ExecuteScalar());
            cx.Close();

            return totalSitiosAprobados;
        }

    }
}
