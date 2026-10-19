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
    public class MultimediaController
    {
        Conexion conexion = new Conexion();

        public void Insert(MultimediaEntidad multimedia, long id_Solicitud, int id_Extension)
        {
            SqlConnection cx = conexion.ObtenerConexion();

            string sql = @"INSERT INTO Multimedia(nombre_ArchivoMultimedia, tamaño_ArchivoMultimedia, ruta_ArchivoMultimedia, fecha_Adjuncion, id_Solicitud, id_Extension) 
                                                 VALUES (@nombre_ArchivoMultimedia, @tamaño_ArchivoMultimedia, @ruta_ArchivoMultimedia, GETDATE(), @id_Solicitud, @id_Extension)";

            SqlCommand cmd = new SqlCommand(sql, cx);
            cmd.Parameters.AddWithValue(@"nombre_ArchivoMultimedia", multimedia.nombre_ArchivoMultimedia);
            cmd.Parameters.AddWithValue(@"tamaño_ArchivoMultimedia", multimedia.tamaño_ArchivoMultimedia);
            cmd.Parameters.AddWithValue(@"ruta_ArchivoMultimedia", multimedia.ruta_ArchivoMultimedia);
            cmd.Parameters.AddWithValue(@"id_Solicitud", id_Solicitud);
            cmd.Parameters.AddWithValue(@"id_Extension", id_Extension);

            cx.Open();
            cmd.ExecuteNonQuery();
            cx.Close();
        }
        // Método para eliminar del todo el último archivo multimedia de una solicitud específica
        public void DeleteMultimedia_ByRequest(long id_Solicitud)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            try
            {
                string sql = @"Delete FROM Multimedia WHERE id_Solicitud = @id_Solicitud";

                //Parametros enviados al SQL
                SqlCommand cmd = new SqlCommand(sql, cx);
                cmd.Parameters.AddWithValue("@id_Solicitud", id_Solicitud);

                cx.Open();
                cmd.ExecuteNonQuery();
                cx.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar archivo multimedia: " + ex.Message);
            }
        }
        // Método para eliminar un archivo multimedia específico por su ID
        public void DeleteMultimediaById(long idMultimedia)
        {
            SqlConnection cx = conexion.ObtenerConexion();

            try
            {
                string sql = @"DELETE FROM Multimedia WHERE id_Multimedia = @idMultimedia";

                SqlCommand cmd = new SqlCommand(sql, cx);

                cmd.Parameters.AddWithValue("@idMultimedia", idMultimedia);

                cx.Open();
                cmd.ExecuteNonQuery();
                cx.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Error al eliminar el archivo multimedia: "
                    + ex.Message
                );
            }
        }
        // Método para eliminar la multimedia mediante el id del usuario relacionado con las solicitudes
        public void DeleteMultimedia_PorUsuario(long id_Usuario)
        {
            SqlConnection cx = conexion.ObtenerConexion();

            try
            {
                string sql = @"DELETE M FROM Multimedia AS M INNER JOIN Solicitudes AS S ON S.id_Solicitud = M.id_Solicitud
                INNER JOIN Usuario AS U ON U.id_Usuario = S.id_UsuarioEstandar WHERE U.id_Usuario = @id_Usuario";

                SqlCommand cmd = new SqlCommand(sql, cx);

                cmd.Parameters.AddWithValue("@id_Usuario", id_Usuario);

                cx.Open();
                cmd.ExecuteNonQuery();
                cx.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Error al eliminar el archivo multimedia: "
                    + ex.Message
                );
            }
        }

        public void DeleteMultimedia_PorExtension(int id_Extension)
        {
            SqlConnection cx = conexion.ObtenerConexion();

            try
            {
                string sql = @"DELETE FROM Multimedia WHERE id_Extension = @idExtension";

                SqlCommand cmd = new SqlCommand(sql, cx);

                cmd.Parameters.AddWithValue("@idExtension", id_Extension);

                cx.Open();
                cmd.ExecuteNonQuery();
                cx.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Error al eliminar el archivo multimedia: "
                    + ex.Message
                );
            }
        }

        public void UpdateMultimedia(long id_Multimedia, string nombre_Archivo, string ruta_Archivo, string tamañonArchivo, int extension, DateOnly fecha_Adjunción)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            try
            {
                string sql = @"UPDATE Multimedia SET nombre_ArchivoMultimedia = @nombre_ArchivoMultimedia, ruta_ArchivoMultimedia = @ruta_ArchivoMultimedia, id_Extension = @id_Extension WHERE id_Multimedia = @id_Multimedia";
                //Parametros enviados al SQL
                SqlCommand cmd = new SqlCommand(sql, cx);
                cmd.Parameters.AddWithValue("@nombre_ArchivoMultimedia", nombre_Archivo);
                cmd.Parameters.AddWithValue("@ruta_ArchivoMultimedia", ruta_Archivo);
                cmd.Parameters.AddWithValue("@id_Extension", extension);
                cmd.Parameters.AddWithValue("@id_Multimedia", id_Multimedia);
                cx.Open();
                cmd.ExecuteNonQuery();
                cx.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar archivo multimedia: " + ex.Message);
            }

        }
        public DataTable ListAllMultimedia()
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();
                string sql = @"SELECT id_Multimedia, nombre_ArchivoMultimedia, tamaño_ArchivoMultimedia, ruta_archivoMultimedia, fecha_Adjuncion,
                Usuario.nombre_Usuario, Solicitudes.id_Solicitud, Extension.tipo_Extension FROM Multimedia INNER JOIN Solicitudes
                ON Solicitudes.id_Solicitud = Multimedia.id_Solicitud INNER JOIN Extension ON Extension.id_Extension = Multimedia.id_Extension
                INNER JOIN Usuario ON Usuario.id_Usuario = Solicitudes.id_UsuarioEstandar;";

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar todos los archivos multimedia del sistema: " + ex.Message);
            }
        }
        public DataTable ListMultimedia_ByUser(long id_Usuario)
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();
                string sql = @"SELECT id_Multimedia, nombre_ArchivoMultimedia, tamaño_ArchivoMultimedia, ruta_ArchivoMultimedia, fecha_Adjuncion, Solicitudes.id_Solicitud, tipo_Extension FROM Multimedia 
                INNER JOIN Solicitudes ON Solicitudes.id_Solicitud = Multimedia.id_Solicitud 
                INNER JOIN Extension ON Extension.id_Extension = Multimedia.id_Extension Where id_UsuarioEstandar = @id_Usuario";

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);
                da.SelectCommand.Parameters.AddWithValue("@id_Usuario", id_Usuario);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar archivos multimedia por ID de usuario: " + ex.Message);
            }
        }
        public DataTable search_ByIdRequest(long id_Solicitud)
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();
                string sql = @"SELECT id_Multimedia, nombre_ArchivoMultimedia, tamaño_ArchivoMultimedia, ruta_archivoMultimedia, fecha_Adjuncion,
                Usuario.nombre_Usuario, Solicitudes.id_Solicitud, Extension.tipo_Extension FROM Multimedia INNER JOIN Solicitudes
                ON Solicitudes.id_Solicitud = Multimedia.id_Solicitud INNER JOIN Extension ON Extension.id_Extension = Multimedia.id_Extension
                INNER JOIN Usuario ON Usuario.id_Usuario = Solicitudes.id_UsuarioEstandar WHERE Solicitudes.id_Solicitud = @id_Solicitud;";

                SqlDataAdapter da = new SqlDataAdapter(sql, cx);
                da.SelectCommand.Parameters.AddWithValue("@id_Solicitud", id_Solicitud);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar archivos multimedia por ID de solicitud: " + ex.Message);
            }
        }
        public int CountMultimediaByRequestId(long id_Solicitud)
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();
                string sql = @"SELECT COUNT(*) FROM Multimedia WHERE id_Solicitud = @id_Solicitud;";
                SqlCommand cmd = new SqlCommand(sql, cx);
                cmd.Parameters.AddWithValue("@id_Solicitud", id_Solicitud);
                cx.Open();
                int count = (int)cmd.ExecuteScalar();
                cx.Close();
                return count;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al contar archivos multimedia por ID de solicitud: " + ex.Message);
            }
        }
    }
}
