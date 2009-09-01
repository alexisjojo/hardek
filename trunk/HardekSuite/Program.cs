using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HardekSuite {
    static class Program {
        /// <summary>
        /// Instance of the Core object.
        /// </summary>
        static public Kedrah.Core core;

        /// <summary>
        /// Instance of the main form.
        /// </summary>
        static public Forms.MainForm mainForm;

        /// <summary>
        /// Instance of the splash screen form;
        /// </summary>
        static private Forms.SplashScreenForm splashScreenForm;

        /// <summary>
        /// Instance of the healing form.
        /// </summary>
        static public Forms.HealingForm healingForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Instantiate the core object
            core = new Kedrah.Core("Hardek", true);

            if (core.Client == null)
                Environment.Exit(0);

            // Show splash screen
            splashScreenForm = new Forms.SplashScreenForm();
            splashScreenForm.Show();

            for (int i = 0; i < 100; i++) {
                Application.DoEvents();
                System.Threading.Thread.Sleep(5);
            }

            splashScreenForm.Close();

            // Create the main form
            mainForm = new Forms.MainForm();

            Application.ApplicationExit += new EventHandler(Close);
            ApplicationContext appContext = new ApplicationContext(mainForm);
            Application.Run(appContext);
        }

        public static void Close(object sender, EventArgs e) {
            ;
        }
    }
}
