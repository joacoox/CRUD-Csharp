using biblioteca;
using biblioteca.Base_de_datos_SQL;
using biblioteca.Logica_Usuarios;
using System.IO;

namespace parcialUno
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
              Application.Run(new InicioDeSesion());



           
        }
    }
}