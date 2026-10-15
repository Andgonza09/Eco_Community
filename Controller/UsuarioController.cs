using Eco_Community.Model;
using Microsoft.Data.SqlClient;
using Model.Eco_Community;
using System;
using System.Collections.Generic;
using System.Configuration;
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
        public long Insert(UsuarioEntidad Usuario, int id_Rol)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            try
            {
                string sql = @"INSERT INTO Usuario(nombre_Usuario ,contraseña_Usuario, correo_Usuario, fecha_Registro, id_Roles) OUTPUT INSERTED.id_Usuario VALUES (@nombre_Usuario, @contraseña_Usuario,@correo_Usuario, GETDATE(), @id_Rol)";

                SqlCommand cmd = new SqlCommand(sql, cx);

                cmd.Parameters.AddWithValue("@nombre_Usuario", Usuario.nombre_Usuario);
                cmd.Parameters.AddWithValue("@contraseña_Usuario", Usuario.contraseña_Usuario);
                cmd.Parameters.AddWithValue("@correo_Usuario", Usuario.correo_Usuario);
                cmd.Parameters.AddWithValue("@id_Rol", id_Rol);


                cx.Open();
                long id_Usuario = Convert.ToInt64(cmd.ExecuteScalar());
                cx.Close();

                return id_Usuario;
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
        public bool UpdateUser(long id_Usuario,string newUsername, string newPassWord, string newEmail, int id_Roles)
        {
            int rowsAffected = 0; // Variable para almacenar el número de filas afectadas por la operación de actualización
            SqlConnection cx = conexion.ObtenerConexion();

            try
            {
                string sql = @"UPDATE Usuario SET nombre_Usuario = @NewUsername, contraseña_Usuario = @NewPassword, correo_Usuario = @EmailUser, id_Roles = @IdRoles WHERE id_Usuario = @IdUsuario";
                //OR contraseña_Usuario = @CurrentPassword OR correo_Usuario = @EmailUser;

                SqlCommand cmd = new SqlCommand(sql, cx);

                cmd.Parameters.AddWithValue("@IdUsuario", id_Usuario);
                cmd.Parameters.AddWithValue("@NewUsername", newUsername);
                cmd.Parameters.AddWithValue("@NewPassword", newPassWord);
                cmd.Parameters.AddWithValue("@EmailUser", newEmail);
                cmd.Parameters.AddWithValue("@IdRoles", id_Roles);
                // cmd.Parameters.AddWithValue("NewDate", newDate.ToDateTime(TimeOnly.MinValue));

                cx.Open();

                rowsAffected = cmd.ExecuteNonQuery();

                cx.Close();

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                if (cx.State == System.Data.ConnectionState.Open)
                    cx.Close();
                throw new Exception("Error al actualizar el usuario: " + ex.Message);
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

        public DataTable ListarUsuarios()    
        {
            SqlConnection cx = conexion.ObtenerConexion();

            string sql = @"SELECT TOP 20 u.id_Usuario,u.nombre_Usuario,u.contraseña_Usuario,u.correo_Usuario,u.fecha_Registro,u.id_Roles,
                            r.tipo_Roles FROM Usuario u INNER JOIN Roles r ON u.id_Roles = r.id_Roles ORDER BY u.id_Usuario DESC";

            SqlDataAdapter da = new SqlDataAdapter(sql, cx);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public DataTable BuscarUsuarioById(long id_Usuario)
        {
            SqlConnection cx = conexion.ObtenerConexion();

            string sql = @"SELECT u.id_Usuario, u.nombre_Usuario, u.contraseña_Usuario, 
                u.correo_Usuario, u.fecha_Registro, u.id_Roles, r.tipo_Roles FROM Usuario As u INNER JOIN Roles As r 
                ON u.id_Roles = r.id_Roles WHERE u.id_Usuario = @IdUser";

            SqlDataAdapter da = new SqlDataAdapter(sql, cx);

            da.SelectCommand.Parameters.AddWithValue(@"IdUser", id_Usuario);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }
        public int UsuarioExiste(string correo, string username)
        {
            SqlConnection cx = conexion.ObtenerConexion();
            try
            {
                string sql = @"SELECT COUNT(*) FROM Usuario WHERE correo_Usuario = @Correo OR nombre_Usuario = @NombreUsuario";
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
        public int CountAllUsers()
        {
            SqlConnection cx = conexion.ObtenerConexion();
            try
            {
                string sql = @"SELECT COUNT(*) FROM Usuario";

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
