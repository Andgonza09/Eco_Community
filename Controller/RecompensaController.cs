using Eco_Community.Model;
using Microsoft.Data.SqlClient;
using Model.Eco_Community;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class RecompensaController
    {
        Conexion conexion = new Conexion();

        private List<RecompensaEntidad> rewards = new List<RecompensaEntidad>();

        public int Insert(RecompensaEntidad recompensa, int id_Mision, int id_TipoRecompensa)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            string sql = @"INSERT INTO Recompensa(descripcionRecompensa, id_Mision, id_TipoRecompensa) OUTPUT INSERTED.id_Recompensa VALUES (@descripcionRecompensa,@id_Mision,@id_TipoRecompensa)";

            SqlCommand cmd = new SqlCommand(sql, cx);

            cmd.Parameters.AddWithValue("@descripcionRecompensa", recompensa.descripcionRecompensa);
            cmd.Parameters.AddWithValue("@id_Mision", id_Mision);
            cmd.Parameters.AddWithValue("@id_TipoRecompensa", id_TipoRecompensa);

            cx.Open();
            int id_Recompensa = Convert.ToInt32(cmd.ExecuteScalar());
            cx.Close();

            return id_Recompensa;
        }
        public bool RewardExist(string descripcion_Recompensa)
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();
                string sql = @"SELECT COUNT(*) FROM Recompensa WHERE descripcionRecompensa = @rewardDescription";

                SqlCommand cmd = new SqlCommand(sql, cx);
                cmd.Parameters.AddWithValue("@rewardDescription", descripcion_Recompensa);

                cx.Open();
                object? result = cmd.ExecuteScalar();
                cx.Close();
                int quantity = Convert.ToInt32(result);
                return quantity > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al comprobar si la recompensa existe: " + ex.Message);
            }
        }

        public bool UpdateReward(RecompensaEntidad recompensa)
        {
            try
            {
                using (SqlConnection cx = conexion.ObtenerConexion())
                {
                    string sql = @"UPDATE Recompensa SET descripcionRecompensa = @descripcionRecompensa,id_Mision = @id_Mision,id_TipoRecompensa = @id_TipoRecompensa WHERE id_Recompensa = @id_Recompensa";

                    SqlCommand cmd = new SqlCommand(sql, cx);
                    cmd.Parameters.AddWithValue("@descripcionRecompensa", recompensa.descripcionRecompensa);
                    cmd.Parameters.AddWithValue("@id_Mision", recompensa.id_Mision);
                    cmd.Parameters.AddWithValue("@id_TipoRecompensa", recompensa.id_TipoRecompensa);
                    cmd.Parameters.AddWithValue("@id_Recompensa", recompensa.id_Recompensa);

                    cx.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la recompensa: " + ex.Message);
            }
        }

        public bool DeleteReward(int id_Mision)
        {
            try
            {
                using (SqlConnection cx = conexion.ObtenerConexion())
                {
                    string sql = @"DELETE FROM Recompensa WHERE id_Mision = @id_Mision";

                    SqlCommand cmd = new SqlCommand(sql, cx);
                    cmd.Parameters.AddWithValue("@id_Mision", id_Mision);

                    cx.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la recompensa: " + ex.Message);
            }
        }
    }
}
