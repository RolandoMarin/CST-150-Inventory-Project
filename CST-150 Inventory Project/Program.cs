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
            Application.Run(new CST_150_Inventory_Project.Resources.SplashScreen());
            Application.Run(new CST_150_Inventory_Project.Resources.MainForm());
        }
    }
}