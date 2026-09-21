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
    public class DetalleConsultaArchivoController
    {
        Conexion conexion = new Conexion();
        public void Insert(long id_Usuario)
        {
            DetalleConsultaArchivoEntidad detalleConsultaArchivo = new DetalleConsultaArchivoEntidad();
            UsuarioEntidad usuario = new UsuarioEntidad()
            {
                id_Usuario = detalleConsultaArchivo.id_Usuario
            };
            SqlConnection cx = conexion.ObtenerConexion();
            string sql = @"INSERT INTO DetalleConsultaArchivo(fechaConsulta,id_Usuario,id_ArchivoCriterio) VALUES (GETDATE(), @id_Usuario, @id_ArchivoCriterio)";

            SqlCommand cmd = new SqlCommand(sql, cx);
            cmd.Parameters.AddWithValue(@"id_Usuario", usuario.id_Usuario); // Traemos el id de la entidad del usuario obtenido 
            cmd.Parameters.AddWithValue(@"id_ArchivoCriterio", 1); // El id siempre será el 1 ya que es un único archivo dentro del sistema

            cx.Open();

            cmd.ExecuteNonQuery();

            cx.Close();

        }
    }
}
