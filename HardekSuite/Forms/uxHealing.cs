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

        private void spellHealth_Enter(object sender, EventArgs e) {
            spellHealth.ForeColor = System.Drawing.SystemColors.WindowText;
            spellHealth.Text = "";
        }

        private void spellHealth_Leave(object sender, EventArgs e) {
            if (spellHealth.Text == "") {
                spellHealth.ForeColor = System.Drawing.SystemColors.GrayText;
                spellHealth.Text = (string)spellHealth.Tag;
            }
        }

        private void HealingForm_Load(object sender, EventArgs e) {
            spellHealth.LostFocus += new EventHandler(spellHealth_Leave);
            spellHealth.GotFocus += new EventHandler(spellHealth_Enter);
        }

        private void addHealth(object sender, EventArgs e) {
            healthList.Items.Add(sender.ToString());
        }

        private void spellHealth_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)13) {
                addHealth("Add", null);
                e.Handled = true;
            }
        }
    }
}
