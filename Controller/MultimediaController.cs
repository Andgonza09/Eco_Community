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
    public class MultimediaController
    {
        Conexion conexion = new Conexion();

        public void Insert(MultimediaEntidad multimedia)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            string sql = @"INSERT INTO Multimedia(nombre_ArchivoMultimedia,tamaño_ArchivoMultimedia,ruta_ArchivoMultimedia,fecha_Adjuncion,id_Solicitud,id_Extension) 
                                                 VALUES (@nobre_ArchivoMultimedia,@tamaño_ArchivoMultimedia,@ruta_ArchivoMultimedia,@fecha_Adjuncion,@id_Solicitud,@id_Extension)";

            SqlCommand cmd = new SqlCommand(sql, cx);
            cmd.Parameters.AddWithValue(@"nombre_ArchivoMultimedia", multimedia.nombre_ArchivoMultimedia);
            cmd.Parameters.AddWithValue(@"tamaño_ArchivoMultimedia", multimedia.tamaño_ArchivoMultimedia);
            cmd.Parameters.AddWithValue(@"ruta_ArchivoMultimedia", multimedia.ruta_ArchivoMultimedia);
            cmd.Parameters.AddWithValue(@"fecha_Adjuncion", multimedia.fecha_Adjuncion);
            cmd.Parameters.AddWithValue(@"id_Solicitud", multimedia.id_Solicitud);
            cmd.Parameters.AddWithValue(@"id_Extension", multimedia.id_Extension);



            cx.Open();

            cmd.ExecuteNonQuery();

            cx.Close();
        }
    }
}
