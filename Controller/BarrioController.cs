using Eco_Community.Model;
using Microsoft.Data.SqlClient;
using Model.Eco_Community;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Controller
{
    public class BarrioController
    {
        Conexion conexion = new Conexion();
        public void Insert(BarrioEntidad barrios)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            string sql = @"INSERT INTO Barrio(nombre_Barrio,id_Distrito) VALUES (@nombre_Barrio,@id_Distrito)";

            SqlCommand cmd = new SqlCommand(sql, cx);
            cmd.Parameters.AddWithValue(@"nombre_barrio", barrios.nombre_Barrio);
            cmd.Parameters.AddWithValue(@"id_Distrito", barrios.id_Distrito);

            cx.Open();

            cmd.ExecuteNonQuery();

            cx.Close();
        }
        public string ObtenerNombreBarrio(int idBarrio)
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();

                string sql = @"SELECT nombre_barrio FROM Barrio WHERE id_barrio = @IdBarrio";

                SqlCommand cmd = new SqlCommand(sql, cx);
                cmd.Parameters.AddWithValue("@IdBarrio", idBarrio);

                object resultado = cmd.ExecuteScalar();

                return resultado?.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el barrio: " + ex.Message);
            }
        }
        public DataTable ListarBarriosPorDistrito(int id_Distrito)
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();

                string sql = @"SELECT id_Barrio, nombre_Barrio, id_Distrito
                FROM Barrio WHERE id_Distrito = @id_Distrito ORDER BY nombre_Barrio ASC";

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);
                da.SelectCommand.Parameters.AddWithValue("@id_Distrito", id_Distrito);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar la información: " + ex.Message, ex);
            }
        }
        public BarrioEntidad GetBarrioById(long id_Barrio)
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();

                string sql = @"SELECT id_Barrio, nombre_Barrio, id_Distrito
                FROM Barrio
                WHERE id_Barrio = @id_Barrio";

                SqlCommand cmd = new SqlCommand(sql, cx);
                cmd.Parameters.AddWithValue("@id_Barrio", id_Barrio);

                cx.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    BarrioEntidad barrio = new BarrioEntidad
                    {
                        id_Barrio = reader.GetInt32(reader.GetOrdinal("id_Barrio")),
                        nombre_Barrio = reader.GetString(reader.GetOrdinal("nombre_Barrio")),
                        id_Distrito = reader.GetInt32(reader.GetOrdinal("id_Distrito"))
                    };

                    cx.Close();

                    return barrio;
                }

                cx.Close();

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Error al obtener el barrio: " + ex.Message
                );
            }
        }
        public bool BarrioExiste(string nombre_Barrio, int id_Distrito)
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();

                string sql = @"SELECT COUNT(*) FROM Barrio WHERE nombre_Barrio = @nombre_Barrio AND id_Distrito = @id_Distrito";

                SqlCommand cmd = new SqlCommand(sql, cx);
                cmd.Parameters.AddWithValue("@nombre_Barrio", nombre_Barrio);
                cmd.Parameters.AddWithValue("@id_Distrito", id_Distrito);

                cx.Open();
                int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                cx.Close();

                return cantidad > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al comprobar si el barrio existe: " + ex.Message, ex);
            }
        }

        public void Delete(int id_Barrio)
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();

                string sql = @"DELETE FROM Barrio WHERE id_Barrio = @id_Barrio";

                SqlCommand cmd = new SqlCommand(sql, cx);

                cmd.Parameters.AddWithValue("@id_Barrio", id_Barrio);

                cx.Open();
                cmd.ExecuteNonQuery();
                cx.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el barrio: " + ex.Message, ex);
            }
        }

        public void Update(int id_Barrio, string nombre_Barrio, int id_Distrito)
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();

                string sql = @"UPDATE Barrio SET nombre_Barrio = @nombre_Barrio,id_Distrito = @id_Distrito WHERE id_Barrio = @id_Barrio";

                SqlCommand cmd = new SqlCommand(sql, cx);

                cmd.Parameters.AddWithValue("@nombre_Barrio", nombre_Barrio);
                cmd.Parameters.AddWithValue("@id_Distrito", id_Distrito);
                cmd.Parameters.AddWithValue("@id_Barrio", id_Barrio);

                cx.Open();
                cmd.ExecuteNonQuery();
                cx.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable BuscarBarrioById(int id_Barrio)
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();

                string sql = @"SELECT b.id_Barrio, b.nombre_Barrio, b.id_Distrito, d.nombre_Distrito
                                FROM Barrio AS b INNER JOIN Distrito AS d ON b.id_Distrito = d.id_Distrito
                                   WHERE b.id_Barrio = @id_Barrio";

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);
                da.SelectCommand.Parameters.AddWithValue("@id_Barrio", id_Barrio);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el barrio: " + ex.Message, ex);
            }
        }


        public DataTable ListarBarrios()
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();

                string sql = @"SELECT b.id_Barrio, b.nombre_Barrio, b.id_Distrito, d.nombre_Distrito
                FROM Barrio AS b INNER JOIN Distrito AS d ON b.id_Distrito = d.id_Distrito ORDER BY b.id_Barrio DESC";

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar la información: " + ex.Message, ex);
            }
        }

    }
}
