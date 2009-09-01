namespace HardekSuite.Forms {
    partial class uxHealing {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uxHealing));
            this.healingPercent = new System.Windows.Forms.ProgressBar();
            this.potionExhaustionText = new System.Windows.Forms.TextBox();
            this.potionExhaustionLabel = new System.Windows.Forms.Label();
            this.spellExhaustionLabel = new System.Windows.Forms.Label();
            this.spellExhaustionText = new System.Windows.Forms.TextBox();
            this.paralyzeCheck = new System.Windows.Forms.CheckBox();
            this.antidoteCheck = new System.Windows.Forms.CheckBox();
            this.splitLists = new System.Windows.Forms.SplitContainer();
            this.healthList = new System.Windows.Forms.ListBox();
            this.manaList = new System.Windows.Forms.ListBox();
            this.addHealthMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ultimateHealingRuneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intenseHealingRuneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallHealthPotionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.healthPotionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strongHealthPotionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ultimateHealthPotionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greatSpiritPotionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spellHealth = new System.Windows.Forms.ToolStripTextBox();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addHealthButton = new System.Windows.Forms.Button();
            this.splitLists.Panel1.SuspendLayout();
            this.splitLists.Panel2.SuspendLayout();
            this.splitLists.SuspendLayout();
            this.addHealthMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // healingPercent
            // 
            this.healingPercent.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.healingPercent.ForeColor = System.Drawing.Color.Green;
            this.healingPercent.Location = new System.Drawing.Point(12, 118);
            this.healingPercent.Name = "healingPercent";
            this.healingPercent.Size = new System.Drawing.Size(399, 16);
            this.healingPercent.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.healingPercent.TabIndex = 1;
            this.healingPercent.Value = 50;
            this.healingPercent.MouseMove += new System.Windows.Forms.MouseEventHandler(this.healingPercent_MouseMove);
            this.healingPercent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.healingPercent_MouseDown);
            this.healingPercent.MouseUp += new System.Windows.Forms.MouseEventHandler(this.healingPercent_MouseUp);
            // 
            // potionExhaustionText
            // 
            this.potionExhaustionText.Location = new System.Drawing.Point(113, 137);
            this.potionExhaustionText.Name = "potionExhaustionText";
            this.potionExhaustionText.Size = new System.Drawing.Size(53, 20);
            this.potionExhaustionText.TabIndex = 2;
            this.potionExhaustionText.Text = "700";
            this.potionExhaustionText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.potionExhaustionText_KeyPress);
            // 
            // potionExhaustionLabel
            // 
            this.potionExhaustionLabel.AutoSize = true;
            this.potionExhaustionLabel.Location = new System.Drawing.Point(12, 140);
            this.potionExhaustionLabel.Name = "potionExhaustionLabel";
            this.potionExhaustionLabel.Size = new System.Drawing.Size(95, 13);
            this.potionExhaustionLabel.TabIndex = 3;
            this.potionExhaustionLabel.Text = "Potion Exhaustion:";
            // 
            // spellExhaustionLabel
            // 
            this.spellExhaustionLabel.AutoSize = true;
            this.spellExhaustionLabel.Location = new System.Drawing.Point(12, 166);
            this.spellExhaustionLabel.Name = "spellExhaustionLabel";
            this.spellExhaustionLabel.Size = new System.Drawing.Size(88, 13);
            this.spellExhaustionLabel.TabIndex = 5;
            this.spellExhaustionLabel.Text = "Spell Exhaustion:";
            // 
            // spellExhaustionText
            // 
            this.spellExhaustionText.Location = new System.Drawing.Point(113, 163);
            this.spellExhaustionText.Name = "spellExhaustionText";
            this.spellExhaustionText.Size = new System.Drawing.Size(53, 20);
            this.spellExhaustionText.TabIndex = 4;
            this.spellExhaustionText.Text = "1080";
            this.spellExhaustionText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.potionExhaustionText_KeyPress);
            // 
            // paralyzeCheck
            // 
            this.paralyzeCheck.AutoSize = true;
            this.paralyzeCheck.Location = new System.Drawing.Point(265, 140);
            this.paralyzeCheck.Name = "paralyzeCheck";
            this.paralyzeCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.paralyzeCheck.Size = new System.Drawing.Size(91, 17);
            this.paralyzeCheck.TabIndex = 6;
            this.paralyzeCheck.Text = "Paralyze Heal";
            this.paralyzeCheck.UseVisualStyleBackColor = true;
            // 
            // antidoteCheck
            // 
            this.antidoteCheck.AutoSize = true;
            this.antidoteCheck.Location = new System.Drawing.Point(273, 166);
            this.antidoteCheck.Name = "antidoteCheck";
            this.antidoteCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.antidoteCheck.Size = new System.Drawing.Size(83, 17);
            this.antidoteCheck.TabIndex = 7;
            this.antidoteCheck.Text = "Poison Heal";
            this.antidoteCheck.UseVisualStyleBackColor = true;
            // 
            // splitLists
            // 
            this.splitLists.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitLists.IsSplitterFixed = true;
            this.splitLists.Location = new System.Drawing.Point(13, 12);
            this.splitLists.Name = "splitLists";
            // 
            // splitLists.Panel1
            // 
            this.splitLists.Panel1.Controls.Add(this.healthList);
            // 
            // splitLists.Panel2
            // 
            this.splitLists.Panel2.Controls.Add(this.manaList);
            this.splitLists.Size = new System.Drawing.Size(400, 100);
            this.splitLists.SplitterDistance = 200;
            this.splitLists.TabIndex = 8;
            // 
            // healthList
            // 
            this.healthList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.healthList.FormattingEnabled = true;
            this.healthList.Location = new System.Drawing.Point(0, 0);
            this.healthList.Name = "healthList";
            this.healthList.Size = new System.Drawing.Size(200, 95);
            this.healthList.TabIndex = 0;
            // 
            // manaList
            // 
            this.manaList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manaList.FormattingEnabled = true;
            this.manaList.Location = new System.Drawing.Point(0, 0);
            this.manaList.Name = "manaList";
            this.manaList.Size = new System.Drawing.Size(196, 95);
            this.manaList.TabIndex = 1;
            // 
            // addHealthMenu
            // 
            this.addHealthMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemToolStripMenuItem,
            this.spellToolStripMenuItem});
            this.addHealthMenu.Name = "addHealthMenu";
            this.addHealthMenu.Size = new System.Drawing.Size(108, 48);
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ultimateHealingRuneToolStripMenuItem,
            this.intenseHealingRuneToolStripMenuItem,
            this.smallHealthPotionToolStripMenuItem,
            this.healthPotionToolStripMenuItem,
            this.strongHealthPotionToolStripMenuItem,
            this.greathToolStripMenuItem,
            this.ultimateHealthPotionToolStripMenuItem,
            this.greatSpiritPotionToolStripMenuItem});
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.itemToolStripMenuItem.Text = "Item";
            // 
            // ultimateHealingRuneToolStripMenuItem
            // 
            this.ultimateHealingRuneToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ultimateHealingRuneToolStripMenuItem.Image")));
            this.ultimateHealingRuneToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ultimateHealingRuneToolStripMenuItem.Name = "ultimateHealingRuneToolStripMenuItem";
            this.ultimateHealingRuneToolStripMenuItem.Size = new System.Drawing.Size(207, 38);
            this.ultimateHealingRuneToolStripMenuItem.Text = "Ultimate Healing Rune";
            this.ultimateHealingRuneToolStripMenuItem.Click += new System.EventHandler(this.addHealth);
            // 
            // intenseHealingRuneToolStripMenuItem
            // 
            this.intenseHealingRuneToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("intenseHealingRuneToolStripMenuItem.Image")));
            this.intenseHealingRuneToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.intenseHealingRuneToolStripMenuItem.Name = "intenseHealingRuneToolStripMenuItem";
            this.intenseHealingRuneToolStripMenuItem.Size = new System.Drawing.Size(207, 38);
            this.intenseHealingRuneToolStripMenuItem.Text = "Intense Healing Rune";
            this.intenseHealingRuneToolStripMenuItem.Click += new System.EventHandler(this.addHealth);
            // 
            // smallHealthPotionToolStripMenuItem
            // 
            this.smallHealthPotionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("smallHealthPotionToolStripMenuItem.Image")));
            this.smallHealthPotionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.smallHealthPotionToolStripMenuItem.Name = "smallHealthPotionToolStripMenuItem";
            this.smallHealthPotionToolStripMenuItem.Size = new System.Drawing.Size(207, 38);
            this.smallHealthPotionToolStripMenuItem.Text = "Small Health Potion";
            this.smallHealthPotionToolStripMenuItem.Click += new System.EventHandler(this.addHealth);
            // 
            // healthPotionToolStripMenuItem
            // 
            this.healthPotionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("healthPotionToolStripMenuItem.Image")));
            this.healthPotionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.healthPotionToolStripMenuItem.Name = "healthPotionToolStripMenuItem";
            this.healthPotionToolStripMenuItem.Size = new System.Drawing.Size(207, 38);
            this.healthPotionToolStripMenuItem.Text = "Health Potion";
            this.healthPotionToolStripMenuItem.Click += new System.EventHandler(this.addHealth);
            // 
            // strongHealthPotionToolStripMenuItem
            // 
            this.strongHealthPotionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("strongHealthPotionToolStripMenuItem.Image")));
            this.strongHealthPotionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.strongHealthPotionToolStripMenuItem.Name = "strongHealthPotionToolStripMenuItem";
            this.strongHealthPotionToolStripMenuItem.Size = new System.Drawing.Size(207, 38);
            this.strongHealthPotionToolStripMenuItem.Text = "Strong Health Potion";
            this.strongHealthPotionToolStripMenuItem.Click += new System.EventHandler(this.addHealth);
            // 
            // greathToolStripMenuItem
            // 
            this.greathToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("greathToolStripMenuItem.Image")));
            this.greathToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.greathToolStripMenuItem.Name = "greathToolStripMenuItem";
            this.greathToolStripMenuItem.Size = new System.Drawing.Size(207, 38);
            this.greathToolStripMenuItem.Text = "Greath Health Potion";
            this.greathToolStripMenuItem.Click += new System.EventHandler(this.addHealth);
            // 
            // ultimateHealthPotionToolStripMenuItem
            // 
            this.ultimateHealthPotionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ultimateHealthPotionToolStripMenuItem.Image")));
            this.ultimateHealthPotionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ultimateHealthPotionToolStripMenuItem.Name = "ultimateHealthPotionToolStripMenuItem";
            this.ultimateHealthPotionToolStripMenuItem.Size = new System.Drawing.Size(207, 38);
            this.ultimateHealthPotionToolStripMenuItem.Text = "Ultimate Health Potion";
            this.ultimateHealthPotionToolStripMenuItem.Click += new System.EventHandler(this.addHealth);
            // 
            // greatSpiritPotionToolStripMenuItem
            // 
            this.greatSpiritPotionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("greatSpiritPotionToolStripMenuItem.Image")));
            this.greatSpiritPotionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.greatSpiritPotionToolStripMenuItem.Name = "greatSpiritPotionToolStripMenuItem";
            this.greatSpiritPotionToolStripMenuItem.Size = new System.Drawing.Size(207, 38);
            this.greatSpiritPotionToolStripMenuItem.Text = "Great Spirit Potion";
            this.greatSpiritPotionToolStripMenuItem.Click += new System.EventHandler(this.addHealth);
            // 
            // spellToolStripMenuItem
            // 
            this.spellToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spellHealth,
            this.addToolStripMenuItem});
            this.spellToolStripMenuItem.Name = "spellToolStripMenuItem";
            this.spellToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.spellToolStripMenuItem.Text = "Spell";
            // 
            // spellHealth
            // 
            this.spellHealth.ForeColor = System.Drawing.SystemColors.GrayText;
            this.spellHealth.Name = "spellHealth";
            this.spellHealth.Size = new System.Drawing.Size(100, 21);
            this.spellHealth.Tag = "Spell";
            this.spellHealth.Text = "Spell";
            this.spellHealth.Leave += new System.EventHandler(this.spellHealth_Leave);
            this.spellHealth.Enter += new System.EventHandler(this.spellHealth_Enter);
            this.spellHealth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.spellHealth_KeyPress);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripMenuItem.Image")));
            this.addToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(176, 38);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addHealth);
            // 
            // addHealthButton
            // 
            this.addHealthButton.Location = new System.Drawing.Point(13, 196);
            this.addHealthButton.Name = "addHealthButton";
            this.addHealthButton.Size = new System.Drawing.Size(75, 23);
            this.addHealthButton.TabIndex = 10;
            this.addHealthButton.Text = "Add";
            this.addHealthButton.UseVisualStyleBackColor = true;
            this.addHealthButton.Click += new System.EventHandler(this.addHealthButton_Click);
            // 
            // uxHealing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 272);
            this.Controls.Add(this.splitLists);
            this.Controls.Add(this.addHealthButton);
            this.Controls.Add(this.antidoteCheck);
            this.Controls.Add(this.paralyzeCheck);
            this.Controls.Add(this.spellExhaustionLabel);
            this.Controls.Add(this.spellExhaustionText);
            this.Controls.Add(this.potionExhaustionLabel);
            this.Controls.Add(this.potionExhaustionText);
            this.Controls.Add(this.healingPercent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "uxHealing";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Healing";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.HealingForm_Load);
            this.splitLists.Panel1.ResumeLayout(false);
            this.splitLists.Panel2.ResumeLayout(false);
            this.splitLists.ResumeLayout(false);
            this.addHealthMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar healingPercent;
        private System.Windows.Forms.TextBox potionExhaustionText;
        private System.Windows.Forms.Label potionExhaustionLabel;
        private System.Windows.Forms.Label spellExhaustionLabel;
        private System.Windows.Forms.TextBox spellExhaustionText;
        private System.Windows.Forms.CheckBox paralyzeCheck;
        private System.Windows.Forms.CheckBox antidoteCheck;
        private System.Windows.Forms.SplitContainer splitLists;
        private System.Windows.Forms.ListBox healthList;
        private System.Windows.Forms.ListBox manaList;
        private System.Windows.Forms.ContextMenuStrip addHealthMenu;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ultimateHealingRuneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intenseHealingRuneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallHealthPotionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem healthPotionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strongHealthPotionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ultimateHealthPotionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greatSpiritPotionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spellToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox spellHealth;
        private System.Windows.Forms.Button addHealthButton;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
    }
}