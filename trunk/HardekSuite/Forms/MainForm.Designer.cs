namespace HardekSuite.Forms {
    partial class MainForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuButton = new System.Windows.Forms.Button();
            this.hotkeysButton = new System.Windows.Forms.Button();
            this.commandsButton = new System.Windows.Forms.Button();
            this.iconsButton = new System.Windows.Forms.Button();
            this.cavebotButton = new System.Windows.Forms.Button();
            this.equipsButton = new System.Windows.Forms.Button();
            this.automaticButton = new System.Windows.Forms.Button();
            this.healingButton = new System.Windows.Forms.Button();
            this.looterButton = new System.Windows.Forms.Button();
            this.targetingButton = new System.Windows.Forms.Button();
            this.toggleCore = new System.Windows.Forms.PictureBox();
            this.corePicture = new System.Windows.Forms.PictureBox();
            this.generalPicture = new System.Windows.Forms.PictureBox();
            this.toggleGeneral = new System.Windows.Forms.PictureBox();
            this.generalPanel = new System.Windows.Forms.Panel();
            this.optionsButton = new System.Windows.Forms.Button();
            this.screenInformationButton = new System.Windows.Forms.Button();
            this.securityButton = new System.Windows.Forms.Button();
            this.statisticsButton = new System.Windows.Forms.Button();
            this.generalGroup = new System.Windows.Forms.FlowLayoutPanel();
            this.bigflow = new System.Windows.Forms.FlowLayoutPanel();
            this.shortCutsPanel = new System.Windows.Forms.Panel();
            this.shortCutsGroup = new System.Windows.Forms.FlowLayoutPanel();
            this.corePanel = new System.Windows.Forms.Panel();
            this.coreGroup = new System.Windows.Forms.FlowLayoutPanel();
            this.shortCutsPicture = new System.Windows.Forms.PictureBox();
            this.toggleShortcuts = new System.Windows.Forms.PictureBox();
            this.trayContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleCore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleGeneral)).BeginInit();
            this.generalPanel.SuspendLayout();
            this.generalGroup.SuspendLayout();
            this.bigflow.SuspendLayout();
            this.shortCutsPanel.SuspendLayout();
            this.shortCutsGroup.SuspendLayout();
            this.corePanel.SuspendLayout();
            this.coreGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shortCutsPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleShortcuts)).BeginInit();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayContextMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Hardek Suite";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // trayContextMenu
            // 
            this.trayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitMenu});
            this.trayContextMenu.Name = "trayContextMenu";
            this.trayContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.trayContextMenu.Size = new System.Drawing.Size(104, 26);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Image = global::HardekSuite.Properties.Resources.close;
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(103, 22);
            this.ExitMenu.Text = "Exit";
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // contextMenuButton
            // 
            this.contextMenuButton.Image = global::HardekSuite.Properties.Resources.context_menu;
            this.contextMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contextMenuButton.Location = new System.Drawing.Point(108, 3);
            this.contextMenuButton.Name = "contextMenuButton";
            this.contextMenuButton.Size = new System.Drawing.Size(99, 40);
            this.contextMenuButton.TabIndex = 18;
            this.contextMenuButton.Text = "Context Menu";
            this.contextMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contextMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.contextMenuButton.UseVisualStyleBackColor = true;
            // 
            // hotkeysButton
            // 
            this.hotkeysButton.Image = global::HardekSuite.Properties.Resources.hotkeys;
            this.hotkeysButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hotkeysButton.Location = new System.Drawing.Point(3, 49);
            this.hotkeysButton.Name = "hotkeysButton";
            this.hotkeysButton.Size = new System.Drawing.Size(99, 40);
            this.hotkeysButton.TabIndex = 17;
            this.hotkeysButton.Text = "Hotkeys";
            this.hotkeysButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hotkeysButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.hotkeysButton.UseVisualStyleBackColor = true;
            // 
            // commandsButton
            // 
            this.commandsButton.Image = global::HardekSuite.Properties.Resources.commands;
            this.commandsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.commandsButton.Location = new System.Drawing.Point(3, 3);
            this.commandsButton.Name = "commandsButton";
            this.commandsButton.Size = new System.Drawing.Size(99, 40);
            this.commandsButton.TabIndex = 15;
            this.commandsButton.Text = "Commands";
            this.commandsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.commandsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.commandsButton.UseVisualStyleBackColor = true;
            // 
            // iconsButton
            // 
            this.iconsButton.Image = global::HardekSuite.Properties.Resources.icons;
            this.iconsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconsButton.Location = new System.Drawing.Point(108, 49);
            this.iconsButton.Name = "iconsButton";
            this.iconsButton.Size = new System.Drawing.Size(99, 40);
            this.iconsButton.TabIndex = 16;
            this.iconsButton.Text = "Icons";
            this.iconsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconsButton.UseVisualStyleBackColor = true;
            // 
            // cavebotButton
            // 
            this.cavebotButton.Image = global::HardekSuite.Properties.Resources.cavebot;
            this.cavebotButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cavebotButton.Location = new System.Drawing.Point(108, 3);
            this.cavebotButton.Name = "cavebotButton";
            this.cavebotButton.Size = new System.Drawing.Size(99, 40);
            this.cavebotButton.TabIndex = 8;
            this.cavebotButton.Text = "Cavebot";
            this.cavebotButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cavebotButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cavebotButton.UseVisualStyleBackColor = true;
            // 
            // equipsButton
            // 
            this.equipsButton.Image = global::HardekSuite.Properties.Resources.equips;
            this.equipsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.equipsButton.Location = new System.Drawing.Point(3, 49);
            this.equipsButton.Name = "equipsButton";
            this.equipsButton.Size = new System.Drawing.Size(99, 40);
            this.equipsButton.TabIndex = 7;
            this.equipsButton.Text = "Equips";
            this.equipsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.equipsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.equipsButton.UseVisualStyleBackColor = true;
            // 
            // automaticButton
            // 
            this.automaticButton.Image = global::HardekSuite.Properties.Resources.automatic;
            this.automaticButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.automaticButton.Location = new System.Drawing.Point(3, 3);
            this.automaticButton.Name = "automaticButton";
            this.automaticButton.Size = new System.Drawing.Size(99, 40);
            this.automaticButton.TabIndex = 1;
            this.automaticButton.Text = "Automatic";
            this.automaticButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.automaticButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.automaticButton.UseVisualStyleBackColor = true;
            // 
            // healingButton
            // 
            this.healingButton.Image = global::HardekSuite.Properties.Resources.healing;
            this.healingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.healingButton.Location = new System.Drawing.Point(108, 49);
            this.healingButton.Name = "healingButton";
            this.healingButton.Size = new System.Drawing.Size(99, 40);
            this.healingButton.TabIndex = 6;
            this.healingButton.Text = "Healing";
            this.healingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.healingButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.healingButton.UseVisualStyleBackColor = true;
            // 
            // looterButton
            // 
            this.looterButton.BackgroundImage = global::HardekSuite.Properties.Resources.looter_background;
            this.looterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.looterButton.Image = global::HardekSuite.Properties.Resources.looter;
            this.looterButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.looterButton.Location = new System.Drawing.Point(3, 95);
            this.looterButton.Name = "looterButton";
            this.looterButton.Size = new System.Drawing.Size(99, 40);
            this.looterButton.TabIndex = 5;
            this.looterButton.Text = "Looter";
            this.looterButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.looterButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.looterButton.UseVisualStyleBackColor = true;
            // 
            // targetingButton
            // 
            this.targetingButton.Image = global::HardekSuite.Properties.Resources.targeting;
            this.targetingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.targetingButton.Location = new System.Drawing.Point(108, 95);
            this.targetingButton.Name = "targetingButton";
            this.targetingButton.Size = new System.Drawing.Size(99, 40);
            this.targetingButton.TabIndex = 4;
            this.targetingButton.Text = "Targeting";
            this.targetingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.targetingButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.targetingButton.UseVisualStyleBackColor = true;
            // 
            // toggleCore
            // 
            this.toggleCore.Image = global::HardekSuite.Properties.Resources.minimize;
            this.toggleCore.Location = new System.Drawing.Point(204, 3);
            this.toggleCore.Name = "toggleCore";
            this.toggleCore.Size = new System.Drawing.Size(9, 9);
            this.toggleCore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.toggleCore.TabIndex = 13;
            this.toggleCore.TabStop = false;
            this.toggleCore.Click += new System.EventHandler(this.toggleCore_Click);
            // 
            // corePicture
            // 
            this.corePicture.Image = global::HardekSuite.Properties.Resources.core;
            this.corePicture.Location = new System.Drawing.Point(3, 3);
            this.corePicture.Name = "corePicture";
            this.corePicture.Size = new System.Drawing.Size(210, 20);
            this.corePicture.TabIndex = 14;
            this.corePicture.TabStop = false;
            this.corePicture.Click += new System.EventHandler(this.toggleCore_Click);
            // 
            // generalPicture
            // 
            this.generalPicture.Image = global::HardekSuite.Properties.Resources.general;
            this.generalPicture.Location = new System.Drawing.Point(3, 3);
            this.generalPicture.Name = "generalPicture";
            this.generalPicture.Size = new System.Drawing.Size(210, 27);
            this.generalPicture.TabIndex = 12;
            this.generalPicture.TabStop = false;
            this.generalPicture.Click += new System.EventHandler(this.toggleGeneral_Click);
            // 
            // toggleGeneral
            // 
            this.toggleGeneral.Image = global::HardekSuite.Properties.Resources.minimize;
            this.toggleGeneral.Location = new System.Drawing.Point(204, 3);
            this.toggleGeneral.Name = "toggleGeneral";
            this.toggleGeneral.Size = new System.Drawing.Size(9, 9);
            this.toggleGeneral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.toggleGeneral.TabIndex = 11;
            this.toggleGeneral.TabStop = false;
            this.toggleGeneral.Click += new System.EventHandler(this.toggleGeneral_Click);
            // 
            // generalPanel
            // 
            this.generalPanel.AutoSize = true;
            this.generalPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.generalPanel.Controls.Add(this.generalGroup);
            this.generalPanel.Controls.Add(this.toggleGeneral);
            this.generalPanel.Controls.Add(this.generalPicture);
            this.generalPanel.Location = new System.Drawing.Point(3, 3);
            this.generalPanel.Name = "generalPanel";
            this.generalPanel.Size = new System.Drawing.Size(216, 128);
            this.generalPanel.TabIndex = 15;
            // 
            // optionsButton
            // 
            this.optionsButton.Image = global::HardekSuite.Properties.Resources.options;
            this.optionsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optionsButton.Location = new System.Drawing.Point(3, 3);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(99, 40);
            this.optionsButton.TabIndex = 19;
            this.optionsButton.Text = "Options";
            this.optionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optionsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.optionsButton.UseVisualStyleBackColor = true;
            // 
            // screenInformationButton
            // 
            this.screenInformationButton.Image = global::HardekSuite.Properties.Resources.screen_information;
            this.screenInformationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.screenInformationButton.Location = new System.Drawing.Point(108, 49);
            this.screenInformationButton.Name = "screenInformationButton";
            this.screenInformationButton.Size = new System.Drawing.Size(99, 40);
            this.screenInformationButton.TabIndex = 18;
            this.screenInformationButton.Text = "Screen Information";
            this.screenInformationButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.screenInformationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.screenInformationButton.UseVisualStyleBackColor = true;
            // 
            // securityButton
            // 
            this.securityButton.Image = global::HardekSuite.Properties.Resources.security;
            this.securityButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.securityButton.Location = new System.Drawing.Point(3, 49);
            this.securityButton.Name = "securityButton";
            this.securityButton.Size = new System.Drawing.Size(99, 40);
            this.securityButton.TabIndex = 17;
            this.securityButton.Text = "Security";
            this.securityButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.securityButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.securityButton.UseVisualStyleBackColor = true;
            // 
            // statisticsButton
            // 
            this.statisticsButton.Image = global::HardekSuite.Properties.Resources.statistics;
            this.statisticsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statisticsButton.Location = new System.Drawing.Point(108, 3);
            this.statisticsButton.Name = "statisticsButton";
            this.statisticsButton.Size = new System.Drawing.Size(99, 40);
            this.statisticsButton.TabIndex = 16;
            this.statisticsButton.Text = "Statistics";
            this.statisticsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statisticsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.statisticsButton.UseVisualStyleBackColor = true;
            // 
            // generalGroup
            // 
            this.generalGroup.Controls.Add(this.optionsButton);
            this.generalGroup.Controls.Add(this.statisticsButton);
            this.generalGroup.Controls.Add(this.securityButton);
            this.generalGroup.Controls.Add(this.screenInformationButton);
            this.generalGroup.Location = new System.Drawing.Point(3, 31);
            this.generalGroup.Name = "generalGroup";
            this.generalGroup.Size = new System.Drawing.Size(210, 94);
            this.generalGroup.TabIndex = 20;
            // 
            // bigflow
            // 
            this.bigflow.AutoSize = true;
            this.bigflow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bigflow.Controls.Add(this.generalPanel);
            this.bigflow.Controls.Add(this.shortCutsPanel);
            this.bigflow.Controls.Add(this.corePanel);
            this.bigflow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bigflow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.bigflow.Location = new System.Drawing.Point(0, 0);
            this.bigflow.Name = "bigflow";
            this.bigflow.Size = new System.Drawing.Size(225, 448);
            this.bigflow.TabIndex = 16;
            // 
            // shortCutsPanel
            // 
            this.shortCutsPanel.AutoSize = true;
            this.shortCutsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.shortCutsPanel.Controls.Add(this.shortCutsGroup);
            this.shortCutsPanel.Controls.Add(this.toggleShortcuts);
            this.shortCutsPanel.Controls.Add(this.shortCutsPicture);
            this.shortCutsPanel.Location = new System.Drawing.Point(3, 137);
            this.shortCutsPanel.Name = "shortCutsPanel";
            this.shortCutsPanel.Size = new System.Drawing.Size(216, 128);
            this.shortCutsPanel.TabIndex = 16;
            // 
            // shortCutsGroup
            // 
            this.shortCutsGroup.Controls.Add(this.commandsButton);
            this.shortCutsGroup.Controls.Add(this.contextMenuButton);
            this.shortCutsGroup.Controls.Add(this.hotkeysButton);
            this.shortCutsGroup.Controls.Add(this.iconsButton);
            this.shortCutsGroup.Location = new System.Drawing.Point(3, 31);
            this.shortCutsGroup.Name = "shortCutsGroup";
            this.shortCutsGroup.Size = new System.Drawing.Size(210, 94);
            this.shortCutsGroup.TabIndex = 20;
            // 
            // corePanel
            // 
            this.corePanel.AutoSize = true;
            this.corePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.corePanel.Controls.Add(this.coreGroup);
            this.corePanel.Controls.Add(this.toggleCore);
            this.corePanel.Controls.Add(this.corePicture);
            this.corePanel.Location = new System.Drawing.Point(3, 271);
            this.corePanel.Name = "corePanel";
            this.corePanel.Size = new System.Drawing.Size(216, 165);
            this.corePanel.TabIndex = 17;
            // 
            // coreGroup
            // 
            this.coreGroup.Controls.Add(this.automaticButton);
            this.coreGroup.Controls.Add(this.cavebotButton);
            this.coreGroup.Controls.Add(this.equipsButton);
            this.coreGroup.Controls.Add(this.healingButton);
            this.coreGroup.Controls.Add(this.looterButton);
            this.coreGroup.Controls.Add(this.targetingButton);
            this.coreGroup.Location = new System.Drawing.Point(3, 24);
            this.coreGroup.Name = "coreGroup";
            this.coreGroup.Size = new System.Drawing.Size(210, 138);
            this.coreGroup.TabIndex = 20;
            // 
            // shortCutsPicture
            // 
            this.shortCutsPicture.Image = global::HardekSuite.Properties.Resources.shortcuts;
            this.shortCutsPicture.Location = new System.Drawing.Point(3, 3);
            this.shortCutsPicture.Name = "shortCutsPicture";
            this.shortCutsPicture.Size = new System.Drawing.Size(210, 27);
            this.shortCutsPicture.TabIndex = 10;
            this.shortCutsPicture.TabStop = false;
            this.shortCutsPicture.Click += new System.EventHandler(this.toggleShortcuts_Click);
            // 
            // toggleShortcuts
            // 
            this.toggleShortcuts.Image = global::HardekSuite.Properties.Resources.minimize;
            this.toggleShortcuts.Location = new System.Drawing.Point(204, 3);
            this.toggleShortcuts.Name = "toggleShortcuts";
            this.toggleShortcuts.Size = new System.Drawing.Size(9, 9);
            this.toggleShortcuts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.toggleShortcuts.TabIndex = 9;
            this.toggleShortcuts.TabStop = false;
            this.toggleShortcuts.Click += new System.EventHandler(this.toggleShortcuts_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(225, 448);
            this.Controls.Add(this.bigflow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hardek Suite";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.trayContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toggleCore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleGeneral)).EndInit();
            this.generalPanel.ResumeLayout(false);
            this.generalPanel.PerformLayout();
            this.generalGroup.ResumeLayout(false);
            this.bigflow.ResumeLayout(false);
            this.bigflow.PerformLayout();
            this.shortCutsPanel.ResumeLayout(false);
            this.shortCutsPanel.PerformLayout();
            this.shortCutsGroup.ResumeLayout(false);
            this.corePanel.ResumeLayout(false);
            this.corePanel.PerformLayout();
            this.coreGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shortCutsPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleShortcuts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.Button cavebotButton;
        private System.Windows.Forms.Button equipsButton;
        private System.Windows.Forms.Button automaticButton;
        private System.Windows.Forms.Button healingButton;
        private System.Windows.Forms.Button looterButton;
        private System.Windows.Forms.Button targetingButton;
        private System.Windows.Forms.Button contextMenuButton;
        private System.Windows.Forms.Button hotkeysButton;
        private System.Windows.Forms.Button commandsButton;
        private System.Windows.Forms.Button iconsButton;
        private System.Windows.Forms.PictureBox toggleCore;
        private System.Windows.Forms.PictureBox corePicture;
        private System.Windows.Forms.PictureBox generalPicture;
        private System.Windows.Forms.PictureBox toggleGeneral;
        private System.Windows.Forms.Panel generalPanel;
        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.Button screenInformationButton;
        private System.Windows.Forms.Button securityButton;
        private System.Windows.Forms.Button statisticsButton;
        private System.Windows.Forms.FlowLayoutPanel generalGroup;
        private System.Windows.Forms.FlowLayoutPanel bigflow;
        private System.Windows.Forms.Panel shortCutsPanel;
        private System.Windows.Forms.FlowLayoutPanel shortCutsGroup;
        private System.Windows.Forms.PictureBox toggleShortcuts;
        private System.Windows.Forms.PictureBox shortCutsPicture;
        private System.Windows.Forms.Panel corePanel;
        private System.Windows.Forms.FlowLayoutPanel coreGroup;





    }
}