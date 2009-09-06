using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HardekSuite.Forms {
    public partial class uxHealing : Form {
        private bool dragging = false;
        private Kedrah.Core Core = Program.Core;
        private string healSpell = null;
        private uint manaHealSpell = 0;

        public uxHealing() {
            InitializeComponent();
        }

        private void refreshPercentBar(int mousePosition) {
            int value = mousePosition * 100 / healingPercent.Width;
            value = (value >= 0) ? value : 0;
            value = (value <= 100) ? value : 100;
            healingPercent.Value = value;
        }

        private void healingPercent_MouseDown(object sender, MouseEventArgs e) {
            refreshPercentBar(e.X);
            dragging = true;
        }

        private void healingPercent_MouseMove(object sender, MouseEventArgs e) {
            if (dragging)
                refreshPercentBar(e.X);
        }

        private void healingPercent_MouseUp(object sender, MouseEventArgs e) {
            refreshPercentBar(e.X);
            dragging = false;
        }

        private void potionExhaustionText_KeyPress(object sender, KeyPressEventArgs e) {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = true;
        }

        private void addHealthButton_Click(object sender, EventArgs e) {
            addHealthMenu.Show(addHealthButton, ((MouseEventArgs)e).Location);
        }

        private void manaSpellHealth_Enter(object sender, EventArgs e) {
            manaSpellHealth.ForeColor = System.Drawing.SystemColors.WindowText;
            manaSpellHealth.Text = "";
        }

        private void spellHealth_Enter(object sender, EventArgs e) {
            spellHealth.ForeColor = System.Drawing.SystemColors.WindowText;
            spellHealth.Text = "";
        }

        private void manaSpellHealth_Leave(object sender, EventArgs e) {
            if (manaSpellHealth.Text == "")
            {
                manaSpellHealth.ForeColor = System.Drawing.SystemColors.GrayText;
                manaSpellHealth.Text = (string)manaSpellHealth.Tag;
                manaHealSpell = 0;
            }
            else
                manaHealSpell = uint.Parse(manaSpellHealth.Text);
        }

        private void spellHealth_Leave(object sender, EventArgs e) {
            if (spellHealth.Text == "") {
                spellHealth.ForeColor = System.Drawing.SystemColors.GrayText;
                spellHealth.Text = (string)spellHealth.Tag;
                healSpell = null;
            }
            else
                healSpell = spellHealth.Text;
        }

        private void HealingForm_Load(object sender, EventArgs e) {
            manaSpellHealth.LostFocus += new EventHandler(manaSpellHealth_Leave);
            manaSpellHealth.GotFocus += new EventHandler(manaSpellHealth_Enter);

            spellHealth.LostFocus += new EventHandler(spellHealth_Leave);
            spellHealth.GotFocus += new EventHandler(spellHealth_Enter);
        }

        private void addHealth(object sender, EventArgs e) {
            if ((healSpell != null) && (manaHealSpell != 0)) {
                healthList.Items.Add("Use " + healSpell + "(" + manaHealSpell + ") when life is less than " + healingPercent.Value);
                Core.Modules.Heal.SpellLife.Add(new Kedrah.Modules.SpellPercent((uint) healingPercent.Value, healSpell, manaHealSpell));
                Core.Modules.Heal.Healer = true;
            }
            else
                System.Windows.MessageBox.Show("Invalids arguments");
        }


        private void manaSpellHealth_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)13) {
                e.Handled = true;
                if (healSpell == null)
                    spellHealth.Focus();
                else
                    if (System.Text.RegularExpressions.Regex.IsMatch(sender.ToString(), "\\d+")) {
                        e.Handled = true;
                        manaHealSpell = uint.Parse(sender.ToString());
                        addHealth(null, e);
                    }
            }
            else
                if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                    e.Handled = true;
        }

        private void spellHealth_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)13) {
                e.Handled = true;
                manaSpellHealth.Focus();
            }
        }

        private void manaSpellHealth_Click(object sender, EventArgs e) {
            
        }

        private void spellHealth_Click(object sender, EventArgs e) {

        }

        private void potionExhaustionText_TextChanged(object sender, EventArgs e)
        {

        }

        private void spellExhaustionText_TextChanged(object sender, EventArgs e)
        {

        }

        private void potionExhaustionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}