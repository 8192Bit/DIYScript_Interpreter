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

        private void pictureBoxCurrent_DoubleClick(object sender, EventArgs e) {
            if (!isFullView) {
                this.Height += pictureBoxCurrent.Image.Height - pictureBoxCurrent.Height;
                pictureBoxCurrent.Location.Offset(pictureBoxCurrent.Width - pictureBoxCurrent.Image.Width, 0);

                pictureBoxCurrent.Size = pictureBoxCurrent.Image.Size;
                pictureBoxCurrent.SizeMode = PictureBoxSizeMode.Normal;
                isFullView = true;
            } else {
                pictureBoxCurrent.Size = new Size(100, 100);
                this.Width = 800;
                this.Height = 280;
                isFullView = false;
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
                MessageBox.Show("要添加的帧与帧列表中的大小不匹配。" + "\r" + "是否添加？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

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
