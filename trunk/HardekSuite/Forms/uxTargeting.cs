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
    public partial class uxTargeting : Form
    {
        public uxTargeting()
        {
            InitializeComponent();
        }

        private void uxTargeting_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
