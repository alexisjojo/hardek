using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HardekSuite.Forms
{
    public partial class uxLoot : Form
    {
        private Kedrah.Core Core = Program.Core;

        public uxLoot()
        {
            InitializeComponent();
        }

        private void uxOpenDistant_CheckedChanged(object sender, EventArgs e)
        {
            Core.Modules.Looter.OpenDistantBodies = uxOpenDistant.Checked;
        }

        private void uxLoot_Load(object sender, EventArgs e)
        {
            uxEnable.Enabled = Core.Client.LoggedIn;

            Core.Proxy.PlayerLogin += new EventHandler(OnLogin);
            Core.Proxy.PlayerLogout += new EventHandler(OnLogout);
        }

        private void OnLogin(object sender, EventArgs e)
        {
            uxEnable.BeginInvoke(new Action(delegate() { uxEnable.Enabled = true; }));
        }

        private void OnLogout(object sender, EventArgs e)
        {
            uxEnable.BeginInvoke(new Action(delegate() { uxEnable.Enabled = uxEnable.Checked = false; }));
        }

        private void uxEatFromCorpses_CheckedChanged(object sender, EventArgs e)
        {
            Core.Modules.Looter.EatFromMonsters = uxEatFromCorpses.Checked;
        }

        private void uxOpenBodies_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (uxOpenBodies.SelectedText)
            {
                case "All":
                    Core.Modules.Looter.OpenBodies = Kedrah.Constants.OpenBodyRule.All;
                    break;
                case "Allowed":
                    Core.Modules.Looter.OpenBodies = Kedrah.Constants.OpenBodyRule.Allowed;
                    break;
                case "Filtered":
                    Core.Modules.Looter.OpenBodies = Kedrah.Constants.OpenBodyRule.Filtered;
                    break;
                case "None":
                    Core.Modules.Looter.OpenBodies = Kedrah.Constants.OpenBodyRule.None;
                    break;
            }
        }

        private void uxEnable_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c == uxEnable.Parent) continue;
                c.Enabled = !uxEnable.Checked;
            }

            foreach (Control c in uxEnable.Parent.Controls)
            {
                c.Enabled = !uxEnable.Checked;
            }

            uxEnable.Enabled = true;
            Core.Modules.Looter.Looting = uxEnable.Checked;
        }

        private void addIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string name = "";
                if (Tibia.Constants.ItemLists.AllItems.ContainsKey(uint.Parse(uxValue.Text)))
                {
                    name = Tibia.Constants.ItemLists.AllItems.FirstOrDefault(i => i.Key == uint.Parse(uxValue.Text)).Value.Name;
                }

                Core.Modules.Looter.AddLootById(uint.Parse(uxValue.Text), byte.Parse(uxContainer.Text));
                uxList.Items.Add(new ListViewItem(new string[] { uxValue.Text, uxContainer.Text, name }));
            }
            catch { }
        }

        private void uxAdd_Click(object sender, EventArgs e)
        {
            uxLootMenu.Show(uxAdd, new Point(uxAdd.Width / 2, uxAdd.Height / 2));
        }

        private void uxValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                uxContainer.Focus();
            }
            else if (e.KeyData != Keys.Back)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyData.ToString(), "\\d+"))
                {
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void uxContainer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Back)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyData.ToString(), "\\d+"))
                {
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void uxValue_Enter(object sender, EventArgs e)
        {
            ((Control)sender).ForeColor = System.Drawing.SystemColors.WindowText;
            ((Control)sender).Text = "";
        }

        private void uxValue_Leave(object sender, EventArgs e)
        {
            if (((Control)sender).Text == "")
            {
                ((Control)sender).ForeColor = System.Drawing.SystemColors.GrayText;
                ((Control)sender).Text = (string)((Control)sender).Tag;
            }
        }

        private void addRatioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string name = "";
                if (Tibia.Constants.ItemLists.AllItems.ContainsKey(uint.Parse(uxValue.Text)))
                {
                    name = Tibia.Constants.ItemLists.AllItems.FirstOrDefault(i => i.Key == uint.Parse(uxValue.Text)).Value.Name;
                }

                Core.Modules.Looter.AddLootByRatio(uint.Parse(uxValue.Text), byte.Parse(uxContainer.Text));
                uxList.Items.Clear();

                foreach (Kedrah.Objects.LootItem item in Core.Modules.Looter.LootItems)
                {
                    uxList.Items.Add(new ListViewItem(new string[] { item.Id.ToString(), item.Container.ToString(), item.Description}));
                }
            }
            catch { }
        }

        private void uxClear_Click(object sender, EventArgs e)
        {
            Core.Modules.Looter.LootItems.Clear();
            uxList.Items.Clear();
        }

        private void uxDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in uxList.SelectedItems)
            {
                Core.Modules.Looter.LootItems.Remove(Core.Modules.Looter.LootItems.FirstOrDefault(i => item.SubItems[0].Text.Equals(i.Id.ToString())));
            }

            while (uxList.SelectedItems.Count > 0)
            {
                uxList.Items.RemoveAt(uxList.SelectedIndices[0]);
            }
        }

        private void uxLoot_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
