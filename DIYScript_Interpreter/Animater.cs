using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DIYScript_Interpreter {
    public partial class Animater : Form {
        public bool isFullView;
        public bool isFirstAdd;
        public bool isFromFront;
        public Animater() {
            InitializeComponent();
        }

        private void pictureBoxCurrent_Click(object sender, EventArgs e) {
            if (isFullView) {
                this.Width += pictureBoxCurrent.Image.Height - pictureBoxCurrent.Height;
                pictureBoxCurrent.Size = pictureBoxCurrent.Image.Size;
            }
        }

        private void ButtonAddBefore_Click(object sendor, EventArgs e) {
            openFileDialog.ShowDialog();
            isFromFront = true;
        }

        private void openFileDialog_FileOK(object sendor, CancelEventArgs e) {
            Image i = (Image)new Bitmap(openFileDialog.FileName);
            if (isFirstAdd) {
                imageList.ImageSize = i.Size;
            } else if (i.Size != imageList.ImageSize) {

            }
        }

        private void Animater_Load(object sender, EventArgs e) {

        }

        private void buttonAddAfter_Click(object sender, EventArgs e) {

            openFileDialog.ShowDialog();
            isFromFront = false;
        }
    }
}
