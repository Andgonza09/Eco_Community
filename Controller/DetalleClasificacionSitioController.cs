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

        public void Insert(DetalleClasificacionSitioEntidad detalleclasificacionsitio, long id_InformacionSitio, List<int> idS_CatalogoResiduos)
        {
            SqlConnection cx = conexion.ObtenerConexion();

            try
            {
                cx.Open();

                foreach (int idCatalogoResiduo in idS_CatalogoResiduos)
                {
                    string sql = @"
                INSERT INTO DetalleClasificacionSitio
                (
                    id_InformacionSitio,
                    id_CatalogoResiduos
                )
                VALUES
                (
                    @id_InformacionSitio,
                    @id_CatalogoResiduos
                )";

                    SqlCommand cmd = new SqlCommand(sql, cx);

                    cmd.Parameters.AddWithValue(
                        "@id_InformacionSitio",
                        id_InformacionSitio
                    );

                    cmd.Parameters.AddWithValue(
                        "@id_CatalogoResiduos",
                        idCatalogoResiduo
                    );

                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                cx.Close();
            }


        }
    }
}
