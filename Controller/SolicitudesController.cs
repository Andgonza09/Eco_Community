using Eco_Community.Model;
using Microsoft.Data.SqlClient;
using Model.Eco_Community;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Controller
{
    public class SolicitudesController
    {
        Conexion conexion = new Conexion();
        public long Insert(SolicitudesEntidad solicitudes, long id_Usuario, long id_InformacionSitio)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            string sql = @"INSERT INTO Solicitudes(estado_Solicitud, fecha_Solicitud, fecha_Resolucion, id_UsuarioEstandar, id_InformacionSitio) OUTPUT INSERTED.id_Solicitud VALUES (@estado_solicitud, GETDATE(), @fecha_Resolucion, @id_UsuarioEstandar, @id_InformacionSitio)";

            SqlCommand cmd = new SqlCommand(sql, cx);

            cmd.Parameters.AddWithValue("@estado_Solicitud", solicitudes.estado_Solicitud ?? "Pendiente");
            cmd.Parameters.Add("@fecha_Resolucion", SqlDbType.Date).Value = solicitudes.fecha_Resolucion.HasValue ? solicitudes.fecha_Resolucion.Value.ToDateTime(TimeOnly.MinValue) : DBNull.Value;

            cmd.Parameters.AddWithValue("@id_UsuarioEstandar", id_Usuario);
            cmd.Parameters.AddWithValue("@id_InformacionSitio", id_InformacionSitio);

            cx.Open();
            long id_Solicitud = Convert.ToInt64(cmd.ExecuteScalar());

            cx.Close();

            return id_Solicitud;
        }
       
        public void DeleteRequest(long id_Solicitud)
        {
            try
            {
                SqlConnection ex = conexion.ObtenerConexion();
                string sql = @"DELETE FROM Solicitudes WHERE id_Solicitud = @idSolitud";

                //Parametros enviados al SQL
                SqlCommand cmd = new SqlCommand(sql, ex);
                cmd.Parameters.AddWithValue("@idSolitud", id_Solicitud);

                ex.Open();
                cmd.ExecuteNonQuery();
                ex.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar solicitud: " + ex.Message);
            }

        }
        public void DeletebyInformacionSitio(long id_InformacionSitio)
        {
            SqlConnection cx = conexion.ObtenerConexion();

            string sql = @"DELETE FROM Solicitudes 
                   WHERE id_InformacionSitio = @id_InformacionSitio";

            SqlCommand cmd = new SqlCommand(sql, cx);
            cmd.Parameters.AddWithValue("@id_InformacionSitio", id_InformacionSitio);

            cx.Open();
            cmd.ExecuteNonQuery();
            cx.Close();
        }
        public bool UpdateRequest(long id_Request, string stateRequest)
        {
            int rowAffected = 0;
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();
                string sql = @"UPDATE Solicitudes SET estado_Solicitud = @StateRequest, fecha_Resolucion = GETDATE() WHERE id_Solicitud = @IdRequest";

                SqlCommand cmd = new SqlCommand(sql, cx);
                cmd.Parameters.AddWithValue("IdRequest", id_Request);
                cmd.Parameters.AddWithValue("StateRequest", stateRequest);

                cx.Open();
                rowAffected = cmd.ExecuteNonQuery();
                cx.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la solicitud" + ex.Message);

            }
            return rowAffected > 0;
        }
        public long GetID_Solicitud(long id_InformacionSitio)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            try
            {
                string sql = @"Select * FROM Solicitudes WHERE id_InformacionSitio = @id_InformacionSitio";
                SqlCommand cmd = new SqlCommand(sql, cx);

                cmd.Parameters.AddWithValue("@id_InformacionSitio", id_InformacionSitio);

                cx.Open();
                object resultado = cmd.ExecuteScalar();
                cx.Close();

                if (resultado == null)
                    return 0;

                return Convert.ToInt64(resultado);


            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el ID de la solicitud: " + ex.Message);
            }
        }
        public List<(SolicitudesEntidad, string, string, string)> ViewAllRequest()
        {
            List<(SolicitudesEntidad, string,string, string)> Lista_solicitudes = new List<(SolicitudesEntidad, string, string, string)>();
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();
                string sql = @"SELECT s.id_Solicitud, s.estado_Solicitud, s.fecha_Solicitud,
                s.fecha_Resolucion, i.tipoSitio, i.direccion, u.nombre_Usuario FROM Solicitudes AS s INNER JOIN InformacionSitio AS i
                ON s.id_InformacionSitio = i.id_InformacionSitio INNER JOIN Usuario As u ON u.id_Usuario = s.id_UsuarioEstandar";

                SqlCommand cmd = new SqlCommand(sql, cx);

                cx.Open();
                SqlDataReader result = cmd.ExecuteReader();

                while (result.Read())
                {

                    string nombre_Usuario = result.GetString(result.GetOrdinal("nombre_Usuario"));
                    string tipoSitio = result.GetString(result.GetOrdinal("tipoSitio"));
                    string direccion = result.GetString(result.GetOrdinal("direccion"));

                    SolicitudesEntidad solicitudes = new SolicitudesEntidad()
                    {
                        id_Solicitud = result.GetInt64(result.GetOrdinal("id_Solicitud")),
                        fecha_Solicitud = DateOnly.FromDateTime(result.GetDateTime(result.GetOrdinal("fecha_Solicitud"))),
                        fecha_Resolucion = result["fecha_Resolucion"] == DBNull.Value ? DateOnly.MinValue : DateOnly.FromDateTime(Convert.ToDateTime(result["fecha_Resolucion"])),
                        estado_Solicitud = result.GetString(result.GetOrdinal("estado_Solicitud")),

                    };
                    Lista_solicitudes.Add((solicitudes, nombre_Usuario, tipoSitio, direccion));
                }

                cx.Close();
                return Lista_solicitudes;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar todas las solicitudes del sistema" + ex.Message);
            }

        }
        public List<(SolicitudesEntidad, string, string)> ViewRequestByUser(long id_Usuario)
        {
            List<(SolicitudesEntidad, string, string)> lista_Solicitudes = new List<(SolicitudesEntidad, string, string)>();
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();
                string sql = @"SELECT s.id_Solicitud, s.estado_Solicitud, s.fecha_Solicitud,
                s.fecha_Resolucion, i.tipoSitio, i.direccion FROM Solicitudes AS s INNER JOIN InformacionSitio AS i
                ON s.id_InformacionSitio = i.id_InformacionSitio WHERE s.id_UsuarioEstandar = @IdUsuario";

                SqlCommand cmd = new SqlCommand(sql, cx);
                cmd.Parameters.AddWithValue("@IdUsuario", id_Usuario);

                cx.Open();
                SqlDataReader result = cmd.ExecuteReader();

                while (result.Read())
                {
                    string tipoSitio = result.GetString(result.GetOrdinal("tipoSitio"));
                    string dirección = result.GetString(result.GetOrdinal("direccion"));
                    int fechaResolucionIndex = result.GetOrdinal("fecha_Resolucion");

                    SolicitudesEntidad solicitudes = new SolicitudesEntidad
                    {
                        id_Solicitud = result.GetInt64(result.GetOrdinal("id_Solicitud")),
                        estado_Solicitud = result.GetString(result.GetOrdinal("estado_Solicitud")),
                        fecha_Solicitud = DateOnly.FromDateTime(result.GetDateTime(result.GetOrdinal("fecha_Solicitud"))),
                        fecha_Resolucion = result.IsDBNull(fechaResolucionIndex) ? DateOnly.MinValue : DateOnly.FromDateTime(result.GetDateTime(fechaResolucionIndex)),
                    };

                    lista_Solicitudes.Add((solicitudes, tipoSitio, dirección));
                }

                return lista_Solicitudes;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar la información" + ex.Message);
            }
        }
        public List<(SolicitudesEntidad, string, string, string)> ViewRequestByID(long id_Solicitud)
        {
            List<(SolicitudesEntidad, string, string, string)> lista_Solicitudes = new List<(SolicitudesEntidad, string, string, string)>();
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();
                string sql = @"SELECT s.id_Solicitud, s.estado_Solicitud, s.fecha_Solicitud,
                s.fecha_Resolucion, i.tipoSitio, i.direccion, u.nombre_Usuario FROM Solicitudes AS s INNER JOIN InformacionSitio AS i
                ON s.id_InformacionSitio = i.id_InformacionSitio INNER JOIN Usuario As u ON u.id_Usuario = s.id_UsuarioEstandar WHERE id_Solicitud = @id_Solicitud";

                SqlCommand cmd = new SqlCommand(sql, cx);
                cmd.Parameters.AddWithValue("@id_Solicitud", id_Solicitud);

                cx.Open();
                SqlDataReader result = cmd.ExecuteReader();

                while (result.Read())
                {
                    string nombre_Usuario = result.GetString(result.GetOrdinal("nombre_Usuario"));
                    string tipoSitio = result.GetString(result.GetOrdinal("tipoSitio"));
                    string dirección = result.GetString(result.GetOrdinal("direccion"));
                    int fechaResolucionIndex = result.GetOrdinal("fecha_Resolucion");

                    SolicitudesEntidad solicitudes = new SolicitudesEntidad
                    {
                        id_Solicitud = result.GetInt64(result.GetOrdinal("id_Solicitud")),
                        estado_Solicitud = result.GetString(result.GetOrdinal("estado_Solicitud")),
                        fecha_Solicitud = DateOnly.FromDateTime(result.GetDateTime(result.GetOrdinal("fecha_Solicitud"))),
                        fecha_Resolucion = result.IsDBNull(fechaResolucionIndex) ? DateOnly.MinValue : DateOnly.FromDateTime(result.GetDateTime(fechaResolucionIndex)),
                    };

                    lista_Solicitudes.Add((solicitudes, nombre_Usuario, tipoSitio, dirección));
                }

                return lista_Solicitudes;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar la información" + ex.Message);
            }
        }
        public int CountRequestApproved(long id_Usuario) // Solicitudes Aprobadas
        {
            SqlConnection cx = conexion.ObtenerConexion();
            try
            {
                string sql = @"SELECT COUNT(*) FROM Solicitudes
                INNER JOIN Usuario ON Solicitudes.id_UsuarioEstandar = Usuario.id_Usuario WHERE Solicitudes.estado_Solicitud = 'Aprobada' AND Usuario.id_Usuario = @IdUser";

                SqlCommand cmd = new SqlCommand(sql, cx);
                cmd.Parameters.AddWithValue("@IdUser", id_Usuario);

                cx.Open();
                int total = Convert.ToInt32(cmd.ExecuteScalar());
                cx.Close();

                return total;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el conteo de solicitudes: " + ex.Message);
            }
        }
        public int CountRequestEarrings(long id_Usuario) // Solicitudes Pendientes
        {
            SqlConnection cx = conexion.ObtenerConexion();
            try
            {
                string sql = @"SELECT COUNT(*) FROM Solicitudes INNER JOIN Usuario ON Solicitudes.id_UsuarioEstandar = Usuario.id_Usuario WHERE Solicitudes.estado_Solicitud = 'Pendiente'
                AND Usuario.id_Usuario = @IdUser";

                SqlCommand cmd = new SqlCommand(sql, cx);
                cmd.Parameters.AddWithValue("@IdUser", id_Usuario);

                cx.Open();
                int total = Convert.ToInt32(cmd.ExecuteScalar());
                cx.Close();

                return total;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el conteo de solicitudes: " + ex.Message);
            }
        }
        public int CountRequesteRected(long id_Usuario) // Solicitudes rechazadas
        {
            SqlConnection cx = conexion.ObtenerConexion();
            try
            {
                string sql = @"SELECT COUNT(*) FROM Solicitudes INNER JOIN Usuario ON Solicitudes.id_UsuarioEstandar = Usuario.id_Usuario WHERE Solicitudes.estado_Solicitud = 'Rechazada'
                AND Usuario.id_Usuario = @IdUser";

                SqlCommand cmd = new SqlCommand(sql, cx);
                cmd.Parameters.AddWithValue("@IdUser", id_Usuario);

                cx.Open();
                int total = Convert.ToInt32(cmd.ExecuteScalar());
                cx.Close();

                return total;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el conteo de solicitudes: " + ex.Message);
            }
        }
        public int CountAllRequestAproved() // Todas las solicitudes aprobadas
        {
            SqlConnection cx = conexion.ObtenerConexion();
            try
            {
                string sql = @"SELECT COUNT(*) FROM Solicitudes where estado_Solicitud = 'Aprobada'";

                SqlCommand cmd = new SqlCommand(sql, cx);

                cx.Open();
                int total = Convert.ToInt32(cmd.ExecuteScalar());
                cx.Close();

                return total;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el conteo de solicitudes: " + ex.Message);
            }
        }
        public int CountAllRequestEarrings() // Todas las solicitudes rechazadas
        {
            SqlConnection cx = conexion.ObtenerConexion();
            try
            {
                string sql = @"SELECT COUNT(*) FROM Solicitudes where estado_Solicitud = 'Pendiente'";

                SqlCommand cmd = new SqlCommand(sql, cx);

                cx.Open();
                int total = Convert.ToInt32(cmd.ExecuteScalar());
                cx.Close();

                return total;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el conteo de solicitudes: " + ex.Message);
            }
        }
        public int CountAllRequesteRected() // Todas las solicitudes rechazadas
        {
            SqlConnection cx = conexion.ObtenerConexion();
            try
            {
                string sql = @"SELECT COUNT(*) FROM Solicitudes where estado_Solicitud = 'Rechazada'";

                SqlCommand cmd = new SqlCommand(sql, cx);

                cx.Open();
                int total = Convert.ToInt32(cmd.ExecuteScalar());
                cx.Close();

                return total;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el conteo de solicitudes: " + ex.Message);
            }
        }


    }
}
