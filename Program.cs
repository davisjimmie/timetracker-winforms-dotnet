using Microsoft.Extensions.DependencyInjection;
using TimeTracker;
using TimeTracker.Application.Interfaces.UseCases;
using TimeTracker.Presentation.Components;
using TimeTracker.Presentation.Forms;

internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new StartForm());
        }
    }