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
        public void DeleteByUser(long id_Usuario)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            try
            {
                string sql = @"DELETE FROM Detalle_Mision WHERE id_Usuario = @id_Usuario";
                SqlCommand cmd = new SqlCommand(sql, cx);

                cmd.Parameters.AddWithValue("@id_Usuario", id_Usuario);
                cx.Open();
                cmd.ExecuteNonQuery();
                cx.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Error al realizar la eliminación del detalle de la misión: " + ex.Message);
            }
        }
        public void DeleteByMission(int id_Mision)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            try
            {
                string sql = @"DELETE FROM Detalle_Mision WHERE id_Mision = @id_Mision";
                SqlCommand cmd = new SqlCommand(sql, cx);

                cmd.Parameters.AddWithValue("@id_Mision", id_Mision);
                cx.Open();
                cmd.ExecuteNonQuery();
                cx.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Error al realizar la eliminación del detalle de la misión: " + ex.Message);
            }
        }
        public bool MisionCompletada(long idUsuario, int idMision)
        {
            using SqlConnection cx = conexion.ObtenerConexion();

            string sql = @" SELECT COUNT(*) FROM Detalle_Mision WHERE id_Usuario = @idUsuario AND id_Mision = @idMision";

            using SqlCommand cmd = new SqlCommand(sql, cx);

            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
            cmd.Parameters.AddWithValue("@idMision", idMision);

            cx.Open();

            int cantidad = Convert.ToInt32(cmd.ExecuteScalar());

            return cantidad > 0;
        }
    }
}
