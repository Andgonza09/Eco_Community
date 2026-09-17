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
        public List<DistritoEntidad> ViewAllDistrict()
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();
                string sql = @"SELECT * FROM Distrito";

                SqlCommand cmd = new SqlCommand(sql, cx);

                cx.Open();
                SqlDataReader result = cmd.ExecuteReader();

                if (!result.HasRows)
                {
                    throw new Exception("Error al cargar los distritos");
                }
                List<DistritoEntidad> list_Districto = new List<DistritoEntidad>();

                while (result.Read())
                {
                    DistritoEntidad distrito = new DistritoEntidad
                    {
                        id_Distrito = result.GetInt32(result.GetOrdinal("id_Distrito")),
                        nombre_Distrito = result.GetString(result.GetOrdinal("nombre_Distrito"))
                    };
                    list_Districto.Add(distrito);
                }
                cx.Close();
                return list_Districto;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar la información del distrito: " + ex.Message, ex);
            }
        }
    }
}

