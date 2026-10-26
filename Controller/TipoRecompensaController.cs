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
    public class TipoRecompensaController
    {
        Conexion conexion = new Conexion();
        public void InsertarTipoRecompensa(TipoRecompensaEntidad tipoRecompensa)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            string sql = @"INSERT INTO TipoRecompensa(tipoRecompensa) VALUES (@tipoRecompensa)";

            SqlCommand cmd = new SqlCommand(sql, cx);
            cmd.Parameters.AddWithValue(@"tipoRecompensa", tipoRecompensa.tipoRecompensa);


            cx.Open();

            cmd.ExecuteNonQuery();

            cx.Close();

        }
        public bool TipoRecompensaExiste(string tipoRecompensa)
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();

                string sql = @"SELECT COUNT(*) FROM TipoRecompensa WHERE tipoRecompensa = @tipoRecompensa";

                SqlCommand cmd = new SqlCommand(sql, cx);
                cmd.Parameters.AddWithValue("@tipoRecompensa", tipoRecompensa);

                cx.Open();
                int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                cx.Close();

                return cantidad > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al comprobar si el tipo de recompensa existe: " + ex.Message, ex);
            }
        }

        public void EliminarTipoRecompensa(int id_TipoRecompensa)
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();

                string sql = @"DELETE FROM TipoRecompensa WHERE id_TipoRecompensa = @id_TipoRecompensa";

                SqlCommand cmd = new SqlCommand(sql, cx);

                cmd.Parameters.AddWithValue("@id_TipoRecompensa", id_TipoRecompensa);

                cx.Open();
                cmd.ExecuteNonQuery();
                cx.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar Tipo Recompensa: " + ex.Message, ex);
            }

        }

        public void ActualizarTipoRecompensa(int id_TipoRecompensa, string tipoRecompensa)
        {
            SqlConnection cx = conexion.ObtenerConexion();

            string sql = @"UPDATE TipoRecompensa SET tipoRecompensa = @tipoRecompensa WHERE id_TipoRecompensa = @id_TipoRecompensa";

            SqlCommand cmd = new SqlCommand(sql, cx);

            cmd.Parameters.AddWithValue("@TipoRecompensa", tipoRecompensa);
            cmd.Parameters.AddWithValue("@id_TipoRecompensa", id_TipoRecompensa);

            cx.Open();
            cmd.ExecuteNonQuery();
            cx.Close();
        }

        public DataTable ListarTipoRecompensa()
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();

                string sql = @"SELECT TOP 20 id_TipoRecompensa,tipoRecompensa FROM TipoRecompensa ORDER BY id_TipoRecompensa DESC";

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los Tipos de Recompensa: " + ex.Message, ex);
            }
        }

        public DataTable BuscarTipoRecompensa_PorId(int id_TipoRecompensa)
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();

                string sql = @"SELECT id_TipoRecompensa,tipoRecompensa FROM TipoRecompensa WHERE id_TipoRecompensa = @id_TipoRecompensa";

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);

                da.SelectCommand.Parameters.AddWithValue("@id_TipoRecompensa", id_TipoRecompensa);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los Tipos de Recompensa: " + ex.Message, ex);
            }
        }

    }
}

