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

        public int InsertarMisiones(MisionesEntidad misiones)
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
        public List<int> ObtenerIds_AsociadoTipoRecompensa(int id_TipoRecompensa)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            List<int> idSListaMisiones = new List<int>();
            try
            {
                string sql = @"Select Misiones.id_Mision From Misiones INNER JOIN Recompensa
                ON Recompensa.id_Mision = Misiones.id_Mision INNER JOIN TipoRecompensa ON TipoRecompensa.id_TipoRecompensa = Recompensa.id_TipoRecompensa
                where TipoRecompensa.id_TipoRecompensa = @id_Tipo";
                SqlCommand cmd = new SqlCommand(sql, cx);

                cmd.Parameters.AddWithValue("@id_Tipo", id_TipoRecompensa);

                cx.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id_Mision = reader.GetInt32(reader.GetOrdinal("id_Mision"));
                    idSListaMisiones.Add(id_Mision);
                }

                cx.Close();
                return idSListaMisiones;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la información del catálogo: " + ex.Message);
            }
        }
        public bool MisionExiste(string descripcion)
        {
            // Este es mi archivo original 
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

        public DataTable ListarMisionesData()
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();
                string sql = @"SELECT TOP 20 M.id_Mision, M.descripcion, M.puntaje, R.id_Recompensa, R.descripcionRecompensa, R.id_TipoRecompensa, T.tipoRecompensa FROM Misiones AS M INNER JOIN Recompensa AS R
                               ON M.id_Mision = R.id_Mision INNER JOIN TipoRecompensa AS T ON R.id_TipoRecompensa = T.id_TipoRecompensa  ORDER BY M.id_Mision DESC";

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar las misiones: " + ex.Message);
            }
        }
        public DataTable ListarMisiones_Tarjetas()
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();
                string sql = @"SELECT id_Mision, descripcion, puntaje FROM Misiones";

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar las misiones: " + ex.Message);
            }
        }

        public DataTable BuscarMisionPorId(int idMision)
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();
                string sql = @"SELECT M.id_Mision, M.descripcion, M.puntaje, R.id_Recompensa, R.descripcionRecompensa, R.id_TipoRecompensa, T.tipoRecompensa
                               FROM Misiones AS M
                               INNER JOIN Recompensa AS R ON M.id_Mision = R.id_Mision
                               INNER JOIN TipoRecompensa AS T ON R.id_TipoRecompensa = T.id_TipoRecompensa
                               WHERE M.id_Mision = @IdMision";

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);
                da.SelectCommand.Parameters.AddWithValue("@IdMision", idMision);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la busqueda de la Misión: " + ex.Message);
            }
        }

        //Actualizar la mision
        public bool ActualizarMisiones(MisionesEntidad mission)
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
        public bool EliminarMisiones(int idMision)
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

        public int ContarTodas_Misiones()
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
