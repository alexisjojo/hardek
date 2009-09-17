using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tibia.Constants;
using Tibia.Objects;
using Kedrah.Objects;

namespace HardekSuite.Forms
{
    public partial class uxHealing : Form
    {
        private Kedrah.Core Kedrah = Program.Core;
        private string healSpell = null;
        private uint manaHealSpell = 0;

        public uxHealing()
        {
            InitializeComponent();
        }

        private void potionExhaustionText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
            {
                e.Handled = true;
            }
        }

        private void addHealthButton_Click(object sender, EventArgs e)
        {
            uxHealthMenu.Show(uxHealthAdd, new Point(uxHealthAdd.Width / 2, uxHealthAdd.Height / 2));
        }

        private void manaSpellHealth_Enter(object sender, EventArgs e)
        {
            uxSpellMana.ForeColor = System.Drawing.SystemColors.WindowText;
            uxSpellMana.Text = "";
        }

        private void spellHealth_Enter(object sender, EventArgs e)
        {
            uxSpellWords.ForeColor = System.Drawing.SystemColors.WindowText;
            uxSpellWords.Text = "";
        }

        private void manaSpellHealth_Leave(object sender, EventArgs e)
        {
            if (uxSpellMana.Text == "")
            {
                uxSpellMana.ForeColor = System.Drawing.SystemColors.GrayText;
                uxSpellMana.Text = (string)uxSpellMana.Tag;
                manaHealSpell = 0;
            }
            else
            {
                manaHealSpell = uint.Parse(uxSpellMana.Text);
            }
        }

        private void spellHealth_Leave(object sender, EventArgs e)
        {
            if (uxSpellWords.Text == "")
            {
                uxSpellWords.ForeColor = System.Drawing.SystemColors.GrayText;
                uxSpellWords.Text = (string)uxSpellWords.Tag;
                healSpell = null;
            }
            else
            {
                healSpell = uxSpellWords.Text;
            }
        }

        private void HealingForm_Load(object sender, EventArgs e)
        {
            uxSpellMana.LostFocus += new EventHandler(manaSpellHealth_Leave);
            uxSpellMana.GotFocus += new EventHandler(manaSpellHealth_Enter);

            uxSpellWords.LostFocus += new EventHandler(spellHealth_Leave);
            uxSpellWords.GotFocus += new EventHandler(spellHealth_Enter);

            uxEnable.Enabled = Kedrah.Client.LoggedIn;

            Kedrah.Proxy.PlayerLogin += new EventHandler(OnLogin);
            Kedrah.Proxy.PlayerLogout += new EventHandler(OnLogout);
        }

        private void OnLogin(object sender, EventArgs e)
        {
            uxEnable.BeginInvoke(new Action(delegate() { uxEnable.Enabled = true; }));
        }

        private void OnLogout(object sender, EventArgs e)
        {
            uxEnable.BeginInvoke(new Action(delegate() { uxEnable.Enabled = uxEnable.Checked = false; }));
        }

        private void addToUxList(string action, int percent, string mana, string list)
        {
            uxList.Items.Add(new ListViewItem(new string[] { percent.ToString(), action, mana.ToString() }, uxList.Groups[list]));
        }

        private void addToUxList(string action, int percent, string list)
        {
            addToUxList(action, percent, "--", list);
        }

        private void addMana(object sender, EventArgs e)
        {
            ToolStripMenuItem s = (ToolStripMenuItem)sender;

            Item item = ItemLists.Potion.FirstOrDefault(i => string.Compare(i.Value.Name, s.Text, true) == 0).Value;

            if (item != null)
            {
                Kedrah.Modules.Heal.PotionMana.Add(new HealPercent((byte)uxPercent.Value, item));
                addToUxList(item.Name, uxPercent.Value, "uxGroupMana");
            }
            else
            {
                System.Windows.MessageBox.Show("Invalids parameters.", "Error", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Exclamation);
            }
        }

        private void addHealth(object sender, EventArgs e)
        {
            ToolStripMenuItem s = (ToolStripMenuItem)sender;

            if (s.Text.Contains("Add"))
            {
                if ((healSpell != null) && (manaHealSpell != 0))
                {
                    addToUxList("Spell: \"" + healSpell + "\"", uxPercent.Value, manaHealSpell.ToString(), "uxGroupHealth");
                    Kedrah.Modules.Heal.SpellLife.Add(new HealPercent((byte)uxPercent.Value, healSpell, manaHealSpell));
                }
                else
                {
                    System.Windows.MessageBox.Show("Invalids parameters.", "Error", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Exclamation);
                }
            }
            else
            {
                Item item = ItemLists.Potion.FirstOrDefault(i => string.Compare(i.Value.Name, s.Text, true) == 0).Value;

                if (item != null)
                {
                    Kedrah.Modules.Heal.PotionLife.Add(new HealPercent((byte)uxPercent.Value, item));
                }
                else
                {
                    item = ItemLists.Runes.FirstOrDefault(i => string.Compare(i.Value.Name, s.Text, true) == 0).Value;

                    if (item != null)
                    {
                        Kedrah.Modules.Heal.RuneLife.Add(new HealPercent((byte)uxPercent.Value, item));
                    }
                }

                if (item == null)
                {
                    System.Windows.MessageBox.Show("Invalids parameters.", "Error", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Exclamation);
                }
                else
                {
                    addToUxList(item.Name, uxPercent.Value, "uxGroupHealth");
                }
            }
        }


        private void manaSpellHealth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                if (healSpell == null)
                {
                    uxSpellWords.Focus();
                }
                else
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(sender.ToString(), "\\d+"))
                    {
                        e.Handled = true;
                        manaHealSpell = uint.Parse(sender.ToString());
                        addHealth(uxAddSpellHealth, e);
                        uxHealthMenu.Hide();
                    }
                }
            }
            else
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                {
                    e.Handled = true;
                }
            }
        }

        private void spellHealth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                uxSpellMana.Focus();
            }
        }

        private void uxMana_Click(object sender, EventArgs e)
        {
            uxManaMenu.Show(uxManaAdd, new Point(uxManaAdd.Width / 2, uxManaAdd.Height / 2));
        }

        private void uxPercent_Scroll(object sender, ScrollEventArgs e)
        {
            uxLabelPercent.Text = e.NewValue.ToString() + "%";
        }

        private void paralyzeCheck_CheckedChanged(object sender, EventArgs e)
        {
            Kedrah.Modules.Heal.Paralyze = paralyzeCheck.Checked;
        }

        private void antidoteCheck_CheckedChanged(object sender, EventArgs e)
        {
            Kedrah.Modules.Heal.Poison = antidoteCheck.Checked;
        }

        private void spellExhaustionText_TextChanged(object sender, EventArgs e)
        {
            Kedrah.Modules.Heal.SpellExhaustion = ushort.Parse(spellExhaustionText.Text);
        }

        private void potionExhaustionText_TextChanged(object sender, EventArgs e)
        {
            Kedrah.Modules.Heal.PotionExhaustion = ushort.Parse(potionExhaustionText.Text);
        }

        private void uxDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in uxList.SelectedItems)
            {
                if (!Kedrah.Modules.Heal.SpellLife.Remove(Kedrah.Modules.Heal.SpellLife.FirstOrDefault(i => item.SubItems[1].Text.Contains(i.Spell))))
                {
                    if (!Kedrah.Modules.Heal.RuneLife.Remove(Kedrah.Modules.Heal.RuneLife.FirstOrDefault(i => item.SubItems[1].Text.Contains(i.Item.Name))))
                    {
                        if (!Kedrah.Modules.Heal.PotionLife.Remove(Kedrah.Modules.Heal.PotionLife.FirstOrDefault(i => item.SubItems[1].Text.Contains(i.Item.Name))))
                        {
                            Kedrah.Modules.Heal.PotionMana.Remove(Kedrah.Modules.Heal.PotionMana.FirstOrDefault(i => item.SubItems[1].Text.Contains(i.Item.Name)));
                        }
                    }
                }
            }

            while (uxList.SelectedItems.Count > 0)
            {
                uxList.Items.RemoveAt(uxList.SelectedIndices[0]);
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
            Kedrah.Modules.Heal.Healer = uxEnable.Checked;
        }

        private void uxClear_Click(object sender, EventArgs e)
        {
            Kedrah.Modules.Heal.PotionLife.Clear();
            Kedrah.Modules.Heal.PotionMana.Clear();
            Kedrah.Modules.Heal.RuneLife.Clear();
            Kedrah.Modules.Heal.SpellLife.Clear();
            uxList.Items.Clear();
        }

        private void uxHealing_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}