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
        private Kedrah.Core Core = Program.Core;
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
            uxHealthMenu.Show(uxHealthAdd, ((MouseEventArgs)e).Location);
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

        private void addToUxList(string sufix, int percent, ref ListBox list)
        {
            string p = percent.ToString();

            while (p.Length < 4)
            {
                p = " " + p;
            }

            list.Items.Add(p + "%  -  " + sufix);
        }

        private void addMana(object sender, EventArgs e)
        {
            ToolStripMenuItem s = (ToolStripMenuItem)sender;

            Item item = ItemLists.Potion.FirstOrDefault(i => string.Compare(i.Value.Name, s.Text, true) == 0).Value;

            if (item != null)
            {
                uxManaList.Items.Add(s.Text + "\t" + uxPercent.Value + "%");
                Core.Modules.Heal.PotionMana.Add(new HealPercent((byte)uxPercent.Value, item));
            }
            else
            {
                System.Windows.MessageBox.Show("Invalids arguments");
            }
        }

        private void addHealth(object sender, EventArgs e)
        {
            ToolStripMenuItem s = (ToolStripMenuItem)sender;

            if (s.Text.Contains("Add"))
            {
                if ((healSpell != null) && (manaHealSpell != 0))
                {
                    addToUxList("\"" + healSpell + "\" (" + manaHealSpell + " manapoints)", uxPercent.Value, ref uxHealthList);
                    Core.Modules.Heal.SpellLife.Add(new HealPercent((byte)uxPercent.Value, healSpell, manaHealSpell));
                }
                else
                {
                    System.Windows.MessageBox.Show("Invalids arguments");
                }
            }
            else
            {
                Item item = ItemLists.Potion.FirstOrDefault(i => string.Compare(i.Value.Name, s.Text, true) == 0).Value;

                if (item != null)
                {
                    Core.Modules.Heal.PotionLife.Add(new HealPercent((byte)uxPercent.Value, item));
                }
                else
                {
                    item = ItemLists.Runes.FirstOrDefault(i => string.Compare(i.Value.Name, s.Text, true) == 0).Value;

                    if (item != null)
                    {
                        Core.Modules.Heal.RuneLife.Add(new HealPercent((byte)uxPercent.Value, item));
                    }
                }

                if (item == null)
                {
                    System.Windows.MessageBox.Show("Invalids arguments");
                }
                else
                {
                    addToUxList(s.Text, uxPercent.Value, ref uxHealthList);
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
                    if (System.Text.RegularExpressions.Regex.IsMatch(sender.ToString(), "\\d+"))
                    {
                        e.Handled = true;
                        manaHealSpell = uint.Parse(sender.ToString());
                        addHealth(uxAddSpellHealth, e);
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
            uxManaMenu.Show(uxManaAdd, ((MouseEventArgs)e).Location);
        }

        private void uxPercent_Scroll(object sender, ScrollEventArgs e)
        {
            uxLabelPercent.Text = e.NewValue.ToString() + "%";
        }

        private void paralyzeCheck_CheckedChanged(object sender, EventArgs e)
        {
            Core.Modules.Heal.Paralyze = paralyzeCheck.Checked;
        }

        private void antidoteCheck_CheckedChanged(object sender, EventArgs e)
        {
            Core.Modules.Heal.Poison = antidoteCheck.Checked;
        }

        private void spellExhaustionText_TextChanged(object sender, EventArgs e)
        {
            Core.Modules.Heal.SpellExhaustion = ushort.Parse(spellExhaustionText.Text);
        }

        private void potionExhaustionText_TextChanged(object sender, EventArgs e)
        {
            Core.Modules.Heal.PotionExhaustion = ushort.Parse(potionExhaustionText.Text);
        }

        private void uxHealthDelete_Click(object sender, EventArgs e)
        {

        }

        private void uxEnable_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = !uxEnable.Checked;
            }

            uxEnable.Enabled = true;
            Core.Modules.Heal.Healer = uxEnable.Checked;
        }
    }
}