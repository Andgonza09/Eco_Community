using Eco_Community.Model;
using Microsoft.Data.SqlClient;
using Model.Eco_Community;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Markup;

namespace Controller
{
    public class MisionesController
    {
        Conexion conexion = new Conexion();

        public int Insert(MisionesEntidad misiones)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            try
            {
                string sql = @"INSERT INTO Misiones(descripcion,puntaje) OUTPUT INSERTED.id_Mision VALUES (@descripcion,@puntaje)";

                SqlCommand cmd = new SqlCommand(sql, cx);
                cmd.Parameters.AddWithValue("@descripcion", misiones.descripcion);
                cmd.Parameters.AddWithValue("@puntaje", misiones.puntaje);

                cx.Open();
                int id_Mision = Convert.ToInt32(cmd.ExecuteScalar());
                cx.Close();
                return id_Mision;
            }
            catch (Exception ex)
            {
                if (cx.State == System.Data.ConnectionState.Open)
                    cx.Close();

                throw new Exception(".Error al agregar la mision:" + ex.Message);
            }


        }
        public bool MissionExists(string descripcion)
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();

                string sql = @"SELECT COUNT(*) FROM Misiones WHERE descripcion = @MissionDescription";

                SqlCommand cmd = new SqlCommand(sql, cx);
                cmd.Parameters.AddWithValue("@MissionDescription", descripcion);

                cx.Open();
                object? result = cmd.ExecuteScalar();
                cx.Close();
                int quantity = Convert.ToInt32(result);

                return quantity > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al comprobar si la misión existe: " + ex.Message);
            }
        }

        //Mostrar todas las misiones 
        public List<(MisionesEntidad, string, string)> ViewAllMissions()
        {
            List<(MisionesEntidad, string, string)> missionList = new List<(MisionesEntidad, string, string)>();

            SqlConnection cx = conexion.ObtenerConexion();
            try
            {
                string sql = "Select M.id_Mision, M.descripcion, M.puntaje, R.descripcionRecompensa, T.tipoRecompensa " +
                    "from Misiones As M INNER JOIN Recompensa AS R ON M.id_Mision = R.id_Mision INNER JOIN TipoRecompensa AS T " +
                    "ON R.id_TipoRecompensa = T.id_TipoRecompensa";

                SqlCommand cmd = new SqlCommand(sql, cx);

                cx.Open();
                SqlDataReader result = cmd.ExecuteReader();

                while (result.Read())
                {
                    string descripcionRecompensa = result["descripcionRecompensa"].ToString();
                    string tipoRecompensa = result["tipoRecompensa"].ToString();

                    MisionesEntidad mission = new MisionesEntidad();
                    mission.id_Mision = Convert.ToInt32(result["id_Mision"]);
                    mission.descripcion = result["descripcion"].ToString();
                    mission.puntaje = Convert.ToInt32(result["puntaje"]);

                    missionList.Add((mission, descripcionRecompensa, tipoRecompensa));
                }

                result.Close();
                cx.Close();

                return missionList;
            }
            catch (Exception ex)
            {
                if (cx.State == System.Data.ConnectionState.Open)
                    cx.Close();

                throw new Exception("Error al mostrar las misiones: " + ex.Message);
            }
        }

        //Buscar mision por ID
        public List<(MisionesEntidad, string, string)> FindById(int idMision)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            List<(MisionesEntidad, string, string)> ListaMisiones = new List<(MisionesEntidad, string, string)>();
            try
            {
                string sql =  @"SELECT M.id_Mision, M.descripcion, M.puntaje, R.descripcionRecompensa, T.tipoRecompensa
                        FROM Misiones AS M INNER JOIN Recompensa AS R ON M.id_Mision = R.id_Mision INNER JOIN TipoRecompensa AS T
                        ON R.id_TipoRecompensa = T.id_TipoRecompensa WHERE M.id_Mision = @IdMision"; 

                SqlCommand cmd = new SqlCommand(sql, cx);

                cmd.Parameters.AddWithValue("@IdMision", idMision);
                cx.Open();
                using SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string descripcionRecompensa = reader.GetString(reader.GetOrdinal("descripcionRecompensa"));
                    string tipoRecompensa = reader.GetString(reader.GetOrdinal("tipoRecompensa"));

                    MisionesEntidad misiones = new MisionesEntidad()
                    {

                        id_Mision = Convert.ToInt32(reader["id_Mision"]),
                        descripcion = reader["descripcion"].ToString() ?? string.Empty,
                        puntaje = Convert.ToInt32(reader["puntaje"])

                    };
                    ListaMisiones.Add((misiones, descripcionRecompensa, tipoRecompensa));
                }
                cx.Close();
                return ListaMisiones;

            }
            catch (Exception ex)
            {
                throw new Exception("Error en la busqueda de la Misión: " + ex.Message);
            }
        }

        //Actualizar la mision
        public bool UpdateMission(MisionesEntidad mission)
        {
            SqlConnection cx = conexion.ObtenerConexion();

            try
            {
                string sql = @"UPDATE Misiones SET descripcion = @descripcion,puntaje = @puntaje WHERE id_Mision = @id_Mision";

                SqlCommand cmd = new SqlCommand(sql, cx);

                cmd.Parameters.AddWithValue("@id_Mision", mission.id_Mision);
                cmd.Parameters.AddWithValue("@descripcion", mission.descripcion);
                cmd.Parameters.AddWithValue("@puntaje", mission.puntaje);

                cx.Open();

                int rowsAffected = cmd.ExecuteNonQuery();

                cx.Close();

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                if (cx.State == System.Data.ConnectionState.Open)
                    cx.Close();

                throw new Exception("Error al actualizar la mision: " + ex.Message);
            }
        }

        //Eliminar Mision
        public bool DeleteMission(int idMision)
        {
            SqlConnection cx = conexion.ObtenerConexion();

            try
            {
                cx.Open();

                SqlTransaction transaction = cx.BeginTransaction();

                try
                {
                    // Eliminar detalles de la misión
                    string sqlDetails = @"DELETE FROM Detalle_Mision WHERE id_Mision = @id_Mision";

                    SqlCommand cmdDetails = new SqlCommand(sqlDetails, cx, transaction);
                    cmdDetails.Parameters.AddWithValue("@id_Mision", idMision);

                    cmdDetails.ExecuteNonQuery();


                    // Eliminar recompensas de la misión
                    string sqlRewards = @"DELETE FROM Recompensa WHERE id_Mision = @id_Mision";

                    SqlCommand cmdRewards = new SqlCommand(sqlRewards, cx, transaction);

                    cmdRewards.Parameters.AddWithValue("@id_Mision", idMision);
                    cmdRewards.ExecuteNonQuery();


                    // Eliminar la misión
                    string sqlMission = @"DELETE FROM Misiones WHERE id_Mision = @id_Mision";

                    SqlCommand cmdMission = new SqlCommand(sqlMission, cx, transaction);

                    cmdMission.Parameters.AddWithValue("@id_Mision", idMision);

                    int rowsAffected = cmdMission.ExecuteNonQuery();
                    transaction.Commit();

                    return rowsAffected > 0;
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la misión: " + ex.Message);
            }
            finally
            {
                if (cx.State == System.Data.ConnectionState.Open)
                {
                    cx.Close();
                }
            }
        }
        public int CountAllMission()
        {
            SqlConnection cx = conexion.ObtenerConexion();
            try
            {
                string sql = @"SELECT COUNT(*) FROM Misiones";

                SqlCommand cmd = new SqlCommand(sql, cx);

                cx.Open();
                int total = Convert.ToInt32(cmd.ExecuteScalar());
                cx.Close();

                return total;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el conteo de solicitudes: " + ex.Message);
            }
        }
    }
}
