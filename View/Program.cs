using Model.Eco_Community;

namespace View
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            UsuarioEntidad usuario = new UsuarioEntidad();

            Application.Run(new frmLoginUsuario(usuario, usuario.nombre_Usuario, usuario.contraseña_Usuario));
        }
    }
}