using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eco_Community.Model;
using Model.Eco_Community;
using Microsoft.Data.SqlClient;
using System.CodeDom;


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
        public List<BarrioEntidad> ViewAllBarrios(int id_Distrito)
        {
            List<BarrioEntidad> List_Barrios = new List<BarrioEntidad>();
            SqlConnection cx = conexion.ObtenerConexion();

            try
            {
                string sql = @"SELECT * FROM Barrio where id_Distrito = @id_Distrito";
                SqlCommand cmd = new SqlCommand(sql, cx);
                cmd.Parameters.AddWithValue("@id_Distrito", id_Distrito);

                cx.Open();
                SqlDataReader result = cmd.ExecuteReader();

                
                while (result.Read())
                {
                    BarrioEntidad barrios = new BarrioEntidad()
                    {
                        id_Barrio = result.GetInt32(result.GetOrdinal("id_Barrio")),
                        nombre_Barrio = result.GetString(result.GetOrdinal("nombre_Barrio"))
                    };
                    List_Barrios.Add(barrios);
                }
                cx.Close();

                return List_Barrios;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar la información: " + ex.Message);
            }
        }
    }
}
