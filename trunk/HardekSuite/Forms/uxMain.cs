using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AIMS.Libraries.CodeEditor.SyntaxFiles;
using AIMS.Libraries.CodeEditor.Syntax;

namespace HardekSuite.Forms
{
    public partial class uxMain : Form
    {
        Kedrah.Core Core = Program.Core;
        private bool close = false;

        public uxMain()
        {
            InitializeComponent();
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = !this.Visible;
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            close = true;
            uxTray.Visible = false;
            Environment.Exit(0);
        }

        private void uxMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!close)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void toggleShortcuts_Click(object sender, EventArgs e)
        {
            if (uxShortcutsGroup.Visible)
            {
                uxToggleShortcuts.Image = (Image)HardekSuite.Properties.Resources.maximize;
                uxShortcutsGroup.Hide();
            }
            else
            {
                uxToggleShortcuts.Image = (Image)HardekSuite.Properties.Resources.minimize;
                uxShortcutsGroup.Show();
            }
        }

        private void toggleGeneral_Click(object sender, EventArgs e)
        {
            if (uxGeneralGroup.Visible)
            {
                uxToggleGeneral.Image = (Image)HardekSuite.Properties.Resources.maximize;
                uxGeneralGroup.Hide();
            }
            else
            {
                uxToggleGeneral.Image = (Image)HardekSuite.Properties.Resources.minimize;
                uxGeneralGroup.Show();
            }
        }

        private void toggleCore_Click(object sender, EventArgs e)
        {
            if (uxCoreGroup.Visible)
            {
                uxToggleCore.Image = (Image)HardekSuite.Properties.Resources.maximize;
                uxCoreGroup.Hide();
            }
            else
            {
                uxToggleCore.Image = (Image)HardekSuite.Properties.Resources.minimize;
                uxCoreGroup.Show();
            }
        }

        private void toggleSettings_Click(object sender, EventArgs e)
        {
            if (uxSettingsGroup.Visible)
            {
                uxToggleSettings.Image = (Image)HardekSuite.Properties.Resources.maximize;
                uxSettingsGroup.Hide();
            }
            else
            {
                uxToggleSettings.Image = (Image)HardekSuite.Properties.Resources.minimize;
                uxSettingsGroup.Show();
            }
        }

        private void healingButton_Click(object sender, EventArgs e)
        {
            if (Program.uxHealing == null)
                Program.uxHealing = new Forms.uxHealing();

            Program.uxHealing.Show();
        }

        private void uxTargetingButton_Click(object sender, EventArgs e)
        {
            if (Program.uxTargeting == null)
                Program.uxTargeting = new Forms.uxTargeting();

            Program.uxTargeting.Show();
        }

        private void uxLooterButton_Click(object sender, EventArgs e)
        {
            if (Program.uxLoot == null)
                Program.uxLoot = new Forms.uxLoot();

            Program.uxLoot.Show();
        }

        private void uxTimer_Tick(object sender, EventArgs e)
        {
            if (!Core.Client.Window.IsActive && TopMost)
            {
                TopMost = false;
            }
            else if (Core.Client.Window.IsActive && !TopMost)
            {
                TopMost = true;
            }
        }

        private void uxChargerButton_Click(object sender, EventArgs e)
        {
            Core.Client.Input.SendKeys(Keys.F1);
        }

        private void uxLoadButton_Click(object sender, EventArgs e)
        {
            Core.Client.Input.SendKeys(Keys.F11);
        }
    }
}


