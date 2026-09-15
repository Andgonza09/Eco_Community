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

        public int Insert(RecompensaEntidad recompensa)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            string sql = @"INSERT INTO Recompensa(descripcionRecompensa,id_Mision,id_TipoRecompensa) VALUES (@descripcionRecompensa,@id_Mision,@id_TipoRecompensa)";

            SqlCommand cmd = new SqlCommand(sql, cx);
            cmd.Parameters.AddWithValue(@"descripcionRecompensa", recompensa.descripcionRecompensa);
            cmd.Parameters.AddWithValue(@"id_Mision", recompensa.id_Mision);
            cmd.Parameters.AddWithValue(@"id_TipoRecompensa", recompensa.id_TipoRecompensa);

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

                object? result = cmd.ExecuteScalar(); 
                int quantity = Convert.ToInt32(result);
                return quantity > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al comprobar si la recompensa existe: " + ex.Message);
            }
        }
    }
}
