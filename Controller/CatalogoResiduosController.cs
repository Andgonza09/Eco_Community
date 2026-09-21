using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eco_Community.Model;
using Model.Eco_Community;
using Microsoft.Data.SqlClient;
using Model;

namespace Controller
{
    public class CatalogoResiduosController
    {
        Conexion conexion = new Conexion();
        public void Insert(CatalogoResiduosEntidad catalogoresiduos)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            string sql = @"INSERT INTO CatalogoResiduos(tipoResiduo) VALUES (@tipoResiduo)";

            SqlCommand cmd = new SqlCommand(sql, cx);
            cmd.Parameters.AddWithValue(@"tipoResiduo", catalogoresiduos.tipoResiduo);

            cx.Open();

            cmd.ExecuteNonQuery();

            cx.Close();

        }

        public List<CatalogoResiduosEntidad> ViewAllWaste()
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();
                string sql = @"SELECT * FROM CatalogoResiduos";

                SqlCommand cmd = new SqlCommand(sql, cx);

                cx.Open();
                SqlDataReader result = cmd.ExecuteReader();
                if (!result.HasRows)
                {
                    throw new Exception("No se han encontrado datos pertenecientes al catálogo de residuo");
                }

                List<CatalogoResiduosEntidad> listWaste = new List<CatalogoResiduosEntidad>();
                while (result.Read())
                {
                    listWaste.Add(new CatalogoResiduosEntidad()
                    {
                        id_CatalogoResiduos = result.GetInt32(result.GetOrdinal("id_CatalogoResiduos")),
                        tipoResiduo = result.GetString(1)
                    });
                }
                cx.Close();
                return listWaste;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar la información: " + ex.Message, ex);
            }
        }
    }
}
