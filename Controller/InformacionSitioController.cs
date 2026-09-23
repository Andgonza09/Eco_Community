using Eco_Community.Model;
using Microsoft.Data.SqlClient;
using Model.Eco_Community;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Controller
{
    public class InformacionSitioController
    {
        Conexion conexion = new Conexion();
        public long Insert(InformacionSitioEntidad informacionsitio, int id_Barrio)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            string sql = @"INSERT INTO InformacionSitio(tipoSitio, direccion, id_Barrio, latitud, length) OUTPUT INSERTED.id_InformacionSitio VALUES (@tipoSitio, @direccion, @id_Barrio, @latitud, @length)";

            SqlCommand cmd = new SqlCommand(sql, cx);
            cmd.Parameters.AddWithValue(@"tipoSitio", informacionsitio.tipoSitio);
            cmd.Parameters.AddWithValue(@"direccion", informacionsitio.direccion);
            cmd.Parameters.AddWithValue(@"id_Barrio", id_Barrio);
            cmd.Parameters.AddWithValue(@"latitud", SqlDbType.Decimal).Value = informacionsitio.latitud.HasValue ? informacionsitio.latitud.Value : DBNull.Value;
            cmd.Parameters.AddWithValue(@"length", SqlDbType.Decimal).Value = informacionsitio.length.HasValue ? informacionsitio.length.Value : DBNull.Value;



            cx.Open();
            long id_InformacionSitio = Convert.ToInt64(cmd.ExecuteScalar());
            cx.Close();

            return id_InformacionSitio;

        }
        public void DeleteInformacion(InformacionSitioEntidad informacionSitio, long id_InformacionSitio)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            try
            {
                string sql = @"DELETE FROM InformacionSitio WHERE id_InformacionSitio = @idInformacionSitio";
                SqlCommand cmd = new SqlCommand(sql, cx);

                cmd.Parameters.AddWithValue("@idInformacionSitio", id_InformacionSitio);

                cx.Open();
                cmd.ExecuteNonQuery();
                cx.Close();

                MessageBox.Show("Información eliminada correctamente", "Operación exitosa", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar este punto" + ex.Message);
            }
        }
        public long GetID_InformacionSitio(long id_InformacionSitio)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            try
            {
                string sql = @"Select * FROM informacionSitio WHERE id_InformacionSitio = @idInformacionSitio";
                SqlCommand cmd = new SqlCommand(sql, cx);

                cmd.Parameters.AddWithValue("@idInformacionSitio", id_InformacionSitio);

                cx.Open();
                object resultado = cmd.ExecuteScalar();
                cx.Close();

                if (resultado == null)
                    return 0;

                return Convert.ToInt64(resultado);


            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar la información: " + ex.Message);
            }
        }
        public bool UpdateInformacion(InformacionSitioEntidad informacionSitio, long id_InformacionSitio)
        {

            SqlConnection cx = conexion.ObtenerConexion();
            try
            {
                string sql = @"Update InformacionSitio SET tipoSitio = @tipoSitio, direccion = @Direccion, 
                latitud = @Latitud, length = @Length WHERE id_InformacionSitio = @IdSiteInformation";

                SqlCommand cmd = new SqlCommand(sql, cx);
                cmd.Parameters.AddWithValue("@IdSiteInformation", id_InformacionSitio);
                cmd.Parameters.AddWithValue("@tipoSitio", informacionSitio.tipoSitio);
                cmd.Parameters.AddWithValue("@Direccion", informacionSitio.direccion);
                cmd.Parameters.AddWithValue("@Latitud", informacionSitio.latitud);
                cmd.Parameters.AddWithValue("@Length", informacionSitio.length);

                cx.Open();
                int result = cmd.ExecuteNonQuery();

                if (result == 0)
                    return false;

                cx.Close();
                return true;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los datos: " + ex.Message);
                return false;
            }
        }
        public List<(InformacionSitioEntidad, string)> ViewAllPoints()
        {
            List<(InformacionSitioEntidad Sitio, string NombreBarrio)> points = new List<(InformacionSitioEntidad Sitio, string NombreBarrio)>();
            SqlConnection cx = conexion.ObtenerConexion();

            string sql = @"
                    SELECT 
                        i.id_InformacionSitio, i.tipoSitio, i.direccion, i.id_Barrio, b.nombre_Barrio, i.latitud, i.length
                        FROM InformacionSitio i INNER JOIN Barrio b ON i.id_Barrio = b.id_Barrio INNER JOIN
                        Solicitudes ON i.id_InformacionSitio = Solicitudes.id_InformacionSitio where Solicitudes.estado_Solicitud = 'Aprobada'";

            SqlCommand cmd = new SqlCommand(sql, cx);
            cx.Open();
            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int neighborhoodId = reader.GetInt32(reader.GetOrdinal("id_Barrio"));
                string nombreBarrio = reader.GetString(reader.GetOrdinal("nombre_Barrio"));


                InformacionSitioEntidad sitio = new InformacionSitioEntidad()
                {

                    id_InformacionSitio = Convert.ToInt32(reader["id_InformacionSitio"]),
                    tipoSitio = reader["tipoSitio"].ToString() ?? string.Empty,
                    direccion = reader["direccion"].ToString() ?? string.Empty,
                    latitud = reader["latitud"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["latitud"]), // Valores predeterminados para latitud y longitud si son nulos
                    length = reader["length"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["length"]),

                    id_Barrio = neighborhoodId

                };
                points.Add((sitio, nombreBarrio));
            }
            cx.Close();
            return points;
        }

    }
}
