using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HardekSuite {
    static class Program {
        static public Kedrah.Core Core;
        static public Forms.uxHealing uxHealing;
        static public Forms.uxLoot uxLoot;
        static public Forms.uxTargeting uxTargeting;

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Core = new Kedrah.Core("Hardek", "Hardek", true, false);

            if (Core.Client == null)
                Environment.Exit(0);

            Application.Run(new Forms.uxMain());
        }
    }
}
