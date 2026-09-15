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
    public class DetalleClasificacionSitioController
    {
        Conexion conexion = new Conexion();

        public void Insert(DetalleClasificacionSitioEntidad
            detalleclasificacionsitio)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            string sql = @"INSERT INTO DetalleClasificacionSitio(id_InformacionSitio,id_CatalogoResiduos) VALUES (@id_InformacionSitio,@id_CatalogoResiduos)";

            SqlCommand cmd = new SqlCommand(sql, cx);
            cmd.Parameters.AddWithValue(@"id_InformacionSitio", detalleclasificacionsitio.id_InformacionSitio);
            cmd.Parameters.AddWithValue(@"id_CatalogoResiduos", detalleclasificacionsitio.id_CatalogoResiduos);

            cx.Open();

            cmd.ExecuteNonQuery();

            cx.Close();

        }
    }
}
