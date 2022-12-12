using System.Reflection;

namespace AoSEE
{
    static class Global
    {
        public static string font = "Arial";
        public static string color = "Default";
        public static string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\result.txt";
    }
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
            Application.Run(new fDashBoard());
        }
    }
}