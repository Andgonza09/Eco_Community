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
    public class RolesController
    {
        Conexion conexion = new Conexion();

        public void Insert(RolesEntidad roles)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            string sql = @"INSERT INTO Roles(tipo_Roles) VALUES (@tipo_Roles)";

            SqlCommand cmd = new SqlCommand(sql, cx);
            cmd.Parameters.AddWithValue(@"tipo_Roles", roles.tipo_Roles);
           

            cx.Open();

            cmd.ExecuteNonQuery();

            cx.Close();

        }
    }
}
