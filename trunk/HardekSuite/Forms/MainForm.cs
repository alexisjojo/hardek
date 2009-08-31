using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HardekSuite.Forms {
    public partial class MainForm : Form {
        Kedrah.Core core = Program.core;

        public MainForm() {
            InitializeComponent();
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e) {
            this.Visible = !this.Visible;
        }

        private void ExitMenu_Click(object sender, EventArgs e) {
            this.Dispose();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.IsBalloon = true;
            toolTip1.UseAnimation = true;
            toolTip1.UseFading = true;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "button info";

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.commandsButton, "My button1");
            toolTip1.SetToolTip(this.contextMenuButton, "My checkBox1");
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
    }
}

