using Eco_Community.Model;
using Microsoft.Data.SqlClient;
using Model.Eco_Community;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks; 
using System.Windows;

namespace Controller 
{
    public class ArchivoCriteriosController
    {
        Conexion conexion = new Conexion();
        public void Insert(ArchivoCriteriosEntidad archivocriterios)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            string sql = @"INSERT INTO ArchivoCriterios(nombre_Archivo,ruta_Archivo) VALUES (@nombre_Archivo,@ruta_Archivo)";

            SqlCommand cmd = new SqlCommand(sql, cx);
            cmd.Parameters.AddWithValue(@"nombre_Archivo", archivocriterios.nombre_Archivo);
            cmd.Parameters.AddWithValue(@"ruta_Archivo", archivocriterios.ruta_Archivo);

            cx.Open();

            cmd.ExecuteNonQuery();

            cx.Close();
        }
        public void ChargeFile()
        {
            string pdfPath = Path.Combine(AppContext.BaseDirectory, "CriteriosUbicación\\criterios_ubicacion_puntos_ambientales.pdf");
            if (File.Exists(pdfPath))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = pdfPath,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("No se encontró el archivo PDF.");
            }
        }


    }
}
