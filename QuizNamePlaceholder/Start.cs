using QuizNamePlaceholder.DebugTests;
using QuizNamePlaceholder.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizNamePlaceholder
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            if (DebugManager.DEBUG_MODE)
            {
                DebugManager.RunTests();
                return;
            }
                
            Application.Run(new PantallaCarga());
        }
    }
}
