/*rolando marin-galvan
 * CST-150
 * 11/06/22
 * Milestone 2
 * This was my own work
 */
namespace CST_150_Inventory_Project
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
            Application.Run(new Resources.SplashScreen());
            Application.Run(new Resources.MainForm());
        }
    }
}