using Eco_Community.Model;
using Microsoft.Data.SqlClient;
using Model.Eco_Community;
using System.Data;

namespace Controller
{
    public class SolicitudesController
    {
        Conexion conexion = new Conexion();
        public long InsertarSolicitudes(SolicitudesEntidad solicitudes, long id_Usuario, long id_InformacionSitio)
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

        public void EliminarSolicitudes(long id_Solicitud)
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
        public void EliminarSolicitudes_PorIdUsuario(long id_Usuario)
        {
            try
            {
                SqlConnection ex = conexion.ObtenerConexion();
                string sql = @"DELETE FROM Solicitudes WHERE id_UsuarioEstandar = @id_Usuario";

                //Parametros enviados al SQL
                SqlCommand cmd = new SqlCommand(sql, ex);
                cmd.Parameters.AddWithValue("@id_Usuario", id_Usuario);

                ex.Open();
                cmd.ExecuteNonQuery();
                ex.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar solicitud: " + ex.Message);
            }
        }
        public void EliminarSolicitudes_PorIdInformacionSitio(long id_InformacionSitio)
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
        public void ActualizarSolicitudes(long id_Request, string stateRequest)
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();
                string sql = @"UPDATE Solicitudes SET estado_Solicitud = @StateRequest, fecha_Resolucion = GETDATE() WHERE id_Solicitud = @IdRequest";

                SqlCommand cmd = new SqlCommand(sql, cx);
                cmd.Parameters.AddWithValue("IdRequest", id_Request);
                cmd.Parameters.AddWithValue("StateRequest", stateRequest);

                cx.Open();
                cmd.ExecuteNonQuery();
                cx.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la solicitud" + ex.Message);

            }
        }
        public long ObtenerIdSolicitud(long id_InformacionSitio)
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


        public DataTable ListarSolicitudes()
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();
                string sql = @"SELECT TOP 20 s.id_Solicitud,s.estado_Solicitud, s.fecha_Solicitud, s.fecha_Resolucion, i.tipoSitio, i.direccion,
                              u.nombre_Usuario FROM Solicitudes s INNER JOIN InformacionSitio i  ON s.id_InformacionSitio = i.id_InformacionSitio INNER JOIN Usuario u
                              ON u.id_Usuario = s.id_UsuarioEstandar ORDER BY s.id_Solicitud DESC";

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar todas las solicitudes del sistema: " + ex.Message);
            }
        }

        public DataTable BuscarSolicitud_PorIdSolicitud(long id_Solicitud)
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();
                string sql = @"SELECT s.id_Solicitud, s.estado_Solicitud, s.fecha_Solicitud,
                                s.fecha_Resolucion, i.tipoSitio, i.direccion, u.nombre_Usuario
                                FROM Solicitudes AS s INNER JOIN InformacionSitio AS i ON s.id_InformacionSitio = i.id_InformacionSitio
                                INNER JOIN Usuario AS u ON u.id_Usuario = s.id_UsuarioEstandar
                                WHERE s.id_Solicitud = @id_Solicitud";

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);
                da.SelectCommand.Parameters.AddWithValue("@id_Solicitud", id_Solicitud);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar la solicitud: " + ex.Message);
            }
        }
        public DataTable ObtenerIdsSolicitudes_AsociadasDistritos(int id_Distrito)
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();
                string sql = @"SELECT S.id_Solicitud FROM Solicitudes AS S INNER JOIN InformacionSitio AS I
                ON S.id_InformacionSitio = I.id_InformacionSitio INNER JOIN Barrio AS B ON I.id_Barrio = B.id_Barrio
                WHERE B.id_Distrito = @idDistrito";

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);
                da.SelectCommand.Parameters.AddWithValue("@idDistrito", id_Distrito);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar la solicitud: " + ex.Message);
            }
        }
        public DataTable ListarSolicitudesPorBusqueda_IdUsuario(long id_Usuario)
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();
                string sql = @"SELECT s.id_Solicitud, s.estado_Solicitud, s.fecha_Solicitud,
                s.fecha_Resolucion, i.tipoSitio, i.direccion FROM Solicitudes AS s INNER JOIN InformacionSitio AS i
                ON s.id_InformacionSitio = i.id_InformacionSitio WHERE s.id_UsuarioEstandar = @IdUsuario";
            

                //SqlCommand cmd = new SqlCommand(sql, cx);
                SqlDataAdapter da = new SqlDataAdapter(sql, cx);
                da.SelectCommand.Parameters.AddWithValue("@IdUsuario", id_Usuario);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar la información" + ex.Message);
            }
        }
        public int ContarSolicitudesAprobadas_PorUsuario(long id_Usuario) // Solicitudes Aprobadas
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
        public int ContarSolicitudesPendientes_PorUsuario(long id_Usuario) // Solicitudes Pendientes
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
        public int ContarSolicitudesRechazadas_PorUsuario(long id_Usuario) // Solicitudes rechazadas
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
        public int ContarTodas_SolicitudesAprobadas() // Todas las solicitudes aprobadas
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
        public int ContarTodas_SolicitudesPendientes() // Todas las solicitudes pendientes
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
        public int ContarTodas_SolicitudesRechazadas() // Todas las solicitudes rechazadas
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

        public long ObtenerIdDelSitio_PorIdSolicitud(long id_Solicitud)
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();

                string sql = @"SELECT id_InformacionSitio
                       FROM Solicitudes
                       WHERE id_Solicitud = @id_Solicitud";

                SqlCommand cmd = new SqlCommand(sql, cx);

                cmd.Parameters.AddWithValue("@id_Solicitud", id_Solicitud);

                cx.Open();
                object resultado = cmd.ExecuteScalar();
                cx.Close();

                if (resultado == null)
                    return 0;

                return Convert.ToInt64(resultado);
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Error al obtener la información del sitio: "
                    + ex.Message
                );
            }
        }
        public List<long> ObtenerIdsSolicitudes_PorIdExtension(int id_Extension)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            List<long> lista_Solicitudes = new List<long>();

            try
            {
                string sql = @"select S.id_Solicitud FROM Solicitudes As S
                INNER JOIN Multimedia AS M ON M.id_Solicitud = S.id_Solicitud INNER JOIN Extension AS E ON E.id_Extension = M.id_Extension
                where E.id_Extension = @id_Extension";

                SqlCommand cmd = new SqlCommand(sql, cx);
                cmd.Parameters.AddWithValue("@id_Extension", id_Extension);

                cx.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    long id_Solicitud = reader.GetInt64(reader.GetOrdinal("id_Solicitud"));
                    lista_Solicitudes.Add(id_Solicitud);
                }

                cx.Close();
                return lista_Solicitudes;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar las solicitudes: " + ex.Message);
            }
        }
        public List<long> ObtenerIdsSolicitudes_PorIDCatalogo(int id_Catalogo)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            List<long> lista_Solicitudes = new List<long>();

            try
            {
                string sql = @"Select S.id_Solicitud From Solicitudes AS S INNER JOIN InformacionSitio AS I 
                ON I.id_InformacionSitio = S.id_InformacionSitio INNER JOIN DetalleClasificacionSitio AS De ON De.id_InformacionSitio = I.id_InformacionSitio
                INNER JOIN CatalogoResiduos AS C ON C.id_CatalogoResiduos = De.id_CatalogoResiduos WHERE C.id_CatalogoResiduos = @id_Catalogo";

                SqlCommand cmd = new SqlCommand(sql, cx);
                cmd.Parameters.AddWithValue("@id_Catalogo", id_Catalogo);

                cx.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    long id_Solicitud = reader.GetInt64(reader.GetOrdinal("id_Solicitud"));
                    lista_Solicitudes.Add(id_Solicitud);
                }

                cx.Close();
                return lista_Solicitudes;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar las solicitudes: " + ex.Message);
            }
        }
    }
}
