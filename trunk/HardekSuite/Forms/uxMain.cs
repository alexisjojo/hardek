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
            if (uxShortcutsGroup.Visible) {
                uxToggleShortcuts.Image = (Image)HardekSuite.Properties.Resources.maximize;
                uxShortcutsGroup.Hide();
            }
            else {
                uxToggleShortcuts.Image = (Image)HardekSuite.Properties.Resources.minimize;
                uxShortcutsGroup.Show();
            }
        }

        private void toggleGeneral_Click(object sender, EventArgs e) {
            if (uxGeneralGroup.Visible) {
                uxToggleGeneral.Image = (Image)HardekSuite.Properties.Resources.maximize;
                uxGeneralGroup.Hide();
            }
            else {
                uxToggleGeneral.Image = (Image)HardekSuite.Properties.Resources.minimize;
                uxGeneralGroup.Show();
            }
        }

        private void toggleCore_Click(object sender, EventArgs e) {
            if (uxCoreGroup.Visible) {
                uxToggleCore.Image = (Image)HardekSuite.Properties.Resources.maximize;
                uxCoreGroup.Hide();
            }
            else {
                uxToggleCore.Image = (Image)HardekSuite.Properties.Resources.minimize;
                uxCoreGroup.Show();
            }
        }

        private void toggleSettings_Click(object sender, EventArgs e) {
            if (uxSettingsGroup.Visible) {
                uxToggleSettings.Image = (Image)HardekSuite.Properties.Resources.maximize;
                uxSettingsGroup.Hide();
            }
            else {
                uxToggleSettings.Image = (Image)HardekSuite.Properties.Resources.minimize;
                uxSettingsGroup.Show();
            }
        }

        private void healingButton_Click(object sender, EventArgs e) {
            if (Program.uxHealing == null)
                Program.uxHealing = new Forms.uxHealing();

            Program.uxHealing.Show();
        }

        private void uxCommandsButton_Click(object sender, EventArgs e)
        {
            Core.Modules.Looter.AddLootByRatio(10);
            Core.Modules.Looter.Looting = true;
            Core.Modules.Targeting.AddAllCreatures(Kedrah.Constants.FightActions.Attack, 0, Kedrah.Constants.FightSecurity.Automatic, Kedrah.Constants.FightStances.Follow, Tibia.Constants.Attack.FullAttack, Tibia.Constants.Follow.FollowClose);
            Core.Modules.Targeting.Attacker = true;
            Core.Modules.General.EnableLevelSpyKeys();
            Core.Modules.Cavebot.Shovel = Tibia.Constants.Items.Tool.LightShovel;
            Core.Modules.Cavebot.Rope = Tibia.Constants.Items.Tool.ElvenhairRope;
            Core.Modules.Cavebot.Walk = true;
        }

        private void uxContextButton_Click(object sender, EventArgs e)
        {
            Core.Modules.Cavebot.Waypoints.Add(new Kedrah.Objects.Waypoint(Core.Player.Location, Kedrah.Constants.WaypointType.Node, Core));
        }
    }
}

