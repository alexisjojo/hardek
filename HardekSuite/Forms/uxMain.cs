using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HardekSuite.Forms {
    public partial class uxMain : Form {
        Kedrah.Core Core = Program.Core;
        private bool close = false;

        public uxMain() {
            InitializeComponent();
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e) {
            this.Visible = !this.Visible;
        }

        private void ExitMenu_Click(object sender, EventArgs e) {
            close = true;
            Application.Exit();
        }

        private void uxMain_FormClosing(object sender, FormClosingEventArgs e) {
            if (!close) {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void toggleShortcuts_Click(object sender, EventArgs e) {
            if (shortCutsGroup.Visible) {
                toggleShortcuts.Image = (Image)HardekSuite.Properties.Resources.maximize;
                shortCutsGroup.Hide();
            }
            else {
                toggleShortcuts.Image = (Image)HardekSuite.Properties.Resources.minimize;
                shortCutsGroup.Show();
            }
        }

        private void toggleGeneral_Click(object sender, EventArgs e) {
            if (generalGroup.Visible) {
                toggleGeneral.Image = (Image)HardekSuite.Properties.Resources.maximize;
                generalGroup.Hide();
            }
            else {
                toggleGeneral.Image = (Image)HardekSuite.Properties.Resources.minimize;
                generalGroup.Show();
            }
        }

        private void toggleCore_Click(object sender, EventArgs e) {
            if (coreGroup.Visible) {
                toggleCore.Image = (Image)HardekSuite.Properties.Resources.maximize;
                coreGroup.Hide();
            }
            else {
                toggleCore.Image = (Image)HardekSuite.Properties.Resources.minimize;
                coreGroup.Show();
            }
        }

        private void toggleSettings_Click(object sender, EventArgs e) {
            if (settingsGroup.Visible) {
                toggleSettings.Image = (Image)HardekSuite.Properties.Resources.maximize;
                settingsGroup.Hide();
            }
            else {
                toggleSettings.Image = (Image)HardekSuite.Properties.Resources.minimize;
                settingsGroup.Show();
            }
        }

        private void healingButton_Click(object sender, EventArgs e) {
            if (Program.uxHealing == null)
                Program.uxHealing = new Forms.uxHealing();

            Program.uxHealing.Show();
        }
    }
}

