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
    public class UsuarioController
    {
        Conexion conexion = new Conexion();
        public void Insert(UsuarioEntidad Usuario, int id_Rol)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            try
            {
                string sql = @"INSERT INTO Usuario(nombre_Usuario ,contraseña_Usuario, correo_Usuario, fecha_Registro, id_Roles) VALUES (@nombre_Usuario, @contraseña_Usuario,@correo_Usuario, GETDATE(), @id_Rol)";

                SqlCommand cmd = new SqlCommand(sql, cx);

                cmd.Parameters.AddWithValue("@nombre_Usuario", Usuario.nombre_Usuario);
                cmd.Parameters.AddWithValue("@contraseña_Usuario", Usuario.contraseña_Usuario);
                cmd.Parameters.AddWithValue("@correo_Usuario", Usuario.correo_Usuario);
                cmd.Parameters.AddWithValue("@id_Rol", id_Rol);


                cx.Open();
                cmd.ExecuteNonQuery();
                cx.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el usuario: " + ex.Message, ex);
            }


        }
        public void Delete(long id_Usuario)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            try
            {
                string sql = @"DELETE FROM Usuario WHERE id_Usuario = @Id_Usuario";
                SqlCommand cmd = new SqlCommand(sql, cx);

                cmd.Parameters.AddWithValue("@Id_Usuario", id_Usuario);
                cx.Open();
                cmd.ExecuteNonQuery();
                cx.Close();


            }
            catch(Exception ex)
            {
                throw new Exception("Error al eliminar la información: " + ex.Message);
            }
        }
        public bool UpdateUser(string newUsername, string newPassWord, string newEmail, string newDate)
        {
            int rowsAffected = 0; // Variable para almacenar el número de filas afectadas por la operación de actualización
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();

                string sql = @"UPDATE Usuario SET nombre_Usuario = @NewUsername, contraseña_Usuario = @NewPassword, correo_Usuario = @EmailUser WHERE nombre_Usuario = @CurrentUsername 
                OR contraseña_Usuario = @CurrentPassword OR correo_Usuario = @EmailUser";

                SqlCommand cmd = new SqlCommand(sql, cx);

                cmd.Parameters.AddWithValue("@NewUsername", newUsername);
                cmd.Parameters.AddWithValue("@NewPassword", newPassWord);
                cmd.Parameters.AddWithValue("@EmailUser", newEmail);

                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el usuario: " + ex.Message);
            }

            return rowsAffected > 0;
        }
        public UsuarioEntidad BuscarUsuario(string email, string password)
        {
            try
            {
                SqlConnection cx = conexion.ObtenerConexion();
                string sql = @"SELECT * FROM Usuario WHERE contraseña_Usuario = @Password AND correo_Usuario = @Email";

                SqlCommand cmd = new SqlCommand(sql, cx);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Email", email);

                cx.Open();

                UsuarioEntidad usuario = new UsuarioEntidad();
                SqlDataReader result = cmd.ExecuteReader();

                if (!result.Read())
                {
                    cx.Close();
                    return null;
                }

                usuario.id_Usuario = Convert.ToInt32(result["id_Usuario"]);
                usuario.nombre_Usuario = result["nombre_Usuario"].ToString();
                usuario.contraseña_Usuario = result["contraseña_Usuario"].ToString();
                usuario.correo_Usuario = result["correo_Usuario"].ToString();
                usuario.id_Roles = Convert.ToInt32(result["id_Roles"]);

                cx.Close();
                return usuario;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al encontrar el usuario: " + ex.Message);
            }
        }
        public List<(UsuarioEntidad, string)> ViewAllUsers()
        {
            SqlConnection cx = conexion.ObtenerConexion();
            List<(UsuarioEntidad, string)> ListaUsuario = new List<(UsuarioEntidad, string)>();
            try
            {
                string sql = @"SELECT u.id_Usuario, u.nombre_Usuario, u.contraseña_Usuario, 
                u.correo_Usuario, u.fecha_Registro, u.id_Roles, r.tipo_Roles FROM Usuario As u INNER JOIN Roles As r 
                ON u.id_Roles = r.id_Roles";
                SqlCommand cmd = new SqlCommand(sql, cx);

                cx.Open();
                using SqlDataReader reader = cmd.ExecuteReader();
               
                while (reader.Read())
                {
                    string tipoRol = reader.GetString(reader.GetOrdinal("tipo_Roles"));

                    UsuarioEntidad usuario = new UsuarioEntidad()
                    {

                        id_Usuario = Convert.ToInt32(reader["id_Usuario"]),
                        nombre_Usuario = reader["nombre_Usuario"].ToString() ?? string.Empty,
                        contraseña_Usuario = reader["contraseña_Usuario"].ToString() ?? string.Empty,
                        correo_Usuario = reader.GetString(reader.GetOrdinal("correo_usuario")),
                        fecha_Registro = DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("fecha_Registro"))),
                        id_Roles = reader.GetInt32(reader.GetOrdinal("id_Roles"))
                    };
                    ListaUsuario.Add((usuario, tipoRol));
                }
                cx.Close();
                return ListaUsuario;

            }
            catch (Exception ex)
            {
                throw new Exception("Error en la busqueda del usuario: " + ex.Message);
            }
        }

        public List<(UsuarioEntidad, string)> BuscarUsuarioById(long id_Usuario)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            List<(UsuarioEntidad, string)> ListaUsuario = new List<(UsuarioEntidad, string)>();
            try
            {
                string sql = @"SELECT u.id_Usuario, u.nombre_Usuario, u.contraseña_Usuario, 
                u.correo_Usuario, u.fecha_Registro, u.id_Roles, r.tipo_Roles FROM Usuario As u INNER JOIN Roles As r 
                ON u.id_Roles = r.id_Roles where id_Usuario = @IdUser";
                SqlCommand cmd = new SqlCommand(sql, cx);

                cmd.Parameters.AddWithValue("@IdUser", id_Usuario);
                cx.Open();
                using SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string tipoRol = reader.GetString(reader.GetOrdinal("tipo_Roles"));

                    UsuarioEntidad usuario = new UsuarioEntidad()
                    {

                        id_Usuario = Convert.ToInt32(reader["id_Usuario"]),
                        nombre_Usuario = reader["nombre_Usuario"].ToString() ?? string.Empty,
                        contraseña_Usuario = reader["contraseña_Usuario"].ToString() ?? string.Empty,
                        correo_Usuario = reader.GetString(reader.GetOrdinal("correo_usuario")),
                        fecha_Registro = DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("fecha_Registro"))),
                        id_Roles = reader.GetInt32(reader.GetOrdinal("id_Roles"))

                    };
                    ListaUsuario.Add((usuario, tipoRol));
                }
                cx.Close();
                return ListaUsuario;

            }
            catch (Exception ex)
            {
                throw new Exception("Error en la busqueda del usuario: " + ex.Message);
            }
            
        }
        public int UsuarioExiste(string correo, string username)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            try
            {
                string sql = @"SELECT COUNT(*) FROM Usuario WHERE correo_Usuario = @Correo AND nombre_Usuario = @NombreUsuario";
                SqlCommand cmd = new SqlCommand(sql, cx);

                cx.Open();
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@NombreUsuario", username);
                int cantidad = (int)cmd.ExecuteScalar();

                cx.Close();
                return cantidad;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el usuario: " + ex.Message);
            }
        }
    }
}
