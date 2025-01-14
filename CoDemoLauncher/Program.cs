﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;
using CoDemoLauncher.Helper;

namespace CoDemoLauncher
{
    static class Program
    {
        public const string CoDemoLauncherIniGroup = "CoDemoLauncher";
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
            string coInstallLocation = GameClient.FindCoDirectory();

            // Create the form, if a valid path was found
            if (!coInstallLocation.Equals(""))
            {
                ConfigurationFile.GetInstance().PutValue(CoDemoLauncherIniGroup, VersionIniKey, Application.ProductVersion);
                SplashScreen.ShowSplashScreen();
                CoDemoLauncherForm mainWindow = new CoDemoLauncherForm(new GameClient(coInstallLocation));
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
