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
        public void Insert(long id_InformacionSitio, List<int> idS_CatalogoResiduos)
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
        public List<int> GetIds_CatalogoResiduosByInformacion(long id_informacionSitio)
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
        public void DeleteDetailsClasificacion(long id_InformacionSitio, List<int> idS_CatalogoResiduos)
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
    }
}
