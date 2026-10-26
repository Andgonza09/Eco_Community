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
        public long InsertarInformacionSitio(InformacionSitioEntidad informacionsitio, int id_Barrio)
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
        public void EliminarInformacionSitio(InformacionSitioEntidad informacionSitio, long id_InformacionSitio)
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

            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar este punto" + ex.Message);
            }
        }
        
        public void EliminarInformacionSitio_PorIdDistrito(int id_Distrito)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            try
            {
                string sql = @"DELETE  InformacionSitio FROM InformacionSitio INNER JOIN Barrio AS B ON B.id_Barrio = InformacionSitio.id_Barrio 
                INNER JOIN Distrito AS D ON D.id_Distrito = B.id_Distrito Where D.id_Distrito = @id_Distrito";
                SqlCommand cmd = new SqlCommand(sql, cx);

                cmd.Parameters.AddWithValue("@id_Distrito", id_Distrito);

                cx.Open();
                cmd.ExecuteNonQuery();
                cx.Close();


            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar este punto" + ex.Message);
            }
        }
        public void EliminarInformacionSitio_PorIdUsuario(long id_Usuario)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            try
            {
                string sql = @"DELETE I FROM InformacionSitio AS I INNER JOIN Solicitudes AS S ON S.id_InformacionSitio = I.id_InformacionSitio
                INNER JOIN Usuario AS U ON U.id_Usuario = S.id_UsuarioEstandar WHERE U.id_Usuario = @id_Usuario";

                SqlCommand cmd = new SqlCommand(sql, cx);

                cmd.Parameters.AddWithValue("@id_Usuario", id_Usuario);

                cx.Open();
                cmd.ExecuteNonQuery();
                cx.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar este punto" + ex.Message);
            }
        }
        public long ObtenerIdInformacionSitio(long id_InformacionSitio)
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
        public InformacionSitioEntidad ObtenerInformacionSitio_IdInformacionSitio(long id_InformacionSitio)
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();

                string sql = @"SELECT id_InformacionSitio, tipoSitio, direccion, id_Barrio, latitud, length FROM InformacionSitio
                WHERE id_InformacionSitio = @id_InformacionSitio";

                SqlCommand cmd = new SqlCommand(sql, cx);
                cmd.Parameters.AddWithValue("@id_InformacionSitio", id_InformacionSitio);

                cx.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    InformacionSitioEntidad informacion = new InformacionSitioEntidad
                    {
                        id_InformacionSitio = reader.GetInt64(reader.GetOrdinal("id_InformacionSitio")),
                        tipoSitio = reader.GetString(reader.GetOrdinal("tipoSitio")),
                        direccion = reader.GetString(reader.GetOrdinal("direccion")),
                        id_Barrio = reader.GetInt32(reader.GetOrdinal("id_Barrio"))
                    };

                    cx.Close();

                    return informacion;
                }

                cx.Close();

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Error al obtener la información del sitio: " + ex.Message
                );
            }
        }

        public bool ActualizarCoordenadas_InformacionSitio(InformacionSitioEntidad informacionSitio, long id_InformacionSitio)
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


        public bool ActualizarInformacionSitio(long id_InformacionSitio,string tipoSitio,string direccion,long id_Barrio)
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();

                string sql = @"UPDATE InformacionSitio
                       SET tipoSitio = @tipoSitio,
                           direccion = @direccion,
                           id_Barrio = @id_Barrio
                       WHERE id_InformacionSitio = @id_InformacionSitio";

                SqlCommand cmd = new SqlCommand(sql, cx);

                cmd.Parameters.AddWithValue("@tipoSitio", tipoSitio);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@id_Barrio", id_Barrio);
                cmd.Parameters.AddWithValue(
                    "@id_InformacionSitio",
                    id_InformacionSitio
                );

                cx.Open();

                int rowsAffected = cmd.ExecuteNonQuery();

                cx.Close();

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Error al actualizar la información del sitio: "
                    + ex.Message
                );
            }
        }
        public List<(InformacionSitioEntidad, string)> ListarTodos_Puntos()
        {
            List<(InformacionSitioEntidad Sitio, string NombreBarrio)> points = new List<(InformacionSitioEntidad Sitio, string NombreBarrio)>();
            SqlConnection cx = conexion.ObtenerConexion();

            string sql = @"SELECT 
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

     public List<(InformacionSitioEntidad, string, string, string, string)> MostrarDetalles_PuntosRegistrados()
        {
            SqlConnection cx = conexion.ObtenerConexion();
            List<(InformacionSitioEntidad Sitio, string NombreBarrio, string nombreDistrito, string nombre_Usuario, string Residuos)> points = new List<(InformacionSitioEntidad Sitio, string NombreBarrio, string nombreDistrito,string nombre_Usuario, string Residuos)>();

            string sql = @"SELECT 
            i.id_InformacionSitio, i.tipoSitio, i.direccion, b.nombre_Barrio, D.nombre_Distrito, STRING_AGG(C.tipoResiduo, ', ') AS tipoResiduo, U.nombre_Usuario, i.latitud, i.length
            FROM InformacionSitio i INNER JOIN Barrio b ON i.id_Barrio = b.id_Barrio INNER JOIN Distrito AS D ON D.id_Distrito = B.id_Distrito INNER JOIN
            Solicitudes ON i.id_InformacionSitio = Solicitudes.id_InformacionSitio INNER JOIN Usuario AS U ON U.id_Usuario = Solicitudes.id_UsuarioEstandar
            INNER JOIN DetalleClasificacionSitio AS DE ON De.id_InformacionSitio = I.id_InformacionSitio INNER JOIN CatalogoResiduos AS C ON C.id_CatalogoResiduos = DE.id_CatalogoResiduos
            where Solicitudes.estado_Solicitud = 'Aprobada' GROUP BY I.id_InformacionSitio, I.tipoSitio, I.direccion, B.nombre_Barrio, D.nombre_Distrito, U.nombre_Usuario, I.latitud, I.length";

            SqlCommand cmd = new SqlCommand(sql, cx);
            cx.Open();
            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string nombreDistrito = reader.GetString(reader.GetOrdinal("nombre_Distrito"));
                string nombreBarrio = reader.GetString(reader.GetOrdinal("nombre_Barrio"));
                string tipoResiduos = reader.GetString(reader.GetOrdinal("tipoResiduo"));
                string nombre_Usuario = reader.GetString(reader.GetOrdinal("nombre_Usuario"));

                InformacionSitioEntidad sitio = new InformacionSitioEntidad()
                {
                    id_InformacionSitio = Convert.ToInt32(reader["id_InformacionSitio"]),
                    tipoSitio = reader["tipoSitio"].ToString() ?? string.Empty,
                    direccion = reader["direccion"].ToString() ?? string.Empty,
                    latitud = reader["latitud"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["latitud"]), // Valores predeterminados para latitud y longitud si son nulos
                    length = reader["length"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["length"]),
                };
                points.Add((sitio, nombreBarrio, nombreDistrito, nombre_Usuario, tipoResiduos));
            }
            cx.Close();
            return points;
        }


    }
}
