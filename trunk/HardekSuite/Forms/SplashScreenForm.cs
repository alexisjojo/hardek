using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HardekSuite.Forms {
    public partial class SplashScreenForm : Form {
        public SplashScreenForm() {
            InitializeComponent();
        }

        public int Progress {
            get {
                return progressBar.Value;
            }
            set {
                progressBar.Value = value;
            }
        }

        private void SplashScreenForm_Load(object sender, EventArgs e) {
            versionLabel.Text = new Version(Application.ProductVersion).Major + "." + new Version(Application.ProductVersion).Minor;
            System.Drawing.Bitmap Img = (Bitmap)this.BackgroundImage;
            Color color = Img.GetPixel(0, 0);
            Img.MakeTransparent(color);
            this.BackgroundImage = Img;
            this.TransparencyKey = color;
            this.BackColor = color;
        }
    }
}
