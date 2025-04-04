using Client;
namespace Interfaz

{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Llama a la función Main del módulo F#
            Client.clientActions.main(null); // Asegúrate de que el nombre del módulo y la función sean correctos


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form2());
        }
    }
}