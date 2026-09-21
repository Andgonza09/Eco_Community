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
    public class MisionesController
    {
        Conexion conexion = new Conexion();

        public int Insert(MisionesEntidad misiones)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            string sql = @"INSERT INTO Misiones(descripcion,puntaje) VALUES (@descripcion,@puntaje)";

            SqlCommand cmd = new SqlCommand(sql, cx);
            cmd.Parameters.AddWithValue(@"descripcion", misiones.descripcion);
            cmd.Parameters.AddWithValue(@"puntaje", misiones.puntaje);

            cx.Open();
            int id_Mision = Convert.ToInt32(cmd.ExecuteScalar());
            cx.Close();
            return id_Mision;
        }
        public bool MissionExists(string descripcion)
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();

                string sql = @"SELECT COUNT(*) FROM Misiones WHERE descripcion = @MissionDescription";

                SqlCommand cmd = new SqlCommand(sql, cx);
                cmd.Parameters.AddWithValue("@MissionDescription", descripcion);

                object? result = cmd.ExecuteScalar();
                int quantity = Convert.ToInt32(result);

                return quantity > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al comprobar si la misión existe: " + ex.Message);
            }
        }

    }
}
