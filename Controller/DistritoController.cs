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
    public class DistritoController
    {
        Conexion conexion = new Conexion();
        public void Insert(DistritoEntidad distritos)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            string sql = @"INSERT INTO Distrito(nombre_Distrito) VALUES (@nombre_Distrito)";

            SqlCommand cmd = new SqlCommand(sql, cx);
            cmd.Parameters.AddWithValue(@"nombre_Distrito", distritos.nombre_Distrito);


            cx.Open();

            cmd.ExecuteNonQuery();

            cx.Close();
        }
        public DataTable ListarDistritos()
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();
                string sql = @"SELECT TOP 20 id_Distrito,nombre_Distrito FROM Distrito ORDER BY id_Distrito DESC";

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar la informacion del escrito:" + ex.Message, ex);
            }
        }
        public bool DistritoExiste(string nombre_Distrito)
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();

                string sql = @"SELECT COUNT(*) FROM Distrito WHERE nombre_Distrito = @nombre_Distrito";

                SqlCommand cmd = new SqlCommand(sql, cx);
                cmd.Parameters.AddWithValue("@nombre_Distrito", nombre_Distrito);

                cx.Open();
                int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                cx.Close();

                return cantidad > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al comprobar si el distrito existe: " + ex.Message, ex);
            }
        }

        public void Delete(int id_Distrito)
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();

                string sql = @"DELETE FROM Distrito WHERE id_Distrito = @id_Distrito";

                SqlCommand cmd = new SqlCommand(sql, cx);

                cmd.Parameters.AddWithValue("@id_Distrito", id_Distrito);

                cx.Open();
                cmd.ExecuteNonQuery();
                cx.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el distrito: " + ex.Message, ex);
            }
        }

        public void Update(int id_Distrito, string nombre_Distrito)
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();
                string sql = @"UPDATE Distrito SET nombre_Distrito = @nombre_Distrito WHERE id_Distrito = @id_Distrito";

                SqlCommand cmd = new SqlCommand(sql, cx);

                cmd.Parameters.AddWithValue(@"nombre_Distrito", nombre_Distrito);
                cmd.Parameters.AddWithValue(@"id_Distrito", id_Distrito);

                cx.Open();
                cmd.ExecuteNonQuery();
                cx.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el distrito: " + ex.Message, ex);
            }
        }

        public DataTable BuscarDistritoById(int id_Distrito)
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();

                string sql = @"SELECT id_Distrito,nombre_Distrito FROM Distrito WHERE id_Distrito = @id_Distrito";

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);
                da.SelectCommand.Parameters.AddWithValue("@id_Distrito", id_Distrito);

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

