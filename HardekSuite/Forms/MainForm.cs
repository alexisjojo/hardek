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

        private void configure() {
            OpenFileDialog ofn = new OpenFileDialog();
            ofn.Filter = "Skin Files(*.msstyles)|*.msstyles";
            ofn.Title = "Select Skin";

            if (ofn.ShowDialog() == DialogResult.Cancel)
                return;

            USkin.USkinSDK.USkinLoadSkin(ofn.FileName);
            return;
            core.Modules.Targeting.AddTarget("All");
            core.Modules.Targeting.Targets[0].Action = Kedrah.Modules.Targeting.FightActions.Attack;
            core.Modules.Targeting.AttackedOnly = true;
            core.Modules.Targeting.TargetSelection["distance"] = 100;
            core.Modules.Targeting.TargetSelection["health"] = 75;
            core.Modules.Targeting.TargetSelection["priority"] = 50;
            core.Modules.Targeting.Attacker = true;

            return;

            core.Modules.General.EnableLevelSpyKeys();
            core.Modules.General.AvoidPitfalls = true;
            core.Modules.General.ClickReuse = true;
            core.Modules.General.EatFood = true;
            core.Modules.General.FramerateControl = true;
            core.Modules.General.WalkOverFields = true;
            core.Modules.Heal.SpellLife.Insert(new Kedrah.Modules.SpellPercent(80, "exura", 20));
            core.Modules.Heal.SpellLife.Insert(new Kedrah.Modules.SpellPercent(50, "exura gran", 70));
            core.Modules.Heal.Paralyze = true;
            core.Modules.Heal.PotionMana.Insert(new Kedrah.Modules.ItemPercent(50, Tibia.Constants.Items.Potion.Mana));
            core.Modules.Heal.Healer = true;
            Tibia.KeyboardHook.Add(System.Windows.Forms.Keys.End, new Tibia.KeyboardHook.KeyPressed(delegate() {
                if (core.Client.Window.IsActive && core.Client.LoggedIn) {
                    Tibia.Objects.Creature creature = core.BattleList.GetCreatures().ToList().Find(delegate(Tibia.Objects.Creature c) {
                        return c.Id == core.Player.Target_ID;
                    });

                    if (creature != null) {
                        core.Console.Say(core.Modules.Targeting.GetBestMageSpell(core.Modules.Targeting.FindMonster(creature.Name)));
                    }

                    return false;
                }
                return true;
            }));
        }

        public void HandleWheel(object sender, MouseEventArgs e) {
            mapViewer.Zoom((e.Delta > 0) ? 2 : .5);
            mapViewer.Invalidate();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            // Height fix
            int height = this.Height;

            USkin.USkinSDK.USkinInit("", "", "Skins\\Clearlooks.msstyles");

            // Height fix
            this.Height = height;

            mapViewer.LoadMap();

            this.MouseWheel += new MouseEventHandler(this.HandleWheel);

            if (core.Client.LoggedIn) {
                mapViewer.Markers.Add(new Tibia.Util.MapViewer.MapMarker(core.Player, true));
            }

            mapTimer.Start();
        }

        private void mapViewer_Click(object sender, EventArgs e) {
            if (core.Client.LoggedIn)
                core.Player.GoTo = mapViewer.PointToMapCoors(((MouseEventArgs)e).Location);
        }

        private void mapTimer_Execute() {
            if (core.Client.LoggedIn) {
                mapViewer.SetMapCenter(core.Player.Location);
                mapViewer.SetLevel(core.Player.Z);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            //configure();
            Kedrah.Util.WebServer web = new Kedrah.Util.WebServer("x");
            MessageBox.Show(web.Port.ToString());
            return;
            core.Modules.General.EnableLevelSpyKeys();
            core.Modules.General.AvoidPitfalls = true;
            core.Modules.General.ClickReuse = true;
            core.Modules.General.EatFood = true;
            core.Modules.General.FramerateControl = true;
            core.Modules.General.WalkOverFields = true;
            core.Modules.General.SpeedBoost = true;
            core.Client.Screen.DrawCreatureText(core.Player.Id, core.Player.Location, System.Drawing.Color.Firebrick, Tibia.Constants.ClientFont.NormalBorder, "testando =D");
            core.Client.Screen.DrawScreenText("xd", new Tibia.Objects.Location(5, 5, 0), System.Drawing.Color.FloralWhite, Tibia.Constants.ClientFont.NormalBorder, "oi amigo");
            core.Client.ContextMenu.AddContextMenu(1, "Menu Maroto", Tibia.Constants.ContextMenuType.AllMenus, true);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            USkin.USkinSDK.USkinRemoveSkin();
            USkin.USkinSDK.USkinExit();
        }


    }
}

