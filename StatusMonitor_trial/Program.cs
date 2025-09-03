using StatusMonitor_trial.Services;

namespace StatusMonitor_trial
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
            UserService.InitializeDefaultUser();
            UserService.LoadUsers(); 
            PrinterService.LoadPrinter();
            PathService.LoadPath();
            Application.Run(new LoginForm());
        }
    }
}