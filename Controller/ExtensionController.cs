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
    public class ExtensionController
    {
        Conexion conexion = new Conexion();
        public void InsertarExtensiones(ExtensionEntidad extension)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            string sql = @"INSERT INTO Extension VALUES (@tipo_Extension)";

            SqlCommand cmd = new SqlCommand(sql, cx);
            cmd.Parameters.AddWithValue("@tipo_Extension", extension.tipo_Extension);


            cx.Open();

            cmd.ExecuteNonQuery();

            cx.Close();
        }
        public void EliminarExtensiones(int id_Extension)
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();

                string sql = @"DELETE FROM Extension WHERE id_Extension = @id_Extension";

                SqlCommand cmd = new SqlCommand(sql, cx);
                cmd.Parameters.AddWithValue("@id_Extension", id_Extension);

                cx.Open();
                cmd.ExecuteNonQuery();
                cx.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la extensión: " + ex.Message, ex);
            }
        }
        public DataTable ObtenerExtensiones()
        { 
            SqlConnection cx = conexion.ObtenerConexion();
            try
            {
                string sql = @"SELECT id_Extension, tipo_Extension FROM Extension";

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las extensiones: " + ex.Message);
            }
        }
        public bool ExtensionExiste(string tipo_Extension)
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();

                string sql = @"SELECT COUNT(*) FROM Extension WHERE tipo_Extension = @tipo_Extension";

                SqlCommand cmd = new SqlCommand(sql, cx);
                cmd.Parameters.AddWithValue("@tipo_Extension", tipo_Extension);

                cx.Open();
                int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                cx.Close();

                return cantidad > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al comprobar si la extensión existe: " + ex.Message, ex);
            }
        }

        public void ActualizarExtensiones(int id_Extension, string tipo_Extension)
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();

                string sql = @"UPDATE Extension SET tipo_Extension = @tipo_Extension WHERE id_Extension = @id_Extension";

                SqlCommand cmd = new SqlCommand(sql, cx);
                cmd.Parameters.AddWithValue("@tipo_Extension", tipo_Extension);
                cmd.Parameters.AddWithValue("@id_Extension", id_Extension);

                cx.Open();
                cmd.ExecuteNonQuery();
                cx.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la extensión: " + ex.Message, ex);
            }
        }

        public DataTable ListarExtensiones()
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();

                string sql = @"SELECT TOP 20 id_Extension, tipo_Extension FROM Extension ORDER BY id_Extension DESC";

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las extensiones: " + ex.Message, ex);
            }
        }

        public DataTable BuscarExtension_PorId(int id_Extension)
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();

                string sql = @"SELECT id_Extension, tipo_Extension FROM Extension WHERE id_Extension = @id_Extension";

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);
                da.SelectCommand.Parameters.AddWithValue("@id_Extension", id_Extension);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar la extensión: " + ex.Message, ex);
            }
        }


    }
}
