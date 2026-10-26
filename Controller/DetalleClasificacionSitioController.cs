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
    public class DetalleClasificacionSitioController
    {
        Conexion conexion = new Conexion();
        public void InsertarDetallesClasificacion(long id_InformacionSitio, List<int> idS_CatalogoResiduos)
        {
            SqlConnection cx = conexion.ObtenerConexion();

            try
            {
                cx.Open();

                foreach (int idCatalogoResiduo in idS_CatalogoResiduos)
                {
                    string sql = @"INSERT INTO DetalleClasificacionSitio (id_InformacionSitio, id_CatalogoResiduos) VALUES (@id_InformacionSitio, @id_CatalogoResiduos)";

                    SqlCommand cmd = new SqlCommand(sql, cx);

                    cmd.Parameters.AddWithValue("@id_InformacionSitio", id_InformacionSitio);
                    cmd.Parameters.AddWithValue("@id_CatalogoResiduos", idCatalogoResiduo);

                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                cx.Close();
            }

        }
        public List<int> ObtenerIdsCatalogoResiduos_PorIdInformacionSitio(long id_informacionSitio)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            List<int> idS_CatalogoResiduos = new List<int>();
            try
            {
                string sql = @"SELECT id_CatalogoResiduos FROM DetalleClasificacionSitio WHERE id_InformacionSitio = @id_InformacionSitio";
                SqlCommand cmd = new SqlCommand(sql, cx);

                cmd.Parameters.AddWithValue("@id_InformacionSitio", id_informacionSitio);

                cx.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id_Catalogo = reader.GetInt32(reader.GetOrdinal("id_CatalogoResiduos"));
                    idS_CatalogoResiduos.Add(id_Catalogo);
                }

                cx.Close();
                return idS_CatalogoResiduos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la información del catálogo: " + ex.Message);
            }
        }
        public void EliminarDetallesClasificacion_PorIdUsuario(long id_Usuario)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            try
            {
               
                string sql = @"DELETE De FROM DetalleClasificacionSitio AS De INNER JOIN Solicitudes AS S
                ON S.id_InformacionSitio = De.id_InformacionSitio INNER JOIN Usuario AS U ON U.id_Usuario = S.id_UsuarioEstandar
                WHERE U.id_Usuario = @id_Usuario";

                SqlCommand cmd = new SqlCommand(sql, cx);
                cmd.Parameters.AddWithValue("@id_Usuario", id_Usuario);

                cx.Open();
                cmd.ExecuteNonQuery();
                cx.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Error en la eliminación de datos: " + ex.Message);
            }
        }
        public void EliminarDetallesClasificacion(long id_InformacionSitio, List<int> idS_CatalogoResiduos)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            try
            {
                cx.Open();
                foreach (int idCatalogoResiduo in idS_CatalogoResiduos)
                {
                    string sql = @"DELETE FROM DetalleClasificacionSitio WHERE id_InformacionSitio = @id_InformacionSitio AND id_CatalogoResiduos = @id_CatalogoResiduos";
                    SqlCommand cmd = new SqlCommand(sql, cx);

                    cmd.Parameters.AddWithValue("@id_InformacionSitio", id_InformacionSitio);
                    cmd.Parameters.AddWithValue("@id_CatalogoResiduos", idCatalogoResiduo);

                    cmd.ExecuteNonQuery();
                }
                cx.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Error en la eliminación de datos: " + ex.Message);
            }
        }
        public void ActualizarDetallesClasificacion(long id_InformacionSitio, List<int> idS_CatalogoResiduos)
        {
            SqlConnection cx = conexion.ObtenerConexion();

            try
            {
                cx.Open();

                // Eliminamos los tipos de residuos anteriores
                string deleteSql = @"DELETE FROM DetalleClasificacionSitio
                      WHERE id_InformacionSitio = @id_InformacionSitio";

                SqlCommand deleteCmd = new SqlCommand(deleteSql, cx);

                deleteCmd.Parameters.AddWithValue("@id_InformacionSitio", id_InformacionSitio);

                deleteCmd.ExecuteNonQuery();

                // Insertamos los nuevos tipos de residuos
                foreach (int idCatalogoResiduo in idS_CatalogoResiduos)
                {
                    string insertSql = @"INSERT INTO DetalleClasificacionSitio (id_InformacionSitio, id_CatalogoResiduos)
                         VALUES (@id_InformacionSitio, @id_CatalogoResiduos)";

                    SqlCommand insertCmd = new SqlCommand(insertSql, cx);

                    insertCmd.Parameters.AddWithValue("@id_InformacionSitio", id_InformacionSitio);
                    insertCmd.Parameters.AddWithValue("@id_CatalogoResiduos", idCatalogoResiduo);
                    insertCmd.ExecuteNonQuery();
                }
            }

            catch (Exception ex)
            {
                throw new Exception("Error al actualizar los tipos de residuos: " + ex.Message);
            }
            finally
            {
                cx.Close();
            }
        }
    }
}
