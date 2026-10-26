using Eco_Community.Model;
using Microsoft.Data.SqlClient;
using Model;
using Model.Eco_Community;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class CatalogoResiduosController
    {
        Conexion conexion = new Conexion();
        public int InsertarCatalogoResiduos(CatalogoResiduosEntidad catalogoresiduos)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            string sql = @"INSERT INTO CatalogoResiduos(tipoResiduo) OUTPUT INSERTED.id_CatalogoResiduos VALUES (@tipoResiduo)";


            SqlCommand cmd = new SqlCommand(sql, cx);
            cmd.Parameters.AddWithValue("@tipoResiduo", catalogoresiduos.tipoResiduo);

            cx.Open();
            int id_Catalogo = Convert.ToInt32(cmd.ExecuteScalar());
            cx.Close();

            return id_Catalogo;

        }
        public void ActualizarCatalogoResiduos(int id_Catalogo, string tipoResiduos)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            try
            {
                string sql = @"UPDATE CatalogoResiduos SET tipoResiduo = @tipoResiduos WHERE id_CatalogoResiduos = @id_Catalogo";

                SqlCommand cmd = new SqlCommand(sql, cx);
                cmd.Parameters.AddWithValue("@id_Catalogo", id_Catalogo);
                cmd.Parameters.AddWithValue("@tipoResiduos", tipoResiduos);

                cx.Open();
                cmd.ExecuteNonQuery();
                cx.Close();


            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la información: " + ex.Message);
            }
        }
        public void EliminarCatalogoResiduos(int id_Catalogo)
        {
            SqlConnection cx = conexion.ObtenerConexion();

            try
            {
                string sql = @"DELETE FROM CatalogoResiduos WHERE id_CatalogoResiduos = @id_Catalogo";

                SqlCommand cmd = new SqlCommand(sql, cx);
                cmd.Parameters.AddWithValue("@id_Catalogo", id_Catalogo);

                cx.Open();
                cmd.ExecuteNonQuery();
                cx.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la información: " + ex.Message);
            }
        }
        public bool ExisteCatalogo(string tipoResiduos)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            try
            {
                string sql = @"SELECT COUNT(*) FROM CatalogoResiduos WHERE tipoResiduo = @tipoResiduos";

                SqlCommand cmd = new SqlCommand(sql, cx);
                cmd.Parameters.AddWithValue("@tipoResiduos", tipoResiduos);

                cx.Open();
                int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                cx.Close();

                return cantidad > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al realizar la búsqueda: " + ex.Message);
            }
        }

        public DataTable ListarCatalogo()
        {
            SqlConnection cx = conexion.ObtenerConexion();
            try
            {
                string sql = @"SELECT * FROM CatalogoResiduos";
                SqlDataAdapter da = new SqlDataAdapter(sql, cx);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los elementos del catálogo de residuos: " + ex.Message);
            }
        }
        public DataTable BuscarResiduoPorId(int id_Catalogo)
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();

                string sql = @"SELECT id_CatalogoResiduos,tipoResiduo FROM CatalogoResiduos WHERE id_CatalogoResiduos = @id_Catalogo";

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);
                da.SelectCommand.Parameters.AddWithValue("@id_Catalogo", id_Catalogo);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar el distrito: " + ex.Message, ex);
            }
        }
    }
}
