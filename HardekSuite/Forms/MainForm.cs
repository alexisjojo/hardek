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

        private void MainForm_Load(object sender, EventArgs e) {
            int height = this.Height;
            USkin.USkinSDK.USkinInit("", "", "Skins\\Clearlooks.msstyles");
            this.Height = height;
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e) {
            this.Visible = !this.Visible;
        }

        private void ExitMenu_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }
    }
}

