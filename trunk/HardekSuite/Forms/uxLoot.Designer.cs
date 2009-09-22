namespace HardekSuite.Forms
{
    partial class uxLoot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uxLoot));
            this.uxList = new System.Windows.Forms.ListView();
            this.uxColumnId = new System.Windows.Forms.ColumnHeader();
            this.uxColumnContainer = new System.Windows.Forms.ColumnHeader();
            this.uxColumnName = new System.Windows.Forms.ColumnHeader();
            this.uxClear = new System.Windows.Forms.Button();
            this.uxDelete = new System.Windows.Forms.Button();
            this.uxOptions = new System.Windows.Forms.GroupBox();
            this.uxEatFromCorpses = new System.Windows.Forms.CheckBox();
            this.uxOpenDistant = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uxOpenBodies = new System.Windows.Forms.ComboBox();
            this.uxEnable = new System.Windows.Forms.CheckBox();
            this.uxLootMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uxValue = new System.Windows.Forms.ToolStripTextBox();
            this.uxContainer = new System.Windows.Forms.ToolStripTextBox();
            this.addIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRatioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxAdd = new System.Windows.Forms.Button();
            this.uxOptions.SuspendLayout();
            this.uxLootMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxList
            // 
            this.uxList.AllowColumnReorder = true;
            this.uxList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.uxColumnId,
            this.uxColumnContainer,
            this.uxColumnName});
            this.uxList.FullRowSelect = true;
            this.uxList.GridLines = true;
            this.uxList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.uxList.Location = new System.Drawing.Point(12, 12);
            this.uxList.Name = "uxList";
            this.uxList.Size = new System.Drawing.Size(254, 220);
            this.uxList.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.uxList.TabIndex = 2;
            this.uxList.UseCompatibleStateImageBehavior = false;
            this.uxList.View = System.Windows.Forms.View.Details;
            // 
            // uxColumnId
            // 
            this.uxColumnId.Text = "ItemID";
            this.uxColumnId.Width = 50;
            // 
            // uxColumnContainer
            // 
            this.uxColumnContainer.Text = "Container";
            this.uxColumnContainer.Width = 61;
            // 
            // uxColumnName
            // 
            this.uxColumnName.Text = "Name";
            this.uxColumnName.Width = 127;
            // 
            // uxClear
            // 
            this.uxClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxClear.Location = new System.Drawing.Point(142, 267);
            this.uxClear.Name = "uxClear";
            this.uxClear.Size = new System.Drawing.Size(124, 23);
            this.uxClear.TabIndex = 17;
            this.uxClear.Text = "Clear List";
            this.uxClear.UseVisualStyleBackColor = true;
            this.uxClear.Click += new System.EventHandler(this.uxClear_Click);
            // 
            // uxDelete
            // 
            this.uxDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDelete.Location = new System.Drawing.Point(12, 267);
            this.uxDelete.Name = "uxDelete";
            this.uxDelete.Size = new System.Drawing.Size(124, 23);
            this.uxDelete.TabIndex = 16;
            this.uxDelete.Text = "Delete Selected";
            this.uxDelete.UseVisualStyleBackColor = true;
            this.uxDelete.Click += new System.EventHandler(this.uxDelete_Click);
            // 
            // uxOptions
            // 
            this.uxOptions.Controls.Add(this.uxEatFromCorpses);
            this.uxOptions.Controls.Add(this.uxOpenDistant);
            this.uxOptions.Controls.Add(this.label1);
            this.uxOptions.Controls.Add(this.uxOpenBodies);
            this.uxOptions.Controls.Add(this.uxEnable);
            this.uxOptions.Location = new System.Drawing.Point(13, 296);
            this.uxOptions.Name = "uxOptions";
            this.uxOptions.Size = new System.Drawing.Size(254, 91);
            this.uxOptions.TabIndex = 18;
            this.uxOptions.TabStop = false;
            this.uxOptions.Text = "Options";
            // 
            // uxEatFromCorpses
            // 
            this.uxEatFromCorpses.AutoSize = true;
            this.uxEatFromCorpses.Location = new System.Drawing.Point(9, 65);
            this.uxEatFromCorpses.Name = "uxEatFromCorpses";
            this.uxEatFromCorpses.Size = new System.Drawing.Size(105, 17);
            this.uxEatFromCorpses.TabIndex = 22;
            this.uxEatFromCorpses.Text = "Eat from corpses";
            this.uxEatFromCorpses.UseVisualStyleBackColor = true;
            this.uxEatFromCorpses.CheckedChanged += new System.EventHandler(this.uxEatFromCorpses_CheckedChanged);
            // 
            // uxOpenDistant
            // 
            this.uxOpenDistant.AutoSize = true;
            this.uxOpenDistant.Location = new System.Drawing.Point(9, 46);
            this.uxOpenDistant.Name = "uxOpenDistant";
            this.uxOpenDistant.Size = new System.Drawing.Size(120, 17);
            this.uxOpenDistant.TabIndex = 21;
            this.uxOpenDistant.Text = "Open distant bodies";
            this.uxOpenDistant.UseVisualStyleBackColor = true;
            this.uxOpenDistant.CheckedChanged += new System.EventHandler(this.uxOpenDistant_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Open Bodies:";
            // 
            // uxOpenBodies
            // 
            this.uxOpenBodies.FormattingEnabled = true;
            this.uxOpenBodies.Items.AddRange(new object[] {
            "All",
            "Allowed",
            "Filtered",
            "None"});
            this.uxOpenBodies.Location = new System.Drawing.Point(83, 19);
            this.uxOpenBodies.Name = "uxOpenBodies";
            this.uxOpenBodies.Size = new System.Drawing.Size(165, 21);
            this.uxOpenBodies.TabIndex = 19;
            this.uxOpenBodies.SelectedIndexChanged += new System.EventHandler(this.uxOpenBodies_SelectedIndexChanged);
            // 
            // uxEnable
            // 
            this.uxEnable.AutoSize = true;
            this.uxEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEnable.Location = new System.Drawing.Point(178, 65);
            this.uxEnable.Name = "uxEnable";
            this.uxEnable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uxEnable.Size = new System.Drawing.Size(70, 20);
            this.uxEnable.TabIndex = 16;
            this.uxEnable.Text = "Enable";
            this.uxEnable.UseVisualStyleBackColor = true;
            this.uxEnable.CheckedChanged += new System.EventHandler(this.uxEnable_CheckedChanged);
            // 
            // uxLootMenu
            // 
            this.uxLootMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxValue,
            this.uxContainer,
            this.addIDToolStripMenuItem,
            this.addRatioToolStripMenuItem});
            this.uxLootMenu.Name = "uxLootMenu";
            this.uxLootMenu.Size = new System.Drawing.Size(161, 94);
            // 
            // uxValue
            // 
            this.uxValue.ForeColor = System.Drawing.SystemColors.GrayText;
            this.uxValue.Name = "uxValue";
            this.uxValue.Size = new System.Drawing.Size(100, 21);
            this.uxValue.Tag = "Value";
            this.uxValue.Text = "Value";
            this.uxValue.Leave += new System.EventHandler(this.uxValue_Leave);
            this.uxValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uxValue_KeyDown);
            this.uxValue.Enter += new System.EventHandler(this.uxValue_Enter);
            // 
            // uxContainer
            // 
            this.uxContainer.ForeColor = System.Drawing.SystemColors.GrayText;
            this.uxContainer.Name = "uxContainer";
            this.uxContainer.Size = new System.Drawing.Size(100, 21);
            this.uxContainer.Tag = "Container";
            this.uxContainer.Text = "Container";
            this.uxContainer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uxContainer_KeyDown);
            this.uxContainer.Enter += new System.EventHandler(this.uxValue_Enter);
            // 
            // addIDToolStripMenuItem
            // 
            this.addIDToolStripMenuItem.Name = "addIDToolStripMenuItem";
            this.addIDToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.addIDToolStripMenuItem.Text = "Add ID";
            this.addIDToolStripMenuItem.Click += new System.EventHandler(this.addIDToolStripMenuItem_Click);
            // 
            // addRatioToolStripMenuItem
            // 
            this.addRatioToolStripMenuItem.Name = "addRatioToolStripMenuItem";
            this.addRatioToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.addRatioToolStripMenuItem.Text = "Add Ratio";
            this.addRatioToolStripMenuItem.Click += new System.EventHandler(this.addRatioToolStripMenuItem_Click);
            // 
            // uxAdd
            // 
            this.uxAdd.Location = new System.Drawing.Point(12, 238);
            this.uxAdd.Name = "uxAdd";
            this.uxAdd.Size = new System.Drawing.Size(255, 23);
            this.uxAdd.TabIndex = 20;
            this.uxAdd.Text = "Add Loot";
            this.uxAdd.UseVisualStyleBackColor = true;
            this.uxAdd.Click += new System.EventHandler(this.uxAdd_Click);
            // 
            // uxLoot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 398);
            this.Controls.Add(this.uxAdd);
            this.Controls.Add(this.uxOptions);
            this.Controls.Add(this.uxList);
            this.Controls.Add(this.uxClear);
            this.Controls.Add(this.uxDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "uxLoot";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Looter";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.uxLoot_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.uxLoot_FormClosing);
            this.uxOptions.ResumeLayout(false);
            this.uxOptions.PerformLayout();
            this.uxLootMenu.ResumeLayout(false);
            this.uxLootMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView uxList;
        private System.Windows.Forms.ColumnHeader uxColumnId;
        private System.Windows.Forms.ColumnHeader uxColumnContainer;
        private System.Windows.Forms.ColumnHeader uxColumnName;
        private System.Windows.Forms.Button uxClear;
        private System.Windows.Forms.Button uxDelete;
        private System.Windows.Forms.GroupBox uxOptions;
        private System.Windows.Forms.CheckBox uxEnable;
        private System.Windows.Forms.ComboBox uxOpenBodies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox uxEatFromCorpses;
        private System.Windows.Forms.CheckBox uxOpenDistant;
        private System.Windows.Forms.ContextMenuStrip uxLootMenu;
        private System.Windows.Forms.ToolStripTextBox uxValue;
        private System.Windows.Forms.ToolStripTextBox uxContainer;
        private System.Windows.Forms.ToolStripMenuItem addIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRatioToolStripMenuItem;
        private System.Windows.Forms.Button uxAdd;
    }
}