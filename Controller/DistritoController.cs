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
    }
}

