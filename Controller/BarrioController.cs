using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eco_Community.Model;
using Model.Eco_Community;
using Microsoft.Data.SqlClient;


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
    }
}
