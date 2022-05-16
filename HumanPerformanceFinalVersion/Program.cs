namespace HumanPerformanceFinalVersion
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<string> nombre = new List<string>();
            List<string> usuario = new List<string>();
            List<string> contrasena = new List<string>();
            List<string> tipoUsuario = new List<string>();
            List<string> calificacion = new List<string>();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new InicioSesion(nombre,usuario,contrasena,tipoUsuario,calificacion));
        }
    }
}