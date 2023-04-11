using System;
using System.Windows.Forms;

namespace MusicStore_App2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Forms.FormMainMenu());
            Application.Run(new Forms.FormLogin());
        }
    }
}
