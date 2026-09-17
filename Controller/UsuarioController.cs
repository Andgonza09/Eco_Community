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
        public void Insert(UsuarioEntidad Usuario)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            try
            {
                string sql = @"INSERT INTO Usuario(nombre_Usuario,contraseña_Usuario,correo_Usuario,fecha_Registro) VALUES (@nombre_Usuario, @contraseña_Usuario,@correo_Usuario,@fecha_Registro)";

                SqlCommand cmd = new SqlCommand(sql, cx);

                cmd.Parameters.AddWithValue("@nombre_Usuario", Usuario.nombre_Usuario);
                cmd.Parameters.AddWithValue("@contraseña_Usuario", Usuario.contraseña_Usuario);
                cmd.Parameters.AddWithValue("@correo_Usuario", Usuario.correo_Usuario);
                cmd.Parameters.AddWithValue("@fecha_Registro", Usuario.fecha_Registro = DateOnly.FromDateTime(DateTime.Now));


                cx.Open();
                cmd.ExecuteNonQuery();
                cx.Close();
            }
            catch
            {
                throw new Exception("Error al agregar el usuario");
            }
           
            
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
        public List<UsuarioEntidad> ViewAllUsers()
        {
            List<UsuarioEntidad> userList = new List<UsuarioEntidad>();

            try
            {
                SqlConnection cx = conexion.ObtenerConexion();

                string sql = @"SELECT * FROM Usuario";

                SqlCommand cmd = new SqlCommand(sql, cx);
                cx.Open();
                SqlDataReader result = cmd.ExecuteReader();

                while (result.Read())
                {
                    UsuarioEntidad usuario = new UsuarioEntidad();

                    usuario.id_Usuario = Convert.ToInt32(result["id_Usuario"]);
                    usuario.nombre_Usuario = result["nombre_Usuario"].ToString();
                    usuario.contraseña_Usuario = result["contraseña_Usuario"].ToString();
                    usuario.correo_Usuario = result["correo_Usuario"].ToString();
                    usuario.id_Roles = Convert.ToInt32(result["id_Roles"]);

                    userList.Add(usuario);
                }

                result.Close();

                return userList;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al mostrar los usuarios: " + ex.Message);
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
    }
}
