using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;
using CoDemoLauncher.Helper;

namespace CoDemoLauncher
{
    static class Program
    {
        public const string StoDemoLauncherIniGroup = "CoDemoLauncher";
        public const string VersionIniKey = "version";

        /// <summary>
        /// Main entry point for Application
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Find the installation location of STO
            string stoInstallLocation = GameClient.FindCoDirectory();

            // Create the form, if a valid path was found
            if (!stoInstallLocation.Equals(""))
            {
                ConfigurationFile.GetInstance().PutValue(StoDemoLauncherIniGroup, VersionIniKey, Application.ProductVersion);
                SplashScreen.ShowSplashScreen();
                CoDemoLauncherForm mainWindow = new CoDemoLauncherForm(new GameClient(stoInstallLocation));
                SplashScreen.CloseSplashScreen();
                Application.Run(mainWindow);
            }
            // Quit the application, if no valid path was found
            else
            {
                Application.Exit();
            }
        }
    }
}
