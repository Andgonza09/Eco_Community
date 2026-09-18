using Eco_Community.Model;
using Microsoft.Data.SqlClient;
using Model.Eco_Community;
using System;
using System.Collections.Generic;
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
        public void DeleteMultimedia(long id_Solicitud)
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
    }
}
